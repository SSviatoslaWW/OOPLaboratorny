#include "Employee.h"
#include <cstdlib>
#include <iostream>
using namespace std;

Employee::Employee() {
	name = "";
	countTimeWork = 0;
	hourseSalary = 0;
}

Employee::Employee(string name) {
	this->name = name;
	countTimeWork =rand()%91;
	hourseSalary = 100+rand() % 701;
}

int Employee::sizePriceEmployee() {
	return countTimeWork * hourseSalary;
}

ostream& operator<<(ostream& os, Employee& ob) {
	os << "��'� ����������: " << ob.name << endl;
	os << "³���������� ������: " << ob.countTimeWork << endl;
	os << "��������� ������: " << ob.hourseSalary << endl;
	os << "��������: "<< ob.sizePriceEmployee()<<" ���" << endl;
	return os;
}
