using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    static IWebDriver driver;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        

        string otp = OTP.Text;

        driver.FindElement(By.XPath("//input[@id = 'otp']")).SendKeys(otp);
        driver.FindElement(By.XPath("//span[text() = 'Submit']/..")).Click();
    }
}