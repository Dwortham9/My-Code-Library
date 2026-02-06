#define _USE_MATH_DEFINES
#include <iostream>
#include <cmath>
#include <string>
#include <cassert>
#include <iomanip>
using namespace std;

class Sphere
{
private:
    double radius;
public:
    Sphere(double radius)
    {
        // constructor
        cout << "Creating sphere with radius "
            << radius << endl;
        this->radius = radius;
    }
    double surface_area()
    {
        double s_a = 4 * M_PI * pow(radius, 2);
        return s_a;
    }
};

int main()
{
    int radius = 35;
    Sphere *s1 = new Sphere(radius);
    double surface_area = s1->surface_area();
    cout << "area of sphere with radius = ";
    cout << radius << " is " << surface_area << endl;
}

