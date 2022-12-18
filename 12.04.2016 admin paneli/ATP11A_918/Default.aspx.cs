using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using okulModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        okulEntities db = new okulEntities();
        RptOgrenci.DataSource = db.ogrenciler.OrderByDescending(o=>o.ogrenciId).Take(6);
        RptOgrenci.DataBind();
    }
}
