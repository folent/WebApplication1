using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.UserControls
{
    public partial class AddCarUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtAdd_Click(object sender, EventArgs e)
        {
            if(txtModel.Text.Length > 0 && txtFuel.Text.Length > 0)
            {
                Label1.Text = txtModel.Text + "  " + txtFuel.Text;
            }
        }
    }
}