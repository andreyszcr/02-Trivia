<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPregunta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnresp1 = New System.Windows.Forms.Button()
        Me.btnresp2 = New System.Windows.Forms.Button()
        Me.btnresp3 = New System.Windows.Forms.Button()
        Me.btnresp4 = New System.Windows.Forms.Button()
        Me.lblPunt = New System.Windows.Forms.Label()
        Me.gbtime = New System.Windows.Forms.GroupBox()
        Me.lblSeg = New System.Windows.Forms.Label()
        Me.lblPunt2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComodinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIcincuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.LlamadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespuestaDelPúblicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PausaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblOculSiguien = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.TimerPregunt = New System.Windows.Forms.Timer(Me.components)
        Me.gbtime.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(52, 71)
        Me.lblPregunta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(97, 25)
        Me.lblPregunta.TabIndex = 1
        Me.lblPregunta.Text = "pregunta"
        '
        'btnresp1
        '
        Me.btnresp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresp1.Location = New System.Drawing.Point(53, 178)
        Me.btnresp1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresp1.Name = "btnresp1"
        Me.btnresp1.Size = New System.Drawing.Size(160, 75)
        Me.btnresp1.TabIndex = 2
        Me.btnresp1.Text = "btnresp1"
        Me.btnresp1.UseVisualStyleBackColor = True
        '
        'btnresp2
        '
        Me.btnresp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresp2.Location = New System.Drawing.Point(260, 178)
        Me.btnresp2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresp2.Name = "btnresp2"
        Me.btnresp2.Size = New System.Drawing.Size(160, 75)
        Me.btnresp2.TabIndex = 3
        Me.btnresp2.Text = "btnresp2"
        Me.btnresp2.UseVisualStyleBackColor = True
        '
        'btnresp3
        '
        Me.btnresp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresp3.Location = New System.Drawing.Point(456, 178)
        Me.btnresp3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresp3.Name = "btnresp3"
        Me.btnresp3.Size = New System.Drawing.Size(160, 75)
        Me.btnresp3.TabIndex = 4
        Me.btnresp3.Text = "btnresp3"
        Me.btnresp3.UseVisualStyleBackColor = True
        '
        'btnresp4
        '
        Me.btnresp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresp4.Location = New System.Drawing.Point(655, 178)
        Me.btnresp4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnresp4.Name = "btnresp4"
        Me.btnresp4.Size = New System.Drawing.Size(160, 75)
        Me.btnresp4.TabIndex = 5
        Me.btnresp4.Text = "btnresp4"
        Me.btnresp4.UseVisualStyleBackColor = True
        '
        'lblPunt
        '
        Me.lblPunt.AutoSize = True
        Me.lblPunt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunt.Location = New System.Drawing.Point(73, 270)
        Me.lblPunt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPunt.Name = "lblPunt"
        Me.lblPunt.Size = New System.Drawing.Size(134, 20)
        Me.lblPunt.TabIndex = 6
        Me.lblPunt.Text = "Puntuación J1:"
        '
        'gbtime
        '
        Me.gbtime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbtime.Controls.Add(Me.lblSeg)
        Me.gbtime.Location = New System.Drawing.Point(716, 15)
        Me.gbtime.Margin = New System.Windows.Forms.Padding(4)
        Me.gbtime.Name = "gbtime"
        Me.gbtime.Padding = New System.Windows.Forms.Padding(4)
        Me.gbtime.Size = New System.Drawing.Size(145, 81)
        Me.gbtime.TabIndex = 8
        Me.gbtime.TabStop = False
        Me.gbtime.Text = "tiempo"
        '
        'lblSeg
        '
        Me.lblSeg.AutoSize = True
        Me.lblSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeg.ForeColor = System.Drawing.Color.Maroon
        Me.lblSeg.Location = New System.Drawing.Point(56, 31)
        Me.lblSeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeg.Name = "lblSeg"
        Me.lblSeg.Size = New System.Drawing.Size(41, 29)
        Me.lblSeg.TabIndex = 1
        Me.lblSeg.Text = "25"
        '
        'lblPunt2
        '
        Me.lblPunt2.AutoSize = True
        Me.lblPunt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunt2.Location = New System.Drawing.Point(73, 300)
        Me.lblPunt2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPunt2.Name = "lblPunt2"
        Me.lblPunt2.Size = New System.Drawing.Size(134, 20)
        Me.lblPunt2.TabIndex = 9
        Me.lblPunt2.Text = "Puntuación J2:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComodinesToolStripMenuItem, Me.PausaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(877, 30)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComodinesToolStripMenuItem
        '
        Me.ComodinesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIcincuenta, Me.LlamadaToolStripMenuItem, Me.RespuestaDelPúblicoToolStripMenuItem})
        Me.ComodinesToolStripMenuItem.Name = "ComodinesToolStripMenuItem"
        Me.ComodinesToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.ComodinesToolStripMenuItem.Text = "Comodines"
        '
        'TSMIcincuenta
        '
        Me.TSMIcincuenta.Name = "TSMIcincuenta"
        Me.TSMIcincuenta.Size = New System.Drawing.Size(238, 26)
        Me.TSMIcincuenta.Text = "50/50"
        '
        'LlamadaToolStripMenuItem
        '
        Me.LlamadaToolStripMenuItem.Name = "LlamadaToolStripMenuItem"
        Me.LlamadaToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.LlamadaToolStripMenuItem.Text = "Llamada"
        '
        'RespuestaDelPúblicoToolStripMenuItem
        '
        Me.RespuestaDelPúblicoToolStripMenuItem.Name = "RespuestaDelPúblicoToolStripMenuItem"
        Me.RespuestaDelPúblicoToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.RespuestaDelPúblicoToolStripMenuItem.Text = "Respuesta del público"
        '
        'PausaToolStripMenuItem
        '
        Me.PausaToolStripMenuItem.Name = "PausaToolStripMenuItem"
        Me.PausaToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.PausaToolStripMenuItem.Text = "pausa/continuar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblOculSiguien
        '
        Me.lblOculSiguien.AutoSize = True
        Me.lblOculSiguien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOculSiguien.Location = New System.Drawing.Point(380, 284)
        Me.lblOculSiguien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOculSiguien.Name = "lblOculSiguien"
        Me.lblOculSiguien.Size = New System.Drawing.Size(19, 20)
        Me.lblOculSiguien.TabIndex = 12
        Me.lblOculSiguien.Text = "1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.juegoTrivia.My.Resources.Resources.frmPregunta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 465)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(509, 34)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 28)
        Me.btnIniciar.TabIndex = 13
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(561, 337)
        Me.lblTurno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(52, 20)
        Me.lblTurno.TabIndex = 14
        Me.lblTurno.Text = "turno"
        '
        'TimerPregunt
        '
        Me.TimerPregunt.Interval = 1000
        '
        'frmPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 495)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblOculSiguien)
        Me.Controls.Add(Me.lblPunt2)
        Me.Controls.Add(Me.gbtime)
        Me.Controls.Add(Me.lblPunt)
        Me.Controls.Add(Me.btnresp4)
        Me.Controls.Add(Me.btnresp3)
        Me.Controls.Add(Me.btnresp2)
        Me.Controls.Add(Me.btnresp1)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPregunta"
        Me.Text = "frmPregunta"
        Me.gbtime.ResumeLayout(False)
        Me.gbtime.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnresp1 As Button
    Friend WithEvents btnresp2 As Button
    Friend WithEvents btnresp3 As Button
    Friend WithEvents btnresp4 As Button
    Friend WithEvents lblPunt As Label
    Friend WithEvents gbtime As GroupBox
    Friend WithEvents lblSeg As Label
    Friend WithEvents lblPunt2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComodinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIcincuenta As ToolStripMenuItem
    Friend WithEvents LlamadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespuestaDelPúblicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblOculSiguien As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lblTurno As Label
    Friend WithEvents PausaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerPregunt As Timer
End Class
