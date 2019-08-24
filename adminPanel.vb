Public Class adminPanel

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub adminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StudentTableAdapter.Fill(Me.StudentsDataSet.student)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class