#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    for(int x = 1; x <= 10; x++)
    {
        cout << setw(5) << x 
            << setw(5) << pow(2, x) 
            << setw(5) << pow(x, 2) << endl;
        
    }
}

