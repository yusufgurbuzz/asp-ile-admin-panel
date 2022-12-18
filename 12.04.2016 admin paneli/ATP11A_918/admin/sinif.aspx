<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sinif.aspx.cs" Inherits="admin_sinif" Title="Class Panel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<ul id="sinif">

    <asp:Repeater ID="RptSiniflar" runat="server">
    <ItemTemplate>
    
    <li>
    
    <a href="#"><img src="images/sil.png" height="16" width="16" alt="sil" /></a>
    <a href="sinifGuncelle.aspx?sId=<%# Eval("sinifId") %>"><img src="images/guncelle.png" height="16" width="16" alt="güncelle" /></a>
    
    <%# Eval("sinifAdi") %>
    
    </li>
    
    
    
    </ItemTemplate>
    </asp:Repeater>
</ul>

    <asp:Button ID="BtnYeniSinifEkle" runat="server" Text="Yeni Sinif Ekle" 
        onclick="BtnYeniSinifEkle_Click" />





</asp:Content>

