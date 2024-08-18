#include <iostream>
#include <queue>

int main(){
    std::queue<int> line; 
    
    line.push(1);
    line.push(2);
    line.push(3);
    line.push(4);

    while(!line.empty()){
        std::cout << " Elemento en el  frente: " << line.front() << std::endl; 
        line.pop(); 
    }

    return 0; 
}
