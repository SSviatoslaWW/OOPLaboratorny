#include "Person.h"

//Конструктор за замовчуванням
Person::Person() {
	name = firstName =midleName = "";
	year = 0;
}

//Параметризований конструктор
Person::Person( string firstName, string name, string midleName, int year) {
	this->name = name;
	this->firstName = firstName;
	this->midleName = midleName;
	this->year = year;
}

//Гетер років
int Person::getYear() {
	return year;
}

//Перевантажений оператор <
bool Person::operator<(Person& person) {
	return this->year<person.year;
}



//Перевантажений оператор >
bool Person::operator>(Person& person) {
	return this->year > person.year;
}

//Перевантажений оператор виведення
ostream& operator<<(ostream& os, Person& person) {
	os << "Прізвище: " << person.firstName << endl << "Ім'я: " << person.name << endl << "По батькові: " << person.midleName << endl << "Вік: " << person.year << endl;
	return os;
}

//Перевантажений оператор float
Person::operator float() const{
	return static_cast<float>(year);
}

//Предикат для пошуку людини віком 18 років
bool Person::predicatEighteenYearsPerson(Person& person) {
	return person.getYear() == 18;
}

//Предикат для пошуку людей віком 18+
bool Person::predicatMoreEighteenYearsPerson() {
	return this->year > 18;
}