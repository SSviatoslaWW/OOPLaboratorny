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
	os << "Ім'я працівника: " << ob.name << endl;
	os << "Відпрацбовані години: " << ob.countTimeWork << endl;
	os << "Погодинна ставка: " << ob.hourseSalary << endl;
	os << "Зарплата: "<< ob.sizePriceEmployee()<<" грн" << endl;
	return os;
}
