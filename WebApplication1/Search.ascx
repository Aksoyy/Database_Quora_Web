<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="WebApplication1.Search" %>
<table id="tblme">
    <tr>
        <td>Dil:</td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="dLanguageList" runat="server" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Kategori:</td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="dCategoryList" runat="server" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Aranacak Kelime</td>
    </tr>
    <tr>

        <td>
            <asp:TextBox ID="teWord" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr><td>
        <asp:Button ID="btSearch" runat="server" Text="Ara" Width="200px" OnClick="btSearch_Click" /></td></tr>
</table>
