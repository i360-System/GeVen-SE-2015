Public Class EsportazioneFatture

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As EsportazioneFatture = Nothing
    Public Shared Function Istanza() As EsportazioneFatture
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New EsportazioneFatture
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class