<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Maestro.aspx.cs" Inherits="VideoJuegos.Web.Maestro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvVideoJuegos" runat="server">
        </asp:GridView>
    </asp:Panel>

</asp:Content>
