#include <iostream>
#include <cmath>
#include <string>

using namespace std;
enum class Friends {Mason, Dalton, Alexis, Chris};
string convertFriend(Friends b)
{
    switch (b)
    {
    case Friends::Mason:
        return "Mason";
        break;
    case Friends::Dalton:
        return "Dalton";
        break;
    case Friends::Alexis:
        return "Alexis";
        break;
    case Friends::Chris:
        return "Chris";
        break;
    default:
        return "unknown Friend name";
    }

}
const int nums_size = 7;
double nums[nums_size] = {5, 2, 10, 38, 20, 56, 44};

int main()
{
    Friends b1, b2, b3, b4;
    string s;

    b1 = Friends::Mason;
    s = convertFriend(b1);
    cout << s << endl;

    b2 = Friends::Dalton;
    s = convertFriend(b2);
    cout << s << endl;

    b3 = Friends::Alexis;
    s = convertFriend(b3);
    cout << s << endl;

    b4 = Friends::Chris;
    s = convertFriend(b4);
    cout << s << endl;

    for (int i = 0; i < nums_size; i++)
        cout << nums[i] << " ";
        cout << endl;
}