
class Entry:
    __mark = ""
    __typeEntry = ""
    def __init__(self, mark:str, typeEntry:str) :
        self.__mark = mark
        self.__typeEntry = typeEntry
    

    @property
    def mark(self):
        return self.__mark

    @mark.setter
    def mark(self, mark:str):
        self.__mark = mark

    @property
    def typeEntry(self):
        return self.__typeEntry
    
    @typeEntry.setter
    def typeEntry(self, typeEntry:str):
        self.__typeEntry = typeEntry

    def __str__(self) -> str:
        return "Mark={}, Type of Entry = {}".format(self.__mark, self.__typeEntry)

