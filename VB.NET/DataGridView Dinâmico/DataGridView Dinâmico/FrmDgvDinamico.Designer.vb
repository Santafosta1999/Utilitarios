<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDgvDinamico
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
        Me.DgvDados = New System.Windows.Forms.DataGridView()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtVlrTotal = New System.Windows.Forms.TextBox()
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDados
        '
        Me.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDados.Location = New System.Drawing.Point(18, 18)
        Me.DgvDados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvDados.Name = "DgvDados"
        Me.DgvDados.Size = New System.Drawing.Size(1000, 461)
        Me.DgvDados.TabIndex = 0
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Location = New System.Drawing.Point(18, 542)
        Me.BtnIncluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(222, 55)
        Me.BtnIncluir.TabIndex = 1
        Me.BtnIncluir.Text = "Incluir Linha - F7"
        Me.BtnIncluir.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(302, 542)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(222, 55)
        Me.BtnExcluir.TabIndex = 2
        Me.BtnExcluir.Text = "Excluir Linha - F8"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 484)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(225, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Aprenda mais sobre o VB.NET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(785, 559)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor Total:"
        '
        'TxtVlrTotal
        '
        Me.TxtVlrTotal.Location = New System.Drawing.Point(882, 556)
        Me.TxtVlrTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtVlrTotal.Name = "TxtVlrTotal"
        Me.TxtVlrTotal.Size = New System.Drawing.Size(136, 26)
        Me.TxtVlrTotal.TabIndex = 5
        '
        'FrmDgvDinamico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 611)
        Me.Controls.Add(Me.TxtVlrTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.DgvDados)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDgvDinamico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridView Dinâmico"
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvDados As DataGridView
    Friend WithEvents BtnIncluir As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtVlrTotal As TextBox
End Class
