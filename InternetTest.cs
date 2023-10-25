using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace InvoiceCloudTechnicalChallenge;

[TestFixture]
public class InternetTest
{
    IWebDriver Driver;

    [SetUp]
    public void Setup() {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
    }

    [Test]
    public void AddAndValidateElements() {
        InternetHomePage HomePage = new(Driver);
        int numElements = 5;
        HomePage.GoToHomepage();
        HomePage.AddElements(numElements);
        Assert.AreEqual(HomePage.GetAllElements(), numElements);
        // internetHomePage.DeleteElement(2);
    }

    [TearDown]
    public void TearDown() {
        Driver.Close();
    }
}