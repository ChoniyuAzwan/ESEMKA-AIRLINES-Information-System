Imports System.Windows.Forms

Public Class frmBoarding

    Sub Clear()
        Label4.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Suc("Print boarding pass successfully")
        frmChekIn.Clear()
        Me.Close()
    End Sub

    Private Sub frmBoarding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from boardingroom where ticketnumber =  '" & frmChekIn.TextBox6.Text & " '"
                Dr = .ExecuteReader
            End With
            Dr.Read()
            If Dr.HasRows Then
                Label4.Text = Dr(0)
                Label3.Text = Dr(1)
            Else
                Att("Please check the Ticket Number")
                Clear()
                Me.Close()
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
        End Try
    End Sub
End Class
