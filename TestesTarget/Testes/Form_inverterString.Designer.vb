<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_inverterString
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
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.btnInverter = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPalavraInvertida = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(91, 65)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(146, 20)
        Me.txtPalavra.TabIndex = 0
        '
        'btnInverter
        '
        Me.btnInverter.Location = New System.Drawing.Point(243, 63)
        Me.btnInverter.Name = "btnInverter"
        Me.btnInverter.Size = New System.Drawing.Size(75, 23)
        Me.btnInverter.TabIndex = 1
        Me.btnInverter.Text = "inverter"
        Me.btnInverter.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(281, 9)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(42, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "X"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(87, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Inverter String"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Palavra:"
        '
        'lblPalavraInvertida
        '
        Me.lblPalavraInvertida.AutoSize = True
        Me.lblPalavraInvertida.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.lblPalavraInvertida.Location = New System.Drawing.Point(22, 105)
        Me.lblPalavraInvertida.Name = "lblPalavraInvertida"
        Me.lblPalavraInvertida.Size = New System.Drawing.Size(126, 20)
        Me.lblPalavraInvertida.TabIndex = 8
        Me.lblPalavraInvertida.Text = "Palavra Invertida"
        '
        'Form_inverterString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 149)
        Me.Controls.Add(Me.lblPalavraInvertida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnInverter)
        Me.Controls.Add(Me.txtPalavra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_inverterString"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_inverterString"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPalavra As TextBox
    Friend WithEvents btnInverter As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPalavraInvertida As Label
End Class
