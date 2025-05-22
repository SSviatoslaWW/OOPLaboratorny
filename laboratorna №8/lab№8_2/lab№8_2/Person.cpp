#include "Person.h"

//����������� �� �������������
Person::Person() {
	name = firstName =midleName = "";
	year = 0;
}

//���������������� �����������
Person::Person( string firstName, string name, string midleName, int year) {
	this->name = name;
	this->firstName = firstName;
	this->midleName = midleName;
	this->year = year;
}

//����� ����
int Person::getYear() {
	return year;
}

//�������������� �������� <
bool Person::operator<(Person& person) {
	return this->year<person.year;
}



//�������������� �������� >
bool Person::operator>(Person& person) {
	return this->year > person.year;
}

//�������������� �������� ���������
ostream& operator<<(ostream& os, Person& person) {
	os << "�������: " << person.firstName << endl << "��'�: " << person.name << endl << "�� �������: " << person.midleName << endl << "³�: " << person.year << endl;
	return os;
}

//�������������� �������� float
Person::operator float() const{
	return static_cast<float>(year);
}

//�������� ��� ������ ������ ���� 18 ����
bool Person::predicatEighteenYearsPerson(Person& person) {
	return person.getYear() == 18;
}

//�������� ��� ������ ����� ���� 18+
bool Person::predicatMoreEighteenYearsPerson() {
	return this->year > 18;
}