using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Pyramid 
    {
        private double length;
        private double width;
        private double height;

        public double DgetVolume() 
        {
            length = 5;
            width = 6;
            height = 7;
            return length * width * height / 3;
        }

        public double PgetVolume(double l, double w, double h)
        {
            length = l;
            width = w;
            height = h;
            return length * width * height / 3;
        }
    }
    internal class pyramid_volume_calculator
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid();
            Console.WriteLine("Default");
            Console.WriteLine(pyramid.DgetVolume());

            Pyramid pyramid2 = new Pyramid();
            Console.WriteLine("Parameterized");
            Console.WriteLine(pyramid2.PgetVolume(52, 61, 73));
        }
    }
}