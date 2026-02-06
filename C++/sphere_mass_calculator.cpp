#define _USE_MATH_DEFINES  
#include <iostream>
#include <cmath>
#include <string>
#include <fstream>
#include <cassert>

// for fixed and setprecision
#include <iomanip>

using namespace std;

void menu1()
{
    cout << "We will calculate the mass of a "
        << "sphere based on its size and "
        << "material.\n\n";

    cout << "Choose the material of the sphere :\n";
    cout << "\t1 Ice\n"
        << "\t2 Aluminum\n"
        << "\t3 Gold\n"
        << "\t4 Iron\n"
        << "\t5 Cedar\n"
        << "\t6 Soil, dry\n"
        << "\t7 Paper\n"
        << "\t8 Osmium\n";
    return;

}

void menu2()
{
    cout << endl;
    cout << "Choose the size of the sphere :\n"
        << "\t1 Marble\n"
        << "\t2 Golf ball\n"
        << "\t3 Baseball\n"
        << "\t4 Basketball\n"
        << "\t5 Beach ball\n"
        << "\t6 Exercise ball\n";
    return;
}

double get_density(int material)
{
    double density;
    switch (material)
    {
    case 1: // ice
        density = 55;  // lbs per cubic foot
        break;
    case 2: // aluminum
        density = 168; // lbs per cubic foot
        break;
    case 3: // gold
        density = 1203; // lbs per cubic foot
        break;
    case 4: // Iron
        density = 491; // lbs per cubic foot
        break;
    case 5: // Cedar
        density = 22; // lbs per cubic foot
        break;
    case 6: // Soil, dry
        density = 80; // lbs per cubic foot
        break;
    case 7: // Paper
        density = 33; // lbs per cubic foot
        break;
    case 8: // Osmium
        density = 1402.25; // lbs per cubic foot
        break;
    default:
        cout << "Unknown material.  Setting density = 1\n";
    }
    return density;
}

double get_diameter(int size_choice)
{
    double diameter;
    switch (size_choice)
    {
    case 1: //Marble
        diameter = 0.05; // cubic feet
        break;
    case 2: //Golf ball
        diameter = 0.14; // cubic feet
        break;
    case 3: //Baseball
        diameter = 0.24; // cubic feet
        break;
    case 4: //Basketball
        diameter = 0.80; // cubic feet
        break;
    case 5: //Beach ball
        diameter = 1.67; // cubic feet
        break;
    case 6: //Exercise ball
        diameter = 2.50; // cubic feet
        break;
    default:
        cout << "Unknown size.  Setting diameter = 1\n";
        diameter = 1;  // cubic feet
    }
    return diameter;
}


int main()
{
    int material, size_choice;
    double density = 0, // lbs per cubic foot
        radius = 0,    // feet
        volume = 0,    // cubic inches
        diameter = 0,  // feet;
        mass = 0;      // weight in lbs

    menu1();
    cout << ">";
    cin >> material;

    menu2();
    cout << ">";
    cin >> size_choice;

    density = get_density(material);
    diameter = get_diameter(size_choice);


    radius = diameter * 0.5;
    volume = 4.0 / 3.0 * M_PI * pow(radius, 3);
    mass = volume * density;

    cout << "The density is " << density
        << " lbs per cubic foot\n";
    cout << "The diameter is " << diameter
        << " feet\n";
    cout << "The radius is " << radius
        << " feet\n";
    cout << "The volume is " << volume
        << " cubic feet\n";
    cout << "The mass is " << mass
        << " pounds\n";
}
