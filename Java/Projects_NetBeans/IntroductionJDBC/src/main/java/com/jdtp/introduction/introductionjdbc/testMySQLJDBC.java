
package com.jdtp.introduction.introductionjdbc;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;


public class testMySQLJDBC {
    public static void main(String[] args) {
        //Cada base de datos tiene su propia cadena de conexion
        var url = "jdbc:mysql://localhost:3307/test";
        var user = "root";
        var password = "root"; 
        try {
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            Connection conexion = DriverManager.getConnection(url,user,password);
            
            Statement instruccion = conexion.createStatement();
            
            var sql = "SELECT id_persona, nombre, apellido, email, telefono FROM persona";
            
            ResultSet resultado = instruccion.executeQuery(sql);
            
            while(resultado.next()){
                System.out.println("id_Persona: "+resultado.getInt("id_persona"));
                System.out.println("nombre: "+resultado.getString("nombre"));
                System.out.println("apellido: "+resultado.getString("apellido"));
                System.out.println("Correo: "+resultado.getString("email"));
                System.out.println("telefono: "+resultado.getString("telefono"));                
            }
            
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace(System.out);
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        }
        
        
        
    }
}
