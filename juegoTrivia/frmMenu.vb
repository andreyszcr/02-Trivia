Public Class frmMenuPrincipal
    Private Sub JuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegoToolStripMenuItem.Click
        'validacion de datos 
        Try
            'se muestra la pantalla del juego 
            frmJuego.Show()

            'se econde el menu principal 
            Me.Hide()
        Catch ex As Exception
            'en caso de error muestra una pantalla
            MessageBox.Show(ex.Message, "Error para cargar pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Variable de tipo windows form 
        Try
            Dim pantallaDatos As New frmAcercaDe

            'acciones que se generan en programa 
            With pantallaDatos
                'esconde el menu principal 
                Me.Hide()

                'muestra el programa donde esta el juego 
                pantallaDatos.Show()
            End With
        Catch ex As Exception
            'en caso de error muestra una pantalla
            MessageBox.Show(ex.Message, "Error para cargar pantalla", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'validacion de datos 
        Try

            End
        Catch ex As Exception
            'en caso de error muestra un mensaje al salir la patanlla
            MsgBox(ex.Message, "Error de datos")
        End Try
    End Sub

    Private Sub InstruccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstruccionesToolStripMenuItem.Click
        frmInstrucciones.Show()

    End Sub


End Class
