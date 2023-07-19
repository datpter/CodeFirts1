using CodeFirts1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirts1.Data
{
    public class DataContext : DbContext
    {


        private readonly string _connectionString = "Server=LAPTOP-HP52IBIJ\\SQLEXPRESS; Database=Exam3; User Id=sa; Password=12345678; Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Student>Students { get; set; }

    }
}
