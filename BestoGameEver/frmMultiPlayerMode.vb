
Public Class frmMultiPlayerMode


    '////////////////////////////////////PERSONALIZACION///////////////////////
    Public avanzar As Double = 5
    Public acelereacion As Double = 0
    Public limvel As Double = 5
    Public salto As Double = 20
    Public pixSubida As Double = 7
    Public desasubida As Double = 0.01
    Public caida As Double = 7
    Public acelcaida As Double = 0.05
    '//////////////////////////////////////////////////////////////////////////

    'Utilizo una copia de las variables para luego devolverlas al valor inicial

    Dim verificarVida As Integer = 0
    Dim verificarVida2 As Integer = 0

    '//////////////////////////////////////////////////Principal1/////////////////////////////////////////////////////////////////

    Dim avanzar2 As Double = avanzar
    Dim limvel2 As Double = limvel
    Dim salto2 As Double = salto
    Dim pixSubida2 As Double = pixSubida
    Dim caida2 As Double = caida


    Dim d As Integer = 0
    Dim a As Integer = 0
    Dim lado As Integer = 0
    Dim cont As Integer = 0
    Dim stand As Integer = 0
    Dim foto As Integer = 0
    Dim idle As Integer = 0

    Dim vida As Integer = 100
    Dim puntos As Integer = 0

    Dim pan As New Panel

    '0 equivale a caer y 1 a subir
    Dim moviVertical As String = ""


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////Principal2////////////////////////////////////////////////////////////

    Dim avanzar3 As Double = avanzar
    Dim limvel3 As Double = limvel
    Dim salto3 As Double = salto
    Dim pixSubida3 As Double = pixSubida
    Dim caida3 As Double = caida

    Dim d2 As Integer = 0
    Dim a2 As Integer = 0
    Dim lado2 As Integer = 0
    Dim cont2 As Integer = 0
    Dim stand2 As Integer = 0
    Dim foto2 As Integer = 0
    Dim idle2 As Integer = 0

    Dim vida2 As Integer = 100
    Dim puntos2 As Integer = 0

    Dim pan2 As New Panel

    '0 equivale a caer y 1 a subir
    Dim moviVertical2 As String = ""


    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Dim pb As PictureBox

    Dim listaPB As List(Of PictureBox) = New List(Of PictureBox)

    Dim listaVariables(,) As Integer

    Dim direc As Integer = 0

    Private Sub BestoGame_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        frmRanking.Dispose()
        frmMenuInicio.Show()
        frmMenuInicio.actTabla()

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If vida <> 0 Then

            'Al presionar la tecla A
            If e.KeyCode = Keys.Left Then


                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla la primera vez
                If a = 0 And d = 0 Then

                    principal.Image = My.Resources.correr5

                End If

                'Indico de que lado2 debe estar la animacion de correr (izquierda)
                lado = 0

                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                a = 1


            End If

            'Al presionar la tecla D
            If e.KeyCode = Keys.Right Then

                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla
                If d = 0 And a = 0 Then

                    principal.Image = My.Resources.correr5
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                'Indico de que lado2 debe estar la animacion de correr (derecha)
                lado = 1

                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                d = 1

            End If

            'Al presionar la tecla W o la barra
            If e.KeyCode = Keys.Up Then

                'Verifico que no este descendiedo para que asi no salta en el aire
                If moviVertical = "" Then

                    'Inicio el ascenso y la animación del mismo
                    moviVertical = "1"

                End If

            End If

            'Al presionar la tecla S
            If e.KeyCode = Keys.Down Then

                If pan IsNot pnlPiso Then

                    'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
                    If moviVertical = "" And principal.Location.Y < pan.Location.Y Then

                        'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                        principal.Location = New Point(principal.Location.X, principal.Location.Y + pan.Height)
                        moviVertical = "0"

                    End If

                End If
               
            End If
        End If

        If vida2 <> 0 Then

            'Al presionar la tecla A
            If e.KeyCode = Keys.A Then


                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla la primera vez
                If a2 = 0 And d2 = 0 Then

                    principal2.Image = My.Resources.correr51

                End If

                'Indico de que lado2 debe estar la animacion de correr (izquierda)
                lado2 = 0

                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                a2 = 1


            End If

            'Al presionar la tecla D
            If e.KeyCode = Keys.D Then

                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla
                If d2 = 0 And a2 = 0 Then

                    principal2.Image = My.Resources.correr51
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                'Indico de que lado2 debe estar la animacion de correr (derecha)
                lado2 = 1


                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                d2 = 1


            End If

            'Al presionar la tecla W o la barra
            If e.KeyCode = Keys.W Then

                'Verifico que no este descendiedo para que asi no salta en el aire
                If moviVertical2 = "" Then

                    'Inicio el ascenso y la animación del mismo
                    moviVertical2 = "1"

                End If

            End If

            'Al presionar la tecla S
            If e.KeyCode = Keys.S Then

                If pan2 IsNot pnlPiso Then

                    'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
                    If moviVertical2 = "" And principal2.Location.Y < pan2.Location.Y Then

                        'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                        principal2.Location = New Point(principal2.Location.X, principal2.Location.Y + principal2.Height + pan2.Height)
                        moviVertical2 = "0"

                    End If

                End If

                



            End If
        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If vida <> 0 Then

            'Al soltar la tecla A
            If e.KeyCode = Keys.Left Then

                'Si la tecla D sigue presionada,  entonces se debe mover a la derecha
                If d = 1 Then

                    'Se apaga la animacion de idle, se indica el lado2 y se enciende la animacion de correr a la derecha

                    lado = 1

                    'Sino, que se detenga y que se encienda la animacion idle
                Else

                    'Determino esta imagen para mostrar como al soltar, se detiene el caminar
                    principal.Image = My.Resources.idle1

                End If

                'Se restaura la aceleracion a la inicial
                avanzar2 = avanzar

                'Se indica que la tecla A ya no está presionada
                a = 0

            End If

            'Al soltar la tecla D
            If e.KeyCode = Keys.Right Then

                'Si la tecla A sigue presionada,  entonces se debe mover a la izquierda
                If a = 1 Then

                    'Se apaga la animacion de idle, se indica el lado2 y se enciende la animacion de correr a la izquierda

                    lado = 0

                    'Sino, que se detenga y que se encienda la animacion idle
                Else

                    'Determino esta imagen para mostrar como al soltar, se detiene el caminar
                    principal.Image = My.Resources.idle1
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)


                End If

                'Se restaura la aceleracion a la inicial
                avanzar2 = avanzar

                'Se indica que la tecla D ya no está presionada
                d = 0

            End If
        End If

        If vida2 <> 0 Then

            'Al soltar la tecla A
            If e.KeyCode = Keys.A Then

                'Si la tecla D sigue presionada,  entonces se debe mover a la derecha
                If d2 = 1 Then

                    'Se apaga la animacion de idle, se indica el lado2 y se enciende la animacion de correr a la derecha

                    lado2 = 1

                    'Sino, que se detenga y que se encienda la animacion idle
                Else

                    'Determino esta imagen para mostrar como al soltar, se detiene el caminar
                    principal2.Image = My.Resources.idle11

                End If

                'Se restaura la aceleracion a la inicial
                avanzar3 = avanzar

                'Se indica que la tecla A ya no está presionada
                a2 = 0

            End If

            'Al soltar la tecla D
            If e.KeyCode = Keys.D Then

                'Si la tecla A sigue presionada,  entonces se debe mover a la izquierda
                If a2 = 1 Then

                    'Se apaga la animacion de idle, se indica el lado2 y se enciende la animacion de correr a la izquierda

                    lado2 = 0

                    'Sino, que se detenga y que se encienda la animacion idle
                Else

                    'Determino esta imagen para mostrar como al soltar, se detiene el caminar
                    principal2.Image = My.Resources.idle11
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)


                End If

                'Se restaura la aceleracion a la inicial
                avanzar3 = avanzar

                'Se indica que la tecla D ya no está presionada
                d2 = 0

            End If
        End If


    End Sub


    Private Sub Movimiento_Principal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Principal.Tick

        If estrella.Location.X + estrella.Width - 10 > principal.Location.X And estrella.Location.X + 10 < principal.Location.X + principal.Width And estrella.Location.Y + estrella.Height - 10 > principal.Location.Y And estrella.Location.Y < principal.Location.Y + principal.Height - 10 Then
            ubicarEstrella()
            puntos += 1
            lblPuntos.Text = ": " + puntos.ToString

        ElseIf estrella.Location.X + estrella.Width - 10 > principal2.Location.X And estrella.Location.X + 10 < principal2.Location.X + principal2.Width And estrella.Location.Y + estrella.Height - 10 > principal2.Location.Y And estrella.Location.Y < principal2.Location.Y + principal2.Height - 10 Then
            ubicarEstrella()
            puntos2 += 1
            lblNumeroEstrella2.Text = ": " + puntos2.ToString
        End If


        '/////////////////////////////////////////////////////////// Movimiento Vertical /////////////////////////////////////////////////////////////////////////
        If moviVertical2 <> "" Then

            '////////////////////// Descenso /////////////////////////////////
            If moviVertical2 = "0" Then

                If pan2 IsNot pnlPiso Then

                    If principal2.Location.Y + principal2.Height + caida3 < pan2.Location.Y - 20 Then

                        principal2.Location = New Point(principal2.Location.X, principal2.Location.Y + caida3)
                        caida3 += acelcaida


                    ElseIf principal2.Location.Y + principal2.Height + caida3 >= pan2.Location.Y - 20 And principal2.Location.Y + principal2.Height + caida3 <= pan2.Location.Y Then

                        principal2.Location = New Point(principal2.Location.X, pan2.Location.Y - principal2.Height)
                        caida3 = caida
                        moviVertical2 = ""


                    ElseIf principal2.Location.Y + principal2.Height >= pan2.Location.Y - 20 And principal2.Location.Y + principal2.Height <= pnlPiso.Location.Y Then

                        principal2.Location = New Point(principal2.Location.X, pan2.Location.Y - principal2.Height)
                        caida3 = caida
                        moviVertical2 = ""

                    End If
                Else

                    If principal2.Location.Y + principal2.Height + caida3 < pnlPiso.Location.Y - 20 Then

                        principal2.Location = New Point(principal2.Location.X, principal2.Location.Y + caida3)
                        caida3 += acelcaida

                    ElseIf principal2.Location.Y + principal2.Height + caida3 >= pnlPiso.Location.Y - 20 Then

                        principal2.Location = New Point(principal2.Location.X, pnlPiso.Location.Y - principal2.Height)
                        caida3 = caida
                        moviVertical2 = ""


                    End If

                End If


                '////////////////////// Ascenso /////////////////////////////////
            ElseIf moviVertical2 = "1" Then


                'Utilizo un contador para ver si se hicieron los movimientos verticales suficientes
                If cont2 <= salto3 Then

                    'El PictureBox se eleva la cantidad que esta en pixSubida2
                    principal2.Location = New Point(principal2.Location.X, principal2.Location.Y - pixSubida3)

                    'Le sumo 1 al contador
                    cont2 += 1

                    'La subida debe ser cada vez mas lenta por la gravedad, por eso le resto
                    pixSubida3 -= desasubida

                Else
                    'Cuando el número de veces es alcanzado, se restablecen la variables al valor inicial
                    pixSubida3 = pixSubida
                    cont2 = 0

                    'Se detiene el ascenso y comienza el descenso con su animación
                    moviVertical2 = "0"

                End If
            End If
        End If

        '/////////////////////////////////////////////////////////// Movimiento Lateral /////////////////////////////////////////////////////////////////////////
        If d2 = 1 Or a2 = 1 Then
            'Si el PictureBox llega al borde de la sala, que lo mueva hacia atrás

            If principal2.Location.X >= pnlFinal.Location.X - principal2.Width And principal2.Location.Y + principal2.Height > pnlFinal.Location.Y And principal2.Location.X < pnlFinal.Location.X + (pnlFinal.Width / 2) Then

                principal2.Location = New Point(principal2.Location.X - 10, principal2.Location.Y)

            ElseIf principal2.Location.X <= pnlFinal.Location.X + pnlFinal.Width And principal2.Location.Y + principal2.Height > pnlFinal.Location.Y And principal2.Location.X > pnlFinal.Location.X + (pnlFinal.Width / 2) Then

                principal2.Location = New Point(principal2.Location.X + 10, principal2.Location.Y)

            ElseIf principal2.Location.X <= pnlInicio.Location.X + pnlInicio.Width Then

                principal2.Location = New Point(principal2.Location.X + 10, principal2.Location.Y)



            End If

            'Si solo la tecla d2 está presionada
            If d2 = 1 And a2 = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                principal2.Location = New Point(principal2.Location.X + avanzar3, principal2.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical2 = "" And avanzar3 <= limvel3 Then

                    avanzar3 += acelereacion

                End If


                'Si solo la tecla a2 está presionada
            ElseIf a2 = 1 And d2 = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                principal2.Location = New Point(principal2.Location.X - avanzar3, principal2.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical2 = "" And avanzar3 <= limvel3 Then

                    avanzar3 += acelereacion

                End If


            End If

            'Si el PictureBox no está ascendiendo ni bajando
            If moviVertical2 = "" Then



                'Si el PictureBox esta a2 la izquierda o la derecha del Panel (Plataforma)
                If principal2.Location.X < (pan2.Location.X - principal2.Width + 5) Or principal2.Location.X > pan2.Location.X + pan2.Width - 10 Then

                    'Si el PictureBox esta por ensima del Panel4 (Plataforma)
                    If principal2.Location.Y + principal2.Height < pan2.Location.Y + 1 Then

                        'Que inicie el descenso y la animación del mismo
                        moviVertical2 = "0"


                    End If

                End If




            End If
        End If

        '/////////////////////////////////////////////////////////// Movimiento Vertical /////////////////////////////////////////////////////////////////////////
        If moviVertical <> "" Then

            '////////////////////// Descenso /////////////////////////////////
            If moviVertical = "0" Then


                If pan IsNot pnlPiso Then

                    If principal.Location.Y + principal.Height + caida2 < pan.Location.Y - 20 Then

                        principal.Location = New Point(principal.Location.X, principal.Location.Y + caida2)
                        caida2 += acelcaida


                    ElseIf principal.Location.Y + principal.Height + caida2 >= pan.Location.Y - 20 And principal.Location.Y + principal.Height + caida2 <= pan.Location.Y Then

                        principal.Location = New Point(principal.Location.X, pan.Location.Y - principal.Height)
                        caida2 = caida
                        moviVertical = ""


                    ElseIf principal.Location.Y + principal.Height >= pan.Location.Y - 20 And principal.Location.Y + principal.Height <= pnlPiso.Location.Y Then

                        principal.Location = New Point(principal.Location.X, pan.Location.Y - principal.Height)
                        caida2 = caida
                        moviVertical = ""

                    End If
                Else

                    If principal.Location.Y + principal.Height + caida2 < pnlPiso.Location.Y - 20 Then

                        principal.Location = New Point(principal.Location.X, principal.Location.Y + caida2)
                        caida2 += acelcaida

                    ElseIf principal.Location.Y + principal.Height + caida2 >= pnlPiso.Location.Y - 20 Then

                        principal.Location = New Point(principal.Location.X, pnlPiso.Location.Y - principal.Height)
                        caida2 = caida
                        moviVertical = ""


                    End If

                End If


                '////////////////////// Ascenso /////////////////////////////////
            ElseIf moviVertical = "1" Then


                'Utilizo un contador para ver si se hicieron los movimientos verticales suficientes
                If cont <= salto Then

                    'El PictureBox se eleva la cantidad que esta en pixSubida2
                    principal.Location = New Point(principal.Location.X, principal.Location.Y - pixSubida2)

                    'Le sumo 1 al contador
                    cont += 1

                    'La subida debe ser cada vez mas lenta por la gravedad, por eso le resto
                    pixSubida2 -= desasubida



                Else
                    'Cuando el número de veces es alcanzado, se restablecen la variables al valor inicial
                    pixSubida2 = pixSubida
                    cont = 0

                    'Se detiene el ascenso y comienza el descenso con su animación
                    moviVertical = "0"

                End If
            End If
        End If

        '/////////////////////////////////////////////////////////// Movimiento Lateral /////////////////////////////////////////////////////////////////////////
        If d = 1 Or a = 1 Then
            'Si el PictureBox llega al borde de la sala, que lo mueva hacia atrás

            If principal.Location.X >= pnlFinal.Location.X - principal.Width And principal.Location.Y + principal.Height > pnlFinal.Location.Y And principal.Location.X < pnlFinal.Location.X + (pnlFinal.Width / 2) Then

                principal.Location = New Point(principal.Location.X - 10, principal.Location.Y)

            ElseIf principal.Location.X <= pnlFinal.Location.X + pnlFinal.Width And principal.Location.Y + principal.Height > pnlFinal.Location.Y And principal.Location.X > pnlFinal.Location.X + (pnlFinal.Width / 2) Then

                principal.Location = New Point(principal.Location.X + 10, principal.Location.Y)

            ElseIf principal.Location.X <= pnlInicio.Location.X + pnlInicio.Width Then

                principal.Location = New Point(principal.Location.X + 10, principal.Location.Y)



            End If

            'Si solo la tecla D está presionada
            If d = 1 And a = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                principal.Location = New Point(principal.Location.X + avanzar2, principal.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = "" And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion

                End If


                'Si solo la tecla A está presionada
            ElseIf a = 1 And d = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                principal.Location = New Point(principal.Location.X - avanzar2, principal.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = "" And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion

                End If


            End If

            'Si el PictureBox no está ascendiendo ni bajando
            If moviVertical = "" Then



                'Si el PictureBox esta a la izquierda o la derecha del Panel (Plataforma)
                If principal.Location.X < (pan.Location.X - principal.Width + 5) Or principal.Location.X > pan.Location.X + pan.Width - 10 Then

                    'Si el PictureBox esta por ensima del Panel4 (Plataforma)
                    If principal.Location.Y + principal.Height < pan.Location.Y + 1 Then

                        'Que inicie el descenso y la animación del mismo
                        moviVertical = "0"


                    End If



                End If


            End If
        End If



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim noti As New frmNotificacion
        noti.lblCambio.Text = "JUGADOR 1: Flechas" + vbNewLine + "JUGADOR 2: ASWD"
        noti.lblTitulo.Visible = True
        noti.lblTitulo.Text = "Controles:"
        noti.ShowDialog()

        Me.Location = New Point(0, 0)
       

        Encontrar_Suelo_Principal.Start()
        Movimiento_Bala.Start()
        Movimiento_Enemigo.Start()
        Anim_Idle_Principal.Start()
        Anim_Movimiento_Principal.Start()
        Anim_Movimiento_Enemigo.Start()
        Movimiento_Principal.Start()
       

        verificarVida = 0
        verificarVida2 = 0

        pbBala.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

        frmRanking.Show()
        frmRanking.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
        frmRanking.actTabla()

        ActVida(vida, 2)
        ActVida2(vida2, 2)

        moviVertical = ""
        moviVertical2 = ""

        Dim cont As Integer = 0

        For Each ctrl As Control In Me.Controls

            Dim pb As PictureBox = Nothing
            Try
                pb = ctrl

                If pb.Name <> principal.Name And pb.Name <> pnlVida.Name And pb.Name <> estrella.Name And pb.Name <> pbNumeroEstrellas.Name And pb.Name <> pbBala.Name And pb.Name <> principal2.Name And pb.Name <> pbNumeroEstrella2.Name Then

                    listaPB.Add(pb)
                    ReDim listaVariables(cont, 3)

                    listaVariables(cont, 0) = 0
                    listaVariables(cont, 1) = 0
                    listaVariables(cont, 2) = 0
                    listaVariables(cont, 3) = 0

                    cont += 1
                End If


            Catch ex As Exception

            End Try

        Next

        ubicarEstrella()



    End Sub


    Private Sub Anim_Idle_Principal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Idle_Principal.Tick
        If ((a2 = 1 And d2 = 1) Or (a2 = 0 And d2 = 0)) And moviVertical2 = "" Then
            'En la variable lado2 se indica a que lado2 debe ver el PictureBox, 0 = izquierda,  1 = derecha
            If lado2 = 0 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand2
                    Case 0
                        principal2.Image = My.Resources.idle11
                        stand2 += 1
                    Case 1
                        principal2.Image = My.Resources.idle21
                        stand2 += 1
                    Case 2
                        principal2.Image = My.Resources.idle31
                        stand2 += 1
                    Case 3
                        principal2.Image = My.Resources.idle41
                        stand2 += 1
                    Case 4
                        principal2.Image = My.Resources.idle51
                        stand2 = 0
                End Select

            ElseIf lado2 = 1 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand2
                    Case 0
                        principal2.Image = My.Resources.idle11
                        principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand2 += 1
                    Case 1
                        principal2.Image = My.Resources.idle21
                        principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand2 += 1
                    Case 2
                        principal2.Image = My.Resources.idle31
                        principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand2 += 1
                    Case 3
                        principal2.Image = My.Resources.idle41
                        principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand2 += 1
                    Case 4
                        principal2.Image = My.Resources.idle51
                        principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand2 = 0
                End Select
            End If

        End If
        If ((a = 1 And d = 1) Or (a = 0 And d = 0)) And moviVertical = "" Then
            'En la variable lado2 se indica a que lado2 debe ver el PictureBox, 0 = izquierda,  1 = derecha
            If lado = 0 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand
                    Case 0
                        principal.Image = My.Resources.idle1
                        stand += 1
                    Case 1
                        principal.Image = My.Resources.idle2
                        stand += 1
                    Case 2
                        principal.Image = My.Resources.idle3
                        stand += 1
                    Case 3
                        principal.Image = My.Resources.idle4
                        stand += 1
                    Case 4
                        principal.Image = My.Resources.idle5
                        stand = 0
                End Select

            ElseIf lado = 1 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand
                    Case 0
                        principal.Image = My.Resources.idle1
                        principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 1
                        principal.Image = My.Resources.idle2
                        principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 2
                        principal.Image = My.Resources.idle3
                        principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 3
                        principal.Image = My.Resources.idle4
                        principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 4
                        principal.Image = My.Resources.idle5
                        principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand = 0
                End Select
            End If

        End If

    End Sub



    Private Sub Anim_Movimiento_Principal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Movimiento_Principal.Tick
        If a2 = 1 And d2 = 0 And moviVertical2 = "" Then

            'Utilizando la variable foto2 como contador, recorremos el select case una vuelta por tick.
            Select Case foto2

                Case 0
                    principal2.Image = My.Resources.correr51
                    foto2 += 1
                Case 1
                    principal2.Image = My.Resources.correr41
                    foto2 += 1
                Case 2
                    principal2.Image = My.Resources.correr31
                    foto2 += 1
                Case 3
                    principal2.Image = My.Resources.correr21
                    foto2 += 1
                Case 4
                    principal2.Image = My.Resources.correr11
                    foto2 = 0

            End Select
        ElseIf d2 = 1 And a2 = 0 And moviVertical2 = "" Then

            'Utilizando la variable foto2 como contador, recorremos el select case una vuelta por tick. Volteamos la imagen porque se mueve hacia adelante
            Select Case foto2

                Case 0
                    principal2.Image = My.Resources.correr51
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto2 += 1
                Case 1
                    principal2.Image = My.Resources.correr41
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto2 += 1
                Case 2
                    principal2.Image = My.Resources.correr31
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto2 += 1
                Case 3
                    principal2.Image = My.Resources.correr21
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto2 += 1
                Case 4
                    principal2.Image = My.Resources.correr11
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto2 = 0

            End Select
        End If

        'Sin esta condicion, el personaje no dejaba de saltar
        If moviVertical2 <> "" Then

            '1 se utiliza para indicar ascenso
            If moviVertical2 = "1" Then

                'En la variable lado22 se indica a2 que lado22 debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado2 = 0 Then

                    principal2.Image = My.Resources.saltar

                ElseIf lado2 = 1 Then

                    principal2.Image = My.Resources.saltar
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                '0 se utiliza para indicar descenso
            ElseIf moviVertical2 = "0" Then

                'En la variable lado22 se indica a2 que lado22 debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado2 = 0 Then

                    principal2.Image = My.Resources.caer2

                ElseIf lado2 = 1 Then

                    principal2.Image = My.Resources.caer2
                    principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If
            End If
        End If

        If a = 1 And d = 0 And moviVertical = "" Then

            'Utilizando la variable foto como contador, recorremos el select case una vuelta por tick.
            Select Case foto

                Case 0
                    principal.Image = My.Resources.correr5
                    foto += 1
                Case 1
                    principal.Image = My.Resources.correr4
                    foto += 1
                Case 2
                    principal.Image = My.Resources.correr3
                    foto += 1
                Case 3
                    principal.Image = My.Resources.correr2
                    foto += 1
                Case 4
                    principal.Image = My.Resources.correr1
                    foto = 0

            End Select

        ElseIf d = 1 And a = 0 And moviVertical = "" Then

            'Utilizando la variable foto como contador, recorremos el select case una vuelta por tick. Volteamos la imagen porque se mueve hacia adelante
            Select Case foto

                Case 0
                    principal.Image = My.Resources.correr5
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 1
                    principal.Image = My.Resources.correr4
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 2
                    principal.Image = My.Resources.correr3
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 3
                    principal.Image = My.Resources.correr2
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 4
                    principal.Image = My.Resources.correr1
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto = 0

            End Select
        End If

        'Sin esta condicion, el personaje no dejaba de saltar
        If moviVertical <> "" Then

            '1 se utiliza para indicar ascenso
            If moviVertical = "1" Then

                'En la variable lado2 se indica a que lado2 debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    principal.Image = My.Resources.salto

                ElseIf lado = 1 Then

                    principal.Image = My.Resources.salto
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                '0 se utiliza para indicar descenso
            ElseIf moviVertical = "0" Then

                'En la variable lado2 se indica a que lado2 debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    principal.Image = My.Resources.caida

                ElseIf lado = 1 Then

                    principal.Image = My.Resources.caida
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If
            End If
        End If



    End Sub



    Private Sub Encontrar_Suelo_Principal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encontrar_Suelo_Principal.Tick

        Dim panelFinal As Panel = pnlPiso
        Dim panelFinal2 As Panel = pnlPiso
        Dim dy As Integer = 1000
        Dim dy2 As Integer = 1000

        For Each ctrl As Control In Me.Controls

            If TypeOf ctrl Is Panel Then


                '   si el valor de la resta de la ubicacion (Y) del objeto y del personaje es menor a dy  y si el objeto esta debajo del personaje(picturebox1) y si el objeto no es el personaje(picturebox1) y si el objeto no es el piso(panel1)
                If Math.Abs(ctrl.Location.Y - (principal2.Location.Y + principal2.Height)) < dy2 And ctrl.Location.Y >= (principal2.Location.Y + principal2.Height) And ctrl.Name <> principal2.Name And ctrl.Name <> pnlVida.Name And ctrl.Name <> principal.Name And ctrl.Name <> pnlVida2.Name Then

                    '                si el personaje esta adentro del piso (si el picturebox1 esta adentro del limite del objeto que esta de bajo (eje x))
                    If principal2.Location.X >= ctrl.Location.X - principal2.Width + 5 And principal2.Location.X < (ctrl.Location.X + ctrl.Width - 5) Then

                        ' si se verifica lo anterior el panel final es el objeto donde esta el personaje
                        panelFinal2 = ctrl


                        ' y el dy es la distancia entre el picturebox y el suelo
                        dy2 = Math.Abs(ctrl.Location.Y - (principal2.Location.Y + principal2.Height))


                    End If


                End If

                '   si el valor de la resta de la ubicacion (Y) del objeto y del personaje es menor a dy  y si el objeto esta debajo del personaje(picturebox1) y si el objeto no es el personaje(picturebox1) y si el objeto no es el piso(panel1)
                If Math.Abs((ctrl.Location.Y) - (principal.Location.Y + principal.Height)) < dy And ctrl.Location.Y >= (principal.Location.Y + principal.Height) And ctrl.Name <> principal.Name And ctrl.Name <> pnlVida.Name And ctrl.Name <> principal2.Name And ctrl.Name <> pnlVida2.Name Then

                    '                si el personaje esta adentro del piso (si el picturebox1 esta adentro del limite del objeto que esta de bajo (eje x))
                    If principal.Location.X >= ctrl.Location.X - principal.Width + 5 And principal.Location.X < (ctrl.Location.X + ctrl.Width - 5) Then

                        ' si se verifica lo anterior el panel final es el objeto donde esta el personaje
                        panelFinal = ctrl

                        ' y el dy es la distancia entre el picturebox y el suelo
                        dy = Math.Abs(ctrl.Location.Y - (principal.Location.Y + principal.Height))


                    End If


                End If


            End If

        Next

       
        pan = panelFinal
        lblPiso.Text = pan.Name
        pan2 = panelFinal2


    End Sub



    Private Sub Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Enemigo.Tick


        For indice = 0 To listaPB.Count - 1

            pb = listaPB(indice)

            Try

                If pb.Location.X > pnlInicio.Location.X + pnlInicio.Width And pb.Location.X + pb.Width < pnlFinal.Location.X Then

                    If Math.Abs(pb.Location.Y - principal.Location.Y) <= 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) <= 10 Then

                        If Math.Abs(pb.Location.X - principal.Location.X) < Math.Abs(pb.Location.X - principal2.Location.X) And Math.Abs(pb.Location.X - principal.Location.X) < 400 And Math.Abs(pb.Location.X - principal.Location.X) > 60 Then

                            If pb.Location.X < principal.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > principal.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf Math.Abs(pb.Location.X - principal.Location.X) >= Math.Abs(pb.Location.X - principal2.Location.X) And Math.Abs(pb.Location.X - principal2.Location.X) < 400 And Math.Abs(pb.Location.X - principal2.Location.X) > 60 Then

                            If pb.Location.X < principal2.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > principal2.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf (Math.Abs(pb.Location.X - principal2.Location.X) > 400 And Math.Abs(pb.Location.X - principal.Location.X) > 400) Or (Math.Abs(pb.Location.Y - principal2.Location.Y) > 10 And Math.Abs(pb.Location.Y - principal.Location.Y) > 10) Then

                            If listaVariables(indice, 2) <= 7 Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            Else

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        End If

                    ElseIf Math.Abs(pb.Location.Y - principal.Location.Y) <= 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) > 10 Then

                        If Math.Abs(pb.Location.X - principal.Location.X) < 400 And Math.Abs(pb.Location.X - principal.Location.X) > 60 Then

                            If pb.Location.X < principal.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > principal.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf Math.Abs(pb.Location.X - principal.Location.X) > 400 Then

                            If listaVariables(indice, 2) <= 7 Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            Else

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        End If

                    ElseIf Math.Abs(pb.Location.Y - principal.Location.Y) > 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) <= 10 Then

                        If Math.Abs(pb.Location.X - principal2.Location.X) < 400 And Math.Abs(pb.Location.X - principal2.Location.X) > 60 Then

                            If pb.Location.X < principal2.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > principal2.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf Math.Abs(pb.Location.X - principal2.Location.X) > 400 Then

                            If listaVariables(indice, 2) <= 7 Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            Else

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        End If

                    ElseIf Math.Abs(pb.Location.Y - principal.Location.Y) > 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) > 10 Then


                        If listaVariables(indice, 2) <= 7 Then

                            pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                        Else

                            pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                        End If

                    End If


                ElseIf pb.Location.X + pb.Width >= pnlFinal.Location.X Then

                    pb.Location = New Point(pb.Location.X - 15, pb.Location.Y)

                ElseIf pb.Location.X <= pnlInicio.Location.X + pnlInicio.Width Then

                    pb.Location = New Point(pb.Location.X + 15, pb.Location.Y)

                End If



            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Anim_Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Movimiento_Enemigo.Tick
        For indice = 0 To listaPB.Count - 1

            pb = listaPB(indice)


            Try


                If pb.Location.X > pnlInicio.Location.X + pnlInicio.Width And pb.Location.X + pb.Width < pnlFinal.Location.X Then

                    If Math.Abs(pb.Location.Y - principal.Location.Y) <= 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) <= 10 Then

                        If Math.Abs(pb.Location.X - principal.Location.X) < Math.Abs(pb.Location.X - principal2.Location.X) And Math.Abs(pb.Location.X - principal.Location.X) < 400 And Math.Abs(pb.Location.X - principal.Location.X) > 60 Then

                            If pb.Location.X < principal.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) = 0

                                End Select

                            ElseIf pb.Location.X > principal.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 0) = 0

                                End Select

                            End If

                        ElseIf Math.Abs(pb.Location.X - principal.Location.X) >= Math.Abs(pb.Location.X - principal2.Location.X) And Math.Abs(pb.Location.X - principal2.Location.X) < 400 And Math.Abs(pb.Location.X - principal2.Location.X) > 60 Then

                            If pb.Location.X < principal2.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) = 0

                                End Select

                            ElseIf pb.Location.X > principal2.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 0) = 0

                                End Select

                            End If

                        ElseIf (Math.Abs(pb.Location.X - principal2.Location.X) > 400 And Math.Abs(pb.Location.X - principal.Location.X) > 400) Or (Math.Abs(pb.Location.Y - principal2.Location.Y) > 10 And Math.Abs(pb.Location.Y - principal.Location.Y) > 10) Then

                            Select Case listaVariables(indice, 2)

                                Case 0
                                    pb.Image = My.Resources.ave1
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 1
                                    pb.Image = My.Resources.ave2
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 2
                                    pb.Image = My.Resources.ave3
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 3
                                    pb.Image = My.Resources.ave4
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 4
                                    pb.Image = My.Resources.ave5
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 5
                                    pb.Image = My.Resources.ave6
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 6
                                    pb.Image = My.Resources.ave7
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 7
                                    pb.Image = My.Resources.ave8
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1


                                Case 8
                                    pb.Image = My.Resources.ave1
                                    listaVariables(indice, 2) += 1
                                Case 9
                                    pb.Image = My.Resources.ave2
                                    listaVariables(indice, 2) += 1
                                Case 10
                                    pb.Image = My.Resources.ave3
                                    listaVariables(indice, 2) += 1
                                Case 11
                                    pb.Image = My.Resources.ave4
                                    listaVariables(indice, 2) += 1
                                Case 12
                                    pb.Image = My.Resources.ave5
                                    listaVariables(indice, 2) += 1
                                Case 13
                                    pb.Image = My.Resources.ave6
                                    listaVariables(indice, 2) += 1
                                Case 14
                                    pb.Image = My.Resources.ave7
                                    listaVariables(indice, 2) += 1
                                Case 15
                                    pb.Image = My.Resources.ave8
                                    listaVariables(indice, 2) = 0


                            End Select


                        ElseIf Math.Abs(pb.Location.X - principal.Location.X) <= 60 Or Math.Abs(pb.Location.X - principal2.Location.X) <= 60 Then

                            If (Math.Abs(pb.Location.X - principal.Location.X)) <= 60 Then


                                If pb.Location.X < principal.Location.X Then

                                    Select Case listaVariables(indice, 1)
                                        Case 0
                                            pb.Image = My.Resources.ave1
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1

                                        Case 1
                                            pb.Image = My.Resources.ave2
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 2
                                            pb.Image = My.Resources.ave3
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 3
                                            pb.Image = My.Resources.ave4
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1

                                            If vida <= 1 Then
                                                vida = 0
                                            Else
                                                vida -= 10
                                            End If
                                            ActVida(vida, 0)

                                        Case 4
                                            pb.Image = My.Resources.ave5
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 5
                                            pb.Image = My.Resources.ave6
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 6
                                            pb.Image = My.Resources.ave7
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 7
                                            pb.Image = My.Resources.ave8
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) = 0

                                            If vida <= 1 Then
                                                vida = 0
                                            Else
                                                vida -= 10
                                            End If
                                            ActVida(vida, 0)

                                    End Select

                                ElseIf pb.Location.X > principal.Location.X Then

                                    Select Case listaVariables(indice, 1)

                                        Case 0
                                            pb.Image = My.Resources.ave1
                                            listaVariables(indice, 1) += 1

                                        Case 1
                                            pb.Image = My.Resources.ave2
                                            listaVariables(indice, 1) += 1
                                        Case 2
                                            pb.Image = My.Resources.ave3
                                            listaVariables(indice, 1) += 1
                                        Case 3
                                            pb.Image = My.Resources.ave4
                                            listaVariables(indice, 1) += 1

                                            If vida <= 1 Then
                                                vida = 0
                                            Else
                                                vida -= 10
                                            End If
                                            ActVida(vida, 1)

                                        Case 4
                                            pb.Image = My.Resources.ave5
                                            listaVariables(indice, 1) += 1
                                        Case 5
                                            pb.Image = My.Resources.ave6
                                            listaVariables(indice, 1) += 1
                                        Case 6
                                            pb.Image = My.Resources.ave7
                                            listaVariables(indice, 1) += 1
                                        Case 7
                                            pb.Image = My.Resources.ave8
                                            listaVariables(indice, 1) = 0



                                            If vida <= 1 Then
                                                vida = 0
                                            Else
                                                vida -= 10
                                            End If
                                            ActVida(vida, 1)


                                    End Select

                                End If

                            End If

                            If (Math.Abs(pb.Location.X - principal2.Location.X)) <= 60 Then


                                If pb.Location.X < principal2.Location.X Then

                                    Select Case listaVariables(indice, 1)
                                        Case 0
                                            pb.Image = My.Resources.ave1
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1

                                        Case 1
                                            pb.Image = My.Resources.ave2
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 2
                                            pb.Image = My.Resources.ave3
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 3
                                            pb.Image = My.Resources.ave4
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1

                                            If vida2 <= 1 Then
                                                vida2 = 0
                                            Else
                                                vida2 -= 10
                                            End If
                                            ActVida2(vida2, 0)

                                        Case 4
                                            pb.Image = My.Resources.ave5
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 5
                                            pb.Image = My.Resources.ave6
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 6
                                            pb.Image = My.Resources.ave7
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) += 1
                                        Case 7
                                            pb.Image = My.Resources.ave8
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            listaVariables(indice, 1) = 0

                                            If vida2 <= 1 Then
                                                vida2 = 0
                                            Else
                                                vida2 -= 10
                                            End If
                                            ActVida2(vida2, 0)

                                    End Select

                                ElseIf pb.Location.X > principal2.Location.X Then

                                    Select Case listaVariables(indice, 1)

                                        Case 0
                                            pb.Image = My.Resources.ave1
                                            listaVariables(indice, 1) += 1

                                        Case 1
                                            pb.Image = My.Resources.ave2
                                            listaVariables(indice, 1) += 1
                                        Case 2
                                            pb.Image = My.Resources.ave3
                                            listaVariables(indice, 1) += 1
                                        Case 3
                                            pb.Image = My.Resources.ave4
                                            listaVariables(indice, 1) += 1

                                            If vida2 <= 1 Then
                                                vida2 = 0
                                            Else
                                                vida2 -= 10
                                            End If
                                            ActVida2(vida2, 1)

                                        Case 4
                                            pb.Image = My.Resources.ave5
                                            listaVariables(indice, 1) += 1
                                        Case 5
                                            pb.Image = My.Resources.ave6
                                            listaVariables(indice, 1) += 1
                                        Case 6
                                            pb.Image = My.Resources.ave7
                                            listaVariables(indice, 1) += 1
                                        Case 7
                                            pb.Image = My.Resources.ave8
                                            listaVariables(indice, 1) = 0



                                            If vida2 <= 1 Then
                                                vida2 = 0
                                            Else
                                                vida2 -= 10
                                            End If
                                            ActVida2(vida2, 1)


                                    End Select

                                End If

                            End If





                        End If

                    ElseIf Math.Abs(pb.Location.Y - principal.Location.Y) <= 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) > 10 Then

                        If Math.Abs(pb.Location.X - principal.Location.X) < 400 And Math.Abs(pb.Location.X - principal.Location.X) > 60 Then

                            If pb.Location.X < principal.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) = 0

                                End Select

                            ElseIf pb.Location.X > principal.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 0) = 0

                                End Select

                            End If
                        ElseIf (Math.Abs(pb.Location.X - principal.Location.X)) < 60 Then


                            If pb.Location.X < principal.Location.X Then

                                Select Case listaVariables(indice, 1)
                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1

                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1

                                        If vida <= 1 Then
                                            vida = 0
                                        Else
                                            vida -= 10
                                        End If
                                        ActVida(vida, 0)

                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) = 0

                                        If vida <= 1 Then
                                            vida = 0
                                        Else
                                            vida -= 10
                                        End If
                                        ActVida(vida, 0)

                                End Select

                            ElseIf pb.Location.X > principal.Location.X Then

                                Select Case listaVariables(indice, 1)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 1) += 1

                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 1) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 1) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 1) += 1

                                        If vida <= 1 Then
                                            vida = 0
                                        Else
                                            vida -= 10
                                        End If
                                        ActVida(vida, 1)

                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 1) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 1) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 1) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 1) = 0



                                        If vida <= 1 Then
                                            vida = 0
                                        Else
                                            vida -= 10
                                        End If
                                        ActVida(vida, 1)


                                End Select

                            End If
                        ElseIf Math.Abs(pb.Location.X - principal.Location.X) > 400 Then

                            Select Case listaVariables(indice, 2)

                                Case 0
                                    pb.Image = My.Resources.ave1
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 1
                                    pb.Image = My.Resources.ave2
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 2
                                    pb.Image = My.Resources.ave3
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 3
                                    pb.Image = My.Resources.ave4
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 4
                                    pb.Image = My.Resources.ave5
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 5
                                    pb.Image = My.Resources.ave6
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 6
                                    pb.Image = My.Resources.ave7
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 7
                                    pb.Image = My.Resources.ave8
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1


                                Case 8
                                    pb.Image = My.Resources.ave1
                                    listaVariables(indice, 2) += 1
                                Case 9
                                    pb.Image = My.Resources.ave2
                                    listaVariables(indice, 2) += 1
                                Case 10
                                    pb.Image = My.Resources.ave3
                                    listaVariables(indice, 2) += 1
                                Case 11
                                    pb.Image = My.Resources.ave4
                                    listaVariables(indice, 2) += 1
                                Case 12
                                    pb.Image = My.Resources.ave5
                                    listaVariables(indice, 2) += 1
                                Case 13
                                    pb.Image = My.Resources.ave6
                                    listaVariables(indice, 2) += 1
                                Case 14
                                    pb.Image = My.Resources.ave7
                                    listaVariables(indice, 2) += 1
                                Case 15
                                    pb.Image = My.Resources.ave8
                                    listaVariables(indice, 2) = 0


                            End Select
                        End If



                    ElseIf Math.Abs(pb.Location.Y - principal.Location.Y) > 10 And Math.Abs(pb.Location.Y - principal2.Location.Y) <= 10 Then

                        If Math.Abs(pb.Location.X - principal2.Location.X) < 400 And Math.Abs(pb.Location.X - principal2.Location.X) > 60 Then

                            If pb.Location.X < principal2.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 0) = 0

                                End Select

                            ElseIf pb.Location.X > principal2.Location.X Then

                                Select Case listaVariables(indice, 0)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 0) += 1
                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 0) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 0) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 0) += 1
                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 0) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 0) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 0) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 0) = 0

                                End Select

                            End If

                        ElseIf Math.Abs(pb.Location.X - principal2.Location.X) < 60 Then


                            If pb.Location.X < principal2.Location.X Then

                                Select Case listaVariables(indice, 1)
                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1

                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1

                                        If vida2 <= 1 Then
                                            vida2 = 0
                                        Else
                                            vida2 -= 10
                                        End If
                                        ActVida2(vida2, 0)

                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        listaVariables(indice, 1) = 0

                                        If vida2 <= 1 Then
                                            vida2 = 0
                                        Else
                                            vida2 -= 10
                                        End If
                                        ActVida2(vida2, 0)

                                End Select

                            ElseIf pb.Location.X > principal2.Location.X Then

                                Select Case listaVariables(indice, 1)

                                    Case 0
                                        pb.Image = My.Resources.ave1
                                        listaVariables(indice, 1) += 1

                                    Case 1
                                        pb.Image = My.Resources.ave2
                                        listaVariables(indice, 1) += 1
                                    Case 2
                                        pb.Image = My.Resources.ave3
                                        listaVariables(indice, 1) += 1
                                    Case 3
                                        pb.Image = My.Resources.ave4
                                        listaVariables(indice, 1) += 1

                                        If vida2 <= 1 Then
                                            vida2 = 0
                                        Else
                                            vida2 -= 10
                                        End If
                                        ActVida2(vida2, 1)

                                    Case 4
                                        pb.Image = My.Resources.ave5
                                        listaVariables(indice, 1) += 1
                                    Case 5
                                        pb.Image = My.Resources.ave6
                                        listaVariables(indice, 1) += 1
                                    Case 6
                                        pb.Image = My.Resources.ave7
                                        listaVariables(indice, 1) += 1
                                    Case 7
                                        pb.Image = My.Resources.ave8
                                        listaVariables(indice, 1) = 0



                                        If vida2 <= 1 Then
                                            vida2 = 0
                                        Else
                                            vida2 -= 10
                                        End If
                                        ActVida2(vida2, 1)


                                End Select

                            End If

                        ElseIf Math.Abs(principal2.Location.X - pb.Location.X) > 400 Then

                            Select Case listaVariables(indice, 2)

                                Case 0
                                    pb.Image = My.Resources.ave1
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 1
                                    pb.Image = My.Resources.ave2
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 2
                                    pb.Image = My.Resources.ave3
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 3
                                    pb.Image = My.Resources.ave4
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 4
                                    pb.Image = My.Resources.ave5
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 5
                                    pb.Image = My.Resources.ave6
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 6
                                    pb.Image = My.Resources.ave7
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1
                                Case 7
                                    pb.Image = My.Resources.ave8
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    listaVariables(indice, 2) += 1


                                Case 8
                                    pb.Image = My.Resources.ave1
                                    listaVariables(indice, 2) += 1
                                Case 9
                                    pb.Image = My.Resources.ave2
                                    listaVariables(indice, 2) += 1
                                Case 10
                                    pb.Image = My.Resources.ave3
                                    listaVariables(indice, 2) += 1
                                Case 11
                                    pb.Image = My.Resources.ave4
                                    listaVariables(indice, 2) += 1
                                Case 12
                                    pb.Image = My.Resources.ave5
                                    listaVariables(indice, 2) += 1
                                Case 13
                                    pb.Image = My.Resources.ave6
                                    listaVariables(indice, 2) += 1
                                Case 14
                                    pb.Image = My.Resources.ave7
                                    listaVariables(indice, 2) += 1
                                Case 15
                                    pb.Image = My.Resources.ave8
                                    listaVariables(indice, 2) = 0


                            End Select

                        End If

                    Else

                        Select Case listaVariables(indice, 2)

                            Case 0
                                pb.Image = My.Resources.ave1
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 1
                                pb.Image = My.Resources.ave2
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 2
                                pb.Image = My.Resources.ave3
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 3
                                pb.Image = My.Resources.ave4
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 4
                                pb.Image = My.Resources.ave5
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 5
                                pb.Image = My.Resources.ave6
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 6
                                pb.Image = My.Resources.ave7
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1
                            Case 7
                                pb.Image = My.Resources.ave8
                                pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                listaVariables(indice, 2) += 1


                            Case 8
                                pb.Image = My.Resources.ave1
                                listaVariables(indice, 2) += 1
                            Case 9
                                pb.Image = My.Resources.ave2
                                listaVariables(indice, 2) += 1
                            Case 10
                                pb.Image = My.Resources.ave3
                                listaVariables(indice, 2) += 1
                            Case 11
                                pb.Image = My.Resources.ave4
                                listaVariables(indice, 2) += 1
                            Case 12
                                pb.Image = My.Resources.ave5
                                listaVariables(indice, 2) += 1
                            Case 13
                                pb.Image = My.Resources.ave6
                                listaVariables(indice, 2) += 1
                            Case 14
                                pb.Image = My.Resources.ave7
                                listaVariables(indice, 2) += 1
                            Case 15
                                pb.Image = My.Resources.ave8
                                listaVariables(indice, 2) = 0


                        End Select

                    End If


                ElseIf pb.Location.X + pb.Width >= pnlFinal.Location.X Then

                    Select Case listaVariables(indice, 3)

                        Case 0
                            pb.Image = My.Resources.ave1
                            listaVariables(indice, 3) += 1
                        Case 1
                            pb.Image = My.Resources.ave2
                            listaVariables(indice, 3) += 1
                        Case 2
                            pb.Image = My.Resources.ave3
                            listaVariables(indice, 3) += 1
                        Case 3
                            pb.Image = My.Resources.ave4
                            listaVariables(indice, 3) += 1
                        Case 4
                            pb.Image = My.Resources.ave1
                            listaVariables(indice, 3) = 0

                    End Select


                ElseIf pb.Location.X <= pnlInicio.Location.X + pnlInicio.Width Then

                    Select Case listaVariables(indice, 3)

                        Case 0
                            pb.Image = My.Resources.ave1
                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                            listaVariables(indice, 3) += 1
                        Case 1
                            pb.Image = My.Resources.ave2
                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                            listaVariables(indice, 3) += 1
                        Case 2
                            pb.Image = My.Resources.ave3
                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                            listaVariables(indice, 3) += 1
                        Case 3
                            pb.Image = My.Resources.ave4
                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                            listaVariables(indice, 3) += 1
                        Case 4
                            pb.Image = My.Resources.ave1
                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                            listaVariables(indice, 3) = 0

                    End Select


                End If


            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ActVida2(ByVal v As Double, ByVal dire As Integer)

        pnlVida2.Width = v
        lblNumero2.Text = v.ToString

        If v = 0 Then

            If verificarVida = 0 Then

                principal2.Location = New Point(-50, -50)

                principal2.Dispose()

                moviVertical2 = "dead"
                verificarVida2 = 1

            ElseIf verificarVida = 1 Then

                moviVertical = "dead"
                Movimiento_Principal.Dispose()
                Anim_Movimiento_Principal.Dispose()
                Anim_Movimiento_Enemigo.Dispose()
                Movimiento_Bala.Dispose()

                For Each ctrl As Control In Me.Controls
                    ctrl.Visible = False
                Next
                lblFinal.Visible = True
                lblFinal.Text = "Game Over" + vbNewLine + vbNewLine + "Puntos conseguidos jugador1: " + puntos.ToString + vbNewLine + "Puntos conseguidos jugador2: " + puntos2.ToString

                Try
                    Dim nombre As String = ""
                    While nombre = ""

                        nombre = InputBox("Ingrese su nombre Jugador 1", "Registro")

                    End While


                    Dim regDate As Date = Date.Now()

                    Dim fecha As String = regDate.ToString("yyyy-MM-dd")
                    Dim hora As String = regDate.ToString("hh:mm:ss")



                    Consulta = "insert into resultados (nombre, fecha, hora, resultado) values ('" + nombre + "', '" + fecha + "', '" + hora + "','" + puntos.ToString + "');"
                    consultar()

                    frmRanking.actTabla()

                    Try
                        Dim nombre2 As String = ""
                        While nombre2 = ""

                            nombre2 = InputBox("Ingrese su nombre Jugador 2", "Registro")

                        End While


                        Dim regDate2 As Date = Date.Now()

                        Dim fecha2 As String = regDate.ToString("yyyy-MM-dd")
                        Dim hora2 As String = regDate.ToString("hh:mm:ss")



                        Consulta = "insert into resultados (nombre, fecha, hora, resultado) values ('" + nombre2 + "', '" + fecha2 + "', '" + hora2 + "','" + puntos2.ToString + "');"
                        consultar()

                        frmRanking.actTabla()

                        MsgBox("Guardado", MsgBoxStyle.Information)

                        Me.Dispose()

                    Catch ex As Exception
                        MsgBox("Error al guardar", MsgBoxStyle.Exclamation)
                    End Try


                Catch ex As Exception
                    MsgBox("Error al guardar", MsgBoxStyle.Exclamation)
                End Try

            End If

        ElseIf v = 100 Then

            Anim_Idle_Principal.Start()

        Else
            'Anim_Idle_Principal_2.Dispose()

            If dire = 0 Then
                principal2.Image = My.Resources.hurt1
            Else
                principal2.Image = My.Resources.hurt1
                principal2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If

            Anim_Idle_Principal.Start()

        End If


    End Sub
    Private Sub ActVida(ByVal v As Double, ByVal dire As Integer)

        pnlVida.Width = v
        lblNumero.Text = v.ToString

        If v = 0 Then

            If verificarVida2 = 0 Then

                principal.Location = New Point(-50, -50)
                principal.Dispose()

                verificarVida = 1
                moviVertical = "dead"

            ElseIf verificarVida2 = 1 Then

                principal.Location = New Point(-50, -50)
                principal.Dispose()


                moviVertical = "dead"
                Movimiento_Principal.Dispose()
                Anim_Movimiento_Principal.Dispose()
                Anim_Movimiento_Enemigo.Dispose()
                Movimiento_Bala.Dispose()

                For Each ctrl As Control In Me.Controls
                    ctrl.Visible = False
                Next
                lblFinal.Visible = True
                lblFinal.Text = "Game Over" + vbNewLine + vbNewLine + "Puntos conseguidos jugador1: " + puntos.ToString + vbNewLine + "Puntos conseguidos jugador2: " + puntos2.ToString

                Try
                    Dim nombre As String = ""
                    While nombre = ""

                        nombre = InputBox("Ingrese su nombre Jugador 1", "Registro")

                    End While


                    Dim regDate As Date = Date.Now()

                    Dim fecha As String = regDate.ToString("yyyy-MM-dd")
                    Dim hora As String = regDate.ToString("hh:mm:ss")



                    Consulta = "insert into resultados (nombre, fecha, hora, resultado) values ('" + nombre + "', '" + fecha + "', '" + hora + "','" + puntos.ToString + "');"
                    consultar()

                    frmRanking.actTabla()

                    Try
                        Dim nombre2 As String = ""
                        Do

                            nombre2 = InputBox("Ingrese su nombre (Jugador 2)", "Registro")

                        Loop While nombre2 = ""


                        Dim regDate2 As Date = Date.Now()

                        Dim fecha2 As String = regDate.ToString("yyyy-MM-dd")
                        Dim hora2 As String = regDate.ToString("hh:mm:ss")



                        Consulta = "insert into resultados (nombre, fecha, hora, resultado) values ('" + nombre2 + "', '" + fecha2 + "', '" + hora2 + "','" + puntos2.ToString + "');"
                        consultar()

                        frmRanking.actTabla()

                        MsgBox("Guardado", MsgBoxStyle.Information)

                        Me.Dispose()

                    Catch ex As Exception
                        MsgBox("Error al guardar", MsgBoxStyle.Exclamation)
                    End Try


                Catch ex As Exception
                    MsgBox("Error al guardar", MsgBoxStyle.Exclamation)
                End Try

            End If

        ElseIf v = 100 Then


            Anim_Idle_Principal.Start()

        Else
            Anim_Idle_Principal.Dispose()

            If dire = 0 Then
                principal.Image = My.Resources.hurt
            Else
                principal.Image = My.Resources.hurt
                principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If


            Anim_Idle_Principal.Start()
        End If


    End Sub



    Private Sub ubicarEstrella()

        estrella.Visible = False

        Dim x
        Dim y

        Randomize()
        x = Int(((pnlFinal.Location.X - estrella.Width) * Rnd()) + (pnlInicio.Location.X + pnlInicio.Width))

        Randomize()
        y = Int(((pnlPiso.Location.Y - estrella.Height) * Rnd()) + 1)


        estrella.Location = New Point(x, y)

        Dim control As Integer = 0

        For Each ctrl As Control In Me.Controls


            If ctrl.Bounds.IntersectsWith(estrella.Bounds) And (TypeOf ctrl Is Panel Or TypeOf ctrl Is Label Or ctrl.Name = pbNumeroEstrellas.Name Or ctrl.Name = pbNumeroEstrella2.Name) Then


                control = 1

            End If
        Next

        If control = 0 Then

            estrella.Image = My.Resources.Estrella
            estrella.Visible = True
        Else

            ubicarEstrella()

        End If

    End Sub




    Private Sub BestoGame_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        frmRanking.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
    End Sub

    Private Sub Movimiento_Bala_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Bala.Tick

        If pbBala.Location.X < pnlInicio.Location.X + pnlInicio.Width Then

            pbBala.Location = New Point(pbBala.Location.X + 5, pbBala.Location.Y)
            pbBala.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            direc = 0

        ElseIf pbBala.Location.X + pbBala.Width > pnlFinal.Location.X Then

            pbBala.Location = New Point(pbBala.Location.X - 5, pbBala.Location.Y)
            pbBala.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            direc = 1

        End If

        If direc = 0 Then
            pbBala.Location = New Point(pbBala.Location.X + 5, pbBala.Location.Y)
        ElseIf direc = 1 Then
            pbBala.Location = New Point(pbBala.Location.X - 5, pbBala.Location.Y)
        End If

        If pbBala.Bounds.IntersectsWith(principal.Bounds) Then

            ActVida(0, 2)

        End If
        If pbBala.Bounds.IntersectsWith(principal2.Bounds) Then

            ActVida2(0, 2)

        End If
    End Sub

 

    Private Sub Movimiento_Principal_2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class