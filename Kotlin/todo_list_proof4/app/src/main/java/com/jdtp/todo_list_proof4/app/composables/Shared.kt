package com.jdtp.todo_list_proof4.app.composables

import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier

class Shared {
    @Composable
    fun TextLabel(text: String, modifier: Modifier) {
        Text(
            text = text,
            modifier = modifier
        )
    }
}