package com.jdtp.todo.connection

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.Query

@Dao
interface TodoDao {
    @Query("SELECT * FROM TodoDB")
    fun getAll(): List<Todo>

    @Query("SELECT * FROM TodoDB WHERE tid IN (:todoIds)")
    fun loadAllById(todoIds:IntArray): List<Todo>

    @Query("SELECT * FROM TodoDB WHERE title LIKE :title LIMIT 1")
    fun findByTitle(title: String): Todo

    @Insert
    fun insertAll(vararg tasks: Todo)

    @Delete
    fun deleteTodo(todo:Todo)
}
