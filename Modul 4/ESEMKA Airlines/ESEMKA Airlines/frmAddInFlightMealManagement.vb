Imports System.Windows.Forms

Public Class frmAddInFlightMealManagement
    Sub Clear()
        TextBox6.Clear()
        TextBox1.Clear()
        TextBox6.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from mealmanagement where menu = '" & TextBox6.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
            Exit Sub
        End Try

        Try
            If TextBox1.Text.Trim = "" Or TextBox6.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("Data already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
            Exit Sub
        End Try

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "insert into mealmanagement values('" & TextBox6.Text & "', '" & TextBox1.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add 1 data successfully")
            Else
                Att("Failed to add data")
            End If
            CloseDB()
            Clear()
            frmInFlightMealManagement.ShowData()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to add data")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = vbBack Then
                Att("You must input this textbox with integer")
                e.Handled = True
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub frmAddInFlightMealManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub
End Class
