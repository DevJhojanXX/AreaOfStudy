// Funciones y parametros functions.dart
// con void no esperes ninguna funcion de retorno
void main(){
	print( greetEveryOne());
	print ('Suma: ${ addTwoNumbers(10, 20 ) }');
	print (greetPerson(name: 'Fernando', message: 'hi,'));
}

String greetEveryOne(){
	return 'Hello everione!';
}

// Funciones de flecha
// las funciones de flecha son de una sola linea
String greetHello() {
  return 'Hello';
}

// siempre es poner los argumentos con el tipado
// se puede poner sin tipado los argumentos pero retornara un error en la copilación
int addTwoNumbers(int a,int b) {
  return a+b;
}

// argumentos opcionales
int addSum(int a, [int? b = 0]){
//op	b = b ?? 0;
//op	b ?? = 0; 
	return a + b!;
}

// mas de un argumento opcional

// argumentos opcionales y por nombre
// cuando se ponen llaves siempre se pone automaticamente opcionales
// el required obliga a que halla almenos un argumento
String greetPerson({required String name, String message = 'Hola ,'}){
	return ' $message $name '; 
}
