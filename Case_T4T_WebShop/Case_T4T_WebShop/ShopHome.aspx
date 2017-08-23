<%@ Page Title="" Language="C#" MasterPageFile="~/Shop.Master" AutoEventWireup="true" CodeBehind="ShopHome.aspx.cs" Inherits="Case_T4T_WebShop.ShopHome" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
     <asp:Label ID="Label1" runat="server"></asp:Label>
     <asp:Panel ID="Panel1" runat="server"></asp:Panel>

    </asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <asp:Label ID="Naam" runat="server" Text="Naam :       "></asp:Label>
&nbsp;<asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="AchterNaam" runat="server" Text="Achternaam : "></asp:Label>
    <asp:TextBox ID="AchterNBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Mail" runat="server" Text="E-Mail adress : "></asp:Label>
    <asp:TextBox ID="MailBox" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="confirmOrderLbl" runat="server" Text="Do you want to order ?" Visible="False"></asp:Label>
    <br />
    <asp:Button ID="ConfirmBtn" runat="server" Text="Confirm" Visible="False" OnClick="Confirm_Click" />
    <asp:Button ID="EditBtn" runat="server" Text="Edit" Visible="False" Width="85px" OnClick="EditBtn_Click" />
    <br />
    <asp:Button ID="OrderBtn" runat="server" Text="Order" Width="85px" OnClick="OrderBtn_Click" />
    </asp:Content>



