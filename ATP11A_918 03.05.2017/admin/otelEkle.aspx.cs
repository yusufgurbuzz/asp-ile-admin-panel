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

public partial class admin_otelEkle : System.Web.UI.Page
{
    ATP11A_918Entities db = new ATP11A_918Entities();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack) return;

        DrpSehir.DataSource = db.sehirler;
        DrpSehir.DataTextField = "sehirAd";
        DrpSehir.DataValueField = "sehirId";
        DrpSehir.DataBind();




    }
    protected void BtnOtelKaydet_Click(object sender, EventArgs e)
    {
        int secilenTur = Convert.ToInt32(DrpSehir.SelectedItem.Value);
        oteller otel = new oteller();
        otel.otelAd = TxtOtelEkleAd.Text;
        otel.aciklama = TxtOtelEkleAcıklama.Text;
        otel.sehirler = db.sehirler.Where(c => c.sehirId == secilenTur).FirstOrDefault();

        if (FileUpload1.HasFile)
        {
            int uzunluk = FileUpload1.PostedFile.ContentLength;
            string tipi = FileUpload1.PostedFile.ContentType;

            if (uzunluk < 1000000 && (tipi == "image/gif" || tipi == "image/jpg" || tipi == "image/jpeg"))
            {

                Guid dosyaAdi = Guid.NewGuid();
                string uzantisi = Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("../otelFoto/") + dosyaAdi.ToString() + uzantisi);
                otel.otelResim = dosyaAdi.ToString() + uzantisi;


            }
            else
            {
                otel.otelResim = null;
            }
        }

        else
        {
            otel.otelResim = null;
        }


        db.AddTooteller(otel);
        db.SaveChanges();
        TxtOtelEkleAd.Text = "";
        TxtOtelEkleAcıklama.Text = "";
        DrpSehir.SelectedIndex = 0;
        Response.Write("<script>alert(' başarılı şekilde oldu');</script>");

    }
    
}
