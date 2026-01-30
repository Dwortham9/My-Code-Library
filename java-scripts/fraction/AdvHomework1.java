import java.util.*;
public class AdvHomework1
{

    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        double gallon, liter;
        
        System.out.print("Please provide values for gallon > ");
        gallon = sc.nextDouble();
        
        liter = gallon * 3.785411784;
        System.out.println("liter(s) > " + liter);
        ///////////////////////////////////////////////
        
        Fraction fr1 = new Fraction();
        int top, bottom;
        System.out.print("Please enter top value > ");
        top = sc.nextInt();
        fr1.setTop(top);
        System.out.print("Please enter bottom value > ");
        bottom = sc.nextInt();
        fr1.setBottom(bottom);
        System.out.println(fr1.getValue());
        
    }
    
}
