'libreria para archivos 
Imports System.IO

Public Class Archivos

#Region "variables del juego "
    'variables para el juego
    'preguntas y respuesta 
    Dim _Pregunta As String
    Dim _Respuesta1 As String
    Dim _Respuesta2 As String
    Dim _Respuesta3 As String
    Dim _Respuesta4 As String
    Dim _Respuestadada As String
    Dim _RespuestaCorrecta As String
    'repuesta que gana mas puntaje 
    Dim respK As String = "Kratos"
    '----------------------------------------------
    'numero aleatorio  para sacar la pregunta 
    Dim _numAleat As Integer
    '--------------------------------------------------
    'puntaje para el juego 
    Dim PuntValor As Integer
    Dim punt As Integer = 1
    Dim punt2 As Integer = 1
    Dim ejecSum As String
    Dim ejecRest As String
    Dim indx As Integer
    '-----------------------------------------------
    'seleccion de la categoria 
    Dim strSelectCategoria As String
    Dim strSelectCategoria2 As String
    Public VectorLleno(19) As Integer
    Public VectorLleno2(19) As Integer
    '-------------------------------------------------
    'nombre de los jugadores 
    Dim _nomJ1 As String
    Dim _nomJ2 As String

#End Region

#Region "variables de archivo"
    'variables para los archivos 
    'nombre del archivo que genera los jugadores con las preguntas 
    Dim fName As String = ""
    Dim fName2 As String = ""
    '---------------------------------------------------------
    'linea de texto 
    Dim TextLine As String = ""
    Dim TextLine2 As String = ""
    '-------------------------------------------------------
    Dim _splitline As String()
    Dim _splitline2 As String()
    Public objReader As StreamReader
    Public objReader2 As StreamReader
    Dim aleatGener As Integer
    'variable del archivo existente 
    Dim _archivoexiste As Boolean
    Dim _archivoexiste2 As Boolean
#End Region
    '--------------------------------------------------------------

#Region "variables de comodin"
    'variables para los comodines 
    'variable del 50/50
    Dim _cincuentcinc As Boolean
    '50/50 para jugador 1
    Dim _unavezcinc1 As Integer
    '50/50 para jugador 2
    Dim _unavezcinc2 As Integer
    Dim _llamadabln As Boolean
    Dim _publicAnswbln As Boolean
    '-----------------------------------------
    'variable de la llamada 

    Dim _llamd As Integer
    Dim _respIncorr As String
    Dim _unavezllmda As Integer
    Dim _unavezllmda2 As Integer
    '-----------------------------------------------
    'porcentage segun la opcion del publico 
    Dim _numsig As Integer
    Dim _porc1publ As Integer
    Dim _porc2publ As Integer
    Dim _porc3publ As Integer
    Dim _porc4publ As Integer
    '-----------------------------------------
    'opcion del publico
    Dim _opcion1publ As String
    Dim _opcion2publ As String
    Dim _opcion3publ As String
    Dim _opcion4publ As String
    '----------------------------------------
    Dim _unavezrespPubl As Integer
    Dim _unavezrespPubl2 As Integer
    Dim _varpub As Integer
    Dim _jugador1 As Integer = 0
    Dim _jugador2 As Integer = 0
#End Region


#Region "propiedades del juego "
    'property de seleccion de categoria 
    Public Property selectCategoria As String
        Get
            'devuelve valor 
            Return strSelectCategoria
        End Get
        Set(value As String)
            'se le da un valor 
            strSelectCategoria = value
        End Set
    End Property
    '--------------------------------------------
    'property de respuesta incorrecta 
    Public Property RespuestaIncorr As String
        Get
            'se le devuelve 
            Return _respIncorr
        End Get
        Set(value As String)
            'se le da un valor 
            _respIncorr = value
        End Set
    End Property
    '-----------------------------------------------
    'property del  nombre  jugador 1
    Public Property nomJ1 As String
        Get
            'devuelve un nombre 
            Return _nomJ1
        End Get
        Set(value As String)
            'nombre se le da valor 
            _nomJ1 = value
        End Set
    End Property
    '---------------------------------------------------------------
    'property del nombre jugador 2
    Public Property nomJ2 As String
        Get
            'devolver un nombre 
            Return _nomJ2
        End Get
        Set(value As String)
            'se le da un valor 
            _nomJ2 = value
        End Set
    End Property
    '---------------------------------------------------------------
    'property de seleccion de categoria 
    Public Property selectCategoria2 As String
        Get
            'se le devuelve un valor 
            Return strSelectCategoria2
        End Get
        Set(value As String)
            'se le da un valor 
            strSelectCategoria2 = value
        End Set
    End Property
    '-----------------------------------------------------------
    'property de jugador 1
    Public Property unjugador() As Integer
        Get
            'devuelve un valor 
            Return _jugador1
        End Get
        Set(value As Integer)
            'se le da un valor 
            _jugador1 = value
        End Set
    End Property
    '-----------------------------------------------------------
    'property de jugador 2
    Public Property dosjugadores() As Integer
        Get
            'se le devuelve un valor 
            Return _jugador2
        End Get
        Set(value As Integer)
            'se le da un valor 
            _jugador2 = value
        End Set
    End Property
    '------------------------------------------------------
    'property de respuesta de kratos 
    Public Property respuestaK As String
        Get
            'se devuelve un valor 
            Return respK
        End Get
        Set(value As String)
            'se le sa un valor 
            respK = value
        End Set
    End Property
    '------------------------------------------------------------
    'property de pregunta 
    Public Property Pregunta() As String
        Get
            'se le devuelve un valor 
            Return _Pregunta
        End Get
        Set(value As String)
            'se le da un valor 
            _Pregunta = value
        End Set
    End Property
    '-----------------------------------------------------------
    'property de respuesta  1
    Public Property Respuesta1() As String
        Get
            'se de le devuelve un valor 
            Return _Respuesta1
        End Get
        Set(value As String)
            'se le da un valor 
            _Respuesta1 = value
        End Set
    End Property
    '----------------------------------------------------------
    'property respuesta 2 
    Public Property Respuesta2() As String
        Get
            'se le devuelve un valor 
            Return _Respuesta2
        End Get
        Set(value As String)
            'se le da un valor 
            _Respuesta2 = value
        End Set
    End Property
    '--------------------------------------------------------
    'property de respuesta 3
    Public Property Respuesta3() As String
        Get
            'se le devuelve un valor 
            Return _Respuesta3
        End Get
        Set(value As String)
            'se le da un valor 
            _Respuesta3 = value
        End Set
    End Property
    '-------------------------------------------------------
    'property de respuesta 4
    Public Property Respuesta4() As String
        Get
            'se le devuelve un valor 
            Return _Respuesta4
        End Get
        Set(value As String)
            'se le da un valor 
            _Respuesta4 = value
        End Set
    End Property
    '-------------------------------------------------------------
    'property de la respuesta correcta 
    Public Property RespuestaCorrecta() As String
        Get
            'se le devuelve un valor 
            Return _RespuestaCorrecta
        End Get
        Set(value As String)
            'se le da un valor 
            _RespuestaCorrecta = value
        End Set
    End Property
    '------------------------------------------------------------
    'property de respuesat dada 
    Public Property RespuestaDada() As String
        Get
            'se le devuelve un valor 
            Return _Respuestadada
        End Get
        Set(value As String)
            'se le da un valor 
            _Respuestadada = value
        End Set
    End Property
    '------------------------------------------------------------
    'property de numero aleatorio 
    Public Property numaleatorio() As Integer
        Get
            'se le devuelve un valor 
            Return _numAleat
        End Get
        Set(value As Integer)
            'se le da un valor 
            _numAleat = value
        End Set
    End Property
    '------------------------------------------------------
    'property de puntos 
    Public Property puntos() As Integer
        Get
            'se le devuelve un valor 
            Return punt
        End Get
        Set(value As Integer)
            'se le da un valor 
            punt = value
        End Set
    End Property
    '-----------------------------------------------------
    'property de valor de puntos 
    Public Property puntoValor() As Integer
        Get
            'se le devuelve un valor 
            Return PuntValor
        End Get
        Set(value As Integer)
            'se le da un valor 
            PuntValor = value
        End Set
    End Property
    '--------------------------------------------------------
    'property de validacion de index 
    Public Property valindx() As Integer
        Get
            ' se le devuelve un valor 
            Return indx
        End Get
        Set(value As Integer)
            'se le da un valor 
            indx = value
        End Set
    End Property
    '-----------------------------------------------------------
    Public Property _VectorLleno() As Integer
        Get
            Return VectorLleno(19)
        End Get
        Set(value As Integer)
            VectorLleno(19) = value
        End Set
    End Property

    Public Property _VectorLleno2() As Integer
        Get
            Return VectorLleno2(19)
        End Get
        Set(value As Integer)
            VectorLleno2(19) = value
        End Set
    End Property


