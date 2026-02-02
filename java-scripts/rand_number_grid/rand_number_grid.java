import java.util.*;

public class rand_number_grid
{

    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);

        int NUM_ROWS;
        int NUM_COLS;
        int num_randoms;
        
        System.out.print("What is the number of rows? > ");
        NUM_ROWS = sc.nextInt();
        System.out.print("What is the number of columns? > ");
        NUM_COLS = sc.nextInt();
        
        num_randoms = NUM_ROWS * NUM_COLS;
        
        int [][] nums = new int [NUM_ROWS][NUM_COLS];
        
        for (int i = 0; i < nums.length; i++) 
        {
         for (int j = 0; j < nums[i].length; j++) 
         {
            nums[i][j] = (int)(Math.random() * num_randoms);
         }
        }
        int sum_array = 0;
        for (int row = 0; row < nums.length; row++)
        {
            int sum_row = 0;
            for (int col = 0; col < nums[row].length; col++)
            {
                System.out.printf("%3d", nums[row][col]);
                sum_row += nums[row][col];
                sum_array += nums[row][col];
            }
            System.out.println(" total="+sum_row);
        }
        System.out.println("Array total = " + sum_array);
    }
    
}

