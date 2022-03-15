#include <iostream>
using namespace std;

float del(float a, float b) {
    if (b == 0) { throw b; }
    else return a / b;
}

int main()
{
    int numb1,numb2;
    cout << "Enter digit 1\nEnter:";
    cin >> numb1;
    cout << "Enter digit 2\nEnter:";
    cin >> numb2;
    try {
        cout << "Answer: " << del(numb1, numb2);
    }
    catch (const float ex) {
        cout << "Error: digit 2 can't be 0!\n";
    }
}
