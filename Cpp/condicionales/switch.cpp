#include <iostream>

int main(){
    int option = 2; 
    switch(option){
        case 1: 
            std::cout << "Seleccionaste la opción 1. " << std::endl;
            break; 

        case 2: 
            std::cout << "Seleccionaste la opción 2. " << std::endl;
            break; 
        case 3: 
            std::cout << "Seleccionaste la opción 3. " << std::endl;
            break; 
        default: 
            std::cout << "Opcion invalidad. " << std::endl;
            break; 
    }
    return 0; 
}
