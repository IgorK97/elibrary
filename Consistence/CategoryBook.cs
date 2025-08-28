using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class CategoryBook
    {
        public int CategoryId{get;set;}
        public long BookId{get;set; }
        public Category Category { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
