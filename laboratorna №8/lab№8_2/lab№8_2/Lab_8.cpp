#include "Lab_8.h"
#include <cstdlib>
#include <iostream>

using namespace std;

Lab_8::Lab_8() {
	variable = -100 + static_cast<float>(rand()) / (static_cast<float>(RAND_MAX / (200))) ;
}

Lab_8::Lab_8(float variable) {
	this->variable = variable;
}

ostream& operator<<(ostream& os, Lab_8& ob) {
	os << "Значення об'єкту: " << ob.variable<<endl;
	return os;
}

bool Lab_8::operator>(Lab_8 & ob) {
	return this->variable > ob.variable;
}

float Lab_8::Variable()const {
	return variable;
}

bool Lab_8::operator>(int i) {
	return this->variable > i;
}

bool Lab_8::operator<(Lab_8& ob) {
	return this->variable < ob.variable;
}

bool Lab_8::operator==(int i) {
	return this->variable == i;
}