Imports MySql.Data.MySqlClient
Public Class Services
    'Dim mydb As New MySqlDbType
    ''' <summary>
    '''Costruisce la Query e la restituisce 
    ''' </summary>
    ''' <param name="preQuery"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

        'recupero i campi e i valori
        numeroOccorrenze = numOccorrenze(stringaAppoggio, "►")
        lunghezza = InStr(stringaAppoggio, "►")
        Dim lunghezzaIniziale = lunghezza
        Dim taglia As Integer = 0
        taglia = lunghezza
        For i = 1 To numeroOccorrenze
            Dim campiValoriPuliti As String = Nothing

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

        Select Case istruzioni.ToLower

            Case "«select»"

                Select Case tabella.ToLower

                    Case "gestionedocumenti"

                        query = serializzatore.Query.selectGestioneDocumenti
                        query &= WhereConditionSelect(campiValori)
                        'eseguo query

                    Case "agentirappresentati"

                        query = serializzatore.Query.selectAgentiRappresentanti
                        query &= WhereConditionSelect(campiValori)

                    Case "selectanagrafica"

                        query = serializzatore.Query.selectAnagrafica
                        query &= WhereConditionSelect(campiValori)

                    Case "selectcambiovaluta"

                        query = serializzatore.Query.selectCambioValuta
                        query &= WhereConditionSelect(campiValori)

                    Case "selectcategorieclienti"

                        query = serializzatore.Query.selectCategorieClienti
                        query &= WhereConditionSelect(campiValori)

                    Case "selectdatiaziende"

                        query = serializzatore.Query.selectDatiAziende
                        query &= WhereConditionSelect(campiValori)

                    Case "selectdestinazionemerce"

                        query = serializzatore.Query.selectDestinazioneMerce
                        query &= WhereConditionSelect(campiValori)

                    Case "selectgestioneannuali"

                        query = serializzatore.Query.selectGestioneAnnuali
                        query &= WhereConditionSelect(campiValori)

                    Case "selectiva"

                        query = serializzatore.Query.selectIva
                        query &= WhereConditionSelect(campiValori)

                    Case "selectmodalitapagamento"

                        query = serializzatore.Query.selectModalitaPagamento
                        query &= WhereConditionSelect(campiValori)

                    Case "selectsconti"

                        query = serializzatore.Query.selectSconti
                        query &= WhereConditionSelect(campiValori)

                    Case "selectspedizionieri"

                        query = serializzatore.Query.selectSpedizionieri
                        query &= WhereConditionSelect(campiValori)

                    Case "selecttipidocumento"

                        query = serializzatore.Query.selectTipiDocumento
                        query &= WhereConditionSelect(campiValori)

                    Case "selectzonegeografiche"

                        query = serializzatore.Query.selectZoneGeografiche
                        query &= WhereConditionSelect(campiValori)

                    Case "selectgestionefatturedocumenti"

                        query = serializzatore.Query.selectGestioneFattureDocumenti
                        query &= WhereConditionSelect(campiValori)

                    Case "selectarticoli"

                        query = serializzatore.Query.selectArticoli
                        query &= WhereConditionSelect(campiValori)

                    Case "selectclassiarticolo"

                        query = serializzatore.Query.selectClassiArticolo
                        query &= WhereConditionSelect(campiValori)

                    Case "selectgenerazioneinventario"

                        query = serializzatore.Query.selectGenerazioneInventario
                        query &= WhereConditionSelect(campiValori)

                    Case "selectlistinoarticoli"

                        query = serializzatore.Query.selectListinoArticoli
                        query &= WhereConditionSelect(campiValori)

                    Case "selectmagazzini"

                        query = serializzatore.Query.selectMagazzini
                        query &= WhereConditionSelect(campiValori)

                    Case "selectmovimenti"

                        query = serializzatore.Query.selectMovimenti
                        query &= WhereConditionSelect(campiValori)

                    Case "selectprezziacquisto"

                        query = serializzatore.Query.selectPrezziAcquisto
                        query &= WhereConditionSelect(campiValori)

                End Select


            Case "«insert»"

                Select Case tabella.ToLower

                End Select

            Case "«update»"

                Select Case tabella.ToLower

                End Select

            Case "«delete»"

                Select Case tabella.ToLower

                End Select

            Case "«print»"

                'todo

        End Select

        Return query

    End Function

    ''' <summary>
    ''' Calcola le occorrenze di un carattere dentro ad una stringa
    ''' </summary>
    ''' <param name="myStr"></param>
    ''' <param name="myWord"></param>
    ''' <param name="isCaseSensitive"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function numOccorrenze(ByVal myStr As String, ByVal myWord As String, Optional ByVal isCaseSensitive As Boolean = False) As Integer
        numOccorrenze = 0
        For i = 0 To myStr.Length - 1

            If myStr(i).CompareTo(myWord(0)) = 0 Then numOccorrenze += 1

        Next

        Return numOccorrenze
    End Function

    ''' <summary>
    ''' Restituisce la where condition della select
    ''' </summary>
    ''' <param name="valore"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function WhereConditionSelect(ByVal valore As List(Of List(Of String)))
        Dim res As String = Nothing
        If valore.Count > 0 Then 'gestiamo l'eventuale where condition
            res &= "where "
            Dim qp As Integer = 0
            For Each campoevalore In valore
                qp += 1
                res &= campoevalore(0).ToString & " = " & campoevalore(1).ToString
                If valore.Count = qp Then Exit For
                res &= " and "
            Next
        End If
        Return res
    End Function

    Public Function EseguiQuery(ByVal quer As String) As DataSet
        Dim DatasetDaRestituire As New DataSet
        Try
            Dim ServerDB As String = My.Settings.serverDB
            Dim user As String = My.Settings.user
            Dim password As String = My.Settings.password
            Dim DB As String = My.Settings.nomeDB

            Dim connectionstring As String = "Server=" & ServerDB & ";User Id=" & user & ";Password=" & password & ";Database=data"
            Dim commandtext As String
            Dim adapter As MySqlDataAdapter
            Dim table As DataTable
            commandtext = quer '"select * from account where user=admin"
            Try
                adapter = New MySqlDataAdapter(commandtext, connectionstring)
                table = New DataTable
                adapter.Fill(table)

                'incollo dataset
                adapter.Fill(DatasetDaRestituire)

                'DataGridView1.DataSource = table '##########(but instead of datagrid put the data in a textbox Put the id in the textbox )#######
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Catch ex As Exception

        End Try

    End Function

End Class
