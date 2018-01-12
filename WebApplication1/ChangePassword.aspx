<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication1.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Şifre Güncelleme</h2>
    <p>
        <asp:Literal ID="Information" runat="server">Profilinizi güncellemek için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
    <table id="tblme">
        <tr>
            <td style="width: 200px">Eski Şifre:</td>
            <td>
                <asp:TextBox ID="tePassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">Yeni Şifre:</td>
            <td>
                <asp:TextBox ID="tePassword1" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="width: 200px">Yeni Şifre Tekrar:</td>
            <td>
                <asp:TextBox ID="tePassword2" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
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
