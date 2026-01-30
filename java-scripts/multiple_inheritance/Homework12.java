import java.util.*;
interface method1
{
    public double getArea();
}

interface method2
{
    public double getVolume();
}

class Cube implements method1, method2
{
    double side = 4;
    public double getArea()
    {
        return 6 * side * side;
    }
    public double getVolume()
    {
        return Math.pow(side,3);
    }
    
}
class Sphere implements method1, method2
{
    double radius = 4;
    public double getArea()
    {
        return 4 * Math.PI * Math.pow(radius,2);
    }
    public double getVolume()
    {
        return (4/3) * Math.PI * Math.pow(radius,3);
    }
    
}
public class Homework12
{
    public static void main(String[] args) 
    {
        Sphere s1 = new Sphere();
        Cube c1 = new Cube();
        
        double area = s1.getArea();
        System.out.println("Sphere area = " + s1.getArea());
        area = c1.getArea();
        System.out.println("Cube area = " + c1.getArea());
        
        double volume = s1.getVolume();
        System.out.println("Sphere volume = " + s1.getVolume());
        volume = c1.getVolume();
        System.out.println("Cube volume = " + c1.getVolume());
    }
    
}
