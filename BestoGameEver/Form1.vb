Public Class Form1

    '////////////////////////////////////PERSONALIZACION///////////////////////
    Public avanzar As Double = 5
    Public acelereacion As Double = 0
    Public limvel As Double = 5
    Public salto As Double = 20
    Public velsubida As Double = 8
    Public desasubida As Double = 0.01
    Public caida As Double = 5
    Public acelcaida As Double = 0.01
    '//////////////////////////////////////////////////////////////////////////

    'Utilizo una copia de las variables para luego devolverlas al valor inicial
    Dim avanzar2 As Double = avanzar
    Dim acelereacion2 As Double = acelereacion
    Dim limvel2 As Double = limvel
    Dim salto2 As Double = salto
    Dim velsubida2 As Double = velsubida
    Dim desasubida2 As Double = desasubida
    Dim caida2 As Double = caida
    Dim acelcaida2 As Double = acelcaida

    Dim bajo As Integer = 0
    Dim sal As Integer = 0
    Dim lado As Integer = 0
    Dim stand As Integer = 0
    Dim foto As Integer = 7
    Dim d As Integer
    Dim a As Integer
    Dim cont As Integer = 0


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Al presionar la tecla A
        If e.KeyCode = Keys.A Then

            'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla la primera vez
            If a = 0 Then
                PictureBox1.Image = My.Resources._17
            End If

            'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
            a = 1
            Movimiento.Start()

            'Indico de que lado debe estar la animacion de correr (izquierda)
            lado = 0

            'Apago el timer de animacion Idle
            Idle.Dispose()

        End If

        'Al presionar la tecla D
        If e.KeyCode = Keys.D Then

            'Le cambio la imagen a la primera en movimineto para que al menos se muestre un cambio al precionar la tecla
            If d = 0 Then
                PictureBox1.Image = My.Resources._17
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If

            'Levanto la bandera de movimiento a la izquierda e inicio el timer movimiento
            d = 1
            Movimiento.Start()

            'Indico de que lado debe estar la animacion de correr (derecha)
            lado = 1

            'Apago el timer de animacion Idle
            Idle.Dispose()

        End If

        'Al presionar la tecla W o la barra
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Space Then

            'Verifico que no este descendiedo para que asi no salta en el aire
            If Descenso.Enabled = False Then

                'Inicio el ascenso y la animación del mismo
                Ascenso.Start()
                SaltoAnima.Start()

            End If

        End If

        'Al presionar la tecla S
        If e.KeyCode = Keys.S Then

            'Verifico que no estoy ascendiendo ni descendiendo además de que debe estar por ensima del panel4 (plataforma)
            If Ascenso.Enabled = False And Descenso.Enabled = False And PictureBox1.Location.Y < Panel4.Location.Y Then

                'Muevo el PictureBox un poco mas abajo para que de esta forma no este dentro del margen de control para frenar e inicio el descenso con animación
                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 30)
                Descenso.Start()
                BajoAnima.Start()

            End If
        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'Al soltar la tecla A
        If e.KeyCode = Keys.A Then

            'Si la tecla D sigue presionada,  entonces se debe mover a la derecha
            If d = 1 Then

                'Se apaga la animacion de idle, se indica el lado y se enciende la animacion de correr a la derecha
                Idle.Dispose()
                lado = 1
                CorrerDelante.Start()
                Movimiento.Start()

                'Sino, que se detenga y que se encienda la animacion idle
            Else
                Movimiento.Dispose()
                CorrerAtras.Dispose()
                Idle.Start()

            End If

            'Se restaura la aceleracion a la inicial
            avanzar2 = avanzar

            'Se indica que la tecla A ya no está presionada
            a = 0

        End If

        'Al soltar la tecla D
        If e.KeyCode = Keys.D Then

            'Si la tecla A sigue presionada,  entonces se debe mover a la izquierda
            If a = 1 Then

                'Se apaga la animacion de idle, se indica el lado y se enciende la animacion de correr a la izquierda
                Idle.Dispose()
                lado = 0
                CorrerAtras.Start()
                Movimiento.Start()

                'Sino, que se detenga y que se encienda la animacion idle
            Else
                Movimiento.Dispose()
                CorrerDelante.Dispose()
                Idle.Start()

            End If

            'Se restaura la aceleracion a la inicial
            avanzar2 = avanzar

            'Se indica que la tecla D ya no está presionada
            d = 0

        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento.Tick

        'Si el PictureBox llega al borde de la sala, que lo mueva hacia atrás
        If PictureBox1.Location.X >= 722 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X - 5, PictureBox1.Location.Y)

        ElseIf PictureBox1.Location.X <= 53 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y)

        End If

        'Si solo la tecla D está presionada
        If d = 1 And a = 0 Then

            'Se desactiva la animación idle se activa la de correr si aún no lo está
            Idle.Dispose()

            If CorrerDelante.Enabled = False Then
                CorrerDelante.Start()
            End If




            'El PictureBox avanza lo que esta en la variable avanzar2
            PictureBox1.Location = New Point(PictureBox1.Location.X + avanzar2, PictureBox1.Location.Y)

            'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
            If Descenso.Enabled = False And avanzar2 <= limvel2 Then

                avanzar2 += acelereacion2

            End If


            'Si solo la tecla A está presionada
        ElseIf a = 1 And d = 0 Then

            'Se desactiva la animacion idle y se activa la de correr si aún no lo está
            Idle.Stop()

            If CorrerAtras.Enabled = False Then
                CorrerAtras.Start()
            End If


            'El PictureBox avanza lo que esta en la variable avanzar2
            PictureBox1.Location = New Point(PictureBox1.Location.X - avanzar2, PictureBox1.Location.Y)

            'Solo en el caso que el PictureBox no esté descendiendo, se acelerará el movimiento. Sino, solo será la inicial
            If Descenso.Enabled = False And avanzar2 <= limvel2 Then

                avanzar2 += acelereacion2

            End If



            'Si ambas teclas A y D estás presionadas
        ElseIf a = 1 And d = 1 Then

            'Que no se genere ningun movimiento y la animación idle se active
            CorrerDelante.Dispose()
            CorrerAtras.Dispose()
            Movimiento.Dispose()
            Idle.Start()

        End If

        'Si el PictureBox no está ascendiendo ni bajando
        If Descenso.Enabled = False And Ascenso.Enabled = False Then

            'Si el PictureBox esta a la izquierda o la derecha del Panel4 (Plataforma)
            If PictureBox1.Location.X < Panel4.Location.X - 35 Or PictureBox1.Location.X > Panel4.Location.X + Panel4.Width Then

                'Si el PictureBox esta por ensima del Panel4 (Plataforma)
                If PictureBox1.Location.Y < Panel4.Location.Y Then

                    'Que inicie el descenso y la animación del mismo
                    Descenso.Start()
                    BajoAnima.Start()

                End If
               
            End If

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descenso.Tick


        'Guardo las posiciones del picturebox y del panel(plataforma)
        Dim y As Double = PictureBox1.Location.Y
        Dim x As Double = PictureBox1.Location.X
        Dim py As Double = Panel4.Location.Y
        Dim px As Double = Panel4.Location.X



        If y >= (py - 55) And y <= (py - Panel4.Height) And x > px - 35 And x < (px + Panel4.Width) Then


            'Por que no mueve en el eje y ??????? help me pls, cambien el 38 si quieren, no hace nada
            PictureBox1.Location = New Point(x, py - 50)


            BajoAnima.Dispose()
            Idle.Start()


            caida2 = caida
            acelcaida2 = acelcaida

            Descenso.Dispose()


        End If

        If (y + caida2) <= 299 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, y + caida2)

            caida2 += acelcaida2

        ElseIf y <= 299 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, 299)

            caida2 = caida
            acelcaida2 = acelcaida

            BajoAnima.Dispose()


            Idle.Start()

            Descenso.Dispose()


        Else

            caida2 = caida
            acelcaida2 = acelcaida

            BajoAnima.Dispose()


            Idle.Start()

            Descenso.Dispose()

        End If





    End Sub

    Private Sub CorrerDelante_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CorrerDelante.Disposed
        foto = 0
    End Sub


    Private Sub animacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerDelante.Tick
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
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicio la animación Idle y muestro el menu de configuraciones
        Idle.Start()
        inicio.Show()

    End Sub

    Private Sub ascenso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ascenso.Tick



        If cont <= salto2 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - velsubida2)

            cont += 1
            velsubida2 -= desasubida2


        Else
            velsubida2 = velsubida
            Ascenso.Dispose()
            Descenso.Start()
            BajoAnima.Start()
            cont = 0

        End If


       



    End Sub

    Private Sub CorrerAtras_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CorrerAtras.Disposed
        foto = 0
    End Sub


    Private Sub correr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerAtras.Tick


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

    End Sub

    Private Sub Idle_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Idle.Disposed
        stand = 0
    End Sub

    Private Sub Idle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idle.Tick
        CorrerDelante.Dispose()
        CorrerAtras.Dispose()

        If lado = 0 Then
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
       
    End Sub

    Private Sub SaltoAnima_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaltoAnima.Disposed
        sal = 0
    End Sub

    Private Sub SaltoAnima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaltoAnima.Tick
       

        Idle.Dispose()

        If lado = 0 Then

            If sal >= 0 And sal < 5 Then
                PictureBox1.Image = My.Resources._01
                sal += 1
            ElseIf sal >= 5 And sal < 10 Then
                PictureBox1.Image = My.Resources._20
                sal += 1
            Else
                PictureBox1.Image = My.Resources.a
            End If

        ElseIf lado = 1 Then

            If sal >= 0 And sal < 5 Then
                PictureBox1.Image = My.Resources._01
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                sal += 1
            ElseIf sal >= 5 And sal < 10 Then
                PictureBox1.Image = My.Resources._20
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                sal += 1
            Else
                PictureBox1.Image = My.Resources.a
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            End If

        End If

       


    End Sub

    Private Sub BajoAnima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajoAnima.Tick

        SaltoAnima.Dispose()

        If lado = 0 Then

            If bajo >= 0 And bajo < 5 Then
                PictureBox1.Image = My.Resources._18
                bajo += 1
            ElseIf bajo >= 5 And bajo < 10 Then
                PictureBox1.Image = My.Resources.b
                bajo += 1
            Else
                PictureBox1.Image = My.Resources.c

            End If

        ElseIf lado = 1 Then

            If bajo >= 0 And bajo < 5 Then
                PictureBox1.Image = My.Resources._18
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                bajo += 1
            ElseIf bajo >= 5 And bajo < 10 Then
                PictureBox1.Image = My.Resources.b
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                bajo += 1
            Else
                PictureBox1.Image = My.Resources.c
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

            End If

        End If
        


    End Sub
End Class
