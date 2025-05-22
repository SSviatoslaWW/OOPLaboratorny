#pragma once
#include <iostream>

using namespace std;

class WorkWithFile {
	string nameFile;
	
public:
	WorkWithFile(string nameFile);
	string getNameFile() const;
	virtual fstream openTextFile(int typeOpen) = 0;
	virtual void writeTextInFile(fstream& file) = 0;
	virtual void readTextfromFile(fstream& file) = 0;
	virtual void closeTextFile(fstream& file) = 0;
	~WorkWithFile();

};

