// Clases
/*
en flutter es indispensable
que se manejen las clases en dart,
El 95% en flutter, son puras clases
*/

void main(){
	final wolverine = new Hero('Logan','Regeneración'); // el new no es necesario
	print(wolverine);
  print(wolverine.name);
  print(wolverine.power);
}

// las clases son el molde
class Hero{
	// siempre procura poner el tipo de dato para no crachar
	String name; // estas propiedades deben de ser inicializables
	String power;
	// la mas utilizada
	Hero (this.name, this.power); 
	
//	Hero( String pName, String pPower ){
//		this.name = pName; // el this es opcional
//		power = pPower; 
//	}
	// si sale un error se hace este construcntor
//	Hero( String pName, String pPower )
//		: name = pName,
//		  power = pPower;
}
