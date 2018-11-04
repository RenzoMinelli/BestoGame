<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiPlayerMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiPlayerMode))
        Me.Movimiento_Bala = New System.Windows.Forms.Timer(Me.components)
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.pnlFinal = New System.Windows.Forms.Panel()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pnlVida = New System.Windows.Forms.Panel()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.Anim_Movimiento_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Encontrar_Suelo_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Idle_Principal = New System.Windows.Forms.Timer(Me.components)
        Me.Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.Anim_Movimiento_Enemigo = New System.Windows.Forms.Timer(Me.components)
        Me.lblNumeroEstrella2 = New System.Windows.Forms.Label()
        Me.lblVida2 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.pnlVida2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlPiso = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnRegistrar2 = New System.Windows.Forms.Button()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblRegistro2 = New System.Windows.Forms.Label()
        Me.txbNombre2 = New ya_ni_se.PlaceHolder()
        Me.txbNombre = New ya_ni_se.PlaceHolder()
        Me.principal2 = New ya_ni_se.TransPicBox()
        Me.principal = New ya_ni_se.TransPicBox()
        Me.pbBala = New ya_ni_se.TransPicBox()
        Me.TransPicBox3 = New ya_ni_se.TransPicBox()
        Me.TransPicBox1 = New ya_ni_se.TransPicBox()
        Me.TransPicBox5 = New ya_ni_se.TransPicBox()
        Me.TransPicBox7 = New ya_ni_se.TransPicBox()
        Me.TransPicBox2 = New ya_ni_se.TransPicBox()
        Me.TransPicBox9 = New ya_ni_se.TransPicBox()
        Me.pbNumeroEstrellas = New ya_ni_se.TransPicBox()
        Me.pbNumeroEstrella2 = New ya_ni_se.TransPicBox()
        Me.estrella = New ya_ni_se.TransPicBox()
        Me.txbCedula = New ya_ni_se.PlaceHolder()
        Me.txbCedula2 = New ya_ni_se.PlaceHolder()
        CType(Me.principal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNumeroEstrellas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNumeroEstrella2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimiento_Bala
        '
        Me.Movimiento_Bala.Interval = 1
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.Location = New System.Drawing.Point(130, 78)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(30, 24)
        Me.lblPuntos.TabIndex = 73
        Me.lblPuntos.Text = ": 0"
        '
        'pnlFinal
        '
        Me.pnlFinal.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlFinal.Location = New System.Drawing.Point(1203, -136)
        Me.pnlFinal.Name = "pnlFinal"
        Me.pnlFinal.Size = New System.Drawing.Size(10, 705)
        Me.pnlFinal.TabIndex = 49
        Me.pnlFinal.Visible = False
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(78, 78)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 73)
        Me.lblFinal.TabIndex = 66
        Me.lblFinal.Visible = False
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.BackColor = System.Drawing.Color.Transparent
        Me.lblVida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVida.Location = New System.Drawing.Point(32, 36)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(53, 24)
        Me.lblVida.TabIndex = 64
        Me.lblVida.Text = "Vida:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(32, 60)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(30, 24)
        Me.lblNumero.TabIndex = 63
        Me.lblNumero.Text = "N°"
        '
        'pnlVida
        '
        Me.pnlVida.BackColor = System.Drawing.Color.Lime
        Me.pnlVida.Location = New System.Drawing.Point(91, 36)
        Me.pnlVida.Name = "pnlVida"
        Me.pnlVida.Size = New System.Drawing.Size(100, 24)
        Me.pnlVida.TabIndex = 60
        '
        'pnlInicio
        '
        Me.pnlInicio.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlInicio.Location = New System.Drawing.Point(-7, -136)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(13, 708)
        Me.pnlInicio.TabIndex = 46
        Me.pnlInicio.Visible = False
        '
        'Anim_Movimiento_Principal
        '
        '
        'Encontrar_Suelo_Principal
        '
        Me.Encontrar_Suelo_Principal.Interval = 1
        '
        'Movimiento_Principal
        '
        Me.Movimiento_Principal.Interval = 1
        '
        'Anim_Idle_Principal
        '
        Me.Anim_Idle_Principal.Interval = 180
        '
        'Movimiento_Enemigo
        '
        Me.Movimiento_Enemigo.Interval = 50
        '
        'Anim_Movimiento_Enemigo
        '
        Me.Anim_Movimiento_Enemigo.Interval = 120
        '
        'lblNumeroEstrella2
        '
        Me.lblNumeroEstrella2.AutoSize = True
        Me.lblNumeroEstrella2.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroEstrella2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroEstrella2.Location = New System.Drawing.Point(1110, 78)
        Me.lblNumeroEstrella2.Name = "lblNumeroEstrella2"
        Me.lblNumeroEstrella2.Size = New System.Drawing.Size(30, 24)
        Me.lblNumeroEstrella2.TabIndex = 85
        Me.lblNumeroEstrella2.Text = ": 0"
        '
        'lblVida2
        '
        Me.lblVida2.AutoSize = True
        Me.lblVida2.BackColor = System.Drawing.Color.Transparent
        Me.lblVida2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVida2.Location = New System.Drawing.Point(1012, 36)
        Me.lblVida2.Name = "lblVida2"
        Me.lblVida2.Size = New System.Drawing.Size(53, 24)
        Me.lblVida2.TabIndex = 84
        Me.lblVida2.Text = "Vida:"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero2.Location = New System.Drawing.Point(1012, 60)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(30, 24)
        Me.lblNumero2.TabIndex = 83
        Me.lblNumero2.Text = "N°"
        '
        'pnlVida2
        '
        Me.pnlVida2.BackColor = System.Drawing.Color.Lime
        Me.pnlVida2.Location = New System.Drawing.Point(1071, 36)
        Me.pnlVida2.Name = "pnlVida2"
        Me.pnlVida2.Size = New System.Drawing.Size(100, 24)
        Me.pnlVida2.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "JUGADOR 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(981, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "JUGADOR 2"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel15.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel15.Location = New System.Drawing.Point(36, 227)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(108, 30)
        Me.Panel15.TabIndex = 51
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel12.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel12.Location = New System.Drawing.Point(203, 110)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(108, 30)
        Me.Panel12.TabIndex = 61
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel7.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel7.Location = New System.Drawing.Point(893, 110)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(108, 30)
        Me.Panel7.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel1.Location = New System.Drawing.Point(552, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 30)
        Me.Panel1.TabIndex = 59
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel4.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel4.Location = New System.Drawing.Point(371, 443)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 30)
        Me.Panel4.TabIndex = 47
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel6.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel6.Location = New System.Drawing.Point(203, 342)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 28)
        Me.Panel6.TabIndex = 48
        '
        'pnlPiso
        '
        Me.pnlPiso.BackColor = System.Drawing.Color.Black
        Me.pnlPiso.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.pnlPiso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPiso.Location = New System.Drawing.Point(0, 565)
        Me.pnlPiso.Name = "pnlPiso"
        Me.pnlPiso.Size = New System.Drawing.Size(1213, 104)
        Me.pnlPiso.TabIndex = 45
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel8.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel8.Location = New System.Drawing.Point(1068, 441)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(108, 30)
        Me.Panel8.TabIndex = 54
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel5.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel5.Location = New System.Drawing.Point(893, 342)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(108, 30)
        Me.Panel5.TabIndex = 56
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel10.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel10.Location = New System.Drawing.Point(34, 443)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(108, 28)
        Me.Panel10.TabIndex = 52
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel14.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel14.Location = New System.Drawing.Point(724, 443)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(108, 30)
        Me.Panel14.TabIndex = 53
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel13.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel13.Location = New System.Drawing.Point(552, 342)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(108, 28)
        Me.Panel13.TabIndex = 55
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel11.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel11.Location = New System.Drawing.Point(1068, 227)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(108, 30)
        Me.Panel11.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel3.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel3.Location = New System.Drawing.Point(724, 227)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 30)
        Me.Panel3.TabIndex = 57
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel2.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.plataforma
        Me.Panel2.Location = New System.Drawing.Point(371, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 30)
        Me.Panel2.TabIndex = 50
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(624, 316)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(145, 32)
        Me.btnRegistrar.TabIndex = 92
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        Me.btnRegistrar.Visible = False
        '
        'btnRegistrar2
        '
        Me.btnRegistrar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar2.Location = New System.Drawing.Point(624, 469)
        Me.btnRegistrar2.Name = "btnRegistrar2"
        Me.btnRegistrar2.Size = New System.Drawing.Size(145, 32)
        Me.btnRegistrar2.TabIndex = 95
        Me.btnRegistrar2.Text = "Registrar"
        Me.btnRegistrar2.UseVisualStyleBackColor = True
        Me.btnRegistrar2.Visible = False
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.Location = New System.Drawing.Point(306, 316)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(131, 29)
        Me.lblRegistro.TabIndex = 96
        Me.lblRegistro.Text = "Registrado"
        Me.lblRegistro.Visible = False
        '
        'lblRegistro2
        '
        Me.lblRegistro2.AutoSize = True
        Me.lblRegistro2.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro2.Location = New System.Drawing.Point(306, 470)
        Me.lblRegistro2.Name = "lblRegistro2"
        Me.lblRegistro2.Size = New System.Drawing.Size(131, 29)
        Me.lblRegistro2.TabIndex = 97
        Me.lblRegistro2.Text = "Registrado"
        Me.lblRegistro2.Visible = False
        '
        'txbNombre2
        '
        Me.txbNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre2.Location = New System.Drawing.Point(82, 468)
        Me.txbNombre2.Name = "txbNombre2"
        Me.txbNombre2.Size = New System.Drawing.Size(226, 31)
        Me.txbNombre2.TabIndex = 100
        Me.txbNombre2.Visible = False
        Me.txbNombre2.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbNombre2.WaterMarkText = "Ingrese su Nombre"
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(82, 314)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(226, 31)
        Me.txbNombre.TabIndex = 98
        Me.txbNombre.Visible = False
        Me.txbNombre.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbNombre.WaterMarkText = "Ingrese su Nombre"
        '
        'principal2
        '
        Me.principal2.BackColor = System.Drawing.Color.Transparent
        Me.principal2.ErrorImage = Nothing
        Me.principal2.Image = Global.ya_ni_se.My.Resources.Resources.idle11
        Me.principal2.InitialImage = Nothing
        Me.principal2.Location = New System.Drawing.Point(899, 512)
        Me.principal2.Name = "principal2"
        Me.principal2.Size = New System.Drawing.Size(49, 53)
        Me.principal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.principal2.TabIndex = 81
        Me.principal2.TabStop = False
        '
        'principal
        '
        Me.principal.BackColor = System.Drawing.Color.Transparent
        Me.principal.ErrorImage = Nothing
        Me.principal.Image = Global.ya_ni_se.My.Resources.Resources.idle1
        Me.principal.InitialImage = Nothing
        Me.principal.Location = New System.Drawing.Point(954, 513)
        Me.principal.Name = "principal"
        Me.principal.Size = New System.Drawing.Size(49, 53)
        Me.principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.principal.TabIndex = 67
        Me.principal.TabStop = False
        '
        'pbBala
        '
        Me.pbBala.BackColor = System.Drawing.Color.Transparent
        Me.pbBala.ErrorImage = Nothing
        Me.pbBala.Image = Global.ya_ni_se.My.Resources.Resources.bullet
        Me.pbBala.InitialImage = Nothing
        Me.pbBala.Location = New System.Drawing.Point(893, 297)
        Me.pbBala.Name = "pbBala"
        Me.pbBala.Size = New System.Drawing.Size(55, 37)
        Me.pbBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBala.TabIndex = 75
        Me.pbBala.TabStop = False
        '
        'TransPicBox3
        '
        Me.TransPicBox3.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox3.ErrorImage = Nothing
        Me.TransPicBox3.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox3.InitialImage = Nothing
        Me.TransPicBox3.Location = New System.Drawing.Point(490, 386)
        Me.TransPicBox3.Name = "TransPicBox3"
        Me.TransPicBox3.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox3.TabIndex = 68
        Me.TransPicBox3.TabStop = False
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Global.ya_ni_se.My.Resources.Resources.ave1
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(117, 506)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(56, 53)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 65
        Me.TransPicBox1.TabStop = False
        '
        'TransPicBox5
        '
        Me.TransPicBox5.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox5.ErrorImage = Nothing
        Me.TransPicBox5.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox5.InitialImage = Nothing
        Me.TransPicBox5.Location = New System.Drawing.Point(1052, 386)
        Me.TransPicBox5.Name = "TransPicBox5"
        Me.TransPicBox5.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox5.TabIndex = 76
        Me.TransPicBox5.TabStop = False
        '
        'TransPicBox7
        '
        Me.TransPicBox7.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox7.ErrorImage = Nothing
        Me.TransPicBox7.Image = Nothing
        Me.TransPicBox7.InitialImage = Nothing
        Me.TransPicBox7.Location = New System.Drawing.Point(1047, 171)
        Me.TransPicBox7.Name = "TransPicBox7"
        Me.TransPicBox7.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox7.TabIndex = 71
        Me.TransPicBox7.TabStop = False
        '
        'TransPicBox2
        '
        Me.TransPicBox2.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox2.ErrorImage = Nothing
        Me.TransPicBox2.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox2.InitialImage = Nothing
        Me.TransPicBox2.Location = New System.Drawing.Point(580, 55)
        Me.TransPicBox2.Name = "TransPicBox2"
        Me.TransPicBox2.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox2.TabIndex = 89
        Me.TransPicBox2.TabStop = False
        '
        'TransPicBox9
        '
        Me.TransPicBox9.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox9.ErrorImage = Nothing
        Me.TransPicBox9.Image = Global.ya_ni_se.My.Resources.Resources.ave8
        Me.TransPicBox9.InitialImage = Nothing
        Me.TransPicBox9.Location = New System.Drawing.Point(402, 170)
        Me.TransPicBox9.Name = "TransPicBox9"
        Me.TransPicBox9.Size = New System.Drawing.Size(55, 53)
        Me.TransPicBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox9.TabIndex = 78
        Me.TransPicBox9.TabStop = False
        '
        'pbNumeroEstrellas
        '
        Me.pbNumeroEstrellas.BackColor = System.Drawing.Color.Transparent
        Me.pbNumeroEstrellas.ErrorImage = Nothing
        Me.pbNumeroEstrellas.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.pbNumeroEstrellas.InitialImage = Nothing
        Me.pbNumeroEstrellas.Location = New System.Drawing.Point(91, 66)
        Me.pbNumeroEstrellas.Name = "pbNumeroEstrellas"
        Me.pbNumeroEstrellas.Size = New System.Drawing.Size(33, 36)
        Me.pbNumeroEstrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNumeroEstrellas.TabIndex = 74
        Me.pbNumeroEstrellas.TabStop = False
        '
        'pbNumeroEstrella2
        '
        Me.pbNumeroEstrella2.BackColor = System.Drawing.Color.Transparent
        Me.pbNumeroEstrella2.ErrorImage = Nothing
        Me.pbNumeroEstrella2.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.pbNumeroEstrella2.InitialImage = Nothing
        Me.pbNumeroEstrella2.Location = New System.Drawing.Point(1071, 66)
        Me.pbNumeroEstrella2.Name = "pbNumeroEstrella2"
        Me.pbNumeroEstrella2.Size = New System.Drawing.Size(33, 36)
        Me.pbNumeroEstrella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNumeroEstrella2.TabIndex = 86
        Me.pbNumeroEstrella2.TabStop = False
        '
        'estrella
        '
        Me.estrella.BackColor = System.Drawing.Color.Transparent
        Me.estrella.ErrorImage = Nothing
        Me.estrella.Image = Global.ya_ni_se.My.Resources.Resources.Estrella
        Me.estrella.InitialImage = Nothing
        Me.estrella.Location = New System.Drawing.Point(893, 158)
        Me.estrella.Name = "estrella"
        Me.estrella.Size = New System.Drawing.Size(55, 53)
        Me.estrella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.estrella.TabIndex = 72
        Me.estrella.TabStop = False
        '
        'txbCedula
        '
        Me.txbCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula.Location = New System.Drawing.Point(392, 316)
        Me.txbCedula.Name = "txbCedula"
        Me.txbCedula.Size = New System.Drawing.Size(226, 31)
        Me.txbCedula.TabIndex = 99
        Me.txbCedula.Visible = False
        Me.txbCedula.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbCedula.WaterMarkText = "Ingrese su Cédula"
        '
        'txbCedula2
        '
        Me.txbCedula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCedula2.Location = New System.Drawing.Point(392, 468)
        Me.txbCedula2.Name = "txbCedula2"
        Me.txbCedula2.Size = New System.Drawing.Size(226, 31)
        Me.txbCedula2.TabIndex = 101
        Me.txbCedula2.Visible = False
        Me.txbCedula2.WaterMarkColor = System.Drawing.Color.Gray
        Me.txbCedula2.WaterMarkText = "Ingrese su Cédula"
        '
        'frmMultiPlayerMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.ya_ni_se.My.Resources.Resources.fondito
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 669)
        Me.Controls.Add(Me.txbCedula)
        Me.Controls.Add(Me.txbNombre2)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.lblRegistro2)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.btnRegistrar2)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.principal2)
        Me.Controls.Add(Me.principal)
        Me.Controls.Add(Me.pnlVida2)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbBala)
        Me.Controls.Add(Me.pnlFinal)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnlPiso)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TransPicBox3)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.TransPicBox5)
        Me.Controls.Add(Me.TransPicBox7)
        Me.Controls.Add(Me.TransPicBox2)
        Me.Controls.Add(Me.TransPicBox9)
        Me.Controls.Add(Me.pnlVida)
        Me.Controls.Add(Me.pbNumeroEstrellas)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVida2)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.pbNumeroEstrella2)
        Me.Controls.Add(Me.lblNumeroEstrella2)
        Me.Controls.Add(Me.estrella)
        Me.Controls.Add(Me.txbCedula2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMultiPlayerMode"
        Me.Text = "MultiPlayerMode"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.principal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNumeroEstrellas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNumeroEstrella2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estrella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransPicBox9 As ya_ni_se.TransPicBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Movimiento_Bala As System.Windows.Forms.Timer
    Friend WithEvents TransPicBox5 As ya_ni_se.TransPicBox
    Friend WithEvents pbBala As ya_ni_se.TransPicBox
    Friend WithEvents lblPuntos As System.Windows.Forms.Label
    Friend WithEvents principal As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox7 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox3 As ya_ni_se.TransPicBox
    Friend WithEvents TransPicBox1 As ya_ni_se.TransPicBox
    Friend WithEvents pnlFinal As System.Windows.Forms.Panel
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents lblVida As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents pnlVida As System.Windows.Forms.Panel
    Friend WithEvents pnlInicio As System.Windows.Forms.Panel
    Friend WithEvents Anim_Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents estrella As ya_ni_se.TransPicBox
    Friend WithEvents Encontrar_Suelo_Principal As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pbNumeroEstrellas As ya_ni_se.TransPicBox
    Friend WithEvents Movimiento_Principal As System.Windows.Forms.Timer
    Friend WithEvents Anim_Idle_Principal As System.Windows.Forms.Timer
    Friend WithEvents Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents pnlPiso As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Anim_Movimiento_Enemigo As System.Windows.Forms.Timer
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents principal2 As ya_ni_se.TransPicBox
    Friend WithEvents lblNumeroEstrella2 As System.Windows.Forms.Label
    Friend WithEvents lblVida2 As System.Windows.Forms.Label
    Friend WithEvents lblNumero2 As System.Windows.Forms.Label
    Friend WithEvents pnlVida2 As System.Windows.Forms.Panel
    Friend WithEvents pbNumeroEstrella2 As ya_ni_se.TransPicBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TransPicBox2 As ya_ni_se.TransPicBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar2 As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents lblRegistro2 As System.Windows.Forms.Label
    Friend WithEvents txbNombre As ya_ni_se.PlaceHolder
    Friend WithEvents txbCedula As ya_ni_se.PlaceHolder
    Friend WithEvents txbNombre2 As ya_ni_se.PlaceHolder
    Friend WithEvents txbCedula2 As ya_ni_se.PlaceHolder
End Class
