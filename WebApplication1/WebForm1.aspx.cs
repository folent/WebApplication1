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
            DBMaster db = new DBMaster();
            SqlDataReader reader = db.getReader("SELECT * FROM Cars");

            string temp = "";
          
            while (reader.Read())
            {
                temp += "<tr><td>";
                temp += reader["Model"].ToString();
                temp += "</td><td>";
                temp += reader["fuel"].ToString();
                temp += "</td></tr>";
            }
            db.closeConnection();
            data_table.Text = temp;
        }

        public void show_fuel(object sender, EventArgs e)
        {
            if (fuels.Text.Length > 0)
            {
                fuels.Text = "";
                return;
            }
            DBMaster db = new DBMaster();
            SqlDataReader reader = db.getReader("SELECT DISTINCT fuel FROM Cars");

            string temp = "";

            while (reader.Read())
            {
                temp += "<div>";
                temp += reader["fuel"].ToString();
                temp += "</div>";
            }
            db.closeConnection();
            fuels.Text = temp;
        }

    }
}