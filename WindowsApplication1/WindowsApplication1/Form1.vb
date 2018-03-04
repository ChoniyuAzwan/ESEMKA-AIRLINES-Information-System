Public Class Form1

    Public NilaiUlangForm As Integer
    
    Public Sub MulaiLoadForm()
        If NilaiUlangForm > 0 Then
            Form2.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NilaiUlangForm = TextBox1.Text
        MulaiLoadForm()
    End Sub

End Class
