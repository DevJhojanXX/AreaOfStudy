package com.jdtp.introduction.manejojdbc.conexion;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class conexion {

    private static final String JDBC_URL = "jdbc:mysql://localhost:3307/test";
    private static final String JDBC_USER = "root";
    private static final String JDBC_PASSWORD = "root";

    public static Connection getConnection() throws SQLException {
        return DriverManager.getConnection(JDBC_URL, JDBC_USER, JDBC_PASSWORD);
    }
    
    /**
     *
     * @param rs
     * @throws SQLException
     */
    public static void close(ResultSet rs) throws SQLException {

        rs.close();

    }
    
    public static void close(Statement smtm) throws SQLException{
        smtm.close();
    }
    
    public static void close(PreparedStatement pmt) throws SQLException {

        pmt.close();

    }
    public static void close(Connection con) throws SQLException {

        con.close();

    }
}
