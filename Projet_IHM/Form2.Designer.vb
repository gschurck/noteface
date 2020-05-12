<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.newPicButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FilePathButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.imageName = New System.Windows.Forms.Label()
        Me.buttonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.imageGroupBox = New System.Windows.Forms.GroupBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.buttonsGroupBox.SuspendLayout()
        Me.imageGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(5, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(585, 552)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.SaveButton.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(4, 68)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(179, 49)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'newPicButton
        '
        Me.newPicButton.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.newPicButton.Location = New System.Drawing.Point(4, 123)
        Me.newPicButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.newPicButton.Name = "newPicButton"
        Me.newPicButton.Size = New System.Drawing.Size(179, 49)
        Me.newPicButton.TabIndex = 2
        Me.newPicButton.Text = " Open a new picture"
        Me.newPicButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(4, 178)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 49)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Search similar face"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FilePathButton
        '
        Me.FilePathButton.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.FilePathButton.Location = New System.Drawing.Point(4, 233)
        Me.FilePathButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FilePathButton.Name = "FilePathButton"
        Me.FilePathButton.Size = New System.Drawing.Size(179, 49)
        Me.FilePathButton.TabIndex = 4
        Me.FilePathButton.Text = "Load another notes"
        Me.FilePathButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.DeleteButton.Location = New System.Drawing.Point(4, 288)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(179, 49)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'imageName
        '
        Me.imageName.AutoSize = True
        Me.imageName.BackColor = System.Drawing.Color.White
        Me.imageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imageName.Location = New System.Drawing.Point(43, 14)
        Me.imageName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.imageName.MaximumSize = New System.Drawing.Size(400, 50)
        Me.imageName.Name = "imageName"
        Me.imageName.Size = New System.Drawing.Size(83, 25)
        Me.imageName.TabIndex = 0
        Me.imageName.Text = "Label1"
        '
        'buttonsGroupBox
        '
        Me.buttonsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonsGroupBox.BackColor = System.Drawing.Color.White
        Me.buttonsGroupBox.Controls.Add(Me.imageName)
        Me.buttonsGroupBox.Controls.Add(Me.DeleteButton)
        Me.buttonsGroupBox.Controls.Add(Me.FilePathButton)
        Me.buttonsGroupBox.Controls.Add(Me.Button3)
        Me.buttonsGroupBox.Controls.Add(Me.newPicButton)
        Me.buttonsGroupBox.Controls.Add(Me.SaveButton)
        Me.buttonsGroupBox.Location = New System.Drawing.Point(-4, -9)
        Me.buttonsGroupBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buttonsGroupBox.Name = "buttonsGroupBox"
        Me.buttonsGroupBox.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buttonsGroupBox.Size = New System.Drawing.Size(183, 612)
        Me.buttonsGroupBox.TabIndex = 6
        Me.buttonsGroupBox.TabStop = False
        '
        'imageGroupBox
        '
        Me.imageGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imageGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.imageGroupBox.Controls.Add(Me.PictureBox1)
        Me.imageGroupBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.imageGroupBox.ForeColor = System.Drawing.Color.Black
        Me.imageGroupBox.Location = New System.Drawing.Point(483, 5)
        Me.imageGroupBox.Name = "imageGroupBox"
        Me.imageGroupBox.Size = New System.Drawing.Size(595, 586)
        Me.imageGroupBox.TabIndex = 7
        Me.imageGroupBox.TabStop = False
        Me.imageGroupBox.Text = "GroupBox2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1090, 603)
        Me.Controls.Add(Me.buttonsGroupBox)
        Me.Controls.Add(Me.imageGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Noteface++"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.buttonsGroupBox.ResumeLayout(False)
        Me.buttonsGroupBox.PerformLayout()
        Me.imageGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents newPicButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FilePathButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents imageName As Label
    Friend WithEvents buttonsGroupBox As GroupBox
    Friend WithEvents imageGroupBox As GroupBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
