using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_VectorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v0 = new Vector(1, 2, 3);
            Vector v1 = new Vector(3, 4, 0); //345 pythagorama
            Console.WriteLine($"v0: {v0}");
            Console.WriteLine($"v1: {v1}");

            Vector zero = new Vector();
            Console.WriteLine($"zero {zero}");

            Vector copyOfV1 = new Vector(v1);
            Console.WriteLine($"copy of v1: {copyOfV1}");

            Console.WriteLine($"v0 length: {v0.Length}, v1 length: {v1.Length}");

            v1.Reverse();
            Console.WriteLine($"v1: {v1}");

            v1.Scale(0.5);
            Console.WriteLine($"v1 length: {v1.Length}");

            v1.Unitize();
            Console.WriteLine($"v1 unitized length: {v1.Length}");
            Console.WriteLine($"v1 unitized: {v1}");
            if (v1.Unitize() == true) { Console.WriteLine("unitized"); } else { Console.WriteLine("unitize failure"); }
            
            zero.Unitize();
            Console.WriteLine($"zero unitized length: {zero.Length}");
            Console.WriteLine($"zero unitized: {zero}");
            if (zero.Unitize() == true) { Console.WriteLine("unitized"); } else { Console.WriteLine("unitize failure"); }


            Vector v2 = Vector.Addition(v0, v1);
            Console.WriteLine($"{v0} + {v1} = {v2}");

            Console.WriteLine($"dot product of ({v0}) and ({v1}) is: ({Vector.DotProduct(v0, v1)})");

            Vector vx = new Vector(Vector.XAxis);
            Vector vy = new Vector(Vector.YAxis);
            Vector vz = new Vector(Vector.ZAxis);
            Vector cross = Vector.CrossProduct(vx, vy);
            Console.WriteLine($"cross product of ({vx}) and ({vy}) is: ({cross})");


            Console.ReadKey();
        }
    }

    /// <summary>
    /// Represents a 3 dimensional vector
    /// </summary>
    public class Vector
    {
        //properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Length { get => GetLength(); }

        //static properties
        public static Vector XAxis { get => new Vector(1, 0, 0); }
        public static Vector YAxis { get => new Vector(0, 1, 0); }
        public static Vector ZAxis { get => new Vector(0, 0, 1); }
        //constructors
        public Vector()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector(Vector other)
        {
            this.X = other.X;
            this.Y = other.Y;
            this.Z = other.Z;
        }

        //methods
        private double GetLength()
        {
            double sq1 = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
            return Math.Sqrt(sq1);
        }

        public void Reverse()
        {
            this.X = -this.X;
            this.Y = -this.Y;
            this.Z = -this.Z;
        }

        public void Scale(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
            this.Z *= factor;
        }

        public bool Unitize()
        {
            double length = this.GetLength();
            if (length <= 0) { return false; }
            this.X /= length;
            this.Y /= length;
            this.Z /= length;
            return true;
        }

        public void Add(Vector other)
        {
            this.X += other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }

        //static methods
        public static Vector Addition(Vector a, Vector b)
        {
            double newX = a.X + b.X;
            double newY = a.Y + b.Y;
            double newZ = a.Z + b.Z;
            Vector v = new Vector(newX, newY, newZ);
            return v;
        }

        public static double DotProduct(Vector a, Vector b) =>  a.X * b.X + a.Y * b.Y + a.Z * b.Z; 
        public static Vector CrossProduct(Vector a, Vector b)
        {
            double x = a.Y * b.Z - a.Z * b.Y;
            double y = a.Z * b.X - a.X * b.Z;
            double z = a.X * b.Y - a.Y * b.X;
            return new Vector(x, y, z);
        }

        //overrides
        public override string ToString() => $"{this.X}, {this.Y}, {this.Z}";
    }
}
