import tkinter as tk
import sqlite3 as sq
from tkinter import END

root = tk.Tk()
root.title('Todo List: Proof')
root.geometry('500x500')

conn = sq.connect('todo.db')
cursor = conn.cursor()

cursor.execute(
    '''
    CREATE TABLE IF NOT EXISTS todo(
      id INTEGER PRIMARY KEY AUTOINCREMENT,
      created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
      title TEXT NOT NULL,
      completed BOOLEAN NOT NULL
    );
    '''
)
conn.commit()

def remove(id):
    def _remove():
        cursor.execute("DELETE FROM todo WHERE id = ?", (id, ))
        conn.commit()
        render_todos()
    return _remove

def completed(id): 
    def _completed():
        todo = cursor.execute("SELECT * FROM todo WHERE id = ?", (id, )).fetchone()
        cursor.execute("UPDATE todo SET completed = ? WHERE id = ?", (not todo[3], id))
        conn.commit()
        render_todos()
    return _completed

def render_todos():
    for widget in list_pending_tasks.winfo_children():
        widget.destroy()
        
    rows_todos = cursor.execute('SELECT * FROM todo').fetchall()
    for i, row in enumerate(rows_todos): 
        id = row[0]
        completed_status = row[3]
        title = row[2]
        color = '#555555' if completed_status else '#ffffff'
        check_task = tk.Checkbutton(list_pending_tasks, text=title, width=50, fg=color, anchor='w', command=completed(id))
        check_task.grid(row=i, column=0, sticky='w')
        btn_remove = tk.Button(list_pending_tasks, text='Eliminar', command=remove(id))
        btn_remove.grid(row=i, column=1, sticky='w')
        check_task.select() if completed_status else check_task.deselect()


def add_todo():
    if title.get(): 
        cursor.execute(
            '''
            INSERT INTO todo (title, completed) VALUES (?, ?)
            ''', (title.get(), False)
        )
        conn.commit() 
        title.delete(0, END)
        render_todos()

title = tk.Entry(root, text='Todo: ')
title.grid(row=0, column=0)
title.focus()

btn_add_todo = tk.Button(root, text='Add', command=add_todo)
btn_add_todo.grid(row=0, column=1)

# Frame para listar las tareas
list_pending_tasks = tk.LabelFrame(root, text='List Tasks', padx=5, pady=5)
list_pending_tasks.grid(row=1, column=0, columnspan=2, sticky='nswe', padx=4)

root.bind('<Return>', lambda event: add_todo())

render_todos()

root.mainloop()
