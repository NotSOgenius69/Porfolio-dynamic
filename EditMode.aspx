<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="EditMode.aspx.cs" Inherits="Porfolio_dynamic.contactEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contactDetails" runat="server">
    
    <div class="contactdetails">
        <asp:Button ID="contactEditbtn" runat="server" Text="Edit" CssClass="btn-submit" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
            onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
            onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="contactEditbtn_Click" />
    <div class="infobox">
        <i class="fa-solid fa-phone"></i>
        <div class="contactText">
          <h2>Call Me On</h2>
          <asp:Label ID="PhoneNoLabel" runat="server" Text="" style="color:white; font-size: 1.5rem;"></asp:Label>
         </div>
    </div>
     <div class="infobox">
        <i class="fa-solid fa-envelope"></i>
        <div class="contactText">
         <h2>Email Me At</h2>
         <asp:Label ID="EmailLabel" runat="server" Text="" style="color:white; font-size: 1.5rem;"></asp:Label>
        </div>
     </div>
     <div class="infobox">
        <i class="fa-solid fa-location-dot"></i>
        <div class="contactText">
          <h2>Address</h2>
          <asp:Label ID="AddressLabel" runat="server" Text="" style="color:white; font-size: 1.5rem;"></asp:Label>
        </div>
     </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Msgbox" runat="server">
    <div class="message-form">
         <asp:Label ID="MsgLabel" runat="server" Text="" style="color:white;
                                                                font-size:2rem;"></asp:Label>
         <asp:Button ID="Showbtn" runat="server" Text="Show" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
                onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
                onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="Showbtn_Click"/>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="login" runat="server">
        <li><asp:Button ID="logoutbtn" runat="server" Text="Logout" CssClass="submitButton"
onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" onClick="logoutbtn_Click"/></li>
</asp:Content>
