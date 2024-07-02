package com.jdtp.todo_list_proof4.app.composables

import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Checkbox
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import com.jdtp.todo_list_proof4.app.data.Todo
private val _shared = Shared()
@Composable
fun TodoItem(todo: Todo, onTaskClick: (Int) -> Unit) {

    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(8.dp)
    ) {
        Checkbox(
            checked = todo.isCompleted,
            onCheckedChange = { onTaskClick(todo.id) },
            Modifier.padding(2.dp)
        )
        _shared.TextLabel(text = todo.name, modifier = Modifier.padding(top=15.dp))
    }
}