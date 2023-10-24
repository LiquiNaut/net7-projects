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
        
        //("GetAllChar") v [HttpGet("GetAllChar")] musime definovat, lebo su 2 get metody
        [HttpGet("GetAllChar")]
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingleChar(){
            return Ok(characters[0]);
        }
    }
}