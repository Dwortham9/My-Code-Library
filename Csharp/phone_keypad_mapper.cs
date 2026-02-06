    string s = "1-800-csharp9";

    s = s.ToLower();

    string result = "";
while (true)
{
    for (int i = 0; i < s.Length; i++)
    {
        char ch = s[i];
        switch (ch)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '-':
            case '(':
            case ')':
            case ' ':
                result += ch;
                break;

            case 'a':
            case 'b':
            case 'c':
                result += "2";
                break;
            case 'd':
            case 'e':
            case 'f':
                result += "3";
                break;
            case 'g':
            case 'h':
            case 'i':
                result += "4";
                break;
            case 'j':
            case 'k':
            case 'l':
                result += "5";
                break;
            case 'm':
            case 'n':
            case 'o':
                result += "6";
                break;
            case 'p':
            case 'q':
            case 'r':
            case 's':
                result += "7";
                break;
            case 't':
            case 'u':
            case 'v':
                result += "8";
                break;
            case 'w':
            case 'x':
            case 'y':
            case 'z':
                result += "9";
                break;
            default:
                result += "?";
                break;

        }
    }
    string q;
    Console.WriteLine(s + " converts to " + result);
    Console.WriteLine("Press 'q' to quit");
    q = Console.ReadLine();
    if (q == "q") 
    {
        break;
    }
    else
    {}
}