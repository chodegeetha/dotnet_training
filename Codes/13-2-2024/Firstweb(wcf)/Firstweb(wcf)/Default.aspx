<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Firstweb_wcf_._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div style="width:50%">
       <div style="background-color:Blue; color:White;font-size:large;font-weight:bolder">My Calculator using wcf</div>
         <br />
          <div style="background-color:gray; color:Blue;font-size:medium;font-weight:bolder">
              Number 1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              Number2: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           </div>
         <br />
         <div>
             <asp:Button ID="Button1" runat="server" Text="Add" BorderColor="#CC3300" 
                 Font-Bold="True" ForeColor="#333399" OnClick="Button1_Click" />
              <asp:Button ID="Button2" runat="server" Text="SUB" BorderColor="#CC3300" 
          Font-Bold="True" ForeColor="#333399" OnClick="Button2_Click" />
              <asp:Button ID="Button3" runat="server" Text="Mul" BorderColor="#CC3300" 
     Font-Bold="True" ForeColor="#333399" OnClick="Button3_Click" />
              <asp:Button ID="Button4" runat="server" Text="Div" BorderColor="#CC3300" 
     Font-Bold="True" ForeColor="#333399" OnClick="Button4_Click" />
         </div>
         <br />
          <div style="background-color:gray; color:Blue;font-size:medium;font-weight:bolder">
              Result:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              </div>
         </div>
</asp:Content>
