using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare left and right operands
        Operand left;
        Operand right;

        // Declare operator
        String opr;

        public MainWindow()
        {
            InitializeComponent();

            // Set calculator to off state
            turnOff();
        }

        private void on_Button_Click(object sender, RoutedEventArgs e)
        {
            // Clear value from display
            clearDisplay();
            
            // Initialize operands to null
            clearOperands();

            // Set calculator to on state
            turnOn();
        }

        private void off_Button_Click(object sender, RoutedEventArgs e)
        {
            // Clear value from display
            clearDisplay();
            
            // Initialize operands to null
            clearOperands();

            // Set calculator to off state
            turnOff();
        }

        private void clear_Button_Click(object sender, RoutedEventArgs e)
        {
            // Clear value from display
            clearDisplay();
            
            // Initialize operands to null
            clearOperands();
            
            // Set calculator to on state
            turnOn();
        }

        private void zero_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 0;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void one_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 1;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void two_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 2;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void three_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 3;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void four_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 4;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void five_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 5;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void six_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 6;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void seven_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 7;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void eight_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 8;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void nine_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable value
            const decimal value = 9;

            // Pass number to applicable operand
            assignOperand(value);
        }

        private void equals_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare answer variable
            decimal answer;

            try
            {
                // Calculate the answer
                switch (opr)
                {
                    case "+":
                        // Perform addition
                        answer = Calculate.Add(left, right);
                        // Display answer
                        displayValue(answer.ToString());
                        break;
                    case "-":
                        // Perform subtraction
                        answer = Calculate.Subtract(left, right);
                        // Display answer
                        displayValue(answer.ToString());
                        break;
                    case "*":
                        // Perform multiplication
                        answer = Calculate.Multiply(left, right);
                        // Display answer
                        displayValue(answer.ToString());
                        break;
                    case "/":
                        // Perform division
                        answer = Calculate.Divide(left, right);
                        // Display answer
                        displayValue(answer.ToString());
                        break;
                    default:
                        // Display error message
                        displayValue("ERROR");
                        break;
                }
            }
            catch (DivideByZeroException divZeroEx)
            {
                displayValue("Cannot divide by zero");
            }
            finally
            {
                // Disable operator buttons
                disableOperators();

                // Disable equals button
                equalsBtn.IsEnabled = false;
            }
        }

        private void add_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable operator type
            const string type = "+";

            // Display operator
            displayValue(type);

            // Assign operator
            opr = type;

            // Enable number buttons
            enableNumbers();

            // Disable operators
            disableOperators();
        }

        private void subtract_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable operator type
            const string type = "-";

            // Display operator
            displayValue(type);

            // Assign operator
            opr = type;

            // Enable number buttons
            enableNumbers();

            // Disable operators
            disableOperators();
        }

        private void multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable operator type
            const string type = "*";

            // Display operator
            displayValue(type);

            // Assign operator
            opr = type;

            // Enable number buttons
            enableNumbers();

            // Disable operators
            disableOperators();
        }

        private void divide_Button_Click(object sender, RoutedEventArgs e)
        {
            // Declare and initialize applicable operator type
            const string type = "/";

            // Display operator
            displayValue(type);

            // Assign operator
            opr = type;

            // Enable number buttons
            enableNumbers();

            // Disable operators
            disableOperators();
        }

        // Set left and right operands to null
        private void clearOperands()
        {
            left = null;
            right = null;
        }
        
        // Display applicable value in window
        private void displayValue(String str)
        {
            displayWindow.Text = str;
        }

        // Clear the value displayed in the window
        private void clearDisplay()
        {
            displayWindow.Text = "";
        }

        // Turns on the calculator
        private void turnOn()
        {
            onBtn.IsEnabled = false;
            offBtn.IsEnabled = true;
            clearBtn.IsEnabled = true;

            // Enable number buttons
            enableNumbers();

            // Disable operator buttons
            disableOperators();

            // Disable equals button
            equalsBtn.IsEnabled = false;
        }

        // Turns off the calculator
        private void turnOff()
        {
            onBtn.IsEnabled = true;
            offBtn.IsEnabled = false;
            clearBtn.IsEnabled = false;

            // Disable number buttons
            disableNumbers();
 
            // Disable operator buttons
            disableOperators();

            // Disable equals button
            equalsBtn.IsEnabled = false;
        }

        // Provides for operator selection
        private void selectOperator()
        {
            // Disable number buttons
            disableNumbers();
            
            // Enable operator buttons
            enableOperators();
        }

        // Provides for equals sign selection
        private void selectEquals()
        {
            // Disable number buttons
            disableNumbers();

            // Disable operator buttons
            disableOperators();

            // Enable equals button
            equalsBtn.IsEnabled = true;
        }

        // Assigns value to left or right operand
        private void assignOperand(decimal value)
        {
            // If left operand is null...
            if (left == null)
            {
                // Assign value to left operand
                left = new Operand(value);

                // Display value
                displayValue(value.ToString());

                // Enable operators, disable numbers
                selectOperator();
            }
            // Else right operator is null...
            else
            {
                // Assign value to right operand
                right = new Operand(value);

                // Display value
                displayValue(value.ToString());

                // Enable equals, disable numbers and operators
                selectEquals();
            }
        }

        // Disable number buttons
        private void disableNumbers()
        {
            zeroBtn.IsEnabled = false;
            oneBtn.IsEnabled = false;
            twoBtn.IsEnabled = false;
            threeBtn.IsEnabled = false;
            fourBtn.IsEnabled = false;
            fiveBtn.IsEnabled = false;
            sixBtn.IsEnabled = false;
            sevenBtn.IsEnabled = false;
            eightBtn.IsEnabled = false;
            nineBtn.IsEnabled = false;
        }

        // Enable number buttons
        private void enableNumbers()
        {
            zeroBtn.IsEnabled = true;
            oneBtn.IsEnabled = true;
            twoBtn.IsEnabled = true;
            threeBtn.IsEnabled = true;
            fourBtn.IsEnabled = true;
            fiveBtn.IsEnabled = true;
            sixBtn.IsEnabled = true;
            sevenBtn.IsEnabled = true;
            eightBtn.IsEnabled = true;
            nineBtn.IsEnabled = true;
        }

        // Disable operator buttons
        private void disableOperators()
        {
            plusBtn.IsEnabled = false;
            minusBtn.IsEnabled = false;
            multiplyBtn.IsEnabled = false;
            divideBtn.IsEnabled = false;
        }

        // Enable operator buttons
        private void enableOperators()
        {
            plusBtn.IsEnabled = true;
            minusBtn.IsEnabled = true;
            multiplyBtn.IsEnabled = true;
            divideBtn.IsEnabled = true;
        }
    }
}
