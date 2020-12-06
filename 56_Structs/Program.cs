using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            Person rd = new Person("rizzle", 100);
            Complex x = new Complex(3, -4);
            Console.WriteLine(x);

            Console.WriteLine(rd.Age);
            Increase(rd);
            Console.WriteLine(rd.Age);

            Console.WriteLine(number);
            Increase(number);
            Console.WriteLine(number);

            Console.WriteLine(x.Real);
            Increase(x);
            Console.WriteLine(x.Real);



            Console.ReadKey();
        }

        //passed by reference to this method because its a CLASS
        public static void Increase(Person p) => p.Age++;
        //passed by value to this method because its a PRIMITIVE VARIABLE
        public static void Increase(int num) => num++;
        //passed by value to this method because its a STRUCT
        public static void Increase(Complex comp) => comp.Real++;
    }

    

    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString() => $"{this.Name}, {this.Age}";
    }

    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex (double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public override string ToString() => $"{Real} {Imaginary}i";
    }
}
