import tkinter as tk
import sqlite3

root = tk.Tk()
root.title("Todo List")
root.geometry('500x500')

conn = sqlite3.connect('todo.db')

c = conn.cursor()
try:
    c.execute(
        '''
            CREATE TABLE if not exists todo(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                decription TEXT NOT NULL,
                completed BOOLEAN NOT NULL
            );
        '''
    )
    conn.commit()
except sqlite3.OperationalError as e: 
    print(f"error: {e}")

def add_todo():
    pass

root.grid_rowconfigure(0, weight=1)
root.grid_rowconfigure(1, weight=1)
root.grid_columnconfigure(0, weight=1)
root.grid_columnconfigure(1, weight=1)


description = tk.Entry(root, width=40)
description.grid(row=0, column=0)

btn_add = tk.Button(root, text='Add',command= add_todo)
btn_add.grid(row = 0, column= 1)

frame_list = tk.LabelFrame(root, text='Todos', padx=5, pady=5)
frame_list.grid(row = 1, column=0, columnspan = 3, sticky = 'nswe', padx = 5)

conn.close()

root.mainloop()

