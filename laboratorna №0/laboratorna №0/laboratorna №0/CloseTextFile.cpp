#include "CloseTextFile.h"
#include <fstream>

CloseTextFile::CloseTextFile(string nameFile) :WorkWithFile(nameFile) {

}


void CloseTextFile::closeTextFile( fstream& file) {

	file.close();
	cout << "Файл успішно закритий!!" << endl;	
}


fstream CloseTextFile::openTextFile(int typeOpen) {
	return fstream();
}

void CloseTextFile::writeTextInFile(fstream& file) {

}

void CloseTextFile::readTextfromFile(fstream& file) {

}
