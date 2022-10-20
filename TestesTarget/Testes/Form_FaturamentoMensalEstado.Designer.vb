<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_FaturamentoMensalEstado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSP = New System.Windows.Forms.Label()
        Me.lblRj = New System.Windows.Forms.Label()
        Me.lblMg = New System.Windows.Forms.Label()
        Me.lblEs = New System.Windows.Forms.Label()
        Me.lblOutros = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPercentualSP = New System.Windows.Forms.Label()
        Me.lblPercentualRj = New System.Windows.Forms.Label()
        Me.lblPercentualMg = New System.Windows.Forms.Label()
        Me.lblPercentualES = New System.Windows.Forms.Label()
        Me.lblPercentualOutros = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(356, 10)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(42, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "X"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(162, 176)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(38, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Percentual Faturamento Mensal Por estado"
        '
        'lblSP
        '
        Me.lblSP.AutoSize = True
        Me.lblSP.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblSP.Location = New System.Drawing.Point(181, 54)
        Me.lblSP.Name = "lblSP"
        Me.lblSP.Size = New System.Drawing.Size(70, 19)
        Me.lblSP.TabIndex = 7
        Me.lblSP.Text = "67.836,43"
        '
        'lblRj
        '
        Me.lblRj.AutoSize = True
        Me.lblRj.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblRj.Location = New System.Drawing.Point(180, 73)
        Me.lblRj.Name = "lblRj"
        Me.lblRj.Size = New System.Drawing.Size(71, 19)
        Me.lblRj.TabIndex = 8
        Me.lblRj.Text = "36.678,66"
        '
        'lblMg
        '
        Me.lblMg.AutoSize = True
        Me.lblMg.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblMg.Location = New System.Drawing.Point(180, 92)
        Me.lblMg.Name = "lblMg"
        Me.lblMg.Size = New System.Drawing.Size(69, 19)
        Me.lblMg.TabIndex = 9
        Me.lblMg.Text = "29.229,88"
        '
        'lblEs
        '
        Me.lblEs.AutoSize = True
        Me.lblEs.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblEs.Location = New System.Drawing.Point(180, 111)
        Me.lblEs.Name = "lblEs"
        Me.lblEs.Size = New System.Drawing.Size(67, 19)
        Me.lblEs.TabIndex = 10
        Me.lblEs.Text = "27.165,48"
        '
        'lblOutros
        '
        Me.lblOutros.AutoSize = True
        Me.lblOutros.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblOutros.Location = New System.Drawing.Point(179, 130)
        Me.lblOutros.Name = "lblOutros"
        Me.lblOutros.Size = New System.Drawing.Size(68, 19)
        Me.lblOutros.TabIndex = 11
        Me.lblOutros.Text = "19.849,53"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(126, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SP - R$"
        '
        'lblPercentualSP
        '
        Me.lblPercentualSP.AutoSize = True
        Me.lblPercentualSP.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblPercentualSP.Location = New System.Drawing.Point(257, 54)
        Me.lblPercentualSP.Name = "lblPercentualSP"
        Me.lblPercentualSP.Size = New System.Drawing.Size(31, 19)
        Me.lblPercentualSP.TabIndex = 13
        Me.lblPercentualSP.Text = "? %"
        '
        'lblPercentualRj
        '
        Me.lblPercentualRj.AutoSize = True
        Me.lblPercentualRj.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblPercentualRj.Location = New System.Drawing.Point(257, 73)
        Me.lblPercentualRj.Name = "lblPercentualRj"
        Me.lblPercentualRj.Size = New System.Drawing.Size(31, 19)
        Me.lblPercentualRj.TabIndex = 14
        Me.lblPercentualRj.Text = "? %"
        '
        'lblPercentualMg
        '
        Me.lblPercentualMg.AutoSize = True
        Me.lblPercentualMg.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblPercentualMg.Location = New System.Drawing.Point(257, 92)
        Me.lblPercentualMg.Name = "lblPercentualMg"
        Me.lblPercentualMg.Size = New System.Drawing.Size(31, 19)
        Me.lblPercentualMg.TabIndex = 15
        Me.lblPercentualMg.Text = "? %"
        '
        'lblPercentualES
        '
        Me.lblPercentualES.AutoSize = True
        Me.lblPercentualES.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblPercentualES.Location = New System.Drawing.Point(257, 111)
        Me.lblPercentualES.Name = "lblPercentualES"
        Me.lblPercentualES.Size = New System.Drawing.Size(31, 19)
        Me.lblPercentualES.TabIndex = 16
        Me.lblPercentualES.Text = "? %"
        '
        'lblPercentualOutros
        '
        Me.lblPercentualOutros.AutoSize = True
        Me.lblPercentualOutros.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.lblPercentualOutros.Location = New System.Drawing.Point(257, 130)
        Me.lblPercentualOutros.Name = "lblPercentualOutros"
        Me.lblPercentualOutros.Size = New System.Drawing.Size(31, 19)
        Me.lblPercentualOutros.TabIndex = 17
        Me.lblPercentualOutros.Text = "? %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(94, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Outros – R$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(123, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ES – R$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(115, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "MG – R$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Product Sans", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(122, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "RJ – R$"
        '
        'Form_FaturamentoMensalEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 287)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPercentualOutros)
        Me.Controls.Add(Me.lblPercentualES)
        Me.Controls.Add(Me.lblPercentualMg)
        Me.Controls.Add(Me.lblPercentualRj)
        Me.Controls.Add(Me.lblPercentualSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOutros)
        Me.Controls.Add(Me.lblEs)
        Me.Controls.Add(Me.lblMg)
        Me.Controls.Add(Me.lblRj)
        Me.Controls.Add(Me.lblSP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnSair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_FaturamentoMensalEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_FaturamentoMensalEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSair As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSP As Label
    Friend WithEvents lblRj As Label
    Friend WithEvents lblMg As Label
    Friend WithEvents lblEs As Label
    Friend WithEvents lblOutros As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPercentualSP As Label
    Friend WithEvents lblPercentualRj As Label
    Friend WithEvents lblPercentualMg As Label
    Friend WithEvents lblPercentualES As Label
    Friend WithEvents lblPercentualOutros As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
