<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="themv2.aspx.cs" Inherits="test.themv2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    <title>Thêm sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="masv" DataSourceID="SqlDataSource1" OnPageIndexChanging="FormView1_PageIndexChanging" OnItemInserting="FormView1_ItemInserting">
            <InsertItemTemplate>
                masv:
                <asp:TextBox ID="masvTextBox" runat="server" Text='<%# Bind("masv") %>' />
                <br />
                hoten:
                <asp:TextBox ID="hotenTextBox" runat="server" Text='<%# Bind("hoten") %>' />
                <br />
                dienthoai:
                <asp:TextBox ID="dienthoaiTextBox" runat="server" Text='<%# Bind("dienthoai") %>' />
                <br />
                que:
                <asp:TextBox ID="queTextBox" runat="server" Text='<%# Bind("que") %>' />
                <br />
                malop:
                <asp:TextBox ID="malopTextBox" runat="server" Text='<%# Bind("malop") %>' />
                <br />
                anh:
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Thêm sv" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([que] = @original_que) OR ([que] IS NULL AND @original_que IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))" InsertCommand="INSERT INTO [sinhvien] ([masv], [hoten], [dienthoai], [que], [malop], [anh]) VALUES (@masv, @hoten, @dienthoai, @que, @malop, @anh)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [sinhvien]" UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [dienthoai] = @dienthoai, [que] = @que, [malop] = @malop, [anh] = @anh WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([que] = @original_que) OR ([que] IS NULL AND @original_que IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))">
            
            <InsertParameters>
                <asp:Parameter Name="masv" Type="String" />
                <asp:Parameter Name="hoten" Type="String" />
                <asp:Parameter Name="dienthoai" Type="String" />
                <asp:Parameter Name="que" Type="String" />
                <asp:Parameter Name="malop" Type="String" />
                <asp:Parameter Name="anh" Type="String" />
            </InsertParameters>
       
        </asp:SqlDataSource>
    </form>
</asp:Content>
