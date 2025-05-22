#include <iostream>
#include "Windows.h"
#include <string>
#include "Person.h"
#include "Student.h"

using namespace std;

int main(){
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    Person *p;
    Person ob("Петренко", "Сергій","Степанович",45);

    p = &ob;

    cout << "Інформація особи до зміни віку: " << endl;
    p->Show();
    p->operator+();

    cout << "Інформація особи після зміни віку: " << endl;
    p->Show();

    Student ob1("Стерео", "Оксана", "Петрівна", 22, 2, "ІПЗ");
    p = &ob1;

    cout << "Інформація студента до зміни віку: " << endl;
    p->Show();
    p->operator+();

    cout << "Інформація студента після зміни віку: " << endl;
    p->Show();
    
}


