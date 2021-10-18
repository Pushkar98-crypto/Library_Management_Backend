using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_mangement_backend.Models
{
    public class Books
    {
        [ForeignKey("bookId")]
        [Key]
        public int bookId { get; set; }

        public virtual BooksCart BooksCart { get; set; }

        [Required]
        public  string bookTitle { get; set; }

        public string Author { get; set; }

        public string bookType { get; set; }

        public string bookDescription { get; set; }

    }
}
