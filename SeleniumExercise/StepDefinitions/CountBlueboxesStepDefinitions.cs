using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExercise.Pages;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class CountBlueboxesStepDefinitions
    {
        private readonly MainPage nameSectionPage;

        public CountBlueboxesStepDefinitions(IWebDriver driver)
        {
            this.nameSectionPage = new MainPage(driver);
        }

        [When(@"I count the number of blueboxes on the page")]
        public void WhenICountTheNumberOfBlueboxesOnThePage()
        {
            ReadOnlyCollection<IWebElement> blueBoxes = nameSectionPage.blueBoxes;
            int blueBoxCount = blueBoxes.Count;

            ScenarioContext.Current["BlueBoxCount"] = blueBoxCount;
            Thread.Sleep(2000);
        }

        [Then(@"I enter the bluebox count into answer box #4")]
        public void ThenIEnterTheBlueboxCountIntoAnswerBox()
        {
            int blueBoxCount = (int)ScenarioContext.Current["BlueBoxCount"];

            IWebElement answerBox4 = nameSectionPage.answerBox4;
            answerBox4.SendKeys(blueBoxCount.ToString());

            string enteredValue = answerBox4.GetAttribute("value");
            Assert.AreEqual(blueBoxCount.ToString(), enteredValue);
            Thread.Sleep(2000);
        }
    }
}
