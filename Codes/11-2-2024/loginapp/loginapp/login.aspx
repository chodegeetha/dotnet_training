<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="loginapp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="vh-100"  >
  <div class="container py-5 h-100">
    <div class="row d-flex align-items-center justify-content-center h-100">
      <div class="col-md-8 col-lg-7 col-xl-6">
        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg"
          class="img-fluid" alt="Phone image">
      </div>
      <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
        <form id="form1" runat="server">
          <!-- Email input -->
          <div class="form-outline mb-4">
             <label>UserName</label>
             <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="UserName"></asp:TextBox> 
          </div>

          <!-- Password input -->
          <div class="form-outline mb-4">
            <label>Password</label>
            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
          </div>
            

          <div class="d-flex justify-content-around align-items-center mb-4">
            <!-- Checkbox -->
             
            <div class="form-check">
               <asp:CheckBox ID="CheckBox2" runat="server" />
              <label>Remember me</label>
            </div>
            <a href="#!">Forgot password?</a>
          </div>

          <!-- Submit button -->
         <asp:Button class="btn btn-success  text-xl-center  btn-lg  btn-block " ID="Button1" runat="server" Text="Login" OnClick="Button3_Click" />


        </form>
      </div>
    </div>
  </div>
</section>
</asp:Content>
       
