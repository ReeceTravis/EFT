using OpenQA.Selenium;
using System;

public partial class LoginOTP : System.Web.UI.Page
{

    string rec = "";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string otp = OTP.Text;

        LibraryUtils.loginOTP(otp);

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