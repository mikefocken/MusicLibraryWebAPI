using Microsoft.EntityFrameworkCore;
using MusicLibraryBackendProject.Models;


namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
