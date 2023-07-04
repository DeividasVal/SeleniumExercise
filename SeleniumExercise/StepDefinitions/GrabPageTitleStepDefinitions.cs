using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExercise.Pages;
using TechTalk.SpecFlow;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class GrabPageTitleStepDefinitions
    {
        private readonly MainPage nameSectionPage;
        private readonly IWebDriver driver;

        public GrabPageTitleStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            this.nameSectionPage = new MainPage(driver);
        }

        [When(@"the page title is grabbed")]
        public void WhenThePageTitleIsGrabbed()
        {
            string pageTitle = driver.Title;
            ScenarioContext.Current["PageTitle"] = pageTitle;
            Thread.Sleep(2000);
        }

        [Then(@"the title text is placed in answer slot")]
        public void ThenTheTitleTextIsPlacedInAnswerSlot()
        {
            string pageTitle = ScenarioContext.Current["PageTitle"].ToString();
            nameSectionPage.answerBox1.SendKeys(pageTitle);
            string answerSlot1 = nameSectionPage.answerBox1.GetAttribute("value");

            Assert.AreEqual(pageTitle, answerSlot1);
            Thread.Sleep(2000);
        }
    }
}
