<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="NewsWebSite.Articles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 59px;
        }
        .auto-style2 {
            width: 529px;
        }
        .auto-style3 {
            width: 487px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Title</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtbxtitle" runat="server" Width="492px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Details</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtbxdetails" runat="server" Height="205px" TextMode="MultiLine" Width="491px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Photo</td>
                    <td class="auto-style2">
                        <input id="File1" class="auto-style3" type="file" runat ="Server"/></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnAjtArticles" runat="server" OnClick="btnAjtArticles_Click" Text="Ajouter Article" Width="375px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
