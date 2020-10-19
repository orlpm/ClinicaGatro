Imports System.Configuration
Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim encuentra As MenuItem = Menu1.FindItem("Login")
        Dim encuentra1 As MenuItem = Menu1.FindItem("Logout")
        Dim encuentra2 As MenuItem = Menu1.FindItem("Medicos")
        Dim encuentra3 As MenuItem = Menu1.FindItem("Administrativo/Usuarios")
        Dim parent As MenuItem = Menu1.FindItem("Pacientes")
        Dim s As MenuItem = Menu1.FindItem("Pacientes/Varios")
        Dim encuentra4 As MenuItem = Menu1.FindItem("Administrativo")
        Dim encuentra6 As MenuItem = Menu1.FindItem("Administrativo/Control de Citas")
        Dim encuentra7 As MenuItem = Menu1.FindItem("Administrativo/Control de Pagos")
        Dim encuentra5 As MenuItem = Menu1.FindItem("Pacientes/Consulta")
        Dim encuentra8 As MenuItem = Menu1.FindItem("Encuestas/Nutrición")
        Dim encuentra9 As MenuItem = Menu1.FindItem("Encuestas/Psico Gastro")
        Dim encuentra10 As MenuItem = Menu1.FindItem("Encuestas/Gastroquirúrgica")
        Dim encuentra11 As MenuItem = Menu1.FindItem("Encuestas")
        If s IsNot Nothing Then
            parent.ChildItems.Remove(s)
        End If
        'usuario general
        If Session("nivel") = 0 Then
            If encuentra1 IsNot Nothing Then
                Menu1.Items.Remove(encuentra1)
                Menu1.Items.Remove(encuentra2)
                Menu1.Items.Remove(parent)
                Menu1.Items.Remove(encuentra4)
                If encuentra11 IsNot Nothing Then
                    encuentra11.ChildItems.Remove(encuentra8)
                    encuentra11.ChildItems.Remove(encuentra9)
                    encuentra11.ChildItems.Remove(encuentra10)
                End If
                If encuentra5 IsNot Nothing Then
                    parent.ChildItems.Remove(encuentra5)
                End If
            End If
            'administrador()
        ElseIf Session("nivel") = 1 Then
            If encuentra IsNot Nothing Then
                Menu1.Items.Remove(encuentra)
            End If
            ' medico()
        ElseIf Session("nivel") = 2 Then
            If encuentra IsNot Nothing Then
                Menu1.Items.Remove(encuentra)
                If encuentra3 IsNot Nothing Then
                    encuentra4.ChildItems.Remove(encuentra3)
                    encuentra4.ChildItems.Remove(encuentra6)
                    encuentra4.ChildItems.Remove(encuentra7)
                End If

            End If
            'administrativo
        ElseIf Session("nivel") = 3 Then
            If encuentra IsNot Nothing Then
                Menu1.Items.Remove(encuentra)
                Menu1.Items.Remove(encuentra2)
                Menu1.Items.Remove(parent)
                If encuentra5 IsNot Nothing Then
                    parent.ChildItems.Remove(encuentra5)
                End If
                If encuentra3 IsNot Nothing Then
                    encuentra4.ChildItems.Remove(encuentra3)
                End If
            End If
            'paciente
        ElseIf Session("nivel") = 4 Then
            If encuentra4 IsNot Nothing Then
                Menu1.Items.Remove(encuentra4)
            End If
            If encuentra5 IsNot Nothing Then
                parent.ChildItems.Remove(encuentra5)
            End If
            If encuentra IsNot Nothing Then
                Menu1.Items.Remove(encuentra)
                Menu1.Items.Remove(encuentra2)
            End If
        End If




    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        If e.Item.Text.Equals("Logout") Then
            Session("nivel") = 0
            Response.Redirect("~/default.aspx")
        End If
    End Sub

    
End Class