<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="NeinteenFlower.View.Member.ManageMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>List Member</h1>

    <br />

    <asp:Repeater ID="RepeaterMember" runat="server">
        <ItemTemplate>
            <h2>Name: <%# Eval("MemberName") %></h2>
            <p>Date of Birth: <%# Eval("MemberDOB") %></p>
            <p>Gender: <%# Eval("MemberGender") %></p>
            <p>Address: <%# Eval("MemberAddress") %></p>
            <p>Phone: <%# Eval("MemberPhone") %></p>
            <p>Email: <%# Eval("MemberEmail") %></p>

            <asp:Button CommandArgument='<%# Eval("MemberId") %>' OnCommand="BtnEditMember_Command" ID="BtnEditMember" runat="server" Text="Edit" />
                
            <hr />
        </ItemTemplate>
    </asp:Repeater>

    <asp:Button ID="BtnAddNewMember" OnClick="BtnAddNewMember_Click" runat="server" Text="Add new Member" />
</asp:Content>
