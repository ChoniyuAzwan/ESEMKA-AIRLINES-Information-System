Imports System.Windows.Forms

Public Class frmTotalFee

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Suc("Print the ticket successfully")

        'Dim C As Integer = frmFlightBooking.TextBox6.Text
        'Do While C > 0
        '    C = C - 1
        '    Me.Close()
        '    frmInFlightMealOrder.Close()
        '    frmSeatAvailability.Close()
        '    frmSeatAvailability.ShowDialog()
        'Loop()
        'Me.Close()
        'frmInFlightMealOrder.Close()
        'frmSeatAvailability.Close()
        'frmFlightBooking.Close()

        'For C = 0 To frmFlightBooking.TextBox6.Text - 1
        '    If C > 0 Then
        '        Me.Close()
        '        frmInFlightMealOrder.Close()
        '    Else
        '        Me.Close()
        '        frmInFlightMealOrder.Close()
        '        frmSeatAvailability.Close()
        '        frmFlightBooking.Close()
        '    End If

        'Next


        'If C > 0 Then
        '    Me.Close()
        '    frmInFlightMealOrder.Close()
        'Else
        '    Me.Close()
        '    frmInFlightMealOrder.Close()
        '    frmSeatAvailability.Close()
        '    frmFlightBooking.Close()
        'End If
    End Sub
End Class
