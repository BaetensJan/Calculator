﻿using System;
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
        Calculate cal = new Calculate();
        bool buttonboxIsEnabled = false;

        public MainWindow()
        {
            InitializeComponent();
            displayTextbox.IsEnabled = false;
        }

        private void ToggleButtonFunctionality()
        {
            buttonboxIsEnabled = !buttonboxIsEnabled;
            
            onButton.IsEnabled = !buttonboxIsEnabled;
            offButton.IsEnabled = buttonboxIsEnabled;
            clearButton.IsEnabled = buttonboxIsEnabled;
            multButton.IsEnabled = buttonboxIsEnabled;
            oneButton.IsEnabled = buttonboxIsEnabled;
            twoButton.IsEnabled = buttonboxIsEnabled;
            threeButton.IsEnabled = buttonboxIsEnabled;
            fourButton.IsEnabled = buttonboxIsEnabled;
            fiveButton.IsEnabled = buttonboxIsEnabled;
            sixButton.IsEnabled = buttonboxIsEnabled;
            sevenButton.IsEnabled = buttonboxIsEnabled;
            eightButton.IsEnabled = buttonboxIsEnabled;
            nineButton.IsEnabled = buttonboxIsEnabled;
            zeroButton.IsEnabled = buttonboxIsEnabled;
            divButton.IsEnabled = buttonboxIsEnabled;
            addButton.IsEnabled = buttonboxIsEnabled;
            subButton.IsEnabled = buttonboxIsEnabled;
            calcButton.IsEnabled = buttonboxIsEnabled;
            decPointButton.IsEnabled = buttonboxIsEnabled;
        }


        private void NumOpButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            displayTextbox.Text += button.Content.ToString();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                displayTextbox.Text = "Error! Try again.";
            }
        }

        private void FuncButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == onButton)
            {
                displayTextbox.Text = "";
                ToggleButtonFunctionality();
                displayTextbox.IsEnabled = true;
            }
            else if (sender == offButton)
            {
                displayTextbox.Text = "Off";
                ToggleButtonFunctionality();
                displayTextbox.IsEnabled = false;
            }
            else if (sender == clearButton)
            {
                displayTextbox.Text = "";
            }
        }

        private void Calculate()
        {
            int opPos = 0;
            double value1 = 0;
            double value2 = 0;
            double result = 0;
            string op = "";

            if (displayTextbox.Text.Contains("*"))
            {
                opPos = displayTextbox.Text.IndexOf("*");
            }
            else if (displayTextbox.Text.Contains("/"))
            {
                opPos = displayTextbox.Text.IndexOf("/");
            }
            else if (displayTextbox.Text.Contains("+"))
            {
                opPos = displayTextbox.Text.IndexOf("+");
            }
            else if (displayTextbox.Text.Contains("-"))
            {
                opPos = displayTextbox.Text.IndexOf("-");
            }

            value1 = Double.Parse(displayTextbox.Text.Substring(0, opPos));
            op = displayTextbox.Text.Substring(opPos, 1);
            value2 = Double.Parse(displayTextbox.Text.Substring(opPos + 1, displayTextbox.Text.Length - opPos - 1));

            if (op == "*")
            {
                result = cal.multiply(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
            else if (op == "/")
            {
                if (value2 == 0)
                {
                    displayTextbox.Text = "Cannot divide by zero!";
                }
                else
                {
                    result = cal.divide(value1, value2);
                    displayTextbox.Text += "= " + result.ToString();
                }
            }
            else if (op == "+")
            {
                result = cal.add(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
            else if (op == "-")
            {
                result = cal.subtract(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            SettingsWindow popup = new SettingsWindow();
            popup.ShowDialog();
        }
    }
}
