#include "LinkedList.h"
# include <iostream>
using namespace std;

LinkedList::LinkedList(){
	cout << "test";
	head = NULL;
	current = NULL;
	temp = NULL;

}

void LinkedList::addElement(int data) {
	current = head;
	temp = head;
	node* newElement = new node;
	newElement->data = data;
	newElement->next = NULL;

	if (head != NULL) {
		while (current != NULL) {
			temp = current;
			current = current->next;
		}

		temp->next = newElement;
	}
	else 
	{
		head = newElement;
	}

}

void LinkedList::deleteElement(int data) {
	node* delleted_node = NULL;
	current = head;
	temp = head;

	while(current->data != data){
		temp = current;
		current = current->next;
	}

	delleted_node = current;
	current = current->next;
	temp->next = current;
	delete delleted_node;
	
}

void LinkedList::printElements() {

	current = head;
	while (current != NULL) {
		cout << current->data << endl;
		current = current->next;
	}

}

