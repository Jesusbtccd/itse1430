using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jesus_Bustillos.AdventureGame.Winhost
{
    class Character
    {


        //public Character ()
        //{
        //}

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _name;

        public string _profession;
        public string _race;
        public int _strength;
        public int _intelligence;
        public int _agility;
        public int _constitution;
        public int _charisma;
        public string _description;


    }
}
