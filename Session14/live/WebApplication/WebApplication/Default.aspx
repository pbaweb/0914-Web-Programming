<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .submitBtn {
            border: solid black 1px;
        }
        nav ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="/style/default.css" />
</head>
<body>
    <h1>Default form</h1>
    <div id="alertbox" runat="server"></div>
    <nav>
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <ul>
                    <li id="itemPlaceholder" runat="server"></li>
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>test</li>
            </ItemTemplate>
        </asp:ListView>
    </nav>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <label>
            <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
        </label>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Send" CssClass="submitBtn" OnClick="Button1_Click" />
    </form>
    <form id="form2" name="form2">
        <label><input type="text" name="title" /></label>
        <button class="submitBtn">Send</button>
    </form>
</body>
</html>
