
import java.util.*;

abstract class Shape
{

    abstract double getArea();

    abstract double getVolume();
}//end abstract class

class Cube extends Shape
{

    double side = 4;

    @Override
    double getArea() {
        return 6 * side * side;
    }

    @Override
    double getVolume() {
        return Math.pow(side, 3);
    }

}//end of cube class

class Sphere extends Shape
{

    double radius = 4;

    @Override
    double getArea() {
        return 4 * Math.PI * Math.pow(radius, 2);
    }

    @Override
    double getVolume() {
        return (4 / 3) * Math.PI * Math.pow(radius, 3);
    }

}

public class oop
{

    public static void main(String[] args) {
        Sphere s1 = new Sphere();
        Cube c1 = new Cube();
        ArrayList<Shape> shapes = new ArrayList<Shape>();

        shapes.add(s1);
        shapes.add(c1);
        
        System.out.println("The Area");
        for(int i = 0; i < shapes.size(); i++)
            System.out.println(shapes.get(i).getArea());
        
        System.out.println("The Volume");
        for(int x = 0; x < shapes.size(); x++)
            System.out.println(shapes.get(x).getVolume());
        

    }

}

