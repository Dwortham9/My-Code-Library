
public class Animal
{
    String name;
    int teeth;
    int legs;
    String species;
    
    public Animal(String species,
            String name, int teeth, int legs)
    {
        this.species = species;
        this.name = name;
        this.teeth = teeth;
        this.legs = legs;
    }
    public void eat() 
    {
        System.out.printf("%s is eating!\n",name);
    }
    
    public void sound()
    {
        System.out.printf("%s is making a sound\n", name);
    }
    
}
class Crow extends Animal
{
   public Crow(String name)
    {
        super("Corvus", name, 0, 2);
    }
    @Override
     public void sound()
     {
         System.out.printf("%s is Caw-Cawing\n", this.name);
     } 
}
class Chicken extends Animal
{
   public Chicken(String name)
    {
        super("Domesticated junglefowl", name, 0, 2);
    }
    @Override
     public void sound()
     {
         System.out.printf("%s is clucking\n", this.name);
     } 
}
class Duck extends Animal
{
   public Duck(String name)
    {
        super("Waterfowl", name, 0, 2);
    }
    @Override
     public void sound()
     {
         System.out.printf("%s is quacking\n", this.name);
     } 
}