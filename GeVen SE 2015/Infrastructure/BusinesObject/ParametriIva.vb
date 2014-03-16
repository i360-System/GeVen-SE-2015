Public Class ParametriIva

    Public Property Descrizione As String
        Get
            Return _descrizione
        End Get
        Set(value As String)
            _descrizione = value
        End Set
    End Property
    Private _descrizione As String

    Public Property AliquotaIva As Single
        Get
            Return _AliquotaIva
        End Get
        Set(value As Single)
            _AliquotaIva = value
        End Set
    End Property
    Private _AliquotaIva As String

End Class
