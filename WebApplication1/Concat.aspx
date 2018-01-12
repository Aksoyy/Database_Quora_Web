<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Concat.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <title>İletişim</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>İletişim Formu</h2>
    <p>
        <asp:Literal ID="Information" runat="server">Soru ve görüşleriniz için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
    <table id="tblme">
        <tr>
            <td style="width: 200px">Adı:</td>
            <td>
                <asp:TextBox ID="txtFullName" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Soyadı</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>E-posta:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Konu:</td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mesaj:</td>
            <td>
                <asp:TextBox ID="txtMessage" runat="server" Height="80px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Gönder" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
