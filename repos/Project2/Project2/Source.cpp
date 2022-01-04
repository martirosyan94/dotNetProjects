#include <iostream>
#include <set>

int main()
{
    std::set<char> mySet;
    mySet.insert('È');
    mySet.insert('È');
    mySet.insert('È');

    for (auto ch : mySet)
        std::cout << "È" << "\n";


    return 0;
}
