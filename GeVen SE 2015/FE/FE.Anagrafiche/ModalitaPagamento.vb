Public Class ModalitaPagamento

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As ModalitaPagamento = Nothing

    Public Shared Function Istanza() As ModalitaPagamento
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New ModalitaPagamento
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class