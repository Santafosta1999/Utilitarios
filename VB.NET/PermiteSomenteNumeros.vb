 Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
     If Not Char.IsDigit(e.KeyChar) Then
         e.Handled = True
         If (Asc(e.KeyChar) = 8) Then
             e.Handled = False
         End If
     End If
 End Sub
