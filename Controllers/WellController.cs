using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WellController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Well> Get()
        {
            Well[] wells = null;
            using (var context = new ApplicationDbContext())
            {
                wells = context.Wells.ToArray();
            }
            return wells;

        }
        [HttpPost]
        public Well Post([FromBody]Well well)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Wells.Add(well);
                context.SaveChanges();
            }
            return well;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var well = context.Wells.Find(id);
                if (well == null) return NotFound();
                context.Remove(well);
                context.SaveChanges();
                return NoContent();
            }
        }
    }
}
