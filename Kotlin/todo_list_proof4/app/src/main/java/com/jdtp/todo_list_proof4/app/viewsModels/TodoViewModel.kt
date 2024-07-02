package com.jdtp.todo_list_proof4.app.viewsModels

import androidx.compose.runtime.Composable
import androidx.compose.ui.platform.LocalContext
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.jdtp.todo_list_proof4.app.data.DataBaseJson
import com.jdtp.todo_list_proof4.app.data.Todo

class TodoViewModel: ViewModel() {
    val _todos= MutableLiveData<List<Todo>>(emptyList())
    private val _dbJson = DataBaseJson()
    private val _todosx = _dbJson._todos

    fun addTodo(todoName: String) {

        val newTodo = Todo(
            id = _dbJson._todos.count() +1,
            name = todoName,
            isCompleted = false
        )
        _dbJson.addNewTodo(todo = newTodo)
        _todos.value = _todos.value?.plus(newTodo)
    }
    fun toggleTodoCompletion(todoId: Int) {
        _todos.value = _todos.value?.map {
            if (it.id == todoId) it.copy(isCompleted = !it.isCompleted) else it
        } ?: _todos.value
    }
    @Composable
    fun AppClose(){
        val context = LocalContext.current
        _dbJson.SaveTodos(context, _dbJson._todos)
    }
}