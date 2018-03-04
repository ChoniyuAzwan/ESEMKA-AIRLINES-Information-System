Public Class frmPlaneManagement
    Sub ShowPlane()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from airplane"
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            Me.dgvPlane.DataSource = Dt
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        dgvPlane.Columns(0).HeaderText = "Airplane Type"
        dgvPlane.Columns(1).HeaderText = "Airplane Capacity"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddPlaneManagement.ShowDialog()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ShowPlane()
    End Sub

    Private Sub frmPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowPlane()
        Dim I As Integer
        For I = 0 To dgvPlane.ColumnCount - 1
            If dgvPlane.Columns(I).Visible Then
                cbTitle.Items.Add(dgvPlane.Columns(I).HeaderText)
            End If
        Next
        cbTitle.SelectedIndex = 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvPlane.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        frmEditlaneManagement.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure wanna delete data with Airplane Type '" & dgvPlane.SelectedRows(0).Cells(0).Value & "' ?", VE + VY, T) = vbYes Then
            Try
                Open()
                With Cmd
                    .Connection = Con
                    .CommandText = "delete airplane where type = '" & dgvPlane.SelectedRows(0).Cells(0).Value & "'"
                    R = .ExecuteNonQuery
                End With
                If R > 0 Then Suc("Delete " & R & " Airplane successfully")
                CloDB()
                ShowPlane()
            Catch ex As Exception
                Err(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCanFind_Click(sender As Object, e As EventArgs) Handles btnCanFind.Click
        ShowPlane()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim I As Integer
        For I = 0 To dgvPlane.ColumnCount - 1
            If dgvPlane.Columns(I).Visible Then
                If dgvPlane.Columns(I).HeaderText = cbTitle.SelectedItem Then
                    Try
                        Open()
                        With Cmd
                            .Connection = Con
                            .CommandText = "select * from airplane where " & dgvPlane.Columns(I).Name & " like '%" & txtSearch.Text & "%'"
                        End With
                        Da.SelectCommand = Cmd
                        Dt.Clear()
                        Da.Fill(Dt)
                        dgvPlane.DataSource = Dt
                        CloDB()
                    Catch ex As Exception
                        Err(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub
End Class