package com.jdtp.todo_list_proof4

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.runtime.Composable
import androidx.compose.ui.tooling.preview.Preview
import com.jdtp.todo_list_proof4.app.AppCompose
import com.jdtp.todo_list_proof4.app.viewsModels.TodoViewModel

class MainActivity : ComponentActivity() {
    private var _application = AppCompose()
    private var _todoView = TodoViewModel()
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        setContent {
            _application.ShowApp()
        }

    }

    override fun onStop() {
        super.onStop()
        setContent{
            _todoView.AppClose()
        }
    }
}



@Preview(
    showSystemUi = true,
    showBackground = true
)
@Composable
fun AllPreview() {
    val _application = AppCompose()
    _application.ShowApp()
}