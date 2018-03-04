Imports System.Data.SqlClient

Module Control
    Public Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Esemka;Integrated Security=True")
    Public Cmd As New SqlCommand
    Public Da As New SqlDataAdapter
    Public Dt As New DataTable
    Public Ds As New DataSet
    Public Dr As SqlDataReader

    Public T As String = "ESEMKA Airlines Information System"
    Public VY As Integer = vbYesNo
    Public VE As Integer = vbExclamation
    Public VI As Integer = vbInformation
    Public VC As Integer = vbCritical
    Public R As Integer
    Public Type As String
    Public Gender As String
    Public TicketNumber As String

    Public Sub Suc(m)
        MsgBox(m, VI, T)
    End Sub

    Public Sub Att(m)
        MsgBox(m, VE, T)
    End Sub

    Public Sub Err(m)
        MsgBox(m, VC, T)
    End Sub


    Public Sub OpenDB()
        Try
            If Con.State = 0 Then Con.Open()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Public Sub CloseDB()
        If Con.State = 1 Then Con.Close()
    End Sub

    Public Sub CheckInteger(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = vbBack Then
                Att("You must input integer data on this textbox")
                e.Handled = True
            End If
        End If
    End Sub

    Public Repeat As Integer

    Public Sub Customer()
        Try
            If Repeat > 0 Then
                frmSeatAvailability.ShowDialog()
            End If
        Catch ex As Exception
            Err(ex.Message)
        End Try
        
    End Sub

    Sub FillCbTitle(dgv As DataGridView, CB As ToolStripComboBox)
        Dim I As Integer
        For I = 0 To dgv.ColumnCount - 1
            If dgv.Columns(I).Visible Then
                CB.Items.Add(dgv.Columns(I).HeaderText)
            End If
        Next
        CB.SelectedIndex = 0
    End Sub
End Module
