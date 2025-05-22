#pragma once
#include "WorkWithFile.h"

class WriteTextInFile:public WorkWithFile{

	fstream openTextFile(int typeOpen)override;
	void readTextfromFile(fstream& file)override;
	void closeTextFile(fstream& file)override;

public:
	WriteTextInFile(string nameFile);
	
	void writeTextInFile(fstream& file)override;
	
};

