
using System.Diagnostics.Metrics;
using System.Reflection;

for (int x = 100; x <= 1000; x += 50)
{
    Console.WriteLine(x);
}

int y = 100;
while (y <= 1000)
{
    Console.WriteLine(y);
    y += 50;
}

for (int z = 100; z >= 0; z -= 10)
{
    Console.WriteLine(z);
}

Random rnd = new Random();
int counter = 0;
bool done = false;
while (!done)
{
    int a;
    counter++;
    a = rnd.Next(1, 101);

    Console.WriteLine($"#{counter} = {a}");

    if (a == 100)
    {
        Console.WriteLine("Match!");
        done = true;
    }
}
Console.WriteLine($"It took {counter} attempts.");

int t = 100;
do 
{
    Console.Write("{0}", t);
    t++;
}
while (t < 3);
Console.WriteLine(" Done");