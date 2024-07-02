package com.jdtp.todo_list_proof4.app
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.Scaffold
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.livedata.observeAsState
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.lifecycle.viewmodel.compose.viewModel
import com.jdtp.todo_list_proof4.app.composables.Shared
import com.jdtp.todo_list_proof4.app.composables.TodoList
import com.jdtp.todo_list_proof4.app.data.DataBaseJson
import com.jdtp.todo_list_proof4.app.viewsModels.TodoViewModel
import com.jdtp.todo_list_proof4.ui.theme.Todo_list_proof4Theme

class AppCompose  {
    private var _shared = Shared()
    private var _dbJson = DataBaseJson()

    @Composable
    fun ShowApp() {
        val context = LocalContext.current
        val todoViewModel: TodoViewModel = viewModel()
        val todo by todoViewModel._todos.observeAsState(emptyList())
        var todoName by remember { mutableStateOf("") }

        Todo_list_proof4Theme {
            Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                Column(
                    modifier = Modifier
                        .fillMaxSize()
                        .padding(innerPadding)
                ) {
                    _shared.TextLabel(text = "Hello", modifier = Modifier.padding(8.dp))
                    TextField(
                        value = todoName,
                        onValueChange = { todoName = it },
                        modifier = Modifier
                            .background(Color.Red)
                            .fillMaxWidth()
                            .padding(bottom = 16.dp)
                    )
                    Spacer(modifier = Modifier.height(16.dp))
                    Button(
                        onClick = {
                            if (todoName.isNotBlank()) {
                                todoViewModel.addTodo(todoName)
                                todoName = ""
                            }
                        },
                        modifier = Modifier.fillMaxWidth()
                    ) {
                        _shared.TextLabel(text = "Add Task", modifier = Modifier.padding(8.dp))
                    }

                    Spacer(modifier = Modifier.height(16.dp))
                    TodoList(todo, todoViewModel::toggleTodoCompletion)

                }
            }
        }
    }
    @Preview(
        showSystemUi = true,
        showBackground = true
    )
    @Composable
    fun AppPreview() {
        ShowApp()
    }
}

