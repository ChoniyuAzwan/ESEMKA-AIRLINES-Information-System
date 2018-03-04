Public Class frmMain

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmPlaneManagement.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmFlightScheduling.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmInFlightMealManagement.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmFlightBooking.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmInFlightMealOrder.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmChekIn.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Q = MsgBox("Are you sure wanna quit from this ESEMKA Airlines Information System ?", VE + VY, T)
        If Q = vbYes Then Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmDepartureConfirmation.ShowDialog()
    End Sub
End Class
