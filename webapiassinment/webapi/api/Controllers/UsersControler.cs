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
public class UsersControler : ControllerBase{

    private readonly MoviesContext _context; 

    public UsersControler(MoviesContext context){
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Users>>> GetUsers(){
        return await _context.Users.ToListAsync();
    } 
   [HttpGet("{id}")]
   public async Task<ActionResult<Users>> GetUsers(int id){
       Users item = await _context.Users.FindAsync(id);

       if(item == null){
           return NotFound();
       }

       return item;
   }

 


    [HttpPut ("{id}")]

    public async Task<IActionResult> UsersPut (int id, Users item){
        if (id != item.Id){ return BadRequest();}
        _context.Entry (item).State = EntityState.Modified;
            await _context.SaveChangesAsync ();

        return Content("Users details has been updated. Thank You");
    }
}

}
