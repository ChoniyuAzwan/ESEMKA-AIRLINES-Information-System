Imports System.Windows.Forms

Public Class frmDepartureConfirmation

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from booking where ticketnumber = '" & TextBox6.Text & "' and departureconfirmation <> ''"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try
        Try
            If TextBox6.Text = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("The passanger has been confirmation")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "update booking set departureconfirmation = 'Confirm' where ticketnumber = '" & TextBox6.Text & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Successfully confirm departure")
                TextBox6.Clear()
            Else
                Att("The ticket number is not finded")
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed confirm departure")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Q = MsgBox("Are you sure wanna quit from this form ?", VE + VY, T)
        If Q = vbYes Then Me.Close()
    End Sub

    Private Sub frmDepartureConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Clear()
        TextBox6.Focus()
    End Sub
End Class
