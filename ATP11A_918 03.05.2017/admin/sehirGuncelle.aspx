<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sehirGuncelle.aspx.cs" Inherits="admin_sehirGuncelle" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 Güncelle: <asp:TextBox ID="TxtSehirGuncelle" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="adGerekliligi" runat="server" ErrorMessage="*" ControlToValidate="TxtSehirGuncelle" SetFocusOnError="true"></asp:RequiredFieldValidator>

    <asp:Button ID="BtnGuncelle" runat="server" Text="Guncelle" 
        onclick="BtnGuncelle_Click" />


</asp:Content>

