<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sehirEkle.aspx.cs" Inherits="admin_sehirEkle" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:TextBox ID="TxtSehirEkle" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="adGerekliligi" runat="server" ErrorMessage="*" ControlToValidate="TxtSehirEkle" SetFocusOnError="true"></asp:RequiredFieldValidator>
    
    <asp:Button ID="BtnSkaydet" runat="server" Text="Kaydet" 
        onclick="BtnSkaydet_Click" />

</asp:Content>

