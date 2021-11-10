<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="danhsach.aspx.cs" Inherits="test.danhsach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    
    <title>
        Danh sách sinh viên
    </title>
    

    <style>
        img {
            max-width: 150px;
        }


        tbody {
            display:flex;
            flex-wrap: wrap;
            justify-content: space-between;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataKeyField="masv" DataSourceID="SqlDataSource1" ForeColor="#333333">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <ItemTemplate>
            Mã sinh viên:
            <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
            <br />
            Họ tên:
            <asp:Label ID="hotenLabel" runat="server" Text='<%# Eval("hoten") %>' />
            <br />
            Điện thoại:
            <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Eval("dienthoai") %>' />
            <br />
            Quê:
            <asp:Label ID="queLabel" runat="server" Text='<%# Eval("que") %>' />
            <br />
            Mã Lớp:
            <asp:Label ID="malopLabel" runat="server" Text='<%# Eval("malop") %>' />
            <br />
            <asp:Image ID="anh" runat="server" ImageUrl='<%# "~/img/" + Eval("anh") %>'/>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("masv", "xoa.aspx?masv={0}") %>'>Xoá</asp:HyperLink>
<br />
        </ItemTemplate>
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" SelectCommand="SELECT * FROM [sinhvien]"></asp:SqlDataSource>
    </asp:Content>
