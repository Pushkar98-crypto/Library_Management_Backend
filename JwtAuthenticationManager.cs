using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_mangement_backend
{
   public  interface JwtAuthenticationManager
    {
        public string Authenticate(string email, string password);
    
    }
}
