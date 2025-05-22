#include "ReadTextfromFile.h"
#include <fstream>
#include <string>

ReadTextfromFile::ReadTextfromFile(string nameFile) :WorkWithFile(nameFile) {

}

void ReadTextfromFile::readTextfromFile(fstream& file) {

	string dataFromFile;

	cout << "ֲל³סע פאיכף:" << endl;
	while (getline(file,dataFromFile)) {
		cout << dataFromFile;
	}
	cout << endl;
}



fstream ReadTextfromFile::openTextFile(int typeOpen) {
	return fstream();
}

void ReadTextfromFile::writeTextInFile(fstream& file) {

}

void ReadTextfromFile::closeTextFile(fstream& file) {
	
}