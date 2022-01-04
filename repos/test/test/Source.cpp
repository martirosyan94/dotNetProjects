#include <iostream>
using namespace std;

template <class T>
bool isequal(T& a, T& b) {
	return a == b;

}

int* g() {
	int i = 15;
	return &i;


}


void main() {

//	float a = 7.2, b = 7.2;

//	cout << isequal(a, b);
	
	int* f = g();

	cout << *f;



}