#End Region

    '********************************************************************************************************
#Region "Propiedades de los archivos "

    '---------------------------------------------------------
    'property de archivo existe 
    Public Property archivoexiste As Boolean
        Get
            'se le devuelve un valor 
            Return _archivoexiste
        End Get
        Set(value As Boolean)
            'se le da valor 
            _archivoexiste = value
        End Set
    End Property
    '-----------------------------------------------------
    'property de archivo existe #2
    Public Property archivoexiste2 As Boolean
        Get
            'se le devuelve un valor 
            Return _archivoexiste2
        End Get
        Set(value As Boolean)
            ' se le da un valor 
            _archivoexiste2 = value
        End Set
    End Property
    '-----------------------------------------------------------
    'property de split linea 
    Public Property splitlinea As String()
        Get
            'se le devuelve un valor 
            Return _splitline
        End Get
        Set(value As String())
            'se le da un valor 
            _splitline = value
        End Set
    End Property
    '----------------------------------------------------------------------
    'property de split linea #2
    Public Property splitlinea2 As String()
        Get
            'se le devuelve un valor 
            Return _splitline2
        End Get
        Set(value As String())
            'se le da un valor 
            _splitline2 = value
        End Set
    End Property
    '-------------------------------------------------------------------
    'property de nombre del archivp
    Public Property filename() As String
        Get
            'se le devuelve un valor 
            Return fName
        End Get
        Set(value As String)
            'se le da un valor 
            fName = value
        End Set
    End Property
    '-----------------------------------------------------------------
    'property del nombre del archivo #2
    Public Property filename2() As String
        Get
            'se le devuelve un valor 
            Return fName2
        End Get
        Set(value As String)
            ' se le da un valor 
            fName2 = value
        End Set
    End Property
    '-----------------------------------------------------
    'property de linea de texto 
    Public Property LineaTexto() As String
        Get
            'se le devuelve un valor 
            Return TextLine
        End Get
        Set(value As String)
            'se le da un valor 
            TextLine = value
        End Set
    End Property
    '-------------------------------------------------------
    'property de linea de texto #2
    Public Property LineaTexto2() As String
        Get
            'se le devuelve un valor 
            Return TextLine2
        End Get
        Set(value As String)
            'se le da un valor 
            TextLine2 = value
        End Set
    End Property
#End Region
    '**************************************************************************************************
