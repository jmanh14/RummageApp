using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RummageApp.Data;
using RummageApp.Models;

namespace RummageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RummageController : ControllerBase
    {
        private ApplicationDbContext _context;
        public RummageController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET api/rummage
        [HttpGet]
        public IEnumerable<Rummage> Get()
        {
            return _context.Rummage.ToList();
        }

        ////GET api/rummage/1
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{

        //}
    }
}