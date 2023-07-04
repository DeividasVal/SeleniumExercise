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
        public IWebElement link => driver.FindElement(By.LinkText("click me"));
        public IWebElement answerBox4 => driver.FindElement(By.Id("answer4"));
        public IWebElement answerBox1 => driver.FindElement(By.Id("answer1"));
        public ReadOnlyCollection<IWebElement> blueBoxes => driver.FindElements(By.ClassName("bluebox"));
        public IWebElement dropdown => driver.FindElement(By.Id("occupation"));
    }
}
