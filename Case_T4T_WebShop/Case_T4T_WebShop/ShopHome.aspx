<%@ Page Title="" Language="C#" MasterPageFile="~/Shop.Master" AutoEventWireup="true" CodeBehind="ShopHome.aspx.cs" Inherits="Case_T4T_WebShop.ShopHome" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>

    </asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <asp:Label ID="Naam" runat="server" Text="Naam :       "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="AchterNaam" runat="server" Text="Achternaam : "></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Mail" runat="server" Text="E-Mail adress : "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="confirmOrderLbl" runat="server" Text="Are you sure ?"></asp:Label>
    <br />
    <asp:TextBox ID="Name"
    <asp:Button ID="ConfirmBtn" runat="server" Text="Confirm" Visible="False" />
    <asp:Button ID="CancelBtn" runat="server" Text="Cancel" Visible="False" Width="85px" />
    <br />
    <asp:Button ID="Order" runat="server" Text="Order" Width="85px" />
    </asp:Content>



