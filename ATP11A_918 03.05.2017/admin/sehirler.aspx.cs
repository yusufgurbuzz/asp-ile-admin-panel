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
using ATP11A_918Model;

public partial class admin_sehirler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ATP11A_918Entities db = new ATP11A_918Entities();

        int deger = Convert.ToInt32(Request.QueryString["silId"]);
        if (deger != 0)
        {

            oteller ot = db.oteller.Where(t => t.sehirler.sehirId == deger).FirstOrDefault();

            if (ot != null)
            {
                Response.Write("<script>alert('Bu sehirde Otel var');</script>");

            }

            else
            {
                sehirler xyz = db.sehirler.Where(s => s.sehirId == deger).FirstOrDefault();
                db.DeleteObject(xyz);
                db.SaveChanges();

            }

        }

        RptSehir.DataSource = db.sehirler;
        RptSehir.DataBind();
    }
    protected void BtnSehirEkle_Click(object sender, EventArgs e)
    {
        Response.Redirect("sehirEkle.aspx");  

    }
}
