#Digito los numeros
primerNumero = input ("Primer número: ")
operador = input ("Operador (+-*/): ")
segundoNumero = input ("Segundo número: ")

#Se determina el tipo de variable

primero = int(primerNumero)
segundo = int(segundoNumero)


#se digita el operador



#Hago las operaciones

if operador == "+":
	resultado = (primero + segundo)
	print(resultado)
elif operador == "-": 
	resultado = primero - segundo
	print(resultado)
elif operador == "*": 
	resultado = (primero * segundo)
	print(resultado)
elif operador == "/": 
	resultado = primero / segundo
	print(resultado)