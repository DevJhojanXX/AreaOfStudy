package com.jdtp.todo_list

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.runtime.Composable
import androidx.compose.ui.tooling.preview.Preview
import com.jdtp.todo_list.app.App
import com.jdtp.todo_list.connection.TodoContainer
class MainActivity : ComponentActivity() {
    lateinit var container: TodoContainer
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        container = TodoContainer(this)
        setContent {
            App()
        }
    }
}


@Preview(showSystemUi = true)
@Composable
fun AllPreview() {
    App()
}