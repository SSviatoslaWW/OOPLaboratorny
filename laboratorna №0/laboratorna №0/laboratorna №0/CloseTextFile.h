#pragma once
#include "WorkWithFile.h"


class CloseTextFile:public WorkWithFile{

	fstream openTextFile(int typeOpen)override;
	void writeTextInFile(fstream& file)override;
	void readTextfromFile(fstream& file)override;

public:

	CloseTextFile(string nameFile);
	
	void closeTextFile( fstream& file)override;
};

