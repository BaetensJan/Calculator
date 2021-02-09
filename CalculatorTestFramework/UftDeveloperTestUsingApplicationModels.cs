using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.SDK.WPF;
using HP.LFT.Verifications;

namespace CalculatorTestFramework
{
    [TestFixture]
    public class UftDeveloperTestUsingApplicationModels : UnitTestClassBase
    {

        private IAut application;
        private CalculatorApplicationModel calculatorApplicationModel;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture

            // Define in autConfig located in your %localappdata%/LeanFT/config folder.
            // Create authConfig.json file if not present and structure it like described here
            // https://admhelp.microfocus.com/uftdev/en/15.0-15.0.2/HelpCenter/Content/HowTo/TestObjects_Manual.htm#Run
            // To make your app start up, follow instructions here
            // https://admhelp.microfocus.com/uftdev/en/15.0-15.0.2/NetSDKReference/webframe.html#CodeSamples_.NET/LaunchAUT_Samples.htm

            application = Desktop.LaunchAut("C:\\Users\\Jan Baetens\\source\\repos\\Calculator\\Calculator\\bin\\Debug\\Calculator.exe");

            var calculatorWindow = Desktop.Describe<IWindow>(new WindowDescription
            {
                WindowTitleRegExp = @"Calculator",
                ObjectName = @"Calculator",
                FullType = @"window"
            });

            calculatorWindow.WaitUntilVisible();

            calculatorApplicationModel = new CalculatorApplicationModel();

        }

        [SetUp]
        public void SetUp()
        { 
            // Before each test
        }

        [Test]
        public void ClickOnePlusSixTest()
        {
            // Assert output is Off
            Assert.That(calculatorApplicationModel.CalculatorWindow.OutputField.Text.Equals("Off"));

            // Enable calc and do calculation 1+6
            calculatorApplicationModel.CalculatorWindow.OnButton.Click();
            calculatorApplicationModel.CalculatorWindow.OneButton.Click();
            calculatorApplicationModel.CalculatorWindow.AddButton.Click();
            calculatorApplicationModel.CalculatorWindow.SixButton.Click();
            calculatorApplicationModel.CalculatorWindow.CalcButton.Click();

            // Assert out is 1+6= 7
            Assert.That(calculatorApplicationModel.CalculatorWindow.OutputField.Text.Equals("1+6= 7"));

            // Clear and disable calc
            calculatorApplicationModel.CalculatorWindow.ClearButton.Click();
            calculatorApplicationModel.CalculatorWindow.OffButton.Click();

            // Assert out is Off
            Assert.That(calculatorApplicationModel.CalculatorWindow.OutputField.Text.Equals("Off"));
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture

            application.Close();
        }
    }
}
