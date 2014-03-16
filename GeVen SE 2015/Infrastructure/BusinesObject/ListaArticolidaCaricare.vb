Public Class ListaArticolidaCaricare
    Public Property listaDaCaricare As List(Of String)
        Get
            Return _listaDaCaricare
        End Get
        Set(value As List(Of String))
            _listaDaCaricare = value
        End Set
    End Property
    Private _listaDaCaricare As New List(Of String)


    Public Sub pulisceLaLista()

        listaDaCaricare.Clear()

    End Sub
End Class
