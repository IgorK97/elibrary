using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverter
{
    internal class DocumentConversionOptions
    {
        public required string InputFormat { get; set; }
        public required string OutputFormat { get; set; }
        public Dictionary<string, string>? MetadataVariables { get; set; }
        public string? TemplatePath { get; set; }

    }
}
