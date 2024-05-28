Usuario = ["camilo@email.com", "Contraceña"]

for user in Usuario: 
    print(user)

user = input("Ingresa la contracena=")

count = 0
for x in user:
    count += 1
    print(x)
    
print("Tiene un total de ", count, " letras") 

for c in range(1,5):
    print(c)