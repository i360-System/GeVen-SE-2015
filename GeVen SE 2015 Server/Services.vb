Public Class Services

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
        istruzioni = Mid(preQuery, 1, lunghezza) ' recupero il tipo di query select, insert ect
        stringaAppoggio = Mid(preQuery, lunghezza)
        lunghezza = InStr(stringaAppoggio, ",")
        totalelunghezzaperCampiValori += lunghezza
        preTabelle = Mid(stringaAppoggio, 1, lunghezza)
        numeroOccorrenze = numOccorrenze(preTabelle, "»", False)
        stringaAppoggio = Nothing
        stringaAppoggio = Mid(preQuery, totalelunghezzaperCampiValori)

        For i = 1 To numeroOccorrenze 'recupero le tabelle

            lunghezza = InStr(preTabelle, "»")
            tabella = Mid(preTabelle, 2, lunghezza)
            tabelle.Add(tabella)
            If numeroOccorrenze - i = 0 Then Exit For
            preTabelle = Mid(preTabelle, lunghezza)

        Next

        'recuper i campi e i valori
        numeroOccorrenze = numOccorrenze(stringaAppoggio, "►")
        lunghezza = InStr(stringaAppoggio, "►")
        For i = 1 To numeroOccorrenze
            Dim campiValoriPuliti As String = Nothing

            campiValoriPuliti = Mid(stringaAppoggio, 2, lunghezza)
            lunghezza = InStr(campiValoriPuliti, "↨")
            Dim campo = Mid(campiValoriPuliti, 1, lunghezza)
            campoValore.Add(campo) ' aggiungo il campo
            valori = Mid(campiValoriPuliti, lunghezza)
            numeroOccorrenze = numOccorrenze(valori, "↨")


            For q = 0 To numeroOccorrenze
                If q = numeroOccorrenze Then
                    valore = valori
                Else
                    lunghezza = InStr(valori, "↨")
                    valore = Mid(valori, 1, lunghezza)
                End If

                campoValore.Add(valore)
                valori = Mid(valori, lunghezza)
            Next

        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''raccolto i valori costruisco la query''''''''''


        '''' | con ◄►
        '''' , con ↨



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
        Dim myArray() As String = myStr.Split
        Dim mySimbol As String = "" '",';.: !?"

        numOccorrenze = 0
        For x As Integer = 0 To UBound(myArray)
            'Pulisco l'array dai segni di punteggiatura
            'For y As Integer = 0 To mySimbol.Length - 1
            '    myArray(x) = myArray(x).Replace(mySimbol.Substring(y, 1), "")
            'Next
            'Confronto la stringa
            If isCaseSensitive Then
                If myArray(x).CompareTo(myWord) = 0 Then numOccorrenze += 1
            Else
                If myArray(x).ToUpper.CompareTo(myWord.ToUpper) = 0 Then numOccorrenze += 1
            End If
        Next
        Return numOccorrenze
    End Function

End Class
