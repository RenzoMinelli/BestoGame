Public Class Form1

    '////////////////////////////////////PERSONALIZACION///////////////////////
    Public avanzar As Double = 1
    Public acelereacion As Double = 0.1
    Public limvel As Double = 5
    Public salto As Double = 20
    Public velsubida As Double = 5
    Public desasubida As Double = 0.01
    Public caida As Double = 5
    Public acelcaida As Double = 0.01
    '//////////////////////////////////////////////////////////////////////////

    Dim avanzar2 As Double = avanzar
    Dim acelereacion2 As Double = acelereacion
    Dim limvel2 As Double = limvel
    Dim salto2 As Double = salto
    Dim velsubida2 As Double = velsubida
    Dim desasubida2 As Double = desasubida
    Dim caida2 As Double = caida
    Dim acelcaida2 As Double = acelcaida


    Dim foto As Integer = 7
    Dim d As Integer
    Dim a As Integer
    Dim cont As Integer = 0

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            a = 1
            Movimiento.Enabled = True

        End If
        If e.KeyCode = Keys.D Then

            d = 1
            Movimiento.Enabled = True

        End If
        If e.KeyCode = Keys.W Then

            If Descenso.Enabled = False Then

                Ascenso.Enabled = True

            End If

        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then
            PictureBox1.Image = My.Resources._19
            Movimiento.Enabled = False
            CorrerAtras.Enabled = False
            avanzar2 = avanzar
            a = 0
        End If
        If e.KeyCode = Keys.D Then
            PictureBox1.Image = My.Resources._19
            Movimiento.Enabled = False
            CorrerDelante.Enabled = False
            avanzar2 = avanzar
            d = 0
        End If
        If e.KeyCode = Keys.W Then


        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Movimiento.Tick

        If PictureBox1.Location.X >= 722 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y)
            Movimiento.Enabled = False

        ElseIf PictureBox1.Location.X <= 53 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y)
            Movimiento.Enabled = False
        Else
            If d = 1 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X + avanzar2, PictureBox1.Location.Y)

                If Descenso.Enabled = False And avanzar2 <= limvel2 Then
                    avanzar2 += acelereacion2
                End If


                CorrerDelante.Enabled = True




            End If

            If a = 1 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X - avanzar2, PictureBox1.Location.Y)

                If Descenso.Enabled = False And avanzar2 <= limvel2 Then
                    avanzar2 += acelereacion2
                End If


                CorrerAtras.Enabled = True

                If PictureBox1.Location.X <= -10 Then
                    PictureBox1.Location = New Point(2000, PictureBox1.Location.Y)
                End If
            End If

            If a = 1 And d = 1 Then
                CorrerDelante.Enabled = False
                CorrerAtras.Enabled = False
                Movimiento.Enabled = False
                PictureBox1.Image = My.Resources._1
            End If

        End If


        
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descenso.Tick

        Dim altura As Double = PictureBox1.Location.Y

        If (altura + caida2) <= 204 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, altura + caida2)

            caida2 += acelcaida2

        ElseIf altura <= 204 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, 200)

            caida2 = caida
            acelcaida2 = acelcaida
            Descenso.Enabled = False

        Else

            caida2 = caida
            acelcaida2 = acelcaida
            Descenso.Enabled = False

        End If





    End Sub


    Private Sub animacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerDelante.Tick
        Select Case foto

            Case 7
                PictureBox1.Image = My.Resources._8
                foto += 1
            Case 8
                PictureBox1.Image = My.Resources._9
                foto += 1
            Case 9
                PictureBox1.Image = My.Resources._10
                foto += 1
            Case 10
                PictureBox1.Image = My.Resources._11
                foto += 1
            Case 11
                PictureBox1.Image = My.Resources._12
                foto += 1
            Case 12
                PictureBox1.Image = My.Resources._13
                foto += 1
            Case 13
                PictureBox1.Image = My.Resources._14
                foto += 1
            Case 14
                PictureBox1.Image = My.Resources._15
                foto += 1
            Case 15
                PictureBox1.Image = My.Resources._16
                foto += 1
            Case 16
                PictureBox1.Image = My.Resources._17
                foto += 1
            Case 17
                PictureBox1.Image = My.Resources._18
                foto = 7



        End Select
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        inicio.Show()

    End Sub

    Private Sub ascenso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ascenso.Tick



        If cont <= salto2 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - velsubida2)
            'Label1.Text = velsubida2.ToString
            cont += 1
            velsubida2 -= desasubida2

        Else
            velsubida2 = velsubida
            Ascenso.Enabled = False
            Descenso.Enabled = True
            cont = 0
        End If






    End Sub


    Private Sub correr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerAtras.Tick
        Dim imagen As Image

        Select Case foto

            Case 7
                PictureBox1.Image = My.Resources._8
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 8
                PictureBox1.Image = My.Resources._9
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 9
                PictureBox1.Image = My.Resources._10
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 10
                PictureBox1.Image = My.Resources._11
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 11
                PictureBox1.Image = My.Resources._12
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 12
                PictureBox1.Image = My.Resources._13
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 13
                PictureBox1.Image = My.Resources._14
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 14
                PictureBox1.Image = My.Resources._15
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 15
                PictureBox1.Image = My.Resources._16
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 16
                PictureBox1.Image = My.Resources._17
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 17
                PictureBox1.Image = My.Resources._18
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto = 7



        End Select
    End Sub
End Class
