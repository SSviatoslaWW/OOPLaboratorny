#include "OpenTextFile.h"
#include <fstream>

using namespace std;

OpenTextFile::OpenTextFile(string nameFile):WorkWithFile(nameFile) {
	
}

fstream OpenTextFile::openTextFile(int typeOpen) {
	fstream file;

	switch (typeOpen)
	{
	case 1:
		file.open(this->getNameFile(), ios::in);

		if (file.is_open()) {
			cout << "���� ������ �������� ��� ����������!" << endl;
		}
		else {
			throw exception("������� �������� �����!!!");
		}

		return file;
		break;
	case 2:
		file.open(this->getNameFile(), ios::out);

		if (file.is_open()) {
			cout << "���� ������ �������� ��� �����������!" << endl;
		}
		else {
			throw exception("������� �������� �����!!!");
		}

		return file;
		break;
	default:

		file.open(this->getNameFile());
		file.close();

		return file;
		break;
	}
	
}

void OpenTextFile::readTextfromFile(fstream& file) {

}

void OpenTextFile::writeTextInFile(fstream& file) {

}

void OpenTextFile::closeTextFile(fstream& file ) {
	
}