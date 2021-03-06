﻿Imports System.Windows.Forms

Public Class frmPlaneManagement

    Sub ShowData()
        Dt.Columns.Clear()
        dgvData.DataSource = Dt
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement"
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddPlaneManagement.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditPlaneManagement.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim Q = MsgBox("Are you sure wanna quit from this form ?", VE + VY, T)
        If Q = vbYes Then Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'If dgvData.SelectedRows.Count = 0 Then
        '    Att("You must select data or data is empty")
        '    Exit Sub
        'End If

        If dgvData.SelectedRows.Count = 0 Then
            Att("daads")
            Exit Sub
        End If
        Dim Q = MsgBox("Are you sure wanna delete this data ?", VE + VY, T)
        If Q = vbYes Then
            Try
                OpenDB()
                With Cmd
                    .Connection = Con
                    .CommandText = "delete planemanagement where airplanetype = '" & dgvData.SelectedRows(0).Cells(0).Value & "'"
                    R = .ExecuteNonQuery
                End With
                If R > 0 Then
                    Suc("Delete 1 data successfully")
                End If
                CloseDB()
                ShowData()
            Catch ex As Exception
                Err(ex.Message)
                Err("Failed to delete data")
            End Try
        End If
    End Sub

    Private Sub frmPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
        FillcbTitle(dgvData, cbTitle)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ShowData()
    End Sub

    Private Sub btnCanFind_Click(sender As Object, e As EventArgs) Handles btnCanFind.Click
        ShowData()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        '    Dim i As Integer
        '    For i = 0 To dgvData.ColumnCount - 1
        '        If dgvData.Columns(i).Visible Then
        '            If dgvData.Columns(i).HeaderText = cbTitle.SelectedItem Then
        '                Try
        '                    OpenDB()
        '                    With Cmd
        '                        .Connection = Con
        '                        .CommandText = "select * from planemanagement where " & dgvData.Columns(i).Name & " like '%" & txtSearch.Text & "%'"
        '                    End With
        '                    Da.SelectCommand = Cmd
        '                    Dt.Clear()
        '                    Da.Fill(Dt)
        '                    dgvData.DataSource = Dt
        '                    CloseDB()
        '                Catch ex As Exception
        '                    Err(ex.Message)
        '                    Err("Failed to display data")
        '                End Try
        '            End If

        '        End If
        '    Next

        Dim I As Integer
        For I = 0 To dgvData.ColumnCount - 1
            If dgvData.Columns(I).Visible Then
                If dgvData.Columns(I).HeaderText = cbTitle.SelectedItem Then
                    Try
                        OpenDB()
                        With Cmd
                            .Connection = Con
                            .CommandText = "select * from planemanagement where " & dgvData.Columns(I).Name & " like '%" & txtSearch.Text & "%'"
                        End With
                        CloseDB()
                    Catch ex As Exception

                    End Try
                End If
            End If
        Next
    End Sub
End Class
