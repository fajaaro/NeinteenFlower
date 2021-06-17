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
    public partial class ManageFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<MsFlowerModel> flowers = FlowerHandler.GetFlowers();

                RepeaterFlower.DataSource = flowers;
                RepeaterFlower.DataBind();
            }
        }

        protected void BtnAddNewFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertFlower.aspx");
        }

        protected void BtnEditFlower_Command(object sender, CommandEventArgs e)
        {
            string strId = e.CommandArgument.ToString();

            Response.Redirect("UpdateFlower.aspx?id=" + int.Parse(strId));
        }
    }
}