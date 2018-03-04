Imports System.Windows.Forms

Public Class frmEditPlaneManagement
    Sub Clear()
        TextBox6.Clear()
        TextBox1.Clear()
        TextBox6.Focus()
    End Sub

    Sub FillData()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
                Dr = .ExecuteReader
            End With
            Dr.Read()
            If Dr.HasRows Then
                TextBox6.Text = Dr(0)
                TextBox1.Text = Dr(1)
                Dr.Close()
            End If
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to fill data")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & TextBox6.Text & "' and airplanetype <> '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
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
                .CommandText = "update planemanagement set airplanetype = '" & TextBox6.Text & "', capacity = '" & TextBox1.Text & "' where airplanetype  = '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Edit 1 data successfully")
            Else
                Att("Failed to edit data")
            End If
            CloseDB()
            Me.Close()
            frmPlaneManagement.ShowData()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to edit data")
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

    Private Sub frmEditPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        FillData()
    End Sub
End Class
