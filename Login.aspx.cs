using System;
using System.Web.UI;

public partial class Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // Simple user validation
        if (username == "admin" && password == "password")
        {
            lblMessage.Text = "Login successful!";
        }
        else
        {
            lblMessage.Text = "Invalid username or password.";
        }
    }
}
