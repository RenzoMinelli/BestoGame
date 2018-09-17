<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinglePlayerMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSinglePlayerMode))
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
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.Movimiento_Bala = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.cosaRandom = New System.Windows.Forms.Timer(Me.components)
        Me.lblPowerUp = New System.Windows.Forms.Label()
        Me.pbCosaR = New System.Windows.Forms.PictureBox()
        Me.estrella = New System.Windows.Forms.PictureBox()
        Me.principal = New ya_ni_se.TransPicBox()
        Me.pbBala = New ya_ni_se.TransPicBox()
        Me.TransPicBox7 = New ya_ni_se.TransPicBox()
        Me.TransPicBox9 = New ya_ni_se.TransPicBox()
        Me.TransPicBox11 = New ya_ni_se.TransPicBox()
        Me.TransPicBox4 = New ya_ni_se.TransPicBox()
        Me.TransPicBox10 = New ya_ni_se.TransPicBox()
        Me.TransPicBox6 = New ya_ni_se.TransPicBox()
        Me.TransPicBox3 = New ya_ni_se.TransPicBox()
        Me.TransPicBox5 = New ya_ni_se.TransPicBox()
        Me.TransPicBox8 = New ya_ni_se.TransPicBox()
        Me.TransPicBox1 = New ya_ni_se.TransPicBox()
        Me.pbNumeroEstrellas = New ya_ni_se.TransPicBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        CType(Me.pbCosaR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNumeroEstrellas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimiento_Principal
        '
        Me.Movimiento_Principal.Enabled = True
        Me.Movimiento_Principal.Interval = 5
        '
        'pnlPiso
        '
        Me.pnlPiso.BackColor = System.Drawing.Color.Black
        Me.pnlPiso.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.pnlPiso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPiso.Location = New System.Drawing.Point(0, 570)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(1223, 109)
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
        Me.Panel4.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel4.Location = New System.Drawing.Point(366, 440)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 30)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel6.Location = New System.Drawing.Point(198, 339)
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
        Me.pnlVida.Location = New System.Drawing.Point(86, 30)
        Me.pnlVida.Name = "pnlVida"
        Me.pnlVida.Size = New System.Drawing.Size(100, 24)
        Me.pnlVida.TabIndex = 14
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(27, 68)
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
        Me.lblVida.Location = New System.Drawing.Point(27, 30)
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
        Me.lblFinal.Location = New System.Drawing.Point(93, 50)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 73)
        Me.lblFinal.TabIndex = 28
        Me.lblFinal.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Location = New System.Drawing.Point(1217, -139)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(40, 721)
        Me.Panel9.TabIndex = 8
        Me.Panel9.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel10.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel10.Location = New System.Drawing.Point(29, 440)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(108, 28)
        Me.Panel10.TabIndex = 9
        '
        'pnlInicio
        '
        Me.pnlInicio.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlInicio.Location = New System.Drawing.Point(0, -139)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(10, 727)
        Me.pnlInicio.TabIndex = 3
        Me.pnlInicio.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel2.Location = New System.Drawing.Point(366, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 30)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel3.Location = New System.Drawing.Point(719, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 30)
        Me.Panel3.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel13.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel13.Location = New System.Drawing.Point(547, 339)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(108, 28)
        Me.Panel13.TabIndex = 12
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel14.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel14.Location = New System.Drawing.Point(719, 440)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(108, 30)
        Me.Panel14.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel5.Location = New System.Drawing.Point(888, 339)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(108, 30)
        Me.Panel5.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel8.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel8.Location = New System.Drawing.Point(1063, 438)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(108, 30)
        Me.Panel8.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel11.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel11.Location = New System.Drawing.Point(1063, 224)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(108, 30)
        Me.Panel11.TabIndex = 13
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.Location = New System.Drawing.Point(57, 107)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel1.Location = New System.Drawing.Point(547, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 30)
        Me.Panel1.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel7.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel7.Location = New System.Drawing.Point(888, 107)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(108, 30)
        Me.Panel7.TabIndex = 15
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel12.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel12.Location = New System.Drawing.Point(198, 107)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(108, 30)
        Me.Panel12.TabIndex = 15
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel15.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel15.Location = New System.Drawing.Point(31, 224)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(108, 30)
        Me.Panel15.TabIndex = 9
        '
        'cosaRandom
        '
        Me.cosaRandom.Interval = 10000
        '
        'lblPowerUp
        '
        Me.lblPowerUp.AutoSize = True
        Me.lblPowerUp.BackColor = System.Drawing.Color.Transparent
        Me.lblPowerUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerUp.ForeColor = System.Drawing.Color.White
        Me.lblPowerUp.Location = New System.Drawing.Point(213, 30)
        Me.lblPowerUp.Name = "lblPowerUp"
        Me.lblPowerUp.Size = New System.Drawing.Size(0, 24)
        Me.lblPowerUp.TabIndex = 46
        '
        'pbCosaR
        '
        Me.pbCosaR.Image = Global.ya_ni_se.My.Resources.Resources.Block
        Me.pbCosaR.Location = New System.Drawing.Point(584, 294)
        Me.pbCosaR.Name = "pbCosaR"
        Me.pbCosaR.Size = New System.Drawing.Size(43, 39)
        Me.pbCosaR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCosaR.TabIndex = 47
        Me.pbCosaR.TabStop = False
        '
        'estrella
        '
        Me.estrella.BackColor = System.Drawing.Color.Transparent
        Me.estrella.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.estrella.Location = New System.Drawing.Point(771, 155)
        Me.estrella.Name = "estrella"
        Me.estrella.Size = New System.Drawing.Size(56, 53)
        Me.estrella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.estrella.TabIndex = 48
        Me.estrella.TabStop = False
        '
        'principal
        '
        Me.principal.BackColor = System.Drawing.Color.Transparent
        Me.principal.ErrorImage = Nothing
        Me.principal.Image = Global.ya_ni_se.My.Resources.Resources.idle1
        Me.principal.InitialImage = Nothing
        Me.principal.Location = New System.Drawing.Point(1071, 504)
        Me.principal.Name = "principal"
        Me.principal.Size = New System.Drawing.Size(49, 53)
        Me.principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.principal.TabIndex = 30
        Me.principal.TabStop = False
        '
        'pbBala
        '
        Me.pbBala.BackColor = System.Drawing.Color.Transparent
        Me.pbBala.ErrorImage = Nothing
        Me.pbBala.Image = Global.ya_ni_se.My.Resources.Resources.bullet
        Me.pbBala.InitialImage = Nothing
        Me.pbBala.Location = New System.Drawing.Point(888, 294)
        Me.pbBala.Name = "pbBala"
        Me.pbBala.Size = New System.Drawing.Size(55, 37)
        Me.pbBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBala.TabIndex = 39
        Me.pbBala.TabStop = False
        '
        'TransPicBox7
        '
        Me.TransPicBox7.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox7.ErrorImage = Nothing
        Me.TransPicBox7.Image = Nothing
        Me.TransPicBox7.InitialImage = Nothing
        Me.TransPicBox7.Location = New System.Drawing.Point(1063, 167)
        Me.TransPicBox7.Name = "TransPicBox7"
        Me.TransPicBox7.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox7.TabIndex = 35
        Me.TransPicBox7.TabStop = False
        '
        'TransPicBox9
        '
        Me.TransPicBox9.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox9.ErrorImage = Nothing
        Me.TransPicBox9.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox9.InitialImage = Nothing
        Me.TransPicBox9.Location = New System.Drawing.Point(923, 50)
        Me.TransPicBox9.Name = "TransPicBox9"
        Me.TransPicBox9.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox9.TabIndex = 42
        Me.TransPicBox9.TabStop = False
        '
        'TransPicBox11
        '
        Me.TransPicBox11.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox11.ErrorImage = Nothing
        Me.TransPicBox11.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox11.InitialImage = Nothing
        Me.TransPicBox11.Location = New System.Drawing.Point(538, 50)
        Me.TransPicBox11.Name = "TransPicBox11"
        Me.TransPicBox11.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox11.TabIndex = 44
        Me.TransPicBox11.TabStop = False
        '
        'TransPicBox4
        '
        Me.TransPicBox4.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox4.ErrorImage = Nothing
        Me.TransPicBox4.Image = Global.ya_ni_se.My.Resources.Resources.ave1
        Me.TransPicBox4.InitialImage = Nothing
        Me.TransPicBox4.Location = New System.Drawing.Point(547, 167)
        Me.TransPicBox4.Name = "TransPicBox4"
        Me.TransPicBox4.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox4.TabIndex = 32
        Me.TransPicBox4.TabStop = False
        '
        'TransPicBox10
        '
        Me.TransPicBox10.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox10.ErrorImage = Nothing
        Me.TransPicBox10.Image = Global.ya_ni_se.My.Resources.Resources.ave1
        Me.TransPicBox10.InitialImage = Nothing
        Me.TransPicBox10.Location = New System.Drawing.Point(82, 167)
        Me.TransPicBox10.Name = "TransPicBox10"
        Me.TransPicBox10.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox10.TabIndex = 43
        Me.TransPicBox10.TabStop = False
        '
        'TransPicBox6
        '
        Me.TransPicBox6.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox6.ErrorImage = Nothing
        Me.TransPicBox6.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox6.InitialImage = Nothing
        Me.TransPicBox6.Location = New System.Drawing.Point(72, 383)
        Me.TransPicBox6.Name = "TransPicBox6"
        Me.TransPicBox6.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox6.TabIndex = 34
        Me.TransPicBox6.TabStop = False
        '
        'TransPicBox3
        '
        Me.TransPicBox3.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox3.ErrorImage = Nothing
        Me.TransPicBox3.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox3.InitialImage = Nothing
        Me.TransPicBox3.Location = New System.Drawing.Point(485, 383)
        Me.TransPicBox3.Name = "TransPicBox3"
        Me.TransPicBox3.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox3.TabIndex = 31
        Me.TransPicBox3.TabStop = False
        '
        'TransPicBox5
        '
        Me.TransPicBox5.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox5.ErrorImage = Nothing
        Me.TransPicBox5.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox5.InitialImage = Nothing
        Me.TransPicBox5.Location = New System.Drawing.Point(1087, 383)
        Me.TransPicBox5.Name = "TransPicBox5"
        Me.TransPicBox5.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox5.TabIndex = 40
        Me.TransPicBox5.TabStop = False
        '
        'TransPicBox8
        '
        Me.TransPicBox8.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox8.ErrorImage = Nothing
        Me.TransPicBox8.Image = Global.ya_ni_se.My.Resources.Resources.ave1
        Me.TransPicBox8.InitialImage = Nothing
        Me.TransPicBox8.Location = New System.Drawing.Point(571, 514)
        Me.TransPicBox8.Name = "TransPicBox8"
        Me.TransPicBox8.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox8.TabIndex = 41
        Me.TransPicBox8.TabStop = False
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Global.ya_ni_se.My.Resources.Resources.ave1
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(112, 513)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 24
        Me.TransPicBox1.TabStop = False
        '
        'pbNumeroEstrellas
        '
        Me.pbNumeroEstrellas.BackColor = System.Drawing.Color.Transparent
        Me.pbNumeroEstrellas.ErrorImage = Nothing
        Me.pbNumeroEstrellas.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.pbNumeroEstrellas.InitialImage = Nothing
        Me.pbNumeroEstrellas.Location = New System.Drawing.Point(24, 95)
        Me.pbNumeroEstrellas.Name = "pbNumeroEstrellas"
        Me.pbNumeroEstrellas.Size = New System.Drawing.Size(33, 36)
        Me.pbNumeroEstrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNumeroEstrellas.TabIndex = 38
        Me.pbNumeroEstrellas.TabStop = False
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.BackColor = System.Drawing.Color.Transparent
        Me.lblPiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPiso.Location = New System.Drawing.Point(394, 30)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(53, 24)
        Me.lblPiso.TabIndex = 49
        Me.lblPiso.Text = "Vida:"
        '
        'frmSinglePlayerMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.fondito
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 679)
        Me.Controls.Add(Me.lblPiso)
        Me.Controls.Add(Me.principal)
        Me.Controls.Add(Me.lblPowerUp)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbBala)
        Me.Controls.Add(Me.TransPicBox7)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlPiso)
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
        Me.Controls.Add(Me.TransPicBox9)
        Me.Controls.Add(Me.TransPicBox11)
        Me.Controls.Add(Me.TransPicBox4)
        Me.Controls.Add(Me.TransPicBox10)
        Me.Controls.Add(Me.TransPicBox6)
        Me.Controls.Add(Me.TransPicBox3)
        Me.Controls.Add(Me.TransPicBox5)
        Me.Controls.Add(Me.TransPicBox8)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.pnlVida)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.pbNumeroEstrellas)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.estrella)
        Me.Controls.Add(Me.pbCosaR)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSinglePlayerMode"
        Me.Text = "SinglePlayerMode"
        Me.TransparencyKey = System.Drawing.Color.Gray
        CType(Me.pbCosaR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents principal As ya_ni_se.TransPicBox
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
    Friend WithEvents lblPuntos As System.Windows.Forms.Label
    Friend WithEvents pbNumeroEstrellas As ya_ni_se.TransPicBox
    Friend WithEvents pbBala As ya_ni_se.TransPicBox
    Friend WithEvents Movimiento_Bala As System.Windows.Forms.Timer
    Friend WithEvents TransPicBox5 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox8 As ya_ni_se.TransPicBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents TransPicBox9 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox10 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox11 As ya_ni_se.TransPicBox
    Friend WithEvents cosaRandom As System.Windows.Forms.Timer
    Friend WithEvents lblPowerUp As System.Windows.Forms.Label
    Friend WithEvents pbCosaR As System.Windows.Forms.PictureBox
    Friend WithEvents estrella As System.Windows.Forms.PictureBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
End Class
