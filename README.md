# Scientific Calculator

![Icon](https://github.com/Cal-ly/ScientificCalculator/blob/master/content/iconCalcNBG.ico)

A simple yet powerful scientific calculator built using C# and WPF. This calculator supports both basic arithmetic operations and advanced scientific functions. It is designed with a clean user interface and includes a history log for tracking previous calculations.

## Features

- **Basic Arithmetic Operations**: Addition, subtraction, multiplication, and division.
- **Scientific Functions**: Sine, cosine, tangent, logarithms, square roots, and exponentiation.
- **History Log**: Keeps a record of previous calculations for easy reference.
- **User-Friendly Interface**: Simple and intuitive design for a smooth user experience.
- **Customizable**: The application is modular, with core functionality encapsulated in a separate DLL.

## Screenshots

![Calculator Screenshot1](https://github.com/Cal-ly/ScientificCalculator/blob/master/content/SciCalc%20S1.png)


## Installation

### Prerequisites

- Windows operating system.
- .NET Core installed (if running from source). [.NET 8.0 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Installing the Calculator

1. **Download the Installer**:
   - Go to the [Releases](https://github.com/Cal-ly/ScientificCalculator/releases) page on GitHub.
   - Download the latest `.msi` or `.exe` file.

2. **Run the Installer**:
   - Double-click the downloaded installer file.
   - Follow the installation wizard to install the Scientific Calculator on your machine.

3. **Launch the Application**:
   - After installation, a shortcut will be placed on your desktop.
   - Double-click the shortcut to start using the calculator.

## Usage

1. **Basic Calculations**:
   - Use the number buttons to enter values.
   - Select an arithmetic operator (`+`, `-`, `*`, `/`) to perform basic operations.
   - Press the `=` button to get the result.

2. **Scientific Functions**:
   - Use the `sin`, `cos`, `tan`, `log`, `sqrt`, or `^` buttons to perform scientific calculations.
   - Enter the value and select the desired function.

3. **View Calculation History**:
   - The history log on the interface shows all previous calculations.
   - Scroll through the log to review past results.

## Development

### Clone the Repository

```bash
git clone https://github.com/Cal-ly/ScientificCalculator.git
```

### Build from Source

1. Open the solution in Visual Studio 2022.
2. Build the solution (`Ctrl + Shift + B`).
3. Run the application (`F5`).

### Project Structure

- **ScientificCalculator**: The main WPF project for the calculator's UI.
- **CalculatorLibrary**: A class library project that contains the core logic for the calculator's operations.

## Notes
There is also a Python script included, that contains a calculator with a simple GUI. It uses the methods from the DLL file and includes a unittest. This is purely a showcase.
```python
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
```

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Make your changes and commit them (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- Thanks to all contributors and users who have provided feedback.
- Icon made with [DALL-E](https://openai.com/dall-e) by OpenAI and Paint3D.
