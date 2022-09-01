using MarvelMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MarvelMVC.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        } 
        public DbSet<UserData> UserDataTable {get; set;}
    }
}