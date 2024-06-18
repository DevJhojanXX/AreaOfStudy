from TypeEntry import Entry

class KeyBoard(Entry):
    __idKeyBoard = (int)
    __CounterKeyBoard = (int)
    def __init__(self, mark, typeEntry:str) :
        super().__init__(mark, typeEntry)
        self.__idKeyBoard = ++KeyBoard.__CounterKeyBoard

    def __str__(self) -> str:
        return "KeyBoard: [id KeyBoard = {}]".format(self.__idKeyBoard), super().__str__()
