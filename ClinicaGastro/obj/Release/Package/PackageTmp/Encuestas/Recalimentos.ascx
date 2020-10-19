<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Recalimentos.ascx.vb" Inherits="ClinicaGastro.Recalimentos" %>
<table style="width:100%;">
    <tr>
        <td>
<asp:DropDownList ID="ddlTiempCom" runat="server">
    <asp:ListItem>--Seleccionar--</asp:ListItem>
    <asp:ListItem>Desayuno</asp:ListItem>
    <asp:ListItem>Comida</asp:ListItem>
    <asp:ListItem>Cena</asp:ListItem>
    <asp:ListItem>Colación</asp:ListItem>
</asp:DropDownList>
        </td>
        <td>
<asp:TextBox ID="tbLugar" runat="server"></asp:TextBox>
        </td>
        <td>
<asp:TextBox ID="tbHr" runat="server"></asp:TextBox>
        </td>
        <td>
<asp:TextBox ID="tbAlim" runat="server"></asp:TextBox>

        </td>
        <td>
<asp:TextBox ID="tbVCal" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
        </td>
    </tr>
</table>
<script src="Scripts/jquery-3.2.0.js"></script>
<script>


    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode

        if (charCode == 46) {
            var inputValue = $("#inputfield").val()
            if (inputValue.indexOf('.') < 1) {
                return true;
            }
            return false;
        }
        if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    }

    </script>
