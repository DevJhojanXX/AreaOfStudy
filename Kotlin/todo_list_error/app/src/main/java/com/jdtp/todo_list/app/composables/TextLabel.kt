package com.jdtp.todo_list.app.composables

import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import com.jdtp.todo_list.ui.theme.Todo_listTheme

@Composable
fun TextLabel(name: String, modifier: Modifier = Modifier) {
    Text(
        text = "Hello $name!",
        modifier = modifier
    )
}

@Preview(showBackground = true)
@Composable
fun TextLabelPreview() {
    TextLabel("Android", Modifier.padding(8.dp))
}