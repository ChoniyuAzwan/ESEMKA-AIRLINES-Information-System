Imports System.Windows.Forms

Public Class frmEditFlightSchedulling
    Sub ShowcbTrip()
        With cbTrip.Items
            .Add("Direct")
        End With
    End Sub

    Sub ShowcbBoarding()
        With cbBoarding.Items
            .Add("R1")
            .Add("R2")
            .Add("R3")
            .Add("R4")
            .Add("R5")
        End With
    End Sub
    Sub ShowcbAirplane()
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
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from schedulling where flightnumber = '" & txtFlightNumber.Text & "' and flightnumber <> '" & frmFlightSchedulling.dgvSchedule.SelectedRows(0).Cells(0).Value & "'"
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
                Att("You must input all data except Trip Point")
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
                .CommandText = "update schedulling set flightnumber = '" & txtFlightNumber.Text & "', origin = '" & txtOrigin.Text & "', destination = '" & txtDestination.Text & "', departure = '" & dtpDeparture.Text & "', arrival = '" & dtpArrival.Text & "', trippoint = '" & cbTrip.Text & "', price = '" & txtPrice.Text & "', airplanetype = '" & cbAirplaneType.Text & "', boarding = '" & cbBoarding.Text & "' where flightnumber = '" & frmFlightSchedulling.dgvSchedule.SelectedRows(0).Cells(0).Value & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Edit " & R & " Schedulling successfully")
            CloDB()
            frmFlightSchedulling.ShowSchedule()
            Me.Close()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEditFlightSchedulling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAirplaneType.Items.Clear()
        ShowcbAirplane()
        ShowcbBoarding()
        ShowcbTrip()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from schedulling where flightnumber = '" & frmFlightSchedulling.dgvSchedule.SelectedRows(0).Cells(0).Value & "'"
                Dr = .ExecuteReader()
            End With
            Dr.Read()
            If Dr.HasRows Then
                txtFlightNumber.Text = Dr(0)
                txtOrigin.Text = Dr(1)
                txtDestination.Text = Dr(2)
                dtpDeparture.Text = Dr(3)
                dtpArrival.Text = Dr(4)
                cbTrip.SelectedItem = Dr(5)
                txtPrice.Text = Dr(6)
                cbAirplaneType.SelectedItem = Dr(7)
                cbBoarding.SelectedItem = Dr(8)
            End If
            Dr.Close()
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub
End Class
