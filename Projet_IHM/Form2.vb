Public Class Form2
    Public fileName As String
    Public filePath As String
    Dim ofdFile As New OpenFileDialog
    Dim selectedPath As String
    Dim saveState As Boolean = False

    Public Sub ImagePicker()
        If ofdFile.ShowDialog = DialogResult.OK Then
            ' get the file name (without the path)
            fileName = ofdFile.SafeFileName()
            ' get path+name
            filePath = ofdFile.FileName()
            ' display just the name
            'Label1.Text = myFile
            Me.Show()
            Form1.Hide()
        End If
    End Sub

    Private Sub ImageLoader()
        PictureBox1.Image = Image.FromFile(filePath)
        imageGroupBox.Text = fileName
        'imageName.Text = fileName
    End Sub

    Private Sub newPicButton_Click(sender As Object, e As EventArgs) Handles newPicButton.Click
        ImagePicker()
        ImageLoader()
    End Sub

    Public Sub ChooseFolder()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            selectedPath = FolderBrowserDialog1.SelectedPath
        Else
            ChooseFolder()
        End If
    End Sub

    Private Sub SaveFile()
        'save to selectedpath
    End Sub

    Private Sub TempSave()
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath() + "\TempFiles") = False Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath() + "\TempFiles")
        End If
        'save to Application.StartupPath() + "\TempFiles"
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    '-----------------------------------------------------------------------------------------------------

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageLoader()
        Form1.Hide()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to delete this file ?", "Delete", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            MessageBox.Show("File is deleted")
            Me.Close()
            Form1.Show()

        ElseIf result = DialogResult.Cancel Then
            Me.Show()
        End If
    End Sub

    Private Sub FilePathButton_Click(sender As Object, e As EventArgs) Handles FilePathButton.Click
        ChooseFolder()
        MsgBox(selectedPath)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If saveState = False Then
            ChooseFolder()
        End If
        SaveButton.Text = "Saved !"
        SaveFile()
        saveState = True
        wait(1)
        SaveButton.Text = "Save"
    End Sub

End Class








'-----------------------------------------------------------------------------------------------------------------------






'Public Sub Test()
'    Try

'        Dim reader As StreamReader = New System.IO.StreamReader(File.OpenRead("D:\CSV\Test.csv"))
'        Dim listA As New List(Of String)()


'        If File.Exists("d:\CSV\TestOut.csv") Then
'            File.Delete("d:\CSV\TestOut.csv")
'        End If

'        Dim sw As New StreamWriter("d:\CSV\TestOut.csv")
'        Dim s As String = String.Empty

'        While reader.Peek() >= 0
'            Dim line As String = reader.ReadLine()
'            Dim values As String() = line.Split(";"c)
'            listA.Add(values(0))
'            s = s + line + Chr(10)
'        End While
'        reader.Close()
'        sw.Write(s)
'        sw.Close()
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try

'End Sub