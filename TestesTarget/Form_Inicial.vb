Public Class Form_Inicial
    Private Sub btnFibonacci_Click(sender As Object, e As EventArgs) Handles btnFibonacci.Click
        Dim Fibonacci As New Form_Fibonacci
        Fibonacci.ShowDialog()
    End Sub

    Private Sub btnJSON_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        Dim Json As New Form_XML
        Json.ShowDialog()
    End Sub

    Private Sub btnFaturamento_Click(sender As Object, e As EventArgs) Handles btnFaturamento.Click
        Dim faturamento As New Form_FaturamentoMensalEstado
        faturamento.ShowDialog()
    End Sub

    Private Sub btnInverteString_Click(sender As Object, e As EventArgs) Handles btnInverteString.Click
        Dim inverterString As New Form_inverterString
        inverterString.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

End Class
