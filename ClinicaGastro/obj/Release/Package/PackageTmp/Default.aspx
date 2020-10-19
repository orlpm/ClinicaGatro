<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Default.aspx.vb" Inherits="ClinicaGastro._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    
    <style type="text/css">
        .auto-style1
        {
            width: 204px;
            height: 45px;
        }
        .auto-style2
        {
            width: 204px;
            height: 196px;
        }
        .auto-style3
        {
            height: 196px;
        }
        .auto-style4
        {
            width: 204px;
            height: 116px;
        }
        .auto-style5
        {
            height: 116px;
        }
        .auto-style6
        {
            margin-top:32px;
            margin-bottom:32px;
            display:block;
            margin-left:auto;
            margin-right:auto;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContextual" runat="server">
    <table style="width:100%;">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3">
                    <asp:Image ID="Image1" ImageUrl="/Images/logo.jpg" runat="server" Height="244px" style="margin-right: 211px" Width="647px" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    &nbsp;
</asp:Content>
