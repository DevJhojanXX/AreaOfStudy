package com.jdtp.todo_list

import androidx.lifecycle.ViewModel
import androidx.lifecycle.ViewModelProvider
import androidx.lifecycle.ViewModelProvider.AndroidViewModelFactory.Companion.APPLICATION_KEY
import androidx.lifecycle.viewModelScope
import androidx.lifecycle.viewmodel.initializer
import androidx.lifecycle.viewmodel.viewModelFactory
import com.jdtp.todo_list.connection.Todo
import com.jdtp.todo_list.connection.TodoRepository
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.launch

class HomeViewModel(private val todoRepository: TodoRepository) : ViewModel() {
    fun getAll(): Flow<List<Todo>>
            = todoRepository.getAll()
    fun insertTodo(todo: Todo) = viewModelScope.launch {
        todoRepository.insertTodo(todo = todo)
    }

    fun deleteAllTodos(allTodo: List<Todo>) = viewModelScope.launch {
        todoRepository.deleteAllTodo(allTodo)
    }

    companion object {
        val Factory: ViewModelProvider.Factory = viewModelFactory {
            initializer {
                val application = (this[APPLICATION_KEY] as MainActivity)
                HomeViewModel(application.container.myFriendsRepository)
            }
        }
    }
}