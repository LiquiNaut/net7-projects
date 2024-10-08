using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net7.Controllers.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Boris";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        //getter, setter pre enum triedu s default hodnotou.
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}