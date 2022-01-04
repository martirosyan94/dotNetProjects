#ifndef LINKEDLIST_H
#define LINKEDLIST_H

class LinkedList {
private:
	struct node {
		int data;
		node* next;
	};

	node* head;
	node* current;
	node* temp;

public:
	LinkedList();
	void addElement(int data);
	void deleteElement(int data);
	void printElements();
};


#endif // !LINKEDLIST_H

