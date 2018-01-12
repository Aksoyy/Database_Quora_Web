<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QuestionForm.aspx.cs" Inherits="WebApplication1.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #example1 {
            border: 2px solid gray;
            padding: 10px;
            border-radius: 25px;
        }

        #example2 {
            border: 2px solid green;
            padding: 10px;
            border-radius: 50px 20px;
        }

        #example3 {
            border: 2px solid red;
            padding: 10px;
            border-radius: 25px;
        }

        div.scroll {
            width: 100%;
            height: 600px;
            overflow: scroll;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="scroll">
        <div id="example1">
            <asp:Label ID="laTitle" runat="server" Text=""></asp:Label>
            <hr />
            <p>
                <asp:Label ID="laQuestionDesc" runat="server" Text=""></asp:Label>
            </p>

            <p>
                <asp:Label ID="laQuestionCreationDate" runat="server" Style="text-align: left; float: right;" Font-Size="Smaller"></asp:Label>
                <asp:Label ID="laQuestionNameSurname" runat="server" Style="text-align: right; float: left;" Font-Size="Smaller"></asp:Label>
            </p>
            <br />
        </div>
        <br />
        <asp:Repeater ID="myRepeater" runat="server">
            <ItemTemplate>
                <div id="example2">
                    <p>
                        <%# Eval("Description") %>
                    </p>
                    <p>
                        <asp:Label ID="laAnswerCreationDate" runat="server" Style="text-align: left; float: right;" Font-Size="Smaller" Text='<%# Eval("CreationDate") %>'></asp:Label>
                        <asp:Label ID="laAnswerNameSurname" runat="server" Style="text-align: right; float: left;" Font-Size="Smaller" Text='<%# Eval("NameSurname") %>'></asp:Label>
                    </p>
                    <br />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <div id="example3">
            <p>
                <textarea id="teDescription" runat="server" cols="65" rows="4" ></textarea>
                <asp:Button ID="btAnswer" runat="server" OnClick="btAnswer_Click" Text="Cevap Yaz" />
            </p>
        </div>
    </div>

</asp:Content>
