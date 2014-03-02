Public Class GestioneFattureDocumenti

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As GestioneFattureDocumenti = Nothing

    Public Shared Function Istanza() As GestioneFattureDocumenti
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioneFattureDocumenti
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class

Public Module CampiUpdateGestioneFattureDocumenti

    Public Property nomecampo As List(Of List(Of String))
        Get
            Return _nomecampo
        End Get
        Set(value As List(Of List(Of String)))
            _nomecampo = value
        End Set
    End Property
    Private _nomecampo As New List(Of List(Of String))

    Public Sub init()
        _nomecampo = New List(Of List(Of String))
    End Sub


End Module