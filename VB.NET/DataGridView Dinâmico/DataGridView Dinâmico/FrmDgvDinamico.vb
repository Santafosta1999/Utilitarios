Public Class FrmDgvDinamico
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Call InicializaGrid()

    End Sub

    Private Sub InicializaGrid()
        With DgvDados
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .ReadOnly = False
            '
            'Colunas
            '
            .Columns.Add("PK", "Chave Primária")
            .Columns.Add("ProdutoID", "Produto ID")
            .Columns.Add("ProdutoNome", "Nome do Produto")
            .Columns.Add("Quantidade", "Quantidade")
            .Columns("Quantidade").ValueType = GetType(Integer)
            .Columns.Add("Preco", "Preço Unitário")
            .Columns("Preco").ValueType = GetType(Double)
            .Columns.Add("Total", "Total")
            .Columns("Total").ValueType = GetType(Double)
            '
            'Auto resize em todas as colunas
            '
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            .AutoResizeColumns()
            .Font = New Font(Me.Font, 12)
            '
            'Coluna Total - Somente Leitura
            '
            With .Columns("Total")
                .ReadOnly = True
                .DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
                .DefaultCellStyle.ForeColor = System.Drawing.Color.Red
                .DefaultCellStyle.Font = New Font(Me.Font, FontStyle.Bold)
            End With
            '
            'Estilo do Cabeçalho
            '
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font(Me.Font, 12)
                .Font = New Font(Me.Font, FontStyle.Bold)
            End With
            '
            'Alinha somente as colinas 3 a 5
            '
            For i As Byte = 3 To 5
                'Alinha Cabeçalho
                .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                'Alinha Celula
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
        End With
    End Sub

    Private Sub FrmDgvDinamico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        '
        'Define a caixa de texto somente leitura e limpa o conteúdo
        '
        TxtVlrTotal.ReadOnly = True
        TxtVlrTotal.Clear()
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim Position As Integer = DgvDados.Rows.Count - 1
        Dim PK As Integer = 1
        '
        'Pega o valor da última linha
        '
        Dim UltimaLinha As New DataGridViewRow
        '
        'Tem linhas?
        '
        If Position >= 0 Then
            '
            'Pega as linhas do DataGridView
            '
            UltimaLinha = DgvDados.Rows.OfType(Of DataGridViewRow).Last()
            '
            'Incrementa a PK (Column = 0)
            '
            PK = UltimaLinha.Cells(0).Value + 1
        End If
        '
        'Dados de Exemplo: Chave, Código do Produto, Nome do Produto, Quantidade e Valor
        '
        Dim linha As String() = New String() {PK, "PROD00" & PK, "Produto " & PK, 1, 0.0, 0.0}
        '
        'Adiciona a Linha no Grid
        '
        DgvDados.Rows.Add(linha)
        '
        'Foco na celula da coluna(3) ou quantidade
        '
        DgvDados.CurrentCell = DgvDados.Rows(DgvDados.RowCount - 1).Cells(3)
        DgvDados.Focus()
        '
        'Calcula o total
        '
        Call CalculaSomaTotal()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        '
        'Se não tem linha selecionada então sai da Sub
        '
        If DgvDados.RowCount = 0 Then Exit Sub
        '
        'Remove a linha atual selecionada
        '
        DgvDados.Rows.Remove(DgvDados.CurrentRow)
        DgvDados.Refresh()
        '
        'Se existem linhas calcula a soma
        '
        If DgvDados.RowCount > 0 Then Call CalculaSomaTotal()

    End Sub

    '
    'Calcula a soma total (Coluna Index = 5)
    '
    Private Sub CalculaSomaTotal()
        '
        'Define o valor igual a zero
        '
        TxtVlrTotal.Text = "0.00"
        '
        'Percorre as linhas do grid
        '
        For i As Byte = 0 To DgvDados.RowCount - 1
            '
            'Converte a célula da coluna 5 para Double (usa CDbl ao estilo VB6)
            '
            TxtVlrTotal.Text = CDbl(TxtVlrTotal.Text) + CDbl(DgvDados.Rows(i).Cells(5).Value)
        Next
        '
        'Formata e exibe o valor da soma
        '
        TxtVlrTotal.Text = Format(CDbl(TxtVlrTotal.Text), "#,##0.00")
    End Sub
End Class
