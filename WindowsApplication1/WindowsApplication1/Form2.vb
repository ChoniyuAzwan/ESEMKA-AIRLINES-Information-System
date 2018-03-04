Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

        Form1.NilaiUlangForm = Form1.NilaiUlangForm - 1
        Label1.Text = Form1.NilaiUlangForm
        Form1.MulaiLoadForm()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Form1.NilaiUlangForm
    End Sub

End Class