#pragma once
#include <string>
#include "Person.h"
using namespace std;

class Student:public Person{
	int numberKours;
	string nameSpeciation;
public:
	Student(string surename, string name, string midleName, int year, int numberKours, string nameSpeciation);

	~Student();

	void  operator+();

	void Show();
};

