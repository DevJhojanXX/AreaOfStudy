package com.jdtp.todo_list.connection

class TodoRepository(private val TodoDao: TodoDao) {
    fun getAll() = TodoDao.getAllTodos()

    fun insertTodo(todo: Todo)
            = TodoDao.insertTodo(todo)

    fun deleteAllTodo(allTodo: List<Todo>)
            = TodoDao.deleteAllTodos(allTodo)


}