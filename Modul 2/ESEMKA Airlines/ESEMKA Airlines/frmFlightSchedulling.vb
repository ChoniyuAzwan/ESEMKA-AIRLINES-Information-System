Public Class frmFlightSchedulling

    Sub ShowSchedule()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from schedulling"
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            dgvSchedule.DataSource = Dt
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub frmFlightScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowSchedule()
        Dim I As Integer
        For I = 0 To dgvSchedule.ColumnCount - 1
            If dgvSchedule.Columns(I).Visible Then
                cbTitle.Items.Add(dgvSchedule.Columns(I).HeaderText)
            End If
        Next
        cbTitle.SelectedIndex = 0
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddFlightSchedulling.ShowDialog()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim I As Integer
        For I = 0 To dgvSchedule.ColumnCount - 1
            If dgvSchedule.Columns(I).Visible Then
                If dgvSchedule.Columns(I).HeaderText = cbTitle.SelectedItem Then
                    Try
                        Open()
                        With Cmd
                            .Connection = Con
                            .CommandText = "select * from schedulling where " & dgvSchedule.Columns(I).Name & " like '%" & txtSearch.Text & "%'"
                        End With
                        Da.SelectCommand = Cmd
                        Dt.Clear()
                        Da.Fill(Dt)
                        dgvSchedule.DataSource = Dt
                        CloDB()
                    Catch ex As Exception
                        Err(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvSchedule.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        frmEditFlightSchedulling.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ShowSchedule()
    End Sub

    Private Sub btnCanFind_Click(sender As Object, e As EventArgs) Handles btnCanFind.Click
        Me.ShowSchedule()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure wanna delete data with Flight Number '" & dgvSchedule.SelectedRows(0).Cells(0).Value & "' ?", VE + VY, T) = vbYes Then
            Try
                Open()
                With Cmd
                    .Connection = Con
                    .CommandText = "delete schedulling where flightnumber = '" & dgvSchedule.SelectedRows(0).Cells(0).Value & "'"
                    R = .ExecuteNonQuery
                End With
                If R > 0 Then Suc("Delete " & R & " Schedulling successfully")
                CloDB()
                ShowSchedule()
            Catch ex As Exception
                Err(ex.Message)
            End Try
        End If
    End Sub
End Class