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


        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            //staci pridat ! ((null-forgiving) operator) na koniec vyrazu
            //return characters.FirstOrDefault(c => c.Id == id)!;
            
            //alebo to osetrit cez throw Exception
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is not null){
                return character;
            }
            throw new Exception("Character not found");
        }
    }
}