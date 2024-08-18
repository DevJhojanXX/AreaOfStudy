#include <iostream>

int main(){

    int edad = 21;
    
    if(edad < 13){
        std::cout << "Eres un niño." << std::endl;
    }
    else if (edad < 18){
        std::cout << "Eres un adolecente." << std::endl;
    }
    else if (edad < 65){
        std::cout << "Eres un adulto. " << std::endl;
    }
    else {
        std::cout << "Eres un adulto mayor." << std::endl;
    }

    return 0; 
}
