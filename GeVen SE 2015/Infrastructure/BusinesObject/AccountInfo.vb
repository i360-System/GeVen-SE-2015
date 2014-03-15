Public Class AccountInfo

    ''' <summary>
    ''' Pulisce l'oggetto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitObject()

        _username = String.Empty
        _password = String.Empty
        _livello = -1
    End Sub

    Public Property username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Private _username As String

    Public Property password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Private _password As String

    Public Property livello As Integer
        Get
            Return _livello
        End Get
        Set(value As Integer)
            _livello = value
        End Set
    End Property
    Private _livello As Integer

    Public Sub New()
        InitObject()
    End Sub

    Public Sub New(ByVal user As String, ByVal pass As String, ByVal lvl As Integer)
        _username = user
        _password = pass
        _livello = lvl
    End Sub
End Class
