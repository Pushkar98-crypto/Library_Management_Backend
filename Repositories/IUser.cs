using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_mangement_backend.Models;




namespace Library_mangement_backend.Repositories
{
   public  interface IUser
    {
        Task <IEnumerable<User>> Get();

        Task<User> Get(int userId);

        Task<User> Create(User user);

        Task<User> GetAuth(User user);
    }
}
