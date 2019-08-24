Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "customer" And txtPassword.Text = "customer" Then
            MsgBox("Welcome to Hotel Food Nation !!!!!")
            Dim a As New mainInterface
            a.Show()
            Me.Hide()

        ElseIf txtUser.Text = "admin" And txtPassword.Text = "123" Then
            MsgBox("Customer list will be going to shown.!!!!")
            Dim a As New adminPanel
            a.Show()
            Me.Hide()

        Else
            MsgBox("Check Username and Password")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPassword.Text = ""
        txtUser.Text = ""
    End Sub
End Class
