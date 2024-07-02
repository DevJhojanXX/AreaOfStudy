package com.jdtp.todo_list.connection

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import androidx.room.Update
import kotlinx.coroutines.flow.Flow

@Dao
interface TodoDao {
    @Insert(onConflict = OnConflictStrategy.REPLACE)
    fun insertTodo(todo: Todo): Long

    @Update
    fun updateTodo(todo: Todo)

    @Delete
    fun deleteTodo(todo: Todo)

    @Query("SELECT * FROM todo WHERE id = :id")
    fun getTodoById(id: Int): Todo?

    @Query("SELECT * FROM todo ORDER BY due_date ASC")
    fun getAllTodos(): Flow<List<Todo>>

    @Query("DELETE FROM todo")
    fun deleteAllTodos(allTodo: List<Todo>)
}