// HW10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int add3(int, int, int);
int add4(int, int, int, int);
int double_me(int);
int triple_me(int);

int main()
{
    int result = add3(1, 2, 3);
    cout << result <<endl;
    result = add4(10, 20, 30, 40);
    cout << result << endl;
    result = double_me(20);
    cout << result << endl;
    result = triple_me(60);
    cout << result << endl;

}//end of main()
int add3(int x1, int x2, int x3)
{
    int result = x1 + x2 + x3;
    cout << "The sum is " << result << endl;
    return 0;
}//end of add3

int add4(int x1, int x2, int x3, int x4)
{
    int result = x1 + x2 + x3 + x4;
    cout << "The sum is " << result << endl;
    return 0;
}//end of add4

int double_me(int x)
{
    int result = x * 2;
    cout << "The result is " << result << endl;
    return 0;
}//end of double_me

int triple_me(int x)
{
    int result = x * 3;
    cout << "The result is " << result << endl;
    return 0;
}//end of triple_me