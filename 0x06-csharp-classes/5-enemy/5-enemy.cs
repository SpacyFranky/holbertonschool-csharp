using System;

/*
    The main Enemies class
*/ 
namespace Enemies
{
    //  Creating an empty public class Zombie.
    /// <summary>
    /// Creating an empty public class Zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Defining the class Zombie by a public filed.
        /// </summary>
        public int health;

        /// <summary>
        /// Defining the class Zombie by a public constructor.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Checks if health is equal or greater than 0.
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        // Private field name for the Zombie object.
        private string _name = "(No name)";

        /// <summary>
        /// Public property name for the Zombie object.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Returns the value of health of the Zombie object.
        /// </summary>
        public int GetHealth()
        {
            return(health);
        }

        /// <summary>
        /// Prints the Zombie object's attributes to stdout
        /// </summary>
        public override string ToString()
        {
            return("Zombie name: " + Name + " / Total Health: " + GetHealth());
        }
    }

}
