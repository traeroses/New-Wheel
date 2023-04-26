<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imgWheel = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picWheel = New System.Windows.Forms.PictureBox()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgWheel
        '
        Me.imgWheel.ImageStream = CType(resources.GetObject("imgWheel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgWheel.TransparentColor = System.Drawing.Color.Transparent
        Me.imgWheel.Images.SetKeyName(0, "1.png")
        Me.imgWheel.Images.SetKeyName(1, "2.png")
        Me.imgWheel.Images.SetKeyName(2, "3.png")
        Me.imgWheel.Images.SetKeyName(3, "4.png")
        Me.imgWheel.Images.SetKeyName(4, "5.png")
        Me.imgWheel.Images.SetKeyName(5, "6.png")
        Me.imgWheel.Images.SetKeyName(6, "7.png")
        Me.imgWheel.Images.SetKeyName(7, "8.png")
        Me.imgWheel.Images.SetKeyName(8, "9.png")
        Me.imgWheel.Images.SetKeyName(9, "10.png")
        Me.imgWheel.Images.SetKeyName(10, "11.png")
        Me.imgWheel.Images.SetKeyName(11, "12.png")
        Me.imgWheel.Images.SetKeyName(12, "13.png")
        Me.imgWheel.Images.SetKeyName(13, "14.png")
        Me.imgWheel.Images.SetKeyName(14, "15.png")
        Me.imgWheel.Images.SetKeyName(15, "16.png")
        Me.imgWheel.Images.SetKeyName(16, "17.png")
        Me.imgWheel.Images.SetKeyName(17, "18.png")
        Me.imgWheel.Images.SetKeyName(18, "19.png")
        Me.imgWheel.Images.SetKeyName(19, "20.png")
        Me.imgWheel.Images.SetKeyName(20, "21.png")
        Me.imgWheel.Images.SetKeyName(21, "22.png")
        Me.imgWheel.Images.SetKeyName(22, "23.png")
        Me.imgWheel.Images.SetKeyName(23, "24.png")
        Me.imgWheel.Images.SetKeyName(24, "25.png")
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(135, 190)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(133, 106)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'picWheel
        '
        Me.picWheel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picWheel.Image = Global.New_Wheel.My.Resources.Resources.Picture1
        Me.picWheel.Location = New System.Drawing.Point(317, 57)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(452, 366)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 1
        Me.picWheel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 513)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgWheel As ImageList
    Friend WithEvents btnGo As Button
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
