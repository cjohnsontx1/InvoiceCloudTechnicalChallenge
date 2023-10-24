using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace InvoiceCloudTechnicalChallenge;

[TestClass]
public class InternetTest
{

    [TestMethod]
    public void AddAndValidateElements() {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        InternetHomePage internetHomePage = new(driver);
        int numElements = 5;
        internetHomePage.GoToHomepage();
        internetHomePage.AddElements(numElements);
        Assert.AreEqual(internetHomePage.GetAllElements(), numElements);
        driver.Close();
    }
}