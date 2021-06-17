using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string message = MemberController.Login(email, password);

            if (message.Equals(""))
            {
                loginMsg.Text = "Login Success!";
                loginMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                loginMsg.Text = message;
                loginMsg.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}