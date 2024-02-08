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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerRed = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.y1 = New System.Windows.Forms.Button()
        Me.ry1 = New System.Windows.Forms.Button()
        Me.y3 = New System.Windows.Forms.Button()
        Me.ry3 = New System.Windows.Forms.Button()
        Me.y4 = New System.Windows.Forms.Button()
        Me.y2 = New System.Windows.Forms.Button()
        Me.ry4 = New System.Windows.Forms.Button()
        Me.ry2 = New System.Windows.Forms.Button()
        Me.y5 = New System.Windows.Forms.Button()
        Me.ry5 = New System.Windows.Forms.Button()
        Me.ry10 = New System.Windows.Forms.Button()
        Me.y10 = New System.Windows.Forms.Button()
        Me.ry7 = New System.Windows.Forms.Button()
        Me.ry9 = New System.Windows.Forms.Button()
        Me.y7 = New System.Windows.Forms.Button()
        Me.y9 = New System.Windows.Forms.Button()
        Me.ry8 = New System.Windows.Forms.Button()
        Me.y8 = New System.Windows.Forms.Button()
        Me.ry6 = New System.Windows.Forms.Button()
        Me.y6 = New System.Windows.Forms.Button()
        Me.TimerYellow = New System.Windows.Forms.Timer(Me.components)
        Me.DYellow = New System.Windows.Forms.Timer(Me.components)
        Me.g = New System.Windows.Forms.Button()
        Me.g2 = New System.Windows.Forms.Button()
        Me.g3 = New System.Windows.Forms.Button()
        Me.g4 = New System.Windows.Forms.Button()
        Me.g5 = New System.Windows.Forms.Button()
        Me.g10 = New System.Windows.Forms.Button()
        Me.g9 = New System.Windows.Forms.Button()
        Me.g8 = New System.Windows.Forms.Button()
        Me.g7 = New System.Windows.Forms.Button()
        Me.g6 = New System.Windows.Forms.Button()
        Me.GreenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sc1 = New System.Windows.Forms.Button()
        Me.sc2 = New System.Windows.Forms.Button()
        Me.TimerSC = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Black.png")
        Me.ImageList1.Images.SetKeyName(1, "DoubleYellow1.png")
        Me.ImageList1.Images.SetKeyName(2, "DoubleYellow2.png")
        Me.ImageList1.Images.SetKeyName(3, "Green.png")
        Me.ImageList1.Images.SetKeyName(4, "Red.png")
        Me.ImageList1.Images.SetKeyName(5, "SC1.png")
        Me.ImageList1.Images.SetKeyName(6, "SC2.png")
        Me.ImageList1.Images.SetKeyName(7, "White.png")
        Me.ImageList1.Images.SetKeyName(8, "Yellow.png")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 146)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Red"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimerRed
        '
        Me.TimerRed.Interval = 200
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(520, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 146)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RaceControlManager.My.Resources.Resources.Layout
        Me.PictureBox2.Location = New System.Drawing.Point(808, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 314)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(42, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 300)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'y1
        '
        Me.y1.Location = New System.Drawing.Point(808, 393)
        Me.y1.Name = "y1"
        Me.y1.Size = New System.Drawing.Size(31, 30)
        Me.y1.TabIndex = 4
        Me.y1.Text = "Button3"
        Me.y1.UseVisualStyleBackColor = True
        '
        'ry1
        '
        Me.ry1.Location = New System.Drawing.Point(842, 393)
        Me.ry1.Name = "ry1"
        Me.ry1.Size = New System.Drawing.Size(31, 30)
        Me.ry1.TabIndex = 5
        Me.ry1.Text = "Button4"
        Me.ry1.UseVisualStyleBackColor = True
        '
        'y3
        '
        Me.y3.Location = New System.Drawing.Point(972, 393)
        Me.y3.Name = "y3"
        Me.y3.Size = New System.Drawing.Size(31, 30)
        Me.y3.TabIndex = 6
        Me.y3.Text = "Button5"
        Me.y3.UseVisualStyleBackColor = True
        '
        'ry3
        '
        Me.ry3.Location = New System.Drawing.Point(1006, 393)
        Me.ry3.Name = "ry3"
        Me.ry3.Size = New System.Drawing.Size(31, 30)
        Me.ry3.TabIndex = 7
        Me.ry3.Text = "Button6"
        Me.ry3.UseVisualStyleBackColor = True
        '
        'y4
        '
        Me.y4.Location = New System.Drawing.Point(1054, 393)
        Me.y4.Name = "y4"
        Me.y4.Size = New System.Drawing.Size(31, 30)
        Me.y4.TabIndex = 8
        Me.y4.Text = "Button7"
        Me.y4.UseVisualStyleBackColor = True
        '
        'y2
        '
        Me.y2.Location = New System.Drawing.Point(890, 393)
        Me.y2.Name = "y2"
        Me.y2.Size = New System.Drawing.Size(31, 30)
        Me.y2.TabIndex = 9
        Me.y2.Text = "Button8"
        Me.y2.UseVisualStyleBackColor = True
        '
        'ry4
        '
        Me.ry4.Location = New System.Drawing.Point(1088, 393)
        Me.ry4.Name = "ry4"
        Me.ry4.Size = New System.Drawing.Size(31, 30)
        Me.ry4.TabIndex = 10
        Me.ry4.Text = "Button9"
        Me.ry4.UseVisualStyleBackColor = True
        '
        'ry2
        '
        Me.ry2.Location = New System.Drawing.Point(924, 393)
        Me.ry2.Name = "ry2"
        Me.ry2.Size = New System.Drawing.Size(31, 30)
        Me.ry2.TabIndex = 11
        Me.ry2.Text = "Button10"
        Me.ry2.UseVisualStyleBackColor = True
        '
        'y5
        '
        Me.y5.Location = New System.Drawing.Point(1136, 393)
        Me.y5.Name = "y5"
        Me.y5.Size = New System.Drawing.Size(31, 30)
        Me.y5.TabIndex = 12
        Me.y5.Text = "Button11"
        Me.y5.UseVisualStyleBackColor = True
        '
        'ry5
        '
        Me.ry5.Location = New System.Drawing.Point(1170, 393)
        Me.ry5.Name = "ry5"
        Me.ry5.Size = New System.Drawing.Size(31, 30)
        Me.ry5.TabIndex = 13
        Me.ry5.Text = "Button12"
        Me.ry5.UseVisualStyleBackColor = True
        '
        'ry10
        '
        Me.ry10.Location = New System.Drawing.Point(1170, 468)
        Me.ry10.Name = "ry10"
        Me.ry10.Size = New System.Drawing.Size(31, 30)
        Me.ry10.TabIndex = 23
        Me.ry10.Text = "Button13"
        Me.ry10.UseVisualStyleBackColor = True
        '
        'y10
        '
        Me.y10.Location = New System.Drawing.Point(1136, 468)
        Me.y10.Name = "y10"
        Me.y10.Size = New System.Drawing.Size(31, 30)
        Me.y10.TabIndex = 22
        Me.y10.Text = "Button14"
        Me.y10.UseVisualStyleBackColor = True
        '
        'ry7
        '
        Me.ry7.Location = New System.Drawing.Point(924, 468)
        Me.ry7.Name = "ry7"
        Me.ry7.Size = New System.Drawing.Size(31, 30)
        Me.ry7.TabIndex = 21
        Me.ry7.Text = "Button15"
        Me.ry7.UseVisualStyleBackColor = True
        '
        'ry9
        '
        Me.ry9.Location = New System.Drawing.Point(1088, 468)
        Me.ry9.Name = "ry9"
        Me.ry9.Size = New System.Drawing.Size(31, 30)
        Me.ry9.TabIndex = 20
        Me.ry9.Text = "Button16"
        Me.ry9.UseVisualStyleBackColor = True
        '
        'y7
        '
        Me.y7.Location = New System.Drawing.Point(890, 468)
        Me.y7.Name = "y7"
        Me.y7.Size = New System.Drawing.Size(31, 30)
        Me.y7.TabIndex = 19
        Me.y7.Text = "Button17"
        Me.y7.UseVisualStyleBackColor = True
        '
        'y9
        '
        Me.y9.Location = New System.Drawing.Point(1054, 468)
        Me.y9.Name = "y9"
        Me.y9.Size = New System.Drawing.Size(31, 30)
        Me.y9.TabIndex = 18
        Me.y9.Text = "Button18"
        Me.y9.UseVisualStyleBackColor = True
        '
        'ry8
        '
        Me.ry8.Location = New System.Drawing.Point(1006, 468)
        Me.ry8.Name = "ry8"
        Me.ry8.Size = New System.Drawing.Size(31, 30)
        Me.ry8.TabIndex = 17
        Me.ry8.Text = "Button19"
        Me.ry8.UseVisualStyleBackColor = True
        '
        'y8
        '
        Me.y8.Location = New System.Drawing.Point(972, 468)
        Me.y8.Name = "y8"
        Me.y8.Size = New System.Drawing.Size(31, 30)
        Me.y8.TabIndex = 16
        Me.y8.Text = "Button20"
        Me.y8.UseVisualStyleBackColor = True
        '
        'ry6
        '
        Me.ry6.Location = New System.Drawing.Point(842, 468)
        Me.ry6.Name = "ry6"
        Me.ry6.Size = New System.Drawing.Size(31, 30)
        Me.ry6.TabIndex = 15
        Me.ry6.Text = "Button21"
        Me.ry6.UseVisualStyleBackColor = True
        '
        'y6
        '
        Me.y6.Location = New System.Drawing.Point(808, 468)
        Me.y6.Name = "y6"
        Me.y6.Size = New System.Drawing.Size(31, 30)
        Me.y6.TabIndex = 14
        Me.y6.Text = "Button22"
        Me.y6.UseVisualStyleBackColor = True
        '
        'TimerYellow
        '
        Me.TimerYellow.Enabled = True
        Me.TimerYellow.Interval = 200
        '
        'DYellow
        '
        Me.DYellow.Enabled = True
        Me.DYellow.Interval = 130
        '
        'g
        '
        Me.g.Location = New System.Drawing.Point(808, 424)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(65, 30)
        Me.g.TabIndex = 24
        Me.g.Text = "g1"
        Me.g.UseVisualStyleBackColor = True
        '
        'g2
        '
        Me.g2.Location = New System.Drawing.Point(890, 424)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(65, 30)
        Me.g2.TabIndex = 25
        Me.g2.Text = "Button4"
        Me.g2.UseVisualStyleBackColor = True
        '
        'g3
        '
        Me.g3.Location = New System.Drawing.Point(972, 424)
        Me.g3.Name = "g3"
        Me.g3.Size = New System.Drawing.Size(65, 30)
        Me.g3.TabIndex = 26
        Me.g3.Text = "Button5"
        Me.g3.UseVisualStyleBackColor = True
        '
        'g4
        '
        Me.g4.Location = New System.Drawing.Point(1054, 424)
        Me.g4.Name = "g4"
        Me.g4.Size = New System.Drawing.Size(65, 30)
        Me.g4.TabIndex = 27
        Me.g4.Text = "Button6"
        Me.g4.UseVisualStyleBackColor = True
        '
        'g5
        '
        Me.g5.Location = New System.Drawing.Point(1136, 424)
        Me.g5.Name = "g5"
        Me.g5.Size = New System.Drawing.Size(65, 30)
        Me.g5.TabIndex = 28
        Me.g5.Text = "Button7"
        Me.g5.UseVisualStyleBackColor = True
        '
        'g10
        '
        Me.g10.Location = New System.Drawing.Point(1136, 499)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(65, 30)
        Me.g10.TabIndex = 33
        Me.g10.Text = "Button8"
        Me.g10.UseVisualStyleBackColor = True
        '
        'g9
        '
        Me.g9.Location = New System.Drawing.Point(1054, 499)
        Me.g9.Name = "g9"
        Me.g9.Size = New System.Drawing.Size(65, 30)
        Me.g9.TabIndex = 32
        Me.g9.Text = "Button9"
        Me.g9.UseVisualStyleBackColor = True
        '
        'g8
        '
        Me.g8.Location = New System.Drawing.Point(972, 499)
        Me.g8.Name = "g8"
        Me.g8.Size = New System.Drawing.Size(65, 30)
        Me.g8.TabIndex = 31
        Me.g8.Text = "Button10"
        Me.g8.UseVisualStyleBackColor = True
        '
        'g7
        '
        Me.g7.Location = New System.Drawing.Point(890, 499)
        Me.g7.Name = "g7"
        Me.g7.Size = New System.Drawing.Size(65, 30)
        Me.g7.TabIndex = 30
        Me.g7.Text = "Button11"
        Me.g7.UseVisualStyleBackColor = True
        '
        'g6
        '
        Me.g6.Location = New System.Drawing.Point(808, 499)
        Me.g6.Name = "g6"
        Me.g6.Size = New System.Drawing.Size(65, 30)
        Me.g6.TabIndex = 29
        Me.g6.Text = "Button12"
        Me.g6.UseVisualStyleBackColor = True
        '
        'GreenTimer
        '
        Me.GreenTimer.Interval = 200
        '
        'sc1
        '
        Me.sc1.Location = New System.Drawing.Point(105, 400)
        Me.sc1.Name = "sc1"
        Me.sc1.Size = New System.Drawing.Size(75, 23)
        Me.sc1.TabIndex = 34
        Me.sc1.Text = "scon"
        Me.sc1.UseVisualStyleBackColor = True
        '
        'sc2
        '
        Me.sc2.Location = New System.Drawing.Point(216, 400)
        Me.sc2.Name = "sc2"
        Me.sc2.Size = New System.Drawing.Size(75, 23)
        Me.sc2.TabIndex = 35
        Me.sc2.Text = "Button4"
        Me.sc2.UseVisualStyleBackColor = True
        '
        'TimerSC
        '
        Me.TimerSC.Interval = 200
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 544)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(729, 118)
        Me.TextBox1.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 717)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sc2)
        Me.Controls.Add(Me.sc1)
        Me.Controls.Add(Me.g10)
        Me.Controls.Add(Me.g9)
        Me.Controls.Add(Me.g8)
        Me.Controls.Add(Me.g7)
        Me.Controls.Add(Me.g6)
        Me.Controls.Add(Me.g5)
        Me.Controls.Add(Me.g4)
        Me.Controls.Add(Me.g3)
        Me.Controls.Add(Me.g2)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.ry10)
        Me.Controls.Add(Me.y10)
        Me.Controls.Add(Me.ry7)
        Me.Controls.Add(Me.ry9)
        Me.Controls.Add(Me.y7)
        Me.Controls.Add(Me.y9)
        Me.Controls.Add(Me.ry8)
        Me.Controls.Add(Me.y8)
        Me.Controls.Add(Me.ry6)
        Me.Controls.Add(Me.y6)
        Me.Controls.Add(Me.ry5)
        Me.Controls.Add(Me.y5)
        Me.Controls.Add(Me.ry2)
        Me.Controls.Add(Me.ry4)
        Me.Controls.Add(Me.y2)
        Me.Controls.Add(Me.y4)
        Me.Controls.Add(Me.ry3)
        Me.Controls.Add(Me.y3)
        Me.Controls.Add(Me.ry1)
        Me.Controls.Add(Me.y1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerRed As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents y1 As Button
    Friend WithEvents ry1 As Button
    Friend WithEvents y3 As Button
    Friend WithEvents ry3 As Button
    Friend WithEvents y4 As Button
    Friend WithEvents y2 As Button
    Friend WithEvents ry4 As Button
    Friend WithEvents ry2 As Button
    Friend WithEvents y5 As Button
    Friend WithEvents ry5 As Button
    Friend WithEvents ry10 As Button
    Friend WithEvents y10 As Button
    Friend WithEvents ry7 As Button
    Friend WithEvents ry9 As Button
    Friend WithEvents y7 As Button
    Friend WithEvents y9 As Button
    Friend WithEvents ry8 As Button
    Friend WithEvents y8 As Button
    Friend WithEvents ry6 As Button
    Friend WithEvents y6 As Button
    Friend WithEvents TimerYellow As Timer
    Friend WithEvents DYellow As Timer
    Friend WithEvents g As Button
    Friend WithEvents g2 As Button
    Friend WithEvents g3 As Button
    Friend WithEvents g4 As Button
    Friend WithEvents g5 As Button
    Friend WithEvents g10 As Button
    Friend WithEvents g9 As Button
    Friend WithEvents g8 As Button
    Friend WithEvents g7 As Button
    Friend WithEvents g6 As Button
    Friend WithEvents GreenTimer As Timer
    Friend WithEvents sc1 As Button
    Friend WithEvents sc2 As Button
    Friend WithEvents TimerSC As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
