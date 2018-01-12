<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<style type="text/css">
    .auto-style1 {
    }
    .auto-style2 {
        width: 118px;
    }
    .auto-style3 {
        height: 23px;
    }
</style>
<form action="Login.aspx" method="post">
    <%if (Session["SessionKey"] != null)
        {%>
    <span>Hosgeldiniz </span><asp:Label Id="laName" runat="server" Text="[name]"></asp:Label>
    <br />
    <asp:LinkButton ID="btnProfileUpdate" runat="server" OnClick="btnProfileUpdate_Click">Profil Güncelle</asp:LinkButton>
    <br />
    <asp:LinkButton ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click">Şifre Değiştir</asp:LinkButton>
    <br />
    <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click">Çıkış</asp:LinkButton>
    <%}
        else
        {%>
    <table>
        <tr>
            <td class="auto-style1" colspan="2">Kullanıcı Adı</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:TextBox ID="teUserName" runat="server" Width="250px" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">Şifre</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:TextBox ID="tePassword" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
            <tr>
                <td>
                    &nbsp;<asp:Button ID="btRegisterUser" runat="server" Text="Yeni Kayıt" OnClick="btRegisterUser_Click" Width="127px" />
                </td>
                <td style="text-align: right;" class="auto-style2">
                    &nbsp;<asp:Button ID="btLogin" runat="server" Text="Login" Width="113px" OnClick="btLogin_Click" />
                </td>
            </tr>
        </tr>
    </table>
    <% }
    %>
</form>
