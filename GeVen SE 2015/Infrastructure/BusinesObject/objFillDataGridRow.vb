Public Class objFillDataGridRow

    Public Property Denominazione As String
        Get
            Return _Denominazione
        End Get
        Set(value As String)
            _Denominazione = value
        End Set
    End Property
    Private _Denominazione As String

    Public Property UnitaMisura As String
        Get
            Return _UnitaMisura
        End Get
        Set(value As String)
            _UnitaMisura = value
        End Set
    End Property
    Private _UnitaMisura As String


    Public Property UnitaMisuraMagazzino As String
        Get
            Return _UnitaMisuraMagazzino
        End Get
        Set(value As String)
            _UnitaMisuraMagazzino = value
        End Set
    End Property
    Private _UnitaMisuraMagazzino

    Public Property Prezzo As Double
        Get
            Return _Prezzo
        End Get
        Set(value As Double)
            _Prezzo = value
        End Set
    End Property
    Private _Prezzo As Double

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

    Public Sub Clean()
        _ArticoloAlias = String.Empty
        _ClasseContropartita = String.Empty
        _ClasseMerceologica = String.Empty
        _Denominazione = String.Empty
        _Iva = String.Empty
        _Prezzo = 0.0
        _Scorporo = String.Empty
        _UnitaMisura = String.Empty
        _UnitaMisuraMagazzino = String.Empty
    End Sub


End Class
