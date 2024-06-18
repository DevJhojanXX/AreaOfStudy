
class Display: 
    __idDisplay = (int)
    __mark = ""
    __size = (float)
    __counterDisplay = (int)

    def __init__(self):
        self.__idDisplay = ++Display.__counterDisplay

    def __init__(self,mark, size:float) -> None:
        self.__mark = mark
        self.__size = size

    @property
    def mark(self):
        return self.__mark
    
    @mark.setter
    def mark(self, mark:str):
        self.__mark = mark

    @property
    def size(self):
        return self.__mark
    
    @size.setter
    def size(self, size:float):
        self.__size = size

    @property
    def idDisplay(self):
        return self.__idDisplay

    def __str__(self) -> str:
        return "Display:[id Display = {}, mark = {}, size={}]".format(self.__idDisplay, self.__mark, self.__size)