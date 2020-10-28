#include <iostream>

using namespace std;

void work(int salary, bool vac)
{
	if (salary < 20000)
	{
		cout << "Salary is lower, than 20.000 rubs. (" << salary << " < 20000)" << endl;
	}
	if (vac == true)
	{
		cout << "Ah, you chilling now? You must work!" << endl;
	}
}
int main()
{
	work(18500, true);
	cin.get();
	return 0;
}