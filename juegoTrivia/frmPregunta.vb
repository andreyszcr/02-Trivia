Imports Trivia


Public Class frmPregunta
    Dim obj As New Archivos
    Private Sub Btnresp1_Click(sender As Object, e As EventArgs) Handles btnresp1.Click
        'metodos de la categoria 
        respuestasCultura()
        respuestasDeportes()
        respuestasSalud()
        respuestasPolitica()
        respuestasFinanzas()
        respuestasHistoria()
        respuestasCiencia()
        respuestasTecnologia()
        respuestasAstronomia()
        respuestasMusica()

        'respuesta dada igual a btnrespuesta 1
        obj.RespuestaDada = btnresp1.Text
        TimerPregunt.Stop()
        'si turno contiene jugador 1 entonces 
        If lblturno.Text.Contains("J1:") Then

            'validacion de respuesta 
            obj.validresp()

            'sino el turno contiene jugador 2 entonces 
        ElseIf lblturno.Text.Contains("J2:") Then
            'validacion de respuesta 2
            obj.validresp2()
        End If

        'puntuacion de los jugadores  
        lblPunt.Text = "Puntuación J1: " + obj.puntos.ToString
        lblPunt2.Text = "Puntuación J2: " + obj.puntuacion2.ToString

        'metodo para avance pregunta 
        obj.avancedepreg()

        disab50()
        'metodos 
        unavezcada1cinc1()
        unavezcada1cinc2()
        unavezcada1llamada()
        unavezcada1llamada2()
        unavezcada1RespPubl()
        unavezcada1RespPubl2()

        'si jugador =1  entonces 
        If frmJuego.lblunjug.Text = "1" Then
            'siguiente pregunta 
            Sigpreg()

            'si jugador 1 y jugador 2 es igual 1 entonces 
        End If
        If frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            'siguiente pregunta 

            Sigpreg2Jug()

        End If
        lblOculSiguien.Text = obj.numSig.ToString

        If frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            AvancePuntuacion()

        End If
        TimerPregunt.Start()
        lblSeg.Text = "25"
    End Sub

    Private Sub Btnresp2_Click(sender As Object, e As EventArgs) Handles btnresp2.Click
        'categoria 
        respuestasCultura()
        respuestasDeportes()
        respuestasSalud()
        respuestasPolitica()
        respuestasFinanzas()
        respuestasHistoria()
        respuestasCiencia()
        respuestasTecnologia()
        respuestasAstronomia()
        respuestasMusica()

        'respuesta dada igual a btnrespuesta 2
        obj.RespuestaDada = btnresp2.Text
        TimerPregunt.Stop()
        'turno del jugador 1
        If lblturno.Text.Contains("J1:") Then

            'validacion de respuesta 
            obj.validresp()

            'turno del jugador 2
        End If
        If lblturno.Text.Contains("J2:") Then

            'validacion de respuesta 
            obj.validresp2()
        End If


        'puntuacion de los jugadores 
        lblPunt.Text = "Puntuación J1: " + obj.puntos.ToString
        lblPunt2.Text = "Puntuación J2: " + obj.puntuacion2.ToString
        obj.avancedepreg()
        disab50()
        unavezcada1cinc1()
        unavezcada1cinc2()
        unavezcada1llamada()
        unavezcada1llamada2()
        unavezcada1RespPubl()
        unavezcada1RespPubl2()

        If frmJuego.lblunjug.Text = "1" Then
            Sigpreg()
        ElseIf frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            Sigpreg2Jug()
        End If
        lblOculSiguien.Text = obj.numSig.ToString

        If frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            AvancePuntuacion()

        End If
        TimerPregunt.Start()
        lblSeg.Text = "25"
    End Sub

    Private Sub Btnresp3_Click(sender As Object, e As EventArgs) Handles btnresp3.Click

        respuestasCultura()
        respuestasDeportes()
        respuestasSalud()
        respuestasPolitica()
        respuestasFinanzas()
        respuestasHistoria()
        respuestasCiencia()
        respuestasTecnologia()
        respuestasAstronomia()
        respuestasMusica()

        TimerPregunt.Stop()
        'respuesta dada igual a btnrespuesta 3
        obj.RespuestaDada = btnresp3.Text
        If lblturno.Text.Contains("J1:") Then
            obj.validresp()
        ElseIf lblturno.Text.Contains("J2:") Then
            obj.validresp2()
        End If

        'puntuacion de los jugadores 
        lblPunt.Text = "Puntuación J1: " + obj.puntos.ToString
        lblPunt2.Text = "Puntuación J2: " + obj.puntuacion2.ToString
        obj.avancedepreg()
        disab50()
        unavezcada1cinc1()
        unavezcada1cinc2()
        unavezcada1llamada()
        unavezcada1llamada2()
        unavezcada1RespPubl()
        unavezcada1RespPubl2()

        'jugador 1
        If frmJuego.lblunjug.Text = "1" Then

            'siguiente pregunta 
            Sigpreg()

            'entre jugador  1 y jugador 2
        ElseIf frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then

            'siguiente  pregunta 
            Sigpreg2Jug()
        End If

        lblOculSiguien.Text = obj.numSig.ToString

        If frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            AvancePuntuacion()

        End If
        TimerPregunt.Start()
        lblSeg.Text = "25"
    End Sub

    Private Sub Btnresp4_Click(sender As Object, e As EventArgs) Handles btnresp4.Click
        'respuesta dada igual a btnrespuesta 2
        'categorias 
        respuestasCultura()
        respuestasDeportes()
        respuestasSalud()
        respuestasPolitica()
        respuestasFinanzas()
        respuestasHistoria()
        respuestasCiencia()
        respuestasTecnologia()
        respuestasAstronomia()
        respuestasMusica()

        TimerPregunt.Stop()

        'respuesta dada igual a btnrespuesta 4
        obj.RespuestaDada = btnresp4.Text
        If lblturno.Text.Contains("J1:") Then
            obj.validresp()
        ElseIf lblturno.Text.Contains("J2:") Then
            obj.validresp2()
        End If

        'puntuacion de los jugadores 
        lblPunt.Text = "Puntuación J1: " + obj.puntos.ToString
        lblPunt2.Text = "Puntuación J2: " + obj.puntuacion2.ToString

        'metodos 
        obj.avancedepreg()
        disab50()
        unavezcada1cinc1()
        unavezcada1cinc2()
        unavezcada1llamada()
        unavezcada1llamada2()
        unavezcada1RespPubl()
        unavezcada1RespPubl2()


        If frmJuego.lblunjug.Text = "1" Then
            Sigpreg()
        ElseIf frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            Sigpreg2Jug()
        End If
        lblOculSiguien.Text = obj.numSig.ToString


        If frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            AvancePuntuacion()

        End If
        TimerPregunt.Start()
        lblSeg.Text = "25"
    End Sub


    '******************************************************************************************************************
    Private Sub FrmPregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'metodo de comodin 
        obj.cincuentacincuent = False
        obj.llamadabln = False
        obj.PublicAnswbln = False
        'btnIniciar.PerformClick()

        ' lblOcultSiguien.Visible = True
        obj.aleatorio()
        obj.VectLlen()
        obj.aleatorio()
        obj.VectLlen2()
        obj.NumerosDiferentes()
        obj.NumerosDiferentes2()


        obj.nomJ1 = frmJuego.txtnombre1.Text
        obj.nomJ2 = frmJuego.txtnombre2.Text
        lblTurno.Text = "Turno J1: " + obj.nomJ1

        btnIniciar.PerformClick()
        btnIniciar.Visible = False
        TimerPregunt.Start()

    End Sub
    '*******************************************************************************************************************
    Sub unavezcada1cinc1()
        'posibilidad de usar una vez el 50/50
        If lblturno.Text.Contains("J1:") And obj.unavezcinc = 0 Then

            TSMIcincuenta.Enabled = True
        End If

        'si ya lo uso no se puede usar mas 
        If lblturno.Text.Contains("J1:") And obj.unavezcinc = 1 Then

            TSMIcincuenta.Enabled = False
        End If
    End Sub
    '*****************************************************************************************
    Sub unavezcada1cinc2()
        'posibilidad de usar una vez el 50/50
        If lblturno.Text.Contains("J2:") And obj.unavezcinc2 = 0 Then

            TSMIcincuenta.Enabled = True
        End If


        If lblturno.Text.Contains("J2:") And obj.unavezcinc2 = 1 Then

            TSMIcincuenta.Enabled = False
        End If
    End Sub
    '*****************************************************************************************
    Sub unavezcada1llamada()
        'posibilidad de usar la llamda una vez 
        If lblturno.Text.Contains("J1:") And obj.unavezllamda = 0 Then

            LlamadaToolStripMenuItem.Enabled = True
        End If

        'si ya lo uso no se puede usar mas 
        If lblturno.Text.Contains("J1:") And obj.unavezllamda = 1 Then

            LlamadaToolStripMenuItem.Enabled = False
        End If
    End Sub
    '**********************************************************************************************
    Sub unavezcada1llamada2()

        'posibilidad de usar la llamda una vez jugador2
        If lblturno.Text.Contains("J2:") And obj.unavezllamda2 = 0 Then

            LlamadaToolStripMenuItem.Enabled = True
        End If

        'si ya lo uso no se puede usar mas 
        If lblturno.Text.Contains("J2:") And obj.unavezllamda2 = 1 Then

            LlamadaToolStripMenuItem.Enabled = False
        End If

    End Sub
    '******************************************************************************************************
    Sub unavezcada1RespPubl()

        'posibilidad de usar la respuesta del publico
        If lblturno.Text.Contains("J1:") And obj.unavezrespPubl = 0 Then

            RespuestaDelPúblicoToolStripMenuItem.Enabled = True
        End If

        'si ya lo uso no se puede usar mas 
        If lblturno.Text.Contains("J1:") And obj.unavezrespPubl = 1 Then

            RespuestaDelPúblicoToolStripMenuItem.Enabled = False
        End If
    End Sub
    '******************************************************************************************************
    Sub unavezcada1RespPubl2()
        'posibilidad de usar la respuesta del publico
        If lblturno.Text.Contains("J2:") And obj.unavezrespPubl2 = 0 Then

            RespuestaDelPúblicoToolStripMenuItem.Enabled = True
        End If

        'si ya lo uso no se puede usar mas 
        If lblturno.Text.Contains("J2:") And obj.unavezrespPubl2 = 1 Then
            RespuestaDelPúblicoToolStripMenuItem.Enabled = False
        End If

    End Sub

    '******************************************************************************************************

    'metodo de preguntas segun categoria 

    Sub respuestasCultura()
        'pregunta segun la categoria 
        If lblPregunta.Text = "¿Primer presidente de Costa Rica?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        ElseIf lblPregunta.Text = "¿Cuánto duro la guerra de los 100 años?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Autor de la pintura: Las meninas?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cúal es el 6 planeta del Sistema Solar?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Creador de la bombilla?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién pintó: El grito?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país se ubica bosque del Amazonas?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué continente se ubica Filipinas?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de los siguientes libros fue escrito por Albert Einstein?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuánto duró la segunda guerra mundial?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué año terminó la primera guerra mundial?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué fecha se celebra el día del café?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué color se obtiene al mezclar pintura Amarilla con Azul?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién mató a Hércules?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué año se creó el carro con gasolina?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Proceso único de los animles?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Raza única en los gatos?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de las siguientes opciones NO es una planta?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Creador del WC de descarga?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es el continente más grande del mundo?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es el animal más grande del mundo?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Año en el que se creó la primera red informática?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué representa la hoz y el martillo en la bandera de la Unión Sovietica?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Año en qué murio Nelson Mandela?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país nació Freddie Mercury?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub
    '*************************************************************************************************************
    'metodo de la categoria de deportes 
    Sub respuestasDeportes()
        If lblPregunta.Text = "¿En qué año se celebro el primer mundial de fútbol?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuántos jugadores hay en un partido de baloncesto?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es el apodo del ciclista Eddy Merckx?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién ganó el tour de francia 2010?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El primer tour de Francia se llevo a cabo en el año:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién ganó el mundial de 1998?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Dónde se llevó a cabo el mundial de fútbol de 1994?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de las siguientes boxeadoras es Costarricense?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Técnica que se puede realizar en Esgrima:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué medalla obtiene Nery Brenes en los juegos de Barranquilla 2018?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El hombre más fuerte del mundo es:" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué pasa si una mujer se inyecta esteroides?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Con qué propósito los culturistas se inyectan esteroides?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En dónde se celebró los juegos olímpicos del 2004?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién recibió el balón de oro en el año 2014?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Ganador del Guante de oro en el 2010" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Ganador del Premio Bota de Oro en el 2006" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿A quién le dan el premio: Bota de oro?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "En los juegos Olímpicos¿Cuántas medallas ha ganado Costa Rica?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país se celebraron los juegos olímpicos de 1936?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El deportista con más medallas olímpicas es:" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "ESPN escoge al mejor jugador de la historia de Baloncesto; el cual fue:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país se celebró el Campeonato mundial de atletismo 2015?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El estadio más grande del mundo se ubica en:" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El 28 de Junio de 1997; Mike Tyson le muerde la oreja a:" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub
    '****************************************************************************************************************************
    'metodo de la categoria de salud 
    Sub respuestasSalud()
        If lblPregunta.Text = "¿Cuántas días es recomentable hacer ejercicio a la semana?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es una de las funciones que cumple la creatina en el organismo?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es la función principal de la proteína en nuestro organismo?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de los siguientes alimentos No tienen vitamina C?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuántos litros de agua se recomiendan beber al día?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de las siguientes enfermedades se producen debido al consumo excesivo de bebidas alcoholicas?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Después de un ejercicio pesado ¿Qué se recomienda comer para la recuperación muscular?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es el rango de IMC recomendable para estar saludable?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es la fórmula para calcular el IMC?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuántos latidos por minuto tiene un adulto en promedio?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuánto suele durar una gripe?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué es la clamidia?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué causa la bacteria Treponema pallidum?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Con que propósito los culturistas se inyectan esteroides?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué es la Tricomoniasis?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Por qué es importante comer verduras?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de los siguientes efectos es debido a la hipertensión arterial?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué provoca el catabolismo muscular?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿El consumo de cocaína puede provocar?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de los siguientes síntomas se debe a la gripe porcina?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué es daño hepático?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué produce la viruela?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de las siguientes enfermedades es producida por un Virus?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de las siguientes enfermedades es una enfermedad osea?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "De las siguientes enfermedades ¿Cuál es causada por la heroína?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "El botulismo se debe a:" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub
    '***************************************************************
    'metodo para la categoria de politica 

    Sub respuestasPolitica()

        If lblPregunta.Text = "¿Que significa TSE?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien es Pancha Carrazco?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien es el dirigente en Corea del Norte?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién fue el primer presidente de la democracia en España?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que presidente estadounidense tiene un premio Nóbel?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama la Reina del Reino Unido?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien es el presidente de Espana?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama el procedimiento de subir la bandera?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Donde esta la Casa Blanca?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que politico cubano fue presidente tras su victoria en la revolucion contra el regimen dictatorial de Fulgencio Batista?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que rey ingles fue famoso por decapitar a sus esposas?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien fue el primer presidente afroamericano electo en los Estados Unidos?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿A qué terrorista se atribuyen la organizacion de los atentados de EEUU el 11 de septiembre de 1999?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien fue la primera mujer presidente de la republica en CR?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Actividad de los que gobiernan o aspiran a gobernar los asuntos que afectan a la sociedad o a un país?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual pais posee un Partido Federal?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien fue Nelson Mandela?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que personaje fue democratico?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿De que pais salio el Regimen totalitario?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Eliminacion de las libertades y Prohibición de partidos políticos y sindicatos de que Regimen es?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuantos tipos de regimen Islamico?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Filipinas de que regimen es?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Instituciones y leyes que permiten la organización del Estado y el ejercicio del poder:" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Pais que es del regimen Politico?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Eliminación de las libertades y Prohibición de partidos políticos y sindicatos de que Regimen es?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Pais que es del regimen Politico?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién es Gandhi?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub
    '********************************************************************************************************************
    Sub respuestasFinanzas()
        If lblPregunta.Text = "¿Cual es el significado de Deber?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cual  es el margen?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cual son las partes del balance general?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿donde se anota elnombre de la empresa?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿que significa las siglas cxc?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿un ejemplo de un activo?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cuantos captales hay?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿nombre de una delas capitales necesarios para llevar en la economia?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿que signfica haber?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que politico cubano fue presidente tras su victoria en la revolucion contra el regimen dictatorial de Fulgencio Batista?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿que significa debe?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cual es uno de los activos?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿pagar es lo mismo que cobrar?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿un pago por anticipado es?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿un activo se puede convertir en gasto cuando?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿un activo se puede convertir en gasto cuando?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿la cuenta en bonos son?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que personaje fue democratico?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿el estado de situacion financiera esta dividido en?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿es uno de los instrumentos que funciona para tener bien sea articulo o empresa:?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿nombre del libro que se usa para llevar las cuentas de la empresa?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cual es la formula de patrimonio?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿como se llama la istitucion que vela por los contadores?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿ciencia empirica que nos permite conocer la realidad economica?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿es uno de los bienes derechos y obligaciones que forman el patrimonio de la empresa?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿tipo de activo  corriente?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿representacion completa de los elementos patrimoniales en un momento determinado?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿tipo de activo no corriente?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        End If
    End Sub
    '**************************************************************************************************************************ç
    Sub respuestasAstronomia()
        If lblPregunta.Text = "¿Velocidad de rotacion de la tierra?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuanto tarda en tiempo una particula de luz salir desde el nucleo del sol a la superficie de este?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Principal origen de los agugeros negros?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama el telescopio espacial de 1990 ?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama el planeta que esta en nuestra galaxia compuesto de diamante?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Diametro de los anillos de saturno?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que edad tiene la tierra en millones de años?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien fue el primero en usar un telescopio para ver las estrellas?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Se encarga del nacimiento y muerte del universo?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien descubrió la expansión del universo?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama nuestra galaxia?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el mejor lugar para estudiar la astronomia?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la galaxia mas cercana a la nuestra?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que tipo de estrella es nuestro sol?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llaman los planetas que orbitan una estrella diferente al sol?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la galaxia mas grande conocida?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llaman las nubes de gas y polvo situadas entre las estrellas?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que planeta del sistema solar absorve basura espacial?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que planeta del sistema solar es el mas caliente?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que planeta del sistema solar es el mas pequeño?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que se genera cuando una estrella agota su combustible nuclear?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la estrella mas brillante de la constelacion de escorpio?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la estrella más brillante del cielo nocturno?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la estrella que brilla mas que el sol?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que se produce cuando una enana blanca explota?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        End If
    End Sub
    '*****************************************************************************************************************************
    ' preguntas de la categoria de ciencia 
    Sub respuestasCiencia()
        If lblPregunta.Text = "¿Cual es el animal mas grande que habita la tierra?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que parte del ser humano consuma mas energia?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que galaxia se encuentra la tierra?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la formula quimica del agua?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el unico satelite natural de la tierra?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual fue le dinisaurio mas grande?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el planeta mas cercano al sol?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el primer elemento de la tabla periodica?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que planeta del sistema solar es el mas pequeño?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama el centro de un atomo?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Nombre de la sustancia que le da pigmentacion a la piel?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Nombre de un metal en el nucleo de la tierra?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿De que sustncia estan hechas las uñas?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien invento la tabla periodica?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el elemento menos denso de la tabla periodica?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien es el padre de la ciencia moderna?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
        ElseIf lblPregunta.Text = "¿Que tipo de animal es el ornitorrinco?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es la montaña terrestre mas alta del mundo?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuantas personas han pisado la luna hasta el 2019?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuantas faces tiene la luna?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuantas capas tiene la atmosfera?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuantos miligramos hay en un kilogramo?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual es el mamifero mas pequeño del mundo?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien es le padre de la quimica moderna?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿De estudio que se encarga la botanica?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        End If
    End Sub
    '*****************************************************************************************************************************
    Sub respuestasTecnologia()
        If lblPregunta.Text = "¿En que año nace el sistema operarivo Linux?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año nace el lenguaje COBOL (Lenguaje Comun Orientado a Negocios)?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cómo se llama la compañia dueña de los creadores de GTA?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año fue creado el primer malware?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llamo el primer malware?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿¿Por quien fue creado el primer virus tecnologico?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien creo eBay?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año sale Internet explorer?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien creo Gmail?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llamó el primer video de Youtube?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año se creo Youtube?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama la mascota de Twitter?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como se llama el telescopio espacial de 1990 ?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien creo el @?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Año en que lanza IBM su primer computadora?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Guido Van Rossum fue el creador de?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Brendan Eich fue el creador de?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Rasmus Lerdorf fue el creador de?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año nace Google?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien fue el primer programador?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien inventó el protocolo TCP / IP en la década de 1970 ?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año circulo en primer carro en Costa Rica?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Un lenguaje de hipertexto?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es la unidad más pequeña de representación de información en un ordenador?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué atajo de teclas usamos para cerrar una ventana en Windows?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        End If
    End Sub

    '*****************************************************************************************************************************
    Sub respuestasHistoria()
        If lblPregunta.Text = "¿Qué motivó la rebelión que dio lugar a la Guerra de la Independencia de EEUU?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué año dejó de existir el estado llamado Yugoslavia?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué guerra se hundió el buque HMS Coventry?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién pronunció la frase 'Bebamos de la copa de la destrucción'?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿De qué estaba fabricado originalmente el maquillaje blanco de las geishas?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Para qué fue creado el Plan Marshall en 1947?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país nació el protestantismo?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué ciudad española era conocida como 'Lucentum' por los romanos?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué año viajó el primer hombre a la Luna?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál era el nombre antiguo de Grecia?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cual fue le dinisaurio mas grande?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es el nombre de la homínido más antigua en el mundo?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿De estos políticos cuál fue el más conocido en la  Revolución Francesa?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién fue el primer rey de Roma?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién fue el responsable de la creación de los derechos humanos?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién fue el maestro de Platón?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Con qué nombre se conoció a la Primera Guerra Mundial en su época?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "En el Antiguo Egipto ¿Qué Dios representaba al Sol?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién pintó 'La última cena'?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Según la historia ¿qué animal amamantó a Rómulo y a Remo?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién inventó el teléfono??" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿cual es la formula de patrimonio?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Con quién estaba casada 'Juana la Loca'?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué líder tribal luchó contra la ocupación romana de Gran Bretaña (Britania)?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué esposas de Enrique VIII fueron decapitadas?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quien descubrió la expansión del universo?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Como murio Hitler?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que año finalizo la II Guerra Mundial?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub

    'Respuestas de Musica
    Sub respuestasMusica()
        'pregunta segun la categoria 
        If lblPregunta.Text = "¿Cuántas lineas y espacios tiene un pentagrama?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()

        ElseIf lblPregunta.Text = "¿Quién compuso: Las cuatro estaciones?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de estos no es un compositor barroco?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿A cuántas semicorcheas equivale una blanca?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿A cuántas negras equivale una redonda?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En qué país nació Johan Sebastian Bach?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Qué es un aria dentro de una ópera?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿A qué edad murió Wolfgang Amadeus Mozart?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Tres de estos compositores nacieron el mismo año: 1685 ¿Cuál no?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿La 'oda a la alegría' forma parte de que sinfonía de Beethoven?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de estas no es una opera de Verdi?" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿En que ciudad se originó el Jazz?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál de estos instrumentos no es de viento-madera?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuántas cuerdas tiene un violín?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Cuál es la única banda de rock de la historia en la que cada miembro ha compuesto una canción que ha llegado a ser número uno como single?" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Cantante de I Will Always Love You:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "La canción Sobreviviré es de:" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 4
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Continua la canción: Pequeño Pony" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 5
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Aplicación para oir música" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Quién canta everything i do?" Then
            obj.RespuestaCorrecta = btnresp2.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Michael Jackson muere en el año:" Then
            obj.RespuestaCorrecta = btnresp3.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Primer ending de dragon ball super:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 3
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Jon Bon Jovi muere en el año:" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 1
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "Ariana Grande canta música:" Then
            obj.RespuestaCorrecta = btnresp1.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        ElseIf lblPregunta.Text = "¿Que banda interpreta i dont wanna miss a thing?" Then
            obj.RespuestaCorrecta = btnresp4.Text
            respuestIncorrect()
            obj.puntoValor = 2
            ocultbtns1()
            llamadaJug()
            RespPublAlJug()
        End If
    End Sub

    '***********************************************************************************************************************
    'metodo del juego 
    Sub llamadaJug()
        'condicion de la llamada segun el jugador 1
        If obj.llamadabln = True And lblturno.Text.Contains("J1:") Then
            obj.llamada()
            obj.llamadabln = False

            'condicion de la llamada para el jugador 2 
        ElseIf obj.llamadabln = True And lblturno.Text.Contains("J2:") Then
            obj.llamada()
            obj.llamadabln = False
        End If
    End Sub
    '************************************************************************************************************
    'metodo para opciones de respuesta restantes 
    Sub opcionesrestant1()
        'condicion de respuestas correcta igual a boton 1 entonces 
        If obj.RespuestaCorrecta = btnresp1.Text Then
            obj.opcionPublico2 = btnresp2.Text
            obj.opcionPublico3 = btnresp3.Text
            obj.opcionPublico4 = btnresp4.Text

            'condicion de respuestas correcta igual a boton 2 entonces
        ElseIf obj.RespuestaCorrecta = btnresp2.Text Then
            obj.opcionPublico2 = btnresp2.Text
            obj.opcionPublico3 = btnresp3.Text
            obj.opcionPublico4 = btnresp4.Text

            'condicion de respuestas correcta igual a boton 3 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp3.Text Then
            obj.opcionPublico2 = btnresp1.Text
            obj.opcionPublico3 = btnresp2.Text
            obj.opcionPublico4 = btnresp4.Text

            'condicion de respuestas correcta igual a boton 4 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp4.Text Then
            obj.opcionPublico2 = btnresp1.Text
            obj.opcionPublico3 = btnresp2.Text
            obj.opcionPublico4 = btnresp3.Text
        End If
    End Sub
    '*********************************************************************************
    Sub opcionesrestant2()
        'condicion de respuestas correcta igual a boton 1 entonces 
        If obj.RespuestaCorrecta = btnresp1.Text Then
            obj.opcionPublico2 = btnresp4.Text
            obj.opcionPublico3 = btnresp3.Text
            obj.opcionPublico4 = btnresp2.Text

            'condicion de respuestas correcta igual a boton 2 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp2.Text Then
            obj.opcionPublico2 = btnresp4.Text
            obj.opcionPublico3 = btnresp2.Text
            obj.opcionPublico4 = btnresp3.Text

            'condicion de respuestas correcta igual a boton 3 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp3.Text Then
            obj.opcionPublico2 = btnresp1.Text
            obj.opcionPublico3 = btnresp4.Text
            obj.opcionPublico4 = btnresp2.Text

            'condicion de respuestas correcta igual a boton 4 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp4.Text Then
            obj.opcionPublico2 = btnresp3.Text
            obj.opcionPublico3 = btnresp1.Text
            obj.opcionPublico4 = btnresp2.Text
        End If
    End Sub
    '*********************************************************************************
    'metodo de respuestas restantes 3
    Sub opcionesrestant3()
        'condicion de respuestas correcta igual a boton 1 entonces 
        If obj.RespuestaCorrecta = btnresp1.Text Then
            obj.opcionPublico2 = btnresp3.Text
            obj.opcionPublico3 = btnresp2.Text
            obj.opcionPublico4 = btnresp4.Text

            'condicion de respuestas correcta igual a boton 2 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp2.Text Then
            obj.opcionPublico2 = btnresp3.Text
            obj.opcionPublico3 = btnresp2.Text
            obj.opcionPublico4 = btnresp4.Text

            'condicion de respuestas correcta igual a boton 3 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp3.Text Then
            obj.opcionPublico2 = btnresp2.Text
            obj.opcionPublico3 = btnresp4.Text
            obj.opcionPublico4 = btnresp1.Text

            'condicion de respuestas correcta igual a boton 4 entonces 
        ElseIf obj.RespuestaCorrecta = btnresp4.Text Then
            obj.opcionPublico2 = btnresp1.Text
            obj.opcionPublico3 = btnresp3.Text
            obj.opcionPublico4 = btnresp2.Text
        End If
    End Sub
    '*******************************************************************************************************************
    'metodo de la respuesta del publico al jugador 
    Sub RespPublAlJug()
        'objeto de variacion de respuesta 
        obj.variarrespuest()

        'si la respuesta del publico es verdadera del jugador 1  entonces 
        If obj.PublicAnswbln = True And lblturno.Text.Contains("J1:") And obj.variarpubl = 1 Then
            'opciones restantes que esta en el metodo
            opcionesrestant1()
            'respuesta del publico 
            obj.RespuestaPublico()
            obj.PublicAnswbln = False

            'si la respuesta del publico es verdadera del jugador 2  entonces 
        ElseIf obj.PublicAnswbln = True And lblturno.Text.Contains("J2:") And obj.variarpubl = 1 Then
            'opciones restantes que esta en el metodo
            opcionesrestant2()
            obj.RespuestaPublico()
            obj.PublicAnswbln = False

            'si la respuesta del publico es verdadera del jugador 1  entonces 
        ElseIf obj.PublicAnswbln = True And lblturno.Text.Contains("J1:") And obj.variarpubl = 2 Then
            'opciones restantes que esta en el metodo
            opcionesrestant2()
            obj.RespuestaPublico()
            obj.PublicAnswbln = False

            'si la respuesta del publico es verdadera del jugador 2 entonces 
        ElseIf obj.PublicAnswbln = True And lblturno.Text.Contains("J2:") And obj.variarpubl = 2 Then
            'opciones restantes que esta en el metodo
            opcionesrestant3()
            obj.RespuestaPublico()
            obj.PublicAnswbln = False

            'si la respuesta del publico es verdadera del jugador 1  entonces 
        ElseIf obj.PublicAnswbln = True And lblturno.Text.Contains("J1:") And obj.variarpubl = 3 Then
            'opciones restantes que esta en el metodo
            opcionesrestant3()
            obj.RespuestaPublico()
            obj.PublicAnswbln = False

            'si la respuesta del publico es verdadera del jugador 1  entonces 
        ElseIf obj.PublicAnswbln = True And lblturno.Text.Contains("J2:") And obj.variarpubl = 3 Then
            'opciones restantes que esta en el metodo
            opcionesrestant1()
            obj.RespuestaPublico()
            obj.PublicAnswbln = False
        End If
    End Sub
    '**************************************************************************************
    'metodo de respuesta incorrecta 
    Sub respuestIncorrect()

        ' si la respuesta correcta es la opcion 1
        If obj.RespuestaCorrecta = btnresp1.Text Then

            'respuesta incorrecta
            obj.RespuestaIncorr = btnresp3.Text

            ' si la respuesta correcta es la opcion 2
        ElseIf obj.RespuestaCorrecta = btnresp2.Text Then

            'respuesta incorrecta
            obj.RespuestaIncorr = btnresp4.Text

            ' si la respuesta correcta es la opcion 3
        ElseIf obj.RespuestaCorrecta = btnresp3.Text Then
            'respuesta incorrecta
            obj.RespuestaIncorr = btnresp1.Text

            ' si la respuesta correcta es la opcion 4
        ElseIf obj.RespuestaCorrecta = btnresp4.Text Then
            'respuesta incorrecta
            obj.RespuestaIncorr = btnresp2.Text
        End If
    End Sub
    '**********************************************************************************************************************************************************
    'metodo de boton 1
    Sub ocultbtns1()

        'si 50/50 es verdad, la respuesta correcta es igual a opcion 1 y 50/50 es es verdad, la respuesta correcta es igual a opcion 2
        If obj.cincuentacincuent = True And obj.RespuestaCorrecta = btnresp1.Text Or obj.cincuentacincuent = True And obj.RespuestaCorrecta = btnresp2.Text Then
            btnresp3.Visible = False
            btnresp4.Visible = False
            obj.cincuentacincuent = False

            'si 50/50 es verdad, la respuesta correcta es igual a opcion 3 y 50/50 es es verdad, la respuesta correcta es igual a opcion 4
        ElseIf obj.cincuentacincuent = True And obj.RespuestaCorrecta = btnresp3.Text Or obj.cincuentacincuent = True And obj.RespuestaCorrecta = btnresp4.Text Then
            btnresp1.Visible = False
            btnresp2.Visible = False
            obj.cincuentacincuent = False
        End If
    End Sub
    '*************************************************************************************************************************************
    'metodo del desuso de 50/50
    Sub disab50()

        'si 50/50 es falso 
        If obj.cincuentacincuent = False Then
            btnresp1.Visible = True
            btnresp2.Visible = True
            btnresp3.Visible = True
            btnresp4.Visible = True
        End If
    End Sub
    '**************************************************************************************************************************************
    'metodos de preguntas para agregar en el data grid view 

    Sub Pregunta1()
        lblPregunta.Text = frmJuego.dgvLector.Rows(0).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(0).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(0).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(0).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(0).Cells(4).Value
    End Sub
    Sub Pregunta2()
        lblPregunta.Text = frmJuego.dgvLector.Rows(1).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(1).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(1).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(1).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(1).Cells(4).Value
    End Sub
    Sub Pregunta3()
        lblPregunta.Text = frmJuego.dgvLector.Rows(2).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(2).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(2).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(2).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(2).Cells(4).Value
    End Sub
    Sub Pregunta4()
        lblPregunta.Text = frmJuego.dgvLector.Rows(3).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(3).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(3).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(3).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(3).Cells(4).Value
    End Sub
    Sub Pregunta5()
        lblPregunta.Text = frmJuego.dgvLector.Rows(4).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(4).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(4).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(4).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(4).Cells(4).Value
    End Sub
    Sub Pregunta6()
        lblPregunta.Text = frmJuego.dgvLector.Rows(5).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(5).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(5).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(5).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(5).Cells(4).Value
    End Sub
    Sub Pregunta7()
        lblPregunta.Text = frmJuego.dgvLector.Rows(6).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(6).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(6).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(6).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(6).Cells(4).Value
    End Sub
    Sub Pregunta8()
        lblPregunta.Text = frmJuego.dgvLector.Rows(7).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(7).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(7).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(7).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(7).Cells(4).Value
    End Sub
    Sub Pregunta9()
        lblPregunta.Text = frmJuego.dgvLector.Rows(8).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(8).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(8).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(8).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(8).Cells(4).Value
    End Sub
    Sub Pregunta10()
        lblPregunta.Text = frmJuego.dgvLector.Rows(9).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(9).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(9).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(9).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(9).Cells(4).Value
    End Sub
    Sub Pregunta11()
        lblPregunta.Text = frmJuego.dgvLector.Rows(10).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(10).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(10).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(10).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(10).Cells(4).Value
    End Sub
    Sub Pregunta12()
        lblPregunta.Text = frmJuego.dgvLector.Rows(11).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(11).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(11).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(11).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(11).Cells(4).Value
    End Sub
    Sub Pregunta13()
        lblPregunta.Text = frmJuego.dgvLector.Rows(12).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(12).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(12).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(12).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(12).Cells(4).Value
    End Sub
    Sub Pregunta14()
        lblPregunta.Text = frmJuego.dgvLector.Rows(13).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(13).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(13).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(13).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(13).Cells(4).Value
    End Sub
    Sub Pregunta15()
        lblPregunta.Text = frmJuego.dgvLector.Rows(14).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(14).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(14).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(14).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(14).Cells(4).Value
    End Sub
    Sub Pregunta16()
        lblPregunta.Text = frmJuego.dgvLector.Rows(15).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(15).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(15).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(15).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(15).Cells(4).Value
    End Sub
    Sub Pregunta17()
        lblPregunta.Text = frmJuego.dgvLector.Rows(16).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(16).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(16).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(16).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(16).Cells(4).Value
    End Sub
    Sub Pregunta18()
        lblPregunta.Text = frmJuego.dgvLector.Rows(17).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(17).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(17).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(17).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(17).Cells(4).Value
    End Sub
    Sub Pregunta19()
        lblPregunta.Text = frmJuego.dgvLector.Rows(18).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(18).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(18).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(18).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(18).Cells(4).Value
    End Sub
    Sub Pregunta20()
        lblPregunta.Text = frmJuego.dgvLector.Rows(19).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(19).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(19).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(19).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(19).Cells(4).Value
    End Sub
    Sub Pregunta21()
        lblPregunta.Text = frmJuego.dgvLector.Rows(20).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(20).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(20).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(20).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(20).Cells(4).Value
    End Sub
    Sub Pregunta22()
        lblPregunta.Text = frmJuego.dgvLector.Rows(21).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(21).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(21).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(21).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(21).Cells(4).Value
    End Sub
    Sub Pregunta23()

        lblPregunta.Text = frmJuego.dgvLector.Rows(22).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(22).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(22).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(22).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(22).Cells(4).Value
    End Sub
    Sub Pregunta24()
        lblPregunta.Text = frmJuego.dgvLector.Rows(23).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(23).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(23).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(23).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(23).Cells(4).Value
    End Sub
    Sub Pregunta25()
        lblPregunta.Text = frmJuego.dgvLector.Rows(24).Cells(0).Value
        btnresp1.Text = frmJuego.dgvLector.Rows(24).Cells(1).Value
        btnresp2.Text = frmJuego.dgvLector.Rows(24).Cells(2).Value
        btnresp3.Text = frmJuego.dgvLector.Rows(24).Cells(3).Value
        btnresp4.Text = frmJuego.dgvLector.Rows(24).Cells(4).Value
    End Sub
    '*****************************************************************************************************************************
    'metodo de pregunta siguiente para el segundo jugador 2
    Sub SigPreg2()
        If obj.VectorLleno(1) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(1) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(1) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(1) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(1) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(1) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(1) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(1) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(1) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(1) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(1) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(1) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(1) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(1) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(1) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(1) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(1) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(1) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(1) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(1) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(1) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(1) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(1) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(1) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(1) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg3()
        If obj.VectorLleno(2) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(2) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(2) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(2) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(2) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(2) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(2) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(2) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(2) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(2) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(2) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(2) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(2) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(2) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(2) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(2) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(2) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(2) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(2) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(2) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(2) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(2) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(2) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(2) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(2) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg4()
        If obj.VectorLleno(3) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(3) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(3) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(3) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(3) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(3) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(3) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(3) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(3) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(3) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(3) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(3) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(3) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(3) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(3) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(3) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(3) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(3) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(3) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(3) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(3) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(3) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(3) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(3) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(3) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg5()
        If obj.VectorLleno(4) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(4) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(4) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(4) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(4) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(4) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(4) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(4) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(4) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(4) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(4) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(4) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(4) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(4) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(4) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(4) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(4) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(4) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(4) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(4) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(4) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(4) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(4) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(4) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(4) = 25 Then
            Pregunta25()
        End If

    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg6()
        If obj.VectorLleno(5) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(5) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(5) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(5) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(5) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(5) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(5) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(5) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(5) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(5) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(5) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(5) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(5) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(5) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(5) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(5) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(5) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(5) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(5) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(5) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(5) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(5) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(5) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(5) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(5) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg7()
        If obj.VectorLleno(6) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(6) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(6) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(6) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(6) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(6) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(6) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(6) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(6) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(6) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(6) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(6) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(6) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(6) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(6) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(6) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(6) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(6) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(6) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(6) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(6) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(6) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(6) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(6) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(6) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg8()
        If obj.VectorLleno(7) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(7) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(7) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(7) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(7) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(7) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(7) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(7) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(7) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(7) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(7) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(7) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(7) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(7) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(7) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(7) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(7) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(7) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(7) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(7) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(7) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(7) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(7) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(7) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(7) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg9()
        If obj.VectorLleno(8) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(8) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(8) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(8) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(8) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(8) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(8) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(8) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(8) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(8) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(8) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(8) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(8) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(8) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(8) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(8) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(8) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(8) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(8) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(8) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(8) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(8) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(8) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(8) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(8) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg10()
        If obj.VectorLleno(9) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(9) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(9) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(9) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(9) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(9) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(9) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(9) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(9) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(9) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(9) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(9) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(9) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(9) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(9) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(9) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(9) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(9) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(9) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(9) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(9) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(9) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(9) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(9) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(9) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg11()
        If obj.VectorLleno(10) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(10) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(10) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(10) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(10) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(10) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(10) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(10) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(10) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(10) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(10) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(10) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(10) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(10) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(10) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(10) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(10) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(10) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(10) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(10) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(10) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(10) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(10) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(10) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(10) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg12()
        If obj.VectorLleno(11) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(11) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(11) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(11) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(11) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(11) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(11) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(11) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(11) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(11) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(11) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(11) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(11) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(11) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(11) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(11) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(11) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(11) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(11) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(11) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(11) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(11) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(11) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(11) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(11) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg13()
        If obj.VectorLleno(12) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(12) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(12) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(12) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(12) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(12) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(12) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(12) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(12) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(12) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(12) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(12) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(12) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(12) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(12) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(12) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(12) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(12) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(12) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(12) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(12) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(12) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(12) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(12) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(12) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg14()
        If obj.VectorLleno(13) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(13) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(13) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(13) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(13) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(13) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(13) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(13) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(13) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(13) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(13) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(13) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(13) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(13) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(13) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(13) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(13) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(13) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(13) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(13) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(13) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(13) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(13) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(13) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(13) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg15()
        If obj.VectorLleno(14) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(14) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(14) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(14) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(14) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(14) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(14) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(14) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(14) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(14) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(14) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(14) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(14) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(14) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(14) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(14) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(14) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(14) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(14) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(14) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(14) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(14) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(14) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(14) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(14) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg16()
        If obj.VectorLleno(15) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(15) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(15) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(15) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(15) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(15) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(15) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(15) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(15) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(15) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(15) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(15) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(15) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(15) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(15) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(15) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(15) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(15) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(15) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(15) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(15) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(15) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(15) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(15) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(15) = 25 Then
            Pregunta25()
        End If
    End Sub
    '*********************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg17()
        If obj.VectorLleno(16) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(16) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(16) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(16) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(16) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(16) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(16) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(16) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(16) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(16) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(16) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(16) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(16) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(16) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(16) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(16) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(16) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(16) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(16) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(16) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(16) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(16) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(16) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(16) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(16) = 25 Then
            Pregunta25()
        End If
    End Sub
    '*******************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg18()
        If obj.VectorLleno(17) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(17) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(17) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(17) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(17) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(17) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(17) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(17) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(17) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(17) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(17) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(17) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(17) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(17) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(17) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(17) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(17) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(17) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(17) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(17) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(17) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(17) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(17) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(17) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(17) = 25 Then
            Pregunta25()
        End If
    End Sub
    '***************************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg19()
        If obj.VectorLleno(18) = 1 Then
            Pregunta1()
        ElseIf obj.vectorlleno(18) = 2 Then
            Pregunta2()
        ElseIf obj.vectorlleno(18) = 3 Then
            Pregunta3()
        ElseIf obj.vectorlleno(18) = 4 Then
            Pregunta4()
        ElseIf obj.vectorlleno(18) = 5 Then
            Pregunta5()
        ElseIf obj.vectorlleno(18) = 6 Then
            Pregunta6()
        ElseIf obj.vectorlleno(18) = 7 Then
            Pregunta7()
        ElseIf obj.vectorlleno(18) = 8 Then
            Pregunta8()
        ElseIf obj.vectorlleno(18) = 9 Then
            Pregunta9()
        ElseIf obj.vectorlleno(18) = 10 Then
            Pregunta10()
        ElseIf obj.vectorlleno(18) = 11 Then
            Pregunta11()
        ElseIf obj.vectorlleno(18) = 12 Then
            Pregunta12()
        ElseIf obj.vectorlleno(18) = 13 Then
            Pregunta13()
        ElseIf obj.vectorlleno(18) = 14 Then
            Pregunta14()
        ElseIf obj.vectorlleno(18) = 15 Then
            Pregunta15()
        ElseIf obj.vectorlleno(18) = 16 Then
            Pregunta16()
        ElseIf obj.vectorlleno(18) = 17 Then
            Pregunta17()
        ElseIf obj.vectorlleno(18) = 18 Then
            Pregunta18()
        ElseIf obj.vectorlleno(18) = 19 Then
            Pregunta19()
        ElseIf obj.vectorlleno(18) = 20 Then
            Pregunta20()
        ElseIf obj.vectorlleno(18) = 21 Then
            Pregunta21()
        ElseIf obj.vectorlleno(18) = 22 Then
            Pregunta22()
        ElseIf obj.vectorlleno(18) = 23 Then
            Pregunta23()
        ElseIf obj.vectorlleno(18) = 24 Then
            Pregunta24()
        ElseIf obj.vectorlleno(18) = 25 Then
            Pregunta25()
        End If
    End Sub
    '*****************************************************************
    'metodo para las siguientes preguntas 
    Sub sigPreg20()
        'si el vector lleno
        If obj.VectorLleno(19) = 1 Then
            'cada pregunta segun cada condicion
            Pregunta1()
        ElseIf obj.VectorLleno(19) = 2 Then
            Pregunta2()
        ElseIf obj.VectorLleno(19) = 3 Then
            Pregunta3()
        ElseIf obj.VectorLleno(19) = 4 Then
            Pregunta4()
        ElseIf obj.VectorLleno(19) = 5 Then
            Pregunta5()
        ElseIf obj.VectorLleno(19) = 6 Then
            Pregunta6()
        ElseIf obj.VectorLleno(19) = 7 Then
            Pregunta7()
        ElseIf obj.VectorLleno(19) = 8 Then
            Pregunta8()
        ElseIf obj.VectorLleno(19) = 9 Then
            Pregunta9()
        ElseIf obj.VectorLleno(19) = 10 Then
            Pregunta10()
        ElseIf obj.VectorLleno(19) = 11 Then
            Pregunta11()
        ElseIf obj.VectorLleno(19) = 12 Then
            Pregunta12()
        ElseIf obj.VectorLleno(19) = 13 Then
            Pregunta13()
        ElseIf obj.VectorLleno(19) = 14 Then
            Pregunta14()
        ElseIf obj.VectorLleno(19) = 15 Then
            Pregunta15()
        ElseIf obj.VectorLleno(19) = 16 Then
            Pregunta16()
        ElseIf obj.VectorLleno(19) = 17 Then
            Pregunta17()
        ElseIf obj.VectorLleno(19) = 18 Then
            Pregunta18()
        ElseIf obj.VectorLleno(19) = 19 Then
            Pregunta19()
        ElseIf obj.VectorLleno(19) = 20 Then
            Pregunta20()
        ElseIf obj.VectorLleno(19) = 21 Then
            Pregunta21()
        ElseIf obj.VectorLleno(19) = 22 Then
            Pregunta22()
        ElseIf obj.VectorLleno(19) = 23 Then
            Pregunta23()
        ElseIf obj.VectorLleno(19) = 24 Then
            Pregunta24()
        ElseIf obj.VectorLleno(19) = 25 Then
            Pregunta25()
        End If
    End Sub
    '*************************************************************************************************
    ' metodo siguiente pregunta
    Sub Sigpreg()
        'si numero siguiente 
        'se da siguiente pregunta 
        If obj.numSig = 2 Then
            SigPreg2()
        ElseIf obj.numSig = 3 Then
            sigPreg3()
        ElseIf obj.numSig = 4 Then
            sigPreg4()
        ElseIf obj.numSig = 5 Then
            sigPreg5()
        ElseIf obj.numSig = 6 Then
            sigPreg6()
        ElseIf obj.numSig = 7 Then
            sigPreg7()
        ElseIf obj.numSig = 8 Then
            sigPreg8()
        ElseIf obj.numSig = 9 Then
            sigPreg9()
        ElseIf obj.numSig = 10 Then
            sigPreg10()
        ElseIf obj.numSig = 11 Then
            sigPreg11()
        ElseIf obj.numSig = 12 Then
            sigPreg12()
        ElseIf obj.numSig = 13 Then
            sigPreg13()
        ElseIf obj.numSig = 14 Then
            sigPreg14()
        ElseIf obj.numSig = 15 Then
            sigPreg15()
        ElseIf obj.numSig = 16 Then
            sigPreg16()
        ElseIf obj.numSig = 17 Then
            sigPreg17()
        ElseIf obj.numSig = 18 Then
            sigPreg18()
        ElseIf obj.numSig = 19 Then
            sigPreg19()
        ElseIf obj.numSig = 20 Then
            sigPreg20()
        ElseIf obj.numSig = 21 Then
            'al final se genera la puntuacion 
            MsgBox("Felicidades, su puntuación es de: " + obj.puntos.ToString)
            frmJuego.cronometro.Stop()

            'condicion para salir del juego 
            If MsgBox("ha terminado el juego", vbYes + vbQuestion, "Juego terminado") = vbYes Then
                End
            End If
        End If
    End Sub
    '******************************************************

    '*************************************************************************************************************************************
    'region donde estan  preguntas para el jugador 2
