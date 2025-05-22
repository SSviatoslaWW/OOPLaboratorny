#include "WorkWithFile.h"

WorkWithFile::WorkWithFile(string nameFile) {
	this->nameFile = nameFile;
}

WorkWithFile::~WorkWithFile() {
	cout << "Конструктор базового класу!" << endl;
}

string WorkWithFile::getNameFile() const {
	return nameFile;
}