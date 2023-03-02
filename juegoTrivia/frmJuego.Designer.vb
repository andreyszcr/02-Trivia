<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJuego
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
        Me.mnsMenuJuego = New System.Windows.Forms.MenuStrip()
        Me.VolverAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnsJugador1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmnsJugador2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PausarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReinicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbtime = New System.Windows.Forms.GroupBox()
        Me.lblpunto3 = New System.Windows.Forms.Label()
        Me.lblpunto2 = New System.Windows.Forms.Label()
        Me.lblpunto1 = New System.Windows.Forms.Label()
        Me.lblmilisegundo = New System.Windows.Forms.Label()
        Me.lblsegundo = New System.Windows.Forms.Label()
        Me.lblminuto = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.cronometro = New System.Windows.Forms.Timer(Me.components)
        Me.txtnombre2 = New System.Windows.Forms.TextBox()
        Me.txtnombre1 = New System.Windows.Forms.TextBox()
        Me.gbJugadores = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.cmbj2 = New System.Windows.Forms.ComboBox()
        Me.cmbj1 = New System.Windows.Forms.ComboBox()
        Me.lbljugador2 = New System.Windows.Forms.Label()
        Me.lbljugador = New System.Windows.Forms.Label()
        Me.pbPintura1 = New System.Windows.Forms.PictureBox()
        Me.lblunjug = New System.Windows.Forms.Label()
        Me.lbldosjug = New System.Windows.Forms.Label()
        Me.dgvLector = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnsMenuJuego.SuspendLayout()
        Me.gbtime.SuspendLayout()
        Me.gbJugadores.SuspendLayout()
        CType(Me.pbPintura1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMenuJuego
        '
        Me.mnsMenuJuego.BackColor = System.Drawing.Color.Fuchsia
        Me.mnsMenuJuego.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsMenuJuego.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenuPrincipalToolStripMenuItem, Me.JugadoresToolStripMenuItem, Me.PausarToolStripMenuItem, Me.ReinicarToolStripMenuItem})
        Me.mnsMenuJuego.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenuJuego.Name = "mnsMenuJuego"
        Me.mnsMenuJuego.Size = New System.Drawing.Size(1180, 30)
        Me.mnsMenuJuego.TabIndex = 0
        Me.mnsMenuJuego.Text = "MenuStrip1"
        '
        'VolverAlMenuPrincipalToolStripMenuItem
        '
        Me.VolverAlMenuPrincipalToolStripMenuItem.Name = "VolverAlMenuPrincipalToolStripMenuItem"
        Me.VolverAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.VolverAlMenuPrincipalToolStripMenuItem.Text = "Volver al Menu Principal "
        '
        'JugadoresToolStripMenuItem
        '
        Me.JugadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnsJugador1, Me.tmnsJugador2})
        Me.JugadoresToolStripMenuItem.Name = "JugadoresToolStripMenuItem"
        Me.JugadoresToolStripMenuItem.Size = New System.Drawing.Size(90, 26)
        Me.JugadoresToolStripMenuItem.Text = "Jugadores"
        '
        'tsmnsJugador1
        '
        Me.tsmnsJugador1.Name = "tsmnsJugador1"
        Me.tsmnsJugador1.Size = New System.Drawing.Size(170, 26)
        Me.tsmnsJugador1.Text = "1 jugador"
        '
        'tmnsJugador2
        '
        Me.tmnsJugador2.Name = "tmnsJugador2"
        Me.tmnsJugador2.Size = New System.Drawing.Size(170, 26)
        Me.tmnsJugador2.Text = "2 jugadores"
        '
        'PausarToolStripMenuItem
        '
        Me.PausarToolStripMenuItem.Name = "PausarToolStripMenuItem"
        Me.PausarToolStripMenuItem.Size = New System.Drawing.Size(69, 26)
        Me.PausarToolStripMenuItem.Text = "Pausar "
        '
        'ReinicarToolStripMenuItem
        '
        Me.ReinicarToolStripMenuItem.Name = "ReinicarToolStripMenuItem"
        Me.ReinicarToolStripMenuItem.Size = New System.Drawing.Size(80, 26)
        Me.ReinicarToolStripMenuItem.Text = "Reiniciar"
        '
        'gbtime
        '
        Me.gbtime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbtime.Controls.Add(Me.lblpunto3)
        Me.gbtime.Controls.Add(Me.lblpunto2)
        Me.gbtime.Controls.Add(Me.lblpunto1)
        Me.gbtime.Controls.Add(Me.lblmilisegundo)
        Me.gbtime.Controls.Add(Me.lblsegundo)
        Me.gbtime.Controls.Add(Me.lblminuto)
        Me.gbtime.Controls.Add(Me.lblhora)
        Me.gbtime.Location = New System.Drawing.Point(441, 577)
        Me.gbtime.Margin = New System.Windows.Forms.Padding(4)
        Me.gbtime.Name = "gbtime"
        Me.gbtime.Padding = New System.Windows.Forms.Padding(4)
        Me.gbtime.Size = New System.Drawing.Size(308, 113)
        Me.gbtime.TabIndex = 2
        Me.gbtime.TabStop = False
        '
        'lblpunto3
        '
        Me.lblpunto3.AutoSize = True
        Me.lblpunto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpunto3.ForeColor = System.Drawing.Color.Maroon
        Me.lblpunto3.Location = New System.Drawing.Point(220, 54)
        Me.lblpunto3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpunto3.Name = "lblpunto3"
        Me.lblpunto3.Size = New System.Drawing.Size(26, 39)
        Me.lblpunto3.TabIndex = 5
        Me.lblpunto3.Text = ":"
        '
        'lblpunto2
        '
        Me.lblpunto2.AutoSize = True
        Me.lblpunto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpunto2.ForeColor = System.Drawing.Color.Maroon
        Me.lblpunto2.Location = New System.Drawing.Point(133, 54)
        Me.lblpunto2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpunto2.Name = "lblpunto2"
        Me.lblpunto2.Size = New System.Drawing.Size(26, 39)
        Me.lblpunto2.TabIndex = 4
        Me.lblpunto2.Text = ":"
        '
        'lblpunto1
        '
        Me.lblpunto1.AutoSize = True
        Me.lblpunto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpunto1.ForeColor = System.Drawing.Color.Maroon
        Me.lblpunto1.Location = New System.Drawing.Point(53, 54)
        Me.lblpunto1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpunto1.Name = "lblpunto1"
        Me.lblpunto1.Size = New System.Drawing.Size(26, 39)
        Me.lblpunto1.TabIndex = 3
        Me.lblpunto1.Text = ":"
        '
        'lblmilisegundo
        '
        Me.lblmilisegundo.AutoSize = True
        Me.lblmilisegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmilisegundo.ForeColor = System.Drawing.Color.Maroon
        Me.lblmilisegundo.Location = New System.Drawing.Point(241, 54)
        Me.lblmilisegundo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmilisegundo.Name = "lblmilisegundo"
        Me.lblmilisegundo.Size = New System.Drawing.Size(55, 39)
        Me.lblmilisegundo.TabIndex = 3
        Me.lblmilisegundo.Text = "00"
        '
        'lblsegundo
        '
        Me.lblsegundo.AutoSize = True
        Me.lblsegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsegundo.ForeColor = System.Drawing.Color.Maroon
        Me.lblsegundo.Location = New System.Drawing.Point(156, 54)
        Me.lblsegundo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsegundo.Name = "lblsegundo"
        Me.lblsegundo.Size = New System.Drawing.Size(55, 39)
        Me.lblsegundo.TabIndex = 2
        Me.lblsegundo.Text = "00"
        '
        'lblminuto
        '
        Me.lblminuto.AutoSize = True
        Me.lblminuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuto.ForeColor = System.Drawing.Color.Maroon
        Me.lblminuto.Location = New System.Drawing.Point(75, 54)
        Me.lblminuto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblminuto.Name = "lblminuto"
        Me.lblminuto.Size = New System.Drawing.Size(55, 39)
        Me.lblminuto.TabIndex = 1
        Me.lblminuto.Text = "00"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.Maroon
        Me.lblhora.Location = New System.Drawing.Point(8, 54)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(55, 39)
        Me.lblhora.TabIndex = 0
        Me.lblhora.Text = "00"
        '
        'cronometro
        '
        Me.cronometro.Interval = 10
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(96, 128)
        Me.txtnombre2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(169, 22)
        Me.txtnombre2.TabIndex = 3
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(96, 31)
        Me.txtnombre1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(169, 22)
        Me.txtnombre1.TabIndex = 4
        '
        'gbJugadores
        '
        Me.gbJugadores.BackColor = System.Drawing.Color.MediumPurple
        Me.gbJugadores.Controls.Add(Me.btnIniciar)
        Me.gbJugadores.Controls.Add(Me.cmbj2)
        Me.gbJugadores.Controls.Add(Me.cmbj1)
        Me.gbJugadores.Controls.Add(Me.lbljugador2)
        Me.gbJugadores.Controls.Add(Me.txtnombre1)
        Me.gbJugadores.Controls.Add(Me.lbljugador)
        Me.gbJugadores.Controls.Add(Me.txtnombre2)
        Me.gbJugadores.Location = New System.Drawing.Point(16, 33)
        Me.gbJugadores.Margin = New System.Windows.Forms.Padding(4)
        Me.gbJugadores.Name = "gbJugadores"
        Me.gbJugadores.Padding = New System.Windows.Forms.Padding(4)
        Me.gbJugadores.Size = New System.Drawing.Size(289, 263)
        Me.gbJugadores.TabIndex = 5
        Me.gbJugadores.TabStop = False
        Me.gbJugadores.Text = "Jugadores"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnIniciar.Location = New System.Drawing.Point(167, 217)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 28)
        Me.btnIniciar.TabIndex = 6
        Me.btnIniciar.Text = "Inicio"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'cmbj2
        '
        Me.cmbj2.FormattingEnabled = True
        Me.cmbj2.Items.AddRange(New Object() {"Cultura", "Deportes", "Salud", "Politica", "Finanzas", "Historia ", "Ciencia", "Tecnologia ", "Astronomia", "Musica", "General"})
        Me.cmbj2.Location = New System.Drawing.Point(124, 172)
        Me.cmbj2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbj2.Name = "cmbj2"
        Me.cmbj2.Size = New System.Drawing.Size(141, 24)
        Me.cmbj2.TabIndex = 8
        '
        'cmbj1
        '
        Me.cmbj1.FormattingEnabled = True
        Me.cmbj1.Items.AddRange(New Object() {"Cultura", "Deportes", "Salud", "Politica", "Finanzas", "Historia", "Ciencia ", "Tecnologia", "Astronomia", "Musica", "General"})
        Me.cmbj1.Location = New System.Drawing.Point(124, 79)
        Me.cmbj1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbj1.Name = "cmbj1"
        Me.cmbj1.Size = New System.Drawing.Size(141, 24)
        Me.cmbj1.TabIndex = 6
        '
        'lbljugador2
        '
        Me.lbljugador2.AutoSize = True
        Me.lbljugador2.Location = New System.Drawing.Point(12, 137)
        Me.lbljugador2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljugador2.Name = "lbljugador2"
        Me.lbljugador2.Size = New System.Drawing.Size(68, 17)
        Me.lbljugador2.TabIndex = 7
        Me.lbljugador2.Text = "jugador 2"
        '
        'lbljugador
        '
        Me.lbljugador.AutoSize = True
        Me.lbljugador.Location = New System.Drawing.Point(12, 34)
        Me.lbljugador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljugador.Name = "lbljugador"
        Me.lbljugador.Size = New System.Drawing.Size(64, 17)
        Me.lbljugador.TabIndex = 6
        Me.lbljugador.Text = "jugador1"
        '
        'pbPintura1
        '
        Me.pbPintura1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPintura1.Image = Global.juegoTrivia.My.Resources.Resources.frmjuego
        Me.pbPintura1.Location = New System.Drawing.Point(0, 30)
        Me.pbPintura1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbPintura1.Name = "pbPintura1"
        Me.pbPintura1.Size = New System.Drawing.Size(1180, 675)
        Me.pbPintura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPintura1.TabIndex = 1
        Me.pbPintura1.TabStop = False
        '
        'lblunjug
        '
        Me.lblunjug.AutoSize = True
        Me.lblunjug.Location = New System.Drawing.Point(1005, 383)
        Me.lblunjug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblunjug.Name = "lblunjug"
        Me.lblunjug.Size = New System.Drawing.Size(51, 17)
        Me.lblunjug.TabIndex = 6
        Me.lblunjug.Text = "Label1"
        Me.lblunjug.Visible = False
        '
        'lbldosjug
        '
        Me.lbldosjug.AutoSize = True
        Me.lbldosjug.Location = New System.Drawing.Point(1005, 442)
        Me.lbldosjug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldosjug.Name = "lbldosjug"
        Me.lbldosjug.Size = New System.Drawing.Size(51, 17)
        Me.lbldosjug.TabIndex = 7
        Me.lbldosjug.Text = "Label1"
        Me.lbldosjug.Visible = False
        '
        'dgvLector
        '
        Me.dgvLector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvLector.Location = New System.Drawing.Point(208, 320)
        Me.dgvLector.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvLector.Name = "dgvLector"
        Me.dgvLector.RowHeadersWidth = 51
        Me.dgvLector.Size = New System.Drawing.Size(728, 185)
        Me.dgvLector.TabIndex = 11
        Me.dgvLector.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Pregunta"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Respuesta 1"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Respuesta 2"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Respuesta 3"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Respuesta 4"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 705)
        Me.Controls.Add(Me.dgvLector)
        Me.Controls.Add(Me.lbldosjug)
        Me.Controls.Add(Me.lblunjug)
        Me.Controls.Add(Me.gbJugadores)
        Me.Controls.Add(Me.gbtime)
        Me.Controls.Add(Me.pbPintura1)
        Me.Controls.Add(Me.mnsMenuJuego)
        Me.MainMenuStrip = Me.mnsMenuJuego
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmJuego"
        Me.Text = "frmJuego"
        Me.mnsMenuJuego.ResumeLayout(False)
        Me.mnsMenuJuego.PerformLayout()
        Me.gbtime.ResumeLayout(False)
        Me.gbtime.PerformLayout()
        Me.gbJugadores.ResumeLayout(False)
        Me.gbJugadores.PerformLayout()
        CType(Me.pbPintura1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMenuJuego As MenuStrip
    Friend WithEvents pbPintura1 As PictureBox
    Friend WithEvents VolverAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmnsJugador1 As ToolStripMenuItem
    Friend WithEvents tmnsJugador2 As ToolStripMenuItem
    Friend WithEvents PausarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbtime As GroupBox
    Friend WithEvents lblpunto3 As Label
    Friend WithEvents lblpunto2 As Label
    Friend WithEvents lblpunto1 As Label
    Friend WithEvents lblmilisegundo As Label
    Friend WithEvents lblsegundo As Label
    Friend WithEvents lblminuto As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents cronometro As Timer
    Friend WithEvents txtnombre2 As TextBox
    Friend WithEvents txtnombre1 As TextBox
    Friend WithEvents gbJugadores As GroupBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents cmbj2 As ComboBox
    Friend WithEvents cmbj1 As ComboBox
    Friend WithEvents lbljugador2 As Label
    Friend WithEvents lbljugador As Label
    Friend WithEvents ReinicarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblunjug As Label
    Friend WithEvents lbldosjug As Label
    Friend WithEvents dgvLector As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
