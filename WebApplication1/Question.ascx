<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Question.ascx.cs" Inherits="WebApplication1.Question" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<table>
    <tr>
        <td>
            <asp:LinkButton ID="btnTheNewests" runat="server" OnClick="btnTheNewests_Click">En Yeniler</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="btnMostAnswered" runat="server" OnClick="btnMostAnswered_Click">En Çok Cevaplanan Soru</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="btnMyQuestions" runat="server" OnClick="btnMyQuestions_Click">Benim Sorularım</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="btnMyFavorites" runat="server" OnClick="btnMyFavorites_Click">Kategorilere Göre Sorular</asp:LinkButton></td>
    </tr>
        <tr>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLanguageQuestion_Click">Dile Göre Sorular</asp:LinkButton></td>
    </tr>
</table>


