#include <iostream>
#include "Windows.h"
#include <algorithm>
#include <cstdlib>
#include <vector>
#include <cmath> 

using namespace std;

void ShowArray1(int i) {
    cout << i << " ";
}

//Виведення елементів масиву
void ShowArray(int arr[],int n) {
    for (int i = 0; i < n; i++) {
        cout << arr[i] <<" ";
    }
    cout << endl;
}

//Перевірка на додатність числка предикат
bool isPositive(int x) {
    return x >= 0;
}

//Сума додатніх елементів
int SumPosistiveElement(int* arrIntNumber,int sizeArrIntNumber) {
    int Summ = 0;
    for (int i = 0; i < sizeArrIntNumber; i++) {
        if (isPositive(arrIntNumber[i])) {
            Summ += arrIntNumber[i];
        }
        else {
            Summ += 0;
        }
    }
     return Summ;
}

//Пошук мінімального по модулю значення
int searchAbsMin(int* arrIntNumber, int sizeArrIntNumber) {
    int min = arrIntNumber[0];

    for (int i = 1; i < sizeArrIntNumber; i++) {
        if (abs(arrIntNumber[i]) < abs(min)) {
            min = arrIntNumber[i];
        }
    }
    return min;
}

//Пошук максимального по модулю значення
int searchAbsMax(int* arrIntNumber, int sizeArrIntNumber) {
    int max = abs(arrIntNumber[0]);

    for (int i = 1; i < sizeArrIntNumber; i++) {
        if (abs(arrIntNumber[i]) > abs(max)) {
            max = arrIntNumber[i];
        }
    }
    return max;
}

//Добуток елементів масиву між min max по модулю
int DobAbsMinMax(int* arrIntNumber, int sizeArrIntNumber) {
    int dobb = 1;
    int absMin = searchAbsMin(arrIntNumber, sizeArrIntNumber);
    int absMax = searchAbsMax(arrIntNumber, sizeArrIntNumber);
    int* indexAbsMin = find(arrIntNumber, arrIntNumber+sizeArrIntNumber , absMin);
    int* indexAbsMax= find(arrIntNumber, arrIntNumber+sizeArrIntNumber, absMax);

    if ((indexAbsMin- arrIntNumber) > (indexAbsMax- arrIntNumber)) {
        for (int i = static_cast<int>(indexAbsMax - arrIntNumber); i <= static_cast<int>(indexAbsMin - arrIntNumber); i++) {
            dobb *= arrIntNumber[i];
        }
    }
    else {
        for (int i = (indexAbsMin - arrIntNumber); i <= (indexAbsMax - arrIntNumber); i++) {
            dobb *= arrIntNumber[i];
        }
    }
    return dobb;
}

//Предикат для алгоритму сортування
bool predicatSortingInDescending(int number1, int number2) {
    return number1 > number2;
}

int main(){
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    srand(static_cast<unsigned>(std::time(0)));

    int sizeArrIntNumber;
    cout << "Введіть розмір масиву n: ";
    cin >> sizeArrIntNumber;

    int* arrIntNumber=new int[sizeArrIntNumber];

    for (int i = 0; i < sizeArrIntNumber; i++) {
        arrIntNumber[i] = -100 + rand() % 200;
    }

    cout << "Масив рандомних чисел: " ;
    ShowArray(arrIntNumber, sizeArrIntNumber);
    
    cout << "Сума додатніх елементів масиву: "<< SumPosistiveElement (arrIntNumber,sizeArrIntNumber)<< endl;
   
    cout<<"Добуток елементів між мінімальним і максимальним значенням по модулю: "<<DobAbsMinMax(arrIntNumber, sizeArrIntNumber)<<endl;
    
    sort(arrIntNumber, arrIntNumber + sizeArrIntNumber, predicatSortingInDescending);

    cout << "Відсортований масив: ";
    ShowArray(arrIntNumber, sizeArrIntNumber);

    for_each(arrIntNumber, arrIntNumber + sizeArrIntNumber, ShowArray1);

    delete[] arrIntNumber;

}
