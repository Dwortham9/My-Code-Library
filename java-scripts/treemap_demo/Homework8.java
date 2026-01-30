import java.util.*;
public class Homework8
{
    public static void main(String[] args) 
    {
        Random rnd = new Random(); 
        TreeMap<Integer, Integer> tm = new TreeMap<>();
        
        for(int i = 1; i <= 10; i++)
        {    
            int n1 = rnd.nextInt(100);
            int n2 = rnd.nextInt(100);
            tm.put(n1, n2);
            
            Set<Integer> keys = tm.keySet();
            for (Integer key : keys)
            {
                int value = tm.get(key);
                System.out.println(key + " " + value);
            }
        }    
    }
    
}
