#include "mystack.h"
#include <stdlib.h>

#pragma region STACK FUNCTIONS

/// <summary>
/// Pushing a stack item
/// </summary>
/// <param name="myStack"></param>
/// <param name="data"></param>
/// <returns></returns>
int push(MyStack* myStack, Data* data) {
	/// <summary>
	/// to design LL and add stuff
	/// </summary>
	/// <param name="myStack"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	MyStack* temp = new MyStack;
	/// <summary>
	/// add information to LL
	/// </summary>
	/// <param name="myStack"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	temp->data = data->key;
	temp->link = myStack->link;
	myStack->link = temp;

	return 0;
}

/// <summary>
/// Pop an item out of a stack
/// </summary>
/// <param name="myStack"></param>
/// <returns></returns>
Data* pop(MyStack* myStack) {
	if (myStack->link == NULL) {
		return NULL;
	}
	MyStack* temp = myStack->link;
	myStack->link = temp->link;
	Data* data = new Data();
	data->key = temp->data;
	delete(temp);
	return 0;
}
/// <summary>
/// To peek item from stack
/// </summary>
/// <param name="myStack"></param>
/// <returns></returns>
Data* top(MyStack* myStack)
{
	if (myStack->link == NULL) {
		return NULL;
	}
	else {
		Data* data = new Data();
		data->key = myStack->link->data;
	}
	return 0;
}
/// <summary>
/// To the last object in the stack
/// </summary>
/// <param name="myStack"></param>
/// <returns></returns>
Data* bottom(MyStack* myStack)
{
	if (myStack->link == NULL) {
		return NULL;
	}
	else {
		MyStack* temp = myStack->link;
		while (temp->link != NULL) {
			temp = temp->link;
		}
		Data* data = new Data();
		data->key = temp->data;
	}
	return 0;
}
/// <summary>
/// showing a stack item
/// </summary>
/// <param name="myStack"></param>
/// <returns></returns>
int stackLength(MyStack* myStack) {
	int count = 0;
	MyStack* temp = myStack->link;
	/// <summary>
	/// to count the stack of elements
	/// </summary>
	/// <param name="myStack"></param>
	/// <returns></returns>
	while (temp != NULL) {
		count++;
		temp = temp->link;
	}
	return count;
}

#pragma endregion