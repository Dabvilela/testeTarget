<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_XML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCaminho = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnMenorValor = New System.Windows.Forms.Button()
        Me.btnMaiorValor = New System.Windows.Forms.Button()
        Me.btnNumeroDiasMaiorMedia = New System.Windows.Forms.Button()
        Me.lblResposta = New System.Windows.Forms.Label()
        Me.btnLerXML = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCaminho
        '
        Me.txtCaminho.Location = New System.Drawing.Point(74, 51)
        Me.txtCaminho.Name = "txtCaminho"
        Me.txtCaminho.Size = New System.Drawing.Size(351, 20)
        Me.txtCaminho.TabIndex = 0
        Me.txtCaminho.Text = "C:\dados.xml"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Caminho:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lendo Dados de um  XML e comparando "
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(446, 6)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(42, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "X"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnMenorValor
        '
        Me.btnMenorValor.Location = New System.Drawing.Point(71, 77)
        Me.btnMenorValor.Name = "btnMenorValor"
        Me.btnMenorValor.Size = New System.Drawing.Size(74, 23)
        Me.btnMenorValor.TabIndex = 4
        Me.btnMenorValor.Text = "Menor Valor"
        Me.btnMenorValor.UseVisualStyleBackColor = True
        '
        'btnMaiorValor
        '
        Me.btnMaiorValor.Location = New System.Drawing.Point(148, 77)
        Me.btnMaiorValor.Name = "btnMaiorValor"
        Me.btnMaiorValor.Size = New System.Drawing.Size(74, 23)
        Me.btnMaiorValor.TabIndex = 5
        Me.btnMaiorValor.Text = "Maior Valor"
        Me.btnMaiorValor.UseVisualStyleBackColor = True
        '
        'btnNumeroDiasMaiorMedia
        '
        Me.btnNumeroDiasMaiorMedia.Location = New System.Drawing.Point(225, 77)
        Me.btnNumeroDiasMaiorMedia.Name = "btnNumeroDiasMaiorMedia"
        Me.btnNumeroDiasMaiorMedia.Size = New System.Drawing.Size(202, 23)
        Me.btnNumeroDiasMaiorMedia.TabIndex = 6
        Me.btnNumeroDiasMaiorMedia.Text = "Numero de dias faturamento > media"
        Me.btnNumeroDiasMaiorMedia.UseVisualStyleBackColor = True
        '
        'lblResposta
        '
        Me.lblResposta.AutoSize = True
        Me.lblResposta.Location = New System.Drawing.Point(11, 118)
        Me.lblResposta.Name = "lblResposta"
        Me.lblResposta.Size = New System.Drawing.Size(52, 13)
        Me.lblResposta.TabIndex = 7
        Me.lblResposta.Text = "Resposta"
        '
        'btnLerXML
        '
        Me.btnLerXML.Location = New System.Drawing.Point(427, 50)
        Me.btnLerXML.Name = "btnLerXML"
        Me.btnLerXML.Size = New System.Drawing.Size(68, 23)
        Me.btnLerXML.TabIndex = 8
        Me.btnLerXML.Text = "Ler XML"
        Me.btnLerXML.UseVisualStyleBackColor = True
        '
        'Form_XML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 309)
        Me.Controls.Add(Me.btnLerXML)
        Me.Controls.Add(Me.lblResposta)
        Me.Controls.Add(Me.btnNumeroDiasMaiorMedia)
        Me.Controls.Add(Me.btnMaiorValor)
        Me.Controls.Add(Me.btnMenorValor)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCaminho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_XML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_JSON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCaminho As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents btnMenorValor As Button
    Friend WithEvents btnMaiorValor As Button
    Friend WithEvents btnNumeroDiasMaiorMedia As Button
    Friend WithEvents lblResposta As Label
    Friend WithEvents btnLerXML As Button
End Class
