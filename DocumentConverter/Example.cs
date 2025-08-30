using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentConverter;

namespace DocumentConverter
{
    internal class Example
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            IDocumentConverter converter = new PandocDocumentConverter();
            if (args.Length == 0)
            {
                string inputFilePath = "C:\\Users\\IgorA\\source\\repos\\MyProjects\\FileConverter\\austen-pride-and-prejudice-illustrations.epub";
                string outputFilePath = "example.pdf";
                DocumentConversionOptions options = new DocumentConversionOptions
                {
                    InputFormat = "epub",
                    OutputFormat = "pdf",
                    MetadataVariables = new Dictionary<string, string>
                {
                    { "title", "Sample Document" },
                    { "author", "John Doe" },
                    { "geometry:margin", "2cm" }
                },
                    TemplatePath = null
                };
                bool success = converter.Convert(inputFilePath, outputFilePath, options);
                Console.WriteLine(success
                    ? $"Conversion succeeded: {outputFilePath}"
                    : "Conversion failed.");
            }
            else if (args.Length == 2)
            {
                string inputFilePath = args[0];
                string outputFilePath = args[1];
                bool success = converter.Convert(inputFilePath, outputFilePath, null);
                Console.WriteLine(success
                    ? $"Conversion succeeded: {outputFilePath}"
                    : "Conversion failed.");
            }
            else if (args.Length > 2)
            {
                string inputFilePath = args[0];
                string outputFilePath = args[1];
                var options = new DocumentConversionOptions
                {
                    InputFormat = args[2],
                    OutputFormat = args[3],
                    MetadataVariables = new Dictionary<string, string>()
                };
                for (int i = 4; i < args.Length; i++)
                {
                    if (args[i] == "-v" && i + 1 < args.Length)
                    {
                        string[] parts = args[i + 1].Split('=', 2); // разбиваем только по первому "="
                        if (parts.Length == 2)
                        {
                            options.MetadataVariables[parts[0]] = parts[1];
                        }
                        i++;
                    }
                    else if (args[i] == "-template" && i + 1 < args.Length)
                    {
                        options.TemplatePath = args[i + 1];
                        i++;
                    }
                }
                bool success = converter.Convert(inputFilePath, outputFilePath, options);

                Console.WriteLine(success
                    ? $"Conversion succeeded: {outputFilePath}"
                    : "Conversion failed.");
            }
            else
            {
                Console.WriteLine("Usage: DocumentConverterApp <inputFilePath> <outputFilePath> -v <variable1> -v <variable2> ,,, -template <templatefile>");
            }

        }

    }
}