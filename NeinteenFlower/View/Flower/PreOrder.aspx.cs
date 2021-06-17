using NeinteenFlower.Controller;
using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View.Flower
{
    public partial class PreOrder : System.Web.UI.Page
    {
        public MsFlower flower;
        private MsMember activeMember;
        protected void Page_Load(object sender, EventArgs e)
        {
            activeMember = MemberHandler.GetMemberByEmail("andreupdated@gmail.com");

            
            string strId = Request.QueryString["id"];
            bool hasFlower = false;

            if (strId != null)
            {
                MsFlower flower = FlowerHandler.GetFlower(int.Parse(strId));
                this.flower = flower;

                if (flower != null)
                {
                    LabelName.Text = "Flower Name: " + flower.FlowerName;
                    LabelPrice.Text = "Flower Price: " + flower.FlowerPrice.ToString();

                    hasFlower = true;
                }
            }

            if (!hasFlower)
            {
                Response.Redirect("/View/404.aspx");
            }

        }

        protected void BtnPreOrder_Click(object sender, EventArgs e)
        {
            int memberId = activeMember.MemberId;
            DateTime transactionDate = DateTime.Now;
            int flowerId = flower.FlowerId;
            int qty = int.Parse(InputQuantity.Text);

            string message = TransactionController.PreOrder(memberId, transactionDate, flowerId, qty);

            if (message.Equals(""))
            {
                LabelAlertMessage.Text = "PreOrder success!";
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