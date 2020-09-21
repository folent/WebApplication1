using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;

namespace WebApplication1
{
    public partial class MyControl : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "SELECT e.Model Cars, ei.year, ei.[desc] FROM Cars e JOIN carsDetails ei ON e.Car_id = ei.carId";
            DBMaster db = new DBMaster();
            SqlDataReader reader = db.getReader(sql);

            Table table = new Table();
            table.ID = "Table1";
            table.BackColor = Color.Gray;
            table.ForeColor = Color.White;
            table.CellPadding = 20;
            Page.Form.Controls.Add(table);

            while (reader.Read())
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();

                cell1.Text = reader["Cars"].ToString();
                cell2.Text = reader["year"].ToString();
                cell3.Text = reader["desc"].ToString();
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add( cell3);

                table.Rows.Add(row);
            }

            db.closeConnection();

        }
    }
}