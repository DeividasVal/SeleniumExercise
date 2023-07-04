using OpenQA.Selenium;
using SeleniumExercise.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class ClickOnLinkStepDefinitions
    {
        private readonly MainPage nameSectionPage;

        public ClickOnLinkStepDefinitions(IWebDriver driver)
        {
            this.nameSectionPage = new MainPage(driver);
        }

        [When(@"the user clicks on a link with the text '([^']*)'")]
        public void WhenTheUserClicksOnALinkWithTheText(string text)
        {
            IWebElement link = nameSectionPage.link;
            link.Click();
            Thread.Sleep(2000);
        }
    }
}
