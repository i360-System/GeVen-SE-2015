Public Class AgentiRappresentanti

    Private Shared Ist As AgentiRappresentanti = Nothing
    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Public Shared Function Istanza() As AgentiRappresentanti
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New AgentiRappresentanti
        End If
        Ist.BringToFront()
        Return Ist
    End Function


End Class