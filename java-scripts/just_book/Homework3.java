
public class Homework3
{
    public static void main(String[] args) 
    {
        Book b1 = new Book();
        b1.title = "River's End";
        b1.author = "Trina L. Talma";
        b1.publisher = "Trina L. Talma";
        b1.genre = "Fantasy";
        
        Book b2 = new Book("Apples Never Fall","Liane Moriarty",
                "Henry Holt & Company","Fiction");
       
        b1.print();
        System.out.println("/////////////");
        b2.print();
        System.out.println("/////////////");
        
        Book b3 = b1;
        
        if(b3.equals(b1))
            System.out.println("Same Book");
        else
            System.out.println("Different Book");
        
        Book b4 = b2;
        
        if(b4.equals(b1))
            System.out.println("Same Book");
        else
            System.out.println("Different Book");
    }
    
}
