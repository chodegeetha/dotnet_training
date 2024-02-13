<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Studentpractice.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server" >
    <div>
        <h1>Students Info</h1>
        </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Student Name" Style="margin-right:50px;"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
             <div>
                 <asp:Label ID="Label2" runat="server" Text="Student Age" Style="margin-right:60px;"></asp:Label>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
             <div>
                 <asp:Label ID="Label3" runat="server" Text="Student Marks" Style="margin-right:50px;"></asp:Label>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
             <div>
                 <asp:Label ID="Label4" runat="server" Text="Student dept" Style="margin-right:60px;"></asp:Label>
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

              </div>
            <div style="margin:15px">
                  <asp:Button class="btn btn-success  text-xl-center  btn-lg  btn-block " ID="Button1" runat="server" Text="Submit" OnClick="Btnsubmit_Click" />
           </div>
           
            


            <div>
                <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="StudentId" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
                    <Columns>
                        <asp:BoundField DataField="StudentId" HeaderText="StudentId" ReadOnly="True" />
                        <asp:BoundField DataField="StudentName" HeaderText="StudentName" />
                        <asp:BoundField DataField="StudentAge" HeaderText="StudentAge" />
                        <asp:BoundField DataField="StudentMarks" HeaderText="StudentMarks" />
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
                    
            </div>

       </form>
    </div>
</form>

</asp:Content>
