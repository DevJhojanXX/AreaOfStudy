#include <iostream>
#include <map>

int main(){
    std::map<std::string, int> ages; 

    ages["Jhojan"] = 20; 
    ages["Danilo"] = 30; 
    ages["Toro"] = 50; 
    ages["Perez"] = 60; 
    ages["True"] = 33; 


    std::cout << "La edad de Jhojan es: " << ages["Jhojan"] << std::endl; 

    for(const auto& age : ages){
        std::cout << age.first << " tiene : " << age.second << " años." << std::endl; 
    }
    return 0; 
}

