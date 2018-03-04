Imports System.Windows.Forms

Public Class frmFlightBooking

    Sub ShowData()
        Dt.Columns.Clear()
        dgvData.DataSource = Dt
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from scheduling"
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            dgvData.DataSource = Dt
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
        End Try
    End Sub

    Sub Clear()
        TextBox6.Clear()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Now
    End Sub


    Sub ShowcbOrigin()
        ComboBox1.Items.Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select FlightOrigin from scheduling"
                Dr = .ExecuteReader
            End With
            While Dr.Read
                ComboBox1.Items.Add(Dr(0))
            End While
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub ShowcbDestination()
        ComboBox2.Items.Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select FlightDestination from scheduling"
                Dr = .ExecuteReader
            End With
            While Dr.Read
                ComboBox2.Items.Add(Dr(0))
            End While
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox6.Text = "" Or ComboBox1.Text.Trim = "" Or ComboBox2.Text.Trim = "" Or DateTimePicker1.Text.Trim = "" Or DateTimePicker2.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf dgvData.SelectedRows.Count = 0 Then
                Att("You must select data or data is empty")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try

        Repeat = TextBox6.Text
        Customer()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q = MsgBox("Are you sure wanna quit from this form ?", VE + VY, T)
        If q = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dt.Columns.Clear()
        dgvData.DataSource = Dt

        Try
            If ComboBox1.Text.Trim = "" Or ComboBox2.Text.Trim = "" Or DateTimePicker1.Text.Trim = "" Or DateTimePicker2.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from scheduling where FlightOrigin = '" & ComboBox1.Text & "' and FlightDestination = '" & ComboBox2.Text & "' and DepartureSchedule = '" & DateTimePicker1.Text & "' "
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            dgvData.DataSource = Dt
            CloseDB()
            If dgvData.SelectedRows.Count = 0 Then
                Att("The flight time is not available")
            Else
                Suc("Please select the available of flight time")
            End If
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
        End Try

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        CheckInteger(e)
    End Sub

    Private Sub frmFlightBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowcbOrigin()
        ShowcbDestination()
        ShowData()

        Dim var_airplanetype As String
        Dim var_capacity As Integer

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select airplanetype from scheduling where flightnumber = '" & dgvData.SelectedRows(0).Cells(0).Value & "' "
                Dr = .ExecuteReader
            End With
            If Dr.Read Then
                var_airplanetype = Dr("airplanetype")
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select capacity from planemanagement where airplanetype = '" & var_airplanetype & "' "
                Dr = .ExecuteReader
            End With
            If Dr.Read Then
                var_capacity = Dr("capacity")
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Dim var_startseat As Integer = 1

        For var_startseat = 1 To var_capacity
            frmSeatAvailability.ComboBox1.Items.Add(var_startseat)
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Type = "One Way"
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Type = "Round Trip"
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowData()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) Then
                If Not e.KeyChar = vbBack Then
                    If Not e.KeyChar = ":" Then
                        Att("You must input integer data on this textbox")
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub
End Class
