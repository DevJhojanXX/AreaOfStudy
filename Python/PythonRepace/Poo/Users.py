class Users:
    def __init__(self, nombre, apellido):
        self.nombre=nombre
        self.apellido = apellido

    def saludo (self):
        print("Hello my name is: ", self.nombre, self.apellido)
        

user = Users("Pedro","Ganzua")
user2 = Users("Laura","Rivera")

user.saludo()
user2.saludo()

user.nombre = "Juana"
user.saludo()

del user.nombre

user.saludo();