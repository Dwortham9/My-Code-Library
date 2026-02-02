import java.util.*;


public class degrees_converter {

    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("1 for fahrenheit, 2 for celsius: ");
        int choice = sc.nextInt();
        if (choice == 1) {
            double f1,c1;
            System.out.print("What is the temperature in celsius? >");
            c1 = sc.nextInt();
            double result1 = c1 * 1.8 + 32;
            System.out.println("The temperature in fahrenheit is: " + result1);
        } else if (choice == 2) {
            double f2, c2;
            System.out.print("What is the temperature in fahrenheit? >");
            f2 = sc.nextInt();
            double result2 = (f2-32)/1.8;
            System.out.println("The temperature in celsius is: " + result2);
        } else 
        {
            System.out.println("Invalid choice.");
            
        }
    }
    
}

