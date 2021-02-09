using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP.LFT.SDK.WPF;

namespace UFTDeveloperTestProject1.PageObjects
{
    public class CalculatorPage
    {
        protected IWindow window;
        protected IButton onButton;
        protected IButton oneButton;
        protected IButton addButton;
        protected IButton sixButton;
        protected IButton calcButton;
        protected IButton clearButton;
        protected IButton offButton;
        protected IEditField outputField;

        public CalculatorPage(IWindow window)
        {
            this.window = window;

             onButton = this.window.Describe<IButton>(new ButtonDescription
             {
                 ObjectName = @"onButton",
                 Text = @"On"
             });

            oneButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"oneButton",
                Text = @"1"
            });

            addButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"addButton",
                Text = @"+"
            });

            sixButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"sixButton",
                Text = @"6"
            });

            calcButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"calcButton",
                Text = @"="
            });

            clearButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"clearButton",
                Text = @"C"
            });

            offButton = this.window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"offButton",
                Text = @"Off"
            });

            outputField = this.window.Describe<IEditField>(new EditFieldDescription
            {
                ObjectName = @"displayTextbox"
            });
        }

        public CalculatorPage Click(string buttonName)
        {

            /*
            protected IButton onButton;
            protected IButton oneButton;
            protected IButton addButton;
            protected IButton sixButton;
            protected IButton calcButton;
            protected IButton clearButton;
            protected IButton offButton;
            */
            switch (buttonName)
            {
                case "One":
                    this.oneButton.Click();
                    break;
                case "Add":
                    this.addButton.Click();
                    break;
                case "Six":
                    this.sixButton.Click();
                    break;
                case "Calc":
                    this.calcButton.Click();
                    break;
                case "Clear":
                    this.clearButton.Click();
                    break;
                case "Off":
                    this.offButton.Click();
                    break;
                default:
                    this.onButton.Click();
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