#Region "properties de los comodines "
    'properyu de opcion del publico 1
    Public Property opcionPublico1 As String
        Get
            'se le devuelve un valor 
            Return _opcion1publ
        End Get
        Set(value As String)
            'se le da un valor 
            _opcion1publ = value
        End Set
    End Property
    '--------------------------------------------------------------
    'property deopcion del publico 2
    Public Property opcionPublico2 As String
        Get
            'se le devuelve un valor 
            Return _opcion2publ
        End Get
        Set(value As String)
            'se le da un valor 
            _opcion2publ = value
        End Set
    End Property
    '-------------------------------------------------------------
    'property de opcion 3
    Public Property opcionPublico3 As String
        Get
            'se le devuelve un valor 
            Return _opcion3publ
        End Get
        Set(value As String)
            'se le da un valor 
            _opcion3publ = value
        End Set
    End Property
    '----------------------------------------------------------------
    'property de opcion del publico 4
    Public Property opcionPublico4 As String
        Get
            'se le devuelve un valor 
            Return _opcion4publ
        End Get
        Set(value As String)
            'se le da un valor 
            _opcion4publ = value
        End Set
    End Property
    '-------------------------------------------------------------------
    'property de cincuenta /50
    Public Property cincuentacincuent As Boolean
        Get
            'se le devuelve un valor 
            Return _cincuentcinc
        End Get
        Set(value As Boolean)
            'se le da un valor 
            _cincuentcinc = value
        End Set
    End Property
    '-------------------------------------------------------------------
    'property de llaamda bln 
    Public Property llamadabln As Boolean
        Get
            'se le devuelve un valor 
            Return _llamadabln
        End Get
        Set(value As Boolean)
            'se le da un valor 
            _llamadabln = value
        End Set
    End Property
    '------------------------------------------------------------------------
    'property de la respuesta del publico 
    Public Property PublicAnswbln As Boolean
        Get
            'se le devuelve un valor 
            Return _publicAnswbln
        End Get
        Set(value As Boolean)
            'se le da un valor 
            _publicAnswbln = value
        End Set
    End Property
    '----------------------------------------------------------------
    'property de una vez cincuneta 
    Public Property unavezcinc() As Integer
        Get
            'se le devuelve un valor 
            Return _unavezcinc1
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezcinc1 = value
        End Set
    End Property
    '----------------------------------------------------------------
    'property se le una vez llamda 
    Public Property unavezllamda() As Integer
        Get
            'se le devuelve un valor 
            Return _unavezllmda
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezllmda = value
        End Set
    End Property
    '------------------------------------------------------------------
    'property de nu8mero siguiente 
    Public Property numSig() As Integer
        Get
            'se le devuelve un valor 
            Return _numsig
        End Get
        Set(value As Integer)
            'se le da un valor 
            _numsig = value
        End Set
    End Property
    '-------------------------------------------------------------------
    'property de la variacion del publico 
    Public Property variarpubl() As Integer
        Get
            'se le devuelve un  valor 
            Return _varpub
        End Get
        Set(value As Integer)
            'se le da un valor  
            _varpub = value
        End Set
    End Property
    '-------------------------------------------------------------
    'property de una vez llamada #2
    Public Property unavezllamda2() As Integer
        Get
            'se le devuelve un valor 
            Return _unavezllmda2
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezllmda2 = value
        End Set
    End Property
    '-----------------------------------------------------
    'property de llamada 
    Public Property llamd() As Integer
        Get
            'se le devuelve una llamada 
            Return _llamd
        End Get
        Set(value As Integer)
            'se le da un valor 
            _llamd = value
        End Set
    End Property
    '-------------------------------------------------------
    'property una vez cincuenta #2
    Public Property unavezcinc2() As Integer
        Get
            'se le devuelve  un valor 
            Return _unavezcinc2
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezcinc2 = value
        End Set
    End Property
    '--------------------------------------------------------------------------
    'property del publico 1
    Public Property porcentajePubl1() As Integer
        Get
            'se le devuelve un valor 
            Return _porc1publ
        End Get
        Set(value As Integer)
            'se le da un valor 
            _porc1publ = value
        End Set
    End Property
    '--------------------------------------------------
    'property del publico 
    Public Property porcentajePubl2() As Integer
        Get
            'se le devuelve un valor 
            Return _porc2publ
        End Get
        Set(value As Integer)
            'se le da un valor 
            _porc2publ = value
        End Set
    End Property
    '-----------------------------------------------------------
    'property de publico 3
    Public Property porcentajePubl3() As Integer
        Get
            'se le devuelve un valor 
            Return _porc3publ
        End Get
        Set(value As Integer)
            'se le da un valor 
            _porc3publ = value
        End Set
    End Property
    '---------------------------------------------------------
    'property del publico4
    Public Property porcentajePubl4() As Integer
        Get
            'se le devuelve un valor 
            Return _porc4publ
        End Get
        Set(value As Integer)
            _porc4publ = value
        End Set
    End Property
    '----------------------------------------------------
    'property de puntuacion #2
    Public Property puntuacion2() As Integer
        Get
            'se le devuelve un valor 
            Return punt2
        End Get
        Set(value As Integer)
            'se le da un valor 
            punt2 = value
        End Set
    End Property
    '-------------------------------------------------
    'property de una vez de respuesta publico
    Public Property unavezrespPubl() As Integer
        Get
            'se le devuelve un valor 
            Return _unavezrespPubl
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezrespPubl = value
        End Set
    End Property
    '---------------------------------------------------------------
    'property de una vez respuesta del publico #2
    Public Property unavezrespPubl2() As Integer
        Get
            'se le devuelve un valor 
            Return _unavezrespPubl2
        End Get
        Set(value As Integer)
            'se le da un valor 
            _unavezrespPubl2 = value
        End Set
    End Property
    '---------------------------------------------------------------------
#End Region
    '**********************************************************************************
    '*********************************************************************
    '***********************************************
#Region "Metodos del juego"
    'metodo general donde se encuentra metodos donde se clasifica el juego, los archivos, comodines 
    '-------------------------------------------------------*---------------------------------------
