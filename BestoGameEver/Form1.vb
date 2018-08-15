Public Class Form1

    '////////////////////////////////////PERSONALIZACION///////////////////////
    Public avanzar As Double = 5
    Public acelereacion As Double = 0
    Public limvel As Double = 5
    Public salto As Double = 15
    Public pixSubida As Double = 5
    Public desasubida As Double = 0.01
    Public caida As Double = 5
    Public acelcaida As Double = 0.01
    '//////////////////////////////////////////////////////////////////////////

    'Utilizo una copia de las variables para luego devolverlas al valor inicial
    Dim avanzar2 As Double = avanzar
    Dim acelereacion2 As Double = acelereacion
    Dim limvel2 As Double = limvel
    Dim salto2 As Double = salto
    Dim pixSubida2 As Double = pixSubida
    Dim desasubida2 As Double = desasubida
    Dim caida2 As Double = caida
    Dim acelcaida2 As Double = acelcaida

    Dim pan As New Panel
    Dim lado As Integer = 0
    Dim cont As Integer = 0

    Dim stand As Integer = 0
    Dim foto As Integer = 0

    Dim idle As Integer = 0
    Dim standE As Integer = 0
    Dim fotoE As Integer = 0

    Dim d As Integer = 0
    Dim a As Integer = 0

    '0 equivale a caer y 1 a subir
    Dim moviVertical As String = ""

    Dim vida As Double = 200

    Dim listaPB As List(Of PictureBox) = New List(Of PictureBox)






    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Al presionar la tecla A
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then


            'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla la primera vez
            If a = 0 And d = 0 Then

                PictureBox1.Image = My.Resources._17

            End If

            'Indico de que lado debe estar la animacion de correr (izquierda)
            lado = 0

            'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
            a = 1


        End If

        'Al presionar la tecla D
        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
           
            'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla
            If d = 0 And a = 0 Then

                PictureBox1.Image = My.Resources._17
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

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
           
            'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
            If moviVertical = "" And PictureBox1.Location.Y < pan.Location.Y Then

                'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + pan.Height)
                moviVertical = "0"

            End If
        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'Al soltar la tecla A
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then

            'Si la tecla D sigue presionada,  entonces se debe mover a la derecha
            If d = 1 Then

                'Se apaga la animacion de idle, se indica el lado y se enciende la animacion de correr a la derecha

                lado = 1

                'Sino, que se detenga y que se encienda la animacion idle
            Else

                'Determino esta imagen para mostrar como al soltar, se detiene el caminar
                PictureBox1.Image = My.Resources._0

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
                PictureBox1.Image = My.Resources._0
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)


            End If

            'Se restaura la aceleracion a la inicial
            avanzar2 = avanzar

            'Se indica que la tecla D ya no está presionada
            d = 0

        End If
        

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Principal.Tick

      
        '/////////////////////////////////////////////////////////// Movimiento Vertical /////////////////////////////////////////////////////////////////////////
        If moviVertical <> "" Then

            '////////////////////// Descenso /////////////////////////////////
            If moviVertical = "0" Then

                'Si el PictureBox se encuentra sobre el Panel a una distancia menor a 20 pixeles
                If PictureBox1.Location.Y + PictureBox1.Height >= (pan.Location.Y - 20) And PictureBox1.Location.Y + PictureBox1.Height <= pan.Location.Y And PictureBox1.Location.X > pan.Location.X - PictureBox1.Width + 5 And PictureBox1.Location.X < (pan.Location.X + pan.Width - 5) Then


                    'Mi objetivo es reubicarlo en un punto por defecto del eje 
                    PictureBox1.Location = New Point(PictureBox1.Location.X, pan.Location.Y - PictureBox1.Height - 5)

                    'Desactivo la animacion de bajada y el descenso. Además enciendo la animacion idle
                    moviVertical = ""


                    'Restablecemos las variables a los valores iniciales
                    caida2 = caida
                    acelcaida2 = acelcaida

                End If

                'Si el punto en donde quedaría el PictureBox al bajar sigue siendo menor a la del suelo
                If (PictureBox1.Location.Y + caida2) <= 299 Then

                    'Descendemos el mismo segun la variable caida2
                    PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + caida2)

                    'Le sumamos a la caida2 la aceleracion, de esta forma acelera mientras cae
                    caida2 += acelcaida2

                    'De lo contrario, si la distancia del PictureBox sigue siendo inferior al suelo pero no lo suficiente para sumarle la caida
                ElseIf PictureBox1.Location.Y <= 299 Then

                    'Descendemos el PictureBox al suelo
                    PictureBox1.Location = New Point(PictureBox1.Location.X, 299)

                    'Restablecemos las variables a los valores iniciales
                    caida2 = caida
                    acelcaida2 = acelcaida

                    'Desactivo la animacion de bajada y el descenso. Además enciendo la animacion idle

                    moviVertical = ""



                End If

                '////////////////////// Ascenso /////////////////////////////////
            ElseIf moviVertical = "1" Then


                'Utilizo un contador para ver si se hicieron los movimientos verticales suficientes
                If cont <= salto2 Then

                    'El PictureBox se eleva la cantidad que esta en pixSubida2
                    PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - pixSubida2)

                    'Le sumo 1 al contador
                    cont += 1

                    'La subida debe ser cada vez mas lenta por la gravedad, por eso le resto
                    pixSubida2 -= desasubida2



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
           
            If PictureBox1.Location.X >= Panel2.Location.X - PictureBox1.Width And PictureBox1.Location.Y + PictureBox1.Height > Panel2.Location.Y And PictureBox1.Location.X < Panel2.Location.X + (Panel2.Width / 2) Then

                PictureBox1.Location = New Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y)

            ElseIf PictureBox1.Location.X <= Panel2.Location.X + Panel2.Width And PictureBox1.Location.Y + PictureBox1.Height > Panel2.Location.Y And PictureBox1.Location.X > Panel2.Location.X + (Panel2.Width / 2) Then

                PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)

            ElseIf PictureBox1.Location.X <= 53 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)

            ElseIf PictureBox1.Location.X >= Panel2.Location.X + Panel2.Width Then


                Movimiento_Enemigo.Dispose()
                Anim_Movimiento_Enemigo.Dispose()

            End If

            'Si solo la tecla D está presionada
            If d = 1 And a = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                PictureBox1.Location = New Point(PictureBox1.Location.X + avanzar2, PictureBox1.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = "" And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion2

                End If


                'Si solo la tecla A está presionada
            ElseIf a = 1 And d = 0 Then


                'El PictureBox avanza lo que esta en la variable avanzar2
                PictureBox1.Location = New Point(PictureBox1.Location.X - avanzar2, PictureBox1.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = "" And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion2

                End If


            End If

            'Si el PictureBox no está ascendiendo ni bajando
            If moviVertical = "" Then

                'Si el PictureBox esta a la izquierda o la derecha del Panel (Plataforma)
                If PictureBox1.Location.X < (pan.Location.X - PictureBox1.Width + 5) Or PictureBox1.Location.X > pan.Location.X + pan.Width - 10 Then

                    'Si el PictureBox esta por ensima del Panel4 (Plataforma)
                    If PictureBox1.Location.Y + PictureBox1.Height < pan.Location.Y + 1 Then

                        'Que inicie el descenso y la animación del mismo
                        moviVertical = "0"


                    End If

                End If

            End If
        End If

    End Sub



    


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicio la animación Idle y muestro el menu de configuraciones
        inicio.Show()
        ActVida(vida)
        moviVertical = "0"


        For Each ctrl As Control In Me.Controls
            Dim pb As PictureBox = Nothing
            Try
                pb = ctrl

                If pb.Name <> PictureBox1.Name Then

                    listaPB.Add(pb)

                End If


            Catch ex As Exception

            End Try

        Next
       
        
    End Sub
    

    Private Sub Idle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Idle_Principal.Tick
        If ((a = 1 And d = 1) Or (a = 0 And d = 0)) And moviVertical = "" Then
            'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
            If lado = 0 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand
                    Case 0
                        PictureBox1.Image = My.Resources._0
                        stand += 1
                    Case 1
                        PictureBox1.Image = My.Resources._1
                        stand += 1
                    Case 2
                        PictureBox1.Image = My.Resources._2
                        stand += 1
                    Case 3
                        PictureBox1.Image = My.Resources._3
                        stand += 1
                    Case 4
                        PictureBox1.Image = My.Resources._4
                        stand = 0
                End Select

            ElseIf lado = 1 Then

                'Utilizando la variable stand como contador, recorremos el select case una vuelta por tick.
                Select Case stand
                    Case 0
                        PictureBox1.Image = My.Resources._0
                        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 1
                        PictureBox1.Image = My.Resources._1
                        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 2
                        PictureBox1.Image = My.Resources._2
                        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 3
                        PictureBox1.Image = My.Resources._3
                        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        stand += 1
                    Case 4
                        PictureBox1.Image = My.Resources._4
                        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
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
                    PictureBox1.Image = My.Resources._17
                    foto += 1
                Case 1
                    PictureBox1.Image = My.Resources._16
                    foto += 1
                Case 2
                    PictureBox1.Image = My.Resources._15
                    foto += 1
                Case 3
                    PictureBox1.Image = My.Resources._14
                    foto += 1
                Case 4
                    PictureBox1.Image = My.Resources._13
                    foto = 0

            End Select
        ElseIf d = 1 And a = 0 And moviVertical = "" Then

            'Utilizando la variable foto como contador, recorremos el select case una vuelta por tick. Volteamos la imagen porque se mueve hacia adelante
            Select Case foto

                Case 0
                    PictureBox1.Image = My.Resources._17
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 1
                    PictureBox1.Image = My.Resources._16
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 2
                    PictureBox1.Image = My.Resources._15
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 3
                    PictureBox1.Image = My.Resources._14
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto += 1
                Case 4
                    PictureBox1.Image = My.Resources._13
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                    foto = 0

            End Select
        End If

        'Sin esta condicion, el personaje no dejaba de saltar
        If moviVertical <> "" Then

            '1 se utiliza para indicar ascenso
            If moviVertical = "1" Then

                'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    PictureBox1.Image = My.Resources.a

                ElseIf lado = 1 Then

                    PictureBox1.Image = My.Resources.a
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If

                '0 se utiliza para indicar descenso
            ElseIf moviVertical = "0" Then

                'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
                If lado = 0 Then

                    PictureBox1.Image = My.Resources.c

                ElseIf lado = 1 Then

                    PictureBox1.Image = My.Resources.c
                    PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                End If
            End If
        End If



    End Sub

  
   
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encontrar_Suelo_Principal.Tick

       

        Dim panelfinal As Control = PictureBox1 'el panelfinal es el personaje
        Dim dy As Integer = 1000

        For Each ctrl As Control In Me.Controls

            '   si el valor de la resta de la ubicacion (Y) del objeto y del personaje es menor a dy  y si el objeto esta debajo del personaje(picturebox1) y si el objeto no es el personaje(picturebox1) y si el objeto no es el piso(panel1)
            If ((ctrl.Location.Y + ctrl.Height) - (PictureBox1.Location.Y + PictureBox1.Height)) < dy And ctrl.Location.Y >= (PictureBox1.Location.Y + PictureBox1.Height) And ctrl.Name <> PictureBox1.Name And ctrl.Name <> Panel1.Name Then

                '                si el personaje esta adentro del piso (si el picturebox1 esta adentro del limite del objeto que esta de bajo (eje x))
                If PictureBox1.Location.X >= ctrl.Location.X - PictureBox1.Width + 5 And PictureBox1.Location.X < (ctrl.Location.X + ctrl.Width - 5) Then

                    ' si se verifica lo anterior el panel final es el objeto donde esta el personaje
                    panelfinal = ctrl

                    ' y el dy es la distancia entre el picturebox y el suelo
                    dy = ctrl.Location.Y - PictureBox1.Location.Y


                End If


            End If



        Next

        Try
            pan = panelfinal

        Catch ex As Exception

        End Try



    End Sub

    
   
    Private Sub Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Enemigo.Tick


        For Each pb As PictureBox In listaPB

            Try


                If pb.Name <> PictureBox1.Name Then

                    If pb.Location.X > Panel3.Location.X + Panel3.Width And pb.Location.X < 725 Then


                        If Math.Abs(PictureBox1.Location.X - pb.Location.X) < 400 And Math.Abs(PictureBox1.Location.Y - pb.Location.Y) <= 10 And Math.Abs(PictureBox1.Location.X - pb.Location.X) > 50 Then

                            If pb.Location.X < PictureBox1.Location.X Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            ElseIf pb.Location.X > PictureBox1.Location.X Then

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        ElseIf Math.Abs(PictureBox1.Location.Y - pb.Location.Y) <= 10 And Math.Abs(PictureBox1.Location.X - pb.Location.X) <= 50 Then




                        ElseIf pb.Location.X > 0 And pb.Location.X < 725 Then

                            If standE <= 4 Then

                                pb.Location = New Point(pb.Location.X + 7, pb.Location.Y)

                            Else

                                pb.Location = New Point(pb.Location.X - 7, pb.Location.Y)

                            End If

                        End If

                    ElseIf pb.Location.X >= 725 Then

                        pb.Location = New Point(pb.Location.X - 15, pb.Location.Y)

                    ElseIf pb.Location.X <= Panel3.Location.X + Panel3.Width Then

                        pb.Location = New Point(pb.Location.X + 15, pb.Location.Y)

                    End If

                End If






            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Anim_Movimiento_Enemigo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Movimiento_Enemigo.Tick
       
        For Each pb As PictureBox In listaPB

            Try

                If pb.Name <> PictureBox1.Name Then

                    If pb.Location.X > 0 And pb.Location.X < 725 Then

                        If Math.Abs(PictureBox1.Location.X - pb.Location.X) < 400 And Math.Abs(PictureBox1.Location.Y - pb.Location.Y) <= 10 And Math.Abs(PictureBox1.Location.X - pb.Location.X) > 50 Then

                            If pb.Location.X < PictureBox1.Location.X Then

                                Select Case fotoE

                                    Case 0
                                        pb.Image = My.Resources._17
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        fotoE += 1
                                    Case 1
                                        pb.Image = My.Resources._16
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        fotoE += 1
                                    Case 2
                                        pb.Image = My.Resources._15
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        fotoE += 1
                                    Case 3
                                        pb.Image = My.Resources._14
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        fotoE += 1
                                    Case 4
                                        pb.Image = My.Resources._13
                                        pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                        fotoE = 0

                                End Select

                            ElseIf pb.Location.X > PictureBox1.Location.X Then


                                Select Case fotoE

                                    Case 0
                                        pb.Image = My.Resources._17
                                        fotoE += 1
                                    Case 1
                                        pb.Image = My.Resources._16
                                        fotoE += 1
                                    Case 2
                                        pb.Image = My.Resources._15
                                        fotoE += 1
                                    Case 3
                                        pb.Image = My.Resources._14
                                        fotoE += 1
                                    Case 4
                                        pb.Image = My.Resources._13
                                        fotoE = 0

                                End Select

                            End If
                        ElseIf Math.Abs(PictureBox1.Location.Y - pb.Location.Y) <= 10 And Math.Abs(PictureBox1.Location.X - pb.Location.X) <= 50 Then

                            If vida <= 1 Then
                                vida = 0
                            Else
                                vida -= 5
                            End If

                            ActVida(vida)
                            If Not vida = 0 Then

                                If pb.Location.X < PictureBox1.Location.X Then

                                    Select Case fotoE
                                        Case 0
                                            pb.Image = My.Resources._24
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE += 1
                                        Case 1
                                            pb.Image = My.Resources._25
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE += 1
                                        Case 2
                                            pb.Image = My.Resources._26
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE += 1
                                        Case 3
                                            pb.Image = My.Resources._27
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE += 1
                                        Case 4
                                            pb.Image = My.Resources._28
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE += 1
                                        Case 5
                                            pb.Image = My.Resources._29
                                            pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                            fotoE = 0

                                    End Select



                                Else

                                    Select Case fotoE
                                        Case 0
                                            pb.Image = My.Resources._24
                                            fotoE += 1
                                        Case 1
                                            pb.Image = My.Resources._25
                                            fotoE += 1
                                        Case 2
                                            pb.Image = My.Resources._26
                                            fotoE += 1
                                        Case 3
                                            pb.Image = My.Resources._27
                                            fotoE += 1
                                        Case 4
                                            pb.Image = My.Resources._28
                                            fotoE += 1
                                        Case 5
                                            pb.Image = My.Resources._29
                                            fotoE = 0

                                    End Select

                                End If
                            Else
                                pb.Image = My.Resources._01
                                PictureBox1.Image = My.Resources._43
                                moviVertical = "dead"
                                Movimiento_Principal.Dispose()
                                Anim_Movimiento_Principal.Dispose()
                            End If


                        ElseIf pb.Location.X > 0 And pb.Location.X < 725 Then


                            Select Case standE
                                Case 0

                                    pb.Image = My.Resources._17
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    standE += 1
                                Case 1

                                    pb.Image = My.Resources._16
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    standE += 1
                                Case 2

                                    pb.Image = My.Resources._15
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    standE += 1
                                Case 3

                                    pb.Image = My.Resources._14
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    standE += 1
                                Case 4

                                    pb.Image = My.Resources._13
                                    pb.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                                    standE += 1
                                Case 5

                                    pb.Image = My.Resources._17
                                    standE += 1
                                Case 6

                                    pb.Image = My.Resources._16
                                    standE += 1
                                Case 7

                                    pb.Image = My.Resources._15
                                    standE += 1
                                Case 8

                                    pb.Image = My.Resources._14
                                    standE += 1
                                Case 9

                                    pb.Image = My.Resources._13
                                    standE = 0


                            End Select

                        End If

                    ElseIf pb.Location.X >= 725 Then

                        Select Case fotoE

                            Case 0
                                pb.Image = My.Resources._17
                                fotoE += 1
                            Case 1
                                pb.Image = My.Resources._16
                                fotoE += 1
                            Case 2
                                pb.Image = My.Resources._15
                                fotoE += 1
                            Case 3
                                pb.Image = My.Resources._14
                                fotoE += 1
                            Case 4
                                pb.Image = My.Resources._13
                                fotoE = 0

                        End Select

                    End If

                End If


            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub PictureBox1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Move
        Encontrar_Suelo_Principal.Start()
    End Sub
    Private Sub ActVida(ByVal v As Double)
        Panel7.Width = v
        Label2.Text = v.ToString
    End Sub
End Class
