using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ATMController : ControllerBase
    {
       private readonly DataContext _context;
     
       public ATMController(DataContext context) 
       {
          _context = context;
       }
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardType>>> GetCardTypes()
       {
           
             return Ok(await _context.CardTypesTbl.ToListAsync());
        
       }
    }
        
}

