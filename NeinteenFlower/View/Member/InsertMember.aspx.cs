using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View.Member
{
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = InputName.Text;
            DateTime DOB = DateTime.Parse(InputDOB.Text);
            string gender = Request.Form["InputGender"];
            string address = InputAddress.Text;
            string phone = InputPhone.Text;
            string email = InputEmail.Text;
            string password = InputPassword.Text;

            string message = MemberController.CreateMember(name, DOB, gender, address, phone, email, password);

            if (message.Equals(""))
            {
                LabelAlertMessage.Text = "Success add new member!";
                LabelAlertMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LabelAlertMessage.Text = message;
                LabelAlertMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}