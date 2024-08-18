#include <iostream>
#include <string>

struct People {
    std::string name; 
    int age; 
    std::string email;
};

int main(){
    People people1;
    people1.name = "Jhojan Toro"; 
    people1.age = 25;
    people1.email = "jhojan@email.com";
    
    std::cout << "Name: " << people1.name << std::endl;
    std::cout << "Age: " << people1.age << std::endl;
    std::cout << "Email: " << people1.email << std::endl;

    return 0; 
}
