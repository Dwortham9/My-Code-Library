import java.util.*;

class MS
{
    private ArrayList<Integer> data = new ArrayList<>();
    public void push(int x)
    {
        data.add(x);
    }
    public int pop()
    {
        int r = data.get(data.size()-1);
        data.remove(data.size()-1);
        return r;
    }
    public boolean isEmpty()
    {
        if(data.size() == 0)
            return true;
        return false;
    }
}//end MS
public class custom_stack_data
{
    public static void main(String[] args) 
    {
        MS mystack = new MS();
        mystack.push(40);
        mystack.push(50);
        mystack.push(60);
        mystack.push(70);
        mystack.push(80);
        
        int value;
        
        while(!mystack.isEmpty())
        {
            value = mystack.pop();
            System.out.println("we just got "+value);
        }
    }
    
}

