#include <iostream>
#include <stack>

int main(){
    std::stack<int> pile; 

    pile.push(1);
    pile.push(2);
    pile.push(3);
    pile.push(4);

    while (!pile.empty()){
        std::cout << "Elemento en la cima: " << pile.top() << std::endl;
        pile.pop();
    }

    return 0; 
}
