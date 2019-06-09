using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
public class WishlistControler : ControllerBase{
        private readonly MoviesContext _context;
        public WishlistControler (MoviesContext context) {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wishlist>>> GetWishlist () {
            return await _context.Wishlist.ToListAsync ();
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Wishlist>> GetWishlist (int id) {
            Wishlist item = await _context.Wishlist.FindAsync (id);

            if (item == null) {
                return NotFound ();
            }

            return item;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Wishlist>> PostWishlist (Wishlist item) {
            _context.Wishlist.Add (item);
            await _context.SaveChangesAsync ();

            return CreatedAtAction (
                nameof (GetWishlist),
                item);
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteWishlist(int id) {
            Wishlist model = await _context.Wishlist.FindAsync (id);

            if (model == null) {
                return NotFound ();
            }

            _context.Wishlist.Remove (model);
            await _context.SaveChangesAsync ();

            return Content ("The Movie has been deleted from your wishlist");
        }
    }
}