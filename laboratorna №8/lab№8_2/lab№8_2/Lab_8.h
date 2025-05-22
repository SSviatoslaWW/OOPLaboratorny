#pragma once
#include <iostream>

using namespace std;

class Lab_8{

	float variable;
public:
	Lab_8();
	Lab_8(float variable);

	friend ostream& operator<<(ostream& os, Lab_8& ob);

	bool operator>(Lab_8& ob);

	bool operator>(int i);

	bool operator<(Lab_8& ob);

	bool operator==(int i);
	
	float Variable() const;
	
};

