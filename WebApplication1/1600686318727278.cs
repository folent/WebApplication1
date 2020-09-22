using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Infinium.MasterControls
{
    public partial class MainMenuItem : System.Web.UI.UserControl
    {
        public string ModuleName = "";
        public string Link = "";
        public string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            MainMenuItemLink.HRef = Link;
            MainMenuItemName.InnerHtml = ModuleName;
            MainMenuItemName.ID = "MainMenuItemName_" + id;
            MainMenuItemName.ClientIDMode = ClientIDMode.Static;
            MainMenuItemUp.ClientIDMode = ClientIDMode.Static;
            MainMenuItemUp.ID = "MainMenuItemUp_" + id;

            if (UpdatesCount > 0)
            {
                MainMenuItemUp.InnerHtml = UpdatesCount.ToString();
                MainMenuItemUp.Style.Add("display", "inline-block");
            }
        }

        public bool Selected
        {
            set
            {
                if (value)
                {
                    MainMenuItemName.Attributes.Remove("class");
                    MainMenuItemName.Attributes.Add("class", "MainMenuItemS");
                }
            }
        }
    }
}