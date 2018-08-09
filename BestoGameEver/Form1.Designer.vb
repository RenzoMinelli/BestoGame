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
        Me.CorrerAtras = New System.Windows.Forms.Timer(Me.components)
        Me.CorrerDelante = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento = New System.Windows.Forms.Timer(Me.components)
        Me.Descenso = New System.Windows.Forms.Timer(Me.components)
        Me.Ascenso = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Idle = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SaltoAnima = New System.Windows.Forms.Timer(Me.components)
        Me.BajoAnima = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CorrerAtras
        '
        '
        'CorrerDelante
        '
        Me.CorrerDelante.Interval = 90
        '
        'Movimiento
        '
        Me.Movimiento.Interval = 1
        '
        'Descenso
        '
        Me.Descenso.Interval = 5
        '
        'Ascenso
        '
        Me.Ascenso.Interval = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Location = New System.Drawing.Point(0, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2617, 563)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Location = New System.Drawing.Point(773, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(56, 355)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(47, 355)
        Me.Panel3.TabIndex = 3
        '
        'Idle
        '
        Me.Idle.Interval = 200
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ya_ni_se.My.Resources.Resources._01
        Me.PictureBox1.Location = New System.Drawing.Point(385, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SaltoAnima
        '
        Me.SaltoAnima.Interval = 1
        '
        'BajoAnima
        '
        Me.BajoAnima.Interval = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.Location = New System.Drawing.Point(172, 264)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(163, 34)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.Location = New System.Drawing.Point(354, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(157, 34)
        Me.Panel5.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.Location = New System.Drawing.Point(578, 202)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(157, 34)
        Me.Panel6.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 417)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CorrerAtras As System.Windows.Forms.Timer
    Friend WithEvents CorrerDelante As System.Windows.Forms.Timer
    Friend WithEvents Movimiento As System.Windows.Forms.Timer
    Friend WithEvents Descenso As System.Windows.Forms.Timer
    Friend WithEvents Ascenso As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Idle As System.Windows.Forms.Timer
    Friend WithEvents SaltoAnima As System.Windows.Forms.Timer
    Friend WithEvents BajoAnima As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel

End Class
