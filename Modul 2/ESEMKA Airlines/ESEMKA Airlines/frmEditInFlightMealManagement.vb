Imports System.Windows.Forms

Public Class frmEditInFlightMealManagement

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from MealManagement where name = '" & txtName.Text & "' and name <> '" & frmInFlightMealManagement.dgvPackage.SelectedRows(0).Cells(0).Value & "'"
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
                Att("The Name of Meal Management '" & txtName.Text & "' already exist")
                Exit Sub
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try

        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "update MealManagementset name = '" & txtName.Text & "', price= '" & txtPrice.Text & "' where type = '" & frmInFlightMealManagement.dgvPackage.SelectedRows(0).Cells(0).Value & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then Suc("Edit " & R & " Meal Management successfully")
            CloDB()
            frmInFlightMealManagement.ShowMeal()
            Me.Close()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub frmEditMealManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Open()
            With Cmd
                .Connection = Con
                .CommandText = "select * from MealManagement where name = '" & frmInFlightMealManagement.dgvPackage.SelectedRows(0).Cells(0).Value & "'"
                Dr = .ExecuteReader()
            End With
            Dr.Read()
            If Dr.HasRows Then
                txtName.Text = Dr(0)
                txtPrice.Text = Dr(1)
            End If
            CloDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
