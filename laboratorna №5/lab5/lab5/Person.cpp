#include "Person.h"
#include <iostream>
using namespace std;

Person::Person(string surename, string name, string midleName, int year) {
	this->surename = surename;
	this->name=name;
	this->midleName = midleName;
	this->year = year;
}

Person::~Person() {
	cout << "Деструктор класу Person" << endl;
}

 void Person::operator+(){
	this->year++;	
 }

 void Person::Show() {
	 cout << "Прізвище: " << surename << endl;
	 cout << "Ім'я: " << name << endl;
	 cout << "По батькові: " << midleName << endl;
	 cout << "Вік: " << year << endl;
 }

