Public Class Form1

    '////////////////////////////////////PERSONALIZACION///////////////////////
    Public avanzar As Double = 5
    Public acelereacion As Double = 0
    Public limvel As Double = 5
    Public salto As Double = 20
    Public pixSubida As Double = 8
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
    Dim stand As Integer = 0
    Dim foto As Integer = 0
    Dim cont As Integer = 0

    Dim d As Integer = 0
    Dim a As Integer = 0

    '0 equivale a caer y 1 a subir
    Dim moviVertical As Integer = 0

    Dim animMovimiento As Integer = vbNull




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
            If moviVertical = vbNull Then

                'Inicio el ascenso y la animación del mismo
                'moviVertical = 1

            End If

        End If

        'Al presionar la tecla S
        If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then

            'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
            If moviVertical = vbNull And PictureBox1.Location.Y < pan.Location.Y Then

                'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + pan.Height)
                moviVertical = 0

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


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Lateral.Tick
        If d = 1 Or a = 1 Then
            'Si el PictureBox llega al borde de la sala, que lo mueva hacia atrás
            If PictureBox1.Location.X >= 722 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X - 5, PictureBox1.Location.Y)

            ElseIf PictureBox1.Location.X <= 53 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y)

            End If

            'Si solo la tecla D está presionada
            If d = 1 And a = 0 Then

                'Se activa la animación de correr si aún no lo está
                If Not animMovimiento = 1 Then

                    animMovimiento = 1

                End If

                'El PictureBox avanza lo que esta en la variable avanzar2
                PictureBox1.Location = New Point(PictureBox1.Location.X + avanzar2, PictureBox1.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = vbNull And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion2

                End If


                'Si solo la tecla A está presionada
            ElseIf a = 1 And d = 0 Then

                'Se activa la animación de correr si aún no lo está
                If Not animMovimiento = 0 Then

                    animMovimiento = 0

                End If


                'El PictureBox avanza lo que esta en la variable avanzar2
                PictureBox1.Location = New Point(PictureBox1.Location.X - avanzar2, PictureBox1.Location.Y)

                'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
                If moviVertical = vbNull And avanzar2 <= limvel2 Then

                    avanzar2 += acelereacion2

                End If



                'Si ambas teclas A y D estás presionadas
            ElseIf a = 1 And d = 1 Then

                'Que no se genere ningun movimiento 
                animMovimiento = vbNull

                a = 0
                d = 0

            End If

            'Si el PictureBox no está ascendiendo ni bajando
            If moviVertical = vbNull Then

                'Si el PictureBox esta a la izquierda o la derecha del Panel (Plataforma)
                If PictureBox1.Location.X < (pan.Location.X - PictureBox1.Width + 5) Or PictureBox1.Location.X > pan.Location.X + pan.Width - 10 Then

                    'Si el PictureBox esta por ensima del Panel4 (Plataforma)
                    If PictureBox1.Location.Y < pan.Location.Y Then

                        'Que inicie el descenso y la animación del mismo
                        moviVertical = 0


                    End If

                End If

            End If
        End If
      

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento_Vertical.Tick

        If moviVertical = 0 Then

            'Si el PictureBox se encuentra sobre el Panel4 a una distancia menor a 55 pixeles?
            If PictureBox1.Location.Y >= (pan.Location.Y - pan.Height) - 20 And PictureBox1.Location.Y <= (pan.Location.Y - pan.Height) And PictureBox1.Location.X > pan.Location.X - PictureBox1.Width + 5 And PictureBox1.Location.X < (pan.Location.X + pan.Width - 5) Then


                'Mi objetivo era reubicarlo en un punto por defecto del eje y pero no lo hace :v
                PictureBox1.Location = New Point(PictureBox1.Location.X, pan.Location.Y - pan.Height - 22)

                'Desactivo la animacion de bajada y el descenso. Además enciendo la animacion idle
                moviVertical = vbNull


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
                moviVertical = vbNull


            End If


        ElseIf moviVertical = 1 Then


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
                moviVertical = 0

            End If
        End If




    End Sub



    


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicio la animación Idle y muestro el menu de configuraciones
        inicio.Show()

    End Sub


    


    Private Sub correr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Correr_Lateral_Principal.Tick
        If a = 1 And d = 0 And moviVertical = vbNull And animMovimiento = 0 Then

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
        ElseIf d = 1 And a = 0 And moviVertical = vbNull And animMovimiento = 1 Then

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




    End Sub

    

    Private Sub Idle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Idle_Principal.Tick
        If a = 0 And d = 0 And moviVertical = vbNull Then
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



    Private Sub SaltoAnima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anim_Vertical_Principal.Tick

        If moviVertical = 1 Then

            'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
            If lado = 0 Then

                PictureBox1.Image = My.Resources.a

            ElseIf lado = 1 Then

                PictureBox1.Image = My.Resources.a
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

            End If


        ElseIf moviVertical = 0 Then

            'En la variable lado se indica a que lado debe ver el PictureBox, 0 = izquierda,  1 = derecha
            If lado = 0 Then

                PictureBox1.Image = My.Resources.c

            ElseIf lado = 1 Then

                PictureBox1.Image = My.Resources.c
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

            End If
        End If


    End Sub

  
   
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encontrar_Suelo.Tick
        Dim panelfinal As Control = PictureBox1
        Dim dy As Integer = 1000

        For Each ctrl As Control In Me.Controls


            If (ctrl.Location.Y - PictureBox1.Location.Y) < dy And ctrl.Location.Y >= PictureBox1.Location.Y And ctrl.Name <> PictureBox1.Name And ctrl.Name <> Panel1.Name Then


                If PictureBox1.Location.X >= ctrl.Location.X - PictureBox1.Width + 5 And PictureBox1.Location.X < (ctrl.Location.X + ctrl.Width - 5) Then


                    panelfinal = ctrl
                    dy = ctrl.Location.Y - PictureBox1.Location.Y


                End If


            End If



        Next

        Try
            pan = panelfinal
        Catch ex As Exception

        End Try



    End Sub

    
   
End Class
