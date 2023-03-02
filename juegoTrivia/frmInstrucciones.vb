Public Class frmInstrucciones
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        'validacion de datos 
        Try
            'variable de tipo windows form
            Dim menu As New frmMenuPrincipal

            With menu
                'esconde el menu de juego 
                Me.Hide()

                'vuelve al menu principal
                menu.Show()
            End With
        Catch ex As Exception

        End Try


    End Sub


End Class