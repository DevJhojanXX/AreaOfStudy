// @override
// es una propieda que me permite sobre escribir un metodo definido
void main(){
	final superman = Hero(name: 'Clarck Ken', power: 'volar');
	print( superman.toString() ); // no es necesario poner el toString aca
}
class Hero{
  String name;
  String power;
	Hero({
		required this.name,
		this.power = 'sin poder'
	});
	@override
	String toString(){
		return '$name - $power';
	}
}