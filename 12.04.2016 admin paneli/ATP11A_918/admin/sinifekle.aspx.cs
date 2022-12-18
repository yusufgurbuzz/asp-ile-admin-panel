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

public partial class admin_sinifekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSinifKaydet_Click(object sender, EventArgs e)
    {
        okulEntities db = new okulEntities();

        siniflar sn = db.siniflar.Where(t => t.sinifAdi == TxtSinifAdi.Text).FirstOrDefault();
        if (sn == null)
        {
            siniflar s = new siniflar();
            s.sinifAdi = TxtSinifAdi.Text;
            db.AddTosiniflar(s);
            db.SaveChanges();
            TxtSinifAdi.Text = "";
            TxtSinifAdi.Focus();
        }
        else
        {

            Response.Write("<script>alert('Bu Kayıt Zaten Var !');</script>");
        
        }



    }
}
