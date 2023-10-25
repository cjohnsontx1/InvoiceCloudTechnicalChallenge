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
        // Navigate to homepage
        HomePage.GoToHomepage();
        // Add n elements
        HomePage.AddElements(numElements);
        // Verify number of elements on screen is equal to number of elements expected
        Assert.AreEqual(HomePage.GetAllElements(), numElements);
        // Ability to delete elements by index
        // internetHomePage.DeleteElement(2);
    }

    [TearDown]
    public void Cleanup() {
        Driver.Close();
    }
}