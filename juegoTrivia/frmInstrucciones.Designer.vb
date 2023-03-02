<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstrucciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbInstruc0 = New System.Windows.Forms.Label()
        Me.LbInstruc9 = New System.Windows.Forms.Label()
        Me.LbInstruc8 = New System.Windows.Forms.Label()
        Me.LbInstruc7 = New System.Windows.Forms.Label()
        Me.LbInstruc6 = New System.Windows.Forms.Label()
        Me.LbInstruc5 = New System.Windows.Forms.Label()
        Me.LbInstruc4 = New System.Windows.Forms.Label()
        Me.LbInstruc3 = New System.Windows.Forms.Label()
        Me.LbInstruc2 = New System.Windows.Forms.Label()
        Me.LbInstruc1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.juegoTrivia.My.Resources.Resources.preguntados1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(882, 399)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LbInstruc0
        '
        Me.LbInstruc0.AutoSize = True
        Me.LbInstruc0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc0.Location = New System.Drawing.Point(389, 23)
        Me.LbInstruc0.Name = "LbInstruc0"
        Me.LbInstruc0.Size = New System.Drawing.Size(104, 20)
        Me.LbInstruc0.TabIndex = 19
        Me.LbInstruc0.Text = "Instrucciones"
        '
        'LbInstruc9
        '
        Me.LbInstruc9.AutoSize = True
        Me.LbInstruc9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc9.Location = New System.Drawing.Point(36, 339)
        Me.LbInstruc9.Name = "LbInstruc9"
        Me.LbInstruc9.Size = New System.Drawing.Size(834, 16)
        Me.LbInstruc9.TabIndex = 18
        Me.LbInstruc9.Text = "La tercera '' Publicó '' dentro del auditorio todos irán a votación y te mostrare" &
    "mos cuál respuesta tiene el mayor porcentaje según el público."
        '
        'LbInstruc8
        '
        Me.LbInstruc8.AutoSize = True
        Me.LbInstruc8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc8.Location = New System.Drawing.Point(36, 310)
        Me.LbInstruc8.Name = "LbInstruc8"
        Me.LbInstruc8.Size = New System.Drawing.Size(525, 16)
        Me.LbInstruc8.TabIndex = 17
        Me.LbInstruc8.Text = "La segunda '' Llamada''  algún conocido lo podrás llamar para sugerirte una respu" &
    "esta."
        '
        'LbInstruc7
        '
        Me.LbInstruc7.AutoSize = True
        Me.LbInstruc7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc7.Location = New System.Drawing.Point(36, 281)
        Me.LbInstruc7.Name = "LbInstruc7"
        Me.LbInstruc7.Size = New System.Drawing.Size(444, 16)
        Me.LbInstruc7.TabIndex = 16
        Me.LbInstruc7.Text = "La primera 50/50 se eliminarán dos opciones de respuesta a la pregunta. "
        '
        'LbInstruc6
        '
        Me.LbInstruc6.AutoSize = True
        Me.LbInstruc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc6.Location = New System.Drawing.Point(11, 244)
        Me.LbInstruc6.Name = "LbInstruc6"
        Me.LbInstruc6.Size = New System.Drawing.Size(378, 16)
        Me.LbInstruc6.TabIndex = 15
        Me.LbInstruc6.Text = "Si no sabes la respuesta, habrán 3 opiniones en todo el juego:"
        '
        'LbInstruc5
        '
        Me.LbInstruc5.AutoSize = True
        Me.LbInstruc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc5.Location = New System.Drawing.Point(12, 206)
        Me.LbInstruc5.Name = "LbInstruc5"
        Me.LbInstruc5.Size = New System.Drawing.Size(329, 16)
        Me.LbInstruc5.TabIndex = 14
        Me.LbInstruc5.Text = "Tenés la opción de ''pausar'', '' reiniciar'' o '' finalizar''. "
        '
        'LbInstruc4
        '
        Me.LbInstruc4.AutoSize = True
        Me.LbInstruc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc4.Location = New System.Drawing.Point(12, 171)
        Me.LbInstruc4.Name = "LbInstruc4"
        Me.LbInstruc4.Size = New System.Drawing.Size(441, 16)
        Me.LbInstruc4.TabIndex = 13
        Me.LbInstruc4.Text = "Tendrás un tiempo para dar tu respuesta y también tu duración de juego. "
        '
        'LbInstruc3
        '
        Me.LbInstruc3.AutoSize = True
        Me.LbInstruc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc3.Location = New System.Drawing.Point(11, 136)
        Me.LbInstruc3.Name = "LbInstruc3"
        Me.LbInstruc3.Size = New System.Drawing.Size(469, 16)
        Me.LbInstruc3.TabIndex = 12
        Me.LbInstruc3.Text = "Podes jugarlo con un amigo donde solo habrá un ganador, '' Intenta Ganarle''."
        '
        'LbInstruc2
        '
        Me.LbInstruc2.AutoSize = True
        Me.LbInstruc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc2.Location = New System.Drawing.Point(12, 96)
        Me.LbInstruc2.Name = "LbInstruc2"
        Me.LbInstruc2.Size = New System.Drawing.Size(838, 16)
        Me.LbInstruc2.TabIndex = 11
        Me.LbInstruc2.Text = "Constara de 20 preguntas independientemente de la categoría a escoger la cual con" &
    "stará de 4 respuestas una de las cuales es la correcta. "
        '
        'LbInstruc1
        '
        Me.LbInstruc1.AutoSize = True
        Me.LbInstruc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInstruc1.Location = New System.Drawing.Point(12, 65)
        Me.LbInstruc1.Name = "LbInstruc1"
        Me.LbInstruc1.Size = New System.Drawing.Size(785, 16)
        Me.LbInstruc1.TabIndex = 10
        Me.LbInstruc1.Text = "Nuestro juego ""Trivia"" es un conjunto de preguntas donde deberás explotar todos t" &
    "us conocimientos para llegar al máximo puntaje."
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(778, 366)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(92, 28)
        Me.btnvolver.TabIndex = 20
        Me.btnvolver.Text = "Volver al menu"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'frmInstrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 399)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.LbInstruc0)
        Me.Controls.Add(Me.LbInstruc9)
        Me.Controls.Add(Me.LbInstruc8)
        Me.Controls.Add(Me.LbInstruc7)
        Me.Controls.Add(Me.LbInstruc6)
        Me.Controls.Add(Me.LbInstruc5)
        Me.Controls.Add(Me.LbInstruc4)
        Me.Controls.Add(Me.LbInstruc3)
        Me.Controls.Add(Me.LbInstruc2)
        Me.Controls.Add(Me.LbInstruc1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmInstrucciones"
        Me.Text = "frmInstrucciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbInstruc0 As Label
    Friend WithEvents LbInstruc9 As Label
    Friend WithEvents LbInstruc8 As Label
    Friend WithEvents LbInstruc7 As Label
    Friend WithEvents LbInstruc6 As Label
    Friend WithEvents LbInstruc5 As Label
    Friend WithEvents LbInstruc4 As Label
    Friend WithEvents LbInstruc3 As Label
    Friend WithEvents LbInstruc2 As Label
    Friend WithEvents LbInstruc1 As Label
    Friend WithEvents btnvolver As Button
End Class