#Region "jugador 2"
    Sub Pregunta1J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(0).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(0).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(0).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(0).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(0).Cells(4).Value
    End Sub
    Sub Pregunta2J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(1).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(1).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(1).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(1).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(1).Cells(4).Value
    End Sub
    Sub Pregunta3J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(2).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(2).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(2).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(2).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(2).Cells(4).Value
    End Sub
    Sub Pregunta4J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(3).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(3).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(3).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(3).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(3).Cells(4).Value
    End Sub
    Sub Pregunta5J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(4).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(4).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(4).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(4).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(4).Cells(4).Value
    End Sub
    Sub Pregunta6J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(5).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(5).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(5).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(5).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(5).Cells(4).Value
    End Sub
    Sub Pregunta7J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(6).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(6).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(6).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(6).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(6).Cells(4).Value
    End Sub
    Sub Pregunta8J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(7).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(7).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(7).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(7).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(7).Cells(4).Value
    End Sub
    Sub Pregunta9J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(8).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(8).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(8).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(8).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(8).Cells(4).Value
    End Sub
    Sub Pregunta10J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(9).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(9).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(9).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(9).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(9).Cells(4).Value
    End Sub
    Sub Pregunta11J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(10).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(10).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(10).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(10).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(10).Cells(4).Value
    End Sub
    Sub Pregunta12J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(11).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(11).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(11).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(11).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(11).Cells(4).Value
    End Sub
    Sub Pregunta13J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(12).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(12).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(12).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(12).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(12).Cells(4).Value
    End Sub
    Sub Pregunta14J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(13).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(13).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(13).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(13).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(13).Cells(4).Value
    End Sub
    Sub Pregunta15J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(14).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(14).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(14).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(14).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(14).Cells(4).Value
    End Sub
    Sub Pregunta16J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(15).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(15).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(15).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(15).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(15).Cells(4).Value
    End Sub
    Sub Pregunta17J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(16).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(16).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(16).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(16).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(16).Cells(4).Value
    End Sub
    Sub Pregunta18J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(17).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(17).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(17).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(17).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(17).Cells(4).Value
    End Sub
    Sub Pregunta19J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(18).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(18).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(18).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(18).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(18).Cells(4).Value
    End Sub
    Sub Pregunta20J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(19).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(19).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(19).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(19).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(19).Cells(4).Value
    End Sub
    Sub Pregunta21J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(20).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(20).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(20).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(20).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(20).Cells(4).Value
    End Sub
    Sub Pregunta22J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(21).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(21).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(21).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(21).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(21).Cells(4).Value
    End Sub
    Sub Pregunta23J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(22).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(22).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(22).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(22).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(22).Cells(4).Value
    End Sub
    Sub Pregunta24J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(23).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(23).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(23).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(23).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(23).Cells(4).Value
    End Sub
    Sub Pregunta25J2()
        lblPregunta.Text = frmpregJ2.dgvLector2.Rows(24).Cells(0).Value
        btnresp1.Text = frmpregJ2.dgvLector2.Rows(24).Cells(1).Value
        btnresp2.Text = frmpregJ2.dgvLector2.Rows(24).Cells(2).Value
        btnresp3.Text = frmpregJ2.dgvLector2.Rows(24).Cells(3).Value
        btnresp4.Text = frmpregJ2.dgvLector2.Rows(24).Cells(4).Value
    End Sub





    Sub SigPreg1J2()
        If obj.VectorLleno2(0) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(0) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(0) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(0) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(0) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(0) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(0) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(0) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(0) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(0) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(0) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(0) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(0) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(0) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(0) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(0) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(0) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(0) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(0) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(0) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(0) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(0) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(0) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(0) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(0) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg2J2()
        If obj.VectorLleno2(1) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(1) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(1) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(1) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(1) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(1) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(1) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(1) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(1) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(1) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(1) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(1) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(1) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(1) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(1) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(1) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(1) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(1) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(1) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(1) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(1) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(1) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(1) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(1) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(1) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg3J2()
        If obj.VectorLleno2(2) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(2) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(2) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(2) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(2) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(2) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(2) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(2) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(2) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(2) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(2) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(2) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(2) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(2) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(2) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(2) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(2) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(2) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(2) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(2) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(2) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(2) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(2) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(2) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(2) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg4J2()
        If obj.VectorLleno2(3) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(3) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(3) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(3) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(3) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(3) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(3) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(3) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(3) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(3) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(3) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(3) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(3) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(3) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(3) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(3) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(3) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(3) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(3) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(3) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(3) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(3) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(3) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(3) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(3) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg5J2()
        If obj.VectorLleno2(4) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(4) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(4) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(4) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(4) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(4) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(4) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(4) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(4) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(4) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(4) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(4) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(4) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(4) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(4) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(4) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(4) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(4) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(4) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(4) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(4) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(4) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(4) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(4) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(4) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg6J2()
        If obj.VectorLleno2(5) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(5) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(5) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(5) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(5) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(5) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(5) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(5) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(5) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(5) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(5) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(5) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(5) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(5) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(5) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(5) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(5) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(5) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(5) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(5) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(5) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(5) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(5) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(5) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(5) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg7J2()
        If obj.VectorLleno2(6) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(6) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(6) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(6) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(6) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(6) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(6) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(6) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(6) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(6) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(6) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(6) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(6) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(6) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(6) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(6) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(6) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(6) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(6) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(6) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(6) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(6) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(6) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(6) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(6) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg8J2()
        If obj.VectorLleno2(7) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(7) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(7) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(7) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(7) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(7) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(7) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(7) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(7) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(7) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(7) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(7) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(7) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(7) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(7) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(7) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(7) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(7) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(7) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(7) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(7) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(7) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(7) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(7) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(7) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg9J2()
        If obj.VectorLleno2(8) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(8) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(8) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(8) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(8) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(8) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(8) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(8) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(8) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(8) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(8) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(8) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(8) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(8) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(8) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(8) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(8) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(8) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(8) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(8) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(8) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(8) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(8) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(8) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(8) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg10J2()
        If obj.VectorLleno2(9) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(9) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(9) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(9) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(9) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(9) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(9) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(9) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(9) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(9) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(9) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(9) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(9) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(9) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(9) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(9) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(9) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(9) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(9) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(9) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(9) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(9) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(9) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(9) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(9) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg11J2()
        If obj.VectorLleno2(10) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(10) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(10) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(10) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(10) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(10) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(10) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(10) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(10) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(10) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(10) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(10) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(10) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(10) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(10) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(10) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(10) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(10) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(10) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(10) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(10) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(10) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(10) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(10) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(10) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg12J2()
        If obj.VectorLleno2(11) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(11) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(11) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(11) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(11) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(11) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(11) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(11) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(11) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(11) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(11) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(11) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(11) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(11) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(11) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(11) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(11) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(11) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(11) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(11) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(11) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(11) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(11) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(11) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(11) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg13J2()
        If obj.VectorLleno2(12) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(12) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(12) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(12) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(12) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(12) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(12) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(12) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(12) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(12) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(12) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(12) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(12) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(12) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(12) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(12) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(12) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(12) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(12) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(12) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(12) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(12) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(12) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(12) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(12) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg14J2()
        If obj.VectorLleno2(13) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(13) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(13) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(13) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(13) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(13) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(13) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(13) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(13) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(13) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(13) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(13) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(13) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(13) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(13) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(13) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(13) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(13) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(13) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(13) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(13) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(13) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(13) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(13) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(13) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg15J2()
        If obj.VectorLleno2(14) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(14) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(14) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(14) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(14) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(14) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(14) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(14) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(14) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(14) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(14) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(14) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(14) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(14) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(14) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(14) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(14) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(14) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(14) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(14) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(14) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(14) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(14) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(14) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(14) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg16J2()
        If obj.VectorLleno2(15) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(15) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(15) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(15) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(15) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(15) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(15) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(15) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(15) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(15) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(15) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(15) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(15) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(15) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(15) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(15) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(15) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(15) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(15) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(15) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(15) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(15) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(15) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(15) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(15) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg17J2()
        If obj.VectorLleno2(16) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(16) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(16) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(16) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(16) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(16) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(16) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(16) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(16) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(16) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(16) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(16) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(16) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(16) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(16) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(16) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(16) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(16) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(16) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(16) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(16) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(16) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(16) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(16) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(16) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg18J2()
        If obj.VectorLleno2(17) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(17) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(17) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(17) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(17) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(17) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(17) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(17) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(17) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(17) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(17) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(17) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(17) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(17) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(17) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(17) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(17) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(17) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(17) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(17) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(17) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(17) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(17) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(17) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(17) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg19J2()
        If obj.VectorLleno2(18) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(18) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(18) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(18) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(18) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(18) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(18) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(18) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(18) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(18) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(18) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(18) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(18) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(18) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(18) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(18) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(18) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(18) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(18) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(18) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(18) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(18) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(18) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(18) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(18) = 25 Then
            Pregunta25J2()
        End If
    End Sub

    Sub SigPreg20J2()
        If obj.VectorLleno2(19) = 1 Then
            Pregunta1J2()
        ElseIf obj.VectorLleno2(19) = 2 Then
            Pregunta2J2()
        ElseIf obj.VectorLleno2(19) = 3 Then
            Pregunta3J2()
        ElseIf obj.VectorLleno2(19) = 4 Then
            Pregunta4J2()
        ElseIf obj.VectorLleno2(19) = 5 Then
            Pregunta5J2()
        ElseIf obj.VectorLleno2(19) = 6 Then
            Pregunta6J2()
        ElseIf obj.VectorLleno2(19) = 7 Then
            Pregunta7J2()
        ElseIf obj.VectorLleno2(19) = 8 Then
            Pregunta8J2()
        ElseIf obj.VectorLleno2(19) = 9 Then
            Pregunta9J2()
        ElseIf obj.VectorLleno2(19) = 10 Then
            Pregunta10J2()
        ElseIf obj.VectorLleno2(19) = 11 Then
            Pregunta11J2()
        ElseIf obj.VectorLleno2(19) = 12 Then
            Pregunta12J2()
        ElseIf obj.VectorLleno2(19) = 13 Then
            Pregunta13J2()
        ElseIf obj.VectorLleno2(19) = 14 Then
            Pregunta14J2()
        ElseIf obj.VectorLleno2(19) = 15 Then
            Pregunta15J2()
        ElseIf obj.VectorLleno2(19) = 16 Then
            Pregunta16J2()
        ElseIf obj.VectorLleno2(19) = 17 Then
            Pregunta17J2()
        ElseIf obj.VectorLleno2(19) = 18 Then
            Pregunta18J2()
        ElseIf obj.VectorLleno2(19) = 19 Then
            Pregunta19J2()
        ElseIf obj.VectorLleno2(19) = 20 Then
            Pregunta20J2()
        ElseIf obj.VectorLleno2(19) = 21 Then
            Pregunta21J2()
        ElseIf obj.VectorLleno2(19) = 22 Then
            Pregunta22J2()
        ElseIf obj.VectorLleno2(19) = 23 Then
            Pregunta23J2()
        ElseIf obj.VectorLleno2(19) = 24 Then
            Pregunta24J2()
        ElseIf obj.VectorLleno2(19) = 25 Then
            Pregunta25J2()
        End If
    End Sub


    Sub AvancePuntuacion()

        If lblOculSiguien.Text = "2" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2

        ElseIf lblOculSiguien.Text = "3" Then


            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "4" Then


            lblTurno.Text = "Turno J2: " + obj.nomJ2

        ElseIf lblOculSiguien.Text = "5" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "6" Then


            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "7" Then


            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "8" Then


            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "9" Then


            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "10" Then


            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "11" Then


            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "12" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "13" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "14" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "15" Then


            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "16" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "17" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "18" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "19" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "20" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "21" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "22" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "23" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "24" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "25" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "26" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "27" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "28" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "29" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "30" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "31" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "32" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "33" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "34" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "35" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "36" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "37" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "38" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "39" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "40" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf lblOculSiguien.Text = "41" Then

            lblTurno.Text = "Turno J1: " + obj.nomJ1
        ElseIf lblOculSiguien.Text = "42" Then

            lblTurno.Text = "Turno J2: " + obj.nomJ2
        End If
    End Sub



    Sub Sigpreg2Jug()
        If obj.numSig = 2 Then
            SigPreg1J2()
            lblTurno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 3 Then
            SigPreg2()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 4 Then
            SigPreg2J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 5 Then
            sigPreg3()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 6 Then
            SigPreg3J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 7 Then
            sigPreg4()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 8 Then
            SigPreg4J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 9 Then
            sigPreg5()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 10 Then
            SigPreg5J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 11 Then
            sigPreg6()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 12 Then
            SigPreg6J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 13 Then
            sigPreg7()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 14 Then
            SigPreg7J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 15 Then
            sigPreg8()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 16 Then
            SigPreg8J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 17 Then
            sigPreg9()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 18 Then
            SigPreg9J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 19 Then
            sigPreg10()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 20 Then
            SigPreg10J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 21 Then
            sigPreg11()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 22 Then
            SigPreg11J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 23 Then
            sigPreg11()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 24 Then
            SigPreg11J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 25 Then
            sigPreg12()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 26 Then
            SigPreg12J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 27 Then
            sigPreg13()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 28 Then
            SigPreg13J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 29 Then
            sigPreg14()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 30 Then
            SigPreg14J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 31 Then
            sigPreg15()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 32 Then
            SigPreg15J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 33 Then
            sigPreg16()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 34 Then
            SigPreg16J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 35 Then
            sigPreg17()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 36 Then
            SigPreg17J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 37 Then
            sigPreg18()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 38 Then
            SigPreg18J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 39 Then
            sigPreg19()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 40 Then
            SigPreg19J2()
            lblturno.Text = "Turno J2: " + obj.nomJ2
        ElseIf obj.numSig = 41 Then
            sigPreg20()
            lblturno.Text = "Turno J1: " + obj.nomJ1
        ElseIf obj.numSig = 42 Then
            SigPreg20J2()
            lblTurno.Text = "Turno J2: " + obj.nomJ2
            frmJuego.cronometro.Stop()
            ganador()
        End If
    End Sub
    '******************************************************
    'metodo para el ganador del jugador 
    Sub ganador()
        If obj.puntos > obj.puntuacion2 Then
            MsgBox("ganador" + obj.nomJ1 + "" + Str(obj.puntos))
        ElseIf obj.puntuacion2 > obj.puntos Then
            MsgBox("ganador" + obj.nomJ2 + "" + Str(obj.puntuacion2))
        End If
    End Sub
