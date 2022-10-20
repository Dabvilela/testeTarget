Public Class Form_inverterString
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnInverter_Click(sender As Object, e As EventArgs) Handles btnInverter.Click

        If Not String.IsNullOrWhiteSpace(txtPalavra.Text) Then

            Dim palavra = txtPalavra.Text
            Dim tamanhoPalavra = palavra.Length - 1
            Dim palavraInvertida As String = ""

            For Each letra In palavra
                palavraInvertida += palavra(tamanhoPalavra)
                tamanhoPalavra -= 1
            Next

            lblPalavraInvertida.Text = $"A palavra é {palavra} {vbCrLf}A palavra invertida é igual a {palavraInvertida}"
        End If

    End Sub
End Class