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
    }

}
