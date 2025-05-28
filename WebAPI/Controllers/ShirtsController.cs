﻿using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading shirt: {id}";
        }

        [HttpPost]
        [Route("/shirts")]
        public string CreateShirt()
        {
            return "Creating a shirt";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating a shirt: {id}";
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt: {id}";
        }
    }
}
