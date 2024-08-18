#include <iostream>
//todo: stacks, queues, maps, 
struct Node{
    int date; 
    Node* next; 
};

int main(){
    Node* firts = new Node();
    Node* seccond = new Node();
    Node* third = new Node();
    
    firts -> date = 10;
    firts -> next = seccond; 

    seccond -> date = 20;
    seccond -> next = third; 

    third -> date = 30;
    third -> next = nullptr; 
    

    Node* current = firts;
    
    while(current !=nullptr){
        std::cout << " Dato: " << current->date << std::endl; 
        current = current -> next;  
    }

    delete firts;
    delete seccond;
    delete third; 

    return 0; 

}
