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
using System.IO;

public partial class admin_oteller : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ATP11A_918Entities db = new ATP11A_918Entities();
        int deger = Convert.ToInt32(Request.QueryString["silmekId"]);

        if (deger == 0)
        {

            RptOteller.DataSource = db.oteller;
            RptOteller.DataBind();

        }
        else
        {
            string FotoAdi = db.oteller.Where(o => o.otelId == deger).FirstOrDefault().otelResim;

            if(FotoAdi!=null)

            {
            File.Delete(Server.MapPath("~") + "/otelFoto/"+FotoAdi);
             }
            oteller ot = db.oteller.Where(x => x.otelId == deger).FirstOrDefault();
            db.DeleteObject(ot);
            db.SaveChanges();

            Response.Redirect("oteller.aspx");
        }

        



    }
    protected void BtnOtelEkle_Click(object sender, EventArgs e)
    {
        Response.Redirect("otelEkle.aspx");  
    }
}
