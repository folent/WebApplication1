using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using WebApplication1.App_Code;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string Method_GET_CARS()
        {
            string sql = "SELECT * FROM Cars";
            DBMaster db = new DBMaster();
            db.getConnection();
            string adapterJSON = db.getAdapterJSON(sql);
            db.closeConnection();
            return adapterJSON;
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string Method_GET_FUELS()
        {
            string sql = "SELECT DISTINCT fuel FROM Cars";
            DBMaster db = new DBMaster();
            db.getConnection();
            string adapterJSON = db.getAdapterJSON(sql);
            db.closeConnection();
            return adapterJSON;
        }
    }
}
