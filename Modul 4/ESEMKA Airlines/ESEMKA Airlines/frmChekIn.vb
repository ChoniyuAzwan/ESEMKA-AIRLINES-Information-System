Imports System.Windows.Forms

Public Class frmChekIn

    Sub Clear()
        Label12.Text = ""
        Label11.Text = ""
        Label10.Text = ""
        Label9.Text = ""
        Label8.Text = ""
        TextBox6.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmBoarding.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Q = MsgBox("Are you sure wanna quit from this form ?", VE + VY, T)
        If Q = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox6.Text.Trim = "" Then
                Att("You must input the ticket number")
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
                .CommandText = "select psgfullname, PsgGender, PsgAddress, PsgEmail, FlightNumber from booking where ticketnumber =  '" & TextBox6.Text & " '"
                Dr = .ExecuteReader
            End With
            Dr.Read()
            If Dr.HasRows Then
                Label12.Text = Dr(0)
                Label11.Text = Dr(1)
                Label10.Text = Dr(2)
                Label9.Text = Dr(3)
                Label8.Text = Dr(4)
                Dr.Close()
                Try
                    OpenDB()
                    With Cmd
                        .Connection = Con
                        .CommandText = "select * from booking where ticketnumber = '" & TextBox6.Text & "' and checkintime <> ''"
                    End With
                    Da.SelectCommand = Cmd
                    Ds = New DataSet
                    Da.Fill(Ds)
                    CloseDB()
                Catch ex As Exception
                    Err(ex.Message)
                    Exit Sub
                End Try

                Try
                    If Ds.Tables(0).Rows.Count > 0 Then
                        Att("The passanger has been check-in")
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
                        .CommandText = "update booking set checkintime = '" & Now & "' where ticketnumber = '" & TextBox6.Text & "' "
                        .ExecuteNonQuery()
                    End With
                    CloseDB()
                    Suc("Record the check-in successfully")
                Catch ex As Exception
                    Err(ex.Message)
                    Err("Failed to record the check-in")
                End Try


            Else
                Att("The ticket number is inappropriate")
            End If
            Dr.Close()
            CloseDB()
        Catch ex As Exception
            Err(ex.Message)
            Err("Failed to display data")
        End Try
    End Sub

    Private Sub frmChekIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        TextBox6.Clear()
        TextBox6.Focus()
    End Sub
End Class
