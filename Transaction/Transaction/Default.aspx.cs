using OpenQA.Selenium;
using System;
using System.Web.UI;

public partial class _Default : Page
{

    static IWebDriver driver;
    public void Page_Init(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          // LibraryUtils.spb();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = email_Address.Text;
        string password = passWord.Text;
        string rec = recEmail.Text;

        if (IsPostBack)
        {

            LibraryUtils.EmailLogin(email, password);

            if (LibraryUtils.IsElementPresent(By.XPath("//span[contains(text(), 'Incorrect')]")))
            {
                MessageBox.Show(Page, "Invalid sign-in details. Please try again");
                LibraryUtils.driver.Quit();
            }
            else if (LibraryUtils.IsElementPresent(By.XPath("//input[@id = 'otp']")))
            {
                Response.Redirect("LoginOTP.aspx");
            }

            if (LibraryUtils.IsElementPresent(By.XPath("//span[text() = 'PAY']")))
            {
                LibraryUtils.conBen(rec);
            }

            if (LibraryUtils.IsElementPresent(By.XPath("//span[text() = 'The amount exceeds your available balance']")))
            {
                MessageBox.Show(Page, "The amount exceeds your available balance");
                LibraryUtils.driver.Quit();

            }
            else
            {
                LibraryUtils.conPay();
                Response.Redirect("Default2.aspx");
            }
        }
    }
}