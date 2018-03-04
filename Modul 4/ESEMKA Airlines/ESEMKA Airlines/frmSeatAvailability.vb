Imports System.Windows.Forms

Public Class frmSeatAvailability

    

    Sub Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""
        TextBox6.Focus()
    End Sub

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSeatAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Suc("Please input " & Repeat & " customer identity more")
        Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim var_totaldata As Integer
        Try
            If TextBox6.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" Or ComboBox1.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
                'ElseIf TextBox4.Text.Length <> 5 Then
                '    Att("You must input the time like this '15:15'")
                '    Exit Sub
            Else
                OpenDB()
                With Cmd
                    .Connection = Con
                    .CommandText = "SELECT COUNT(*) as totaldata FROM Booking WHERE FlightNumber='" & frmFlightBooking.dgvData.SelectedRows(0).Cells(0).Value & "' AND Seat='" & ComboBox1.Text & "'"
                    Dr = .ExecuteReader
                End With
                If Dr.Read Then
                    var_totaldata = Dr("totaldata")
                End If
                CloseDB()

                If var_totaldata > 0 Then
                    MessageBox.Show("Seat telah terisi!", "Informasi", MessageBoxButtons.OK)
                Else
                    Try
                        OpenDB()
                        With Cmd
                            .Connection = Con
                            .CommandText = "insert into booking (FlightNumber, FlightType, ReturnDate, ReturnTime, PsgFullName, PsgGender, PsgAddress, PsgEmail, PsgPhone, Seat) values('" & frmFlightBooking.dgvData.SelectedRows(0).Cells(0).Value & "', '" & Type & "', '" & frmFlightBooking.DateTimePicker2.Text & "', '" & frmFlightBooking.TextBox4.Text & "', '" & TextBox6.Text & "', '" & Gender & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & ComboBox1.Text & "')"
                            R = .ExecuteNonQuery
                        End With
                        If R > 0 Then
                            Suc("Add 1 data successfully")
                        Else
                            Att("Failed to add data")
                            Exit Sub
                        End If
                        CloseDB()
                        frmInFlightMealOrder.ShowDialog()
                    Catch ex As Exception
                        Err(ex.Message)
                        Err("Failed to add data")
                    End Try
                End If
                
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try
        
    End Sub
End Class
