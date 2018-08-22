﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

            /*
            Person firstPerson = new Person("Béla",DateTime.Now);
            Employee firstEmployee = new Employee("Kinga", DateTime.Now, 250000, "Random");
            firstEmployee.RoomNumber = new Room();
            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(firstEmployee.ToString());
            Console.ReadKey();
            */
        }
    }
}
