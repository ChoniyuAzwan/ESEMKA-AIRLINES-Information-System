Imports System.Windows.Forms

Public Class frmAddFlightScheduling
    Sub Clear()
        TextBox4.Clear()
        TextBox8.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Now
    End Sub

    Sub ShowcbAirplane()
        ComboBox1.Items.Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select airplanetype from planemanagement"
                Dr = .ExecuteReader
            End With
            While Dr.Read
                ComboBox1.Items.Add(Dr(0))
            End While
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub ShowcbTrip()
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Direct")
        ComboBox2.SelectedIndex = 0
    End Sub
    Private Sub frmAddFlightScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowcbAirplane()
        ShowcbTrip()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from scheduling where flightnumber = '" & TextBox6.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
            Exit Sub
        End Try

        Try
            If TextBox4.Text.Trim = "" Or TextBox8.Text.Trim = "" Or TextBox1.Text.Trim = "" Or TextBox6.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox5.Text.Trim = "" Or ComboBox1.Text.Trim = "" Or ComboBox2.Text.Trim = "" Or DateTimePicker1.Text.Trim = "" Or DateTimePicker2.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf TextBox4.Text.Length <> 5 Or Len(TextBox8.Text) <> 5 Then
                Att("You must input the time like this '15:15'")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("Data already exist")
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
                .CommandText = "insert into scheduling values('" & TextBox6.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & DateTimePicker1.Text & "', '" & TextBox4.Text & "', '" & DateTimePicker2.Text & "', '" & TextBox8.Text & "', '" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox7.Text & "' , '" & TextBox3.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add 1 data successfully")
            Else
                Att("Failed to add data")
            End If
            CloseDB()
            Clear()
            frmFlightScheduling.ShowData()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to add data")
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        CheckInteger(e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = vbBack Then
                If Not e.KeyChar = ":" Then
                    Att("You must input integer data on this textbox")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
        Me.Close()
    End Sub
End Class
