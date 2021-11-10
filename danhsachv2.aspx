<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="danhsachv2.aspx.cs" Inherits="test.danhsachv2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    <title>Test</title>
    <style>
        tbody {
            display: flex;
            gap: 120px;
            flex-wrap: wrap;
        }

        img {
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <form id="form1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="masv" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            Mã sinh viên:
            <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
            <br />
            Họ :
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
            <asp:Image ID="Image1" ImageUrl='<%# "~/img/" + Eval("anh") %>' runat="server" />
            <br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("masv", "xoav2.aspx?masv={0}") %>' runat="server">Xoá sinh viên</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# Eval("masv", "capnhatv2.aspx?masv={0}") %>' runat="server">Cập nhật sinh viên</asp:HyperLink>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" SelectCommand="SELECT * FROM [sinhvien]"></asp:SqlDataSource>
</form>
</asp:Content>
