Public Class EsportazioneAnagrafiche

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As EsportazioneAnagrafiche = Nothing
    Public Shared Function Istanza() As EsportazioneAnagrafiche
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New EsportazioneAnagrafiche
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class