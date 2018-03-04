Imports System.Windows.Forms

Public Class frmTotalFee
    Sub Clear()
        Label6.Text = ""
        Label5.Text = ""
        Label4.Text = ""
    End Sub

    Sub FillData()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from totalprice where ticketnumber =  '" & TicketNumber & " '"
                Dr = .ExecuteReader
            End With
            Dr.Read()
            If Dr.HasRows Then
                Label6.Text = Dr(1)
                Label5.Text = Dr(2)
                Label4.Text = Dr(3)
            Else
                Att("Failed to display data")
                Clear()
                Me.Close()
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Suc("Print the ticket successfully")
        Me.Dispose()
        frmInFlightMealOrder.Dispose()
        frmSeatAvailability.Dispose()
        Repeat = Repeat - 1
        Customer()
    End Sub

    Private Sub frmTotalFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        frmInFlightMealOrder.Ticket()
        FillData()
    End Sub
End Class
