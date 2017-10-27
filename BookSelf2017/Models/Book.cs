using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookSelf2017.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2), MaxLength(50)]
        public string Title { get; set; }
        [Display(Name ="Published Date")]
        public DateTime PublishedDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
      //  [Required]
        public string ISBN { get; set; }

        [ForeignKey("Catagory")] [Display(Name ="Category")]
  public int CatagoryID { get; set; } 
        public virtual Catagory Catagory  { get; set; }




    }
}