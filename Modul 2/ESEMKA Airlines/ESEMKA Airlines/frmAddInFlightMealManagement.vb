Imports System.Windows.Forms

Public Class frmAddInFlightMealManagement

    Sub Clear()
        txtName.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub frmAddPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub

    Private Sub btnOk_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from MealManagement where name = '" & txtName.Text & "'"
            End With
            Da.SelectCommand = Cmd
            Ds = New DataSet
            Da.Fill(Ds)
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            If txtName.Text.Trim = "" Or txtPrice.Text.Trim = "" Then
                Att("You must input all data")
                Exit Sub
            ElseIf Ds.Tables(0).Rows.Count > 0 Then
                Att("The Name of MyDeluxe Treat Package '" & txtName.Text & "' already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "insert into MealManagement (name, price) values ('" & txtName.Text & "', '" & txtPrice.Text & "')"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Add " & R & " Meal Management successfully")
            CloDB()
            frmInFlightMealManagement.ShowMeal()
            Clear()
            txtName.Focus()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class

