Imports System.Windows.Forms

Public Class frmEditPlaneManagement
    Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub frmEditPlaneManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
                Dr = .ExecuteReader
            End With
            Dr.Read()
            If Dr.HasRows Then
                TextBox1.Text = Dr(0)
                TextBox2.Text = Dr(1)
            End If
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Att("Failed display data")
            Err(ex.Message)
        End Try
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & TextBox1.Text & "' and airplanetype <>'" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
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
                .CommandText = "update planemanagement set airplanetype = '" & TextBox1.Text & "', capacity = '" & TextBox2.Text & "' where airplanetype = '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Edit " & R & " data successfully")
            Else
                Att("Failed Edit data")
            End If
            CloseDB()
            frmPlaneManagement.ShowData()
            Me.Close()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
