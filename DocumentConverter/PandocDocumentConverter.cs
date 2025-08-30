using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverter
{
    internal class PandocDocumentConverter :IDocumentConverter
    {
        public readonly string _pandocPath;
        public PandocDocumentConverter(string pandocPath = "pandoc")
        {
            _pandocPath = pandocPath;
        }
        public bool Convert(string inputFilePath, string outputFilePath, DocumentConversionOptions? options)
        {

            //var args = $"\"{inputFilePath}\" -o \"{outputFilePath}\"";
            //var args = $"\"{_pandocPath}\"";
            //var args = "";
            var args = $"\"{inputFilePath}\"";

            if (options is null)
            {
                args += $" -o \"{outputFilePath}\"";
            }
            else
            {
                args += $" -f {options.InputFormat} -t {options.OutputFormat} -o \"{outputFilePath}\"";
                if (options.MetadataVariables is not null)
                {
                    foreach (var kv in options.MetadataVariables)
                    {
                        args += $" -V {kv.Key}=\"{kv.Value}\"";
                    }
                }
                if (!string.IsNullOrEmpty(options.TemplatePath))
                {
                    args += $" --template \"{options.TemplatePath}\"";
                }
            }


            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _pandocPath,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            return process.ExitCode == 0;
        }
    }
}
