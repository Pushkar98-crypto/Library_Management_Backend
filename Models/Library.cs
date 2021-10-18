using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_mangement_backend.Models
{
    public class Library
    {
        [ForeignKey("bookId")]
        public int? bookId { get; set; }

        public virtual Books Books { get; set; }

        [ForeignKey("userId")]
        [Key]
        public int? userId { get; set; }
        public virtual User User { get; set; }





    }
}
