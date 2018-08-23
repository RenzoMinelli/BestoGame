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
        Me.Movimiento_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Anim_Idle_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Movimiento_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Encontrar_Suelo_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransPicBox2 = New ya_ni_se.TransPicBox()
        Me.enemigo2 = New ya_ni_se.TransPicBox()
        Me.enemigo1 = New ya_ni_se.TransPicBox()
        Me.TransPicBox1 = New ya_ni_se.TransPicBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimiento_Principal
        '
        Me.Movimiento_Principal.Enabled = True
        Me.Movimiento_Principal.Interval = 1
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
        Me.Panel2.Location = New System.Drawing.Point(773, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(56, 184)
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
        'Anim_Idle_Principal
        '
        Me.Anim_Idle_Principal.Enabled = True
        Me.Anim_Idle_Principal.Interval = 180
        '
        'Anim_Movimiento_Principal
        '
        Me.Anim_Movimiento_Principal.Enabled = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.Location = New System.Drawing.Point(412, 278)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(101, 28)
        Me.Panel5.TabIndex = 6
        '
        'Encontrar_Suelo_Principal
        '
        Me.Encontrar_Suelo_Principal.Enabled = True
        Me.Encontrar_Suelo_Principal.Interval = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.Location = New System.Drawing.Point(659, 169)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 34)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.Location = New System.Drawing.Point(560, 233)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 34)
        Me.Panel6.TabIndex = 8
        '
        'Movimiento_Enemigo
        '
        Me.Movimiento_Enemigo.Enabled = True
        Me.Movimiento_Enemigo.Interval = 50
        '
        'Anim_Movimiento_Enemigo
        '
        Me.Anim_Movimiento_Enemigo.Enabled = True
        Me.Anim_Movimiento_Enemigo.Interval = 120
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Chartreuse
        Me.Panel7.Location = New System.Drawing.Point(138, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(195, 24)
        Me.Panel7.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "N°"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Vida:"
        '
        'TransPicBox2
        '
        Me.TransPicBox2.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox2.ErrorImage = Nothing
        Me.TransPicBox2.Image = Nothing
        Me.TransPicBox2.InitialImage = Nothing
        Me.TransPicBox2.Location = New System.Drawing.Point(284, 294)
        Me.TransPicBox2.Name = "TransPicBox2"
        Me.TransPicBox2.Size = New System.Drawing.Size(49, 53)
        Me.TransPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox2.TabIndex = 27
        Me.TransPicBox2.TabStop = False
        '
        'enemigo2
        '
        Me.enemigo2.BackColor = System.Drawing.Color.Transparent
        Me.enemigo2.ErrorImage = Nothing
        Me.enemigo2.Image = Nothing
        Me.enemigo2.InitialImage = Nothing
        Me.enemigo2.Location = New System.Drawing.Point(222, 294)
        Me.enemigo2.Name = "enemigo2"
        Me.enemigo2.Size = New System.Drawing.Size(49, 53)
        Me.enemigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemigo2.TabIndex = 26
        Me.enemigo2.TabStop = False
        '
        'enemigo1
        '
        Me.enemigo1.BackColor = System.Drawing.Color.Transparent
        Me.enemigo1.ErrorImage = Nothing
        Me.enemigo1.Image = Nothing
        Me.enemigo1.InitialImage = Nothing
        Me.enemigo1.Location = New System.Drawing.Point(669, 294)
        Me.enemigo1.Name = "enemigo1"
        Me.enemigo1.Size = New System.Drawing.Size(49, 53)
        Me.enemigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemigo1.TabIndex = 25
        Me.enemigo1.TabStop = False
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Nothing
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(425, 105)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(49, 53)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 24
        Me.TransPicBox1.TabStop = False
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(301, 147)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 73)
        Me.lblFinal.TabIndex = 28
        Me.lblFinal.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 460)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.TransPicBox2)
        Me.Controls.Add(Me.enemigo2)
        Me.Controls.Add(Me.enemigo1)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Anim_Idle_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Encontrar_Suelo_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Anim_Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransPicBox1 As ya_ni_se.TransPicBox
    Friend WithEvents enemigo1 As ya_ni_se.TransPicBox
    Friend WithEvents enemigo2 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox2 As ya_ni_se.TransPicBox
    Friend WithEvents lblFinal As System.Windows.Forms.Label

End Class
