Public Class Navigatore

    Dim PulsanteCorrente As Byte = Nothing

#Region "click sul navigatore"
    Private Sub inserisci_Click(sender As Object, e As EventArgs) Handles inserisci.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 0
        If genitore.clickMenu(0) Then aggiornaUserControl(0)
    End Sub

    Private Sub ricerca_Click(sender As Object, e As EventArgs) Handles ricerca.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 1
        If genitore.clickMenu(1) Then aggiornaUserControl(1)
    End Sub

    Private Sub cancella_Click(sender As Object, e As EventArgs) Handles cancella.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 2
        If genitore.clickMenu(2) Then aggiornaUserControl(2)
    End Sub

    Private Sub cancellatutto_Click(sender As Object, e As EventArgs) Handles cancellatutto.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 3
        If genitore.clickMenu(3) Then aggiornaUserControl(3)
    End Sub

    Private Sub indietro_Click(sender As Object, e As EventArgs) Handles indietro.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 4
        If genitore.clickMenu(4) Then aggiornaUserControl(4)
    End Sub

    Private Sub avanti_Click(sender As Object, e As EventArgs) Handles avanti.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 5
        If genitore.clickMenu(5) Then aggiornaUserControl(5)
    End Sub

    Private Sub primo_Click(sender As Object, e As EventArgs) Handles primo.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 6
        If genitore.clickMenu(6) Then aggiornaUserControl(6)
    End Sub

    Private Sub ultimo_Click(sender As Object, e As EventArgs) Handles ultimo.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 7
        If genitore.clickMenu(7) Then aggiornaUserControl(7)
    End Sub

    Private Sub annulla_Click(sender As Object, e As EventArgs) Handles annulla.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 8
        If genitore.clickMenu(8) Then aggiornaUserControl(8)
    End Sub

    Private Sub conferma_Click(sender As Object, e As EventArgs) Handles conferma.Click
        Dim genitore As Object = Me.Parent.FindForm
        If genitore.clickMenu(9) Then aggiornaUserControl(9)
    End Sub

    Private Sub esci_Click(sender As Object, e As EventArgs) Handles esci.Click
        Dim genitore As Object = Me.Parent.FindForm
        If genitore.clickMenu(10) Then aggiornaUserControl(10)
    End Sub

    Private Sub stampa_Click(sender As Object, e As EventArgs) Handles stampa.Click
        Dim genitore As Object = Me.Parent.FindForm
        If genitore.clickMenu(11) Then aggiornaUserControl(11)
    End Sub


    Private Sub modifica_Click(sender As Object, e As EventArgs) Handles modifica.Click
        Dim genitore As Object = Me.Parent.FindForm
        PulsanteCorrente = 12
        If genitore.clickMenu(12) Then aggiornaUserControl(12)
    End Sub

#End Region


    Private Sub aggiornaUserControl(ByVal valClick As Byte)

        Select Case valClick
            Case 0 'inserisci

                With Me
                    .inserisci.Enabled = False
                    .ricerca.Enabled = False
                    .annulla.Enabled = True
                    .conferma.Enabled = True
                End With

            Case 1 'ricerca

                With Me
                    .inserisci.Enabled = False
                    .ricerca.Enabled = False
                    .cancella.Enabled = True
                    .cancellatutto.Enabled = True
                    .primo.Enabled = True
                    .ultimo.Enabled = True
                    .annulla.Enabled = True
                    .modifica.Enabled = True
                    .stampa.Enabled = True
                End With

            Case 2 ' cancella

                situazioneInizialeMenu()

            Case 3 'cancellatutto

                situazioneInizialeMenu()

            Case 4, 5, 6, 7 'indietro,primo,ultimo,avanti

                'non succede un cazzo alivello di grafica

            Case 8 'annulla

                situazioneInizialeMenu()

            Case 9 'conferma

                situazioneInizialeMenu()

            Case 10 'esci

                'closeform

            Case 11 'stampa

                situazioneInizialeMenu()

            Case 12 ' modifica

                With Me
                    .inserisci.Enabled = False
                    .ricerca.Enabled = False
                    .modifica.Enabled = False
                    .cancella.Enabled = False
                    .cancellatutto.Enabled = False
                    .indietro.Enabled = False
                    .avanti.Enabled = False
                    .primo.Enabled = False
                    .ultimo.Enabled = False
                    .conferma.Enabled = True
                    .stampa.Enabled = False
                End With

        End Select
    End Sub

    ''' <summary>
    ''' Imposta il menu alla situazione iniziale
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub situazioneInizialeMenu()

        With Me

            'true
            .inserisci.Enabled = True
            .ricerca.Enabled = True
            .esci.Enabled = True

            'false
            .modifica.Enabled = False
            .cancella.Enabled = False
            .cancellatutto.Enabled = False
            .indietro.Enabled = False
            .avanti.Enabled = False
            .primo.Enabled = False
            .ultimo.Enabled = False
            .annulla.Enabled = False
            .conferma.Enabled = False
            .stampa.Enabled = False

        End With

    End Sub

End Class
