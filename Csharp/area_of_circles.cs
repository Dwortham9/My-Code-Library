using System;

namespace ConsoleApp9
{

    class Circle
    {
        private double radius;
        

        public double Radius { get => radius; set => radius = value; }

        public double Circumference
        {
            get
            {
                double circum = 2 * Math.PI * radius;
                return circum;
            }
        }

        public double Area
        {
            get
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
        }
    }

    class area_of_circles
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle();
            c1.Radius = 10;
            Circle c2 = new Circle();
            c2.Radius = 20;
            Circle c3 = new Circle();
            c3.Radius = 30;

            Console.WriteLine("C1's area is " + c1.Area);
            Console.WriteLine("C2's area is " + c2.Area);
            Console.WriteLine("C3's area is " + c3.Area);

            Console.WriteLine("C1's circumference is " + c1.Circumference);
            Console.WriteLine("C2's circumference is " + c2.Circumference);
            Console.WriteLine("C3's circumference is " + c3.Circumference);


        }
    }
}