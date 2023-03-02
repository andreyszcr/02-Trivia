<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.mnsMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.JuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstruccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnsMenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMenuPrincipal
        '
        Me.mnsMenuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnsMenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegoToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.InstruccionesToolStripMenuItem})
        Me.mnsMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenuPrincipal.Name = "mnsMenuPrincipal"
        Me.mnsMenuPrincipal.Size = New System.Drawing.Size(1067, 30)
        Me.mnsMenuPrincipal.TabIndex = 0
        Me.mnsMenuPrincipal.Text = "MenuStrip1"
        '
        'JuegoToolStripMenuItem
        '
        Me.JuegoToolStripMenuItem.Name = "JuegoToolStripMenuItem"
        Me.JuegoToolStripMenuItem.Size = New System.Drawing.Size(66, 26)
        Me.JuegoToolStripMenuItem.Text = "Juego "
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'InstruccionesToolStripMenuItem
        '
        Me.InstruccionesToolStripMenuItem.Name = "InstruccionesToolStripMenuItem"
        Me.InstruccionesToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.InstruccionesToolStripMenuItem.Text = "Instrucciones"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.juegoTrivia.My.Resources.Resources.frmPrincipal1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1067, 524)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnsMenuPrincipal)
        Me.MainMenuStrip = Me.mnsMenuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Princpal"
        Me.mnsMenuPrincipal.ResumeLayout(False)
        Me.mnsMenuPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMenuPrincipal As MenuStrip
    Friend WithEvents JuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InstruccionesToolStripMenuItem As ToolStripMenuItem
End Class
