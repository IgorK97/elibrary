using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoryBook
    {
        public int CategoryId{get;set;}
        public Category Category { get; set; } = null!;
        public long BookId{get;set; }
        public Book Book { get; set; } = null!;


    }
}
