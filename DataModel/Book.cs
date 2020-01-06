using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.DataModel
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
    }
}
