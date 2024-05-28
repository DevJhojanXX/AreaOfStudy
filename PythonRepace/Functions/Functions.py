""" def llamame():
    print("Me puedes llamar al número 423434345")


llamame()


def user(email, password):
    print(email, " ", password)


email = input("Escribe tú email: ")
passwor = input("Escribe tú passwork:")

user(email, passwor)


def listado(*Listas):
    print(Listas)


def agregandoLista():
    obj1 = input("Escribe el nombre del Objeto: ")
    obj2 = input("Escribe el segundo objeto a agregar: ")

    listado(obj1, obj2)


def keyWorks(**kwargs):
    print(kwargs["nombre"], kwargs["apellido"])


def main():
    agregandoLista()
    keyWorks(nombre="felipe", apellido="Perez")


main()
 """

#Valor por defecto
def componente(Agumento = "Defauld"):
    print(Agumento)

componente("Rivera")
componente()

##Listado
def Listado (lista):
    for list in lista:
        print(list)

Listado(['Juanma', '00234', 'Rivera', "c0n2"])


#Capturando funciones en variables
def lista2(lista):
    x = ' '
    for element in lista:
        x = x + element + ' '
    return x

Lucas = lista2(['pecera', 'Ropas', 'Panelas'])
print(Lucas)

#recurcibidad
def Recurcion(i):
    if(i < 1):
        return i
    print(i)
    Recurcion(i - 1)

Recurcion(7)