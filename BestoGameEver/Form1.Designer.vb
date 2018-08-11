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
        Me.Anim_Correr_Izquierda_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Correr_Derecha_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento_Lateral = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento_Descenso = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento_Ascenso = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Anim_Idle_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Anim_Ascenso_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Descenso_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Encontrar_Suelo = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.enemigo = New System.Windows.Forms.PictureBox()
        Me.Anim_Idle_Enemigo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Anim_Correr_Izquierda_Principal
        '
        '
        'Anim_Correr_Derecha_Principal
        '
        Me.Anim_Correr_Derecha_Principal.Interval = 90
        '
        'Movimiento_Lateral
        '
        Me.Movimiento_Lateral.Interval = 1
        '
        'Movimiento_Descenso
        '
        Me.Movimiento_Descenso.Interval = 5
        '
        'Movimiento_Ascenso
        '
        Me.Movimiento_Ascenso.Interval = 5
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
        'Anim_Idle_Principal
        '
        Me.Anim_Idle_Principal.Interval = 200
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ya_ni_se.My.Resources.Resources._01
        Me.PictureBox1.Location = New System.Drawing.Point(509, 300)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Anim_Ascenso_Principal
        '
        Me.Anim_Ascenso_Principal.Interval = 1
        '
        'Anim_Descenso_Principal
        '
        Me.Anim_Descenso_Principal.Interval = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.Location = New System.Drawing.Point(259, 198)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(101, 34)
        Me.Panel5.TabIndex = 6
        '
        'Encontrar_Suelo
        '
        Me.Encontrar_Suelo.Enabled = True
        Me.Encontrar_Suelo.Interval = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.Location = New System.Drawing.Point(509, 111)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 34)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.Location = New System.Drawing.Point(411, 198)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 34)
        Me.Panel6.TabIndex = 8
        '
        'enemigo
        '
        Me.enemigo.BackColor = System.Drawing.Color.Transparent
        Me.enemigo.Location = New System.Drawing.Point(186, 298)
        Me.enemigo.Name = "enemigo"
        Me.enemigo.Size = New System.Drawing.Size(52, 56)
        Me.enemigo.TabIndex = 9
        Me.enemigo.TabStop = False
        '
        'Anim_Idle_Enemigo
        '
        Me.Anim_Idle_Enemigo.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 417)
        Me.Controls.Add(Me.enemigo)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Anim_Correr_Izquierda_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Correr_Derecha_Principal As System.Windows.Forms.Timer
    Friend WithEvents Movimiento_Lateral As System.Windows.Forms.Timer
    Friend WithEvents Movimiento_Descenso As System.Windows.Forms.Timer
    Friend WithEvents Movimiento_Ascenso As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Anim_Idle_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Ascenso_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Descenso_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Encontrar_Suelo As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents enemigo As System.Windows.Forms.PictureBox
    Friend WithEvents Anim_Idle_Enemigo As System.Windows.Forms.Timer

End Class
