using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime? PublishedDate { get; set; }
        public string? ISBN { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public string? CoverPath { get; set; }
        public string? FilePath { get; set; }
        public int? BBKId { get; set; }
        public int? UDKId { get; set; }
    }
}
