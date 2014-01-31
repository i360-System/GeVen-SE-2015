Public Class InfoClient

    Private _IDclient As New List(Of Integer)
    Public Property IDclient As List(Of Integer)
        Get
            Return _IDclient
        End Get
        Set(value As List(Of Integer))
            _IDclient = value
        End Set
    End Property

End Class
