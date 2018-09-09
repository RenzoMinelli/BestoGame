<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BestoGame
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
        Me.Encontrar_Suelo_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.pnlVida = New System.Windows.Forms.Panel()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.mover_estrella = New System.Windows.Forms.Timer(Me.components)
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.Movimiento_Bala = New System.Windows.Forms.Timer(Me.components)
        Me.TransPicBox8 = New ya_ni_se.TransPicBox()
        Me.TransPicBox5 = New ya_ni_se.TransPicBox()
        Me.pbBala = New ya_ni_se.TransPicBox()
        Me.TransPicBox2 = New ya_ni_se.TransPicBox()
        Me.TransPicBox7 = New ya_ni_se.TransPicBox()
        Me.TransPicBox4 = New ya_ni_se.TransPicBox()
        Me.TransPicBox3 = New ya_ni_se.TransPicBox()
        Me.TransPicBox6 = New ya_ni_se.TransPicBox()
        Me.TransPicBox1 = New ya_ni_se.TransPicBox()
        Me.estrella = New ya_ni_se.TransPicBox()
        Me.pbNumeroEstrellas = New ya_ni_se.TransPicBox()
        CType(Me.TransPicBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNumeroEstrellas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlPiso.Location = New System.Drawing.Point(0, 456)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(1206, 142)
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
        'Encontrar_Suelo_Principal
        '
        Me.Encontrar_Suelo_Principal.Enabled = True
        Me.Encontrar_Suelo_Principal.Interval = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel4.Location = New System.Drawing.Point(363, 326)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 30)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel6.Location = New System.Drawing.Point(195, 225)
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
        'pnlVida
        '
        Me.pnlVida.BackColor = System.Drawing.Color.Lime
        Me.pnlVida.Location = New System.Drawing.Point(138, 30)
        Me.pnlVida.Name = "pnlVida"
        Me.pnlVida.Size = New System.Drawing.Size(195, 24)
        Me.pnlVida.TabIndex = 14
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(87, 64)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(30, 24)
        Me.lblNumero.TabIndex = 15
        Me.lblNumero.Text = "N°"
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.BackColor = System.Drawing.Color.Transparent
        Me.lblVida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVida.Location = New System.Drawing.Point(71, 30)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(53, 24)
        Me.lblVida.TabIndex = 17
        Me.lblVida.Text = "Vida:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(134, 180)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 73)
        Me.lblFinal.TabIndex = 28
        Me.lblFinal.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(1193, -139)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 603)
        Me.Panel9.TabIndex = 8
        Me.Panel9.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel10.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel10.Location = New System.Drawing.Point(26, 326)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(108, 28)
        Me.Panel10.TabIndex = 9
        '
        'pnlInicio
        '
        Me.pnlInicio.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlInicio.Location = New System.Drawing.Point(0, -139)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(10, 603)
        Me.pnlInicio.TabIndex = 3
        Me.pnlInicio.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel2.Location = New System.Drawing.Point(363, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 30)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel3.Location = New System.Drawing.Point(716, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 30)
        Me.Panel3.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel13.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel13.Location = New System.Drawing.Point(544, 225)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(108, 28)
        Me.Panel13.TabIndex = 12
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel14.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel14.Location = New System.Drawing.Point(716, 326)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(108, 30)
        Me.Panel14.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel5.Location = New System.Drawing.Point(885, 225)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(108, 30)
        Me.Panel5.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel8.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel8.Location = New System.Drawing.Point(1060, 322)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(108, 30)
        Me.Panel8.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel11.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.kisspng_platform_game_two_dimensional_space_tile_2d_comput_platform_5ac036eb3e40a61
        Me.Panel11.Location = New System.Drawing.Point(1060, 110)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(108, 30)
        Me.Panel11.TabIndex = 13
        '
        'mover_estrella
        '
        Me.mover_estrella.Enabled = True
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.Location = New System.Drawing.Point(696, 30)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(30, 24)
        Me.lblPuntos.TabIndex = 37
        Me.lblPuntos.Text = ": 0"
        '
        'Movimiento_Bala
        '
        Me.Movimiento_Bala.Enabled = True
        Me.Movimiento_Bala.Interval = 1
        '
        'TransPicBox8
        '
        Me.TransPicBox8.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox8.ErrorImage = Nothing
        Me.TransPicBox8.Image = Global.ya_ni_se.My.Resources.Resources.ave__1_
        Me.TransPicBox8.InitialImage = Nothing
        Me.TransPicBox8.Location = New System.Drawing.Point(544, 397)
        Me.TransPicBox8.Name = "TransPicBox8"
        Me.TransPicBox8.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox8.TabIndex = 41
        Me.TransPicBox8.TabStop = False
        '
        'TransPicBox5
        '
        Me.TransPicBox5.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox5.ErrorImage = Nothing
        Me.TransPicBox5.Image = Global.ya_ni_se.My.Resources.Resources.ave__8_
        Me.TransPicBox5.InitialImage = Nothing
        Me.TransPicBox5.Location = New System.Drawing.Point(1091, 269)
        Me.TransPicBox5.Name = "TransPicBox5"
        Me.TransPicBox5.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox5.TabIndex = 40
        Me.TransPicBox5.TabStop = False
        '
        'pbBala
        '
        Me.pbBala.BackColor = System.Drawing.Color.Transparent
        Me.pbBala.ErrorImage = Nothing
        Me.pbBala.Image = Global.ya_ni_se.My.Resources.Resources.bullet
        Me.pbBala.InitialImage = Nothing
        Me.pbBala.Location = New System.Drawing.Point(885, 180)
        Me.pbBala.Name = "pbBala"
        Me.pbBala.Size = New System.Drawing.Size(55, 37)
        Me.pbBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBala.TabIndex = 39
        Me.pbBala.TabStop = False
        '
        'TransPicBox2
        '
        Me.TransPicBox2.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox2.ErrorImage = Nothing
        Me.TransPicBox2.Image = Global.ya_ni_se.My.Resources.Resources._01
        Me.TransPicBox2.InitialImage = Nothing
        Me.TransPicBox2.Location = New System.Drawing.Point(1060, 397)
        Me.TransPicBox2.Name = "TransPicBox2"
        Me.TransPicBox2.Size = New System.Drawing.Size(49, 53)
        Me.TransPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox2.TabIndex = 30
        Me.TransPicBox2.TabStop = False
        '
        'TransPicBox7
        '
        Me.TransPicBox7.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox7.ErrorImage = Nothing
        Me.TransPicBox7.Image = Nothing
        Me.TransPicBox7.InitialImage = Nothing
        Me.TransPicBox7.Location = New System.Drawing.Point(1060, 53)
        Me.TransPicBox7.Name = "TransPicBox7"
        Me.TransPicBox7.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox7.TabIndex = 35
        Me.TransPicBox7.TabStop = False
        '
        'TransPicBox4
        '
        Me.TransPicBox4.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox4.ErrorImage = Nothing
        Me.TransPicBox4.Image = Global.ya_ni_se.My.Resources.Resources.ave__1_
        Me.TransPicBox4.InitialImage = Nothing
        Me.TransPicBox4.Location = New System.Drawing.Point(544, 53)
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
        Me.TransPicBox3.Location = New System.Drawing.Point(482, 269)
        Me.TransPicBox3.Name = "TransPicBox3"
        Me.TransPicBox3.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox3.TabIndex = 31
        Me.TransPicBox3.TabStop = False
        '
        'TransPicBox6
        '
        Me.TransPicBox6.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox6.ErrorImage = Nothing
        Me.TransPicBox6.Image = Global.ya_ni_se.My.Resources.Resources.ave__8_
        Me.TransPicBox6.InitialImage = Nothing
        Me.TransPicBox6.Location = New System.Drawing.Point(69, 269)
        Me.TransPicBox6.Name = "TransPicBox6"
        Me.TransPicBox6.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox6.TabIndex = 34
        Me.TransPicBox6.TabStop = False
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Global.ya_ni_se.My.Resources.Resources.ave__1_
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(91, 397)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 24
        Me.TransPicBox1.TabStop = False
        '
        'estrella
        '
        Me.estrella.BackColor = System.Drawing.Color.Transparent
        Me.estrella.ErrorImage = Nothing
        Me.estrella.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.estrella.InitialImage = Nothing
        Me.estrella.Location = New System.Drawing.Point(578, 284)
        Me.estrella.Name = "estrella"
        Me.estrella.Size = New System.Drawing.Size(55, 53)
        Me.estrella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.estrella.TabIndex = 36
        Me.estrella.TabStop = False
        '
        'pbNumeroEstrellas
        '
        Me.pbNumeroEstrellas.BackColor = System.Drawing.Color.Transparent
        Me.pbNumeroEstrellas.ErrorImage = Nothing
        Me.pbNumeroEstrellas.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.pbNumeroEstrellas.InitialImage = Nothing
        Me.pbNumeroEstrellas.Location = New System.Drawing.Point(663, 18)
        Me.pbNumeroEstrellas.Name = "pbNumeroEstrellas"
        Me.pbNumeroEstrellas.Size = New System.Drawing.Size(33, 36)
        Me.pbNumeroEstrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNumeroEstrellas.TabIndex = 38
        Me.pbNumeroEstrellas.TabStop = False
        '
        'BestoGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.fondito
        Me.ClientSize = New System.Drawing.Size(1203, 565)
        Me.Controls.Add(Me.TransPicBox8)
        Me.Controls.Add(Me.TransPicBox5)
        Me.Controls.Add(Me.pbBala)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.TransPicBox2)
        Me.Controls.Add(Me.TransPicBox7)
        Me.Controls.Add(Me.TransPicBox4)
        Me.Controls.Add(Me.TransPicBox3)
        Me.Controls.Add(Me.TransPicBox6)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.pnlVida)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlPiso)
        Me.Controls.Add(Me.estrella)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbNumeroEstrellas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BestoGame"
        Me.Text = "BestoGame"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.TransPicBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNumeroEstrellas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents pnlPiso As System.Windows.Forms.Panel
    Friend WithEvents Anim_Idle_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents Encontrar_Suelo_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Anim_Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents pnlVida As System.Windows.Forms.Panel
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents lblVida As System.Windows.Forms.Label
    Friend WithEvents TransPicBox1 As ya_ni_se.TransPicBox
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents TransPicBox2 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox3 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox4 As ya_ni_se.TransPicBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents pnlInicio As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents TransPicBox6 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox7 As ya_ni_se.TransPicBox
    Friend WithEvents estrella As ya_ni_se.TransPicBox
    Friend WithEvents mover_estrella As System.Windows.Forms.Timer
    Friend WithEvents lblPuntos As System.Windows.Forms.Label
    Friend WithEvents pbNumeroEstrellas As ya_ni_se.TransPicBox
    Friend WithEvents pbBala As ya_ni_se.TransPicBox
    Friend WithEvents Movimiento_Bala As System.Windows.Forms.Timer
    Friend WithEvents TransPicBox5 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox8 As ya_ni_se.TransPicBox
End Class
