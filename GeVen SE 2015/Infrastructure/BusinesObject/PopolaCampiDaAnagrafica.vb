Public Class PopolaCampiDaAnagrafica

    Public Property Pagamento As Integer
        Get
            Return _Pagamento
        End Get
        Set(value As Integer)
            _Pagamento = value
        End Set
    End Property
    Private _Pagamento As Integer

    Public Property Agente As Integer
        Get
            Return _Agente
        End Get
        Set(value As Integer)
            _Agente = value
        End Set
    End Property
    Private _Agente As Integer


    Public Property Iva As String
        Get
            Return _Iva
        End Get
        Set(value As String)
            _Iva = value
        End Set
    End Property
    Private _Iva As String


    Public Property Banca As String
        Get
            Return _Banca
        End Get
        Set(value As String)
            _Banca = value
        End Set
    End Property
    Private _Banca As String


    Public Property Agenzia As String
        Get
            Return _Agenzia
        End Get
        Set(value As String)
            _Agenzia = value
        End Set
    End Property
    Private _Agenzia As String



End Class
