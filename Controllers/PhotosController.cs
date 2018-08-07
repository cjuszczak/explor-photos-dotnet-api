using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using explorphotosdotnetapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace explorphotosdotnetapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : Controller
    {
        private readonly ExplorContext _context;

        public PhotosController(ExplorContext context)
        {
            _context = context;
        }

        // GET: api/photos
        [HttpGet]
        public ActionResult<Photo> Get()
        {
            var photos = _context.Photos;

            return Ok(_context.Photos);
        }

        // GET api/photos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> Get(int id)
        {
            var photo = await _context.Photos.SingleOrDefaultAsync(p => p.photoId == id);

            return Ok(photo);
        }

        // POST api/photos
        [HttpPost]
        public async Task<ActionResult<Photo>> Post(Photo photo)
        {
            _context.Photos.Add(photo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhoto", new { id = photo.photoId }, photo);
        }

        // PUT api/photos/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Photo>> Put(int id, Photo photo)
        {
            _context.Entry(photo).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(photo);
        }

        // DELETE api/photos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Photo>> Delete(int id)
        {
            var photo = await _context.Photos.SingleOrDefaultAsync(p => p.photoId == id);

            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();

            return Ok(photo);
        }
    }
}
