using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Home2 : System.Web.UI.Page
    {
        public MsMember activeMember;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                activeMember = MemberHandler.GetMemberById(2);

                LabelHello.Text = "Hi, " + activeMember.MemberName + "!";

                List<MsFlowerModel> flowers = FlowerHandler.GetFlowers();

                RepeaterFlower.DataSource = flowers;
                RepeaterFlower.DataBind();
            }
            
        }

        protected void BtnManageMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/ManageMember.aspx");
        }

        protected void BtnManageEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee/ManageEmployee.aspx");
        }

        protected void BtnManageFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("Flower/ManageFlower.aspx");
        }

        protected void BtnViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/ViewTransactionHistory.aspx");
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        protected void BtnPreOrderFlower_Command(object sender, CommandEventArgs e)
        {
            string strId = e.CommandArgument.ToString();

            Response.Redirect("Flower/PreOrder.aspx?id=" + int.Parse(strId));
        }
    }
}