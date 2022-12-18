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

public partial class admin_sinifGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        int deger = Convert.ToInt32(Request.QueryString["sId"]);
        okulEntities db = new okulEntities();
        TxtGuncelle.Text = db.siniflar.Where(s => s.sinifId == deger).FirstOrDefault().sinifAdi;
    }
    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        int deger = Convert.ToInt32(Request.QueryString["sId"]);
        okulEntities db = new okulEntities();

        siniflar x = db.siniflar.Where(t => t.sinifAdi == TxtGuncelle.Text).FirstOrDefault();
        if (x == null)
        {

            siniflar sn = db.siniflar.Where(s => s.sinifId == deger).FirstOrDefault();
            sn.sinifAdi = TxtGuncelle.Text;
            db.SaveChanges();
            Response.Redirect("sinif.aspx");
        }

        else
        {
            Response.Write("<script>alert('Bu Kayıt Zaten Var !');</script>");

        }


    }
}
