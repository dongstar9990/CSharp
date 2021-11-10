<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="them.aspx.cs" Inherits="test.them" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    <title>
         Thêm sinh viên
    </title>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="masv" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnPageIndexChanging="FormView1_PageIndexChanging" OnItemInserting="FormView1_ItemInserting">
        
        <InsertItemTemplate>
            Mã sing viên:
            <asp:TextBox ID="masvTextBox" runat="server" Text='<%# Bind("masv") %>' />
            <br />
            Họ tên:
            <asp:TextBox ID="hotenTextBox" runat="server" Text='<%# Bind("hoten") %>' />
            <br />
            Điện thoại:
            <asp:TextBox ID="dienthoaiTextBox" runat="server" Text='<%# Bind("dienthoai") %>' />
            <br />
            Quê:
            <asp:TextBox ID="queTextBox" runat="server" Text='<%# Bind("que") %>' />
            <br />
            Mã lớp:
            <asp:TextBox ID="malopTextBox" runat="server" Text='<%# Bind("malop") %>' />
            <br />
            Ảnh:
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" OnClientClick="return confirm('Chac chan chu')"/>
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @masv" InsertCommand="INSERT INTO [sinhvien] ([masv], [hoten], [dienthoai], [que], [malop], [anh]) VALUES (@masv, @hoten, @dienthoai, @que, @malop, @anh)" SelectCommand="SELECT * FROM [sinhvien]" UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [dienthoai] = @dienthoai, [que] = @que, [malop] = @malop, [anh] = @anh WHERE [masv] = @masv">
        <InsertParameters>
            <asp:Parameter Name="masv" Type="String" />
            <asp:Parameter Name="hoten" Type="String" />
            <asp:Parameter Name="dienthoai" Type="String" />
            <asp:Parameter Name="que" Type="String" />
            <asp:Parameter Name="malop" Type="String" />
            <asp:Parameter Name="anh" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </asp:Content>
