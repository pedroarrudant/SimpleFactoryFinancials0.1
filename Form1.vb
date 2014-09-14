Public Class Form1
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        'declara variáveis
        Dim custoFabrica As Double
        Dim valorDistribuidor As Double
        Dim valorImpostos As Double
        Dim custoFinal As Double
        'lê custo de fábrica
        custoFabrica = Convert.ToDouble(TxtCustoFabrica.Text)
        'calcula valor distribuidor
        valorDistribuidor = 0.28 * custoFabrica
        'calcula valor dos impostos
        valorImpostos = 0.45 * custoFabrica
        'calcula o custo final
        custoFinal = custoFabrica + valorDistribuidor + valorImpostos
        'exibe o custo final
        TxtValorDistribuidor.Text = valorDistribuidor.ToString("F")
        TxtValorImpostos.Text = valorImpostos.ToString("F")
        TxtCustoFinal.Text = custoFinal.ToString("F")
    End Sub

    Private Sub BtnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpar.Click
        'limpa as caixas de texto
        TxtCustoFabrica.Clear()
        TxtValorDistribuidor.Clear()
        TxtValorImpostos.Clear()
        TxtCustoFinal.Clear()
        'foca na caixa de texto custo fábrica
        TxtCustoFabrica.Focus()
    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        If (MessageBox.Show(Me,
                            "Sair?",
                            "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            End
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show(Me,
                            "Fechar?",
                            "Atenção",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class
