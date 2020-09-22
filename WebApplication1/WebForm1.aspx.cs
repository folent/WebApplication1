using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Cars";
            DBMaster db = new DBMaster();
            db.getConnection();
            SqlDataReader reader = db.getReader(sql);

            while(reader.Read())
            {
                UserControls.MainPageCard MainPageCard = (UserControls.MainPageCard)
                Page.LoadControl("~/UserControls/MainPageCard.ascx");
                MainPageCard.Title = reader["Model"].ToString();
                MainPageCard.Desc = reader["fuel"].ToString();
                MainPageCard.id = reader["Car_Id"].ToString();
                MainPageCard.Link = "../"+reader["Car_Id"].ToString();
                Panel1.Controls.Add(MainPageCard);
            }
             
            db.closeConnection();
        }
    }
}