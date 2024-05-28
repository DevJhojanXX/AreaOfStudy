from TypeEntry import Entry

class Mause(Entry):
    __idMouse = (int)   
    __CounterMause = (int)
    def __init__(self, mark, typeEntry) :
        super().__init__(mark, typeEntry)
        self.__idMouse = ++Mause.__CounterMause
    
    
    def __str__(self) :
        return "Mouse: [id Mouse = {}]".format(self.__idMouse), super().__str__()

