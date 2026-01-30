public class AdvBook
{
    String title;
    String author;
    String publisher;
    String genre;
    public AdvBook(String title,String author,String publisher,String genre)
    {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.genre = genre;
    }
    
    public AdvBook(){}
    
    void print()
    {
        System.out.println(title);
        System.out.println(author);
        System.out.println(publisher);
        System.out.println(genre);
    }
    
}
