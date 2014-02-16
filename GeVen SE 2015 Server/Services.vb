Imports MySql.Data.MySqlClient
Public Class Services
    'Dim mydb As New MySqlDbType
    Dim listaCampiDocumentiDettaglio As New List(Of String)(New String() {"riga", "articolo", "descrizione", _
                                                                          "unitamisuramnagazzino", "quantitamagazzino", _
                                                                          "unitamisura", "quantita", _
                                                                          "prezzounitario", "sconto1", "sconto2", "sconto3", _
                                                                          "importo", "iva", "scorporo", "classemerceologica", _
                                                                         "classecontropartita", "percentoprovvigioni", _
                                                                          "articoloalias", "movimentomagazzino"})
    '
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
        Dim campiSET As New List(Of List(Of String))

        Dim valori As String = Nothing
        Dim valore As String = Nothing
        Dim stringaAppoggio As String = Nothing
        Dim lunghezza As Integer = 0
        Dim numeroOccorrenze As Integer = 0
        Dim totalelunghezzaperCampiValori As Integer = 0
        Try
            lunghezza = InStr(preQuery, ",") 'controllo la prima virgola e ne ricavo l'indice
            totalelunghezzaperCampiValori += lunghezza 'sommo l'indice
            istruzioni = Mid(preQuery, 1, lunghezza - 1) ' recupero il tipo di query select, insert ect
            stringaAppoggio = Mid(preQuery, lunghezza + 1) 'taglio
            lunghezza = InStr(stringaAppoggio, ",") 'ricavo la seconda virgola
            totalelunghezzaperCampiValori += lunghezza 'sommo l'indice
            preTabelle = Mid(stringaAppoggio, 1, lunghezza - 1) 'ricavo eventuali tabelle
            numeroOccorrenze = numOccorrenze(preTabelle, "»", False)
            stringaAppoggio = Nothing
            stringaAppoggio = Mid(preQuery, totalelunghezzaperCampiValori)

            For i = 1 To numeroOccorrenze 'recupero le tabelle

                lunghezza = InStr(preTabelle, "»")
                tabella = Mid(preTabelle, 2, (lunghezza - 2))
                ' tabelle.Add(tabella)
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
                Dim campoValore As New List(Of String)
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
                'serializzarlo campo
                Dim valCampo = serializzatore.ritornacampo(campo)


                If IsNothing(valCampo) Then Throw New NotImplementedException("Non c'è corrispondenza nel database con i/il campi/o selezionato")


                campoValore.Add(valCampo) ' aggiungo il campo
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
                valore = Nothing

                stringaAppoggio = Mid(stringaAppoggio, taglia + 1) 'possibile punto di implementazione per gestire i valori set dell'updATE
                taglia = 0
            Next
            ''''''''''''''''''''''''''''''''''''''''''''''''''''raccolto i valori costruisco la query''''''''''

            If stringaAppoggio.Length > 0 Then

                'to do estraiamo i campi set da mofificare

            End If


            Select Case istruzioni.ToLower

                Case "«select»"

                    Select Case tabella.ToLower

                        Case "gestionedocumenti"

                            query = serializzatore.Query.selectGestioneDocumenti
                            query &= WhereConditionSelect(campiValori, "gestionedocumenti")
                            'eseguo query

                        Case "agentirappresentati"

                            query = serializzatore.Query.selectAgentiRappresentanti
                            query &= WhereConditionSelect(campiValori, "agentirappresentati")

                        Case "anagrafica"

                            query = serializzatore.Query.selectAnagrafica
                            query &= WhereConditionSelect(campiValori)

                        Case "cambiovaluta"

                            query = serializzatore.Query.selectCambioValuta
                            query &= WhereConditionSelect(campiValori)

                        Case "categorieclienti"

                            query = serializzatore.Query.selectCategorieClienti
                            query &= WhereConditionSelect(campiValori)

                        Case "datiaziende"

                            query = serializzatore.Query.selectDatiAziende
                            query &= WhereConditionSelect(campiValori)

                        Case "destinazionemerce"

                            query = serializzatore.Query.selectDestinazioneMerce
                            query &= WhereConditionSelect(campiValori)

                        Case "gestioneannuali"

                            query = serializzatore.Query.selectGestioneAnnuali
                            query &= WhereConditionSelect(campiValori)

                        Case "iva"

                            query = serializzatore.Query.selectIva
                            query &= WhereConditionSelect(campiValori)

                        Case "modalitapagamento"

                            query = serializzatore.Query.selectModalitaPagamento
                            query &= WhereConditionSelect(campiValori, "modalitapagamento")

                        Case "sconti"

                            query = serializzatore.Query.selectSconti
                            query &= WhereConditionSelect(campiValori)

                        Case "spedizionieri"

                            query = serializzatore.Query.selectSpedizionieri
                            query &= WhereConditionSelect(campiValori)

                        Case "tipidocumento"

                            query = serializzatore.Query.selectTipiDocumento
                            query &= WhereConditionSelect(campiValori)

                        Case "zonegeografiche"

                            query = serializzatore.Query.selectZoneGeografiche
                            query &= WhereConditionSelect(campiValori)

                            'Case "selectgestionefatturedocumenti"

                            '    query = serializzatore.Query.selectGestioneFattureDocumenti
                            '    query &= WhereConditionSelect(campiValori)

                        Case "articoli"

                            query = serializzatore.Query.selectArticoli
                            query &= WhereConditionSelect(campiValori, "articoli")

                        Case "classiarticolo"

                            query = serializzatore.Query.selectClassiArticolo
                            query &= WhereConditionSelect(campiValori)

                            'Case "selectgenerazioneinventario"

                            '    query = serializzatore.Query.selectGenerazioneInventario
                            '    query &= WhereConditionSelect(campiValori)

                        Case "listinoarticoli"

                            query = serializzatore.Query.selectListinoArticoli
                            query &= WhereConditionSelect(campiValori)

                        Case "magazzini"

                            query = serializzatore.Query.selectMagazzini
                            query &= WhereConditionSelect(campiValori)

                        Case "movimenti"

                            query = serializzatore.Query.selectMovimentiMagazzino
                            query &= WhereConditionSelect(campiValori, "movimenti")

                        Case "prezziacquisto"

                            query = serializzatore.Query.selectPrezziAcquisto
                            query &= WhereConditionSelect(campiValori)

                    End Select


                Case "«insert»"

                    Select Case tabella.ToLower

                        Case "documenti"

                            query = serializzatore.Query.insertGestioneDocumenti1 'add gestdocu2
                            query &= InsertFieldValues(campiValori)

                        Case "rappresentanti"

                            query = serializzatore.Query.insertAgentiRappresentanti1 'add agerap2
                            query &= InsertFieldValues(campiValori)

                        Case "anagrafica"

                            query = serializzatore.Query.insertAnagrafica
                            query &= InsertFieldValues(campiValori)

                        Case "cambiovaluta"

                            query = serializzatore.Query.insertCambioValuta
                            query &= InsertFieldValues(campiValori)

                        Case "categorieclienti"

                            query = serializzatore.Query.insertCategorieClienti
                            query &= InsertFieldValues(campiValori)

                        Case "datiaziende"

                            query = serializzatore.Query.insertDatiAziende
                            query &= InsertFieldValues(campiValori)

                        Case "destinazionemerce"

                            query = serializzatore.Query.insertDestinazioneMerce
                            query &= InsertFieldValues(campiValori)

                        Case "gestioneannuali"

                            query = serializzatore.Query.insertGestioneAnnuali
                            query &= InsertFieldValues(campiValori)

                        Case "iva"

                            query = serializzatore.Query.insertIva
                            query &= InsertFieldValues(campiValori)

                        Case "modalitapagamento"

                            query = serializzatore.Query.insertModalitaPagamento1 'add 2
                            query &= InsertFieldValues(campiValori)

                        Case "sconti"

                            query = serializzatore.Query.insertSconti
                            query &= InsertFieldValues(campiValori)

                        Case "spedizionieri"

                            query = serializzatore.Query.insertSpedizionieri
                            query &= InsertFieldValues(campiValori)

                        Case "tipidocumento"

                            query = serializzatore.Query.insertTipiDocumento
                            query &= InsertFieldValues(campiValori)

                        Case "zonegeografiche"

                            query = serializzatore.Query.insertZoneGeografiche
                            query &= InsertFieldValues(campiValori)

                        Case "articoli"

                            query = serializzatore.Query.insertArticoli1 'add 2
                            query &= InsertFieldValues(campiValori)

                        Case "classiarticolo"

                            query = serializzatore.Query.insertClassiArticolo
                            query &= InsertFieldValues(campiValori)

                        Case "listinoarticoli"

                            query = serializzatore.Query.insertListinoArticoli
                            query &= InsertFieldValues(campiValori)

                        Case "magazzini"

                            query = serializzatore.Query.insertMagazzini
                            query &= InsertFieldValues(campiValori)

                        Case "movimenti"

                            query = serializzatore.Query.insertMovimentiMagazzino1 'add 2
                            query &= InsertFieldValues(campiValori)

                        Case "prezziacquisto"

                            query = serializzatore.Query.insertPrezziAcquisto
                            query &= InsertFieldValues(campiValori)

                    End Select

                Case "«update»"

                    Select Case tabella.ToLower

                        Case "updatedocumenti"

                            query = serializzatore.Query.updateGestioneDocumenti1 'add 2
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updaterappresentanti"

                            query = serializzatore.Query.updateAgentiRappresentanti1 ' add 2
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updateanagrafica"

                            query = serializzatore.Query.updateAnagrafica
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatecambiovaluta"

                            query = serializzatore.Query.updateCambioValuta
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatecategorieclienti"

                            query = serializzatore.Query.updateCategorieClienti
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatedatiaziende"

                            query = serializzatore.Query.updateDatiAziende
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatedestinazionemerce"

                            query = serializzatore.Query.updateDestinazioneMerce
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updategestioneannuali"

                            query = serializzatore.Query.updateGestioneAnnuali
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updateiva"

                            query = serializzatore.Query.updateIva
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatemodalitapagamento"

                            query = serializzatore.Query.updateModalitaPagamento1 ' add 2
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatesconti"

                            query = serializzatore.Query.updateSconti
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatespedizionieri"

                            query = serializzatore.Query.updateSpedizionieri
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatetipidocumento"

                            query = serializzatore.Query.updateTipiDocumento
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatezonegeografiche"

                            query = serializzatore.Query.updateZoneGeografiche
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatearticoli"

                            query = serializzatore.Query.updateArticoli1 ' add 2
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updateclassiarticolo"

                            query = serializzatore.Query.updateClassiArticolo
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatelistinoarticoli"

                            query = serializzatore.Query.updateListinoArticoli
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatemagazzini"

                            query = serializzatore.Query.updateMagazzini
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updatemovimenti"

                            query = serializzatore.Query.updateMovimentiMagazzino1 ' add 2
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                        Case "updateprezziacquisto"

                            query = serializzatore.Query.updatePrezziAcquisto
                            query &= SetCondition(campiSET)
                            query &= WhereConditionSelect(campiValori)

                    End Select

                Case "«delete»"

                    Select Case tabella.ToLower

                        Case "documenti"

                            query = serializzatore.Query.deleteGestioneDocumenti1 ' add 2
                            query &= WhereConditionSelect(campiValori)

                            query = serializzatore.Query.deleteGestioneDocumenti2 ' add 2
                            query &= WhereConditionSelect(campiValori)

                        Case "rappresentanti"

                            query = serializzatore.Query.deleteAgentiRappresentanti1 ' add 2
                            query &= WhereConditionSelect(campiValori)

                            query = serializzatore.Query.deleteAgentiRappresentanti2 ' add 2
                            query &= WhereConditionSelect(campiValori)

                        Case "anagrafica"

                            query = serializzatore.Query.deleteAnagrafica
                            query &= WhereConditionSelect(campiValori)

                        Case "cambiovaluta"

                            query = serializzatore.Query.deleteCambioValuta
                            query &= WhereConditionSelect(campiValori)

                        Case "categorieclienti"

                            query = serializzatore.Query.deleteCategorieClienti
                            query &= WhereConditionSelect(campiValori)

                        Case "datiaziende"

                            query = serializzatore.Query.deleteDatiAziende
                            query &= WhereConditionSelect(campiValori)

                        Case "destinazionemerce"

                            query = serializzatore.Query.deleteDestinazioneMerce
                            query &= WhereConditionSelect(campiValori)

                        Case "gestioneannuali"

                            query = serializzatore.Query.deleteGestioneAnnuali
                            query &= WhereConditionSelect(campiValori)

                        Case "iva"

                            query = serializzatore.Query.deleteIva
                            query &= WhereConditionSelect(campiValori)

                        Case "modalitapagamento"

                            query = serializzatore.Query.deleteModalitaPagamento1 'add 2
                            query &= WhereConditionSelect(campiValori)

                            query = serializzatore.Query.deleteModalitaPagamento2 'add 2
                            query &= WhereConditionSelect(campiValori)

                        Case "sconti"

                            query = serializzatore.Query.deleteSconti
                            query &= WhereConditionSelect(campiValori)

                        Case "spedizionieri"

                            query = serializzatore.Query.deleteSpedizionieri
                            query &= WhereConditionSelect(campiValori)

                        Case "tipidocumento"

                            query = serializzatore.Query.deleteTipiDocumento
                            query &= WhereConditionSelect(campiValori)

                        Case "zonegeografiche"

                            query = serializzatore.Query.deleteZoneGeografiche
                            query &= WhereConditionSelect(campiValori)

                        Case "articoli"

                            query = serializzatore.Query.deleteArticoli1 'add 2
                            query &= WhereConditionSelect(campiValori)

                            query = serializzatore.Query.deleteArticoli2 'add 2
                            query &= WhereConditionSelect(campiValori)

                        Case "classiarticolo"

                            query = serializzatore.Query.deleteClassiArticolo
                            query &= WhereConditionSelect(campiValori)

                        Case "listinoarticoli"

                            query = serializzatore.Query.deleteListinoArticoli
                            query &= WhereConditionSelect(campiValori)

                        Case "magazzini"

                            query = serializzatore.Query.deleteMagazzini
                            query &= WhereConditionSelect(campiValori)

                        Case "movimenti"

                            query = serializzatore.Query.deleteMovimentiMagazzino1 'add 2
                            query &= WhereConditionSelect(campiValori)

                            query = serializzatore.Query.deleteMovimentiMagazzino2 'add 2
                            query &= WhereConditionSelect(campiValori)

                        Case "prezziacquisto"

                            query = serializzatore.Query.deletePrezziAcquisto
                            query &= WhereConditionSelect(campiValori)

                    End Select

                Case "«print»"
                Case ""
                Case ""
                Case ""
                Case ""

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
            query = Nothing
        End Try

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
    Private Overloads Function WhereConditionSelect(ByVal valore As List(Of List(Of String)))
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

    ''' <summary>
    ''' Restituisce la Where condition comprensiva del prefisso alias delle tabelle davanti ai nomi dei campi.
    ''' </summary>
    ''' <param name="valore"></param>
    ''' <param name="nomeForm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Overloads Function WhereConditionSelect(ByVal valore As List(Of List(Of String)), ByVal nomeForm As String)

        Dim res As String = Nothing

        If valore.Count > 0 Then 'gestiamo l'eventuale where condition

            Select Case nomeForm.ToLower

                Case "gestionedocumenti"

                    res &= "where "

                    Dim qp As Integer = 0
                    For Each campoevalore In valore
                        qp += 1
                        If listaCampiDocumentiDettaglio.Contains(campoevalore(0).ToString) Then ' se incontro campi text e combo

                            res &= "dl." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        Else ' se incontro i campi grid

                            res &= "dt." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        End If

                        If valore.Count = qp Then Exit For
                        res &= " and "
                    Next

                Case "agentirappresentanti"

                    res &= "where "

                    Dim qp As Integer = 0
                    For Each campoevalore In valore
                        qp += 1
                        '    If listaCampiDocumentiDettaglio.Contains(campoevalore(0).ToString) Then ' se incontro campi text e combo

                        '        res &= "ag." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    Else ' se incontro i campi grid

                        '        res &= "ap." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    End If

                        If valore.Count = qp Then Exit For
                        res &= " and "
                    Next

                Case "modalitapagamento"

                    res &= "where "

                    Dim qp As Integer = 0
                    For Each campoevalore In valore
                        qp += 1
                        '    If listaCampiDocumentiDettaglio.Contains(campoevalore(0).ToString) Then ' se incontro campi text e combo

                        '        res &= "ag." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    Else ' se incontro i campi grid

                        '        res &= "ap." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    End If

                        If valore.Count = qp Then Exit For
                        res &= " and "
                    Next

                Case "movimenti"

                    res &= "where "

                    Dim qp As Integer = 0
                    For Each campoevalore In valore
                        qp += 1
                        '    If listaCampiDocumentiDettaglio.Contains(campoevalore(0).ToString) Then ' se incontro campi text e combo

                        '        res &= "ag." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    Else ' se incontro i campi grid

                        '        res &= "ap." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    End If

                        If valore.Count = qp Then Exit For
                        res &= " and "
                    Next

                Case "articoli"

                    res &= "where "

                    Dim qp As Integer = 0
                    For Each campoevalore In valore
                        qp += 1
                        '    If listaCampiDocumentiDettaglio.Contains(campoevalore(0).ToString) Then ' se incontro campi text e combo

                        '        res &= "ag." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    Else ' se incontro i campi grid

                        '        res &= "ap." & campoevalore(0).ToString & " = " & campoevalore(1).ToString

                        '    End If

                        If valore.Count = qp Then Exit For
                        res &= " and "
                    Next


            End Select

        End If

        Return res

    End Function

    ''' <summary>
    ''' ritorna la stringa con i SET per la query update
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetCondition(ByVal listaSet As List(Of List(Of String))) As String

        Dim res As String = Nothing



        Return res

    End Function

    ''' <summary>
    ''' Esegue la query Select
    ''' </summary>
    ''' <param name="quer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EseguiQuery(ByVal quer As String) As DataSet
        Dim DatasetDaRestituire As New DataSet
        Try
            Dim ServerDB As String = My.Settings.serverDB
            Dim user As String = My.Settings.user
            Dim password As String = My.Settings.password
            Dim DB As String = My.Settings.nomeDB


            Dim connectionstring As String = "Server=" & ServerDB & ";User Id=" & user & ";Password=" & password & ";Database=" & DB
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
            Finally
                adapter.Dispose()
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return DatasetDaRestituire

    End Function

    ''' <summary>
    ''' Ritorna la stringa con i valori "SET nomecampo = valore" 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function InsertFieldValues(ByVal valore As List(Of List(Of String))) As String

        Dim res As String = Nothing
        If valore.Count > 0 Then 'gestiamo l'eventuale where condition
            res &= "("
            Dim qp As Integer = 0
            For Each campoevalore In valore
                qp += 1
                res &= campoevalore(0).ToString  ' " = " & campoevalore(1).ToString
                If valore.Count = qp Then
                    res &= ") "
                    Exit For
                End If
                res &= " , "
            Next

            res &= "VALUES ("
            qp = 0
            For Each campoevalore In valore
                qp += 1
                res &= campoevalore(1).ToString  ' " = " & campoevalore(1).ToString
                If valore.Count = qp Then
                    res &= ")"
                    Exit For
                End If
                res &= " , "
            Next

        End If

        Return res

    End Function

End Class