#Region "juego"
    'metodo de aleatorio 
    Sub aleatorio()
        'aleatorio de 25 preguntas
        _numAleat = Math.Ceiling(Rnd() * 25)
    End Sub
    '----------------------------------------------------
    'validacion en caso de que no escoga categoria 
    Sub ValidarEnBlancoCat()
        'en caso de un error , de que no escoga una categoria 
        Throw New System.Exception("Debe de seleccionar al menos una categoría")
    End Sub
    '----------------------------------------------------------------
    'validacion para escoger canitdad de jugadores 
    Sub ValidarEnBlancoJug()
        'en caso de que no escoga ningun jugador 
        Throw New System.Exception("Debe de seleccionar al menos un jugador")
    End Sub
    '--------------------------------------------------------------------------
    'validacion para que los 2  jugadores no tengan la misma la categoria 
    Sub ValidarCategDuplic()
        'en caso de que los 2 jugadores sean iguales 
        Throw New System.Exception("Las categorias no pueden ser las mismas")
    End Sub
    '---------------------------------------------------------------------------
    'metodo para validar la respuesta 
    Sub validresp()
        'si la respuesta dada es correcta 
        If RespuestaDada = RespuestaCorrecta Then
            'se muestra un mensaje de correcta 
            MsgBox("Respuesta Correcta")
            'aumenta el puntaje 
            puntos = puntos + puntoValor

            'si la respuesta es kratos 
        ElseIf RespuestaDada = respK Then
            'es correcta 
            MsgBox("Respuesta Correcta")
            'te da un uamento de puntos 
            puntos = puntos + 5

            'en caso de que sea incorrecto
        Else
            'se muestra un mensaje de respuesta incorrecta 
            'se muestra la que era correcta 
            MsgBox("Respuesta Incorrecta, la respuesta es: " + RespuestaCorrecta)
        End If
    End Sub
    Sub validresp2()
        'si la respuesta dada es correcta 
        If RespuestaDada = RespuestaCorrecta Then
            'se muestra un mensaje de correcta 
            MsgBox("Respuesta Correcta")
            'aumenta el puntaje 
            puntuacion2 = puntuacion2 + puntoValor

            'si la respuesta es kratos 
        ElseIf RespuestaDada = respK Then
            'se muestra un mensaje de correcta 
            MsgBox("Respuesta Correcta")
            'te da un uamento de puntos 
            puntuacion2 = puntuacion2 + 5


            'en caso de que sea incorrecto
        Else
            'se muestra un mensaje de respuesta incorrecta 
            'se muestra la que era correcta 
            MsgBox("Respuesta Incorrecta, la respuesta es: " + RespuestaCorrecta)

        End If
    End Sub
    '----------------------------------------------------
    'metodo para avance de pregunta 
    Sub avancedepreg()
        'aumenta con la cantidad de preguntas 
        _numsig = _numsig + 1
    End Sub
    '-----------------------------------------------------------------
    'metodo de vector lleno 
    Sub VectLlen()
        'metodo del aleatorio 
        aleatorio()
        'vector lleno de cantidad 19 sea igual al numero aleatorio 
        VectorLleno(0) = numaleatorio
        aleatorio()
        VectorLleno(1) = numaleatorio
        aleatorio()
        VectorLleno(2) = numaleatorio
        aleatorio()
        VectorLleno(3) = numaleatorio
        aleatorio()
        VectorLleno(4) = numaleatorio
        aleatorio()
        VectorLleno(5) = numaleatorio
        aleatorio()
        VectorLleno(6) = numaleatorio
        aleatorio()
        VectorLleno(7) = numaleatorio
        aleatorio()
        VectorLleno(8) = numaleatorio
        aleatorio()
        VectorLleno(9) = numaleatorio
        aleatorio()
        VectorLleno(10) = numaleatorio
        aleatorio()
        VectorLleno(11) = numaleatorio
        aleatorio()
        VectorLleno(12) = numaleatorio
        aleatorio()
        VectorLleno(13) = numaleatorio
        aleatorio()
        VectorLleno(14) = numaleatorio
        aleatorio()
        VectorLleno(15) = numaleatorio
        aleatorio()
        VectorLleno(16) = numaleatorio
        aleatorio()
        VectorLleno(17) = numaleatorio
        aleatorio()
        VectorLleno(18) = numaleatorio
        aleatorio()
        VectorLleno(19) = numaleatorio
    End Sub
    '----------------------------------------------------------------------------------------
    'numeros diferentes 
    Sub NumerosDiferentes()
        'metodo del vector lleno 
        VectLlen()

        'mientras el vectolleno sea igual al de la cantidad de vectores 
        While VectorLleno(19) = VectorLleno(4) Or VectorLleno(19) = VectorLleno(3) Or VectorLleno(19) = VectorLleno(2) Or VectorLleno(19) = VectorLleno(1) Or VectorLleno(19) = VectorLleno(0) Or VectorLleno(19) = VectorLleno(5) Or VectorLleno(19) = VectorLleno(6) Or VectorLleno(19) = VectorLleno(7) Or VectorLleno(19) = VectorLleno(8) Or VectorLleno(19) = VectorLleno(9) Or VectorLleno(19) = VectorLleno(10) Or VectorLleno(19) = VectorLleno(11) Or VectorLleno(19) = VectorLleno(12) Or VectorLleno(19) = VectorLleno(13) Or VectorLleno(19) = VectorLleno(14) Or VectorLleno(19) = VectorLleno(15) Or VectorLleno(19) = VectorLleno(16) Or VectorLleno(19) = VectorLleno(17) Or VectorLleno(19) = VectorLleno(18) _
            Or VectorLleno(18) = VectorLleno(4) Or VectorLleno(18) = VectorLleno(3) Or VectorLleno(18) = VectorLleno(2) Or VectorLleno(18) = VectorLleno(1) Or VectorLleno(18) = VectorLleno(0) Or VectorLleno(18) = VectorLleno(5) Or VectorLleno(18) = VectorLleno(6) Or VectorLleno(18) = VectorLleno(7) Or VectorLleno(18) = VectorLleno(8) Or VectorLleno(18) = VectorLleno(9) Or VectorLleno(18) = VectorLleno(10) Or VectorLleno(18) = VectorLleno(11) Or VectorLleno(18) = VectorLleno(12) Or VectorLleno(18) = VectorLleno(13) Or VectorLleno(18) = VectorLleno(14) Or VectorLleno(18) = VectorLleno(15) Or VectorLleno(18) = VectorLleno(16) Or VectorLleno(18) = VectorLleno(17) _
            Or VectorLleno(17) = VectorLleno(4) Or VectorLleno(17) = VectorLleno(3) Or VectorLleno(17) = VectorLleno(2) Or VectorLleno(17) = VectorLleno(1) Or VectorLleno(17) = VectorLleno(0) Or VectorLleno(17) = VectorLleno(5) Or VectorLleno(17) = VectorLleno(6) Or VectorLleno(17) = VectorLleno(7) Or VectorLleno(17) = VectorLleno(8) Or VectorLleno(17) = VectorLleno(9) Or VectorLleno(17) = VectorLleno(10) Or VectorLleno(17) = VectorLleno(11) Or VectorLleno(17) = VectorLleno(12) Or VectorLleno(17) = VectorLleno(13) Or VectorLleno(17) = VectorLleno(14) Or VectorLleno(17) = VectorLleno(15) Or VectorLleno(17) = VectorLleno(16) _
            Or VectorLleno(16) = VectorLleno(4) Or VectorLleno(16) = VectorLleno(3) Or VectorLleno(16) = VectorLleno(2) Or VectorLleno(16) = VectorLleno(1) Or VectorLleno(16) = VectorLleno(0) Or VectorLleno(16) = VectorLleno(5) Or VectorLleno(16) = VectorLleno(6) Or VectorLleno(16) = VectorLleno(7) Or VectorLleno(16) = VectorLleno(8) Or VectorLleno(16) = VectorLleno(9) Or VectorLleno(16) = VectorLleno(10) Or VectorLleno(16) = VectorLleno(11) Or VectorLleno(16) = VectorLleno(12) Or VectorLleno(16) = VectorLleno(13) Or VectorLleno(16) = VectorLleno(14) Or VectorLleno(16) = VectorLleno(15) _
            Or VectorLleno(15) = VectorLleno(4) Or VectorLleno(15) = VectorLleno(3) Or VectorLleno(15) = VectorLleno(2) Or VectorLleno(15) = VectorLleno(1) Or VectorLleno(15) = VectorLleno(0) Or VectorLleno(15) = VectorLleno(5) Or VectorLleno(15) = VectorLleno(6) Or VectorLleno(15) = VectorLleno(7) Or VectorLleno(15) = VectorLleno(8) Or VectorLleno(15) = VectorLleno(9) Or VectorLleno(15) = VectorLleno(10) Or VectorLleno(15) = VectorLleno(11) Or VectorLleno(15) = VectorLleno(12) Or VectorLleno(15) = VectorLleno(13) Or VectorLleno(15) = VectorLleno(14) _
            Or VectorLleno(14) = VectorLleno(4) Or VectorLleno(14) = VectorLleno(3) Or VectorLleno(14) = VectorLleno(2) Or VectorLleno(14) = VectorLleno(1) Or VectorLleno(14) = VectorLleno(0) Or VectorLleno(14) = VectorLleno(5) Or VectorLleno(14) = VectorLleno(6) Or VectorLleno(14) = VectorLleno(7) Or VectorLleno(14) = VectorLleno(8) Or VectorLleno(14) = VectorLleno(9) Or VectorLleno(14) = VectorLleno(10) Or VectorLleno(14) = VectorLleno(11) Or VectorLleno(14) = VectorLleno(12) Or VectorLleno(14) = VectorLleno(13) _
            Or VectorLleno(13) = VectorLleno(4) Or VectorLleno(13) = VectorLleno(3) Or VectorLleno(13) = VectorLleno(2) Or VectorLleno(13) = VectorLleno(1) Or VectorLleno(13) = VectorLleno(0) Or VectorLleno(13) = VectorLleno(5) Or VectorLleno(13) = VectorLleno(6) Or VectorLleno(13) = VectorLleno(7) Or VectorLleno(13) = VectorLleno(8) Or VectorLleno(13) = VectorLleno(9) Or VectorLleno(13) = VectorLleno(10) Or VectorLleno(13) = VectorLleno(11) Or VectorLleno(13) = VectorLleno(12) _
            Or VectorLleno(12) = VectorLleno(4) Or VectorLleno(12) = VectorLleno(3) Or VectorLleno(12) = VectorLleno(2) Or VectorLleno(12) = VectorLleno(1) Or VectorLleno(12) = VectorLleno(0) Or VectorLleno(12) = VectorLleno(5) Or VectorLleno(12) = VectorLleno(6) Or VectorLleno(12) = VectorLleno(7) Or VectorLleno(12) = VectorLleno(8) Or VectorLleno(12) = VectorLleno(9) Or VectorLleno(12) = VectorLleno(10) Or VectorLleno(12) = VectorLleno(11) _
            Or VectorLleno(11) = VectorLleno(4) Or VectorLleno(11) = VectorLleno(3) Or VectorLleno(11) = VectorLleno(2) Or VectorLleno(11) = VectorLleno(1) Or VectorLleno(11) = VectorLleno(0) Or VectorLleno(11) = VectorLleno(5) Or VectorLleno(11) = VectorLleno(6) Or VectorLleno(11) = VectorLleno(7) Or VectorLleno(11) = VectorLleno(8) Or VectorLleno(11) = VectorLleno(9) Or VectorLleno(11) = VectorLleno(10) _
            Or VectorLleno(10) = VectorLleno(4) Or VectorLleno(10) = VectorLleno(3) Or VectorLleno(10) = VectorLleno(2) Or VectorLleno(10) = VectorLleno(1) Or VectorLleno(10) = VectorLleno(0) Or VectorLleno(10) = VectorLleno(5) Or VectorLleno(10) = VectorLleno(6) Or VectorLleno(10) = VectorLleno(7) Or VectorLleno(10) = VectorLleno(8) Or VectorLleno(10) = VectorLleno(9) _
            Or VectorLleno(9) = VectorLleno(4) Or VectorLleno(9) = VectorLleno(3) Or VectorLleno(9) = VectorLleno(2) Or VectorLleno(9) = VectorLleno(1) Or VectorLleno(9) = VectorLleno(0) Or VectorLleno(9) = VectorLleno(5) Or VectorLleno(9) = VectorLleno(6) Or VectorLleno(9) = VectorLleno(7) Or VectorLleno(9) = VectorLleno(8) _
            Or VectorLleno(8) = VectorLleno(4) Or VectorLleno(8) = VectorLleno(3) Or VectorLleno(8) = VectorLleno(2) Or VectorLleno(8) = VectorLleno(1) Or VectorLleno(8) = VectorLleno(0) Or VectorLleno(8) = VectorLleno(5) Or VectorLleno(8) = VectorLleno(6) Or VectorLleno(8) = VectorLleno(7) _
            Or VectorLleno(7) = VectorLleno(4) Or VectorLleno(7) = VectorLleno(3) Or VectorLleno(7) = VectorLleno(2) Or VectorLleno(7) = VectorLleno(1) Or VectorLleno(7) = VectorLleno(0) Or VectorLleno(7) = VectorLleno(5) Or VectorLleno(7) = VectorLleno(6) _
            Or VectorLleno(6) = VectorLleno(4) Or VectorLleno(6) = VectorLleno(3) Or VectorLleno(6) = VectorLleno(2) Or VectorLleno(6) = VectorLleno(1) Or VectorLleno(6) = VectorLleno(0) Or VectorLleno(6) = VectorLleno(5) _
            Or VectorLleno(5) = VectorLleno(4) Or VectorLleno(5) = VectorLleno(3) Or VectorLleno(5) = VectorLleno(2) Or VectorLleno(5) = VectorLleno(1) Or VectorLleno(5) = VectorLleno(0) _
            Or VectorLleno(4) = VectorLleno(3) Or VectorLleno(4) = VectorLleno(2) Or VectorLleno(4) = VectorLleno(1) Or VectorLleno(4) = VectorLleno(0) _
            Or VectorLleno(3) = VectorLleno(2) Or VectorLleno(3) = VectorLleno(1) Or VectorLleno(3) = VectorLleno(0) _
            Or VectorLleno(2) = VectorLleno(1) Or VectorLleno(2) = VectorLleno(0) Or VectorLleno(0) = VectorLleno(1)

            'entra en el while el metodo de vector lleno 
            VectLlen()
        End While
    End Sub
    'metodo de vector lleno2
    Sub VectLlen2()
        'metodo aleatorio 
        aleatorio()
        'longitud del vector igual al numero aleatorio 
        VectorLleno2(0) = numaleatorio
        aleatorio()
        VectorLleno2(1) = numaleatorio
        aleatorio()
        VectorLleno2(2) = numaleatorio
        aleatorio()
        VectorLleno2(3) = numaleatorio
        aleatorio()
        VectorLleno2(4) = numaleatorio
        aleatorio()
        VectorLleno2(5) = numaleatorio
        aleatorio()
        VectorLleno2(6) = numaleatorio
        aleatorio()
        VectorLleno2(7) = numaleatorio
        aleatorio()
        VectorLleno2(8) = numaleatorio
        aleatorio()
        VectorLleno2(9) = numaleatorio
        aleatorio()
        VectorLleno2(10) = numaleatorio
        aleatorio()
        VectorLleno2(11) = numaleatorio
        aleatorio()
        VectorLleno2(12) = numaleatorio
        aleatorio()
        VectorLleno2(13) = numaleatorio
        aleatorio()
        VectorLleno2(14) = numaleatorio
        aleatorio()
        VectorLleno2(15) = numaleatorio
        aleatorio()
        VectorLleno2(16) = numaleatorio
        aleatorio()
        VectorLleno2(17) = numaleatorio
        aleatorio()
        VectorLleno2(18) = numaleatorio
        aleatorio()
        VectorLleno2(19) = numaleatorio
    End Sub
    '------------------------------------------------------------------------------------
    'metodo de numero diferente 2
    Sub NumerosDiferentes2()
        'vector lleno 2 , que se encuentra en el metodo
        VectLlen2()

        'mientas la longitud del vector lleno igual a los espacios del vector lleno 
        While VectorLleno2(19) = VectorLleno2(4) Or VectorLleno2(19) = VectorLleno2(3) Or VectorLleno2(19) = VectorLleno2(2) Or VectorLleno2(19) = VectorLleno2(1) Or VectorLleno2(19) = VectorLleno2(0) Or VectorLleno2(19) = VectorLleno2(5) Or VectorLleno2(19) = VectorLleno2(6) Or VectorLleno2(19) = VectorLleno2(7) Or VectorLleno2(19) = VectorLleno2(8) Or VectorLleno2(19) = VectorLleno2(9) Or VectorLleno2(19) = VectorLleno2(10) Or VectorLleno2(19) = VectorLleno2(11) Or VectorLleno2(19) = VectorLleno2(12) Or VectorLleno2(19) = VectorLleno2(13) Or VectorLleno2(19) = VectorLleno2(14) Or VectorLleno2(19) = VectorLleno2(15) Or VectorLleno2(19) = VectorLleno2(16) Or VectorLleno2(19) = VectorLleno2(17) Or VectorLleno2(19) = VectorLleno2(18) _
            Or VectorLleno2(18) = VectorLleno2(4) Or VectorLleno2(18) = VectorLleno2(3) Or VectorLleno2(18) = VectorLleno2(2) Or VectorLleno2(18) = VectorLleno2(1) Or VectorLleno2(18) = VectorLleno2(0) Or VectorLleno2(18) = VectorLleno2(5) Or VectorLleno2(18) = VectorLleno2(6) Or VectorLleno2(18) = VectorLleno2(7) Or VectorLleno2(18) = VectorLleno2(8) Or VectorLleno2(18) = VectorLleno2(9) Or VectorLleno2(18) = VectorLleno2(10) Or VectorLleno2(18) = VectorLleno2(11) Or VectorLleno2(18) = VectorLleno2(12) Or VectorLleno2(18) = VectorLleno2(13) Or VectorLleno2(18) = VectorLleno2(14) Or VectorLleno2(18) = VectorLleno2(15) Or VectorLleno2(18) = VectorLleno2(16) Or VectorLleno2(18) = VectorLleno2(17) _
            Or VectorLleno2(17) = VectorLleno2(4) Or VectorLleno2(17) = VectorLleno2(3) Or VectorLleno2(17) = VectorLleno2(2) Or VectorLleno2(17) = VectorLleno2(1) Or VectorLleno2(17) = VectorLleno2(0) Or VectorLleno2(17) = VectorLleno2(5) Or VectorLleno2(17) = VectorLleno2(6) Or VectorLleno2(17) = VectorLleno2(7) Or VectorLleno2(17) = VectorLleno2(8) Or VectorLleno2(17) = VectorLleno2(9) Or VectorLleno2(17) = VectorLleno2(10) Or VectorLleno2(17) = VectorLleno2(11) Or VectorLleno2(17) = VectorLleno2(12) Or VectorLleno2(17) = VectorLleno2(13) Or VectorLleno2(17) = VectorLleno2(14) Or VectorLleno2(17) = VectorLleno2(15) Or VectorLleno2(17) = VectorLleno2(16) _
            Or VectorLleno2(16) = VectorLleno2(4) Or VectorLleno2(16) = VectorLleno2(3) Or VectorLleno2(16) = VectorLleno2(2) Or VectorLleno2(16) = VectorLleno2(1) Or VectorLleno2(16) = VectorLleno2(0) Or VectorLleno2(16) = VectorLleno2(5) Or VectorLleno2(16) = VectorLleno2(6) Or VectorLleno2(16) = VectorLleno2(7) Or VectorLleno2(16) = VectorLleno2(8) Or VectorLleno2(16) = VectorLleno2(9) Or VectorLleno2(16) = VectorLleno2(10) Or VectorLleno2(16) = VectorLleno2(11) Or VectorLleno2(16) = VectorLleno2(12) Or VectorLleno2(16) = VectorLleno2(13) Or VectorLleno2(16) = VectorLleno2(14) Or VectorLleno2(16) = VectorLleno2(15) _
            Or VectorLleno2(15) = VectorLleno2(4) Or VectorLleno2(15) = VectorLleno2(3) Or VectorLleno2(15) = VectorLleno2(2) Or VectorLleno2(15) = VectorLleno2(1) Or VectorLleno2(15) = VectorLleno2(0) Or VectorLleno2(15) = VectorLleno2(5) Or VectorLleno2(15) = VectorLleno2(6) Or VectorLleno2(15) = VectorLleno2(7) Or VectorLleno2(15) = VectorLleno2(8) Or VectorLleno2(15) = VectorLleno2(9) Or VectorLleno2(15) = VectorLleno2(10) Or VectorLleno2(15) = VectorLleno2(11) Or VectorLleno2(15) = VectorLleno2(12) Or VectorLleno2(15) = VectorLleno2(13) Or VectorLleno2(15) = VectorLleno2(14) _
            Or VectorLleno2(14) = VectorLleno2(4) Or VectorLleno2(14) = VectorLleno2(3) Or VectorLleno2(14) = VectorLleno2(2) Or VectorLleno2(14) = VectorLleno2(1) Or VectorLleno2(14) = VectorLleno2(0) Or VectorLleno2(14) = VectorLleno2(5) Or VectorLleno2(14) = VectorLleno2(6) Or VectorLleno2(14) = VectorLleno2(7) Or VectorLleno2(14) = VectorLleno2(8) Or VectorLleno2(14) = VectorLleno2(9) Or VectorLleno2(14) = VectorLleno2(10) Or VectorLleno2(14) = VectorLleno2(11) Or VectorLleno2(14) = VectorLleno2(12) Or VectorLleno2(14) = VectorLleno2(13) _
            Or VectorLleno2(13) = VectorLleno2(4) Or VectorLleno2(13) = VectorLleno2(3) Or VectorLleno2(13) = VectorLleno2(2) Or VectorLleno2(13) = VectorLleno2(1) Or VectorLleno2(13) = VectorLleno2(0) Or VectorLleno2(13) = VectorLleno2(5) Or VectorLleno2(13) = VectorLleno2(6) Or VectorLleno2(13) = VectorLleno2(7) Or VectorLleno2(13) = VectorLleno2(8) Or VectorLleno2(13) = VectorLleno2(9) Or VectorLleno2(13) = VectorLleno2(10) Or VectorLleno2(13) = VectorLleno2(11) Or VectorLleno2(13) = VectorLleno2(12) _
            Or VectorLleno2(12) = VectorLleno2(4) Or VectorLleno2(12) = VectorLleno2(3) Or VectorLleno2(12) = VectorLleno2(2) Or VectorLleno2(12) = VectorLleno2(1) Or VectorLleno2(12) = VectorLleno2(0) Or VectorLleno2(12) = VectorLleno2(5) Or VectorLleno2(12) = VectorLleno2(6) Or VectorLleno2(12) = VectorLleno2(7) Or VectorLleno2(12) = VectorLleno2(8) Or VectorLleno2(12) = VectorLleno2(9) Or VectorLleno2(12) = VectorLleno2(10) Or VectorLleno2(12) = VectorLleno2(11) _
            Or VectorLleno2(11) = VectorLleno2(4) Or VectorLleno2(11) = VectorLleno2(3) Or VectorLleno2(11) = VectorLleno2(2) Or VectorLleno2(11) = VectorLleno2(1) Or VectorLleno2(11) = VectorLleno2(0) Or VectorLleno2(11) = VectorLleno2(5) Or VectorLleno2(11) = VectorLleno2(6) Or VectorLleno2(11) = VectorLleno2(7) Or VectorLleno2(11) = VectorLleno2(8) Or VectorLleno2(11) = VectorLleno2(9) Or VectorLleno2(11) = VectorLleno2(10) _
            Or VectorLleno2(10) = VectorLleno2(4) Or VectorLleno2(10) = VectorLleno2(3) Or VectorLleno2(10) = VectorLleno2(2) Or VectorLleno2(10) = VectorLleno2(1) Or VectorLleno2(10) = VectorLleno2(0) Or VectorLleno2(10) = VectorLleno2(5) Or VectorLleno2(10) = VectorLleno2(6) Or VectorLleno2(10) = VectorLleno2(7) Or VectorLleno2(10) = VectorLleno2(8) Or VectorLleno2(10) = VectorLleno2(9) _
            Or VectorLleno2(9) = VectorLleno2(4) Or VectorLleno2(9) = VectorLleno2(3) Or VectorLleno2(9) = VectorLleno2(2) Or VectorLleno2(9) = VectorLleno2(1) Or VectorLleno2(9) = VectorLleno2(0) Or VectorLleno2(9) = VectorLleno2(5) Or VectorLleno2(9) = VectorLleno2(6) Or VectorLleno2(9) = VectorLleno2(7) Or VectorLleno2(9) = VectorLleno2(8) _
            Or VectorLleno2(8) = VectorLleno2(4) Or VectorLleno2(8) = VectorLleno2(3) Or VectorLleno2(8) = VectorLleno2(2) Or VectorLleno2(8) = VectorLleno2(1) Or VectorLleno2(8) = VectorLleno2(0) Or VectorLleno2(8) = VectorLleno2(5) Or VectorLleno2(8) = VectorLleno2(6) Or VectorLleno2(8) = VectorLleno2(7) _
            Or VectorLleno2(7) = VectorLleno2(4) Or VectorLleno2(7) = VectorLleno2(3) Or VectorLleno2(7) = VectorLleno2(2) Or VectorLleno2(7) = VectorLleno2(1) Or VectorLleno2(7) = VectorLleno2(0) Or VectorLleno2(7) = VectorLleno2(5) Or VectorLleno2(7) = VectorLleno2(6) _
            Or VectorLleno2(6) = VectorLleno2(4) Or VectorLleno2(6) = VectorLleno2(3) Or VectorLleno2(6) = VectorLleno2(2) Or VectorLleno2(6) = VectorLleno2(1) Or VectorLleno2(6) = VectorLleno2(0) Or VectorLleno2(6) = VectorLleno2(5) _
            Or VectorLleno2(5) = VectorLleno2(4) Or VectorLleno2(5) = VectorLleno2(3) Or VectorLleno2(5) = VectorLleno2(2) Or VectorLleno2(5) = VectorLleno2(1) Or VectorLleno2(5) = VectorLleno2(0) _
            Or VectorLleno2(4) = VectorLleno2(3) Or VectorLleno2(4) = VectorLleno2(2) Or VectorLleno2(4) = VectorLleno2(1) Or VectorLleno2(4) = VectorLleno2(0) _
            Or VectorLleno2(3) = VectorLleno2(2) Or VectorLleno2(3) = VectorLleno2(1) Or VectorLleno2(3) = VectorLleno2(0) _
            Or VectorLleno2(2) = VectorLleno2(1) Or VectorLleno2(2) = VectorLleno2(0) Or VectorLleno2(0) = VectorLleno2(1)

            'entra en el mienras el metodo del vector lleno 2
            VectLlen2()
        End While
    End Sub
    '---------------------------------------------------------------------
    'validacion de nombre del jugador 1
    Sub validarnomJ1()

        If _nomJ1.Trim.Length = 0 Then  'Valida si el usuario deja el espacio en blanco
            'error 
            Throw New System.Exception("El nombre de J1 no debe quedar en blanco y no debe tener números")

            'si es numerico entonces 
        ElseIf IsNumeric(_nomJ1) Then
            'error 
            Throw New System.Exception("El nombre de J1 no debe quedar en blanco y no debe tener números")
        End If
    End Sub

    Sub validarnomJ2()
        If _nomJ2.Trim.Length = 0 Then  'Valida si el usuario deja el espacio en blanco
            'error 
            Throw New System.Exception("El nombre de J2 no debe quedar en blanco y no debe tener números")

            'si es numerico entonces 
        ElseIf IsNumeric(_nomJ2) Then
            'error 
            Throw New System.Exception("El nombre de J2 no debe quedar en blanco y no debe tener números")
        End If
    End Sub
