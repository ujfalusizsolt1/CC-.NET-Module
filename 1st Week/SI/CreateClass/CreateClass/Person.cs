using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        private string name;
        public DateTime birthDate;
        internal Genders gender;

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }



        public enum Genders
        {
            Male,
            Female
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public Genders Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return (this.Name + ", " + this.BirthDate + ", " + this.Gender);
        }
    }
}
