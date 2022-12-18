<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="otelGuncelle.aspx.cs" Inherits="admin_otelGuncelle" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

Otel adı güncelle:<asp:TextBox ID="TxtOtelGuncelleAd" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="adGerekliligi" runat="server" ErrorMessage="*" ControlToValidate="TxtOtelGuncelleAd" SetFocusOnError="true"></asp:RequiredFieldValidator>

<br />
Otel Resmi güncelle:<asp:FileUpload ID="FileUpload1" runat="server" />

<br />
otel Adı güncelle:<asp:DropDownList ID="DrpSehir" runat="server">    </asp:DropDownList>

<br />

Açıklama:<asp:TextBox ID="TxtOtelGuncelleAcıklama" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TxtOtelGuncelleAcıklama" SetFocusOnError="true"></asp:RequiredFieldValidator>

<asp:Button ID="BtnGuncelle" runat="server" Text="Guncelle" onclick="BtnGuncelle_Click" />


</asp:Content>

