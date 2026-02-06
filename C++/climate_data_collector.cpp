#include <iostream>
#include <string>
#include <iterator>
using namespace std;

int main()
{
    const int size = 12;
    string months[size] = { "JAN","FEB","MAR",
    "APR", "MAY","JUN","JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

    int num_elements = sizeof(months) /
        sizeof(string);

    int temp[size] = { 0 };

    for (int i = 0; i < size; i++)
        temp[i] = 0;

    int items_added = 0;

    for (int i = 0; i < size; i++)
    {
        cout << "Enter temperature for " <<
            months[i] << ", or Q to quit >";

        string s;
        cin >> s;
        if (s == "Q" || s == "q")
            break;
        int x = stoi(s);

        temp[i] = x;
        items_added = i + 1;
    }
    double total = 0;
    for (int i = 0; i < items_added; i++)
        total += temp[i];
    double average = total / items_added;
    cout << "----------------------" << endl;
    cout << "Temperature/Months " << endl;
    cout << "----------------------" << endl;
    for (int i = 0; i < items_added; i++)
        cout << months[i] << " :" <<
        temp[i] << endl;

    cout << "----------------------"<< endl;
    if (items_added > 0)
    {
        cout << "average = " << average << endl;
    } // endif (items_added > 0)
}
