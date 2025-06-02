using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController: ControllerBase
    {
        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand 1", Color = "red", Gender = "men", Price = 150, Size = 9},
            new Shirt {ShirtId = 2, Brand = "My Brand 2", Color = "blu", Gender = "women", Price = 150, Size = 5},
            new Shirt {ShirtId = 3, Brand = "My Brand 3", Color = "green", Gender = "men", Price = 150, Size = 7},
            new Shirt {ShirtId = 4, Brand = "My Brand 4", Color = "orange", Gender = "women", Price = 150, Size = 6},
            new Shirt {ShirtId = 5, Brand = "My Brand 5", Color = "yellow", Gender = "men", Price = 150, Size = 11},
        };

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Reading all the shirts");
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var shirt = shirts.FirstOrDefault(x => x.ShirtId == id);
            if (shirt == null)
                return NotFound();
            return Ok(shirt);
        }

        [HttpPost]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            return "Creating a shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating a shirt: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt: {id}";
        }
    }
}
