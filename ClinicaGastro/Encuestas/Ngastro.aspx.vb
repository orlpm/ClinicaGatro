Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

Partial Public Class Ngastro
    Inherits System.Web.UI.Page

    Protected Overrides Sub OnInit(e As EventArgs)
        CargarControles()

    End Sub

    Protected Sub CargarControles()
        Dim i As Integer = 1
        For i = 1 To Session("contador") Step 1

            Dim cpas As cPasajeros = CType(LoadControl("cPasajeros.ascx"), cPasajeros)
            cpas.ID = "cPas" & i
            cpas.AsignarID(i)
            divPassenger.Controls.Add(cpas)


        Next

    End Sub
    'Shared arregloTextBoxs1, arregloTextBoxs2, arregloTextBoxs3, arregloTextBoxs4 As TextBox()
    'Shared arregloCombos As DropDownList()
    'Shared contadorControles As Integer
    'Protected Overrides Sub OnInit(e As EventArgs)
    '    'CargarControles()
    'End Sub

    ''Protected Sub CargarControles()
    ''    Dim i As Integer = 0

    ''    For i = 1 To 99

    ''        Dim cpas As cPasajeros = DirectCast(LoadControl("cPasajeros.ascx"), cPasajeros)
    ''        cpas.ID = "cPas" + i

    ''        cpas.AsignarID(i)



    ''        divPassenger.Controls.Add(cpas)
    ''    Next
    ''End Sub

    ' ''#Region "Events"
    ' ''    Public n As Integer = 0
    ' ''    Protected Sub Page_Load(sender As Object, e As EventArgs)
    ' ''        If Not IsPostBack Then
    ' ''            Session("conta") = 1
    ' ''            ViewState("count") = Session("conta")
    ' ''        End If
    ' ''    End Sub

    ' ''    Protected Overrides Sub OnLoad(e As EventArgs)
    ' ''        MyBase.OnLoad(e)
    ' ''        generateDynamicControls()
    ' ''    End Sub

    ' ''    Protected Sub btnRead_Click(sender As Object, e As EventArgs)

    ' ''        Select Case Convert.ToString(ViewState("control")).ToLower()
    ' ''            Case "textbox"
    ' ''                Dim txt As TextBox = DirectCast(PlaceHolder1.FindControl("TextBox" & (n)), TextBox)
    ' ''                lblValue.Text = txt.Text & n
    ' ''                Exit Select
    ' ''            Case "dropdownlist"
    ' ''                Dim ddl As DropDownList = DirectCast(PlaceHolder1.FindControl("DropDownList"), DropDownList)
    ' ''                lblValue.Text = ddl.SelectedValue & n
    ' ''                Exit Select
    ' ''            Case "radiobuttonlist"
    ' ''                Dim value As String = ""
    ' ''                Dim RadioButtonList As RadioButtonList = DirectCast(PlaceHolder1.FindControl("RadioButtonList"), RadioButtonList)
    ' ''                For Each item As ListItem In RadioButtonList.Items
    ' ''                    If item.Selected Then
    ' ''                        value = value + item.Text & Convert.ToString("<br>")
    ' ''                    End If
    ' ''                Next
    ' ''                lblValue.Text = value & n
    ' ''                Exit Select
    ' ''            Case "checkboxlist"
    ' ''                Dim val As String = ""
    ' ''                Dim CheckBoxList As CheckBoxList = DirectCast(PlaceHolder1.FindControl("CheckBoxList"), CheckBoxList)
    ' ''                For Each item As ListItem In CheckBoxList.Items
    ' ''                    If item.Selected Then
    ' ''                        val = val + item.Text & Convert.ToString("<br>")
    ' ''                    End If
    ' ''                Next
    ' ''                lblValue.Text = val & n
    ' ''                Exit Select
    ' ''            Case Else
    ' ''                Exit Select
    ' ''        End Select
    ' ''    End Sub

    ' ''    Public Sub ddl_SelectedIndexChanged(sender As Object, e As EventArgs)
    ' ''        Dim ddl = DirectCast(sender, DropDownList)
    ' ''        If ddl.SelectedIndex > 0 Then
    ' ''            lblValue.Text = ddl.SelectedValue
    ' ''        End If
    ' ''    End Sub

    ' ''#End Region

    ' ''#Region "Dynamic Methods"

    ' ''    Public Sub generateDynamicControls()
    ' ''        If ddlDynamicControlList.SelectedIndex > 0 Then
    ' ''            lblValue.Text = String.Empty
    ' ''            Select Case ddlDynamicControlList.SelectedValue.ToString().ToLower()

    ' ''                Case "textbox"
    ' ''                    ViewState("control") = "textbox"
    ' ''                    Session("conta") += 1
    ' ''                    n = Session("conta")
    ' ''                    Try
    ' ''                        For i = 1 To n
    ' ''                            createDynamicTextBox("TextBox")
    ' ''                        Next
    ' ''                    Catch ex As Exception
    ' ''                        MsgBox(ex.Message)
    ' ''                    End Try


    ' ''                    Exit Select
    ' ''                Case "dropdownlist"
    ' ''                    ViewState("control") = "dropdownlist"
    ' ''                    createDynamicDropDownList("DropDownList")
    ' ''                    Exit Select
    ' ''                Case "radiobuttonlist"
    ' ''                    ViewState("control") = "radiobuttonlist"
    ' ''                    createDynamicRadioButtonList("RadioButtonList")
    ' ''                    Exit Select
    ' ''                Case "checkboxlist"
    ' ''                    ViewState("control") = "checkboxlist"
    ' ''                    createDynamicCheckBoxList("CheckBoxList")
    ' ''                    Exit Select
    ' ''                Case Else
    ' ''                    Exit Select
    ' ''            End Select
    ' ''        End If
    ' ''    End Sub

    ' ''    Public Sub createDynamicTextBox(_TextBoxId As String)
    ' ''        Dim tr As New HtmlGenericControl("tr")
    ' ''        Dim td1 As New HtmlGenericControl("td")

    ' ''        Dim lbl As New Label()
    ' ''        lbl.ID = "lbl" + _TextBoxId.Replace(" ", "").ToLower()
    ' ''        lbl.Text = _TextBoxId
    ' ''        td1.Controls.Add(lbl)
    ' ''        tr.Controls.Add(td1)

    ' ''        Dim td2 As New HtmlGenericControl("td")
    ' ''        Dim txtBox As New TextBox()
    ' ''        txtBox.ID = _TextBoxId.Replace(" ", "").ToLower() & n
    ' ''        txtBox.Text = txtBox.ID
    ' ''        td2.Controls.Add(txtBox)
    ' ''        tr.Controls.Add(td2)
    ' ''        PlaceHolder1.Controls.Add(tr)
    ' ''    End Sub

    ' ''    Public Sub createDynamicDropDownList(_ddlId As String)
    ' ''        Dim tr As New HtmlGenericControl("tr")
    ' ''        Dim td1 As New HtmlGenericControl("td")

    ' ''        Dim lbl As New Label()
    ' ''        lbl.ID = "ddl" + _ddlId.Replace(" ", "").ToLower()
    ' ''        lbl.Text = _ddlId
    ' ''        td1.Controls.Add(lbl)
    ' ''        tr.Controls.Add(td1)

    ' ''        Dim td2 As New HtmlGenericControl("td")
    ' ''        Dim ddl As New DropDownList()
    ' ''        ddl.ID = _ddlId.Replace(" ", "").ToLower()
    ' ''        AddHandler ddl.SelectedIndexChanged, AddressOf ddl_SelectedIndexChanged
    ' ''        ddl.AutoPostBack = True
    ' ''        ddl.Items.Add(New ListItem("-- Select --", "-- Select --"))
    ' ''        ddl.Items.Add(New ListItem("DropDown Option One", "Option One"))
    ' ''        ddl.Items.Add(New ListItem("DropDown Option Two", "Option Two"))
    ' ''        ddl.Items.Add(New ListItem("DropDown Option Three", "Option Three"))
    ' ''        td2.Controls.Add(ddl)
    ' ''        tr.Controls.Add(td2)
    ' ''        PlaceHolder1.Controls.Add(tr)
    ' ''    End Sub

    ' ''    Public Sub createDynamicRadioButtonList(_RadioButtonListID As String)
    ' ''        Dim tr As New HtmlGenericControl("tr")
    ' ''        Dim td1 As New HtmlGenericControl("td")

    ' ''        Dim lbl As New Label()
    ' ''        lbl.ID = "lbl" + _RadioButtonListID.Replace(" ", "").ToLower()
    ' ''        lbl.Text = _RadioButtonListID
    ' ''        td1.Controls.Add(lbl)
    ' ''        tr.Controls.Add(td1)

    ' ''        Dim td2 As New HtmlGenericControl("td")
    ' ''        Dim RadioButtonList As New RadioButtonList()
    ' ''        RadioButtonList.ID = _RadioButtonListID.Replace(" ", "").ToLower()
    ' ''        RadioButtonList.Items.Add(New ListItem("Radio Option One", "Option One"))
    ' ''        RadioButtonList.Items.Add(New ListItem("Radio Option Two", "Option Two"))
    ' ''        RadioButtonList.Items.Add(New ListItem("Radio Option Three", "Option Three"))
    ' ''        td2.Controls.Add(RadioButtonList)
    ' ''        tr.Controls.Add(td2)
    ' ''        PlaceHolder1.Controls.Add(tr)
    ' ''    End Sub

    ' ''    Public Sub createDynamicCheckBoxList(_CheckBoxListID As String)
    ' ''        Dim tr As New HtmlGenericControl("tr")
    ' ''        Dim td1 As New HtmlGenericControl("td")

    ' ''        Dim lbl As New Label()
    ' ''        lbl.ID = "Check Box List" + _CheckBoxListID.Replace(" ", "").ToLower()
    ' ''        lbl.Text = _CheckBoxListID
    ' ''        td1.Controls.Add(lbl)
    ' ''        tr.Controls.Add(td1)

    ' ''        Dim td2 As New HtmlGenericControl("td")
    ' ''        Dim CheckBoxList As New CheckBoxList()
    ' ''        CheckBoxList.ID = _CheckBoxListID.Replace(" ", "").ToLower()
    ' ''        CheckBoxList.Items.Add(New ListItem("CheckBox Option One", "Option One"))
    ' ''        CheckBoxList.Items.Add(New ListItem("CheckBox Option Two", "Option Two"))
    ' ''        CheckBoxList.Items.Add(New ListItem("CheckBox Option Three", "Option Three"))
    ' ''        td2.Controls.Add(CheckBoxList)
    ' ''        tr.Controls.Add(td2)
    ' ''        PlaceHolder1.Controls.Add(tr)
    ' ''    End Sub

    ' ''#End Region

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim dt As New DataTable

    '    Try
    '        Dim numeroRegistro As Integer = contadorControles
    '        Dim nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4 As New TextBox()
    '        nuevoTxt1.ID = "txtlugar" & numeroRegistro.ToString()
    '        nuevoTxt1.Width = 100
    '        nuevoTxt1.AutoPostBack = True
    '        nuevoTxt2.ID = "txthorario" & numeroRegistro.ToString()
    '        nuevoTxt2.Width = 150
    '        nuevoTxt2.AutoPostBack = True
    '        nuevoTxt3.ID = "txtalimycant" & numeroRegistro.ToString()
    '        nuevoTxt3.Width = 150
    '        nuevoTxt3.AutoPostBack = True
    '        nuevoTxt4.ID = "txtvalcalor" & numeroRegistro.ToString()
    '        nuevoTxt4.Width = 100
    '        nuevoTxt4.AutoPostBack = True
    '        arregloTextBoxs1(numeroRegistro) = nuevoTxt1
    '        arregloTextBoxs2(numeroRegistro) = nuevoTxt2
    '        arregloTextBoxs3(numeroRegistro) = nuevoTxt3
    '        arregloTextBoxs4(numeroRegistro) = nuevoTxt4
    '        Dim nuevoCmb As New DropDownList()
    '        nuevoCmb.ID = "cmb" & numeroRegistro.ToString()
    '        nuevoCmb.Items.Add("---Seleccione el Plazo---")
    '        nuevoCmb.Items.Add("Desayuno")
    '        nuevoCmb.Items.Add("Comida")
    '        nuevoCmb.Items.Add("Cena")
    '        nuevoCmb.Items.Add("Colación")
    '        nuevoCmb.SelectedIndex = 0
    '        nuevoCmb.AutoPostBack = True
    '        arregloCombos(numeroRegistro) = nuevoCmb
    '        AgregarControles(nuevoCmb, nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4)
    '        MsgBox(nuevoTxt1.ID)
    '        contadorControles += 1

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    '    Protected Sub AgregarControles(cmb As DropDownList, Txt As TextBox, txt2 As TextBox, txt3 As TextBox, txt4 As TextBox)
    '    divPassenger.Controls.Add(cmb)
    '    divPassenger.Controls.Add(New LiteralControl(" "))
    '    divPassenger.Controls.Add(Txt)
    '    divPassenger.Controls.Add(New LiteralControl(" "))
    '    divPassenger.Controls.Add(txt2)
    '    divPassenger.Controls.Add(New LiteralControl(" "))
    '    divPassenger.Controls.Add(txt3)
    '    divPassenger.Controls.Add(New LiteralControl(" "))
    '    divPassenger.Controls.Add(txt4)
    '    divPassenger.Controls.Add(New LiteralControl(" "))


    'End Sub

    'Protected Sub Page_Load(sender As Object, e As EventArgs)
    '    ReDim arregloTextBoxs1(0 To 100 - 1)
    '    ReDim arregloTextBoxs2(0 To 100 - 1)
    '    ReDim arregloTextBoxs3(0 To 100 - 1)
    '    ReDim arregloTextBoxs4(0 To 100 - 1)
    '    ReDim arregloCombos(0 To 100 - 1)


    '    contadorControles = 0
    '    If Button1.OnClientClick = True Then
    '        Try
    '            Dim numeroRegistro As Integer = contadorControles
    '            Dim nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4 As New TextBox()
    '            nuevoTxt1.ID = "txtlugar" & numeroRegistro.ToString()
    '            nuevoTxt1.Width = 100
    '            nuevoTxt1.AutoPostBack = True
    '            nuevoTxt2.ID = "txthorario" & numeroRegistro.ToString()
    '            nuevoTxt2.Width = 150
    '            nuevoTxt2.AutoPostBack = True
    '            nuevoTxt3.ID = "txtalimycant" & numeroRegistro.ToString()
    '            nuevoTxt3.Width = 150
    '            nuevoTxt3.AutoPostBack = True
    '            nuevoTxt4.ID = "txtvalcalor" & numeroRegistro.ToString()
    '            nuevoTxt4.Width = 100
    '            nuevoTxt4.AutoPostBack = True
    '            arregloTextBoxs1(numeroRegistro) = nuevoTxt1
    '            arregloTextBoxs2(numeroRegistro) = nuevoTxt2
    '            arregloTextBoxs3(numeroRegistro) = nuevoTxt3
    '            arregloTextBoxs4(numeroRegistro) = nuevoTxt4
    '            Dim nuevoCmb As New DropDownList()
    '            nuevoCmb.ID = "cmb" & numeroRegistro.ToString()
    '            nuevoCmb.Items.Add("---Seleccione el Plazo---")
    '            nuevoCmb.Items.Add("Desayuno")
    '            nuevoCmb.Items.Add("Comida")
    '            nuevoCmb.Items.Add("Cena")
    '            nuevoCmb.Items.Add("Colación")
    '            nuevoCmb.SelectedIndex = 0
    '            nuevoCmb.AutoPostBack = True
    '            arregloCombos(numeroRegistro) = nuevoCmb
    '            AgregarControles(nuevoCmb, nuevoTxt1, nuevoTxt2, nuevoTxt3, nuevoTxt4)
    '            MsgBox(nuevoTxt1.ID)
    '            contadorControles += 1

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    '    Try
    '        For i As Integer = 0 To contadorControles - 1
    '            AgregarControles(arregloCombos(i), arregloTextBoxs1(i), arregloTextBoxs2(i), arregloTextBoxs3(i), arregloTextBoxs4(i))
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(Session("contador")) Then
            Session("contador") = 1
        Else
            Session("contador") += 1
        End If

        
        
    End Sub

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    Session("contador") = 1
        'End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = TextBox2.Text
        'Dim c As Control = CType(FindControl("cPas" & i), Control)
        'Dim tb As TextBox = CType(c.FindControl("tbNombrePas" & i), TextBox)

        Dim c As Control = CType(divPassenger.FindControl("cPas" & i), Control)
        Dim tb As TextBox = CType(c.FindControl("tbNombrePas" & i), TextBox)
        TextBox1.Text = tb.Text

    End Sub
End Class
