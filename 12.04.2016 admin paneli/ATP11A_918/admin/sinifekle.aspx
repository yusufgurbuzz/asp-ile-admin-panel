<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sinifekle.aspx.cs" Inherits="admin_sinifekle" Title="sınıf ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  Sınıf Adı:  <asp:TextBox ID="TxtSinifAdi" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="isimGerekliligi" runat="server" ErrorMessage="*" ControlToValidate="TxtSinifAdi" SetFocusOnError="true"></asp:RequiredFieldValidator>

    <asp:Button ID="BtnSinifKaydet" runat="server" Text="Kaydet" 
        onclick="BtnSinifKaydet_Click" />

</asp:Content>

