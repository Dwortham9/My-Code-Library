import java.util.*;
import java.io.*;
public class create_n_edit_files
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        String fn;
        System.out.print("Enter save filename: ");
        fn = sc.nextLine();
          try 
        {
            File file = new File(fn);
            PrintWriter pt = new PrintWriter(file);
            System.out.println(fn + " opened.");
            boolean done = false;
            while (!done)
            {
            System.out.print("Enter first name, or Q to quit: ");
            String response = sc.nextLine();
            pt.print(response);
                if (response.equals("Q"))
                {
                    done = true;
                    pt.close();
                    System.out.println(fn + " closed.");
                    System.out.println("done.");
                } else
                {
                    System.out.print("Enter last name: ");
                    response = sc.nextLine();
                    pt.print(", " + response + ", ");
                    System.out.print("Enter zipcode: ");
                    response = sc.nextLine();
                    pt.println(response);
                    System.out.println("Data saved.");
                }
            }
        }
          catch (FileNotFoundException ex)
        {
            System.out.println("Could not open file " + fn);
        }
    }// end of main
    
}//end of public class

/*Enter save file name: musicians.txt
File musicians.txt created.

Enter first name, or Q to quit: George
Enter last name: Thoroughgood
Enter zipcode: 65321
Data saved.

Enter first name, or Q to quit: Edward
Enter last name. Van Halen
Enter zipcode. 90111
Data saved.

Enter first name, or Q to quit: Ludwig
Enter last name: Van Beethoven
Enter zipcode: 12345
Data saved.

Enter first name, or Q to quit: Q

File musicians.txt closed.

Done.*/
