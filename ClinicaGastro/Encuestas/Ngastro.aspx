<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Encuestas/Encuestas.master" CodeBehind="Ngastro.aspx.vb" Inherits="ClinicaGastro.Ngastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" ></asp:TextBox>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <%--<div>

        <table>
            <tr>
                <td colspan="2" style="background-color: #46B525;">
                    <b>Manage Dynamic Controls</b>
                </td>
            </tr>
            <tr>
                <td>
                    Select Dynamic Controls :
                </td>
                <td>
                    <asp:DropDownList ID="ddlDynamicControlList" runat="server" AutoPostBack="true">
                        <asp:ListItem Text="-- Select --" Value="-- Select --"></asp:ListItem>
                        <asp:ListItem Text="TextBox" Value="TextBox"></asp:ListItem>
                        <asp:ListItem Text="DropDownList" Value="DropDownList"></asp:ListItem>
                        <asp:ListItem Text="RadioButtonList" Value="RadioButtonList"></asp:ListItem>
                        <asp:ListItem Text="CheckBoxList" Value="CheckBoxList"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-color: #EEEEEE;">
                    <table>
                        <tr>
                            <td>
                                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblValue" runat="server" Text="" Style="color: Red;"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click" />
                </td>
            </tr>
        </table>--%>
    </div>
            <div id="divPassenger" runat="server">

                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <asp:Label ID="lblcontador" runat="server" Text="Label"></asp:Label>

            </div>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
