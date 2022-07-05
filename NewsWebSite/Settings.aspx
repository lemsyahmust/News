<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="NewsWebSite.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="BtnS_adduser" runat="server" OnClick="BtnS_adduser_Click" Text="Ajouter User" />
            <asp:Button ID="BtnS_Articles" runat="server" OnClick="BtnS_Articles_Click" Text="Ajouter Article" />
            <asp:Button ID="BtnS_MSJArticl" runat="server" OnClick="BtnS_MSJArticl_Click" Text="M.S.J Article" />
        </div>
    </form>
</body>
</html>
