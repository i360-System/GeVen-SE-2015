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