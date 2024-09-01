import clr  # Import the Common Language Runtime (CLR) module
import os   # Import os module to handle paths
import tkinter as tk
from tkinter import messagebox

# Get the relative path to the DLL
dll_path = os.path.join(os.path.dirname(__file__), "CalculatorLibrary.dll")
clr.AddReference(dll_path)  # Add the path to the .NET assembly containing the Calculator class

# Import the Calculator class from the CalculatorLibrary namespace
from CalculatorLibrary import Calculator

# Create an instance of the Calculator class
calc = Calculator()

# Function to perform the calculation
def calculate(operation):
    try:
        num1 = float(entry1.get())
        num2 = float(entry2.get())

        if operation == "Add":
            result = calc.Add(num1, num2)
        elif operation == "Subtract":
            result = calc.Subtract(num1, num2)
        elif operation == "Multiply":
            result = calc.Multiply(num1, num2)
        elif operation == "Divide":
            result = calc.Divide(num1, num2)

        result_var.set(f"Result: {result}")
    except ValueError:
        messagebox.showerror("Input Error", "Please enter valid numbers")
    except Exception as e:
        messagebox.showerror("Error", str(e))

# Set up the GUI
root = tk.Tk()
root.title("Calculator GUI")

# Define font size and padding
font_size = 20
padding = 10

# Entry for the first number
tk.Label(root, text="Number 1", font=("Arial", font_size)).grid(row=0, column=0, padx=padding, pady=padding)
entry1 = tk.Entry(root, font=("Arial", font_size))
entry1.grid(row=0, column=1, padx=padding, pady=padding)

# Entry for the second number
tk.Label(root, text="Number 2", font=("Arial", font_size)).grid(row=1, column=0, padx=padding, pady=padding)
entry2 = tk.Entry(root, font=("Arial", font_size))
entry2.grid(row=1, column=1, padx=padding, pady=padding)

# Result display
result_var = tk.StringVar()
result_var.set("Result: ")
tk.Label(root, textvariable=result_var, font=("Arial", font_size)).grid(row=2, columnspan=2, padx=padding, pady=padding)

# Buttons for operations
button_width = 10
button_height = 2
tk.Button(root, text="Add", command=lambda: calculate("Add"), font=("Arial", font_size), width=button_width, height=button_height).grid(row=3, column=0, padx=padding, pady=padding)
tk.Button(root, text="Subtract", command=lambda: calculate("Subtract"), font=("Arial", font_size), width=button_width, height=button_height).grid(row=3, column=1, padx=padding, pady=padding)
tk.Button(root, text="Multiply", command=lambda: calculate("Multiply"), font=("Arial", font_size), width=button_width, height=button_height).grid(row=4, column=0, padx=padding, pady=padding)
tk.Button(root, text="Divide", command=lambda: calculate("Divide"), font=("Arial", font_size), width=button_width, height=button_height).grid(row=4, column=1, padx=padding, pady=padding)

# Start the GUI loop
root.mainloop()