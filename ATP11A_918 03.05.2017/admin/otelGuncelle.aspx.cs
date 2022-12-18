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

public partial class admin_otelGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ATP11A_918Entities db = new ATP11A_918Entities();

        if (IsPostBack) return;
        DrpSehir.DataSource = db.sehirler;
        DrpSehir.DataTextField = "sehirAd";
        DrpSehir.DataValueField = "sehirId";
        DrpSehir.DataBind();

          int deger = Convert.ToInt32(Request.QueryString["oId"]);

          oteller y = db.oteller.Where(c => c.otelId == deger).FirstOrDefault();


        TxtOtelGuncelleAd.Text = db.oteller.Where(s => s.otelId == deger).FirstOrDefault().otelAd;
        TxtOtelGuncelleAcıklama.Text = db.oteller.Where(s => s.otelId == deger).FirstOrDefault().aciklama;
        DrpSehir.SelectedValue = y.sehirler.sehirId.ToString();


    }
    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
int secilenOtel = Convert.ToInt32(DrpSehir.SelectedItem.Value);


        int deger = Convert.ToInt32(Request.QueryString["oId"]);
       ATP11A_918Entities db = new ATP11A_918Entities();
        oteller x = db.oteller.Where(c => c.otelId == deger).FirstOrDefault();
        x.otelAd = TxtOtelGuncelleAd.Text;
        x.aciklama = TxtOtelGuncelleAcıklama.Text;
        x.sehirler = db.sehirler.Where(k => k.sehirId == secilenOtel).FirstOrDefault();

        if (FileUpload1.HasFile)
        {
            int uzunluk = FileUpload1.PostedFile.ContentLength;
            string tipi = FileUpload1.PostedFile.ContentType;

            if (uzunluk < 1000000 && (tipi == "image/gif" || tipi == "image/jpg" || tipi == "image/jpeg"))
            {

                if (x.otelResim == null)
                {
                    Guid dosyaAdi = Guid.NewGuid();
                    string uzantisi = Path.GetExtension(FileUpload1.FileName);
                    
                    x.otelResim = dosyaAdi.ToString() + uzantisi;
                }

                FileUpload1.SaveAs(Server.MapPath("../otelFoto/")+x.otelResim);
            }
            else
            {
                x.otelResim = null;
            }
        }

        else
        {
            x.otelResim = null;
        }








  

        db.SaveChanges();
       
        Response.Redirect("oteller.aspx");
    }





    }

