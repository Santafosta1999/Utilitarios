<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baskara
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
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEquacao = New System.Windows.Forms.TextBox()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDelta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtA
        '
        Me.TxtA.Enabled = False
        Me.TxtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtA.Location = New System.Drawing.Point(134, 143)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(240, 38)
        Me.TxtA.TabIndex = 0
        '
        'TxtB
        '
        Me.TxtB.Enabled = False
        Me.TxtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtB.Location = New System.Drawing.Point(134, 200)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(240, 38)
        Me.TxtB.TabIndex = 1
        '
        'TxtC
        '
        Me.TxtC.Enabled = False
        Me.TxtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtC.Location = New System.Drawing.Point(134, 257)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(240, 38)
        Me.TxtC.TabIndex = 2
        '
        'TxtResultado
        '
        Me.TxtResultado.Enabled = False
        Me.TxtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultado.Location = New System.Drawing.Point(134, 380)
        Me.TxtResultado.Multiline = True
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtResultado.Size = New System.Drawing.Size(240, 94)
        Me.TxtResultado.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor de a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor de b:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor de c:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Resultado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Equação:"
        '
        'TxtEquacao
        '
        Me.TxtEquacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEquacao.Location = New System.Drawing.Point(134, 10)
        Me.TxtEquacao.Name = "TxtEquacao"
        Me.TxtEquacao.Size = New System.Drawing.Size(240, 38)
        Me.TxtEquacao.TabIndex = 8
        '
        'BtnResultado
        '
        Me.BtnResultado.Enabled = False
        Me.BtnResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResultado.Location = New System.Drawing.Point(18, 67)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(356, 55)
        Me.BtnResultado.TabIndex = 11
        Me.BtnResultado.Text = "Resultado"
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delta:"
        '
        'TxtDelta
        '
        Me.TxtDelta.Enabled = False
        Me.TxtDelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDelta.Location = New System.Drawing.Point(134, 314)
        Me.TxtDelta.Name = "TxtDelta"
        Me.TxtDelta.Size = New System.Drawing.Size(240, 38)
        Me.TxtDelta.TabIndex = 12
        '
        'Baskara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 490)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDelta)
        Me.Controls.Add(Me.BtnResultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEquacao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Name = "Baskara"
        Me.Text = "Báskara"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents TxtC As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEquacao As TextBox
    Friend WithEvents BtnResultado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDelta As TextBox
End Class
