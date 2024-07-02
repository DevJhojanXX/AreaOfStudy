package com.jdtp.todo_list.connection

import android.content.Context

class TodoContainer (private val context: Context) {
    val myFriendsRepository: TodoRepository by lazy {
        TodoRepository(TodoDatabase.getTodoDatabase(context).TodoDao())
    }
}