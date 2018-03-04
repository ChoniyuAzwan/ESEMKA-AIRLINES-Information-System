Imports System.Windows.Forms

Public Class frmAddFlightSchedulling
    Sub ShowcbTrip()
        With cbTrip.Items
            .Add("Direct")
        End With
        cbTrip.SelectedIndex = 0
    End Sub

    Sub ShowcbBoarding()
        With cbBoarding.Items
            .Add("R1")
            .Add("R2")
            .Add("R3")
            .Add("R4")
            .Add("R5")
        End With
        cbBoarding.SelectedIndex = 0
    End Sub

    Sub Clear()
        txtFlightNumber.Clear()
        txtOrigin.Clear()
        txtDestination.Clear()
        dtpDeparture.Text = Now
        dtpArrival.Text = Now
        cbAirplaneType.Text = ""
        cbTrip.SelectedIndex = 0
        txtPrice.Clear()
        cbBoarding.Text = ""
    End Sub

    Sub ShowcbIDAirplane()
        cbAirplaneType.Items.Clear()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select type from airplane"
                Dr = .ExecuteReader
            End With
            Do While Dr.Read
                cbAirplaneType.Items.Add(Dr("type"))
            Loop
            Dr.Close()
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        cbAirplaneType.SelectedIndex = 0
    End Sub

    Private Sub frmAddFlightSchedulling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAirplaneType.Items.Clear()
        ShowcbIDAirplane()
        ShowcbBoarding()
        ShowcbTrip()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from Schedulling where FlightNumber = '" & txtFlightNumber.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            If txtFlightNumber.Text.Trim = "" Or txtOrigin.Text.Trim = "" Or txtDestination.Text.Trim = "" Or dtpDeparture.Text.Trim = "" Or dtpArrival.Text.Trim = "" Or txtPrice.Text.Trim = "" Or cbAirplaneType.Text.Trim = "" Or cbTrip.Text.Trim = "" Or cbBoarding.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("The Airplane Type '" & txtFlightNumber.Text & "' already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "insert into schedulling (flightnumber, Origin, Destination, Departure, Arrival, TripPoint, Price, airplanetype, boarding) values ('" & txtFlightNumber.Text & "', '" & txtOrigin.Text & "', '" & txtDestination.Text & "', '" & dtpDeparture.Text & "', '" & dtpArrival.Text & "', '" & cbTrip.Text & "', '" & txtPrice.Text & "', '" & cbAirplaneType.Text & "', '" & cbBoarding.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Add " & R & " data successfully")
            CloDB()
            frmFlightSchedulling.ShowSchedule()
            Clear()
            txtFlightNumber.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
