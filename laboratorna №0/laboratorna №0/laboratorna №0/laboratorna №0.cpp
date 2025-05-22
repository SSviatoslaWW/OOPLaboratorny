#include <iostream>
#include "OpenTextFile.h"
#include "WriteTextInFile.h"
#include "ReadTextfromFile.h"
#include "CloseTextFile.h"
#include "Windows.h"
#include <fstream>

using namespace std;

int funMenu() {
    int switchItem;

    cout << "Для якої події відкрити файл: " << endl;
    cout << " 1)Зчитування;" << endl;
    cout << " 2)Запису;" << endl;

    cin >> switchItem;

    return switchItem;
}





bool readToFileOrNot() {
    string tmpValue;
    cout << "Бажаєте зчитати вміст файлу? Так/Ні" << endl;
    cin >> tmpValue;

    if (tmpValue == "Так") {
        return true;
    }
    else {
        return false;
    }
}

bool writeInFileOrNot() {
    string tmpValue;
    cout<<"Бажаєте щось записати у файл? Так/Ні" << endl;
    cin >> tmpValue;

    if (tmpValue == "Так") {
        return true;
    }
    else {
        return false;
    }
}

string inputNameFile() {

    string nameFile;
    cout << "Введіть ім'я файлу: " << endl;

    cin >> nameFile;

    return nameFile;
}

int main(){
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    int switchItem;
    string nameFile;
    

    try {
        nameFile = inputNameFile();
        switchItem = funMenu();
        OpenTextFile openFile(nameFile);
        fstream myFile = openFile.openTextFile(switchItem);

        bool tmpValue;


        switch (switchItem)
        {
        case 1:
            tmpValue = readToFileOrNot();
            if (tmpValue) {
                ReadTextfromFile readTextfromFile(openFile.getNameFile());
                readTextfromFile.readTextfromFile(myFile);
            }
            else {
                CloseTextFile closeTextFile(openFile.getNameFile());
                closeTextFile.closeTextFile(myFile);
            }

            break;
        case 2:
            tmpValue = writeInFileOrNot();
            if (tmpValue) {
                WriteTextInFile writeInFile(openFile.getNameFile());
                writeInFile.writeTextInFile(myFile);
            }
            else {
                CloseTextFile closeTextFile(openFile.getNameFile());
                closeTextFile.closeTextFile(myFile);
            }

            break;
        default:
            break;
        }


        CloseTextFile closeTextFile(openFile.getNameFile());
        closeTextFile.closeTextFile(myFile);
    }
    catch (exception& e) {
        cout << e.what() << endl;
        return 0;
    }
    
    

}


