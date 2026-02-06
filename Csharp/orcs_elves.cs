Random rnd = new Random();

int[] orcs_health = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
int[] elves_health = { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };

int turns = 1;

while (orcs_health[0] > 0 || elves_health[0] > 0)
{
    for (int i = 0; i < orcs_health.Length; i++)
    {
        if (orcs_health[i] < 0)
            Console.WriteLine($"Orc {i} has been knocked out");
        else
            Console.WriteLine($"Orc {i} has {orcs_health[i]} " +
            "hit points remaining");
    }
    for (int i = 0; i < elves_health.Length; i++)
    {
        if (elves_health[i] < 0)
            Console.WriteLine($"Elve {i} has been knocked out");
        else
            Console.WriteLine($"Elve {i} has {elves_health[i]} " +
            "hit points remaining");
    }
    ////////////////////////////////////////////////////////
    for (int i = 0; i < orcs_health.Length; i++)
    {
        if (orcs_health[i] > 0)
        {
            int damage = rnd.Next(1, 6);
            orcs_health[i] -= damage;

            Console.WriteLine($"Orc {i} took {damage} hits and " +
                $"has {orcs_health[i]} hit points remaining");
        }
    }
    for (int i = 0; i < elves_health.Length; i++)
    {
        if (elves_health[i] > 0)
        {
            int damage = rnd.Next(1, 6);
            elves_health[i] -= damage;

            Console.WriteLine($"Elve {i} took {damage} hits and " +
                $"has {elves_health[i]} hit points remaining");
        }
    }
    ////////////////////////////////////////////////////
    Array.Sort(orcs_health);
    Array.Reverse(orcs_health);
    Array.Sort(elves_health);
    Array.Reverse(elves_health);
    //////////////////////////////////////////////////////
    if (orcs_health[0] <= 0)
    {
        Console.WriteLine("It took " + turns + " turns.");
    }
    else
    {

        Console.WriteLine("Current stats");

        for (int i = 0; i < orcs_health.Length; i++)
        {
            if (orcs_health[i] < 0)
                Console.WriteLine($"Orc {i} has knocked out");
            else
                Console.WriteLine($"Orc {i} has {orcs_health[i]} " +
                "hit points remaining");
        }
    }
    Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
    if (elves_health[0] <= 0)
    {
        Console.WriteLine("It took " + turns + " turns.");
    }
    else
    {

        Console.WriteLine("Current stats");

        for (int i = 0; i < elves_health.Length; i++)
        {
            if (elves_health[i] < 0)
                Console.WriteLine($"elve {i} has knocked out");
            else
                Console.WriteLine($"elve {i} has {elves_health[i]} " +
                "hit points remaining");
        }
        Console.Write("Turn " + turns + " over.  Hit enter");
        Console.ReadLine();
        turns++;
    }
}

Console.WriteLine("Game over!");