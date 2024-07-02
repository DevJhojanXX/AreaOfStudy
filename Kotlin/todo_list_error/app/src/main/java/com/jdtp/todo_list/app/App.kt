package com.jdtp.todo_list.app

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Button
import androidx.compose.material3.Card
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.lifecycle.viewmodel.compose.viewModel
import com.jdtp.todo_list.HomeViewModel
import com.jdtp.todo_list.app.composables.TextLabel
import com.jdtp.todo_list.connection.Todo
import com.jdtp.todo_list.ui.theme.Todo_listTheme

@Composable
fun App(
    modifier: Modifier = Modifier,
    viewModel: HomeViewModel = viewModel(factory = HomeViewModel.Factory)
){
    val todoList by viewModel.getAll().collectAsState(initial = emptyList()) // ..2
    var todoInput by remember { mutableStateOf("") }

    Todo_listTheme {
        Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
            Column(
                modifier = modifier.fillMaxSize().padding(innerPadding),
                verticalArrangement = Arrangement.Center,
                horizontalAlignment = Alignment.CenterHorizontally
            ) {
                // Display the list of friends
                LazyColumn(
                    modifier = Modifier.weight(.7F),
                    verticalArrangement = Arrangement.Center
                ) {

                    items(todoList) { todo ->
                        Card(
                            modifier = Modifier
                                .width(200.dp)
                                .height(80.dp)
                                .padding(vertical = 8.dp)
                        ) {
                            Box(
                                modifier = Modifier.fillMaxSize(),
                                contentAlignment = Alignment.Center
                            ) {
                                Text(text = todo.title.toString(), style = MaterialTheme.typography.displaySmall)
                                TextLabel(
                                    name = "Android",
                                    modifier = Modifier.padding(8.dp)
                                )
                            }
                        }
                    }
                }

                // Input field and buttons
                Column(
                    verticalArrangement = Arrangement.spacedBy(16.dp),
                    horizontalAlignment = Alignment.CenterHorizontally,
                    modifier = Modifier.weight(.3F)
                ) {
                    OutlinedTextField(value = todoInput, onValueChange = { todoInput = it })

                    Button(onClick = { viewModel.insertTodo(Todo(id=0, title = todoInput, description = "Hola", false, "293929")) }) {
                        Text(text = "SAVE")
                    }
                    Button(onClick = { viewModel.deleteAllTodos(todoList) }) {
                        Text(text = "ALL DELETE")
                    }
                }
            }
       }
   }
}

@Preview(showSystemUi = true)
@Composable
fun AppPreview() {
    App()
}