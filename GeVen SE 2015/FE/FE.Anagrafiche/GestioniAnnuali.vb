Public Class GestioniAnnuali

    Private Shared Ist As GestioniAnnuali = Nothing
    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Public Shared Function Istanza() As GestioniAnnuali
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioniAnnuali
        End If
        Ist.BringToFront()
        Return Ist
    End Function


    Private Sub GestioniAnnuali_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class