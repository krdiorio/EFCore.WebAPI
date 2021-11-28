using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class Context : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=bru12051;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=.\");
            
        }


    }





}