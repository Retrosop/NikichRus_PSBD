using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHB.Models
{
   public class Heroes
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }
        public string HeroClass { get; set; }
        public string HeroRace { get; set; }


    }
}
