Imports System.Windows.Forms

Public Class frmeditplanemanagement

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
                TextBox1.Text = Dr(0)
                TextBox2.Text = Dr(1)
                Dr.Close()
            End If
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            OpenDB()
            With Cmd
                .Connection = Con
                .CommandText = "select * from planemanagement where airplanetype = '" & TextBox1.Text & "' and airplanetype <> '" & frmPlaneManagement.dgvData.SelectedRows(0).Cells(0).Value & "'"
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
                .CommandText = "update planemanagement set airplanetype = '" & TextBox1.Text & "', capacity = '" & TextBox2.Text & "'"
                R = .ExecuteNonQuery
            End With
            If R > 0 Then
                Suc("Add 1 data successfully")
            Else
                Att("Failed add data")
            End If
            CloseDB()
            Clear()
            frmPlaneManagement.ShowData()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        CheckInteger(e)
    End Sub
End Class
