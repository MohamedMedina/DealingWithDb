<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelectData.aspx.cs" Inherits="DealingWithDb.SelectData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Product List :
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Search By Id" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search By Column" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search By Name Start" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
