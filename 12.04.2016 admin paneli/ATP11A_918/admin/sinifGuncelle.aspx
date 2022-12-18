<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="sinifGuncelle.aspx.cs" Inherits="admin_sinifGuncelle" Title="Güncelleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

Sınıf Adı :<asp:TextBox ID="TxtGuncelle" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator ID="guncellemeGerekliligi" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="TxtGuncelle" SetFocusOnError="true"></asp:RequiredFieldValidator>


<asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" onclick="BtnGuncelle_Click" />

</asp:Content>

