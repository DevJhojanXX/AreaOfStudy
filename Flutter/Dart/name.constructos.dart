// Construntores con nombre name.constructors.dart
void main(){
	// llamada a un constructor normal
	final iroman = Hero(
		isAlive: false,
		power: 'Money',
		name: 'Tony Stark'
	); 
	print( iroman); 
	
	// llamando al constructor con nombre
	final Map<String, dynamic> rawJson = {
		'name': 'Clarck Ken',
		'power': 'Money',
		'isAlave': true
	};
	final superman = Hero.fromJson(rawJson);
	print ( superman ); 
}

class Hero{
	String name;
	String power; 
	bool isAlive;
  // constructor normal 
	Hero({
		required this.name,
		required this.power,
		required this.isAlive,
	});
	
	// constructor con nombre
	Hero.fromJson(Map<String, dynamic> json)
		: name = json['name'] ?? 'No name found',
		  power = json['power'] ?? 'No power found',
		  isAlive = json['isAlive'] ?? ' No know if is alive';

	@override
	String toString(){
		return '$name, Power=$power, is Alive: ${ isAlive ? 'YES!': 'Nope'}';
	}
}