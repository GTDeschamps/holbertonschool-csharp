using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name;

        public Zombie()
        {
            health = 0;
            name = "No Name";
        }

        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
                name = "(No Name)";
            }
            else
            {
            throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
