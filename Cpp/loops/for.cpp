#include <iostream>

int main(){
    for(int i = 0; i < 10; i++){
        if(i == 5){
            break;
        }
        if(i % 2 == 0){
            continue; 
        }
        std::cout << "i: " << i << std::endl;
    }
    return 0; 
}
