using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumExercise.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver _driver;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("http://timvroom.com/selenium/playground/");

            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}