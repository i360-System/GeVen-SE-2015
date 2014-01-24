Public Class ZoneGeografiche

    Private Shared Ist As ZoneGeografiche = Nothing
    Public Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Public Shared Function Istanza() As ZoneGeografiche
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New ZoneGeografiche
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class