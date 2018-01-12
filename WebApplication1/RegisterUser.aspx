<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Yeni Kayıt</h2>
    <p>
        <asp:Literal ID="Information" runat="server">Yeni kayıt olmak için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
    <table id="tblme">
        <tr>
            <td style="width: 200px">Adı:</td>
            <td>
                <asp:TextBox ID="teName" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="width: 200px">İkinci Adı:</td>
            <td>
                <asp:TextBox ID="teLastName" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">Soyadı:</td>
            <td>
                <asp:TextBox ID="teSurname" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Uyruk:</td>
            <td>
                <asp:TextBox ID="teNationality" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>E-posta:</td>
            <td>
                <asp:TextBox ID="teUsername" runat="server" Width="200px" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Şifre:</td>
            <td>
                <asp:TextBox ID="tePassword" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btOk" runat="server" Text="Kaydet"  Width="207px" OnClick="btOk_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
