Imports System.ComponentModel

Public Class frmSinglePlayerMode

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
    Dim avanzar2 As Double = avanzar
    Dim limvel2 As Double = limvel
    Dim salto2 As Double = salto
    Dim pixSubida2 As Double = pixSubida
    Dim caida2 As Double = caida


    Dim pan As New Panel
    Dim lado As Integer = 0
    Dim cont As Integer = 0

    Dim stand As Integer = 0
    Dim foto As Integer = 0

    Dim idle As Integer = 0


    Dim pb As PictureBox

    Dim d As Integer = 0
    Dim a As Integer = 0

    '0 equivale a caer y 1 a subir
    Dim moviVertical As String = ""

    Dim vida As Double = 100

    Dim listaPB As List(Of PictureBox) = New List(Of PictureBox)

    Dim listaVariables(,) As Integer


    Dim final As Integer = 0

    Dim pnlFinal As Panel

    Dim puntos As Integer = 0

    Dim direc As Integer = 0

    Dim caso As Integer = 0


    Private Sub BestoGame_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed

        frmRanking.Dispose()
        frmMenuInicio.Show()
        frmMenuInicio.actTabla()

    End Sub

    Private Sub SinglePlayerMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        pbBala.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

        pnlFinal = Panel9


        frmRanking.Show()
        frmRanking.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
        frmRanking.actTabla()

        ActVida(vida, 0)

        moviVertical = "0"

        Dim cont As Integer = 0

        For Each ctrl As Control In Me.Controls

            Dim pb As PictureBox = Nothing
            Try
                pb = ctrl

                If pb.Name <> principal.Name And pb.Name <> pnlVida.Name And pb.Name <> estrella.Name And pb.Name <> pbNumeroEstrellas.Name And pb.Name <> pbBala.Name And pb.Name <> pbCosaR.Name Then

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
        ubicarRandom()



    End Sub


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If vida <> 0 Then

            'Al presionar la tecla A
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then


                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla la primera vez
                If a = 0 And d = 0 Then

                    principal.Image = My.Resources.correr5

                End If

                'Indico de que lado debe estar la animacion de correr (izquierda)
                lado = 0

                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                a = 1


            End If

            'Al presionar la tecla D
            If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then

                'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla
                If d = 0 And a = 0 And vida <> 0 Then

                    principal.Image = My.Resources.correr5
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                'Indico de que lado debe estar la animacion de correr (derecha)
                lado = 1


                'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
                d = 1


            End If

            'Al presionar la tecla W o la barra
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then

                'Verifico que no este descendiedo para que asi no salta en el aire
                If moviVertical = "" Then

                    'Inicio el ascenso y la animación del mismo
                    moviVertical = "1"

                End If

            End If

            'Al presionar la tecla S
            If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then

                If pan IsNot pnlPiso Then

                    'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
                    If moviVertical = "" And principal.Location.Y < pan.Location.Y Then

                        'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                        principal.Location = New Point(principal.Location.X, pan.Location.Y + 20)
                        moviVertical = "0"

                    End If

                End If

            End If
        End If


    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        If vida <> 0 Then

            'Al soltar la tecla A
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then

                'Si la tecla D sigue presionada,  entonces se debe mover a la derecha
                If d = 1 Then

                    'Se apaga la animacion de idle, se indica el lado y se enciende la animacion de correr a la derecha

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
            If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then

                'Si la tecla A sigue presionada,  entonces se debe mover a la izquierda
                If a = 1 Then

                    'Se apaga la animacion de idle, se indica el lado y se enciende la animacion de correr a la izquierda

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



    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Principal.Tick

        If estrella.Location.X + estrella.Width - 10 > principal.Location.X And estrella.Location.X + 10 < principal.Location.X + principal.Width And estrella.Location.Y + estrella.Height - 10 > principal.Location.Y And estrella.Location.Y < principal.Location.Y + principal.Height - 10 Then
            ubicarEstrella()
            puntos += 1
            lblPuntos.Text = ": " + puntos.ToString
        End If

        If principal.Location.X + principal.Width > pbCosaR.Location.X And principal.Location.X < pbCosaR.Location.X + pbCosaR.Width And principal.Location.Y + principal.Height > pbCosaR.Location.Y And principal.Location.Y < pbCosaR.Location.Y + pbCosaR.Height Then

            pbCosaR.Location = New Point(-50, -50)


            Randomize()
            caso = Int((15 * Rnd()) + 1)


            Select Case caso


                Case 1

                    Movimiento_Enemigo.Interval -= 10
                    notificar("Velocidad Enemigos 10% mas rápido")

                Case 2

                    Movimiento_Enemigo.Interval += 10
                    notificar("Velocidad Enemigos 10% mas lento")

                Case 3

                    Movimiento_Principal.Interval += 10
                    notificar("Velocidad jugador enlentecido 10%")

                Case 4
                    Movimiento_Bala.Interval -= 4
                    notificar("Velocidad Bala 4% mas rápido")

                Case 5

                    vida += 10
                    ActVida(vida, 2)
                    notificar("Vida +10")


                Case 6

                    Movimiento_Principal.Interval -= 4
                    notificar("Velocidad jugador aumento 10%")

                Case 7
                    Movimiento_Bala.Interval += 10
                    notificar("Velocidad Bala 10% mas lento")
                Case 8

                    Movimiento_Enemigo.Stop()
                    Anim_Movimiento_Enemigo.Stop()
                    notificar("Enemigos congelados")

                Case 9

                    Movimiento_Enemigo.Interval -= 10
                    notificar("Velocidad Enemigos 10% mas rápido")

                Case 10

                    Movimiento_Enemigo.Interval += 10
                    notificar("Velocidad Enemigos 10% mas lento")

                Case 11

                    Movimiento_Principal.Interval += 10
                    notificar("Velocidad jugador enlentecido 10%")

                Case 12
                    Movimiento_Bala.Interval -= 4
                    notificar("Velocidad Bala 4% mas rápido")

                Case 13

                    vida += 10
                    ActVida(vida, 2)
                    notificar("Vida +10")


                Case 14

                    Movimiento_Principal.Interval -= 4
                    notificar("Velocidad jugador aumento 10%")

                Case 15
                    Movimiento_Bala.Interval += 10
                    notificar("Velocidad Bala 10% mas lento")

            End Select

            cosaRandom.Start()

        End If

        '/////////////////////////////////////////////////////////// Movimiento Vertical /////////////////////////////////////////////////////////////////////////
        If moviVertical <> "" Then

            '////////////////////// Descenso /////////////////////////////////
            If moviVertical = "0" Then

                'Si el PictureBox se encuentra sobre el Panel a una distancia menor a 20 pixeles
                If principal.Location.Y + principal.Height >= (pan.Location.Y - 20) And principal.Location.Y + principal.Height <= pan.Location.Y And principal.Location.X > pan.Location.X - principal.Width + 5 And principal.Location.X < (pan.Location.X + pan.Width - 5) Then


                    'Mi objetivo es reubicarlo en un punto por defecto del eje 
                    principal.Location = New Point(principal.Location.X, pan.Location.Y - principal.Height - 5)

                    'Desactivo la animacion de bajada y el descenso. Además enciendo la animacion idle
                    moviVertical = ""


                    'Restablecemos las variables a los valores iniciales
                    caida2 = caida


                End If

                'Si el punto en donde quedaría el PictureBox al bajar sigue siendo menor a la del suelo
                If (principal.Location.Y + principal.Height + caida2) <= pnlPiso.Location.Y Then

                    'Descendemos el mismo segun la variable caida2
                    principal.Location = New Point(principal.Location.X, principal.Location.Y + caida2)

                    'Le sumamos a la caida2 la aceleracion, de esta forma acelera mientras cae
                    caida2 += acelcaida

                    'De lo contrario, si la distancia del PictureBox sigue siendo inferior al suelo pero no lo suficiente para sumarle la caida
                ElseIf principal.Location.Y + principal.Height <= pnlPiso.Location.Y Then

                    'Descendemos el PictureBox al suelo
                    principal.Location = New Point(principal.Location.X, pnlPiso.Location.Y - principal.Height)

                    'Restablecemos las variables a los valores iniciales
                    caida2 = caida

                    'Desactivo la animacion de bajada y el descenso. Además enciendo la animacion idle

                    moviVertical = ""



                End If

                '////////////////////// Ascenso /////////////////////////////////
            ElseIf moviVertical = "1" Then


                'Utilizo un contador para ver si se hicieron los movimientos verticales suficientes
                If cont <= salto2 Then

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

            If Math.Abs((principal.Location.Y + principal.Height) - pan.Location.Y) > 5 And moviVertical = "" Then

                moviVertical = "0"
            End If
        End If

    End Sub

    Private Sub Idle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Idle_Principal.Tick
        If ((a = 1 And d = 1) Or (a = 0 And d = 0)) And moviVertical = "" Then
            'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
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



    Private Sub SaltoAnima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Movimiento_Principal.Tick


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

                'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    principal.Image = My.Resources.salto

                ElseIf lado = 1 Then

                    principal.Image = My.Resources.salto
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                '0 se utiliza para indicar descenso
            ElseIf moviVertical = "0" Then

                'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    principal.Image = My.Resources.caida

                ElseIf lado = 1 Then

                    principal.Image = My.Resources.caida
                    principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If
            End If
        End If



    End Sub



    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encontrar_Suelo_Principal.Tick

        Dim panelfinal As Panel = pnlPiso
        Dim dy As Integer = 1000

        For Each ctrl As Control In Me.Controls

            If TypeOf ctrl Is Panel Then


                '   si el valor de la resta de la ubicacion (Y) del objeto y del personaje es menor a dy  y si el objeto esta debajo del personaje(picturebox1) y si el objeto no es el personaje(picturebox1) y si el objeto no es el piso(panel1)
                If Math.Abs(ctrl.Location.Y - (principal.Location.Y + principal.Height)) < dy And ctrl.Location.Y >= (principal.Location.Y + principal.Height - 10) And ctrl.Name <> pnlVida.Name Then

                    '                si el personaje esta adentro del piso (si el picturebox1 esta adentro del limite del objeto que esta de bajo (eje x))
                    If principal.Location.X >= ctrl.Location.X - principal.Width + 5 And principal.Location.X < (ctrl.Location.X + ctrl.Width - 5) Then

                        ' si se verifica lo anterior el panel final es el objeto donde esta el personaje
                        panelfinal = ctrl

                        ' y el dy es la distancia entre el picturebox y el suelo
                        dy = Math.Abs(ctrl.Location.Y - (principal.Location.Y + principal.Height))


                    End If


                End If

            End If


        Next

        pan = panelfinal



    End Sub



    Private Sub Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Enemigo.Tick


        For indice = 0 To listaPB.Count - 1

            pb = listaPB(indice)

            Try


                If pb.Name <> principal.Name Then

                    If pb.Location.X > pnlInicio.Location.X + pnlInicio.Width And pb.Location.X + pb.Width < pnlFinal.Location.X Then


                        If Math.Abs(principal.Location.X - pb.Location.X) < 400 And Math.Abs(principal.Location.Y - pb.Location.Y) <= 10 And Math.Abs(principal.Location.X - pb.Location.X) > 60 Then

                            If pb.Location.X < principal.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > principal.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf Math.Abs(principal.Location.X - pb.Location.X) > 400 Or Math.Abs(principal.Location.Y - pb.Location.Y) > 10 Then


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

                End If






            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Anim_Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Movimiento_Enemigo.Tick
        For indice = 0 To listaPB.Count - 1

            pb = listaPB(indice)


            Try

                If pb.Name <> principal.Name And pb.Name <> pbBala.Name Then

                    If pb.Location.X > 0 And pb.Location.X < pnlFinal.Location.X Then

                        If Math.Abs(principal.Location.X - pb.Location.X) < 400 And Math.Abs(principal.Location.Y - pb.Location.Y) <= 10 And Math.Abs(principal.Location.X - pb.Location.X) > 60 Then

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
                        ElseIf Math.Abs(principal.Location.Y - pb.Location.Y) <= 10 And Math.Abs(principal.Location.X - pb.Location.X) <= 60 Then




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



                            Else

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



                        ElseIf pb.Location.X > pnlInicio.Location.X + pnlInicio.Width And pb.Location.X + pb.Width < pnlFinal.Location.X Then


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

                    ElseIf pb.Location.X >= 725 Then

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

                    End If



                End If





            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ActVida(ByVal v As Double, ByVal dire As Integer)


        If v = 0 Then


            moviVertical = "dead"
            Movimiento_Principal.Dispose()
            Anim_Movimiento_Principal.Dispose()
            Anim_Movimiento_Enemigo.Dispose()
            Movimiento_Bala.Dispose()
            cosaRandom.Dispose()

            For Each ctrl As Control In Me.Controls
                ctrl.Visible = False
            Next
            lblFinal.Visible = True
            lblFinal.Text = "Game Over" + vbNewLine + vbNewLine + "Puntos conseguidos: " + puntos.ToString
            txbCedula.Visible = True
            txbNombre.Visible = True
            btnRegistrar.Visible = True


        ElseIf v = 100 Then

            pnlVida.Width = v
            lblNumero.Text = v.ToString
            Anim_Idle_Principal.Start()

        Else
            Anim_Idle_Principal.Dispose()

            If dire = 0 Then
                principal.Image = My.Resources.hurt
            ElseIf dire = 1 Then
                principal.Image = My.Resources.hurt
                principal.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If

            pnlVida.Width = v
            lblNumero.Text = v.ToString
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


            If ctrl.Bounds.IntersectsWith(estrella.Bounds) And (TypeOf ctrl Is Panel Or TypeOf ctrl Is Label Or ctrl.Name = pbNumeroEstrellas.Name) Then


                control = 1

            End If
        Next

        If control = 0 Then


            estrella.Visible = True
        Else

            ubicarEstrella()

        End If

    End Sub



    Private Sub BestoGame_Move(ByVal sender As Object, ByVal e As System.EventArgs)
        frmRanking.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
    End Sub

    Private Sub cosaRandom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosaRandom.Tick
        ubicarRandom()
        lblPowerUp.Hide()

        Movimiento_Enemigo.Interval = 50
        Movimiento_Enemigo.Start()
        Anim_Movimiento_Enemigo.Start()
        Movimiento_Bala.Interval = 5
        Movimiento_Principal.Interval = 5
        Anim_Movimiento_Enemigo.Interval = 120

        cosaRandom.Dispose()
    End Sub

    Private Sub ubicarRandom()


        Dim x
        Dim y

        Randomize()
        x = Int(((pnlFinal.Location.X - estrella.Width) * Rnd()) + (pnlInicio.Location.X + pnlInicio.Width))

        Randomize()
        y = Int(((pnlPiso.Location.Y - estrella.Height) * Rnd()) + 1)


        pbCosaR.Location = New Point(x, y)

        Dim control As Integer = 0

        For Each ctrl As Control In Me.Controls


            If ctrl.Bounds.IntersectsWith(pbCosaR.Bounds) And (TypeOf ctrl Is Panel Or TypeOf ctrl Is Label Or ctrl.Name = pbNumeroEstrellas.Name) Then


                control = 1

            End If
        Next

        If control = 0 Then

            pbCosaR.Visible = True


        Else

            ubicarRandom()

        End If
    End Sub

    Private Sub notificar(ByVal texto As String)

        lblPowerUp.Show()
        lblPowerUp.Text = texto

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
            Movimiento_Bala.Dispose()

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        If txbCedula.Text = "" Or txbNombre.Text = "" Or txbCedula.ForeColor = Color.Gray Or txbNombre.ForeColor = Color.Gray Then

            MsgBox("Complete los campos", MsgBoxStyle.Exclamation)

        ElseIf verificarCedula(txbCedula.Text) = False Then

            MsgBox("Cédula no válida", MsgBoxStyle.Exclamation)

        Else

            ceduJug = txbCedula.Text
            nombreJug = txbNombre.Text

            Try




                Dim regDate As Date = Date.Now()

                Dim fecha As String = regDate.ToString("yyyy-MM-dd")
                Dim hora As String = regDate.ToString("hh:mm:ss")



                Consulta = "insert into resultados (nombre, fecha, hora, resultado, cedula) values ('" + nombreJug + "', '" + fecha + "', '" + hora + "','" + puntos.ToString + "','" + ceduJug + "');"
                consultar()

                frmRanking.actTabla()

                MsgBox("Guardado", MsgBoxStyle.Information)

                Me.Dispose()
                frmMenuInicio.Show()
                frmMenuInicio.actTabla()

            Catch ex As Exception
                MsgBox("Error al guardar", MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Function verificarCedula(ByVal cedula As String)

        If cedula.Length = 8 And IsNumeric(cedula) Then
            Try

                Dim cedulaChar(7) As Char
                Dim suma As Integer
                Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

                cedulaChar = cedula.ToCharArray()

                For i = 0 To 6
                    Dim num1 As Integer = Val(cedulaChar(i))
                    suma = (num1 * calculo(i)) + suma
                Next

                cedulaChar = cedula.ToCharArray()

                Dim liResto As Integer = 10 - (suma Mod 10)

                If liResto = 10 Then
                    liResto = 0
                End If


                If liResto = Val(cedulaChar(7)) Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception

                Return False

            End Try

        Else

            Return False

        End If

    End Function


    Private Sub frmSinglePlayerMode_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        frmRanking.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
    End Sub

    Private Sub frmSinglePlayerMode_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If vida = 0 Then

            e.Cancel = True
            MsgBox("Debe registrarse primero", MsgBoxStyle.Exclamation)

        End If
    End Sub


End Class
