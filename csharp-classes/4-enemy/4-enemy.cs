using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name;

        public Zombie()
        {
            this.health = 0;
            this.name = "No Name";
        }

        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
                name = "No Name";
            }
            else
            {
            throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
