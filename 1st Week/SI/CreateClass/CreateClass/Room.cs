using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        private int number;
        private Random rnd = new Random();

        public Room()
        {
            this.number = rnd.Next(101);
        }

        public Room(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
