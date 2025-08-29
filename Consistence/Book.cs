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
        public long? PublisherId { get; set; }
        public int? BBKId { get; set; }
        public int? UDKId { get; set; }
        public bool IsHidden { get; set; }
        public ICollection<Creation> Creations { get; set; } = [];
        public ICollection<CreationBook> CreationBooks { get; set; } = [];
        public BBK? BBK { get; set; }
        public UDK? UDK { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = [];
        public Publisher? Publisher { get; set; }
        public ICollection<Category> Categories { get; set; } = [];
        public ICollection<Agreement> Agreements { get; set; } = [];
        public ICollection<Submission> Submissions { get; set; } = [];
    }
}
