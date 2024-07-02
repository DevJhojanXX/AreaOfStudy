package com.jdtp.todo_list_proof4.app.data

import kotlinx.serialization.Serializable

@Serializable
data class Todo(
    val id: Int,
    val name: String,
    val isCompleted: Boolean
)

