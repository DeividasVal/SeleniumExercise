using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class GrabPageTitleStepDefinitions
    {
        private readonly IWebDriver driver;

        public GrabPageTitleStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"the page title is grabbed")]
        public void WhenThePageTitleIsGrabbed()
        {
            string pageTitle = driver.Title;
            ScenarioContext.Current["PageTitle"] = pageTitle;
        }

        [Then(@"the title text is placed in answer slot")]
        public void ThenTheTitleTextIsPlacedInAnswerSlot()
        {
            string pageTitle = ScenarioContext.Current["PageTitle"].ToString();
            driver.FindElement(By.Id("answer1")).SendKeys(pageTitle);
            string answerSlot1 = driver.FindElement(By.Id("answer1")).GetAttribute("value");

            Assert.AreEqual(pageTitle, answerSlot1);

            driver.Quit();
        }
    }
}
