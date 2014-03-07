Public Class ObjectService

    Public Property VeroFalso As Boolean
        Get
            Return _VeroFalso
        End Get
        Set(value As Boolean)
            _VeroFalso = value
        End Set
    End Property
    Private _VeroFalso As Boolean

    Public Property WhereCondition As String
        Get
            Return _WhereCondition
        End Get
        Set(value As String)
            _WhereCondition = value
        End Set
    End Property
    Private _WhereCondition As String

End Class
