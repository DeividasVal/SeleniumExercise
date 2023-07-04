using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SeleniumExercise.Pages;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class NameSectionStepDefinitions
    {
        private readonly MainPage nameSectionPage;

        public NameSectionStepDefinitions(IWebDriver driver)
        {
            this.nameSectionPage = new MainPage(driver);
        }

        [When(@"the name section of the form is filled out with '(.*)'")]
        public void WhenTheNameSectionOfTheFormIsFilledOut(string name)
        {
            nameSectionPage.NameInput.SendKeys(name);
            Thread.Sleep(2000);
        }

        [Then(@"the name section of the form should contain '(.*)'")]
        public void ThenTheNameSectionOfTheFormShouldContain(string expectedName)
        {
            string actualName = nameSectionPage.NameInput.GetAttribute("value");

            Assert.AreEqual(expectedName, actualName);
            Thread.Sleep(2000);
        }
    }
}
