using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Grade;

        public Student()
        {
            Console.WriteLine("Name daxil et: ");
            Name = Console.ReadLine();

        restart:
            Console.WriteLine("Surname daxil et: ");
            Surname = Console.ReadLine();
            if (Surname.Length < 3)
            {
                Console.WriteLine("3 ve ya daha artiq elementli Surname daxil et!");
                goto restart;
            }

        start:
            Console.WriteLine("Age daxil et: ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 0)
            {
                Console.WriteLine("Musbet eded daxil et!");
                goto start;
            }

        starter:
            Console.WriteLine("Grade daxil et: ");
            Grade = Convert.ToDouble(Console.ReadLine());
            if (!(Grade >= 0 && Grade <= 100))
            {
                Console.WriteLine("0-100 araliginde reqem daxil et!");
                goto starter;
            }
        }
    }
}
