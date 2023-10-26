using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net7.Controllers.Models;

namespace net7.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Id = 1, Name = "Samo"}
        };


        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>
            {
                Data = characters
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {

            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;

            //staci pridat ! ((null-forgiving) operator) na koniec vyrazu
            //return characters.FirstOrDefault(c => c.Id == id)!;
            //alebo to osetrit cez throw Exception
            /* dodatocne toto nie je potrebne kedze mame generic wrapper response aj null-ovi
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is not null){
                return character;
            }
            throw new Exception("Character not found");
            */
        }
    }
}