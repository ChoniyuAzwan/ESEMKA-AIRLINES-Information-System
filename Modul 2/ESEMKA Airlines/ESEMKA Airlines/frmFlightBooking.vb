Public Class frmFlightBooking
    Public FlightType As String

    Sub ShowData()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from schedulling"
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            dgvBooking.DataSource = Dt
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Sub ShowcbOrigin()
        cbOrigin.Items.Clear()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select origin from schedulling"
                Dr = .ExecuteReader
            End With
            Do While Dr.Read
                cbOrigin.Items.Add(Dr("origin"))
            Loop
            Dr.Close()
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Sub ShowcbDestination()
        cbDestination.Items.Clear()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select destination from schedulling"
                Dr = .ExecuteReader
            End With
            Do While Dr.Read
                cbDestination.Items.Add(Dr("destination"))
            Loop
            Dr.Close()
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub frmFlightBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
        ShowcbOrigin()
        ShowcbDestination()
        rdOneWay.Checked = True
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from schedulling where origin = '" & cbOrigin.Text & "' and destination = '" & cbDestination.Text & "' and departure = '" & dtpDeparture.Text & "' "
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            dgvBooking.DataSource = Dt
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        If dtpReturn.Enabled = False Then dtpDeparture.Text = ""
        Dim F = New frmSeatAvailability
        F.ShowDialog()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ShowData()
    End Sub

    Private Sub rdOneWay_CheckedChanged(sender As Object, e As EventArgs) Handles rdOneWay.CheckedChanged
        FlightType = "One Way"
        dtpReturn.Enabled = False
    End Sub

    Private Sub rdRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rdRoundTrip.CheckedChanged
        FlightType = "Round Trip"
        dtpReturn.Enabled = True
    End Sub
End Class