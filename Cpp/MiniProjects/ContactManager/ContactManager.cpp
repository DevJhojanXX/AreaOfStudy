/* Descripción: Crea un programa para almacenar y gestionar una lista de contactos. 
 * Cada contacto debe tener atributos como nombre, número de teléfono, 
 * y correo electrónico.
 * Estructuras utilizadas: struct, vector, map.
 * */
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
//Model
struct Contact{
    std::string name; 
    std::string email; 
    int number; 
    bool operator==(const Contact& other) const {
        return name == other.name && email == other.email && number == other.number;
    }
};

//packs
void print(const std::string& p){
        std::cout << p << std::endl; 
}
void println(const std::string& p){
        std::cout << p << "\n" << std::endl; 
}

// Main
int main(){
    //variables
    //Objects
    Contact contact = {"","", 0}; 

    // Vectors
    std::vector<Contact> contacts; 
    //String
    std::string name = ""; 
    std::string email = "";
    std::string name_update = ""; 
    std::string email_update = ""; 
    std::string name_delete = ""; 
    std::string menu = "0.Menu:\n 1. Show\n 2. Add\n 3. Update\n 4.Delete\n 5. exit";

    //Ints
    int sw = 0; 
    int number = 0; 
    int number_update = 0; 
    int option_update;
    int option; 
    
    //Program
    while(sw != 1 ){
        //Input
        println(" Write one option: "); 
        std::cin >> option; 
        println("");
        switch(option){
            case 0: 
                //Menu
                println(menu);
                break; 
            case 1: 
                //Show Contacts
                println("----------------------------"); 
                for(Contact contact : contacts){
                    println("----------------------------"); 
                    println("Name: " + contact.name ); 
                    println("Email: "+contact.email ); 
                    println("Number: " + std::to_string(contact.number)); 
                    println("----------------------------"); 
                } 
                println("----------------------------"); 
                break; 
            case 2:
                // Add Contacts
                println("Add name:  "); 
                std::cin >> name; 
                println("Add email:  "); 
                std::cin >> email; 
                std::cout << "\n" << std::endl; 
                println("Add number:  "); 
                std::cin >> number; 
                contact.name = name; 
                contact.email = email; 
                contact.number = number; 

                contacts.push_back(contact);
                break;
            case 3: 
                //update
                std::cout << "Input name to update:  \n" << std::endl; 
                std::cin >> name_update; 
                for(size_t i = 0; i < contacts.size(); i++){
                    if(contact.name == name_update){
                        println("What Date updte?:"); 
                        println("1 = name  "); 
                        println("2 = email  "); 
                        println("3 = number "); 

                        std::cin >> option_update; 
                        
                        switch (option_update){
                            case 1:
                                println("Write name update:"); 
                                std::cin >> name_update; 
                                contacts[i].name = name_update; 
                                break; 
                            case 2:
                                println("Write email update: "); 
                                std::cin >> email_update; 
                                contacts[i].email = email_update; 
                                
                                break; 
                            case 3:
                                println("Write number update: "); 
                                std::cin >> number_update; 
                                contacts[i].number = number_update; 
                                break; 
                        }
                    }
                }
                break; 
            case 4: 
                // Delete
                println("Write name to delete");
                std::cin >> name_delete; 
                for(const Contact& contact : contacts){
                    if(contact.name==name_delete ){
                       auto it = std::remove(contacts.begin(), contacts.end(), contact);
                       contacts.erase(it, contacts.end());
                    }
                }
                break; 
            case 5: 
                //exit
                sw = 1; 
                break; 
        }
    }
    return 0; 
}
