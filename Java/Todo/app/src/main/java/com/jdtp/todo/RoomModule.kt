package com.jdtp.todo

import android.content.Context
import androidx.room.Room
import com.jdtp.todo.connection.TodoDatabase
import dagger.Module
import dagger.Provides
import dagger.hilt.InstallIn
import dagger.hilt.android.qualifiers.ApplicationContext
import dagger.hilt.components.SingletonComponent
import javax.inject.Singleton

@Module
@InstallIn(SingletonComponent::class)
class RoomModule {
    private  val TODO_DATABASE_NAME = "todo_database"

    @Singleton
    @Provides
    fun provideRoom(@ApplicationContext context: Context) =
        Room.databaseBuilder(context, TodoDatabase::class.java, TODO_DATABASE_NAME).build()

    @Singleton
    @Provides
    fun provideTodoDao(db: TodoDatabase) = db.todoDao()

}