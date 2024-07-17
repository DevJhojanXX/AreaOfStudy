import tkinter as tk
from typing import Union, List, Tuple

def press(num):
    expression = equation.get()
    equation.set(expression + str(num))

def equal_press():
    try:
        result = eval(equation.get())
        equation.set(result)
    except (ValueError, SyntaxError):
        equation.set("Error")

def clear():
    equation.set("")

def create_button_action(text):
    if text.isdigit() or text in "+-*/":
        return lambda: press(text)
    elif text == '=':
        return equal_press
    else:
        return clear

root = tk.Tk()
root.title("Calculadora")
root.configure(background='#333333')
equation = tk.StringVar()

# Crear el campo de entrada de la expresión
expression_entry = tk.Entry(root, textvariable=equation, font=('Arial', 18))
expression_entry.grid(row=0, columnspan=4, sticky='nswe')

# Configurar botones
buttons : List[Tuple[str, int, int, Union[int], Union[int]]] = [
    ('1', 4, 0, 1, 1), ('2', 4, 1, 1, 1), ('3', 4, 2, 1, 1),
    ('4', 3, 0, 1, 1), ('5', 3, 1, 1, 1), ('6', 3, 2, 1, 1),
    ('7', 2, 0, 1, 1), ('8', 2, 1, 1, 1), ('9', 2, 2, 1, 1),
    ('0', 5, 0, 1, 2), ('=', 5, 2, 1, 2), ('+', 4, 3,1, 1),
    ('-', 3, 3, 1, 1), ('*', 2, 3, 1, 1), ('/', 1, 3, 1, 1),
    ('CE', 1, 2, 1, 1)
]

for button in buttons:
    text = button[0]
    row = button[1]
    column = button[2]
    rowspan = button[3] if len(button) > 3 else 1
    columnspan = button[4] if len(button) > 4 else 1
    action = create_button_action(text)
    btn = tk.Button(root, text=str(text), fg='#fff', bg='#666', command=action)
    btn.grid(row=row, column=column, rowspan=rowspan, columnspan=columnspan, sticky='nswe')

# Configurar que las filas y columnas se expandan
for i in range(6):
    root.grid_rowconfigure(i, weight=1)

for i in range(4):
    root.grid_columnconfigure(i, weight=1)

root.mainloop()
