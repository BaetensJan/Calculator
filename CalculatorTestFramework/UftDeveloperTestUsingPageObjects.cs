using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.SDK.WPF;
using HP.LFT.Verifications;
using UFTDeveloperTestProject1.PageObjects;

namespace CalculatorTestFramework
{
    [TestFixture]
    public class UftDeveloperTestUsingPageObjects : UnitTestClassBase
        
    {

        private IAut application;
        private CalculatorPage calculatorPage;

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

            calculatorPage = new CalculatorPage(calculatorWindow);
        }

        [SetUp]
        public void SetUp()
        { 
            // Before each test
        }

        [Test]
        // Using self written PageObject
        public void ClickOnePlusSixTest()
        {
            // Assert output is Off
            Assert.That(this.calculatorPage.GetOutput().Equals("Off"));

            // Enable calc and do calculation 1+6
            this.calculatorPage.Click("On");
            this.calculatorPage.Click("One");
            this.calculatorPage.Click("Add");
            this.calculatorPage.Click("Six");
            this.calculatorPage.Click("Calc");

            // Assert out is 1+6= 7
            Assert.That(this.calculatorPage.GetOutput().Equals("1+6= 7"));

            // Clear and disable calc
            this.calculatorPage.Click("Clear");
            this.calculatorPage.Click("Off");

            // Assert out is Off
            Assert.That(this.calculatorPage.GetOutput().Equals("Off"));
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
