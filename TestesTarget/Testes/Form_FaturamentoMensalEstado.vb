Public Class Form_FaturamentoMensalEstado
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim dict As New Dictionary(Of String, Decimal)
        dict.Add("SP", CDec(lblSP.Text))
        dict.Add("RJ", CDec(lblRj.Text))
        dict.Add("MG", CDec(lblMg.Text))
        dict.Add("ES", CDec(lblEs.Text))
        dict.Add("Outros", CDec(lblOutros.Text))

        Dim total As Decimal
        For Each item In dict
            total += item.Value
        Next

        For Each item In dict

            If item.Key = "SP" Then
                Dim valorSP = item.Value
                Dim percentual = Math.Round((valorSP * 100) / total, 2)
                lblPercentualSP.Text = percentual.ToString + " %"
            End If

            If item.Key = "RJ" Then
                Dim valorRJ = item.Value
                Dim percentual = Math.Round((valorRJ * 100) / total, 2)
                lblPercentualRj.Text = percentual.ToString + " %"
            End If

            If item.Key = "MG" Then
                Dim valorMG = item.Value
                Dim percentual = Math.Round((valorMG * 100) / total, 2)
                lblPercentualMg.Text = percentual.ToString + " %"
            End If

            If item.Key = "ES" Then
                Dim valorES = item.Value
                Dim percentual = Math.Round((valorES * 100) / total, 2)
                lblPercentualES.Text = percentual.ToString + " %"
            End If

            If item.Key = "Outros" Then
                Dim valorOutros = item.Value
                Dim percentual = Math.Round((valorOutros * 100) / total, 2)
                lblPercentualOutros.Text = percentual.ToString + " %"
            End If

        Next

    End Sub

End Class