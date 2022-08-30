Public Class Baskara
    Dim baskara As BaskaraClass
    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        If TxtResultado.Text <> String.Empty Then
            Me.LimpaCaixasTexto()
        Else
            baskara = New BaskaraClass(VerificaEquacao(TxtEquacao.Text))
            baskara.PegaVariaveis()
            Me.PreencheCaixasTexto()
            TxtResultado.Text = baskara.CalculaRaizes(baskara.CalculaDelta())
            BtnResultado.Text = "Limpar"
        End If
    End Sub


    Private Sub PreencheCaixasTexto()
        TxtA.Text = baskara.A.ToString()
        TxtB.Text = baskara.B.ToString()
        TxtC.Text = baskara.C.ToString()
        TxtDelta.Text = baskara.CalculaDelta()
    End Sub

    Private Sub LimpaCaixasTexto()
        TxtA.Text = String.Empty
        TxtB.Text = String.Empty
        TxtC.Text = String.Empty
        TxtDelta.Text = String.Empty
        TxtResultado.Text = String.Empty
        BtnResultado.Text = "Resultado"
    End Sub

    Private Function VerificaEquacao(Parcial As String) As String
        If Mid(Parcial, 1, 1) = "X" Or Mid(Parcial, 1, 1) = "x" Then
            Parcial = "1" + Parcial
        End If

        Parcial = Parcial.Replace("+X", "+1X").Replace("-X", "-1X")
        Parcial = Parcial.Replace("+x", "+1x").Replace("-x", "-1x")

        TxtEquacao.Text = Parcial

        Return Parcial
    End Function

    Private Sub TxtEquacao_TextChanged(sender As Object, e As EventArgs) Handles TxtEquacao.TextChanged
        If TxtEquacao.TextLength > 5 Then
            BtnResultado.Enabled = True
        Else
            BtnResultado.Enabled = False
        End If
    End Sub

    Private Sub TxtEquacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEquacao.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If (Asc(e.KeyChar) = 8) Then
                e.Handled = False
            End If
        End If
    End Sub
End Class