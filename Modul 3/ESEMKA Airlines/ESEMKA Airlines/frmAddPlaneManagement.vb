Imports System.Windows.Forms

Public Class frmAddPlaneManagement

    Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub frmAddPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & TextBox1.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("Data already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "insert into planemanagement values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add " & R & " data successfully")
            Else
                Att("Failed add data")
            End If
            CloseDB()
            frmPlaneManagement.ShowData()
            Clear()
            TextBox1.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