#End Region
    '*************************************************************************************************************************************
    Private Sub TSMIcincuenta_Click(sender As Object, e As EventArgs) Handles TSMIcincuenta.Click
        'si turno es jugador 1 
        If lblturno.Text.Contains("J1:") And frmJuego.lblunjug.Text = "1" Then
            obj.cincuentacincuent = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()

            obj.unavezcinc2 = 1
            obj.unavezcinc = 1

            'si turno es jugador 2
        ElseIf lblturno.Text.Contains("J2:") Then
            obj.cincuentacincuent = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()

            obj.unavezcinc = 1

            'si turno es jugador 1 
        ElseIf lblturno.Text.Contains("J1:") Then
            obj.cincuentacincuent = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()

            obj.unavezcinc2 = 1
        End If
    End Sub
    '*****************************************************************************************************************************************
    Private Sub LlamadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlamadaToolStripMenuItem.Click

        'si turno es jugador 1 entonces 
        If lblturno.Text.Contains("J1:") And frmJuego.lblunjug.Text = "1" Then
            obj.llamadabln = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()
            '-----------------------------------

            obj.unavezllamda2 = 1
            obj.unavezllamda = 1

            'si turno es jugador 1 entonces 
        ElseIf lblturno.Text.Contains("J1:") Then
            obj.llamadabln = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()
            '----------------------------
            obj.unavezllamda2 = 1

            'si turno es jugador 2 entonces 
        ElseIf lblturno.Text.Contains("J2:") Then
            obj.llamadabln = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()
            '----------------------
            obj.unavezllamda = 1
        End If
    End Sub

    Private Sub RespuestaDelPúblicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespuestaDelPúblicoToolStripMenuItem.Click

        'si turno es jugador 1 entonces 
        If lblturno.Text.Contains("J1:") And frmJuego.lblunjug.Text = "1" Then
            obj.PublicAnswbln = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()
            '----------------------
            obj.unavezrespPubl = 1
            obj.unavezrespPubl2 = 1

            'si turno es jugador 1 entonces 
        ElseIf lblturno.Text.Contains("J1:") Then
            obj.PublicAnswbln = True
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()

            obj.unavezrespPubl2 = 1

            'si turno es jugador 1 entonces 
        ElseIf lblturno.Text.Contains("J2:") Then
            obj.PublicAnswbln = True

            'categorias 
            respuestasCultura()
            respuestasDeportes()
            respuestasSalud()
            respuestasPolitica()
            respuestasFinanzas()
            respuestasHistoria()
            respuestasCiencia()
            respuestasTecnologia()
            respuestasAstronomia()
            respuestasMusica()
            '------------------
            obj.unavezrespPubl = 1
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'inicializacion 
        obj.unavezcinc = 0
        obj.unavezcinc2 = 0
        obj.unavezllamda = 0
        obj.unavezllamda2 = 0
        obj.unavezrespPubl = 0
        obj.unavezrespPubl2 = 0

        'metodos 
        unavezcada1cinc1()
        unavezcada1cinc2()
        unavezcada1llamada()
        unavezcada1llamada2()

        'se muestra la pregunta y las opciones 
        lblPregunta.Visible = True
        btnresp1.Visible = True
        btnresp2.Visible = True
        btnresp3.Visible = True
        btnresp4.Visible = True
        lblPunt.Visible = True

        'metodos de numeros diferentes 
        obj.NumerosDiferentes()
        obj.NumerosDiferentes2()
        obj.numSig = 1

        'segun el vector lleno 
        'se da cada pregunta 
        If obj.VectorLleno(0) = 1 Then
            Pregunta1()
        ElseIf obj.VectorLleno(0) = 2 Then
            Pregunta2()
        ElseIf obj.VectorLleno(0) = 3 Then
            Pregunta3()
        ElseIf obj.VectorLleno(0) = 4 Then
            Pregunta4()
        ElseIf obj.VectorLleno(0) = 5 Then
            Pregunta5()
        ElseIf obj.VectorLleno(0) = 6 Then
            Pregunta6()
        ElseIf obj.VectorLleno(0) = 7 Then
            Pregunta7()
        ElseIf obj.VectorLleno(0) = 8 Then
            Pregunta8()
        ElseIf obj.VectorLleno(0) = 9 Then
            Pregunta9()
        ElseIf obj.VectorLleno(0) = 10 Then
            Pregunta10()
        ElseIf obj.VectorLleno(0) = 11 Then
            Pregunta11()
        ElseIf obj.VectorLleno(0) = 12 Then
            Pregunta12()
        ElseIf obj.VectorLleno(0) = 13 Then
            Pregunta13()
        ElseIf obj.VectorLleno(0) = 14 Then
            Pregunta14()
        ElseIf obj.VectorLleno(0) = 15 Then
            Pregunta15()
        ElseIf obj.VectorLleno(0) = 16 Then
            Pregunta16()
        ElseIf obj.VectorLleno(0) = 17 Then
            Pregunta17()
        ElseIf obj.VectorLleno(0) = 18 Then
            Pregunta18()
        ElseIf obj.VectorLleno(0) = 19 Then
            Pregunta19()
        ElseIf obj.VectorLleno(0) = 20 Then
            Pregunta20()
        ElseIf obj.VectorLleno(0) = 21 Then
            Pregunta21()
        ElseIf obj.VectorLleno(0) = 22 Then
            Pregunta22()
        ElseIf obj.VectorLleno(0) = 23 Then
            Pregunta23()
        ElseIf obj.VectorLleno(0) = 24 Then
            Pregunta24()
        ElseIf obj.VectorLleno(0) = 25 Then
            Pregunta25()
        End If
    End Sub

    Private Sub PausaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PausaToolStripMenuItem.Click
        frmJuego.cronometro.Stop()
        TimerPregunt.Stop()

        btnresp1.Enabled = False
        btnresp2.Enabled = False
        btnresp3.Enabled = False
        btnresp4.Enabled = False



        LlamadaToolStripMenuItem.Enabled = False
        TSMIcincuenta.Enabled = False
        RespuestaDelPúblicoToolStripMenuItem.Enabled = False

        If MsgBox("¿Desea continuar?", vbYesNo + vbQuestion, "Salir del programa") = vbYes Then

            frmJuego.cronometro.Start()
            TimerPregunt.Start()
            btnresp1.Enabled = True
            btnresp2.Enabled = True
            btnresp3.Enabled = True
            btnresp4.Enabled = True



            LlamadaToolStripMenuItem.Enabled = True
            TSMIcincuenta.Enabled = True
            RespuestaDelPúblicoToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerPregunt.Tick
        lblSeg.Text -= 1
        If frmJuego.lblunjug.Text = "1" Then
            While lblSeg.Text = "0"
                TimerPregunt.Stop()
                MsgBox("Tiempo de repuesta acabado", MsgBoxStyle.Exclamation)
                obj.avancedepreg()
                Sigpreg()
                lblSeg.Text = "25"
                TimerPregunt.Start()
            End While

        ElseIf frmJuego.lblunjug.Text = "1" And frmJuego.lbldosjug.Text = "1" Then
            While lblSeg.Text = "0"
                TimerPregunt.Stop()
                MsgBox("Tiempo de repuesta acabado", MsgBoxStyle.Exclamation)
                obj.avancedepreg()
                Sigpreg2Jug()
                lblSeg.Text = "25"
                TimerPregunt.Start()
            End While
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class