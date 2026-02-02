public class HW11
{
    public static void main(String[] args) 
    {
         String word = "I LOVE JAVA PROGRAMMING";

        System.out.println("Cell text " + word);
        String converted = "";
        
        for (char ch: word.toCharArray())
        {
            ch = Character.toUpperCase(ch);
            switch (ch)
            {
                case 'A':
                    converted += "2";
                case 'B':
                    converted += "2";
                case 'C': 
                    converted += "2";
                    converted += " ";
                    break;
                case 'D':
                    converted += "3";
                case 'E':
                    converted += "3";
                case 'F':
                    converted += "3";
                    converted += " ";
                    break;
                case 'G':
                    converted += "4";
                case 'H':
                    converted += "4";
                case 'I':
                    converted += "4";
                    converted += " ";
                    break;
                case 'J':
                    converted += "5";
                case 'K':
                    converted += "5";
                case 'L':
                    converted += "5";
                    converted += " ";
                    break;
                case 'M':
                    converted += "6";
                case 'N':
                    converted += "6";
                case 'O':
                    converted += "6";
                    converted += " ";
                    break;
                case 'P':
                    converted += "7";
                case 'Q':
                    converted += "7";
                case 'R':
                    converted += "7";
                case 'S':
                    converted += "7";
                    converted += " ";
                    break;
                case 'T':
                    converted += "8";
                case 'U':
                    converted += "8";
                case 'V':
                    converted += "8";
                    converted += " ";
                    break;
                case 'W':
                    converted += "9";
                case 'X':
                    converted += "9";
                case 'Y':
                    converted += "9";
                case 'Z':
                    converted += "9";
                    converted += " ";
                    break;
                case ' ':
                    converted += "0";
                    converted += " ";
                    break;
                default:
                    System.out.println("Unrecognized char = " + ch);
            } // end switch
        } // end for
        System.out.println("Text dial = " + converted);
        System.out.println();
    }
    
}
