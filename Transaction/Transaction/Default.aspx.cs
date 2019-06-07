using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = email_Address.Text;
        string password = passWord.Text;

        ChromeOptions option = new ChromeOptions();
        option.AddArgument("--headless");
        IWebDriver driver = new ChromeDriver("C:\\Users\\Public"/*,option*/);

       /* ChromeOptions options = new ChromeOptions();
        ChromeDriverService service = ChromeDriverService.CreateDefaultService("C:\\Users\\Public");
        service.HideCommandPromptWindow = true;
        IWebDriver driver = new ChromeDriver(service, options);*/

        driver.Navigate().GoToUrl("https://onlinebanking.standardbank.co.za/#/login?intcmp=coza-sitewide-headernav-direct-login");

        driver.FindElement(By.XPath("//input[@id = 'username']")).SendKeys(email);

        driver.FindElement(By.XPath("//button[text() = 'Next']")).Click();

        // Thread.Sleep(1500);

        LibraryUtils.FindElement(driver, By.XPath("//span[text() = 'Sign In With Password']/.."), 10);

        //driver.FindElement(By.XPath("//span[text() = 'Sign In With Password']/..")).Click();

        Thread.Sleep(1000);

        driver.FindElement(By.XPath("//input[@type = 'password']")).SendKeys(password);

        driver.FindElement(By.XPath("//span[text() = 'Sign in']/..")).Click();

        Thread.Sleep(3000);

        driver.FindElement(By.XPath("//span[text() = 'PAY']")).Click();

        driver.FindElement(By.XPath("//li[text() = 'Once-off payment']")).Click();

        Thread.Sleep(2000);

        driver.FindElement(By.XPath("//input[@id = 'name']")).SendKeys("Traverse");

        driver.FindElement(By.XPath("//input[@id = 'Bank-input']")).SendKeys("standard bank");

        driver.FindElement(By.XPath("//input[@id = 'accountNumber']")).SendKeys("270657282");

        driver.FindElement(By.XPath("//input[@id = 'myReference']")).SendKeys("eft test");

        driver.FindElement(By.XPath("//input[@id = 'beneficiaryReference']")).SendKeys("eft test");

        driver.FindElement(By.XPath("//input[@id = 'Recipient_Name']")).SendKeys("Traverse");

        driver.FindElement(By.XPath("//input[@id = 'Recipient_Email']")).SendKeys("traversek@gmail.com");

        driver.FindElement(By.XPath("//input[@id = 'amount']")).SendKeys("1");

        driver.FindElement(By.XPath("//span[text() = 'Next']/..")).Click();

        Thread.Sleep(500);

        driver.FindElement(By.XPath("//span[text() = 'Confirm']/..")).Click();

        Response.Redirect("Default2.aspx");
    }
}