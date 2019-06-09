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
public class MoviesControler : ControllerBase{

    private readonly MoviesContext _context; 

    public MoviesControler(MoviesContext context){
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movies>>> GetMovies(){
        return await _context.Movies.ToListAsync();
    } 
    [HttpGet("{id}")]

    public async Task<ActionResult<Movies>> GetMovies(int id){
        Movies item = await _context.Movies.FindAsync(id);

        if (item == null){
            return NotFound();
        }

        return item;
    }
}

}
