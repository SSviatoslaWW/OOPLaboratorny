#pragma once
#include <iostream>
#include <string>

using namespace std;
class Person{
	string name;
	string firstName;
	string midleName;
	int year;
public:
	Person();
	Person( string firstName, string name, string midleName,int year);

	int getYear();

	bool operator<(Person& person);
	bool operator>(Person& person);
	friend ostream& operator<<(ostream& os, Person& person);

	operator float()const;

	static bool predicatEighteenYearsPerson(Person& person);
	bool predicatMoreEighteenYearsPerson();
};

