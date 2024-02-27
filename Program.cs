using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code10_11Lessons
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(){}
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            //Vector result = new Vector();
            //result.X = v1.X + v2.X;
            //result.Y = v1.Y + v2.Y;
            //return result;

            return new Vector {X = v1.X + v2.X, Y = v1.Y + v2.Y};
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            //Vector result = new Vector();
            //result.X = v1.X - v2.X;
            //result.Y = v1.Y - v2.Y;
            //return result;

            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            Vector res = v1 + v2;
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static Vector operator *(Vector v2,int a)
        {
            return new Vector { X = v2.X * a, Y = v2.Y * a };
        }

        public static Vector operator *(int a, Vector v2)
        {
            return new Vector { X = v2.X * a, Y = v2.Y * a };
        }
        public static Vector operator *(Vector v2, Point p)
        {
            return new Vector { X = v2.X * p.X, Y = v2.Y * p.Y };
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !v1.Equals(v2);
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            double mod1 = Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y);
            double mod2 = Math.Sqrt(v2.X * v2.X + v2.Y * v2.Y);
            bool res = mod1 > mod2 ? true : false;
            return res;
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            double mod1 = Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y);
            double mod2 = Math.Sqrt(v2.X * v2.X + v2.Y * v2.Y);
            bool res = mod1 < mod2 ? true : false;
            return res;
        }

        public static bool operator true(Vector v)
        {
            return v.X != 0 || v.Y != 0 ? true : false;
        }

        public static bool operator false(Vector v)
        {
            return v.X == 0 && v.Y == 0;
        }

        public static Vector operator &(Vector v1, Vector v2)
        {
            if ((v1.X != 0 && v1.Y != 0) && (v2.X != 0 && v2.Y != 0)) return v2;
            return new Vector();
        }

        public static Vector operator |(Vector v1, Vector v2)
        {
            if ((v1.X != 0 || v1.Y != 0) || (v2.X != 0 || v2.Y != 0)) return v2;
            return new Vector();
        }

        public override string ToString()
        {
            return $"Вектор ({X};{Y})";
        }
        

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator ++(Point p)
        {
            p.X += 1;
            p.Y += 1;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X -= 1;
            p.Y -= 1;
            return p;
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1 = new Point();
            Point p2 = p1;

            Vector v1 = new Vector(new Point {X = 4, Y = 3 }, new Point { X = 4, Y = 3 });
            Vector v2 = new Vector(new Point {X = 15, Y = -3 }, new Point { X = 1, Y = 5 });
            v1 *= v2;
            Console.WriteLine(v1 * p1);
            Console.WriteLine(v1 != v2);

            if (v1 && v2)
            {
                Console.WriteLine("Успех");
            }

        }
    }
}
