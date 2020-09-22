using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.UserControls
{
    public partial class MainPageCard : System.Web.UI.UserControl
    {
        public string Title = "";
        public string Desc = "";
        public string Link = "";
        public string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            MainPageCardLink.HRef = Link;
            MainPageCardLink.InnerText = "About the " +Title;
            MainPageCardTitle.InnerHtml = Title;
            MainPageCardDesc.InnerText = Desc;
            MainPageCardTitle.ID = "MainPageCard" + id;
        }
    }
}