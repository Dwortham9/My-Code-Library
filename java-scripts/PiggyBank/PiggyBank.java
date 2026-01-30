import java.util.*;
public class PiggyBank
{
    private ArrayList<Coin> coinlist = new ArrayList<>();
    final int MAX_COINS = 50;
    
    public int getNumberOfCoins()
    {
        return coinlist.size();
    }
    public double getTotalMoney()
    {
        double sum = 0;
        for (Coin c : coinlist)
        {
            sum = sum + c.getValue();
        }
        return sum;
    }
    public int addCoins(int howmany, Coin c)
    {
        int added = 0;
        
        while(added < howmany)
        {
            added += 1;
            coinlist.add(c);
            if(added > MAX_COINS)
            {
                System.out.println("Theres no more room.");
                break;
            }
        }
        return added;
    }
}
