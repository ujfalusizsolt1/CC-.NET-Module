using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }

        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }
        /*
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        */

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }


        public override string ToString()
        {
            return (this.Name + ", " + this.BirthDate + ", " + this.Gender + ", " + this.Salary + ", " + this.Profession + ", " + this.Room.Number);
        }
    }
}
