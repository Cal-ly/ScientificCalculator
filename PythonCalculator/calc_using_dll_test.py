import unittest
import clr  # Import the Common Language Runtime (CLR) module
import os   # Import os module to handle paths

# Get the relative path to the DLL
dll_path = os.path.join(os.path.dirname(__file__), "CalculatorLibrary.dll")
clr.AddReference(dll_path)  # Add the path to the .NET assembly containing the Calculator class

# Import the Calculator class from the CalculatorLibrary namespace
from CalculatorLibrary import Calculator

class TestCalculator(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        """Create a single instance of Calculator to be used in all tests."""
        cls.calc = Calculator()

    def test_add(self):
        self.assertEqual(self.calc.Add(10, 5), 15)
        self.assertEqual(self.calc.Add(-1, 1), 0)
        self.assertEqual(self.calc.Add(-1, -1), -2)

    def test_subtract(self):
        self.assertEqual(self.calc.Subtract(10, 5), 5)
        self.assertEqual(self.calc.Subtract(-1, 1), -2)
        self.assertEqual(self.calc.Subtract(-1, -1), 0)

    def test_multiply(self):
        self.assertEqual(self.calc.Multiply(10, 5), 50)
        self.assertEqual(self.calc.Multiply(-1, 1), -1)
        self.assertEqual(self.calc.Multiply(-1, -1), 1)

    def test_divide(self):
        self.assertEqual(self.calc.Divide(10, 5), 2)
        self.assertEqual(self.calc.Divide(-1, 1), -1)
        self.assertEqual(self.calc.Divide(-1, -1), 1)
        with self.assertRaises(Exception):  # Expecting an exception for divide by zero
            self.calc.Divide(10, 0)

if __name__ == '__main__':
    unittest.main()

# Run the calc_using_dll_test.py file to execute the test cases. 
# The output will show the results of the tests, including any failures or errors that occurred during the test execution.
# To run 
# ```bash
# py calc_using_dll_test.py
# ```