using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.SDK.WPF;
using HP.LFT.Verifications;
using UFTDeveloperTestProject1.PageObjects;

namespace CalculatorTestFramework
{
    [TestFixture]
    public class UftDeveloperTestUsingWindowObjects : UnitTestClassBase
        
    {

        private IAut application;
        private CalculatorWindow calculatorWindow;

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

            var applicationWindow = Desktop.Describe<IWindow>(new WindowDescription
            {
                WindowTitleRegExp = @"Calculator",
                ObjectName = @"Calculator",
                FullType = @"window"
            });

            applicationWindow.WaitUntilVisible();

            calculatorWindow = new CalculatorWindow(applicationWindow);
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
            var output = calculatorWindow.GetOutput();
            if (output != null && output.Equals("Off")) { 
                calculatorWindow.Click("On");
            }
        }

        [Test]
        // Using self written PageObject
        public void ClickOnePlusSixTest()
        {
            // Assert output is Off

            // Enable calc and do calculation 1+6
            calculatorWindow.Click("One");
            calculatorWindow.Click("Add");
            calculatorWindow.Click("Six");
            calculatorWindow.Click("Calc");

            // Assert out is 1+6= 7
            Assert.That(calculatorWindow.GetOutput().Equals("1+6= 7"));

            // Clear and disable calc
            calculatorWindow.Click("Clear");
        }

        [Test]
        public void ClickTwoPlusMultiplierTest()
        {
            calculatorWindow.Click("Two");
            calculatorWindow.Click("Add");
            calculatorWindow.Click("Multiply");
            calculatorWindow.Click("Calc");
            Assert.That(calculatorWindow.GetOutput().Equals("Error! Try again."));
        }

        [Test]
        public void ClickThreeMinusNineTest()
        {
            calculatorWindow.Click("Three");
            calculatorWindow.Click("Minus");
            calculatorWindow.Click("Nine");
            calculatorWindow.Click("Calc");
            Assert.That(calculatorWindow.GetOutput().Equals("3-9= -6"));
        }


        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            var output = calculatorWindow.GetOutput();
            if (output == null || !output.Equals("Off"))
            {
                calculatorWindow.Click("Off");
            }
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture

            application.Close();
        }
    }
}
