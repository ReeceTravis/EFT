using System;
using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LibraryUtils
/// </summary>
public static class LibraryUtils
{
    

    public static IWebElement FindElement(this IWebDriver driver, By By, int timeoutInSeconds)
    {
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElement(By));
        }
        return driver.FindElement(By);
    }

    public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
    {
        return (driver) =>
        {
            try
            {
                return element.Displayed;
            }
            catch (Exception)
            {
                // If element is null, stale or if it cannot be located
                return false;
            }
        };
    }
}