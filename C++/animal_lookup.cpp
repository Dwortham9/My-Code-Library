#include <iostream>
#include <cmath>
#include <string>

using namespace std;

enum class Friends { cow, pig, dog, sheep, goat, chicken };

string convertFriend(Friends a)
{
    switch (a)
    {
    case Friends::cow:
        return "cow";
        break;
    case Friends::pig:
        return "pig";
        break;
    case Friends::dog:
        return "dog";
        break;
    case Friends::sheep:
        return "sheep";
        break;
    case Friends::goat:
        return "goat";
        break;
    case Friends::chicken:
        return "chicken";
        break;
    default:
        return "unknown Animal";
    }

}

int main()
{
    Friends a1, a2, a3, a4, a5, a6;
    string s;

    a1 = Friends::cow;
    s = convertFriend(a1);
    cout << s << endl;

    a2 = Friends::pig;
    s = convertFriend(a2);
    cout << s << endl;

    a3 = Friends::dog;
    s = convertFriend(a3);
    cout << s << endl;

    a4 = Friends::sheep;
    s = convertFriend(a4);
    cout << s << endl;

    a5 = Friends::goat;
    s = convertFriend(a5);
    cout << s << endl;

    a6 = Friends::chicken;
    s = convertFriend(a6);
    cout << s << endl;
}