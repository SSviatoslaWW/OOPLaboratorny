#pragma once
#include "WorkWithFile.h"

class OpenTextFile:public WorkWithFile{
	void writeTextInFile(fstream& file)override;
	void readTextfromFile(fstream& file)override;
	void closeTextFile(fstream& file)override;
public:
	OpenTextFile(string nameFil);
	fstream openTextFile(int tupeOpen)override;
	

};

