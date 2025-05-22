#include "WriteTextInFile.h"
#include <fstream>

WriteTextInFile::WriteTextInFile(string nameFile):WorkWithFile(nameFile) {

}

void WriteTextInFile::writeTextInFile(fstream& file) {
	
	string writeData;
	cout << "Починайте запис у файл: " << endl;
	cin >> writeData;
	file << writeData << endl;
	cout << "Запис у файл пройшов успішно!!!" << endl;
}


fstream WriteTextInFile::openTextFile(int typeOpen) {
	return fstream();
}

void WriteTextInFile::readTextfromFile(fstream& file) {

}

void WriteTextInFile::closeTextFile(fstream& file) {

}


