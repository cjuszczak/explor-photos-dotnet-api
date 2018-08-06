using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using explorphotosdotnetapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace explorphotosdotnetapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PhotosController : Controller
    {
        private readonly ExplorContext _context;

        public PhotosController(ExplorContext context)
        {
            _context = context;
        }

        // GET: api/photos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/photos/5
        [HttpGet("{id}")]
        public string Get([FromRoute] int id)
        {
            return "value";
        }

        // POST api/photos
        [HttpPost]
        public IActionResult Post([FromBody] Object obj)
        {
            return Ok();
        }

        // PUT api/photos/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Object obj)
        {
            return Ok();
        }

        // DELETE api/photos/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
