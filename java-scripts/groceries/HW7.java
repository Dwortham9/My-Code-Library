import java.util.*;

public class HW7
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        
        final int QUARTERS_PER_DOLLAR = 4;
        int quartsNeeded;
        
        System.out.print("How many quarters? > "); 
            String s = sc.next(); 
            quartsNeeded = Integer.parseInt(s);
        
        int gallons, quarts_left;
        gallons = quartsNeeded / QUARTERS_PER_DOLLAR;
        quarts_left = quartsNeeded % QUARTERS_PER_DOLLAR;
        
        System.out.printf("A job that needs %d quarters requires %d gallon(s) plus %d quart(s)\n", quartsNeeded, gallons, quarts_left);
       
        //******************
        
       final int EGGS_PER_DOZEN = 12;
       int eggsNeeded;
        
        System.out.print("How many eggs? > "); 
          String i = sc.next(); 
          eggsNeeded = Integer.parseInt(i);
        
        int eggs, eggs_left;
        eggs = eggsNeeded / EGGS_PER_DOZEN;
        eggs_left = eggsNeeded % EGGS_PER_DOZEN;
        
        System.out.printf("A job that needs %d eggs requires %d dozen plus %d egg(s)\n", eggsNeeded, eggs, eggs_left);
    }
  
}
