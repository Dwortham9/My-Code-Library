#include <iostream>

using namespace std;

int main()
{
	double feet, yards, miles, ounces, pounds;

	int choice = 0;
	while (choice != -1)
	{
		cout << "Do you want to 1=Convert feet to yards, 2=Convert feet to miles, or 3=Convert ounces to pounds? \n";
		cout << "-1 to quit\n";
		cin >> choice;

		if (choice == 1)
		{
			cout << "How many feet? > ";
			cin >> feet;

			yards = feet / 3.0;
			cout << "Yards: " << yards << endl;
		}
		else if (choice == 2)
		{
			cout << "How many feet? > ";
			cin >> feet;

			miles = feet / 5280;
			cout << "Miles: " << miles << endl;
		}
		else if (choice == 3)
		{
			cout << "How many ounces? > ";
			cin >> ounces;

			pounds = ounces / 16;
			cout << "Pounds: " << pounds << endl;
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