
Module serializzatore

    Public GlobalObjAccountInfo As AccountInfo = Nothing
    Public globalObjAziendaEsercizioDocumento As New ObjAziendaEsercizioTipoDocumento
    Public globalArticolo As New Articolo
    Public globalObjFillDataGridRow As New objFillDataGridRow
    Public globalListaArticoliDaCaricare As New ListaArticolidaCaricare

    Public globalObjApplication As New AppObjModel
    Dim listaComboGestioneDocumenti As New List(Of String)
    Dim listaTextGestioneDocumenti As New List(Of String)


    ''' <summary>
    ''' Struttura con relative Query
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure comandiInvioClient

#Region "tipoDiQuery"
        Shared sel As String = "«select»"
        Shared inser As String = "«insert»"
        Shared del As String = "«delete»"
        Shared upd As String = "«update»"
        Shared sep As String = ","
#End Region

    End Structure

#Region "Metodi"

    ''' <summary>
    ''' Metodo che pulisce il testo di ogni textbox, combobox, o datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub azzeraTuttiCampi(ByRef frm As Form)

        For Each gruppobox As Object In frm.Controls 'groupbox

            If TypeOf gruppobox Is GroupBox Then
                For Each controllo As Control In gruppobox.Controls
                    If (TypeOf controllo Is TextBox) Or (TypeOf controllo Is ComboBox) Then
                        controllo.Text = Nothing
                    ElseIf (TypeOf controllo Is DataGridView) Then
                        controllo = Nothing
                    End If
                Next
            End If

        Next
    End Sub

    ''' <summary>
    ''' Restituisce la parte destra dopo il carattere speciale ■, dalla combo tipodocumento
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ImpostaTestdocumentoSuOggetto(ByVal str As String) As String

        Dim res As String = String.Empty

        Dim lungh = InStr(str, "■")
        res = Trim(Mid(str, lungh + 1))
        'globalObjAziendaEsercizioDocumento.testDocumento = ret

        Return res

    End Function


    ''' <summary>
    ''' Produce l'output corretto del testo nella combobox
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OutPutComboBox(ByRef cbo As ComboBox)

        If Not Trim(cbo.Text) = "" Then

            Try

                Select Case cbo.Name.ToLower

                    Case "aziendacombobox"

                        If cbo.Text.ToString.Length > 4 Then
                            cbo.Text = Trim(Mid(Trim(cbo.Text.ToString), 1, 4)).ToString
                        End If

                    Case "anagraficacombobox", "tipodocumentocombobox", "agentecombobox", "ivacombobox", "pagamentocombobox", "causaletrasportocombobox", "portocombobox", "aspettobenicombobox", "trasportomezzocombobox", "vettorecombobox", "destinazionecombobox", "eserciziocombobox"

                        If Not IsNumeric(cbo.Text.ToString) Then
                            If InStr(cbo.Text, "-") > 0 Then
                                Dim lunghezza = InStr(cbo.Text, "-")
                                cbo.Text = Trim(Mid(cbo.Items(cbo.SelectedIndex).ToString, 1, lunghezza - 1)).ToString
                            End If
                        End If
                        '1-euro

                    Case "divisacombobox" 'return prima parte stringa - not seconda numeric


                        Dim lunghezza = InStr(cbo.Text, "-")

                        If lunghezza > 0 Then
                            cbo.Text = Trim(Mid(cbo.Items(cbo.SelectedIndex).ToString, 1, lunghezza - 1)).ToString
                        End If


                End Select

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub


    ''' <summary>
    ''' Valorizza una proprieta dell'oggetto globalObjaziendEsercizioDocumento
    ''' </summary>
    ''' <param name="valoreUniversale"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub CaptureforNumDoc(ByVal valoreUniversale As Object, ByVal index As Integer)

        Select Case index
            Case 0 'indice di azienda
                globalObjAziendaEsercizioDocumento.azienda = valoreUniversale
            Case 1 ' esercizio
                globalObjAziendaEsercizioDocumento.esercizio = valoreUniversale
            Case 2 ' testdocumento
                globalObjAziendaEsercizioDocumento.testDocumento = valoreUniversale

        End Select
    End Sub

    ''' <summary>
    ''' Costruttore di preSelect query, imposta la stringa da dare al server, il quale provvederà
    ''' a comporre su istruzione del client, la query select
    ''' </summary>
    ''' <param name="CampiValori"></param>
    ''' <param name="nomeTabella"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function costruttoreDiPreUpdate(ByVal CampiValori As List(Of List(Of String)), ByVal campivaloriSET As List(Of List(Of String)), ByVal nomeTabella As String) As String

        Dim queryPreSelect As String = ""

        queryPreSelect &= comandiInvioClient.upd & comandiInvioClient.sep

        queryPreSelect &= nomeTabella & comandiInvioClient.sep



        For Each lista As List(Of String) In CampiValori
            queryPreSelect &= "◄"
            For Each valore As String In lista
                queryPreSelect &= valore & "↨"
            Next
            queryPreSelect = Left(queryPreSelect, queryPreSelect.Length - 1)
            queryPreSelect &= "►"
        Next

        For Each Lis As List(Of String) In campivaloriSET

            queryPreSelect &= "┌"
            For Each Val As String In Lis
                queryPreSelect &= Val & "█"
            Next
            queryPreSelect = Left(queryPreSelect, queryPreSelect.Length - 1)
            queryPreSelect &= "┘"
        Next


        Return queryPreSelect

    End Function

    ''' <summary>
    ''' Setta i parametri del login nell'oggetto GlobalObjAccountInfo
    ''' </summary>
    ''' <param name="Tabella"></param>
    ''' <remarks></remarks>
    Public Sub GetAccountData(ByVal usr As String, ByVal pass As String, ByVal usrlvl As Integer)

        GlobalObjAccountInfo = New AccountInfo(usr, pass, usrlvl)

    End Sub

    ''' <summary>
    ''' Blocca le combobox
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Sub ComboLocked(ByRef frm As Form)

        Select Case frm.Name.ToLower

            Case "gestionedocumenti"


                With listaComboGestioneDocumenti
                    .AddRange({"aziendacombobox", "eserciziocombobox", "tipodocumentocombobox"})
                End With
                With listaTextGestioneDocumenti
                    .Add("testdocumentotextbox")
                End With

                For Each gruppobox In frm.Controls()

                    If TypeOf gruppobox Is GroupBox Then

                        For Each cont As Object In gruppobox.Controls

                            If (TypeOf cont Is ComboBox) Or (TypeOf cont Is TextBox) Then

                                If listaComboGestioneDocumenti.Contains(cont.name.ToLower) Then

                                    cont.Enabled = False

                                ElseIf listaTextGestioneDocumenti.Contains(cont.name.tolower) Then

                                    cont.ReadOnly = True

                                End If

                            End If



                        Next
                    End If

                Next
                'cbo1.DropDownStyle = ComboBoxStyle.DropDownList
        End Select

    End Sub

    ''' <summary>
    ''' Sblocca le combobox
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Sub comboUnlocked(ByRef frm As Form)

        Select Case frm.Name.ToLower

            Case "gestionedocumenti"


                With listaComboGestioneDocumenti
                    .AddRange({"aziendacombobox", "eserciziocombobox", "tipodocumentocombobox"})
                End With
                With listaTextGestioneDocumenti
                    .Add("testdocumentotextbox")
                End With

                For Each gruppobox In frm.Controls()

                    If TypeOf gruppobox Is GroupBox Then

                        For Each cont As Object In gruppobox.Controls

                            If (TypeOf cont Is ComboBox) Or (TypeOf cont Is TextBox) Then

                                If listaComboGestioneDocumenti.Contains(cont.name.ToLower) Then

                                    cont.Enabled = True

                                ElseIf listaTextGestioneDocumenti.Contains(cont.name.tolower) Then

                                    cont.ReadOnly = False

                                End If

                            End If



                        Next
                    End If

                Next
                'cbo1.DropDownStyle = ComboBoxStyle.DropDownList
        End Select

    End Sub

    ''' <summary>
    ''' popola le combo per destinazione
    ''' </summary>
    ''' <param name="listaControlli"></param>
    ''' <param name="tabella"></param>
    ''' <param name="anag"></param>
    ''' <param name="dest"></param>
    ''' <remarks></remarks>
    Public Sub PopolaCampiDaDestinazione(ByRef listaControlli As List(Of Control), ByVal tabella As DataTable, ByVal anag As Integer, ByVal dest As Integer)

        'Dim seq1 As IEnumerable(Of DataRow) = tabella.AsEnumerable
        Dim servApp As New Services
        Dim ret As EnumerableRowCollection(Of CampiDestinazione) = servApp.distinctSelectDestinazione(tabella, anag, dest)
        'tabella.AsEnumerable.ToList.Count
        If Not IsNothing(ret) Then

            For Each cont In listaControlli

                Select Case cont.Name.ToLower

                    Case "nominativodestinatariotextbox"
                        cont.Text = ret.ElementAt(0).Nominativo
                    Case "indirizzodestinatariotextbox"
                        cont.Text = ret.ElementAt(0).Indirizzo
                    Case "capdestinatariotextbox"
                        cont.Text = ret.ElementAt(0).Cap
                    Case "localitadestinatariotextbox"
                        cont.Text = ret.ElementAt(0).Localita
                    Case "provinciadestinatariotextbox"
                        cont.Text = ret.ElementAt(0).Provincia

                End Select

            Next
        End If
    End Sub

    Public Sub PopolaCampiDaanagrafica(ByRef listaControlli As List(Of Control), ByVal tabella As DataTable, ByVal anag As Integer)

        'Dim seq1 As IEnumerable(Of DataRow) = tabella.AsEnumerable
        Dim servApp As New Services
        Dim ret As EnumerableRowCollection(Of PopolaCampiDaAnagrafica) = servApp.distinctSelectAnagraficaFatturazione(tabella, anag)
        'tabella.AsEnumerable.ToList.Count
        If Not IsNothing(ret) Then

            For Each cont In listaControlli

                Select Case cont.Name.ToLower

                    Case "pagamentocombobox"
                        cont.Text = ret.ElementAt(0).Pagamento
                    Case "agentecombobox"
                        cont.Text = ret.ElementAt(0).Agente
                    Case "ivacombobox"
                        cont.Text = ret.ElementAt(0).Iva
                    Case "bancatextbox"
                        cont.Text = ret.ElementAt(0).Banca
                    Case "agenziatextbox"
                        cont.Text = ret.ElementAt(0).Agenzia

                End Select

            Next
        End If
    End Sub


    ''' <summary>
    ''' Popola la text relativa allo sconto
    ''' </summary>
    ''' <param name="scontoText"></param>
    ''' <param name="tabella"></param>
    ''' <param name="whereValue"></param>
    ''' <remarks></remarks>
    Public Sub PopolaScontoCassa(ByRef scontoText As Control, ByVal tabella As DataTable, ByVal whereValue As Integer)
        Dim servApp As New Services
        Dim ret = servApp.distinctSelect(tabella, whereValue)

        If ret.ToList.Count > 0 Then
            scontoText.Text = ret.ElementAt(0).ToString
        End If



    End Sub

    ''' <summary>
    ''' Cattura l'articolo selezionato
    ''' </summary>
    ''' <param name="str"></param>
    ''' <remarks></remarks>
    Public Sub CaptureArticolo(ByVal str As String)

        globalArticolo.clean()
        globalArticolo.Articolo = RitornaArticoloPulito(str)

    End Sub

    Private Function RitornaArticoloPulito(ByVal str As String) As String
        Dim ret As String = String.Empty

        If InStr(str, "-") > 0 Then
            Dim lungh = InStr(str, "-")
            ret = Mid(str, 1, lungh - 1)
        End If

        Return ret
    End Function

    Public Sub CaptureDataGridRow(ByVal tabella1 As DataTable, ByVal tabella2 As DataTable, ByVal whereCondition As String)

        globalObjFillDataGridRow.Clean()
        Dim servApp As New Services
        Dim ret1 As EnumerableRowCollection(Of ArticoliStrongType) = Nothing
        Dim ret2 As EnumerableRowCollection(Of ArticoliMisure) = Nothing
        ret1 = servApp.distinctSelectArticoliEmisure(tabella1, whereCondition)
        ret2 = servApp.distinctSelectArticoliEmisure(tabella2, whereCondition)

        If (Not IsNothing(ret1)) And (Not IsNothing(ret2)) Then
            If (ret1.ToList.Count > 0) And (ret2.ToList.Count > 0) Then
                globalObjFillDataGridRow.ArticoloAlias = ret1.ElementAt(0).ArticoloAlias
                globalObjFillDataGridRow.ClasseContropartita = ret1.ElementAt(0).ClasseContropartita
                globalObjFillDataGridRow.ClasseMerceologica = ret1.ElementAt(0).ClasseMerceologica
                globalObjFillDataGridRow.Denominazione = ret1.ElementAt(0).Denominazione
                globalObjFillDataGridRow.Iva = ret1.ElementAt(0).Iva
                globalObjFillDataGridRow.Prezzo = ret2.ElementAt(0).PrezzoVendita
                globalObjFillDataGridRow.Scorporo = ret1.ElementAt(0).Scorporo
                globalObjFillDataGridRow.UnitaMisura = ret2.ElementAt(0).UnitaMisura
                globalObjFillDataGridRow.UnitaMisuraMagazzino = ret2.ElementAt(0).UnitaMisura
            End If
        End If

    End Sub

    ''' <summary>
    ''' Carica gli articoli
    ''' </summary>
    ''' <param name="listaArticoli"></param>
    ''' <remarks></remarks>
    Public Sub CaricaArticoli(ByVal listaArticoli As List(Of String))

        globalListaArticoliDaCaricare.pulisceLaLista()
        globalListaArticoliDaCaricare.listaDaCaricare = listaArticoli

    End Sub


    Public Sub MakeConnectionString(ByVal settaCon As Boolean)

        Dim server As String = Nothing
        Dim user As String = Nothing
        Dim password As String = Nothing
        Dim database As String = Nothing
        Dim tipodb As String = My.Settings.tipodb
        Dim cn As String = Nothing

        Select Case tipodb.ToLower
            Case "mysql"
                server = My.Settings.server
                user = My.Settings.user
                password = My.Settings.pass
                database = My.Settings.Database
                'tipodb = My.Settings.tipodb
                cn = "server=" & server & ";" & _
                    "user id=" & user & ";" & _
                    "password=" & password & ";" & _
                    "database=" & database & ";" & _
                    "persistsecurityinfo=True"

                globalObjApplication.CurrentConnectionString = cn

                If settaCon Then
                    My.MySettings.Default.Item("fatturazioneGevenConnectionString") = globalObjApplication.CurrentConnectionString
                    My.MySettings.Default.Save()
                End If


        End Select

    End Sub




#End Region


    Public Structure stampe
        Shared pèippo = ""
    End Structure

    Public Structure Messaggi

        Shared TemplatepercorsononTrovato = "Percorso dei template non impostato."
        Shared templatenonTrovato = "Template non trovato"
        Shared privilegiAccount = "Non si disponde dei privilegi necessari per creare o modificare account."
        Shared userErrato = "Nome utente non corretto."
        Shared passErrata = "Password errata."
        Shared whereLikeNothing = "Non sono stati trovati valori corrispondenti alla ricerca."

    End Structure




End Module
