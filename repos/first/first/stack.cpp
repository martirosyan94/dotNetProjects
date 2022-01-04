#include "stack.h"

Stack::Stack() {
	top = 0;
}

bool Stack::is_empty() {
	if (top == 0) {
		return true;
	} else {
		return false;
	}
}
bool Stack::is_full() {
	if (top == MAX) {
		return true;
	}
	else {
		return false;
	}

}
bool Stack::push(int item) {
	if (!is_full()) {
		items[top++] = item;
		return true;
	}

	return false;
}

bool Stack::pop() {
	if (!is_empty()) {
		top--;
		return true;
	}
	return false;
}

