import java.util.*;

public class HW8
{
    public static void main(String[] args) {
        
     Scanner sc = new Scanner(System.in);
     
     double FV,PV, i;
     int n;
     
     //the input
     
     System.out.print("What is PV (Present investment)> ");
     PV = sc.nextDouble();
     System.out.print("What is i (Interest per period)> ");
     i = sc.nextDouble();
     System.out.print("What is n (Number of periods)> ");
     n = sc.nextInt();
     // the math
    
    //output
    System.out.println("Period      FV");
    System.out.println("------     -----");
    for (int x = 0;x <= n; x++)
    {
        FV = PV *(Math.pow((1+i), n));
        System.out.println("   "+x+"        "+FV);
    }
  }
    
}
