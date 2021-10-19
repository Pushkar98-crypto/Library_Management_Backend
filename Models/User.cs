using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_mangement_backend.Models
{
    public class User
    {
        [Key]
        [Required]
        public int userId { get; set; }

   
        public string firstName { get; set; }

       
        public string lastName { get; set; }


        public string address { get; set; }

        public int pincode { get; set; }

       
        public string phoneNumber { get; set; }

        public  string typeUser { get; set; }

        [Required]
        public string email { get; set; }

        [Required]

        public string password { get; set; }

        

    }
}
