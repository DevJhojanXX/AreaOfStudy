from Pet import Pet

class Main:
    def register(): 
        
        typeAnimal = input("Tipo de Animal: ")

        if typeAnimal == 'mascota':
            name = input("Nombre del animal: ")
            age = input("Edad del animal: ")
            jefe = input("Nombre del dueño de la mascota: ")

            pets = Pet(name, age,typeAnimal)
            pets.boss(jefe)
            pets.caller()



Main.register()
