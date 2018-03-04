Imports System.Windows.Forms

Public Class frmSeatAvailability
    Public Gender As String

    'Sub ShowData()
    '    Try
    '        Open()
    '        With Cmd
    '            .Connection = Con
    '            .CommandText = "select * from booking"
    '        End With
    '        Da.SelectCommand = Cmd
    '        Dt.Clear()
    '        Da.Fill(Dt)
    '        dgvData.DataSource = Dt
    '        CloDB()
    '    Catch ex As Exception
    '        Err(ex.Message)
    '    End Try
    'End Sub

    Sub Clear()
        txtName.Clear()
        rdMale.Checked = True
        txtAddress.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        cbSeat.SelectedItem = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '    Try
        '        Open()
        '        With Cmd
        '            .Connection = Con
        '            .CommandText = "select * from airplane where type = '" & txtType.Text & "'"
        '        End With
        '        Da.SelectCommand = Cmd
        '        Ds = New DataSet
        '        Da.Fill(Ds)
        '        CloDB()
        '    Catch ex As Exception
        '        Err(ex.Message)
        '    End Try

        '    Try
        '        If txtType.Text.Trim = "" Or txtCapacity.Text.Trim = "" Then
        '            Att("You must input all data")
        '            Exit Sub
        '        ElseIf Ds.Tables(0).Rows.Count > 0 Then
        '            Att("The Airplane Type '" & txtType.Text & "' already exist")
        '            Exit Sub
        '        End If
        '    Catch ex As Exception
        '        Err(ex.Message)
        '    End Try

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "insert into booking (flightnumber, flighttype, ReturnDate, PsgName, PsgGender, PsgAddress, PsgEmail, PsgPhone, Seat)" & _
                            " values ('" & frmFlightBooking.dgvBooking.SelectedRows(0).Cells(0).Value & "', '" & frmFlightBooking.FlightType & "', '" & frmFlightBooking.dtpReturn.Text & "', '" & txtName.Text & "', '" & Gender & "', '" & txtAddress.Text & "', '" & txtEmail.Text & "', '" & txtPhone.Text & "', '" & cbSeat.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Add " & R & " Booking successfully")
            CloDB()
            Clear()
            'showData()
            txtName.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ShowData()
        rdMale.Checked = True
    End Sub
End Class
