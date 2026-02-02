import java.util.Arrays;
import java.util.Scanner;
public class HW14
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
        int[] numbers = new int[x];
        int numItems = 0;
        
        for (int i = 0; i < numbers.length; i++)
        {
            System.out.println("Enter number or Q to quit.");
            String s = sc.next();
            if (s.equalsIgnoreCase("Q"))
                break;
            int value = Integer.parseInt(s);
            numbers[i] = value;
            numItems = i + 1;
        }
        dTotal = 0;
        for (int index = 0; index < numItems; index++)
            dTotal += numbers[index];
        System.out.println(Arrays.toString(numbers));
        
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
