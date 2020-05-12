Public Class Form1
    Public myFile As String ' file name
    Public myPath As String ' file path

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub importButton_Click(sender As Object, e As EventArgs) Handles importButton.Click
        Dim ofdFile As New OpenFileDialog
        Form2.ImagePicker()
        Form2.Show()
    End Sub

End Class
