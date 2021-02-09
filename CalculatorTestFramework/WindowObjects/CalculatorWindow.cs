using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP.LFT.SDK.WPF;

namespace UFTDeveloperTestProject1.PageObjects
{
    public class CalculatorWindow
    {
        protected IWindow window;

        protected IButton onButton;
        protected IButton oneButton;
        protected IButton twoButton;
        protected IButton threeButton;
        protected IButton sixButton;
        protected IButton nineButton;
        protected IButton addButton;
        protected IButton minusButton;
        protected IButton multiplyButton;
        protected IButton calcButton;
        protected IButton clearButton;
        protected IButton offButton;
        protected IEditField outputField;

        public CalculatorWindow(IWindow window)
        {
            this.window = window;

            onButton = window.Describe<IButton>(new ButtonDescription
             {
                 ObjectName = @"onButton",
                 Text = @"On"
             });

            oneButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"oneButton",
                Text = @"1"
            });

            twoButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"twoButton",
                Text = @"2"
            });

            threeButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"threeButton",
                Text = @"3"
            });

            sixButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"sixButton",
                Text = @"6"
            });

            nineButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"nineButton",
                Text = @"9"
            });

            addButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"addButton",
                Text = @"+"
            });

            minusButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"subButton",
                Text = @"-"
            });

            multiplyButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"multButton",
                Text = @"*"
            });

            calcButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"calcButton",
                Text = @"="
            });

            clearButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"clearButton",
                Text = @"C"
            });

            offButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"offButton",
                Text = @"Off"
            });

            outputField = window.Describe<IEditField>(new EditFieldDescription
            {
                ObjectName = @"displayTextbox"
            });
        }

        public CalculatorWindow Click(string buttonName)
        {
            switch (buttonName)
            {
                case "One":
                    oneButton.Click();
                    break;
                case "Two":
                    twoButton.Click();
                    break;
                case "Three":
                    threeButton.Click();
                    break;
                case "Six":
                    sixButton.Click();
                    break;
                case "Nine":
                    nineButton.Click();
                    break;
                case "Add":
                    addButton.Click();
                    break;
                case "Minus":
                    minusButton.Click();
                    break;
                case "Multiply":
                    multiplyButton.Click();
                    break;
                case "Calc":
                    calcButton.Click();
                    break;
                case "Clear":
                    clearButton.Click();
                    break;
                case "Off":
                    offButton.Click();
                    break;
                default:
                    onButton.Click();
                    break;
            }
            return this;
        }

        public string GetOutput()
        {
            return outputField.Text;
        }
    }
}
