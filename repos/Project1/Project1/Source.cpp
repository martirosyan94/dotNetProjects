#include <iostream>
#include <map>
#include <vector>
#include <string>
#include <sstream>
#include <regex>
#include <filesystem>
void test(std::shared_ptr<std::map<double, std::string>> mfoo)
{
	mfoo->insert({ 10,"a" });
	mfoo->insert({ 100,"b" });
}

void main() 
{
	std::shared_ptr<std::map<double, std::string>> foo = std::make_shared<std::map<double, std::string>>();
	
	test(foo);

	//for (auto iter = foo->begin(); iter != foo->end(); ++iter) {
	//	std::cout << iter->second << "\n";


		std::string my_str = "text 5 5 10 10";
		std::vector<std::string> out ;

		std::stringstream ss(my_str);
		std::string word;
		while (ss >> word) {
			std::cout << word << "\n";
		}
		std::string ms = "chip_suffix 5 5 10 10";
		if (std::regex_match(ms, std::regex("[a-z]"))) {
			std::cout << "found\n";
		}

		std::string name = "s.txt";

		auto x = [](std::string name) {return name + "_suffix"; };
		std::cout<< typeid(x).name();
}