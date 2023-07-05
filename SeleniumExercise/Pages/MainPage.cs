using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumExercise.Pages
{
    internal class MainPage
    {
        private readonly IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement NameInput => driver.FindElement(By.Id("name"));
        public IWebElement Link => driver.FindElement(By.LinkText("click me"));
        public IWebElement ClickThenWaitLink => driver.FindElement(By.LinkText("click then wait"));
        public IWebElement AnswerBox4 => driver.FindElement(By.Id("answer4"));
        public IWebElement AnswerBox6 => driver.FindElement(By.Id("answer6"));
        public IWebElement AnswerBox8 => driver.FindElement(By.Id("answer8"));
        public IWebElement AnswerBox10 => driver.FindElement(By.Id("answer10"));
        public IWebElement AnswerBox11 => driver.FindElement(By.Id("answer11"));
        public IWebElement AnswerBox13 => driver.FindElement(By.Id("answer13"));
        public IWebElement AnswerBox14 => driver.FindElement(By.Id("answer14"));
        public IWebElement IsPurpleboxHere => driver.FindElement(By.Id("purplebox"));
        public IWebElement WroteBookRadioButton => driver.FindElement(By.CssSelector("input[type='radio'][name='wrotebook'][value='wrotebook']"));
        public IWebElement AnswerBox1 => driver.FindElement(By.Id("answer1"));
        public IWebElement RedBox => driver.FindElement(By.Id("redbox"));
        public ReadOnlyCollection<IWebElement> blueBoxes => driver.FindElements(By.ClassName("bluebox"));
        public IWebElement Dropdown => driver.FindElement(By.Id("occupation"));
        public IWebElement CheckResultsButton => driver.FindElement(By.Id("checkresults"));
        public IWebElement OrangeBox => driver.FindElement(By.Id("orangebox"));
        public IWebElement GreenBox => driver.FindElement(By.Id("greenbox"));
        public IWebElement Ok1 => driver.FindElement(By.Id("ok_1"));
        public IWebElement Ok2 => driver.FindElement(By.Id("ok_2"));
        public IWebElement SubmitButtonAfterWait => driver.FindElement(By.Id("submitbutton"));
        public IWebElement Ok3 => driver.FindElement(By.Id("ok_3"));
        public IWebElement Ok4 => driver.FindElement(By.Id("ok_4"));
        public IWebElement Ok5 => driver.FindElement(By.Id("ok_5"));
        public IWebElement Ok6 => driver.FindElement(By.Id("ok_6"));
        public IWebElement Ok7 => driver.FindElement(By.Id("ok_7"));
        public IWebElement Ok8 => driver.FindElement(By.Id("ok_8"));
        public IWebElement Ok9 => driver.FindElement(By.Id("ok_9"));
        public IWebElement Ok10 => driver.FindElement(By.Id("ok_10"));
        public IWebElement Ok11 => driver.FindElement(By.Id("ok_11"));
        public IWebElement Ok12 => driver.FindElement(By.Id("ok_12"));
        public IWebElement Ok13 => driver.FindElement(By.Id("ok_13"));
        public IWebElement Ok14 => driver.FindElement(By.Id("ok_14"));
        public IWebElement Ok15 => driver.FindElement(By.Id("ok_15"));
        public IWebElement Ok16 => driver.FindElement(By.Id("ok_16"));
        public IWebElement Ok17 => driver.FindElement(By.Id("ok_17"));
    }
}
