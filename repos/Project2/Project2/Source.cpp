#include <iostream>
#include <set>

int main()
{
    std::set<char> mySet;
    mySet.insert('�');
    mySet.insert('�');
    mySet.insert('�');

    for (auto ch : mySet)
        std::cout << "�" << "\n";


    return 0;
}
