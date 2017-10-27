using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookSelf2017.Models
{
    public class BookSelf2017Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BookSelf2017Context() : base("name=BookSelf2017Context")
        {
        }

        public System.Data.Entity.DbSet<BookSelf2017.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<BookSelf2017.Models.Catagory> Catagories { get; set; }
    }
}
