using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace elibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly string _bookDir;
        public BooksController(IWebHostEnvironment env)
        {
            _bookDir = Path.Combine(env.ContentRootPath, "Books");
            if (!Directory.Exists(_bookDir))
            {
                Directory.CreateDirectory(_bookDir);
            }
        }

        [HttpGet("read/{fileName}")]
        public async Task<IActionResult> Read(string fileName)
        {
            if (!Request.Headers.TryGetValue("Authorization", out var auth) || auth != "Bearer secret-token")
                return Unauthorized("Missing or invalid Authorization header");

            fileName = Path.GetFileName(fileName); // Prevent path traversal
            if(!fileName.EndsWith(".epub", StringComparison.OrdinalIgnoreCase))
            {
                fileName+= ".epub";
            }

            var epubPath = Path.Combine(_bookDir, fileName);
            if(!System.IO.File.Exists(epubPath))
            {
                return NotFound("File not found");
            }
            // Замените строку:
            // HttpContext.Features.Get<IHttpResponseFeature>()?.DisableBuffering();
            // на:

            //HttpContext.Response.Body.Flush();

            //HttpContext.Features.Get<IHttpResponseFeature>()?.DisableBuffering();
            Response.ContentType = "application/pdf";
            Response.Headers["Content-Disposition"] = $"inline; filename=\"{Path.GetFileNameWithoutExtension(fileName)}.pdf\"";
            Response.Headers["Cache-Control"] = "no-store";
            Response.Headers["X-Content-Type-Options"] = "nosniff";

            var psi = new ProcessStartInfo
            {
                FileName = "pandoc",
                Arguments = $"\"{epubPath}\" -f epub -t pdf -o -",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            using var process = Process.Start(psi);
            if (process == null)
            {
                return StatusCode(500, "Failed to start pandoc");
            }
            try
            {
                await process.StandardOutput.BaseStream.CopyToAsync(Response.Body, 81920, HttpContext.RequestAborted);
                await process.WaitForExitAsync(HttpContext.RequestAborted);

                var err = await process.StandardError.ReadToEndAsync();
                if (process.ExitCode != 0)
                {
                    Console.Error.WriteLine("Pandoc error: " + err);
                }
            }
            catch (OperationCanceledException)
            {
                try { process.Kill(true); } catch { }
            }
            return new EmptyResult();
        }
    }
}
