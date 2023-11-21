using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MusicLibraryBackendProject.Models;
using MusicLibraryWebAPI.Data;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return  Ok (songs);
        }

        // GET api/Songs
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Find(id);

            return Ok (song);
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201,song);
        }

        // PUT api/Songs
        [HttpPut("{id}")]
        public IActionResult Put (int id, [FromBody] Song song)
        {
            var songFromDb= _context.Songs.Find(id);

            if (songFromDb == null) 
            {
                return NotFound();
            }


            ////update these properties
            songFromDb.Title=song.Title;
            songFromDb.Artist=song.Artist;
            songFromDb.Album=song.Album;
            songFromDb.ReleaseDate =song.ReleaseDate;
            songFromDb.Genre=song.Genre;
            songFromDb.Likes=song.Likes;
           
            if (song.Likes>=0)
            {
                songFromDb.Likes = song.Likes;
            }

            _context.Songs.Update(songFromDb);
            _context.SaveChanges();

            return StatusCode (201,songFromDb);


        }

        // DELETE api/Songs
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
          var songFromDb = _context.Songs.Find(id);

            if (songFromDb == null)
            {
                return NotFound();
            }

            _context.Songs.Remove(songFromDb);
            _context.SaveChanges();


            return NotFound();
        
        }





    }





}
