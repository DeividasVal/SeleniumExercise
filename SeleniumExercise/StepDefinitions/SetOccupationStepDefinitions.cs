using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;


namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class SetOccupationStepDefinitions
    {
        private readonly IWebDriver driver;

        public SetOccupationStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"the user selects the drop down menu and chooses menu item '([^']*)'")]
        public void WhenTheUserSelectsTheDropDownMenuAndChoosesMenuItem(string item)
        {
            IWebElement dropdown = driver.FindElement(By.Id("occupation"));
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(item);
        }

        [Then(@"the selected item should be '([^']*)'")]
        public void ThenTheSelectedItemShouldBe(string expectedItem)
        {
            IWebElement dropdown = driver.FindElement(By.Id("occupation"));
            SelectElement selectElement = new SelectElement(dropdown);
            string actualItem = selectElement.SelectedOption.Text;

            Assert.AreEqual(expectedItem, actualItem, $"Expected '{expectedItem}' but was '{actualItem}'");
        }
    }
}
