import java.util.*;
public class math_demo
{
    public static void main (String args[]) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter a whole number > ");
        int n = sc.nextInt();
        displayTwiceTheNumber(n);
        displayNumberPlusFive(n);
        displayNumberSquared(n);
         
    }
    public static void displayTwiceTheNumber(int n) {
        int result = n * 2;
        System.out.printf("%d * 2 = %d\n", n, result);
    }
    public static void displayNumberPlusFive(int n) {
        int result = n+5;
        System.out.printf("%d + 5 = %d\n", n, result);
    }
    public static void displayNumberSquared(int n) {
      int result = n*n;
      System.out.printf("%d squared = %d\n", n, result);
   }
    
}

