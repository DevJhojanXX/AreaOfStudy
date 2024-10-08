package com.jdtp.todo_list.connection

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity(tableName = "todo")
data class Todo(
    @PrimaryKey(autoGenerate = true)
    val id: Int?,
    @ColumnInfo(name = "title")
    val title: String?,
    @ColumnInfo(name = "description")
    val description: String?,
    @ColumnInfo(name = "is_completed")
    val isCompleted: Boolean?,
    @ColumnInfo(name = "due_date")
    val dueDate: String?
)



