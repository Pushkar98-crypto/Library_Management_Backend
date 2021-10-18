using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library_mangement_backend.Models;

namespace Library_mangement_backend
{
    public class LibContext:DbContext
    {

        public LibContext(DbContextOptions<LibContext> options) : base(options)
        {
            
        }

        public DbSet<Books>Books { get; set; }

        public DbSet<BooksCart>BooksCarts { get; set; }

        public DbSet<Library>Libraries { get; set; }

        public DbSet<User>Users { get; set; }

    }
}
