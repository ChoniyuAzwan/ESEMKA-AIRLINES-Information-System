Imports System.Windows.Forms

Public Class frmCheckIn

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnChekIn_Click(sender As Object, e As EventArgs) Handles btnChekIn.Click
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from booking where "
            End With
            CloDB()
        Catch ex As Exception

        End Try
    End Sub
End Class
