#include <iostream>
using namespace std;

void print_letter_as_digit(char letter)
{
	letter = toupper(letter);
	switch (letter)
	{

	case 'A': case 'B': case 'C':
		cout << 2;
		break;

	case 'D': case 'E': case 'F':
		cout << 3;
		break;

	case 'G': case 'H': case 'I':
		cout << 4;
		break;

	case 'J': case 'K': case 'L':
		cout << 5;
		break;

	case 'M': case 'N': case 'O':
		cout << 6;
		break;
	case 'P': case 'Q': case 'R': case 'S':
		cout << 7;
		break;
	case 'T': case 'U': case 'V':
		cout << 8;
		break;
	case 'W': case 'X': case 'Y': case 'Z':
		cout << 9;
		break;

	default:

		cout << letter;
	}
}

int main()
{
	string phonenum = "1-800-PROGRAM";
	// modify to prompt the user for the
	// phonenum, rather than assign it
	// this default value

	for (char ch : phonenum)
		print_letter_as_digit(ch);

	cout << endl;
}