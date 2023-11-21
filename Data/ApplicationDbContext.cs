using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using MusicLibraryBackendProject.Models;
using Org.BouncyCastle.Asn1.Cmp;


namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    ///configure the song entity 

        //    modelBuilder.Entity<Song>().HasData(
        //        new Song
        //        {
        //            Id = 30,
        //            Title = "A way back home",
        //            Artist = "unknow",
        //            Album = "Sea Change",
        //            ReleaseDate = newDateTime(2002,1,1),
        //            Genre = "Alternative",
        //            Likes = 0

        //        });



        //}








    }





}
