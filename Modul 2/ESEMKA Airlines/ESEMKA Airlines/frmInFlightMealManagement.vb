Imports System.Windows.Forms

Public Class frmInFlightMealManagement
    Sub ShowMeal()
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from MealManagement"
            End With
            Da.SelectCommand = Cmd
            Dt.Clear()
            Da.Fill(Dt)
            Me.dgvPackage.DataSource = Dt
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub frmMyDeluxeTreatMenuPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMeal()
        Dim I As Integer
        For I = 0 To dgvPackage.ColumnCount - 1
            If dgvPackage.Columns(I).Visible Then
                cbTitle.Items.Add(dgvPackage.Columns(I).HeaderText)
            End If
        Next
        cbTitle.SelectedIndex = 0
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ShowMeal()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddInFlightMealManagement.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvPackage.SelectedRows.Count = 0 Then
            Att("You must select the data")
            Exit Sub
        End If
        frmEditInFlightMealManagement.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvPackage.SelectedRows.Count = 0 Then
            Att("You must select the data")
            Exit Sub
        End If
        If MsgBox("Are you sure wanna delete data with Name of Meal Management'" & dgvPackage.SelectedRows(0).Cells(0).Value & "' ?", VE + VY, T) = vbYes Then
            Try
                Open()
                With Cmd
                    .Connection = Con
                    .CommandText = "delete MealManagement where name = '" & dgvPackage.SelectedRows(0).Cells(0).Value & "'"
                    R = .ExecuteNonQuery
                End With
                If R > 0 Then Suc("Delete " & R & " Meal Management successfully")
                CloDB()
                ShowMeal()
            Catch ex As Exception
                Err(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim I As Integer
        For I = 0 To dgvPackage.ColumnCount - 1
            If dgvPackage.Columns(I).Visible Then
                If dgvPackage.Columns(I).HeaderText = cbTitle.SelectedItem Then
                    Try
                        Open()
                        With Cmd
                            .Connection = Con
                            .CommandText = "select * from mealmanagement where " & dgvPackage.Columns(I).Name & " like '%" & txtSearch.Text & "%'"
                        End With
                        Da.SelectCommand = Cmd
                        Dt.Clear()
                        Da.Fill(Dt)
                        dgvPackage.DataSource = Dt
                        CloDB()
                    Catch ex As Exception
                        Err(ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub btnCanFind_Click(sender As Object, e As EventArgs) Handles btnCanFind.Click
        ShowMeal()
    End Sub
End Class
