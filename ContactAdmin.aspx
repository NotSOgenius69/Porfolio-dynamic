<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.Master" AutoEventWireup="true" CodeBehind="ContactAdmin.aspx.cs" Inherits="Porfolio_dynamic.ContactAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SectionControl" runat="server">
    <h3>Contact admin</h3>
     <div class="contactform">
         <div class="infodivs">
              <h4>Phone:</h4>
              <asp:TextBox ID="PhoneId" runat="server" type="text" placeholder= "Enter your phone no"/>
             <asp:Button ID="updatebtn1" runat="server" Text="Update" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
                 onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
                 onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="updatebtn1_Click" />
             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>

        <div class="infodivs">
             <h4>Email:</h4>
             <asp:TextBox ID="EmailId" runat="server" type="text" placeholder= "Enter your email"/>
            <asp:Button ID="updatebtn2" runat="server" Text="Update" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
                onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
                onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="updatebtn2_Click" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>

        <div class="infodivs">
           <h4>Address:</h4>
           <asp:TextBox ID="AddressId" runat="server" type="text" placeholder= "Enter your address"/>
            <asp:Button ID="updatebtn3" runat="server" Text="Update" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
                onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
                onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="updatebtn3_Click" />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
     
     </div>
    <asp:Button ID="backbtn" runat="server" Text="Back" Style="background-color: #00bbf9; padding: 10px 25px; border-radius: 25px;"
    onmouseover="this.style.backgroundColor='#222';this.style.border='1px #fff solid';this.style.color='#fff';"
    onmouseout="this.style.backgroundColor='#00bbf9';this.style.border='none';this.style.color='#000';" OnClick="backbtn_Click" />
</asp:Content>
