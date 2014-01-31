Module Module1

    Sub Main()
        CostruttoreQuery("«select»,«gestionedocumenti»,")
    End Sub

    '◄esercizio↨2012►◄datadocumento↨30/01/2012►◄azienda↨0001↨0001►
    Public Function CostruttoreQuery(ByVal preQuery As String) As String

        Dim query As String = Nothing
        Dim istruzioni As String = Nothing
        Dim preTabelle As String = Nothing
        Dim tabella As String = Nothing
        Dim tabelle As New List(Of String)
        Dim campiValori As New List(Of List(Of String))
        Dim campoValore As New List(Of String)
        Dim valori As String = Nothing
        Dim valore As String = Nothing
        Dim stringaAppoggio As String = Nothing
        Dim lunghezza As Integer = 0
        Dim numeroOccorrenze As Integer = 0
        Dim totalelunghezzaperCampiValori As Integer = 0

        lunghezza = InStr(preQuery, ",")
        totalelunghezzaperCampiValori += lunghezza
        istruzioni = Mid(preQuery, 1, lunghezza - 1) ' recupero il tipo di query select, insert ect
        stringaAppoggio = Mid(preQuery, lunghezza + 1)
        lunghezza = InStr(stringaAppoggio, ",")
        totalelunghezzaperCampiValori += lunghezza
        preTabelle = Mid(stringaAppoggio, 1, lunghezza - 1)
        numeroOccorrenze = numOccorrenze(preTabelle, "»", False)
        stringaAppoggio = Nothing
        stringaAppoggio = Mid(preQuery, totalelunghezzaperCampiValori)

        For i = 1 To numeroOccorrenze 'recupero le tabelle

            lunghezza = InStr(preTabelle, "»")
            tabella = Mid(preTabelle, 2, (lunghezza - 2))
            tabelle.Add(tabella)
            If numeroOccorrenze - i = 0 Then Exit For
            preTabelle = Mid(preTabelle, lunghezza)

        Next

        'recuper i campi e i valori
        numeroOccorrenze = numOccorrenze(stringaAppoggio, "►")
        lunghezza = InStr(stringaAppoggio, "►")
        Dim lunghezzaIniziale = lunghezza
        Dim taglia As Integer = 0
        taglia = lunghezza
        For i = 1 To numeroOccorrenze
            Dim campiValoriPuliti As String = Nothing
            campoValore = (New List(Of String))

            If i = 1 Then
                campiValoriPuliti = Mid(stringaAppoggio, 2, lunghezzaIniziale - 1)
            Else
                lunghezza = InStr(stringaAppoggio, "►")
                taglia = lunghezza
                campiValoriPuliti = Mid(stringaAppoggio, 1, lunghezza)
            End If



            lunghezza = InStr(campiValoriPuliti, "↨")
            Dim campo = Mid(campiValoriPuliti, 2, lunghezza - 2)
            campoValore.Add(campo) ' aggiungo il campo

            valori = Mid(campiValoriPuliti, lunghezza + 1)
            numeroOccorrenze = numOccorrenze(valori, "↨")


            For q = 0 To numeroOccorrenze
                If q = numeroOccorrenze Then
                    valore = Left(valori, valori.Length - 1)
                    'lunghezza = valori.Length
                Else
                    lunghezza = InStr(valori, "↨")
                    valore = Mid(valori, 1, lunghezza)
                End If
                'taglia += lunghezza
                campoValore.Add(valore)
                'valori = Mid(valori, lunghezza)
            Next
            campiValori.Add(campoValore)
            stringaAppoggio = Mid(stringaAppoggio, taglia + 1)
            taglia = 0
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''raccolto i valori costruisco la query''''''''''

        Select Case istruzioni

            Case "«select»"

                Select Case tabella

                    Case "gestionedocumenti"

                        query = "Select * from documentitestata as dt inner join documentidettaglio as dl " & _
                    "on dt.documentidettaglioazienda = dl.documentidettaglioazienda " & _
                     "on dt.documentitestataazienda = dl.documentitestataazienda " & _
                     "on dt.esercizio = dl.esercizio " & _
                    "on dt.tipodocumento = dl.tipodocumento " & _
                    "on dt.numerodocumento = dl.numerodocumento "

                        If campiValori.Count > 0 Then 'gestiamo l'eventuale where condition
                            query &= "where "
                            Dim qp As Integer = 0
                            For Each campoevalore In campiValori
                                qp += 1
                                query &= campoevalore(0).ToString & " = " & campoevalore(1).ToString
                                If campiValori.Count = qp Then Exit For
                                query &= " and "
                            Next
                        End If

                    Case "Magazzini"

                End Select


            Case "«insert»"
            Case "«update»"
            Case "«delete»"
            Case "«print»"

        End Select


    End Function
    Public Function numOccorrenze(ByVal myStr As String, ByVal myWord As String, Optional ByVal isCaseSensitive As Boolean = False) As Integer
        '***********************************************************
        ' Func: numOccorrenze
        ' Desc: 
        ' Par : myStr                   Sringa da verificare
        '         myWord                Stringa da recuperare
        '        [isCaseSensitive]    Boolean indicante se voglio il confronto Case Sensitive
        ' Ret :                             Numero di occorrenze di myWord in myStr
        ' Note: mySimbol             E' una stringa contenente l'elenco dei caratteri
        '                                     da ignorare nel confronto, tipo la virgola a fine
        '                                     parola o il punto ecc.
        '***********************************************************

        numOccorrenze = 0
        For i = 0 To myStr.Length - 1

            If myStr(i).CompareTo(myWord(0)) = 0 Then numOccorrenze += 1

        Next

        Return numOccorrenze
    End Function


End Module
