#pragma once
#include <string>

using namespace std;

class Employee{
	string name;
	int countTimeWork;
	int hourseSalary;
public:
	Employee();

	Employee(string name);

	int sizePriceEmployee();

	friend ostream& operator <<(ostream& ios, Employee& ob);
};

