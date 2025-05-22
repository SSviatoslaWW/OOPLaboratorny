#include <iostream>
#include "Windows.h"
#include <algorithm>
#include <functional>
#include <cstdlib>
#include <deque>
#include "Person.h"
#include <vector>
#include <stack>

using namespace std;

//Виведення черги
void showDeque(deque<Person> Deque) {
    for (int i = 0; i < Deque.size(); i++) {
        cout << Deque[i] << endl;
    }
}

//Виведення стеку
void showStack(stack<float> Stack) {
    while (!Stack.empty()) {
        cout << Stack.top() << " ";
        Stack.pop();
    }
    cout << endl;
}

//Виведення вектора
void showVector(vector<float> Vector) {
    for (int i = 0; i < Vector.size(); i++) {
        cout << Vector[i] << " ";
    }
    cout << endl;
}

//Сортування черги по спаданню алгоритмом sort
void sortDequeDeclineAlgoritms(deque<Person>& Deque) {
    sort(Deque.begin(), Deque.end(), [](Person& a, Person& b) {
        return a > b;
        });
}

//Пошук потрібного елемента в черзі через алгоритм find_if
deque<Person>::iterator findIfAlgoritms(deque<Person>& Deque) {
    auto searchPerson = find_if(Deque.begin(),Deque.end(),Person::predicatEighteenYearsPerson);
    return searchPerson;
}

//Копіювання елементів одного контейнера в інший за умовою
void copyIfElementDequeInStact(deque<Person>& Deque, stack<float>& Stack) {
    for (deque<Person>::iterator it = Deque.begin(); it != Deque.end();++it) {
        if (it->predicatMoreEighteenYearsPerson()) {
            Stack.push(*it);
        }
    }
}

//Сортування черги по зростанню
void sortDequeGrowthAlgoritms(deque<Person>& Deque) {
    sort(Deque.begin(), Deque.end(),less<Person>());
}

//Переміщення стеку у чергу
deque<float> movementStackInDeque(stack<float>& Stack) {
    deque<float> dequeSortingStack;
    while (!Stack.empty()) {
        dequeSortingStack.push_back(Stack.top());
        Stack.pop();
    }
    return dequeSortingStack;
}

//Переміщення Черги у стек
stack<float> movementDequeInStack(deque<float>& dequeSortingStack) {
    stack<float> stackWithVectorSortingStack;
    for (int i = 0; i < dequeSortingStack.size(); i++) {
        stackWithVectorSortingStack.push(dequeSortingStack[i]);
    }
    
    return stackWithVectorSortingStack;
}

//Сортування стеку по зростанню
void sortStackGrowthAlgoritms(stack<float>& Stack) {
    deque<float> dequeSortingStack= movementStackInDeque(Stack);
    sort(dequeSortingStack.begin(), dequeSortingStack.end(), [](float& a, float& b) {
        return a > b;
        });
    Stack = movementDequeInStack(dequeSortingStack);
}

//Злиття черги і стеку у векторі
vector<float> mergeDequeAndStack(deque<Person>& Deque, stack<float>& Stack) {
    vector<float> thirdContainer;
    copy(Deque.begin(), Deque.end(), back_inserter(thirdContainer));

    while (!Stack.empty()) {
        thirdContainer.push_back(Stack.top());
        Stack.pop();
    }
    return thirdContainer;
}

//Умова пошуку в контейнері
bool numberMoreTwenty(float number) {
    return number > 20;
}

//Перевікра на кількість відповідних елементів в контейнері
int coutIfAlgoritms(vector<float>& Vector) {
    return static_cast<int>(count_if(Vector.begin(), Vector.end(), numberMoreTwenty));
}

int main(){
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    srand(static_cast<unsigned>(std::time(0)));

    deque<Person> Deque;
    stack<float> Stack;
    vector<float> thirdContainer;
    Person person[5] = { Person("Петренко","Сергій","Степанович",20),
                         Person("Коваль","Петро","Павлович",18),
                         Person("Бородач","Андрій","Андрійович",39),
                         Person("Конотоп","Семен","Іванович",55),
                         Person("Каразін","Олег","Миронович",27)};

    for (int i = 0; i < 5; i++) {
        Deque.push_back(person[i]);
    }
    cout << "                           Створена черга: " << endl;
    showDeque(Deque);

    sortDequeDeclineAlgoritms(Deque);
    cout << "                           Відсортована черга: " << endl;
    showDeque(Deque);

    cout << "                           Персона з віком 18 років: " << endl;
    cout << *findIfAlgoritms(Deque);

    copyIfElementDequeInStact(Deque, Stack);
    cout << "                           Стек з віком людей 18+: " << endl;
    showStack(Stack);

    sortDequeGrowthAlgoritms(Deque);
    cout << "                           Відсортована черга: " << endl;
    showDeque(Deque);
    sortStackGrowthAlgoritms(Stack);
    cout << "                           Відсортований стек: " << endl;
    showStack(Stack);

    thirdContainer = mergeDequeAndStack(Deque, Stack);
    cout << "                           Злиття черги і стеку: " << endl;
    showVector(thirdContainer);

    cout << "                           Кількість елементів більших за 20: " <<endl<< coutIfAlgoritms(thirdContainer)<< endl;
    return 0;
}

