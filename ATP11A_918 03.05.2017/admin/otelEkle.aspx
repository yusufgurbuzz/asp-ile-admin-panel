<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="otelEkle.aspx.cs" Inherits="admin_otelEkle" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

Otel adı ekle:<asp:TextBox ID="TxtOtelEkleAd" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator ID="adGerekliligi" runat="server" ErrorMessage="*" ControlToValidate="TxtOtelEkleAd" SetFocusOnError="true"></asp:RequiredFieldValidator>
<br />
Otel Resmi ekle:<asp:FileUpload ID="FileUpload1" runat="server" />

<br />
otel Adı ekle:<asp:DropDownList ID="DrpSehir" runat="server">    </asp:DropDownList>

<br />

Açıklama:<asp:TextBox ID="TxtOtelEkleAcıklama" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TxtOtelEkleAcıklama" SetFocusOnError="true"></asp:RequiredFieldValidator>



<asp:Button ID="BtnOtelKaydet" runat="server" Text="kaydet" onclick="BtnOtelKaydet_Click" />

</asp:Content>

