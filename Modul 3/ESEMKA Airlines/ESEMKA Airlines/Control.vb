Imports System.Data.SqlClient

Module Control
    Public Con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=esemka;Integrated Security=True")
    Public Cmd As New SqlCommand
    Public Da As New SqlDataAdapter
    Public Dt As New DataTable
    Public Ds As New DataSet
    Public Dr As SqlDataReader

    Public VI As Integer = vbInformation
    Public VE As Integer = vbExclamation
    Public VC As Integer = vbCritical
    Public VY As Integer = vbYesNo
    Public T As String = "ESEMKA Airlines Information System"

    Public R As Integer

    Public Sub Suc(M)
        MsgBox(M, VI, T)
    End Sub

    Public Sub Att(M)
        MsgBox(M, VE, T)
    End Sub

    Public Sub Err(M)
        MsgBox(M, VC, T)
    End Sub

    Public Gender As String
    Public AirplaneType As String

    Public Sub OpenDB()
        Try
            If Con.State = ConnectionState.Closed Then Con.Open()
        Catch ex As Exception
            Err(ex.Message)
        End Try
    End Sub

    Public Sub CloseDB()
        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Public Sub FillcbTitle(dgv As DataGridView, cb As ToolStripComboBox)
        Dim I As Integer
        For I = 0 To dgv.ColumnCount - 1
            If dgv.Columns(I).Visible Then
                cb.Items.Add(dgv.Columns(I).HeaderText)
            End If
        Next
        cb.SelectedIndex = 0
    End Sub
End Module
