using OpenQA.Selenium;

class InternetHomePage {
    private readonly string url = "https://the-internet.herokuapp.com/add_remove_elements/";
    private readonly IWebDriver driver;

    public InternetHomePage(IWebDriver driver) {
        this.driver = driver;
    }

    private IWebElement Title => driver.FindElement(By.Id("content"));
    private IWebElement AddElementBtn => driver.FindElement(By.CssSelector("#content > div > button"));

    public void GoToHomepage() {
        driver.Navigate().GoToUrl(url);
        Assert.IsTrue(Title.Displayed);
    }

    public IWebElement GetElement(int index) {
        return driver.FindElement(By.CssSelector($"#elements > button:nth-child({index})"));
    }

    public int GetAllElements() {
        return driver.FindElements(By.CssSelector("#elements > button")).Count;
    }

    public void AddElements(int numElements = 1) {
        for (int i = 1; i <= numElements; i++) {
            AddElementBtn.Click();
        }
    }
}

