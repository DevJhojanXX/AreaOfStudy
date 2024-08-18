#include <iostream>
#include <vector>

int main(){
    std::vector<int> numbers;
    numbers.push_back(10);
    numbers.push_back(20);
    numbers.push_back(30);
    numbers.push_back(40);
    numbers.push_back(50);

    for(int number : numbers){
        std::cout << "Elemento: " << number << std::endl; 
    }

    std::cout << " El tamaño del vector es. " << numbers.size() << std::endl; 
    
    return 0; 
}
