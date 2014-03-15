Public Class CampiDestinazione


    Public Property Nominativo As String
        Get
            Return _Nominativo
        End Get
        Set(value As String)
            _Nominativo = value
        End Set
    End Property
    Private _Nominativo As String

    Public Property Indirizzo As String
        Get
            Return _Indirizzo
        End Get
        Set(value As String)
            _Indirizzo = value
        End Set
    End Property
    Private _Indirizzo As String

    Public Property Cap As String
        Get
            Return _Cap
        End Get
        Set(value As String)
            _Cap = value
        End Set
    End Property
    Private _Cap As String

    Public Property Localita As String
        Get
            Return _Localita
        End Get
        Set(value As String)
            _Localita = value
        End Set
    End Property
    Private _Localita As String

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property
    Private _Provincia As String

End Class
