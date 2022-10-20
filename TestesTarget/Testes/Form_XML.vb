Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form_XML

    Private Property listaFaturamento As New List(Of FaturamentoMensal)
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnLerXML_Click(sender As Object, e As EventArgs) Handles btnLerXML.Click

        listaFaturamento.Clear()
        Dim caminho As String = txtCaminho.Text

        Dim reader = New StreamReader(txtCaminho.Text)
        Dim strBuffer = reader.ReadToEnd

        Dim document As New XmlDocument
        document.LoadXml(strBuffer)

        For index = 0 To 29
            Dim FaturamentoMensal As New FaturamentoMensal
            FaturamentoMensal.Valor = document.GetElementsByTagName("valor").Item(index).InnerText.Replace(".", ",")
            FaturamentoMensal.Dia = document.GetElementsByTagName("dia").Item(index).InnerText.Replace(".", ",")
            listaFaturamento.Add(FaturamentoMensal)
        Next

    End Sub

    Private Sub btnMenorValor_Click(sender As Object, e As EventArgs) Handles btnMenorValor.Click

        If listaFaturamento.Count <= 0 Then
            btnLerXML.PerformClick()
        End If

        Dim diaComMenorValor = listaFaturamento.Select(Function(i) i).Where(Function(i) i.Valor > 0).OrderBy(Function(i) i.Valor).First
        lblResposta.Text = $"O menor valor foi {FormatCurrency(diaComMenorValor.Valor)} no Dia: {diaComMenorValor.Dia}"

    End Sub

    Private Sub btnMaiorValor_Click(sender As Object, e As EventArgs) Handles btnMaiorValor.Click

        If listaFaturamento.Count <= 0 Then
            btnLerXML.PerformClick()
        End If

        Dim diaCommaiorValor = listaFaturamento.Select(Function(i) i).Where(Function(i) i.Valor > 0).OrderByDescending(Function(i) i.Valor).First
        lblResposta.Text = $"O maior valor foi {FormatCurrency(diaCommaiorValor.Valor)} no Dia: {diaCommaiorValor.Dia}"

    End Sub

    Private Sub btnNumeroDiasMaiorMedia_Click(sender As Object, e As EventArgs) Handles btnNumeroDiasMaiorMedia.Click

        If listaFaturamento.Count <= 0 Then
            btnLerXML.PerformClick()
        End If

        Dim diasComfaturamento = listaFaturamento.Select(Function(i) i).Where(Function(i) i.Valor > 0).ToList

        Dim MediaFaturamentoMes = Math.Round(calculoMedia(diasComfaturamento), 4)

        Dim diasComFaturamentoMaiorQueMedia = diasComfaturamento.Select(Function(i) i).Where(Function(i) i.Valor > MediaFaturamentoMes).ToList

        lblResposta.Text = $"A quantidade de dias com o faturammeto maior que a media foram {diasComFaturamentoMaiorQueMedia.Count},"
        lblResposta.Text += $"{vbCrLf}O valor medio foi {MediaFaturamentoMes}, os valores e dias foram:"

        For Each item In diasComFaturamentoMaiorQueMedia
            lblResposta.Text += $"{vbCrLf}Resposta: O valor foi {FormatCurrency(item.Valor)} no Dia: {item.Dia}"
        Next

    End Sub

    Private Function calculoMedia(diasComfaturamento As List(Of FaturamentoMensal)) As Decimal

        Dim mediaFaturamentoSemDiasZerados As Decimal
        For Each item In diasComfaturamento
            mediaFaturamentoSemDiasZerados += item.Valor
        Next

        Return mediaFaturamentoSemDiasZerados / diasComfaturamento.Count

    End Function
End Class

Class FaturamentoMensal

    Public Property Valor As Double
    Public Property Dia As Integer

End Class