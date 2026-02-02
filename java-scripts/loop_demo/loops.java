
public class loops
{
    public static void main(String[] args) 
    {
        int i = 1;
        System.out.print("While loop: ");
        while (i <= 5) 
        {
          System.out.print(i+" ");
          i++;
        }
        System.out.println(" ");
        System.out.print("For loop: ");
        for (int x = 6; x <= 10; x++) 
        {
            System.out.print(x+" ");
        }
        System.out.println(" ");
        System.out.print("Do/While loop: ");
        int y = 11;
        do 
        {
          System.out.print(y+" ");
          y++;
        }
        while (y <= 15);
        System.out.println(" ");
    }
    
}

