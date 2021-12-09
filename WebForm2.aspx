﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BuiVietHoang_2019606167.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="form-view">
         <asp:FormView ID="FormView1" runat="server" DataKeyNames="Pid" DataSourceID="SqlDataSource1" DefaultMode="Insert">
        <EditItemTemplate>
            Pid:
            <asp:Label ID="PidLabel1" runat="server" Text='<%# Eval("Pid") %>' />
            <br />
            Categoryid:
            <asp:TextBox ID="CategoryidTextBox" runat="server" Text='<%# Bind("Categoryid") %>' />
            <br />
            ProdName:
            <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
            <br />
            MetaTitle:
            <asp:TextBox ID="MetaTitleTextBox" runat="server" Text='<%# Bind("MetaTitle") %>' />
            <br />
            Description:
            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
            <br />
            ImagePath:
            <asp:TextBox ID="ImagePathTextBox" runat="server" Text='<%# Bind("ImagePath") %>' />
            <br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            Categoryid:
            <asp:TextBox ID="CategoryidTextBox" runat="server" Text='<%# Bind("Categoryid") %>' />
            <br />
            ProdName:
            <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
            <br />
            MetaTitle:
            <asp:TextBox ID="MetaTitleTextBox" runat="server" Text='<%# Bind("MetaTitle") %>' />
            <br />
            Description:
            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
            <br />
            ImagePath:
            <asp:TextBox ID="ImagePathTextBox" runat="server" Text='<%# Bind("ImagePath") %>' />
            <br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            Pid:
            <asp:Label ID="PidLabel" runat="server" Text='<%# Eval("Pid") %>' />
            <br />
            Categoryid:
            <asp:Label ID="CategoryidLabel" runat="server" Text='<%# Bind("Categoryid") %>' />
            <br />
            ProdName:
            <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Bind("ProdName") %>' />
            <br />
            MetaTitle:
            <asp:Label ID="MetaTitleLabel" runat="server" Text='<%# Bind("MetaTitle") %>' />
            <br />
            Description:
            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Bind("Description") %>' />
            <br />
            ImagePath:
            <asp:Label ID="ImagePathLabel" runat="server" Text='<%# Bind("ImagePath") %>' />
            <br />
            Price:
            <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ECartDB2ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [Pid] = @original_Pid AND [Categoryid] = @original_Categoryid AND [ProdName] = @original_ProdName AND (([MetaTitle] = @original_MetaTitle) OR ([MetaTitle] IS NULL AND @original_MetaTitle IS NULL)) AND (([Description] = @original_Description) OR ([Description] IS NULL AND @original_Description IS NULL)) AND [ImagePath] = @original_ImagePath AND [Price] = @original_Price" InsertCommand="INSERT INTO [Product] ([Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (@Categoryid, @ProdName, @MetaTitle, @Description, @ImagePath, @Price)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [Categoryid] = @Categoryid, [ProdName] = @ProdName, [MetaTitle] = @MetaTitle, [Description] = @Description, [ImagePath] = @ImagePath, [Price] = @Price WHERE [Pid] = @original_Pid AND [Categoryid] = @original_Categoryid AND [ProdName] = @original_ProdName AND (([MetaTitle] = @original_MetaTitle) OR ([MetaTitle] IS NULL AND @original_MetaTitle IS NULL)) AND (([Description] = @original_Description) OR ([Description] IS NULL AND @original_Description IS NULL)) AND [ImagePath] = @original_ImagePath AND [Price] = @original_Price">
        <DeleteParameters>
            <asp:Parameter Name="original_Pid" Type="Int32" />
            <asp:Parameter Name="original_Categoryid" Type="Int32" />
            <asp:Parameter Name="original_ProdName" Type="String" />
            <asp:Parameter Name="original_MetaTitle" Type="String" />
            <asp:Parameter Name="original_Description" Type="String" />
            <asp:Parameter Name="original_ImagePath" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Categoryid" Type="Int32" />
            <asp:Parameter Name="ProdName" Type="String" />
            <asp:Parameter Name="MetaTitle" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="ImagePath" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Categoryid" Type="Int32" />
            <asp:Parameter Name="ProdName" Type="String" />
            <asp:Parameter Name="MetaTitle" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="ImagePath" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="original_Pid" Type="Int32" />
            <asp:Parameter Name="original_Categoryid" Type="Int32" />
            <asp:Parameter Name="original_ProdName" Type="String" />
            <asp:Parameter Name="original_MetaTitle" Type="String" />
            <asp:Parameter Name="original_Description" Type="String" />
            <asp:Parameter Name="original_ImagePath" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </div>
   
</asp:Content>
