Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
    If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
        DirectCast(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
        DirectCast(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
        DirectCast(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
    End If
End Sub
