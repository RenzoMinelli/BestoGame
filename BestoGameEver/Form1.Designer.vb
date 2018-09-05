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
        Me.pnlPiso = New System.Windows.Forms.Panel()
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
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.TransPicBox2 = New ya_ni_se.TransPicBox()
        Me.TransPicBox1 = New ya_ni_se.TransPicBox()
        Me.TransPicBox4 = New ya_ni_se.TransPicBox()
        Me.TransPicBox3 = New ya_ni_se.TransPicBox()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimiento_Principal
        '
        Me.Movimiento_Principal.Enabled = True
        Me.Movimiento_Principal.Interval = 1
        '
        'pnlPiso
        '
        Me.pnlPiso.BackColor = System.Drawing.Color.Transparent
        Me.pnlPiso.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.pnlPiso.Location = New System.Drawing.Point(0, 353)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(1206, 199)
        Me.pnlPiso.TabIndex = 1
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
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(901, 270)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(88, 82)
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
        Me.Panel4.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel4.Location = New System.Drawing.Point(371, 255)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 30)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel6.Location = New System.Drawing.Point(225, 187)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 28)
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
        Me.Panel7.BackColor = System.Drawing.Color.Lime
        Me.Panel7.Location = New System.Drawing.Point(138, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(195, 24)
        Me.Panel7.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Vida:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(307, 79)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 73)
        Me.lblFinal.TabIndex = 28
        Me.lblFinal.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel8.Location = New System.Drawing.Point(901, 211)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(88, 86)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(901, 147)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(88, 86)
        Me.Panel9.TabIndex = 8
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel10.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel10.Location = New System.Drawing.Point(41, 255)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(108, 28)
        Me.Panel10.TabIndex = 9
        '
        'pnlInicio
        '
        Me.pnlInicio.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlInicio.Location = New System.Drawing.Point(0, 1)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(20, 364)
        Me.pnlInicio.TabIndex = 3
        Me.pnlInicio.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(41, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 28)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel2.Location = New System.Drawing.Point(371, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 30)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel3.Location = New System.Drawing.Point(695, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 30)
        Me.Panel3.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel13.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel13.Location = New System.Drawing.Point(549, 187)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(108, 28)
        Me.Panel13.TabIndex = 12
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel14.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel14.Location = New System.Drawing.Point(695, 255)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(108, 30)
        Me.Panel14.TabIndex = 11
        '
        'TransPicBox2
        '
        Me.TransPicBox2.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox2.ErrorImage = Nothing
        Me.TransPicBox2.Image = Nothing
        Me.TransPicBox2.InitialImage = Nothing
        Me.TransPicBox2.Location = New System.Drawing.Point(403, 180)
        Me.TransPicBox2.Name = "TransPicBox2"
        Me.TransPicBox2.Size = New System.Drawing.Size(49, 53)
        Me.TransPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox2.TabIndex = 30
        Me.TransPicBox2.TabStop = False
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Nothing
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(41, 299)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 24
        Me.TransPicBox1.TabStop = False
        '
        'TransPicBox4
        '
        Me.TransPicBox4.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox4.ErrorImage = Nothing
        Me.TransPicBox4.Image = Nothing
        Me.TransPicBox4.InitialImage = Nothing
        Me.TransPicBox4.Location = New System.Drawing.Point(840, 64)
        Me.TransPicBox4.Name = "TransPicBox4"
        Me.TransPicBox4.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox4.TabIndex = 32
        Me.TransPicBox4.TabStop = False
        '
        'TransPicBox3
        '
        Me.TransPicBox3.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox3.ErrorImage = Nothing
        Me.TransPicBox3.Image = Global.ya_ni_se.My.Resources.Resources.ave__8_
        Me.TransPicBox3.InitialImage = Nothing
        Me.TransPicBox3.Location = New System.Drawing.Point(840, 201)
        Me.TransPicBox3.Name = "TransPicBox3"
        Me.TransPicBox3.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox3.TabIndex = 31
        Me.TransPicBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.fondito
        Me.ClientSize = New System.Drawing.Size(1203, 460)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.TransPicBox2)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlPiso)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.TransPicBox4)
        Me.Controls.Add(Me.TransPicBox3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents pnlPiso As System.Windows.Forms.Panel
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
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents TransPicBox2 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox3 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox4 As ya_ni_se.TransPicBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pnlInicio As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel

End Class
