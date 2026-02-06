#include <iostream>

using namespace std;

int main()
{
    double p, v, n, t;
    const float r = 0.0821;
    /*p is gas pressure in atmospheres
    v is volume of gas in liters
    n is quantity in moles
    r is the ideal gas constant
    t is temperature in Kelvin*/

    //asking the user
    cout << "What is the volume of the gas in liters? ";
    cin >> v;
    cout << "What is the temperature in Kelvin? ";
    cin >> t;
    cout << "How many moles of the gas are present? ";
    cin >> n;

    //The math!!!
    p = n * r * t / v;

    //The output
    cout << "The pressure is " << p << " atmospheres.";

    return 0;
}