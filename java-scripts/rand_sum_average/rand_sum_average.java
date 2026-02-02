import java.util.*;
public class rand_sum_average
{
public static void main(String[] args) 
    {
      if (args.length > 0)
        {
            for (String arg : args) {
                System.out.println("arg = " + arg);
            }
            
        }
        Scanner sc = new Scanner(System.in);       
        double[] dArray = {};
        double dTotal = sum(dArray);
        
        System.out.println("Enter how many numbers do you want?");
        int x = sc.nextInt();
        int[] randomList = new int[x];
        int numItems = 0;
        
        for (int i = 0; i < randomList.length; i++)
        {
            Random rnd = new Random();
            int value = rnd.nextInt(100);
            randomList[i] = value;
            numItems = i + 1;
        }
        dTotal = 0;
        for (int index = 0; index < numItems; index++)
            dTotal += randomList[index];
        System.out.println(Arrays.toString(randomList));
        
        if (numItems > 0)
        {
            double average = dTotal / numItems;
            System.out.println("Total = " + dTotal);
            System.out.println("Average = " + average);
        }
        else
        {
            System.out.println("No data entered, so no sum or average");
        }   
    }

    private static int sum(int[] array) 
    {
        int total = 0;
        for (int value : array)
            total += value;
        return total;
    }
    
    private static double sum(double[] array) 
    {
        double total = 0;
        for (double value : array)
            total += value;
        return total;
    }
    
}

