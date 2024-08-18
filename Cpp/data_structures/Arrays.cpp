#include <iostream>

int main(){
    int numbers[5] = {1, 2, 3, 4, 5}; // Array of five integers
    for (int number : numbers){
        std::cout << "number: " << number << std::endl;
    }
    return 0; 
}
