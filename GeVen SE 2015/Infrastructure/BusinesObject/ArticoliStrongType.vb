Public Class ArticoliStrongType


    Public Property Denominazione As String
        Get
            Return _Denominazione
        End Get
        Set(value As String)
            _Denominazione = value
        End Set
    End Property
    Private _Denominazione As String

    Public Property Scorporo As String
        Get
            Return _Scorporo
        End Get
        Set(value As String)
            _Scorporo = value
        End Set
    End Property
    Private _Scorporo As String

    Public Property ClasseMerceologica As String
        Get
            Return _ClasseMerceologica
        End Get
        Set(value As String)
            _ClasseMerceologica = value
        End Set
    End Property
    Private _ClasseMerceologica As String

    Public Property ClasseContropartita As String
        Get
            Return _ClasseContropartita
        End Get
        Set(value As String)
            _ClasseContropartita = value
        End Set
    End Property
    Private _ClasseContropartita As String

    Public Property ArticoloAlias As String
        Get
            Return _ArticoloAlias
        End Get
        Set(value As String)
            _ArticoloAlias = value
        End Set
    End Property
    Private _ArticoloAlias As String

    Public Property Iva As String
        Get
            Return _Iva
        End Get
        Set(value As String)
            _Iva = value
        End Set
    End Property
    Private _Iva As String



End Class
