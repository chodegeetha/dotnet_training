<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="loginapp.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class ="con" >
    <form id="form1" runat="server" >
        <div class="container" id="signup">
            <h2 style="text-align:center">Sign Up</h2>
            <div class="form-group">
                <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" required></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" required></asp:TextBox>
            </div>
            <div style="margin-top:15px">
             <asp:Button class="btn btn-success  text-xl-center  btn-lg  btn-block " ID="Button1" runat="server" Text="SignUp" OnClick="Btnsignup_Click" />
            </div>

        </div>
    </form>
 </div>

</asp:Content>
