using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class NameSectionStepDefinitions
    {
        private readonly IWebDriver driver;

        public NameSectionStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"the name section of the form is filled out with '(.*)'")]
        public void WhenTheNameSectionOfTheFormIsFilledOut(string name)
        {
            IWebElement nameInput = driver.FindElement(By.Id("name"));
            nameInput.SendKeys(name);
        }

        [Then(@"the name section of the form should contain '(.*)'")]
        public void ThenTheNameSectionOfTheFormShouldContain(string expectedName)
        {
            IWebElement nameInput = driver.FindElement(By.Id("name"));
            string actualName = nameInput.GetAttribute("value");

            Assert.AreEqual(expectedName, actualName);
        }
    }
}
