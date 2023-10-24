using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using net7.Controllers.Models;

namespace net7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Name = "Samo"}
        };
        
        [HttpGet]
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }
    }
}