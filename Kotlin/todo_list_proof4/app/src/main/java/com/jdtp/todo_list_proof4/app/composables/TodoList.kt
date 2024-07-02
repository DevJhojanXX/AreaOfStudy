package com.jdtp.todo_list_proof4.app.composables

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.runtime.Composable
import androidx.compose.ui.platform.LocalContext
import com.jdtp.todo_list_proof4.app.data.DataBaseJson
import com.jdtp.todo_list_proof4.app.data.Todo

private val _dbJson = DataBaseJson()

@Composable
fun TodoList(todos: List<Todo>, onTaskClick: (Int) -> Unit) {
    val context = LocalContext.current
    val todosJson =   _dbJson.showTodos(context)
    _dbJson._todos.addAll(todos)
    Column {
            LazyColumn {
                items(todosJson){todo ->
                    TodoItem(todo = todo, onTaskClick)
                }
            }
        }
}
