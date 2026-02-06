class overloaded_product
{
    static int product(params int[] nums)
    {
        int total = 1;
        foreach (int value in nums)
        {
            total *= value;
        }
        return total;
    }
    static double product(params double[] nums)
    {
        double total = 1;
        foreach (double value in nums)
        {
            total *= value;
        }
        return total;
    }
    static long product(params long[] nums)
    {
        long total = 1;
        foreach (long value in nums)
        {
            total *= value;
        }
        return total;
    }
    static double product(params string[] nums)
    {
        double total = 0;
        foreach (string s in nums)
        {
            total += double.Parse(s);
        }
        return total;
    }

    static void Main(string[] args)
    {
        long L1 = product(1, 2, 3);
        long L2 = product(9999999999L, 1);
        int i1 = product(1, 2);
        int i2 = product(1, 2, 3, 4);
        string sresult = "" + product("1", "2", "3");
        double d1 = product(1.1, 2.0, 3.0); 
        double d2 = product(2.0, 3.0, 4.0); 
        string[] sa = { "10.0", "0.5", "2" };
        double d3 = product(sa);            
        Console.WriteLine(L1);
        Console.WriteLine(L2);
        Console.WriteLine(i1);
        Console.WriteLine(i2);
        Console.WriteLine(sresult);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
    }
}