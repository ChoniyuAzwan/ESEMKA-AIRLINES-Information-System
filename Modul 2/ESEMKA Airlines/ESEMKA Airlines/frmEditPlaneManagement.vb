Imports System.Windows.Forms

Public Class frmEditlaneManagement

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from airplane where type = '" & txtType.Text & "' and type <> '" & frmPlaneManagement.dgvPlane.SelectedRows(0).Cells(0).Value & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            If txtType.Text.Trim = "" Or txtCapacity.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("The Airplane Type '" & txtType.Text & "' already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "update airplane set type = '" & txtType.Text & "', capacity = '" & txtCapacity.Text & "' where type = '" & frmPlaneManagement.dgvPlane.SelectedRows(0).Cells(0).Value & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Edit " & R & " Airplane successfully")
            CloDB()
            frmPlaneManagement.ShowPlane()
            Me.Close()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmeditlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from airplane where type = '" & frmPlaneManagement.dgvPlane.SelectedRows(0).Cells(0).Value & "'"
                Dr = .ExecuteReader()
            End With
            Dr.Read()
            If Dr.HasRows Then
                txtType.Text = Dr(0)
                txtCapacity.Text = Dr(1)
            End If
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            Att("You must input numeral or round number")
        End If
    End Sub
End Class
