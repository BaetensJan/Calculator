using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HP.LFT.SDK;
using HP.LFT.SDK.WPF;

namespace CalculatorTestFramework.WindowObjects
{
    public class SettingsWindow
    {
        protected IWindow window = Desktop.Describe<IWindow>(new WindowDescription
        {
            WindowTitleRegExp = @"Settings",
            ObjectName = @"Settings",
            FullType = @"window"
        });

        protected IButton closeButton;

        public SettingsWindow()
        {
            closeButton = window.Describe<IButton>(new ButtonDescription
            {
                ObjectName = @"CloseButton",
                Text = @"Back"
            });
        }

        public void CloseSettings()
        {
            closeButton.Click();
        }
    }
}
