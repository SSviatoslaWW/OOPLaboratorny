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
	cout << "���������� ����� Person" << endl;
}

 void Person::operator+(){
	this->year++;	
 }

 void Person::Show() {
	 cout << "�������: " << surename << endl;
	 cout << "��'�: " << name << endl;
	 cout << "�� �������: " << midleName << endl;
	 cout << "³�: " << year << endl;
 }

