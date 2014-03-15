Public Class Articolo
    Public Property Articolo As String
        Get
            Return _Articolo
        End Get
        Set(value As String)
            _Articolo = value
        End Set
    End Property
    Private _Articolo As String

    ''' <summary>
    ''' Pulisce l'articolo nell'oggetto articolo
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub clean()
        _Articolo = String.Empty
    End Sub
End Class
