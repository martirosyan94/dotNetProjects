#ifndef STACK_H_
#define STACK_H_

class Stack {

private:
	enum { MAX = 3 };
	int top;
	int items[MAX];

public:
	Stack();
	bool is_empty();
	bool is_full();
	bool push(int item);
	bool pop();
};


#endif
