<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="test.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    <title>Test</title>
    <style>
        tbody {
            display: flex;
            gap: 120px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="masv" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" style="margin-right: 1200px">
        <ItemTemplate>
            masv:
            <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
            <br />
            hoten:
            <asp:Label ID="hotenLabel" runat="server" Text='<%# Eval("hoten") %>' />
            <br />
            dienthoai:
            <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Eval("dienthoai") %>' />
            <br />
            que:
            <asp:Label ID="queLabel" runat="server" Text='<%# Eval("que") %>' />
            <br />
            malop:
            <asp:Label ID="malopLabel" runat="server" Text='<%# Eval("malop") %>' />
            <br />
            anh:
            <asp:Label ID="anhLabel" runat="server" Text='<%# Eval("anh") %>' />
            <asp:Image ID="Image1" ImageUrl='<%# Eval("anh") %>' runat="server" />
            <br />
<br />
        </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" SelectCommand="SELECT * FROM [sinhvien]"></asp:SqlDataSource>
</asp:Content>
