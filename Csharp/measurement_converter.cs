

namespace MyApp
{
    internal class measurement_converter
    {
        static void Main(string[] args)
        {
            //feet to meters
            string i;
            Console.WriteLine("A to convert feet to meters");
            Console.Write("B to convert miles to kilometers > ");
            i = Console.ReadLine();
            if (i == "a" || i == "A") 
            {
                string s;
                Console.Write("Convert how many feet? > ");
                s = Console.ReadLine();
                double feet = Double.Parse(s);
                double meters = feet * 12 * 2.54 / 100;
                Console.WriteLine($"{feet} Feet = {meters} Meters");
            }else if(i == "b" || i == "B") 
            {
                string x;
                Console.Write("Convert how many miles? > ");
                x = Console.ReadLine();
                double miles = Double.Parse(x);
                double kilometers = miles * 1.609344;
                Console.WriteLine($"{miles} Miles = {kilometers,0:0.#} Kilometers");
            }
        }
    }
}
