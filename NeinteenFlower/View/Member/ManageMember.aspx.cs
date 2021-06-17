using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View.Member
{
    public partial class ManageMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<MsMember> members = MemberHandler.GetMembers();

                RepeaterMember.DataSource = members;
                RepeaterMember.DataBind();
            }
        }
        protected void BtnAddNewMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMember.aspx");
        }

        protected void BtnEditMember_Command(object sender, CommandEventArgs e)
        {
            string strId = e.CommandArgument.ToString();

            Response.Redirect("UpdateMember.aspx?id=" + int.Parse(strId));
        }
    }
}