#include <iostream>
#include <map>
#include <thread> 
//#include "boost/multi_array.hpp"

using namespace std;

class mySum
{
	string mT;
public:

	mySum(const string& T) {
		mT = T;
	}

	void print() {
	
		cout << mT;
	}
};




void main() {


	//i1 = find(vec.begin(), vec.end(), 20);

	//Test* t = new Test();
	//	auto_ptr<Test> t( new Test());
	/*for (int i = 0; i < 10; i++) {
		
		cout << i;
		i+=10;
	}*/

	/*
	string a = "test";
	mySum t(a);
	t.print();
	*/
/*
	map<int, double> myMap; // = { {1,10.1},{2,20.1},{3,30.1} };
	const map<int, double>* myMapPtr = nullptr;

	map<int, double>::const_iterator itr = myMapPtr->find(10);
	if (itr == myMapPtr->end())
		cout << "test";
	*/
	//int n = 2;
	//if (myMapPtr)
		//itr = myMapPtr->find(n);

	//if (itr == myMapPtr->end())
		//cout << "true";
	//if(itr != myMapPtr->end())
		//cout << itr->second;
	//const int* t = nullptr;
	//int w = nullptr ? 1 : 2;
	//cout << w;

	printf("%-40s\n", "descr");

}

