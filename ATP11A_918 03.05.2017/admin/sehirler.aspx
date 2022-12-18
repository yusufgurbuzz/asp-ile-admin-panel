<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sehirler.aspx.cs" Inherits="admin_sehirler" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<script type="text/javascript">

    function silinsinMi(sId, sAd) 
    {

        if (confirm(sAd + 'isimli sehiri silmek Ýster misiniz ?'))
        {
            location.href = "sehirler.aspx?silId=" + sId;    
    
    }

}




</script>








</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<ul>


    <asp:Repeater ID="RptSehir" runat="server">
   <ItemTemplate>




<li>

<a href="javascript:silinsinMi(<%# Eval ("sehirId") %>,'<%# Eval ("sehirAd") %>')">



 <img src="images/sil.png"  title="sil"/> </a>                                 

<a href="sehirGuncelle.aspx?sId=<%# Eval("sehirId") %>">              
<img src="images/guncelle.png" title="güncelle" />  </a> 



  <%# Eval("sehirAd") %>              </li>
  

      


</ItemTemplate>
 </asp:Repeater>
</ul>

 <asp:Button ID="BtnSehirEkle" runat="server" Text="Þehir Ekle" 
        onclick="BtnSehirEkle_Click" />












</asp:Content>

