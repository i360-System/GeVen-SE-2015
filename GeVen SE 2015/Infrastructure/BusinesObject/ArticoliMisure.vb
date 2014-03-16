Public Class ArticoliMisure

   

    Public Property UnitaMisura As String
        Get
            Return _UnitaMisura
        End Get
        Set(value As String)
            _UnitaMisura = value
        End Set
    End Property
    Private _UnitaMisura As String


    Public Property PrezzoVendita As Double
        Get
            Return _PrezzoVendita
        End Get
        Set(value As Double)
            _PrezzoVendita = value
        End Set
    End Property
    Private _PrezzoVendita As Double



End Class
