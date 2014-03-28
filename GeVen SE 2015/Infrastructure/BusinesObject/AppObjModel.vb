Public Class AppObjModel

    Public Property CurrentConnectionString As String
        Get
            Return _CurrentConnectionString
        End Get
        Set(value As String)
            _CurrentConnectionString = value
        End Set
    End Property
    Private _CurrentConnectionString As String

    Public Sub Init()
        _CurrentConnectionString = String.Empty
    End Sub

End Class
