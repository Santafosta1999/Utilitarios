Public Class BaskaraClass

#Region """PROPRIEDADES"""

    Private Property Equacao As String
    Private AValue As Integer
    Private BValue As Integer
    Private CValue As Integer
    Public ReadOnly Property A As Integer
        Get
            Return AValue
        End Get
    End Property
    Public ReadOnly Property B As Integer
        Get
            Return BValue
        End Get
    End Property
    Public ReadOnly Property C As Integer
        Get
            Return CValue
        End Get
    End Property

#End Region

#Region """CONSTRUTORES"""
    Public Sub New(Eq As String)
        Me.AValue = 0
        Me.BValue = 0
        Me.CValue = 0
        Me.Equacao = Eq
    End Sub

#End Region

#Region """MÉTODOS"""
    Public Sub PegaVariaveis()
        Equacao = Equacao.Replace("=0","")
        Dim separadores As Char() = {"X", "x", "¹", "²", "³"}
        Dim vetor As String() = Equacao.Split(separadores, StringSplitOptions.RemoveEmptyEntries)

        If vetor.Length = 1 Then
            Me.AValue = Convert.ToInt32(vetor(0))
        End If
        If vetor.Length = 2 Then
            Me.AValue = Convert.ToInt32(vetor(0))
            Me.BValue = Convert.ToInt32(vetor(1))
        End If
        If vetor.Length = 3 Then
            Me.AValue = Convert.ToInt32(vetor(0))
            Me.BValue = Convert.ToInt32(vetor(1))
            Me.CValue = Convert.ToInt32(vetor(2))
        End If
    End Sub

    Public Function CalculaDelta() As Integer
        Dim Delta As Integer
        Delta = (Math.Pow(B, 2)) - 4 * A * C

        Return Delta
    End Function

    Private Function RaizReal(Delta As Integer) As Boolean
        If Delta < 0 Then
            Return False
        End If

        Return True
    End Function

    Private Function DuasRaizes(Delta As Integer) As Boolean
        If (Delta = 0) Then
            Return False
        End If

        Return True
    End Function

    Public Function CalculaRaizes(Delta As Integer) As String
        If (RaizReal(Delta)) Then
            Return Resultado(Delta)
        End If
        Return "Delta negativo, não há raiz real!"
    End Function

    Public Function Resultado(Delta As Integer) As String
        Dim X1 As Double = (-B + Math.Sqrt(Delta)) / (2 * A)

        If (DuasRaizes(Delta)) Then
            Dim X2 As Double = (-B - Math.Sqrt(Delta)) / (2 * A)
            Return "X1 = " + X1.ToString() + vbCrLf + "X2 = " + X2.ToString()
        End If
        Return "X = " + X1.ToString()
    End Function
#End Region

End Class
