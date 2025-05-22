#include <iostream>
#include "Windows.h"
#include <vector>
#include "Employee.h"

using namespace std;

int SummSalary(vector<Employee*> vec) {
	int tmpSumm = 0;
	for (vector<Employee*>::iterator i = vec.begin(); i < vec.end(); i++) {
		tmpSumm += (*i)->sizePriceEmployee();
	}

	return tmpSumm;
}

int main(){
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	srand(static_cast<unsigned>(std::time(0)));

	Employee person[5] = { Employee("Сергій"),Employee("Микола") ,Employee("Андрій"),Employee("Семен"),Employee("Петро") };

	Employee *p = person;
	vector<Employee*> vec;
	for (int i = 0; i < 5; i++) {
		vec.push_back(p);
		p++;
	}
	p = person;
	cout << "Заповнений вектор:" << endl<<endl;
	for (int i = 0; i < vec.size(); i++) {
		p = &person[i];
		cout << "Працівник №"<<i+1 << endl;
		cout << *p << endl;
		p++;
	}

	cout << "Загальна сума на оплату праці: "<<SummSalary(vec)<<" грн" << endl;

	
}

