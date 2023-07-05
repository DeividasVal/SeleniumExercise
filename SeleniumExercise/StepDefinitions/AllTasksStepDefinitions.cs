using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExercise.Pages;
using System;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SeleniumExercise.StepDefinitions
{
    [Binding]
    public class AllTasksStepDefinitions
    {
        private readonly MainPage mainPage;
        private readonly IWebDriver driver;

        public AllTasksStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            this.mainPage = new MainPage(driver);
        }

        [When(@"the page title is grabbed the title text is placed in answer slot")]
        public void WhenThePageTitleIsGrabbedTheTitleTextIsPlacedInAnswerSlot()
        {
            string pageTitle = driver.Title;
            mainPage.AnswerBox1.SendKeys(pageTitle);
            ScenarioContext.Current["PageTitle"] = pageTitle;
            Thread.Sleep(2000);
        }

        [When(@"name section of the form is filled out with '([^']*)'")]
        public void WhenNameSectionOfTheFormIsFilledOutWith(string name)
        {
            mainPage.NameInput.SendKeys(name);
            Thread.Sleep(2000);
        }

        [When(@"user selects the drop down menu and chooses menu item '([^']*)'")]
        public void WhenUserSelectsTheDropDownMenuAndChoosesMenuItem(string item)
        {
            SelectElement selectElement = new SelectElement(mainPage.Dropdown);
            selectElement.SelectByText(item);
            Thread.Sleep(2000);
        }

        [When(@"count the number of blueboxes on the page")]
        public void WhenCountTheNumberOfBlueboxesOnThePage()
        {
            ReadOnlyCollection<IWebElement> blueBoxes = mainPage.blueBoxes;
            int blueBoxCount = blueBoxes.Count;

            ScenarioContext.Current["BlueBoxCount"] = blueBoxCount;
            Thread.Sleep(2000);
        }

        [When(@"the bluebox count into answer box #4")]
        public void WhenTheBlueboxCountIntoAnswerBox()
        {
            int blueBoxCount = (int)ScenarioContext.Current["BlueBoxCount"];

            IWebElement answerBox4 = mainPage.AnswerBox4;
            answerBox4.SendKeys(blueBoxCount.ToString());
        }

        [When(@"user clicks on a link with the text 'click me'")]
        public void WhenUserClicksOnALinkWithTheText()
        {
            IWebElement link = mainPage.Link;
            link.Click();
            Thread.Sleep(2000);
        }

        [When(@"class applied to the red box is retrieved")]
        public void WhenClassAppliedToTheRedBoxIsRetrieved()
        {
            string redBoxClass = mainPage.RedBox.GetAttribute("class");
            ScenarioContext.Current["RedBoxClass"] = redBoxClass;
            Thread.Sleep(2000);
        }

        [When(@"the class applied to the red box is entered into answer box #6")]
        public void WhenTheClassAppliedToTheRedBoxIsEnteredIntoAnswerBox()
        {
            string redBoxClass = ScenarioContext.Current["RedBoxClass"].ToString();
            mainPage.AnswerBox6.SendKeys(redBoxClass);
            Thread.Sleep(2000);
        }

        [When(@"the function ran_this_js_function\(\) is ran")]
        public void WhenTheFunctionRan_This_Js_FunctionIsRan()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("ran_this_js_function()");
            Thread.Sleep(2000);
        }

        [When(@"the function got_return_from_js_function\(\) is ran and it's answer is put into answer box six")]
        public void WhenTheFunctionGot_Return_From_Js_FunctionIsRanAndItsAnswerIsPutIntoAnswerBox()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            string returnedValue = jsExecutor.ExecuteScript("return got_return_from_js_function();").ToString();
            mainPage.AnswerBox8.SendKeys(returnedValue);
            Thread.Sleep(2000);
        }

        [When(@"the radio button is marked to Yes for written book")]
        public void WhenTheRadioButtonIsMarkedToYesForWrittenBook()
        {
            mainPage.WroteBookRadioButton.Click();
            Thread.Sleep(2000);
        }

        [When(@"the text from the red box is placed in answer box #10")]
        public void WhenTheTextFromTheRedBoxIsPlacedInAnswerBox()
        {
            string textFromRedbox = mainPage.RedBox.Text;
            mainPage.AnswerBox10.SendKeys(textFromRedbox);
            Thread.Sleep(2000);
        }

        [When(@"check box is on top\? orange or green, place correct color in answer slot eleven")]
        public void WhenCheckBoxIsOnTopOrangeOrGreenPlaceCorrectColorInAnswerSlot()
        {
            bool isOrangeOnTop = mainPage.OrangeBox.Location.Y < mainPage.GreenBox.Location.Y;
            string answer11 = isOrangeOnTop ? "orange" : "green";

            mainPage.AnswerBox11.SendKeys(answer11);
            Thread.Sleep(2000);
        }

        [When(@"set browser width to (.*) and height to (.*)")]
        public void WhenSetBrowserWidthToAndHeightTo(int width, int height)
        {
            driver.Manage().Window.Size = new System.Drawing.Size(width, height);
            Thread.Sleep(2000);
        }

        [When(@"type into answer slot thirteen yes or no depending on whether item by id of ishere is on the page")]
        public void WhenTypeIntoAnswerSlotThirteenYesOrNoDependingOnWhetherItemByIdOfIshereIsOnThePage()
        {
            bool isHereElementExists = driver.FindElements(By.Id("ishere")).Count > 0;

            string answer = isHereElementExists ? "yes" : "no";
            mainPage.AnswerBox13.SendKeys(answer);
            Thread.Sleep(2000);
        }

        [When(@"type into answer slot fourteen yes or no depending on whether item with id of purplebox is visible")]
        public void WhenTypeIntoAnswerSlotFourteenYesOrNoDependingOnWhetherItemWithIdOfPurpleboxIsVisible()
        {
            bool isHereElementExists = mainPage.IsPurpleboxHere.Displayed;

            string answer = isHereElementExists ? "yes" : "no";
            mainPage.AnswerBox14.SendKeys(answer);
            Thread.Sleep(2000);
        }

        [When(@"do the waiting game")]
        public void WhenDoTheWaitingGame()
        {
            mainPage.ClickThenWaitLink.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement clickAfterWaitLink = wait.Until(ExpectedConditions.ElementExists(By.LinkText("click after wait")));

            Thread.Sleep(100);
            clickAfterWaitLink.Click();
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            Thread.Sleep(2000);
        }

        [When(@"click complete after the waiting game")]
        public void WhenClickCompleteAfterTheWaitingGame()
        {
            mainPage.SubmitButtonAfterWait.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the button check results is pressed")]
        public void ThenTheButtonCheckResultsIsPressed()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
            mainPage.CheckResultsButton.Click();
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\valac\\Desktop\\results.png", ScreenshotImageFormat.Png);
        }
    }
}
