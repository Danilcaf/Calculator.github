using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double currentResult = 0;
        string currentOperation;
        bool isOperationPerformed = false;
        int equalsButtonPressCount = 0;
        double secondOperand;
        double previousOperand;
        string currentInput;
        bool isNewCalculation = true;
        int operationsCount = 0;
        double firstOperand;
        double intermediateResult;

        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
        }

        private double Calculate(string operation, double firstOperand, double secondOperand)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        return firstOperand + secondOperand;
                    case "-":
                        return firstOperand - secondOperand;
                    case "×":
                        return firstOperand * secondOperand;
                    case "÷":
                        if (secondOperand == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw new DivideByZeroException();
                        }
                        return firstOperand / secondOperand;
                    case "√":
                        if (firstOperand < 0)
                        {
                            MessageBox.Show("Нельзя извлечь корень из отрицательного числа!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw new ArgumentException();
                        }
                        return Math.Sqrt(firstOperand);
                    case "sin":
                        return Math.Sin(firstOperand * Math.PI / 180);
                    case "cos":
                        return Math.Cos(firstOperand * Math.PI / 180);
                    case "^":
                        return Math.Pow(firstOperand, secondOperand);
                    case "%":
                        return firstOperand * secondOperand / 100;
                    default:
                        Label_Formula.Text = "Неизвестная операция";
                        return 0;
                }
            }
            catch (Exception ex)
            {
                ResetCalculator();
                TextBox_Output_String.Text = "Ошибка";
                return 0;
            }
        }

        private void Button_Number_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            isNewCalculation = true;

            if (TextBox_Output_String.Text == "0" || isOperationPerformed)
                TextBox_Output_String.Clear();

            isOperationPerformed = false;

            if (clickedButton.Text == ".")
            {
                if (!TextBox_Output_String.Text.Contains("."))
                {
                    if (string.IsNullOrEmpty(TextBox_Output_String.Text))
                        TextBox_Output_String.Text = "0";
                    TextBox_Output_String.Text += clickedButton.Text;
                }
                return;
            }

            TextBox_Output_String.Text = equalsButtonPressCount != 0 ?
                clickedButton.Text :
                TextBox_Output_String.Text + clickedButton.Text;

            equalsButtonPressCount = 0;

            if (!double.TryParse(TextBox_Output_String.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out secondOperand))
            {
                TextBox_Output_String.Text = "0";
                secondOperand = 0;
            }

            currentInput = clickedButton.Text;

            if (operationsCount == 0)
                firstOperand = secondOperand;

            if (operationsCount >= 1)
                intermediateResult = Calculate(currentOperation, firstOperand, secondOperand);
        }

        private void ResetCalculator()
        {
            TextBox_Output_String.Text = "0";
            Label_Formula.Text = string.Empty;
            equalsButtonPressCount = 0;
            isNewCalculation = true;
            currentOperation = null;
            previousOperand = 0;
            operationsCount = 0;
            intermediateResult = 0;
            currentInput = null;
            isOperationPerformed = false;
            firstOperand = 0;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void Button_Operation_Click(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            currentOperation = clickedButton.Text;

            if (!double.TryParse(TextBox_Output_String.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out currentResult))
            {
                currentResult = 0;
            }
            isOperationPerformed = true;

            if (operationsCount >= 1)
            {
                TextBox_Output_String.Text = intermediateResult.ToString();
                firstOperand = intermediateResult;
                currentResult = intermediateResult;
            }

            if (IsUnaryOperation(currentOperation))
            {
                intermediateResult = Calculate(currentOperation, currentResult, 0);
                TextBox_Output_String.Text = intermediateResult.ToString();
                Label_Formula.Text = $"{currentOperation}({currentResult}) = {intermediateResult}";
                isOperationPerformed = false;
                operationsCount = 0;
                return;
            }

            Label_Formula.Text = $"{TextBox_Output_String.Text} {currentOperation} ";
            operationsCount++;
            previousOperand = double.Parse(TextBox_Output_String.Text);
        }

        private bool IsUnaryOperation(string operation)
        {
            return operation == "√" || operation == "sin" || operation == "cos";
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (currentOperation == null) return;

            try
            {
                if (currentOperation == "÷" && double.Parse(TextBox_Output_String.Text) == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (currentOperation == "^")
                {
                    Label_Formula.Text = $"{firstOperand}^{secondOperand} =";
                    intermediateResult = Calculate(currentOperation, firstOperand, secondOperand);
                    TextBox_Output_String.Text = intermediateResult.ToString();
                }
                else if (!IsUnaryOperation(currentOperation))
                {
                    Label_Formula.Text += $"{TextBox_Output_String.Text} =";
                    intermediateResult = Calculate(currentOperation, firstOperand, secondOperand);
                    TextBox_Output_String.Text = intermediateResult.ToString();
                }
                else
                {
                    Label_Formula.Text = currentOperation == "√" ?
                        $"{currentOperation}({currentResult}) = {TextBox_Output_String.Text}" :
                        $"{currentResult} {currentOperation} 0 = {TextBox_Output_String.Text}";
                }

                equalsButtonPressCount++;
                operationsCount = 0;
            }
            catch
            {
                TextBox_Output_String.Text = "Ошибка";
                Label_Formula.Text = string.Empty;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel_Mover_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Panel_Mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
