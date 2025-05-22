#pragma once
#include "WorkWithFile.h"

class ReadTextfromFile:public WorkWithFile{

	fstream openTextFile(int typeOpen)override;
	void writeTextInFile(fstream& file)override;
	void closeTextFile(fstream& file)override;

public:
	ReadTextfromFile(string nameFile);
	
	void readTextfromFile(fstream& file)override;
	
};

