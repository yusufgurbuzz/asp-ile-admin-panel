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

public partial class admin_sehirGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        int deger = Convert.ToInt32(Request.QueryString["sId"]);
        ATP11A_918Entities db = new ATP11A_918Entities();
        TxtSehirGuncelle.Text = db.sehirler.Where(s=>s.sehirId==deger).FirstOrDefault().sehirAd;




    }
    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {

        int deger = Convert.ToInt32(Request.QueryString["sId"]);
        ATP11A_918Entities db = new ATP11A_918Entities();
        sehirler x = db.sehirler.Where(shr => shr.sehirAd == TxtSehirGuncelle.Text).FirstOrDefault();
        if (x == null)
        {
            sehirler s = db.sehirler.Where(sh => sh.sehirId == deger).FirstOrDefault();

            s.sehirAd = TxtSehirGuncelle.Text;
            db.SaveChanges();
            Response.Redirect("sehirler.aspx");
        }

        else
        {
            Response.Write("<script>alert('Bu kayıt zaten var');</script>");
        }




    }
}
