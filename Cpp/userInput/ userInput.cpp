#include <iostream>
#include <string>

int main(){
    int sw = 0; 
    std::string email; 
    std::string password; 
    int edad;
    int counter = 3;  
    while(sw!=1){
        std::cout << "Ingrese el correo:\n"; 
        std::getline(std::cin, email);

        std::cout << "Ingrese la contraceña:\n"; 
        std::getline(std::cin, password);
        for(int i= 0; i <= 3; i++){
            if (counter == 0){ 
                std::cout << "Se acabaron los intentos\n";
                sw = 1;
                break;
            }
            if (email != "jhojan@email.com" || password != "3lm3i0r"){
                counter--;
                std::cout << "Correo o Contraceña  incorrecta\n";
                std::cout << "Quedan " << counter << " intentos \n";
                break;
            }
            else{
                std::cout << "Welcome Jhojan \n";
                sw=1;
                break;
            }
        }
        
    }
    return 0;
}
