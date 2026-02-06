#include <iostream>

using namespace std;

int main()
{
	double radius, volume, surface_area;
	double pie = 3.141592653589793238462643;

	int choice = 0;
	while (choice != -1)
	{
		cout << "Do you want 1=Surface area, or 2=Volume? \n";
		cout << "-1 to quit";
		cin >> choice;

		if (choice == 1)
		{
			cout << "What is the radius? >";
			cin >> radius;

			surface_area = 4 * pie * (radius * radius);
			cout << "The surface area is about " << surface_area << endl;
		}
		else if (choice == 2)
		{
			cout << "What is the radius? >";
			cin >> radius;

			volume = (4 * pie * radius * radius * radius) / 3;
			cout << "The volume is about " << volume << endl;
		}
		else if (choice == -1)
		{
			cout << "Ok, bye\n";
		}
		else
		{
			cout << "Invalid choice\n";
		}
	}
	return 0;
}
