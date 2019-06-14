using System;
using OpenQA.Selenium;

public partial class Default2 : System.Web.UI.Page
{
    static IWebDriver driver;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        string otp = OTP.Text;

        LibraryUtils.OTPSequence(otp);

        if (LibraryUtils.con.Contains("successful"))
        {
            MessageBox.Show(Page, LibraryUtils.con);
        }
        else
        {
            MessageBox.Show(Page, "Payment unsuccuessful");
        }
    }
}
