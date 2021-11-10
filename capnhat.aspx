<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="capnhat.aspx.cs" Inherits="test.capnhat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Cập nhật
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="masv" DataSourceID="SqlDataSource1" DefaultMode="Edit">
        <EditItemTemplate>
            masv:
            <asp:Label ID="masvLabel1" runat="server" Text='<%# Eval("masv") %>' />
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
            <asp:TextBox ID="anhTextBox" runat="server" Text='<%# Bind("anh") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
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
            <asp:TextBox ID="anhTextBox" runat="server" Text='<%# Bind("anh") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            masv:
            <asp:Label ID="masvLabel" runat="server" Text='<%# Eval("masv") %>' />
            <br />
            hoten:
            <asp:Label ID="hotenLabel" runat="server" Text='<%# Bind("hoten") %>' />
            <br />
            dienthoai:
            <asp:Label ID="dienthoaiLabel" runat="server" Text='<%# Bind("dienthoai") %>' />
            <br />
            que:
            <asp:Label ID="queLabel" runat="server" Text='<%# Bind("que") %>' />
            <br />
            malop:
            <asp:Label ID="malopLabel" runat="server" Text='<%# Bind("malop") %>' />
            <br />
            anh:
            <asp:Label ID="anhLabel" runat="server" Text='<%# Bind("anh") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:SinhVienConnectionString %>" 
        DeleteCommand="DELETE FROM [sinhvien] WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([que] = @original_que) OR ([que] IS NULL AND @original_que IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))" 
        InsertCommand="INSERT INTO [sinhvien] ([masv], [hoten], [dienthoai], [que], [malop], [anh]) VALUES (@masv, @hoten, @dienthoai, @que, @malop, @anh)" OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [sinhvien] WHERE [masv] = @masv" 
        UpdateCommand="UPDATE [sinhvien] SET [hoten] = @hoten, [dienthoai] = @dienthoai, [que] = @que, [malop] = @malop, [anh] = @anh WHERE [masv] = @original_masv AND (([hoten] = @original_hoten) OR ([hoten] IS NULL AND @original_hoten IS NULL)) AND (([dienthoai] = @original_dienthoai) OR ([dienthoai] IS NULL AND @original_dienthoai IS NULL)) AND (([que] = @original_que) OR ([que] IS NULL AND @original_que IS NULL)) AND (([malop] = @original_malop) OR ([malop] IS NULL AND @original_malop IS NULL)) AND (([anh] = @original_anh) OR ([anh] IS NULL AND @original_anh IS NULL))">
        
        <SelectParameters>
            <asp:QueryStringParameter Name="masv" Type="String" QueryStringField="masv1"/>
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="original_masv" Type="String" />
            <asp:Parameter Name="original_hoten" Type="String" />
            <asp:Parameter Name="original_dienthoai" Type="String" />
            <asp:Parameter Name="original_que" Type="String" />
            <asp:Parameter Name="original_malop" Type="String" />
            <asp:Parameter Name="original_anh" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="masv" Type="String" />
            <asp:Parameter Name="hoten" Type="String" />
            <asp:Parameter Name="dienthoai" Type="String" />
            <asp:Parameter Name="que" Type="String" />
            <asp:Parameter Name="malop" Type="String" />
            <asp:Parameter Name="anh" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="hoten" Type="String" />
            <asp:Parameter Name="dienthoai" Type="String" />
            <asp:Parameter Name="que" Type="String" />
            <asp:Parameter Name="malop" Type="String" />
            <asp:Parameter Name="anh" Type="String" />
            <asp:Parameter Name="original_masv" Type="String" />
            <asp:Parameter Name="original_hoten" Type="String" />
            <asp:Parameter Name="original_dienthoai" Type="String" />
            <asp:Parameter Name="original_que" Type="String" />
            <asp:Parameter Name="original_malop" Type="String" />
            <asp:Parameter Name="original_anh" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
