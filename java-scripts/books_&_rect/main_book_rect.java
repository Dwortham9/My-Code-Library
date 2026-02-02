
public class main_book_rect
{
    public static void main(String[] args) 
    {
        AdvBook b1 = new AdvBook();
        b1.title = "River's End";
        b1.author = "Trina L. Talma";
        b1.publisher = "Trina L. Talma";
        b1.genre = "Fantasy";
        
        AdvBook b2 = new AdvBook("Apples Never Fall","Liane Moriarty",
                "Henry Holt & Company","Fiction");
        
        b1.print();
        System.out.println("/////////////");
        b2.print();
        
        
        AdvRect r1 = new AdvRect();
        r1.setH(6);
        r1.setW(9);
        
        AdvRect r2 = new AdvRect(10,20);
        r1.print();
        r2.print();
    }
    
}

