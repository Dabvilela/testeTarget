<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Inicial
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
        Me.btnFibonacci = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnInverteString = New System.Windows.Forms.Button()
        Me.btnFaturamento = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFibonacci
        '
        Me.btnFibonacci.Location = New System.Drawing.Point(39, 48)
        Me.btnFibonacci.Name = "btnFibonacci"
        Me.btnFibonacci.Size = New System.Drawing.Size(150, 50)
        Me.btnFibonacci.TabIndex = 0
        Me.btnFibonacci.Text = "2. Fibonacci"
        Me.btnFibonacci.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.Location = New System.Drawing.Point(39, 104)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(150, 43)
        Me.btnXML.TabIndex = 1
        Me.btnXML.Text = "3. XML"
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'btnInverteString
        '
        Me.btnInverteString.Location = New System.Drawing.Point(39, 203)
        Me.btnInverteString.Name = "btnInverteString"
        Me.btnInverteString.Size = New System.Drawing.Size(150, 43)
        Me.btnInverteString.TabIndex = 2
        Me.btnInverteString.Text = "5. Inverter String"
        Me.btnInverteString.UseVisualStyleBackColor = True
        '
        'btnFaturamento
        '
        Me.btnFaturamento.Location = New System.Drawing.Point(39, 153)
        Me.btnFaturamento.Name = "btnFaturamento"
        Me.btnFaturamento.Size = New System.Drawing.Size(150, 43)
        Me.btnFaturamento.TabIndex = 3
        Me.btnFaturamento.Text = "4. Faturamento Mensal"
        Me.btnFaturamento.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(208, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(42, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "X"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(84, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Teste"
        '
        'Form_Inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnFaturamento)
        Me.Controls.Add(Me.btnInverteString)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.btnFibonacci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_inicial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFibonacci As Button
    Friend WithEvents btnXML As Button
    Friend WithEvents btnInverteString As Button
    Friend WithEvents btnFaturamento As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents Label1 As Label
End Class
