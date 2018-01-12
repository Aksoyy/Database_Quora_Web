<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Profil Güncelleme</h2>
    <p>
        <asp:Literal ID="Information" runat="server">Profilinizi güncellemek için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
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
            <td>Ülke Adı:</td>
            <td>
                <asp:TextBox ID="teNationaltyTypeCd" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btOk" runat="server" Text="Kaydet" Width="207px" OnClick="btOk_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
