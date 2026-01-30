
public class Homework4
{

    public static void main(String[] args) 
    {
        Pet p1 = new Pet();
        p1.name = "Obi";
        p1.birthdate = "02/12/22";
        p1.vacdate = "03/26/22";
        Pet p2 = new Pet("Cookie","09/26/21","11/07/21");
        
        p1.print();
        p2.print();
    }// end of main
    
}// end of Homework 4
