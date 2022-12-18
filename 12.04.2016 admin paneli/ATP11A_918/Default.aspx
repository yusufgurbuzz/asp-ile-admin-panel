<%@ Page Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Kullanıcı Arayüzü" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<h1>Burası Kullanıcı Arayüzü </h1>

    <asp:Repeater ID="RptOgrenci" runat="server">
   <ItemTemplate>
           


<p style="margin-left:10px;" ><%# Eval("ogrenciAdi") %>   <%# Eval("ogrenciSoyadi") %> </p>



</ItemTemplate>
 </asp:Repeater>



</asp:Content>

