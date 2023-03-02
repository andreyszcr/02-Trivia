Imports Trivia

Public Class frmJuego

    'variables de tipo clase 
    'generadas desde la biblioteca de clases 
    Dim juego As New Archivos

    Private Sub VolverAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenuPrincipalToolStripMenuItem.Click
        'validacion de datos 
        Try
            'esconde el menu de juego 
            Me.Hide()

            'vuelve al menu principal
            frmMenuPrincipal.Show()
        Catch ex As Exception
            'error para entrar a la pantalla 
            MessageBox.Show("Error al volver al menu", "Error de pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '******************************************************************************************************************
    Private Sub PausarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PausarToolStripMenuItem.Click


        cronometro.Stop()

    End Sub
    '******************************************************************************************************************
    Private Sub TsmnsJugador1_Click(sender As Object, e As EventArgs) Handles tsmnsJugador1.Click
        'validacion de datos 
        Try
            'en caso de que el jugador sea uno 
            juego.unjugador = 1
            lblunjug.Text = juego.unjugador.ToString

            'la panalla se habilita los datos encontrados en esa pantalla 
            frmPregunta.lblPunt2.Visible = True
            'aparezca el jugador 
            gbJugadores.Visible = True


            'aparece la casilla  
            lbljugador.Visible = True
            txtnombre1.Visible = True
            ' juego.nomJ1 = txtnombre1.Text
            cmbj1.Visible = True


            'no se muestra los datos 
            lbljugador2.Visible = False
            txtnombre2.Visible = False
            txtnombre2.Enabled = False
            'g = txtnombre2.Text

            'no se muestra el combo box para escoger los datos del jugador
            cmbj2.Visible = False
            cmbj2.Enabled = False
            lbldosjug.Text = "0"
        Catch ex As Exception
            'en caso de error
            MessageBox.Show("Error de datos en las seleccion del jugador", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'casillas escondidas en el momento de agregar 

        gbJugadores.Visible = False
        txtnombre1.Visible = False
        txtnombre2.Visible = False
        cmbj1.Visible = False
        cmbj2.Visible = False
        lbljugador.Visible = False
        lbljugador2.Visible = False
    End Sub

    Private Sub TmnsJugador2_Click(sender As Object, e As EventArgs) Handles tmnsJugador2.Click
        'validacion de datos 
        Try
            'en caso de que sean 2 jugadores 
            juego.unjugador = 1
            lblunjug.Text = juego.unjugador.ToString
            juego.dosjugadores = 1
            lbldosjug.Text = juego.dosjugadores.ToString
            frmPregunta.lblPunt2.Visible = True
            'aparezca el jugador 
            gbJugadores.Visible = True


            'aparece la casilla  
            lbljugador.Visible = True
            txtnombre1.Visible = True
            'game.nombre1 = txtnombre1.Text
            cmbj1.Visible = True


            lbljugador2.Visible = True
            txtnombre2.Visible = True
            txtnombre2.Enabled = True
            'game.nombre2 = txtnombre2.Text

            'se habilita oara que el jugador 2 pueda escoger la categoria 
            cmbj2.Visible = True
            cmbj2.Enabled = True
        Catch ex As Exception
            'en caso de error
            MessageBox.Show("Error de datos en las seleccion del jugador", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmJuego_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'validacion de datos 
        Try
            End
        Catch ex As Exception
            'en caso de error muestra un mensaje al salir la patanlla
            MsgBox(ex.Message, "Error de datos")
        End Try
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'validacion de datos 
        Try
            juego.nomJ1 = txtnombre1.Text
            juego.validarnomJ1()
            juego.VectLlen()
            juego.VectLlen2()
            juego.NumerosDiferentes()
            juego.NumerosDiferentes2()
            'Label1.Text = juego.VectorLleno(0).ToString + " " + juego.VectorLleno(1).ToString + " " + juego.VectorLleno(2).ToString


            If cmbj1.SelectedIndex = -1 Then
                juego.ValidarEnBlancoCat()
            End If
            If lbldosjug.Text = "1" Then
                juego.nomJ2 = txtnombre2.Text
                juego.validarnomJ2()
            End If
            If lbldosjug.Text = "1" And cmbj2.SelectedIndex = -1 Then
                juego.validarcat2enblanc()
            End If


            If cmbj1.SelectedIndex = 0 And cmbj2.SelectedIndex = 0 Then
                juego.ValidarCategDuplic()
            ElseIf cmbj1.SelectedIndex = 1 And cmbj2.SelectedIndex = 1 Then
                juego.ValidarCategDuplic()
            ElseIf cmbj1.SelectedIndex = 2 And cmbj2.SelectedIndex = 2 Then
                juego.ValidarCategDuplic()
            End If


            'variable de tipo de windows form 
            Dim Pantallapreguntas As New frmPregunta
            'se muestra la pantalla 
            Pantallapreguntas.Show()

            'comienzo del cronometro
            cronometro.Start()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cronometro_Tick(sender As Object, e As EventArgs) Handles cronometro.Tick

        'aumento de milisegundo 
        lblmilisegundo.Text += 1
        'si milisegundo llega a 60 entonces 
        If lblmilisegundo.Text = "60" Then
            'aumenta el segundo 
            lblsegundo.Text += 1

            'al llegar el milisegundo a 60 se coloca en 00
            lblmilisegundo.Text = "00"
        End If

        'si segundo llega hasta 60 entnces 
        If lblsegundo.Text = "60" Then
            'minuto aumenta 
            lblminuto.Text += 1

            'el segundo se detiene en 00
            lblsegundo.Text = "00"
        End If


        If lblminuto.Text = "60" Then
            'aumenta la hora 
            lblhora.Text += 1

            'se coloca en 0 los minutos 
            lblminuto.Text = "00"
        End If
    End Sub

    Private Sub ReinicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReinicarToolStripMenuItem.Click
        'comodines a reiniciar  
        juego.unavezcinc = 0
        juego.unavezcinc2 = 0
        juego.unavezllamda = 0
        juego.unavezllamda2 = 0
        juego.unavezrespPubl = 0
        juego.unavezrespPubl2 = 0

        'se reinicia los comodines 
        frmPregunta.unavezcada1cinc1()
        frmPregunta.unavezcada1cinc2()
        frmPregunta.unavezcada1llamada()
        frmPregunta.unavezcada1llamada2()

        'se reinicia los numeros diferentes 
        juego.NumerosDiferentes()
        juego.NumerosDiferentes2()
        juego.numSig = 1

        'condicion para reiniciar el juego 
        If MsgBox("¿Desea reiniciar el juego?", vbAbort + vbQuestion, "Reinicio del juego") = vbYes Then
            cronometro.Stop()
            'el tiempo se reinicia 
            lblmilisegundo.Text = "00"
            lblsegundo.Text = "00"
            lblminuto.Text = "00"
            lblhora.Text = "00"
        End If
    End Sub

    Private Sub Cmbj1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbj1.SelectedIndexChanged

        'la seleccion de la categoria 
        juego.selectCategoria = Me.cmbj1.SelectedItem.ToString

        'categoria a seleccionar 
        Select Case juego.selectCategoria

            'categoria de cultura 
            Case "Cultura"
                dgvLector.Rows.Clear()
                juego.valindx = 1
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

            'categoria de deportes
            Case "Deportes"
                dgvLector.Rows.Clear()
                juego.valindx = 2
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

                'categoria de salud 
            Case "Salud"
                dgvLector.Rows.Clear()
                juego.valindx = 3
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

                   'categoria de politica
            Case "Politica"
                dgvLector.Rows.Clear()
                juego.valindx = 4
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()


                'categoria de finanzas
            Case "Finanzas"
                dgvLector.Rows.Clear()
                juego.valindx = 5
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()


                  'categoria de Historia
            Case "Historia"
                dgvLector.Rows.Clear()
                juego.valindx = 6
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

                       'categoria de Ciencia
            Case "Ciencia "
                dgvLector.Rows.Clear()
                juego.valindx = 7
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()



                       'categoria de Tecnologia
            Case "Tecnologia"
                dgvLector.Rows.Clear()
                juego.valindx = 8
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()



                       'categoria de Astronomia
            Case "Astronomia"
                dgvLector.Rows.Clear()
                juego.valindx = 9
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

            Case "Musica"
                dgvLector.Rows.Clear()
                juego.valindx = 10
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

            Case "General"
                dgvLector.Rows.Clear()
                juego.valindx = 11
                juego.ejectArch()
                juego.ExisteArchivo()
                agreguno()

        End Select
    End Sub

    Private Sub Cmbj2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbj2.SelectedIndexChanged
        'la seleccion de la categoria 
        juego.selectCategoria2 = cmbj2.SelectedItem.ToString

        'categoria a seleccionar
        Select Case juego.selectCategoria2

            'categoria de cultura 
            Case "Cultura"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 1
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

                'categoria de deportes  
            Case "Deportes"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 2
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

                'categoria de salud 
            Case "Salud"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 3
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()


                   'categoria de politica
            Case "Politica"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 4
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

                    'categoria de finanzas  
            Case "Finanzas"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 5
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()


                       'categoria de Historia
            Case "Historia"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 6
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

            'categoria de Ciencia
            Case "Ciencia"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 7
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()


            'categoria de Tecnologia
            Case "Tecnologia"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 8
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()


            'categoria de Astronomia 
            Case "Astronomia"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 9
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

            Case "Musica"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 10
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

                'categoria de General 
            Case "General"
                frmpregJ2.dgvLector2.Rows.Clear()
                juego.valindx = 11
                juego.ejectArch2()
                juego.ExisteArchivo2()
                agregdos()

        End Select
    End Sub
    '*******************************************************************************************************
    'metodo para agregar datos de ka categoria escogida 
    Sub agregdos()
        'si el archivo de l jugador 2 existe entonces 
        If juego.archivoexiste2 = True Then

            'lectura del objeto del jugador 2
            'se encuntra en la clase 
            juego.objectlect2()

            'mientras el la lectura del onjeto del jugador 2 sea diferente a -1 entonces 
            Do While juego.objReader2.Peek() <> -1

                'lectura de datos por comas 
                juego.leerporcomas2()

                'se agregan datos al datagrid view 
                frmpregJ2.dgvLector2.Rows.Add(juego.splitlinea2)
            Loop
        Else
            'si no, el archivo no existe 
            juego.directorionoexist2()
        End If
    End Sub
    '**************************************************************************************************************
    'metodo para agregar datos segun la categoria  del jugador 1
    Sub agreguno()


        'si el archivo existe entonces 
        If juego.archivoexiste = True Then

            'lectura de la lectura que se encuentra en la clase 
            juego.objectlect()


            Do While juego.objReader.Peek() <> -1


                'lectura delarchivo por comas 
                juego.leerporcomas()


                'se agregan datos al data grid view 
                dgvLector.Rows.Add(juego.splitlinea)
            Loop

        Else
            'si no el archivo no existe 
            juego.directorionoexist()
        End If
    End Sub

    Private Sub dgvLector_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLector.CellContentClick

    End Sub
    '**************************************************************************************************************************************************

End Class