package com.jdtp.todo.adapter

import android.annotation.SuppressLint
import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.jdtp.todo.R
import com.jdtp.todo.connection.Todo

class TodoAdapter(
    private val context: Context,
    private var listTodo: List<Todo> = emptyList()
    ) : RecyclerView.Adapter<TodoViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int):
            TodoViewHolder {
        val layoutInflater = LayoutInflater.from(context)
        val view = layoutInflater.inflate(R.layout.todo_item, parent, false)
        return TodoViewHolder(view)
    }

    override fun getItemCount(): Int {
        return listTodo.size
    }

    override fun onBindViewHolder(holder: TodoViewHolder, position: Int) {
        val todo = listTodo[position]
        holder.tvTitleTodo.text = todo.title
    }

    @SuppressLint("NotifyDataSetChanged")
    fun updateList(newList: List<Todo>){
        listTodo = newList
        notifyDataSetChanged()
    }
}
class TodoViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
    val tvTitleTodo: TextView = itemView.findViewById(R.id.tv_title_todo)
}