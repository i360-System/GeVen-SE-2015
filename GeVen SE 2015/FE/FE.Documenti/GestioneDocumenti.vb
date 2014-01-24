Public Class GestioneDocumenti
    Private Shared Ist As GestioneDocumenti = Nothing

    Public Shared Function Istanza() As GestioneDocumenti
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioneDocumenti
        End If
        Ist.BringToFront()
        Return Ist
    End Function
End Class