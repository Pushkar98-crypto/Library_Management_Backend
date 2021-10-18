using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_mangement_backend.Models
{
    public class BooksCart
    {
        [ForeignKey("cartId")]
        public  int? cartId { get; set; }

        public virtual User User { get; set; }

       
        [Key]
        public  int bookId { get; set; }


        
    }
}
