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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBMaster db = new DBMaster();

            SqlDataReader reader = db.getReader("SELECT e.Model Cars, ei.year, ei.[desc] FROM Cars e JOIN carsDetails ei ON e.Car_id = ei.carId");

            string temp = "";

            while (reader.Read())
            {
                temp += "<div>";
                temp += reader["Cars"].ToString();
                temp += " ";
                temp += reader["year"].ToString();
                temp += " ";
                temp += reader["desc"].ToString();
                temp += "</div><br/>";
            }

            db.closeConnection();

            cars_details.Text = temp;
        }
    }
}