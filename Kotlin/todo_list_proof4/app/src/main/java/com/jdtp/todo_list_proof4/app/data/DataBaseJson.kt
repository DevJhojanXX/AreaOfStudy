package com.jdtp.todo_list_proof4.app.data

import android.content.Context
import com.google.gson.Gson
import kotlinx.serialization.json.Json
import java.io.File
import java.io.FileOutputStream
import java.io.InputStream

class DataBaseJson {
    var _todos: MutableList<Todo> = mutableListOf()
    private var _jsonString: String = ""
    private val _fileName: String = "todo_db.json"
    private val gson = Gson()

    fun SaveTodos(context: Context, todos: List<Todo>) {
        val jsonString = gson.toJson(todos)
        val file = File(context.filesDir, _fileName)
        FileOutputStream(file).use { it.write(jsonString.toByteArray()) }
        println("save = $file")
        println("content save = $todos")
    }

    fun showTodos(context: Context): MutableList<Todo> {
        copyFileFromAssets(context, _fileName)
        val fileContent =  File(context.filesDir, _fileName).readText()
         _todos += Json.decodeFromString<MutableList<Todo>>(fileContent)
        _todos.add(Todo(id=6, name ="tareaX", isCompleted = false))
        return _todos
    }

    fun addNewTodo(todo: Todo) {
        _todos.add(todo)
        println("Se agrego todo: $_todos")
    }

    private fun copyFileFromAssets(context: Context, fileName: String) {
        val assetManager = context.assets
        val inputStream: InputStream
        try {
            inputStream = assetManager.open(fileName)
            val outFile = File(context.filesDir, fileName)
            inputStream.copyTo(outFile.outputStream())
        } catch (e: Exception) {
            e.printStackTrace()
        }
    }
}