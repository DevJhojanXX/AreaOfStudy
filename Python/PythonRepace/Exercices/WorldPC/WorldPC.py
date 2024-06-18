from Order import Order
from Computer import Computer
from Display import Display
from KeyBoard import KeyBoard
from Mause import Mause

class WorldPc:
    def Main():
        displayHp:Display = Display("HP",13)
        keyBoardHP:KeyBoard = KeyBoard("HP","usb")
        mouseHP:Mause = Mause("HP","USB")

        computerHP:Computer=Computer("Hp pavilion",displayHp,keyBoardHP,mouseHP)

        orderOne:Order = Order()
        orderOne.addComputer(computerHP)

        orderOne.showOrder()

WorldPc.Main()