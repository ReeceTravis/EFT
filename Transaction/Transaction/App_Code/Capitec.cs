using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Capitec
/// </summary>
public class Capitec
{
    static IWebDriver driver;
    public static string fail;

    public static void CapitecLog(String email, String password/*, String rec*/)
    {
        ChromeOptions option = new ChromeOptions();
        option.AddArguments("--headless", "--disable-gpu", "--window-size=1200,900");
        driver = new ChromeDriver("C:\\Users\\Public"/*, option*/);

        driver.Navigate().GoToUrl("https://direct.capitecbank.co.za/ibank/");
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//Label[@id = 'usernameLabel']//input[@id = 'username']"))).SendKeys(email);

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type = 'password']"))).SendKeys(password);

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Sign in']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Go to my banking portfolio']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Go to the payments menu']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Pay a beneficiary']"))).Click();
        
        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id = 'beneficiaryName']"))).SendKeys("standard bank");

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id = 'beneficiaryAccountNo']"))).SendKeys("10091879696");

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@id = 'selectedBankID']//option[text() = 'Standard Bank']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id = 'beneficiaryToStatementDesc']"))).SendKeys("eftref");

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id = 'emailShow']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name= 'email']"))).SendKeys("traversek@gmail.com");

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Add this beneficiary to my list']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Pay this beneficiary']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name = 'amount']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Pay this amount now (Money will be available within 48 hours)']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'No']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Make another payment']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@name = 'selectedBeneficiary']//option[contains(text(), 'Traverse')]"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Remove the selected beneficiary']"))).Click();

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Yes']"))).Click();


        if (wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("//span[text() = 'The amount exceeds your available balance']"), "The amount exceeds your available balance")))
        {
            fail = driver.FindElement(By.XPath("//span[text() = 'The amount exceeds your available balance']")).Text.ToString();
        }
        else
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Next']/.."))).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text() = 'Confirm']/.."))).Click();
        }
    }
}