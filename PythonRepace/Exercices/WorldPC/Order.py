
from Computer import Computer
class Order:
    __idOrder = (int)
    __computers:Computer = []
    __MAX_COMPUTER = 10
    __counterOrder = (int)
    __counterComputers = (int)

    def __init__(self) :
        self.__idOrder = ++Order.__counterOrder
        self.__computers = Computer[Order.__MAX_COMPUTER]

    def addComputer(self, computer:Computer):
        if self.__counterComputer < Order.__MAX_COMPUTER:
            self.__computers.append(computer)
            self.__counterComputers += 1
        else:
            print("Has superado el limite: ", Order.__MAX_COMPUTER)

    def showOrder(self):
        print("Order #:", self.__idOrder)
        for i in range(self.__counterComputers):
            print(self.__computers[i])
