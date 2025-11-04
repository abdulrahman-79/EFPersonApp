using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFPersonApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> EfPerson { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + @"D:\Luftborn\SqliteDatabases\People.db");
        }
    }
}