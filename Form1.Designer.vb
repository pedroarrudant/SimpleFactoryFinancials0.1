<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblCustoFabrica = New System.Windows.Forms.Label()
        Me.LblValorDistribuidor = New System.Windows.Forms.Label()
        Me.LblValorImpostos = New System.Windows.Forms.Label()
        Me.LblCustoFinal = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.TxtCustoFabrica = New System.Windows.Forms.TextBox()
        Me.TxtValorDistribuidor = New System.Windows.Forms.TextBox()
        Me.TxtValorImpostos = New System.Windows.Forms.TextBox()
        Me.TxtCustoFinal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblCustoFabrica
        '
        Me.LblCustoFabrica.AutoSize = True
        Me.LblCustoFabrica.Location = New System.Drawing.Point(16, 13)
        Me.LblCustoFabrica.Name = "LblCustoFabrica"
        Me.LblCustoFabrica.Size = New System.Drawing.Size(90, 13)
        Me.LblCustoFabrica.TabIndex = 0
        Me.LblCustoFabrica.Text = "Custo de Fábrica:"
        '
        'LblValorDistribuidor
        '
        Me.LblValorDistribuidor.AutoSize = True
        Me.LblValorDistribuidor.Location = New System.Drawing.Point(16, 48)
        Me.LblValorDistribuidor.Name = "LblValorDistribuidor"
        Me.LblValorDistribuidor.Size = New System.Drawing.Size(89, 13)
        Me.LblValorDistribuidor.TabIndex = 2
        Me.LblValorDistribuidor.Text = "Valor Distribuidor:"
        '
        'LblValorImpostos
        '
        Me.LblValorImpostos.AutoSize = True
        Me.LblValorImpostos.Location = New System.Drawing.Point(16, 90)
        Me.LblValorImpostos.Name = "LblValorImpostos"
        Me.LblValorImpostos.Size = New System.Drawing.Size(76, 13)
        Me.LblValorImpostos.TabIndex = 4
        Me.LblValorImpostos.Text = "Valor Impostos"
        '
        'LblCustoFinal
        '
        Me.LblCustoFinal.AutoSize = True
        Me.LblCustoFinal.Location = New System.Drawing.Point(16, 131)
        Me.LblCustoFinal.Name = "LblCustoFinal"
        Me.LblCustoFinal.Size = New System.Drawing.Size(62, 13)
        Me.LblCustoFinal.TabIndex = 6
        Me.LblCustoFinal.Text = "Custo Final:"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(16, 169)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(97, 169)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 9
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(178, 169)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 10
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'TxtCustoFabrica
        '
        Me.TxtCustoFabrica.Location = New System.Drawing.Point(112, 10)
        Me.TxtCustoFabrica.Name = "TxtCustoFabrica"
        Me.TxtCustoFabrica.Size = New System.Drawing.Size(141, 20)
        Me.TxtCustoFabrica.TabIndex = 1
        Me.TxtCustoFabrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorDistribuidor
        '
        Me.TxtValorDistribuidor.Enabled = False
        Me.TxtValorDistribuidor.Location = New System.Drawing.Point(112, 45)
        Me.TxtValorDistribuidor.Name = "TxtValorDistribuidor"
        Me.TxtValorDistribuidor.Size = New System.Drawing.Size(141, 20)
        Me.TxtValorDistribuidor.TabIndex = 3
        Me.TxtValorDistribuidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorImpostos
        '
        Me.TxtValorImpostos.Enabled = False
        Me.TxtValorImpostos.Location = New System.Drawing.Point(112, 87)
        Me.TxtValorImpostos.Name = "TxtValorImpostos"
        Me.TxtValorImpostos.Size = New System.Drawing.Size(141, 20)
        Me.TxtValorImpostos.TabIndex = 5
        Me.TxtValorImpostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCustoFinal
        '
        Me.TxtCustoFinal.Location = New System.Drawing.Point(112, 128)
        Me.TxtCustoFinal.Name = "TxtCustoFinal"
        Me.TxtCustoFinal.Size = New System.Drawing.Size(141, 20)
        Me.TxtCustoFinal.TabIndex = 7
        Me.TxtCustoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 207)
        Me.Controls.Add(Me.TxtCustoFinal)
        Me.Controls.Add(Me.TxtValorImpostos)
        Me.Controls.Add(Me.TxtValorDistribuidor)
        Me.Controls.Add(Me.TxtCustoFabrica)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.LblCustoFinal)
        Me.Controls.Add(Me.LblValorImpostos)
        Me.Controls.Add(Me.LblValorDistribuidor)
        Me.Controls.Add(Me.LblCustoFabrica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custo Final de um Carro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCustoFabrica As System.Windows.Forms.Label
    Friend WithEvents LblValorDistribuidor As System.Windows.Forms.Label
    Friend WithEvents LblValorImpostos As System.Windows.Forms.Label
    Friend WithEvents LblCustoFinal As System.Windows.Forms.Label
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents TxtCustoFabrica As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorDistribuidor As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorImpostos As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustoFinal As System.Windows.Forms.TextBox

End Class
