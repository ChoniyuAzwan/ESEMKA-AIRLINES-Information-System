Imports System.Windows.Forms

Public Class frmFlightScheduling

   

    Sub ShowData()
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
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        jkkljlklllllllllllllkjhjjjjjjjjjjjjjjjjjjjjjkkkkkk.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditFlightScheduling.ShowDialog()
    End Sub

    Private Sub frmFlightScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
        FillcbTitle(dgvData, cbTitle)
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim I As Integer
        For I = 0 To dgvData.ColumnCount - 1
            If dgvData.Columns(I).Visible Then
                Try
                    OpenDB()
                    With Cmd
                        .Connection = Con
                        .CommandText = "select * from scheduling where " & dgvData.Columns(I).Name & " like '%" & txtSearch.Text & "%'"
                    End With
                    Da.SelectCommand = Cmd
                    Dt.Clear()
                    Da.Fill(Dt)
                    dgvData.DataSource = Dt
                    CloseDB()
                Catch ex As Exception
                    Err(ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ShowData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvData.SelectedRows.Count = 0 Then
            Att("Nothing data you select")
            Exit Sub
        End If
        Dim Q = MsgBox("Are you sure wanna delete this data ?", VE + VY, T)
        If Q = vbYes Then
            Try
                OpenDB()
                With Cmd
                    .Connection = Con
                    .CommandText = "delete scheduling where flightnumber= '" & dgvData.SelectedRows(0).Cells(0).Value & "'"
                    R = .ExecuteNonQuery
                End With
                If R > 0 Then
                    Suc("Delete " & R & " data successfully")
                Else
                    Att("Failed delete data")
                End If
                CloseDB()
                ShowData()
            Catch ex As Exception
                Err(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jkkljlklllllllllllllkjhjjjjjjjjjjjjjjjjjjjjjkkkkkk.ShowDialog()
    End Sub
End Class
