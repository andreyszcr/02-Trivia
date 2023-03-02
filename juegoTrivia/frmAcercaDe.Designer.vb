<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbprogramadores = New System.Windows.Forms.Label()
        Me.LbNombre3 = New System.Windows.Forms.Label()
        Me.LbNombre2 = New System.Windows.Forms.Label()
        Me.LbNombre1 = New System.Windows.Forms.Label()
        Me.lbentorno = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.Lbfecha = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(426, 362)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(92, 28)
        Me.btnvolver.TabIndex = 1
        Me.btnvolver.Text = "Volver al menu"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.juegoTrivia.My.Resources.Resources.frmAcercaDe
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 414)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbprogramadores
        '
        Me.lbprogramadores.AutoSize = True
        Me.lbprogramadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbprogramadores.Location = New System.Drawing.Point(34, 59)
        Me.lbprogramadores.Name = "lbprogramadores"
        Me.lbprogramadores.Size = New System.Drawing.Size(106, 16)
        Me.lbprogramadores.TabIndex = 2
        Me.lbprogramadores.Text = "Programadores:"
        '
        'LbNombre3
        '
        Me.LbNombre3.AutoSize = True
        Me.LbNombre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre3.Location = New System.Drawing.Point(77, 160)
        Me.LbNombre3.Name = "LbNombre3"
        Me.LbNombre3.Size = New System.Drawing.Size(100, 16)
        Me.LbNombre3.TabIndex = 3
        Me.LbNombre3.Text = "Maikol Navarro"
        '
        'LbNombre2
        '
        Me.LbNombre2.AutoSize = True
        Me.LbNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre2.Location = New System.Drawing.Point(77, 126)
        Me.LbNombre2.Name = "LbNombre2"
        Me.LbNombre2.Size = New System.Drawing.Size(89, 16)
        Me.LbNombre2.TabIndex = 4
        Me.LbNombre2.Text = "Junior Monge"
        '
        'LbNombre1
        '
        Me.LbNombre1.AutoSize = True
        Me.LbNombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre1.Location = New System.Drawing.Point(77, 98)
        Me.LbNombre1.Name = "LbNombre1"
        Me.LbNombre1.Size = New System.Drawing.Size(106, 16)
        Me.LbNombre1.TabIndex = 5
        Me.LbNombre1.Text = "Andrey Sanchez"
        '
        'lbentorno
        '
        Me.lbentorno.AutoSize = True
        Me.lbentorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbentorno.Location = New System.Drawing.Point(31, 198)
        Me.lbentorno.Name = "lbentorno"
        Me.lbentorno.Size = New System.Drawing.Size(109, 16)
        Me.lbentorno.TabIndex = 6
        Me.lbentorno.Text = "Visual Basic .Net"
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.Location = New System.Drawing.Point(77, 227)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(108, 16)
        Me.lbVersion.TabIndex = 7
        Me.lbVersion.Text = "Version: 16.02.05"
        '
        'Lbfecha
        '
        Me.Lbfecha.AutoSize = True
        Me.Lbfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfecha.Location = New System.Drawing.Point(41, 260)
        Me.Lbfecha.Name = "Lbfecha"
        Me.Lbfecha.Size = New System.Drawing.Size(122, 16)
        Me.Lbfecha.TabIndex = 8
        Me.Lbfecha.Text = "Fecha: 21/Oct/2019"
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 414)
        Me.Controls.Add(Me.Lbfecha)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.lbentorno)
        Me.Controls.Add(Me.LbNombre1)
        Me.Controls.Add(Me.LbNombre2)
        Me.Controls.Add(Me.LbNombre3)
        Me.Controls.Add(Me.lbprogramadores)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAcercaDe"
        Me.Text = "frmAcercaDe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnvolver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbprogramadores As Label
    Friend WithEvents LbNombre3 As Label
    Friend WithEvents LbNombre2 As Label
    Friend WithEvents LbNombre1 As Label
    Friend WithEvents lbentorno As Label
    Friend WithEvents lbVersion As Label
    Friend WithEvents Lbfecha As Label
End Class