#End Region
    '************************************************************
#Region "archivos"

    'seleccion de la categoria segun el jugador 1
    Sub ejectArch()
        'si la seleccion es igual a 1 o a 10
        If indx = 1 Then
            'se escoge el archivo con la categoria 
            filename = "Cultura.txt"

        ElseIf indx = 2 Then
            'se escoge el archivo con la categoria 
            filename = "Deportes.txt"

        ElseIf indx = 3 Then
            'se escoge el archivo con la categoria 
            filename = "Salud.txt"

        ElseIf indx = 4 Then
            'se escoge el archivo con la categoria 
            filename = "Politica.txt"

        ElseIf indx = 5 Then
            'se escoge el archivo con la categoria 
            filename = "Finanzas.txt"

        ElseIf indx = 6 Then
            'se escoge el archivo con la categoria 
            filename = "Historia.txt"


        ElseIf indx = 7 Then
            'se escoge el archivo con la categoria 
            filename = "Ciencia.txt"

        ElseIf indx = 8 Then
            'se escoge el archivo con la categoria 
            filename = "Tecnologia.txt"

        ElseIf indx = 9 Then
            'se escoge el archivo con la categoria 
            filename = "Astronomia.txt"

        ElseIf indx = 10 Then
            'se escoge el archivo con la categoria 
            filename = "Música.txt"

        ElseIf indx = 11 Then
            'se escoge el archivo con la categoria 
            catgener()

        End If
    End Sub
    '-------------------------------------------------------------
    'Metodo para ejecutar la categoria general
    Sub catgener()
        aleatGener = Math.Ceiling(Rnd() * 10)
        If aleatGener = 1 Then
            filename = "General1.txt"
        ElseIf aleatGener = 2 Then
            filename = "General2.txt"
        ElseIf aleatGener = 3 Then
            filename = "General3.txt"
        ElseIf aleatGener = 4 Then
            filename = "General4.txt"
        ElseIf aleatGener = 5 Then
            filename = "General5.txt"
        ElseIf aleatGener = 6 Then
            filename = "General6.txt"
        ElseIf aleatGener = 7 Then
            filename = "General7.txt"
        ElseIf aleatGener = 8 Then
            filename = "General8.txt"
        ElseIf aleatGener = 9 Then
            filename = "General9.txt"
        ElseIf aleatGener = 10 Then
            filename = "General10.txt"
        End If
    End Sub
    '--------------------------------------------------------------------
    'escogencia de la categoria seguh el jugador 2
    Sub ejectArch2()
        'se escoge la categoria del 1 al 10
        If indx = 1 Then
            'se escoge el archivo con la categoria
            filename2 = "Cultura.txt"

        ElseIf indx = 2 Then
            'se escoge el archivo con la categoria
            filename2 = "Deportes.txt"

        ElseIf indx = 3 Then
            'se escoge el archivo con la categoria
            filename2 = "Salud.txt"

        ElseIf indx = 4 Then
            'se escoge el archivo con la categoria 
            filename2 = "Politica.txt"

        ElseIf indx = 5 Then
            'se escoge el archivo con la categoria 
            filename2 = "Finanzas.txt"

        ElseIf indx = 6 Then
            'se escoge el archivo con la categoria 
            filename2 = "Historia.txt"

        ElseIf indx = 7 Then
            'se escoge el archivo con la categoria 
            filename2 = "Ciencia.txt"

        ElseIf indx = 8 Then
            'se escoge el archivo con la categoria 
            filename2 = "Tecnologia.txt"

        ElseIf indx = 9 Then
            'se escoge el archivo con la categoria 
            filename2 = "Astronomia.txt"

        ElseIf indx = 10 Then
            'se escoge el archivo con la categoria 
            filename2 = "Música.txt"

        ElseIf indx = 11 Then
            'se escoge el archivo con la categoria 
            catgener2()
        End If
    End Sub

    'Metodo para ejecutar la categoria general para el jugador 2
    Sub catgener2()
        aleatGener = Math.Ceiling(Rnd() * 10)
        If aleatGener = 1 Then
            filename2 = "General1.txt"
        ElseIf aleatGener = 2 Then
            filename2 = "General2.txt"
        ElseIf aleatGener = 3 Then
            filename2 = "General3.txt"
        ElseIf aleatGener = 4 Then
            filename2 = "General4.txt"
        ElseIf aleatGener = 5 Then
            filename2 = "General5.txt"
        ElseIf aleatGener = 6 Then
            filename2 = "General6.txt"
        ElseIf aleatGener = 7 Then
            filename2 = "General7.txt"
        ElseIf aleatGener = 8 Then
            filename2 = "General8.txt"
        ElseIf aleatGener = 9 Then
            filename2 = "General9.txt"
        ElseIf aleatGener = 10 Then
            filename2 = "General10.txt"
        End If
    End Sub
    '--------------------------------------------------------------
    'lectura del objeto 
    Sub objectlect()
        'objeto de lectura es igual al nombre del archivo 

        objReader = New StreamReader(filename, System.Text.Encoding.GetEncoding(28591))


    End Sub
    '-----------------------------------------------------------
    'lectura por comas 
    Sub leerporcomas()
        ' linea de texto 
        LineaTexto = objReader.ReadLine()
        splitlinea = Split(LineaTexto, ",")
    End Sub
    '--------------------------------------------------------------------------------
    'metodo de lectura de objeto 2
    Sub objectlect2()
        'objeto de lectura 2 para la lectura de archivo 

        objReader2 = New StreamReader(filename2, System.Text.Encoding.GetEncoding(28591))

    End Sub
    '---------------------------------------------------------
    'lectura por comas  2
    Sub leerporcomas2()
        'linea de texto 2
        LineaTexto2 = objReader2.ReadLine()
        splitlinea2 = Split(LineaTexto2, ",")
    End Sub
    '-----------------------------------------------------------
    'metodo de la existencia del archivo 
    Sub ExisteArchivo()
        'si el nombre del archivo existe entonces 
        If File.Exists(fName) Then
            'existe 
            _archivoexiste = True
        Else
            'no existe 
            _archivoexiste = False
        End If
    End Sub
    '------------------------------------------------------------------
    'metodo para el archvivo que existe 2 
    Sub ExisteArchivo2()
        'si el archivo existe entonces 
        If File.Exists(fName2) Then
            'existe
            _archivoexiste2 = True
        Else
            'no existe 
            _archivoexiste2 = False
        End If
    End Sub
    '------------------------------------------------------------------
    'validacion por si el directorio no existe 
    Sub directorionoexist()
        'si el archivo no existe entonces 
        If _archivoexiste = False Then
            'error de categoria
            MsgBox("Error al cargar la categoría seleccionada")
        End If
    End Sub
    '-------------------------------------------------
    'validacion del archivo 2 no existe 
    Sub directorionoexist2()
        'si el archivo 2 no existe entonces 
        If _archivoexiste2 = False Then
            'error de categoria 
            MsgBox("Error al cargar la categoría seleccionada")
        End If
    End Sub
