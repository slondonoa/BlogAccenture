<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="AccentureBLog.UI.Forms.Posts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Posts</h4>
    <hr>
    <asp:GridView ID="gvPosts" runat="server"></asp:GridView>

</asp:Content>
