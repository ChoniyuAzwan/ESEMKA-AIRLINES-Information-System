Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmFlightSchedulling.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPlaneManagement.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmFlightBooking.ShowDialog()
    End Sub

    Private Sub btnPackage_Click(sender As Object, e As EventArgs) Handles btnPackage.Click
        frmInFlightMealManagement.ShowDialog()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmCheckIn.ShowDialog()
    End Sub
End Class