#End Region
    '****************************************************************
#Region "comodines"
    'metodo de la llamada 
    Sub llamada()

        'la llamada de forma al azar hasta 6
        _llamd = Math.Ceiling(Rnd() * 6)
        'si la llamda es igual a 1 o2 o 3 o 4 o 5 entonces 
        If _llamd = 1 Or _llamd = 2 Or _llamd = 3 Or _llamd = 4 Or _llamd = 5 Then

            'mensaje de respuesta correcta
            MsgBox("La respuesta sugerida es: " + RespuestaCorrecta)
        Else

            'mensaje de respuesta incorrecta 
            MsgBox("La respuesta sugerida es: " + _respIncorr)
        End If
    End Sub
    '------------------------------------------------------------------------
    'metodo para la respuesta del publico 
    Sub RespuestaPublico()
        'procentage de publico 1
        _porc1publ = Math.Ceiling(Rnd() * 100)
        'procentage de publico 2
        _porc2publ = Math.Ceiling(Rnd() * 25)
        'procentage de publico 3
        _porc3publ = Math.Ceiling(Rnd() * 15)
        'procentage de publico 4 
        _porc4publ = Math.Ceiling(Rnd() * 10)

        'mientras los porcentages de los cuatro publico no sean igual a 100 entonces 
        While Not _porc1publ + _porc2publ + _porc3publ + _porc4publ = 100
            'procentage de publico 1
            _porc1publ = Math.Ceiling(Rnd() * 100)

            'procentage de publico 2
            _porc2publ = Math.Ceiling(Rnd() * 25)

            'procentage de publico 3
            _porc3publ = Math.Ceiling(Rnd() * 15)

            'procentage de publico 4
            _porc4publ = Math.Ceiling(Rnd() * 10)
        End While

        'un mensaje donde muestra el porcentage de la respuesta escogida por el publico 
        'dando las respuestas escogidas
        MsgBox("Un " + _porc1publ.ToString + "% vota por la respuesta: " + _RespuestaCorrecta + vbCrLf _
               + "Un " + _porc2publ.ToString + "% vota por la respuesta: " + _opcion2publ + vbCrLf _
               + "Un " + _porc3publ.ToString + "% vota por la respuesta: " + _opcion3publ + vbCrLf _
               + "Un " + _porc4publ.ToString + "% vota por la respuesta: " + _opcion4publ + vbCrLf)
    End Sub
    '------------------------------------------------------------------------------------------------------
    'metodo de variacion de respuesta 
    Sub variarrespuest()
        'variacion del publico de tipo random 
        _varpub = Math.Ceiling(Rnd() * 3)
    End Sub
    '---------------------------------------------------------------------
    'metodo de la categoria #2
    Sub validarcat2enblanc()
        'en caso de que no seleccione uan categoria el jugador2
        Throw New System.Exception("Seleccione una categoría para el jugador 2")
    End Sub
#End Region
    '****************************************************************
#End Region
End Class
