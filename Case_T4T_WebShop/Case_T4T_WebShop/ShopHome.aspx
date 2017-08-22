<%@ Page Title="" Language="C#" MasterPageFile="~/Shop.Master" AutoEventWireup="true" CodeBehind="ShopHome.aspx.cs" Inherits="Case_T4T_WebShop.ShopHome" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat ="server"></asp:Label>
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    <asp:Button ID="ConfirmBtn" runat="server" Text="Confirm" Visible="False" />
    <asp:Button ID="CancelBtn" runat="server" Text="Cancel" Visible="False" Width="85px" />
    <br />
    <asp:Button ID="Order" runat="server" Text="Order" Width="85px" />
    </asp:Content>


