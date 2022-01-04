#include "LinkedList.h"
#include "iostream"
using namespace std;

class A {
public:
	void a() { b(); }
	void b() { cout << "b::A"; }
};

class B : virtual public A {

	void b() { cout << "b::B"; }
};



void main() {

	B b;
	b.a();

	/*
	LinkedList list1;
	list1.addElement(10);
	list1.addElement(20);
	list1.addElement(30);
	list1.addElement(40);

	list1.printElements();

	list1.deleteElement(20);
	list1.printElements();
	*/



}