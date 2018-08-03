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
        If e.KeyCode = Keys.A Then


            a = 1
            Movimiento.Enabled = True
            lado = 0
        End If
        If e.KeyCode = Keys.D Then
            

            d = 1
            lado = 1
            Movimiento.Enabled = True

        End If
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Space Then

            If Descenso.Enabled = False Then

                SaltoAnima.Enabled = True
                Ascenso.Enabled = True

            End If

        End If

    End Sub


    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then

            Movimiento.Enabled = False
            CorrerAtras.Enabled = False

            lado = 0
            Idle.Enabled = True

            avanzar2 = avanzar
            a = 0
        End If
        If e.KeyCode = Keys.D Then

            Movimiento.Enabled = False
            CorrerDelante.Enabled = False

            lado = 1
            Idle.Enabled = True

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

                Idle.Enabled = False
                CorrerDelante.Enabled = True




            End If

            If a = 1 Then

                PictureBox1.Location = New Point(PictureBox1.Location.X - avanzar2, PictureBox1.Location.Y)

                If Descenso.Enabled = False And avanzar2 <= limvel2 Then
                    avanzar2 += acelereacion2
                End If

                Idle.Enabled = False
                CorrerAtras.Enabled = True

                If PictureBox1.Location.X <= -10 Then
                    PictureBox1.Location = New Point(2000, PictureBox1.Location.Y)
                End If
            End If

            If a = 1 And d = 1 Then
                CorrerDelante.Enabled = False
                CorrerAtras.Enabled = False
                Movimiento.Enabled = False
                Idle.Enabled = True
            End If

        End If
        If Descenso.Enabled = False Then
            If PictureBox1.Location.X < Panel4.Location.X - 20 Or PictureBox1.Location.X > Panel4.Location.X + Panel4.Width Then

                Descenso.Enabled = True

            End If
        End If

        
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descenso.Tick
        SaltoAnima.Enabled = False

        Dim y As Double = PictureBox1.Location.Y
        Dim x As Double = PictureBox1.Location.X
        Dim py As Double = Panel4.Location.Y
        Dim px As Double = Panel4.Location.X

        Label1.Text = "PanelY: " + py.ToString + vbNewLine + "Panelx: " + px.ToString + " hasta: " + (px + 325).ToString + vbNewLine + "Y: " + y.ToString + vbNewLine + "X: " + x.ToString

        If y >= py - 30 And y <= py And x > px And x < px + 430 Then


            PictureBox1.Location = New Point(x, py)
            Label1.Text += vbNewLine + "Detected"



            caida2 = caida
            acelcaida2 = acelcaida



            BajoAnima.Enabled = False
            Idle.Enabled = True
            Descenso.Enabled = False

        End If

        If (y + caida2) <= 302 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, y + caida2)

            caida2 += acelcaida2

        ElseIf y <= 302 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, 302)

            caida2 = caida
            acelcaida2 = acelcaida

            BajoAnima.Enabled = False


            Idle.Enabled = True

            Descenso.Enabled = False


        Else

            caida2 = caida
            acelcaida2 = acelcaida

            BajoAnima.Enabled = False


            Idle.Enabled = True

            Descenso.Enabled = False

        End If





    End Sub


    Private Sub animacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerDelante.Tick
        Select Case foto

            Case 7
                PictureBox1.Image = My.Resources._13
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 8
                PictureBox1.Image = My.Resources._14
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 9
                PictureBox1.Image = My.Resources._15
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 10
                PictureBox1.Image = My.Resources._16
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto += 1
            Case 11
                PictureBox1.Image = My.Resources._17
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                foto = 7


        End Select
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Idle.Enabled = True
        inicio.Show()

    End Sub

    Private Sub ascenso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ascenso.Tick



        If cont <= salto2 Then

            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - velsubida2)

            cont += 1
            velsubida2 -= desasubida2


        Else
            velsubida2 = velsubida
            Ascenso.Enabled = False
            Descenso.Enabled = True
            BajoAnima.Enabled = True
            cont = 0

        End If


       



    End Sub


    Private Sub correr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrerAtras.Tick


        Select Case foto

             Case 7
                PictureBox1.Image = My.Resources._13
                foto += 1
            Case 8
                PictureBox1.Image = My.Resources._14
                foto += 1
            Case 9
                PictureBox1.Image = My.Resources._15
                foto += 1
            Case 10
                PictureBox1.Image = My.Resources._16
                foto += 1
            Case 11
                PictureBox1.Image = My.Resources._17
                foto = 7

        End Select

    End Sub

    Private Sub Idle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idle.Tick
        CorrerAtras.Enabled = False
        CorrerAtras.Enabled = False

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

    Private Sub SaltoAnima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaltoAnima.Tick
       

        Idle.Enabled = False

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

        SaltoAnima.Enabled = False

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

    Private Sub Esfera_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Esfera.Tick

    End Sub
End Class
