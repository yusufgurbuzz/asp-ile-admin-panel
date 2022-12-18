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

public partial class admin_sinif : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        okulEntities db = new okulEntities();
        RptSiniflar.DataSource = db.siniflar;
        RptSiniflar.DataBind();
       
    }
    protected void BtnYeniSinifEkle_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("sinifekle.aspx");
    }
}
