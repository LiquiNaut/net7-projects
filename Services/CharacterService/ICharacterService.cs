using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net7.Controllers.Models;

namespace net7.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}