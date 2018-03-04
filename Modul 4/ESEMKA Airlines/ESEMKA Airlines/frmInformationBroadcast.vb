Imports System.Windows.Forms

Public Class frmInformationBroadcast
    Sub FillData()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from scheduling where flightnumber = '" & frmeditflightscheduling.TextBox6.Text & "'"
                Dr = .ExecuteReader
            End With
            While Dr.Read
                Label8.Text = Dr(0)
                Label9.Text = Dr(1)
                Label10.Text = Dr(2)
                Label11.Text = Dr(3)
                Label21.Text = Dr(4)
                Label12.Text = Dr(5)
                Label23.Text = Dr(6)
                Label16.Text = Dr(7)
                Label17.Text = Dr(8)
                Label18.Text = Dr(9)
                Label19.Text = Dr(10)
                Label25.Text = Dr(11)
            End While
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to fill data")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Suc("Successfully send information broadcast")
        Me.Close()
        frmeditflightscheduling.Close()
    End Sub

    Private Sub frmInformationBroadcast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()
    End Sub

End Class
