#include "Student.h"
#include <iostream>

using namespace std;

Student::Student(string surename, string name, string midleName, int year, int numberKours, string nameSpeciation):Person(surename,name,midleName,year){
	this->nameSpeciation = nameSpeciation;
	this->numberKours = numberKours;
}

Student::~Student() {
	cout << "Деструктор Student" << endl;
}

void Student::operator+() {
	this->numberKours++;

}

void Student::Show() {
	Person::Show();
	cout << "Назва спеціальності: " << nameSpeciation << endl;
	cout << "Номер курсу: " << numberKours << endl;
}
