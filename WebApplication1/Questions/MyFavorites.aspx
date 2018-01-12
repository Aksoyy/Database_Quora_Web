<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MyFavorites.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style4 {
            width: 100%;
            border: 2px solid #FF3300;
            background-color: #FFFF00;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Kategorilere Göre Sorular 
    <table>
        <tr>
            <td>Kategori:</td>
            <td>
                <asp:DropDownList ID="dCategoryList" runat="server" Width="206px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btGetCategory" runat="server" Text="Soruları Getir" OnClick="btGetCategory_Click" /></td>
        </tr>
    </table>

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EnableTheming="True" ForeColor="#333333" GridLines="Vertical" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" ShowHeader="False">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                   <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("RESULT") %>'></asp:Literal>                    
                </ItemTemplate>
            </asp:TemplateField> 
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
