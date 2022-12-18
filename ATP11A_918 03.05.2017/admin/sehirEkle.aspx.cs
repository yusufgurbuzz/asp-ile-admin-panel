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

public partial class admin_sehirEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSkaydet_Click(object sender, EventArgs e)
    {
        ATP11A_918Entities db = new ATP11A_918Entities();
        sehirler sh = db.sehirler.Where(s => s.sehirAd == TxtSehirEkle.Text).FirstOrDefault();

        if (sh == null)
        {
            sehirler s = new sehirler();
            s.sehirAd = TxtSehirEkle.Text;
            db.AddTosehirler(s);
            db.SaveChanges();
            TxtSehirEkle.Text = "";
            TxtSehirEkle.Focus();

        }


        else
        { 
        
        Response.Write("<script>alert('Bu kayıt zaten var');</script>");
        
        }
        
        
        
    }
}
