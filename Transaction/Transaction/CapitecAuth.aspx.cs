using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CapitecAuth : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string email = email_Address.Text;
            string password = passWord.Text;

            Capitec.CapitecLog(email, password);

            if (LibraryUtils.fail.Contains("amount"))
            {
                MessageBox.Show(Page, "The amount exceeds your available balance");
            }
            else
            {
                Response.Redirect("Default2.aspx");
            }

        }

    }
}