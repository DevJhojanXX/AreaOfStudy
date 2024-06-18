
package com.jdtp.introduction.manejojdbc;

import com.jdtp.introduction.manejojdbc.conexion.PersonaDAO;
import com.jdtp.introduction.manejojdbc.domain.Persona;
import java.util.List;


public class ManejoJDBC {
    public static void main(String[] args) {
        PersonaDAO personaDao = new PersonaDAO();
        
//        Persona personaNew = new Persona("Juanita"," Carmona"," jcarmona@email.com","3234242");
        
//        Persona personaMody = new Persona(3,"Juanita Andra","Carmona Agudelo","jandreaagudelo@email.com","3524562123");
          Persona personaEliminar = new Persona(3);
          personaDao.eliminar(personaEliminar);
//        personaDao.insertar(personaNew);
//        personaDao.actualizar(personaMody);
        
        List<Persona>personas = personaDao.seleccionar();
        
        personas.forEach(persona ->{
            System.out.println("persona = " + persona);
        });
        
    }
    
}
