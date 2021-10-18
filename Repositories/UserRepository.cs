using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library_mangement_backend.Models;

namespace Library_mangement_backend.Repositories
{


    public class UserRepository : IUser
    {

        public readonly LibContext _context;


        public UserRepository(LibContext libcontext)
        {
            _context = libcontext;
        }



        public async Task<User> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
            
        }

        public  async Task<IEnumerable<User>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        public  async Task<User> Get(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAuth(string email)
        {
            return await _context.Users.ToListAsync();
        }

        
    }
}
