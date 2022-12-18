<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="oteller.aspx.cs" Inherits="admin_oteller" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<script type="text/javascript">

    function silinsinMi(oId, oAd) 
    {

        if (confirm(oAd + 'isimli oteli silmek İster misiniz ?'))
        {
            location.href = "oteller.aspx?silmekId=" + oId;    
    
    }

}




</script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul>

    <asp:Repeater ID="RptOteller" runat="server">
<ItemTemplate>  


<li>

<a href="javascript:silinsinMi(<%# Eval ("otelId") %>,'<%# Eval ("otelAd") %>')">
<img src="images/sil.png"  title="sil"/> </a>




<a href="otelGuncelle.aspx?oId=<%# Eval("otelId") %> ">
<img src="images/guncelle.png" title="güncelle" /></a>

<%# Eval("otelAd") %>     </li>

</ItemTemplate>  
</asp:Repeater>

</ul>


    <asp:Button ID="BtnOtelEkle" runat="server" Text="EKLE" 
        onclick="BtnOtelEkle_Click" />






</asp:Content>

