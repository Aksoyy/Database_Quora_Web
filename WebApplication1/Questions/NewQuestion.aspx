<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewQuestion.aspx.cs" Inherits="WebApplication1.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Soru-Yaz Formu</h2>
    <p>
        <asp:Literal ID="Information" runat="server">Sorunuz için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
    <table id="tblme">
        <tr>
            <td>Dil:</td>
            <td>
                <asp:DropDownList ID="dLanguageList" runat="server" Width="206px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Kategori:</td>
            <td>
                <asp:DropDownList ID="dCategoryList" runat="server" Width="206px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Başlık:</td>
            <td>
                <asp:TextBox ID="teTitle" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Detay:</td>
            <td>
                <asp:TextBox ID="teDescription" runat="server" Height="80px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Kaydet" OnClick="btnSubmit_Click" Width="202px" />
            </td>
        </tr>
    </table>
</asp:Content>
