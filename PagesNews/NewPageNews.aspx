<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_PagesNews.Master" AutoEventWireup="true" CodeBehind="NewPageNews.aspx.cs" Inherits="PagesNews.NewPageNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="art" runat="server">


    </div>

    <hr/>

     <div id="comments" runat="server">

     </div>
     <hr/>
         <table style="width:100%;">
             <tr>
                 <td style="width: 84px">Name</td>
                 <td>
                     <asp:TextBox ID="txtbxname" runat="server" Width="560px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 84px">Commentaires</td>
                 <td>
                     <asp:TextBox ID="txtbxcommet" runat="server" Height="165px" TextMode="MultiLine" Width="568px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 84px">&nbsp;</td>
                 <td>
                     <asp:Button ID="btnAjouter_cm" runat="server" OnClick="btnAjouter_cm_Click" Text="Ajout Commentaire" Width="309px" />
                 </td>
             </tr>
         </table>


    
</asp:Content>
