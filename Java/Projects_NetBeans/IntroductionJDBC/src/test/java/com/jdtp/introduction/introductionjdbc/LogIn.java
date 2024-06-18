
package com.jdtp.introduction.introductionjdbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class LogIn {
    public static void main(String[] args) {
        var url = "jdbc:mysql://localhost:3307/test";
        var user = "root";
        var password = "root"; 
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            
            Connection conexion = DriverManager.getConnection(url, user, password);
            
            Statement instruccion = conexion.createStatement();
            
            var sql = "SELECT email, password FROM login";
            
            
            ResultSet resultado = instruccion.executeQuery(sql);
            
            
            while(resultado.next()){
                System.out.println("email: " + resultado.getString("email"));
                System.out.println("password: " + resultado.getString("password"));
            }
            
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace(System.out);
        } catch (SQLException ex) {
            ex.printStackTrace(System.out);
        }
    }
}
