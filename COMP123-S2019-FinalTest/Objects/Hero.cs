using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: RAFAEL RODRIGUES DE AGUIAR
 * STUDENT ID: 301041266
 * DESCRIPTION: This is the Hero Data Container Class
 * 
 */ 
namespace COMP123_S2019_FinalTest.Objects
{
    class Hero
    {
        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //Physical Abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        //Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }

        //Power List
        List<Power> Powers;

        // Constructor
        Hero()
        {
            //Instantiates an empty Power List
            Powers = new List<Power>();
        }
    }
}
