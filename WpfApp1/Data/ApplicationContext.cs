using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ContactInfo> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            if(Database.EnsureCreated())
            {
                
            }
            Contacts.Load();
            Departments.Load();
            Users.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=main.db");
        }
    }
}
