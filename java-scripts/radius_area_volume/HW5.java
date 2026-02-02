import java.util.*;
//
public class HW5
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("1 for sphere, 2 for cube: ");
        int choice = sc.nextInt();
        if (choice == 1) {
            double radius, surface_area, volume;
            System.out.print("What is the radius > ");
            radius = sc.nextDouble();
            surface_area = (4*Math.PI*Math.pow(radius,2));
            volume = ((double)(4 / 3)*Math.PI*Math.pow(radius,3));
            System.out.println("surface area of the sphere = " + surface_area);
            System.out.println("volume of the sphere = " + volume);
            
        } else if (choice == 2) {
            double edge_length, surface_area, volume;
            System.out.print("What is the edge length > ");
            edge_length = sc.nextDouble();
            surface_area = (6*Math.pow(edge_length,2));
            volume = (Math.pow(edge_length,3));
            System.out.println("surface area of the cube = " + surface_area);
            System.out.println("volume of the cube = " + volume);
        } else 
        {
            System.out.println("Invalid choice.");
        }
    }
    
}
