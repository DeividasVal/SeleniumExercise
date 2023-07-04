using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExercise.Pages;
using System;
using TechTalk.SpecFlow;


namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class SetOccupationStepDefinitions
    {
        private readonly MainPage nameSectionPage;

        public SetOccupationStepDefinitions(IWebDriver driver)
        {
            this.nameSectionPage = new MainPage(driver);
        }

        [When(@"the user selects the drop down menu and chooses menu item '([^']*)'")]
        public void WhenTheUserSelectsTheDropDownMenuAndChoosesMenuItem(string item)
        {
            SelectElement selectElement = new SelectElement(nameSectionPage.dropdown);
            selectElement.SelectByText(item);
            Thread.Sleep(2000);
        }

        [Then(@"the selected item should be '([^']*)'")]
        public void ThenTheSelectedItemShouldBe(string expectedItem)
        {
            SelectElement selectElement = new SelectElement(nameSectionPage.dropdown);
            string actualItem = selectElement.SelectedOption.Text;

            Assert.AreEqual(expectedItem, actualItem, $"Expected '{expectedItem}' but was '{actualItem}'");
            Thread.Sleep(2000);
        }
    }
}
