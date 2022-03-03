//Jesus Bustillos
//ITSE 1430
//02/17/2022


namespace CharacterCreater.ConsoleHost
{
    internal class Character
    {
        
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
        public int _attributes;
        public string _description;

       
    }
}

