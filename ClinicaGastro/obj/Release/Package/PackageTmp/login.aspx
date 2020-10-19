<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="ClinicaGastro.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
        }
        .auto-style2
        {
            width: 115px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 58%;">
            <tr>
                <td class="auto-style2">Usuario</td>
                <td>
                    <asp:TextBox ID="usu" runat="server" Width="294px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="pass" TextMode="Password"  runat="server" Width="294px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Ingresar" Width="152px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
