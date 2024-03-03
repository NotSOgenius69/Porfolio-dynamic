<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Porfolio_dynamic.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SectionControl" runat="server">
    <div class="loginform">
    <h3>Login Page</h3>
    <input id="adminEmail" runat="server" type="text" placeholder="Enter your email" />
    <input id="adminPass" runat="server" type="password" placeholder="Enter your pass"/>
    <asp:Label ID="HudaiLabel" runat="server" Text="" style="color:white;font-size:1.5rem;"></asp:Label>
    <asp:Button ID="loggingInbtn" runat="server" Text="Login" Style="background-color: #00bbf9; padding: 10px 20px; border-radius: 25px;"
onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="loggingInbtn_Click" />
   </div>

    <asp:Button ID="backbtn" runat="server" Text="Back" Style="background-color: #00bbf9; margin-top:10px; padding: 5px 10px; border-radius: 20px;"
onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="backbtn_Click" />
</asp:Content>
