Public Class ObjAziendaEsercizioTipoDocumento

    Public Property azienda As String
        Get
            Return _azienda
        End Get
        Set(value As String)
            _azienda = value
        End Set
    End Property
    Private _azienda As String


    Public Property esercizio As String
        Get
            Return _esercizio
        End Get
        Set(value As String)
            _esercizio = value
        End Set
    End Property
    Private _esercizio As String

    Public Property testDocumento As Integer
        Get
            Return _testdocumento
        End Get
        Set(value As Integer)
            _testdocumento = value
        End Set
    End Property
    Private _testdocumento As Integer

    Public Sub New()

        init()

    End Sub

    Public Sub init()
        Me._azienda = Nothing
        Me._esercizio = Nothing
        Me._testdocumento = 0
    End Sub

    'Public Sub New(ByVal valo As String)
    '    _azienda = valo
    'End Sub
End Class
