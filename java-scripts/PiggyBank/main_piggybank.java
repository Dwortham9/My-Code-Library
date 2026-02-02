import java.util.*;
public class main_piggybank
{

    public static void main(String[] args) 
    {
        int x = 1;
        Scanner sc = new Scanner(System.in);
        PiggyBank bank = new PiggyBank();
        
        Coin penny = new Coin(.01);
        Coin nickle = new Coin(.05);
        Coin dime = new Coin(.10);
        Coin quarter = new Coin(.25);
        
        while(x != 0)
        {
            //System.out.println("It is: " + dime.getValue());
                    
            System.out.println("How many coins or 0 to quit: " );
            x = sc.nextInt();
            if (x == 0)
            {   
                System.out.println("Bye!");
                break;
            }
            System.out.println("What type of coin: (1:Penny 2:Nickle 3:Dime 4:Quarter)" );
            double y = sc.nextDouble();
            if(y == 1)
            {
                penny.getValue();
                bank.addCoins(x, penny);
            }
            else if(y == 2)
            {
                nickle.getValue();
                bank.addCoins(x, nickle);
            }
            else if(y == 3)
            {
                dime.getValue();
                bank.addCoins(x, dime);
            }
            else if(y == 4)
            {
                quarter.getValue();
                bank.addCoins(x, quarter);
            }
            
            double value = bank.getTotalMoney();
            int num_coin = bank.getNumberOfCoins();

            System.out.printf("The bank contains %d coins worth %.2f dollars\n",num_coin, value);
        }
    }
    
}

