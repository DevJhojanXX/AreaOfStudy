
from Display import Display
from KeyBoard import KeyBoard
from Mause import Mause
class Computer:
    __idComputer = (int)
    __markComputer = ""
    __display = (Display)
    __keyBoard = (KeyBoard)
    __mouse = (Mause)
    __counterComputers = (int)

    def __init__(self) :
        self.__idComputer = ++Computer.__counterComputers

    def __init__(self, markComputer, display:Display, keyboard:KeyBoard, mouse:Mause) :
        self()
        self.__markComputer = markComputer
        self.__display = display
        self.__keyBoard =keyboard
        self.__mouse = mouse
    
    @property
    def markComputer(self):
        return self.__markComputer
    
    @markComputer.setter
    def markComputer(self, markComputer:str):
        self.__markComputer = markComputer
    
    @property
    def display(self):
        return self.__display
    
    @display.setter
    def display(self, display:Display):
        self.__display = display
    
    @property
    def keyBoard(self):
        return self.__keyBoard
    
    @keyBoard.setter
    def keyBoard(self, keyBoard:KeyBoard):
        self.__keyBoard = keyBoard

    @property
    def mouse(self):
        return self.__mouse
    
    @mouse.setter
    def mouse(self, mouse:Mause):
        self.__mouse = mouse

    def __str__(self) -> str:
        return "Computer: ( id Computer = {}, Mark = {}, Display = {}, KeyBoard = {}, Mouse = {}".format(self.__idComputer, self.__markComputer, self.__display, self.__keyBoard, self.__mouse)
