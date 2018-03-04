Imports System.Windows.Forms

Public Class frmFlightBooking

    'Function Ticket()
    '    Dim C As Integer
    '    If frmTotalFee.ShowDialog Then
    '        C = 2 - 1
    '        If C > 0 Then

    '        End If
    '        Return True
    '    End If
    'End Function

    Sub ShowData()
        Dt.Columns.Clear()
        dgvData.DataSource = Dt
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from booking"
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
        ComboBox1.Items.Clear()
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
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSeatAvailability.ShowDialog()
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
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from booking where FlightOrigin = '' and FlightDestination = '' and "
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

        Try
            If TextBox6.Text.Trim = "" Or ComboBox1.Text.Trim = "" Or ComboBox2.Text.Trim = "" Or DateTimePicker1.Text.Trim = "" Or DateTimePicker2.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try
        Suc("Please select the available of flight time")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Type = "One Way"
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Type = "Round Trip"
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        CheckInteger(e)
    End Sub

    Private Sub frmFlightBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        ShowcbOrigin()
        ShowcbDestination()
    End Sub
End Class
