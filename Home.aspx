<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Porfolio_dynamic.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contactDetails" runat="server">
    
    <div class="contactdetails">
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
           <h2>Write a <span>message</span></h2>
            <input ID="nameId" type="text" runat="server" placeholder="Your Name" class="input"/>
            <input id="emailId" type="text" runat="server" placeholder="Your Email" class="input"/>
            <textarea id="messageId" runat="server" cols="30" rows="10" placeholder="Your Message" style="height: 25vh;
                                                                                           resize: none;
                                                                                           border-radius: 20px;
                                                                                           padding-left: 25px;
                                                                                           padding-top: 25px;"></textarea>
            <asp:Button ID="submitbtn" runat="server" Text="Submit" CssClass="submitButton"
                onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
                onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="submitBtn_Click"/>
            <asp:Label ID="HudaiLabel" runat="server" Text="" style="color:white;font-size:1.5rem;"></asp:Label>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="login" runat="server">
        <li><asp:Button ID="loginbtn" runat="server" Text="Login" CssClass="submitButton"
onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" onClick="loginbtn_Click"/></li>
</asp:Content>
