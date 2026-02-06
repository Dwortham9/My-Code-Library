#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	srand(time(NULL));

	for (int i = 1; i <= 100; i++)
	{
		cout << rand() % 100 + 1;

	}
	
}

