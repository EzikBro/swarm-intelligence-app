using System;

namespace Case1
{
    public abstract class Geometry
    {
        public class Point
        {
            double x { get; set; }
            double y { get; set; }

            public Point()
            {
                this.x = 0;
                this.y = 0;
            }

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public Point(Point a, Point b)
            {
                this.x = b.x - a.x;
                this.y = b.y - a.y;
            }

            public static Point operator +(Point a, Point b)
            {
                return new Point(a.x + b.x, a.y + b.y);
            }

            public static Point operator -(Point a, Point b)
            {
                return new Point(a.x - b.x, a.y - b.y);
            }

            public static double operator *(Point a, Point b)
            {
                return a.x * b.x + a.y * b.y;
            }

            public static Point operator *(Point a, double k)
            {
                return new Point(a.x * k, a.y * k);
            }

            public static Point operator /(Point a, double k)
            {
                return new Point(a.x / k, a.y / k);
            }

            public static double operator ^(Point a, Point b)
            {
                return a.x * b.y - b.x * a.y;
            }

            public static Point operator -(Point a)
            {
                return new Point(-a.x, -a.y);
            }

            public double Lenght()
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }

            // Square of lenght
            public double Lenght2()
            {
                return this.x * this.x + this.y * this.y;
            }

            public Point UnitVector()
            {
                return this / this.Lenght();
            }

            public override bool Equals(object obj)
            {
                return obj is Point point &&
                       x == point.x &&
                       y == point.y;
            }

            public override int GetHashCode()
            {
                var hashCode = 1502939027;
                hashCode = hashCode * -1521134295 + x.GetHashCode();
                hashCode = hashCode * -1521134295 + y.GetHashCode();
                return hashCode;
            }

            public static bool operator ==(Point a, Point b)
            {
                return (a.x == b.x && a.y == b.y);
            }

            public static bool operator !=(Point a, Point b)
            {
                return !(a == b);
            }
        }

        public static Point HeightToSegment(Point o, Point a, Point b)
        {
            Point ao = new Point(a, o);
            Point ab = new Point(a, b);
            Point ab1 = ab.UnitVector();
            double ahl = ao * ab1;
            Point ah = ab1 * ahl;
            Point h = a + ah;
            return h;
        }

        public static Point NearestPointOnSegment(Point o, Point a, Point b)
        {
            Point h = HeightToSegment(o, a, b);
            Point ab = new Point(a, b);
            Point ao = new Point(a, o);
            Point ba = new Point(b, a);
            Point bo = new Point(b, o);

            if ((ab * ao) > 0 && (ba * bo) > 0)
            {
                return h;
            }

            Point oa = new Point(o, a);
            Point ob = new Point(o, b);

            if (oa.Lenght2() <= ob.Lenght2())
                return a;
            else
                return b;
        }
    }
}
