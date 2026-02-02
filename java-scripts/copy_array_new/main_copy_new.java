import java.util.*;
public class main_copy_new
{

    public static void main(String[] args) 
    {
        int[] num1 = new int[] {7,3,1,1,5};
        System.out.println("Num 1");
        for (int i = 0; i < num1.length; i++)
            System.out.print(num1[i]);
        
        System.out.println(" ");
        
        int[] num2 = Arrays.copyOf(num1, 5);
        System.out.println("Num 2");
        for (int i = 0; i < num2.length; i++)
            System.out.print(num2[i]);
    }
    
}

