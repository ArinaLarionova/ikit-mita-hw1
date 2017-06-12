using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    public class Cat
    {
        
        private string _name;
        private int _health;

        public Cat(int age, int health)
        {
            Age = age;
            _health = health;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
            get { return _name; }
        }
        
        public int Age { get; private set; }

        public string Feed()
        {
            _health = _health + 1;
            return "I like it!";
        }

        public string Punish()
        {
            _health = _health - 1;
            return "I don't like it!";
        }

        public string Color
        {
            get
            {
                if (_health > 5)
                {
                    return "Green";
                }
                if (_health == 5)
                {
                    return "Yellow";
                }
                return "Red";
            }
        }
    }
}
