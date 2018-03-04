Imports System.Windows.Forms

Public Class frmAddPlaneManagement

    Sub Clear()
        txtType.Text = ""
        txtCapacity.Text = ""
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs)

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from airplane where type = '" & txtType.Text & "'"
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
                .CommandText = "insert into airplane (type, capacity) values ('" & txtType.Text & "', '" & txtCapacity.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Add " & R & " Airplane successfully")
            CloDB()
            frmPlaneManagement.ShowPlane()
            Clear()
            txtType.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub


    Private Sub frmAddPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtType.Focus()
    End Sub

    Private Sub btnOk_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from airplane where type = '" & txtType.Text & "'"
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
                .CommandText = "insert into airplane (type, capacity) values ('" & txtType.Text & "', '" & txtCapacity.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Add " & R & " Airplane successfully")
            CloDB()
            frmPlaneManagement.ShowPlane()
            Clear()
            txtType.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = vbBack Then
                e.Handled = True
                Att("You must input round number or numeral")
            End If
        End If
    End Sub
End Class
