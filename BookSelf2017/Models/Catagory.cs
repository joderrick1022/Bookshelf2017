using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookSelf2017.Models
{
    public class Catagory
    {

        [Key]
        public int ID { get; set; }
        [Display(Name ="Category")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }  
    }
