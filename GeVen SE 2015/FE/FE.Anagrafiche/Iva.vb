﻿Public Class Iva

    Private Shared Ist As Iva = Nothing
    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Public Shared Function Istanza() As Iva
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New Iva
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class