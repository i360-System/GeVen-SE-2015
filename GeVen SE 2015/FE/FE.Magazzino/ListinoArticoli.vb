﻿Public Class ListinoArticoli

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As ListinoArticoli = Nothing
    Public Shared Function Istanza() As ListinoArticoli
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New ListinoArticoli
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class