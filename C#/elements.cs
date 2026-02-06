using System;
using System.Drawing;
using static System.Console;
namespace Homework5 
{
    class elements 
    {
        enum Element
        {
            H,
            He,
            Li,
            Be,
            B,
            C
        }
        static void Main(string[] args) 
        {
            string s;
            WriteLine("Possible Elements:  H He Li Be B C");
            Write("Which element do you want?  ");
            s = ReadLine();
            Element e = (Element)Enum.Parse(typeof(Element), s);
            switch (e)
            {
                case Element.H:
                    WriteLine("The atomic mass of that element is 1.01");
                    break;
                case Element.He:
                    WriteLine("The atomic mass of that element is 4.0");
                    break;
                case Element.Li:
                    WriteLine("The atomic mass of that element is 7.0");
                    break;
                case Element.Be:
                    WriteLine("The atomic mass of that element is 9.01");
                    break;
                case Element.B:
                    WriteLine("The atomic mass of that element is 10.81");
                    break;
                case Element.C:
                    WriteLine("The atomic mass of that element is 12.01");
                    break;
                default:
                    WriteLine("Unimplemented element");
                    break;
            }
        }
    }

}
