import java.util.*;
public class HW13
{

    public static void main(String[] args) 
    {
        for (int dollar = 1; dollar <= 10; dollar++)
	{
            for (int cent = 0; cent < 100; cent += 25)
            {
                System.out.printf("$%d.%02d\n", dollar, cent);
            }
	}
        for (int ft = 0; ft <= 2; ft++)
	{
            for (int in = 0; in < 12; in += 3)
            {
                System.out.printf("%d ft and %d in\n", ft, in);
            }
	}
    }
    
}