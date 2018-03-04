Imports System.Windows.Forms

Public Class frmInFlightMealOrder
    Sub ShowcbMenu()
        ComboBox2.Items.Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select menu from mealmanagement"
                Dr = .ExecuteReader
            End With
            While Dr.Read
                ComboBox2.Items.Add(Dr(0))
            End While
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
        ComboBox2.SelectedIndex = 0
    End Sub

    Sub Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox2.SelectedIndex = 0
    End Sub

    Sub Ticket()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select ticketnumber from booking where ticketnumber = max(ticketnumber)"
                Dr = .ExecuteReader
            End With
            If Dr.Read Then
                TicketNumber = Dr(0)
            End If
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed fill ticket number")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or ComboBox2.Text.Trim = "" Then
                Att("You must input all data")
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
                .CommandText = "insert into mealorder (TicketNumber, Menu, OrderQuantity, OrderPrice) values ('" & TicketNumber & "', '" & ComboBox2.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
                '.CommandText = "update MealOrder set ticketnumber = '', Menu = '" & ComboBox2.Text & "', OrderQuantity = '" & TextBox2.Text & "', OrderPrice = '" & TextBox3.Text & "' where ticketnumber = '" & TicketNumber & "' "
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add 1 data successfully")
            Else
                Att("Failed to add data")
            End If
            CloseDB()
            frmTotalFee.ShowDialog()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to add data")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "insert into mealorder() values ()"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("You don't order")
            Else
                Att("Failed to add data")
            End If
            CloseDB()
            frmTotalFee.ShowDialog()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to add data")
        End Try
    End Sub

    Private Sub frmInFlightMealOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear()
        ShowcbMenu()
        Ticket()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        CheckInteger(e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
