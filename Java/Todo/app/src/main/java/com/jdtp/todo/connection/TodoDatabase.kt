package com.jdtp.todo.connection

import android.content.Context
import androidx.room.Database
import androidx.room.DatabaseConfiguration
import androidx.room.InvalidationTracker
import androidx.room.Room
import androidx.room.Room.databaseBuilder
import androidx.room.RoomDatabase
import androidx.sqlite.db.SupportSQLiteOpenHelper
import com.jdtp.todo.adapter.TodoAdapter
import com.jdtp.todo.adapter.TodoViewHolder

@Database(entities = [Todo::class],version = 1, exportSchema = false)
abstract class TodoDatabase:RoomDatabase() {
    abstract fun todoDao(): TodoDao
}