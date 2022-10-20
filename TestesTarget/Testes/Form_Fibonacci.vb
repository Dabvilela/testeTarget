Public Class Form_Fibonacci
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        If NumeroExisteNaSequencia() Then
            lblResposta.ForeColor = Color.Green
            lblResposta.Text = $"O numero {txtNumero.Text} contém na sequência de Fibonacci."
        Else
            lblResposta.ForeColor = Color.Red
            lblResposta.Text = $"O numero {txtNumero.Text} não contém na sequência de Fibonacci."
        End If

    End Sub

    Private Function NumeroExisteNaSequencia() As Boolean

        Dim valorDigitado As Integer = If(IsNumeric(txtNumero.Text), txtNumero.Text, 1)
        Dim primeiroNumero As Integer = 0
        Dim segundoNumero As Integer = 1

        While segundoNumero <= valorDigitado

            Dim numeroTemporario = primeiroNumero
            primeiroNumero = segundoNumero
            segundoNumero += numeroTemporario

            If segundoNumero = valorDigitado Then
                Return True
            End If

        End While

        Return False

    End Function

    Private Sub txtNumero_MouseLeave(sender As Object, e As EventArgs) Handles txtNumero.MouseLeave

        If Not IsNumeric(txtNumero.Text) Then
            sender.text = 1
            Exit Sub
        End If

    End Sub
End Class