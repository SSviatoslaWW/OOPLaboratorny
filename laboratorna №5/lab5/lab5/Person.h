#pragma once
#include <string>
using namespace std;

class Person{

	string surename;
	string name;
	string midleName;
	int year;
public:
	Person(string surename, string name, string midleName, int year);

	~Person();

	virtual void operator+();

	virtual void Show();

};

