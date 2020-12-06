using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person rd = new Person();
            //rd.name = "Ray Dizzle";
            //rd.age = 10;
            //rd.height = 5.9;
            //rd.isAlive = true;

            Person jd = new Person("Jeremy", 1983, 90);
            Person hg = new Person("hoochiemama", 1900, 80);

            Console.WriteLine($"is {jd.Name } alive? {jd.IsAlive}");
            Console.WriteLine(hg.Name);

            jd.Greet();
            hg.Die();
            hg.Greet(jd);

            Console.WriteLine(jd);

            Console.WriteLine($"{jd.Name} is {jd.GetAge()} many old");
            Console.WriteLine($"{hg.Name} is {hg.GetAge()} many old");
            Console.WriteLine($"the age gap between {jd.Name} and {hg.Name} is {Person.ComputeAgeDiff(jd, hg)}");


            Console.ReadKey();
        }
    }

    /// <summary>
    /// class defining Person objects
    /// </summary>
    class Person
    {
        //static properties
        public static int MaxAge = 100;

        //static methods
        public static int ComputeAgeDiff(Person one, Person two) => Math.Abs(one.Age - two.Age);

        //fields - replaced with the get; set; auto property
        //private string _name;
        //private int _YOB;
        //private double _height;
        //private bool _isAlive;

        //properties
        public string Name { get; set; }
        public int YOB { get; set; }
        public double Height { get; set; }
        public bool IsAlive { get; set; }
        
        //public string Name //all of this is same as public string Name { get; set; }
        //{
        //    get => this._name; //same as get { return this._name; }
        //    set => this._name = value;
        //}
        public bool isAlive { get => this.IsAlive; }
        //this isn't a stored variable, its an on-the-fly calculation, can't 
        //just point to its value like the other fields
        public int Age { get => DateTime.Now.Year - this.YOB; }

        //constructors
        public Person(string name)
        {
            this.Name = name;
            this.YOB = DateTime.Now.Year;
            this.Height = 6;
            this.IsAlive = true;
        }
        public Person(string name, int YOB, double height)
        {
            this.Name = name;
            this.YOB = YOB;
            this.Height = height;

            int currentYear = DateTime.Now.Year;

            if (currentYear - YOB < 0 || currentYear - YOB > Person.MaxAge)
            {
                this.IsAlive = false;
            } else
            {
                this.IsAlive = true;
            }
        }

        //methods
        public void Greet()
        {
            Console.WriteLine($"{this.Name} says hi, incidentally he is {this.Height} many tall");
        }

        public void Greet(string otherPerson)
        {
            Console.WriteLine($"hey {otherPerson} my name is {this.Name}");
        }

        public void Greet(Person otherP)
        {
            Console.WriteLine($"hey {otherP.Name} my name is {this.Name}");
        }

        public void Die()
        {
            this.IsAlive = false;
            Console.WriteLine($"{this.Name} is deader than a doorknob");
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.YOB;
        }

        //override the build int ToString so it shows whats inside the object
        public override string ToString()
        {
            return $"{this.Name}, {this.GetAge()}, {this.Height}, {this.IsAlive}";
        }
    }
}
