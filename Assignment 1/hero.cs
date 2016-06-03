using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * author Shahzaib Malik
 * student id 300852792 
 */
namespace Assignment_1
{
    class hero
    {
        // private instance variables
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        // public property
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        /** constructor which takes a single argument which is a name as a string
         * and passes it to the name property
         */  
        
        public hero(string name)
        {
           
            this.Name = name;
            
        }
        public static void Fight()
        {
             
        }
        public void show()
        {
            _generateAbilities();
        }
        private void _generateAbilities()
        {
            Random randomInt = new Random();
            _strength = randomInt.Next(1,100);
            _speed = randomInt.Next(1,100);
            _health = randomInt.Next(1,100);
            Console.WriteLine("your hero has been created with strength {0},speed {1} and a health of {2}",_strength,_speed,_health);
        }
        private bool _hitAttempt()
        {
            return true;
        } 
        private int _hitDamage()
        {
            return 1;
        }
    }
}
