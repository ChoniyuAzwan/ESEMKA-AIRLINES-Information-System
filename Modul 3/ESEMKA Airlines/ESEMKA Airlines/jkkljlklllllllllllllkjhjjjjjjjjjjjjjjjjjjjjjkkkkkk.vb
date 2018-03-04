Imports System.Windows.Forms

Public Class jkkljlklllllllllllllkjhjjjjjjjjjjjjjjjjjjjjjkkkkkk

    Dim Duration = dtpArrival.Text - dtpDeparture.Text

    Sub Airplane()
        cbAirplane.Items.Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select airplanetype from planemanagement"
                Dr = .ExecuteReader
            End With
            Do While Dr.Read
                cbAirplane.Items.Add("airplanetype")
            Loop
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
        cbAirplane.SelectedIndex = 0
    End Sub

    Sub Clear()
        txtNumber.Clear()
        txtOrigin.Clear()
        txtBoarding.Clear()
        txtDestination.Clear()
        txtPrice.Clear()
        cbAirplane.SelectedIndex = 0
        dtpArrival.Text = Now
        dtpDeparture.Text = Now
        txtNumber.Focus()
        cbTrip.SelectedIndex = 0
        txtNumber.Focus()
        TextBox1.Text = ""
    End Sub

    Private Sub frmAddFlightScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTrip.Items.Add("Direct")
        Clear()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from scheduling where flightnumber= '" & txtNumber.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            If txtNumber.Text.Trim = "" Or txtBoarding.Text.Trim = "" Or txtDestination.Text.Trim = "" Or txtOrigin.Text.Trim = "" Or txtPrice.Text.Trim = "" Or cbAirplane.Text.Trim = "" Or dtpArrival.Text.Trim = "" Or dtpDeparture.Text.Trim = "" Or cbTrip.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("Data already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "insert into scheduling values ('" & txtNumber.Text & "', '" & txtOrigin.Text & "', '" & txtDestination.Text & "', '" & dtpDeparture.Text & "', '" & dtpArrival.Text & "', '" & AirplaneType & "', '" & cbTrip.Text & "', '" & txtPrice.Text & "' , '" & Duration & "', '" & txtBoarding.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add " & R & " data successfully")
            Else
                Att("Failed add data")
            End If
            CloseDB()
            frmFlightScheduling.ShowData()
            Clear()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub
End Class
