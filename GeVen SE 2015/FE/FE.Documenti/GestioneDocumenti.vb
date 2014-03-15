Imports System.Windows
Imports System.Collections.ObjectModel

Public Class GestioneDocumenti
    Private globalSystemComboBehaviour As Boolean
    Private Shared Ist As GestioneDocumenti = Nothing
    Public ListaControllidaRiempire As New List(Of Control)
    Public ListaControllidaRiempiredaAnagrafica As New List(Of Control)
    Public listaArticoli As New List(Of String)
    Public Shared Function Istanza() As GestioneDocumenti
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioneDocumenti
        End If
        Ist.BringToFront()
        Return Ist
    End Function

    Private Sub DocumentitestataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DocumentitestataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)

    End Sub


    Private Sub DocumentitestataBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DocumentitestataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DocumentitestataBindingSource.EndEdit()
        'Me.DocumentitestataTableAdapter.Update(Me.FatturazionegevenDataSet.documentitestata)
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)
        globalSystemComboBehaviour = True
    End Sub

    Private Sub GestioneDocumenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.documentidettaglio'. È possibile spostarla o rimuoverla se necessario.
        'Me.DocumentidettaglioTableAdapter.Fill(Me.FatturazionegevenDataSet.documentidettaglio)
        ''TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.documentitestata'. È possibile spostarla o rimuoverla se necessario.
        'Me.DocumentitestataTableAdapter.Fill(Me.FatturazionegevenDataSet.documentitestata)
        ListaControllidaRiempire.Clear()
        ListaControllidaRiempire.AddRange({NominativoDestinatarioTextBox, IndirizzoDestinatarioTextBox, CapDestinatarioTextBox, _
                                                               LocalitaDestinatarioTextBox, ProvinciaDestinatarioTextBox})
        ListaControllidaRiempiredaAnagrafica.Clear()
        ListaControllidaRiempiredaAnagrafica.AddRange({AgenteComboBox, IvaComboBox, PagamentoComboBox, BancaTextBox, AgenziaTextBox})
        'carichiamo gli articoli
        Dim i As New Services
        listaArticoli = i.distinctSelect(ArticoliTableAdapter1.GetData()).ToList()

    End Sub

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        globalSystemComboBehaviour = False ' forsed a mettere nell'evneto load
        InitCombo()

    End Sub

    ''' <summary>
    ''' Ricerca nel Dataset e filla i risultati ai controlli sul form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        globalSystemComboBehaviour = True
        Cursor = Cursors.WaitCursor
        'ricerca
        Dim FlussodiLavoro As New WorkFlow
        Dim oggettoWhereCondition As New ObjectService : oggettoWhereCondition = FlussodiLavoro.ricerca(Me)
        If oggettoWhereCondition.VeroFalso Then
            DocumentitestataBindingSource.RemoveFilter()
            DocumentitestataBindingSource.Filter = oggettoWhereCondition.WhereCondition
        End If
        serializzatore.ComboLocked(Me)
        DocumentidettaglioTableAdapter.Fill(Me.FatturazionegevenDataSet.documentidettaglio)
        DocumentitestataTableAdapter.Fill(Me.FatturazionegevenDataSet.documentitestata)

        'ArticoloComboBoxColumn.DataSource = lis.ToArray
        ''ArticoloComboBoxColumn.DataSource = lis.ToArray
        Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' Stampa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        globalSystemComboBehaviour = False ' da vedere cosa fare
        Dim flussodiLAvoro As New WorkFlow
        flussodiLAvoro.Print(Me)

    End Sub

    ''' <summary>
    ''' Inizializa il caricamento delle combobox in determinati stati dell'applicativo,
    ''' inoltre determina il caricamento delle combobox "figlie"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitCombo()
        If Not globalSystemComboBehaviour Then
            Try
                Dim servizioApplicazione As New Services

                'create list
                Dim listaAziende = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AziendeTableAdapter.GetData()).ToList)
                Dim listAnagrafiche = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AnagraficheTableAdapter1.GetData()).ToList)
                Dim listaTipoDocumento = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(TipidocumentoTableAdapter1.GetData()).ToList)
                Dim listaParametriIva = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(ParametriivaTableAdapter1.GetData()).ToList)
                Dim listaPagamentiTestata = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(PagamentitestataTableAdapter1.GetData()).ToList)
                Dim listaModiTrasporto = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(CausalitrasportoTableAdapter1.GetData()).ToList)
                Dim listaPorto = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(TipitrasportoTableAdapter1.GetData()).ToList)
                Dim listaAspettoBeni = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AspettobeniTableAdapter1.GetData()).ToList)
                Dim listaTrasportoMezzo = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(ModitrasportoTableAdapter1.GetData()).ToList)
                Dim listaVettori = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(VettoriTableAdapter1.GetData()).ToList)
                Dim listaDivise = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(DiviseTableAdapter1.GetData()).ToList)
                'Dim listaDestinazione = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AnagraficadestinazioniTableAdapter1.GetData()).ToList)
                'fill combo
                AziendaComboBox.Items.AddRange(listaAziende.ToArray)
                TipoDocumentoComboBox.Items.AddRange(listaTipoDocumento.ToArray)
                AnagraficaComboBox.Items.AddRange(listAnagrafiche.ToArray)
                AgenteComboBox.Items.AddRange(listAnagrafiche.ToArray)
                IvaComboBox.Items.AddRange(listaParametriIva.ToArray)
                PagamentoComboBox.Items.AddRange(listaPagamentiTestata.ToArray)
                CausaleTrasportoComboBox.Items.AddRange(listaModiTrasporto.ToArray)
                PortoComboBox.Items.AddRange(listaPorto.ToArray)
                AspettoBeniComboBox.Items.AddRange(listaAspettoBeni.ToArray)
                TrasportoMezzoComboBox.Items.AddRange(listaTrasportoMezzo.ToArray)
                VettoreComboBox.Items.AddRange(listaVettori.ToArray)
                DivisaComboBox.Items.AddRange(listaDivise.ToArray)
                'DestinazioneComboBox.Items.AddRange(listaDestinazione.ToArray)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    ''' <summary>
    ''' Inizializza le combo all'inserimento di un nuovo record
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NewInitCombo()

        Dim servizioApplicazione As New Services

        Dim listaTipoDocumento = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(TipidocumentoTableAdapter1.GetData()).ToList)


        TipoDocumentoComboBox.Items.AddRange(listaTipoDocumento.ToArray)

    End Sub


    ''' <summary>
    ''' cancella
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        globalSystemComboBehaviour = False
    End Sub

    ''' <summary>
    ''' Nuovo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        globalSystemComboBehaviour = True
        serializzatore.globalObjAziendaEsercizioDocumento.init()
        serializzatore.comboUnlocked(Me)
        InitCombo()
        'NewInitCombo()
    End Sub

#Region "OutPutCombobox"

    Private Sub AnagraficaComboBox_Validated(sender As Object, e As EventArgs) Handles AnagraficaComboBox.Validated

        If Not Trim(AnagraficaComboBox.Text) = "" Then
            Dim an As String = Trim(AnagraficaComboBox.Text)
            Dim i As New Services
            DestinazioneComboBox.Items.Clear()
            DestinazioneComboBox.Items.AddRange(i.distinctSelect(AnagraficadestinazioniTableAdapter1.GetData(), an).ToArray)
            DestinazioneComboBox.Text = ""
            'compilo i campi sotto anagrafica
            serializzatore.PopolaCampiDaanagrafica(ListaControllidaRiempiredaAnagrafica, AnagraficafatturazioneTableAdapter1.GetData(), an)
            If (Not Trim(PagamentoComboBox.Text) = String.Empty) And (IsNumeric(Trim(PagamentoComboBox.Text))) Then ' se pagamento è pieno valorizzo sconto
                Dim valorePag = Trim(PagamentoComboBox.Text)
                serializzatore.PopolaScontoCassa(ScontoTextBox, PagamentitestataTableAdapter1.GetData(), valorePag)
            End If
        End If

    End Sub

    Private Sub AnagraficaComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnagraficaComboBox.Validating
        serializzatore.OutPutComboBox(AnagraficaComboBox)
    End Sub

    Private Sub AziendaComboBox_Validated(sender As Object, e As EventArgs) Handles AziendaComboBox.Validated
        If Not AziendaComboBox.Text = String.Empty Then
            Dim i As New Services
            EsercizioComboBox.Items.Clear()
            EsercizioComboBox.Items.AddRange(i.distinctSelect(EsercizicontabiliTableAdapter1.GetData(), AziendaComboBox.Text).ToArray)
            EsercizioComboBox.Text = ""
            If globalSystemComboBehaviour Then serializzatore.CaptureforNumDoc(AziendaComboBox.Text, 0)
        End If
    End Sub

    Private Sub AziendaComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AziendaComboBox.Validating

        serializzatore.OutPutComboBox(AziendaComboBox)

    End Sub

    Private Sub TipoDocumentoComboBox_Validated(sender As Object, e As EventArgs) Handles TipoDocumentoComboBox.Validated
        If Not Trim(TipoDocumentoComboBox.Text) = String.Empty Then

            ' se ho l'oggetto completo con i 3 campi allora lancio la query che mi popola il numero di documento
            With serializzatore.globalObjAziendaEsercizioDocumento
                If (Not .azienda = String.Empty) And (Not .esercizio = String.Empty) And ((IsNumeric(.testDocumento)) And (.testDocumento > 0)) Then
                    'call query
                    Dim i As New Services
                    NumeroTextBox.Text = i.GetNumeroDocumento(DocumentitestataTableAdapter.GetData(), .azienda, .esercizio, .testDocumento) + 1

                End If

            End With

        End If

    End Sub

    Private Sub TipoDocumentoComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TipoDocumentoComboBox.Validating
        If Not Trim(TipoDocumentoComboBox.Text) = String.Empty Then

            If InStr(Trim(TipoDocumentoComboBox.Text), "■") > 0 Then
                If globalSystemComboBehaviour Then serializzatore.CaptureforNumDoc(ImpostaTestdocumentoSuOggetto(TipoDocumentoComboBox.Text), 2)
            End If

            serializzatore.OutPutComboBox(TipoDocumentoComboBox)
        End If


    End Sub

    Private Sub AgenteComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AgenteComboBox.Validating
        serializzatore.OutPutComboBox(AgenteComboBox)
    End Sub

    Private Sub IvaComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles IvaComboBox.Validating
        serializzatore.OutPutComboBox(IvaComboBox)
    End Sub

    Private Sub PagamentoComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PagamentoComboBox.Validating
        serializzatore.OutPutComboBox(PagamentoComboBox)
    End Sub

    Private Sub CausaleTrasportoComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CausaleTrasportoComboBox.Validating
        serializzatore.OutPutComboBox(CausaleTrasportoComboBox)
    End Sub

    Private Sub PortoComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PortoComboBox.Validating
        serializzatore.OutPutComboBox(PortoComboBox)
    End Sub

    Private Sub AspettoBeniComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AspettoBeniComboBox.Validating
        serializzatore.OutPutComboBox(AspettoBeniComboBox)
    End Sub

    Private Sub TrasportoMezzoComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TrasportoMezzoComboBox.Validating
        serializzatore.OutPutComboBox(TrasportoMezzoComboBox)
    End Sub

    Private Sub VettoreComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VettoreComboBox.Validating
        serializzatore.OutPutComboBox(VettoreComboBox)
    End Sub

    Private Sub DivisaComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DivisaComboBox.Validating
        serializzatore.OutPutComboBox(DivisaComboBox)
    End Sub

    Private Sub DestinazioneComboBox_Validated(sender As Object, e As EventArgs) Handles DestinazioneComboBox.Validated
        'dopo che il valore è stato pprovto popolo tutti i camnpi in funzione del valore
        If (Not Trim(DestinazioneComboBox.Text) = String.Empty) And (Not Trim(AnagraficaComboBox.Text) = String.Empty) Then
            Dim ana As String = Trim(AnagraficaComboBox.Text) : Dim des As String = Trim(DestinazioneComboBox.Text)
            'call metodo popola campi
            
            serializzatore.PopolaCampiDaDestinazione(ListaControllidaRiempire, AnagraficadestinazioniTableAdapter1.GetData(), ana, des)
        End If

    End Sub

    Private Sub DestinazioneComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DestinazioneComboBox.Validating
        serializzatore.OutPutComboBox(DestinazioneComboBox)
    End Sub

    Private Sub EsercizioComboBox_Validated(sender As Object, e As EventArgs) Handles EsercizioComboBox.Validated
        If Not EsercizioComboBox.Text = String.Empty Then
            If globalSystemComboBehaviour Then serializzatore.CaptureforNumDoc(EsercizioComboBox.Text, 1)
        End If
    End Sub
    Private Sub EsercizioComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EsercizioComboBox.Validating
        serializzatore.OutPutComboBox(EsercizioComboBox)
    End Sub

    ''' <summary>
    ''' Cerca il cliente in funzione del testo inserito
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not Trim(TextBoxLike.Text) = String.Empty Then
            Dim str As String = Trim(TextBoxLike.Text)
            Dim servApp As New Services
            Dim ret = servApp.AnagraficaClienteLike(AnagraficheTableAdapter1.GetData(), str)

            If ret.ToList.Count <= 0 Then 'se non trovo risultati
                MsgBox(serializzatore.Messaggi.whereLikeNothing.ToString)
            Else 'se trovo risultati
                AnagraficaComboBox.Items.Clear()
                AnagraficaComboBox.Items.AddRange(ret.ToList.ToArray)
            End If

        End If

    End Sub

#End Region

    Private Sub DocumentidettaglioDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.CellClick
        'viene chiamato al click del mouse dopo cell enter
    End Sub

    Private Sub DocumentidettaglioDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.CellDoubleClick

    End Sub

    Private Sub DocumentidettaglioDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.CellEndEdit

    End Sub

    Private Sub DocumentidettaglioDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.CellEnter
        'viene chiamata ogniqualvolta si seleziona una cella con qualsiasi metodo o tastiera o mouse
        If DocumentidettaglioDataGridView.CurrentCell.ColumnIndex() = 1 Then
            SelezioneArticolo.listaDaCaricare.Clear() : SelezioneArticolo.listaDaCaricare = listaArticoli
            SelezioneArticolo.ShowDialog()
            If Not serializzatore.globalArticolo.Articolo = String.Empty Then
                DocumentidettaglioDataGridView.CurrentCell.Value = serializzatore.globalArticolo.Articolo.ToString
                'a questo punto carico tutta la riga
            End If
        End If
    End Sub

    Private Sub DocumentidettaglioDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DocumentidettaglioDataGridView.CellMouseClick
        'viene chiamata dopo cell click
    End Sub

  

    Private Sub DocumentidettaglioDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DocumentidettaglioDataGridView.DataError
        MsgBox(e.Exception.ToString)
    End Sub

    Private Sub DocumentidettaglioDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DocumentidettaglioDataGridView.DefaultValuesNeeded
        Dim numrighe As Integer = DocumentidettaglioDataGridView.Rows.Count : Dim valorePiuAlto As Integer = 0

        If numrighe = 1 Then

            DocumentidettaglioDataGridView.Rows.Item(e.Row.Index).Cells(0).Value = 1

        ElseIf numrighe > 1 Then

            For Each righe As DataGridViewRow In DocumentidettaglioDataGridView.Rows

                If (Not IsNothing(righe.Cells(0).Value)) And (righe.Cells(0).Value > valorePiuAlto) Then 'se il valore corrente è piu alto di quello precedentemente memorizzato lo catturo
                    valorePiuAlto = righe.Cells(0).Value
                End If

            Next
            valorePiuAlto += 1 'incremento il valore pi alto
            DocumentidettaglioDataGridView.Rows.Item(e.Row.Index).Cells(0).Value = valorePiuAlto
        End If
    End Sub

    Private Sub DocumentidettaglioDataGridView_NewRowNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DocumentidettaglioDataGridView.NewRowNeeded

    End Sub

   

    Private Sub DocumentidettaglioDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.RowEnter
        
        'Dim s As String = "ciao"
        'DocumentidettaglioDataGridView.CurrentRow.Cells(2).Value = s.ToArrayDocumentidettaglioDataGridView.CurrentRow.Cells("ArticoloComboBoxColumn")
    End Sub

    Private Sub DocumentidettaglioDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DocumentidettaglioDataGridView.RowsAdded

      

    End Sub

    Private Sub DocumentidettaglioDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DocumentidettaglioDataGridView.RowStateChanged

    End Sub

    Private Sub DocumentidettaglioDataGridView_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentidettaglioDataGridView.RowValidated

    End Sub

    Private Sub DocumentidettaglioDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DocumentidettaglioDataGridView.RowValidating

    End Sub

    Private Sub DocumentidettaglioDataGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DocumentidettaglioDataGridView.UserAddedRow
      
    End Sub
End Class



Namespace WpfCombo

    '/// <summary>
    '/// Interaction logic for MainWindow.xaml
    '/// </summary>
    Partial Public Class Parziale


        Private cities As New ObservableCollection(Of AziendaDenominazione)
        'cities = new ObservableCollection

        Public Sub Elab(ByRef cbo As ComboBox, ByVal objData1 As List(Of String), ByVal ObjData2 As List(Of String))

            If (objData1.Count = ObjData2.Count) And (objData1.Count > 0) Then

                Dim numero = objData1.Count

                For i = 1 To numero

                    cities.Add(New AziendaDenominazione() With {.azienda = objData1.Item(i - 1).ToString, .denominazione1 = ObjData2.Item(i - 1).ToString})
                    cbo.Items.Add(cities.Item(i - 1))

                Next

            End If

        End Sub

    End Class


    Public Class AziendaDenominazione

        Public Property azienda As String
            Get
                Return _azienda
            End Get
            Set(value As String)
                _azienda = value
            End Set
        End Property
        Private _azienda As String


        Public Property denominazione1 As String
            Get
                Return _denominazione1
            End Get
            Set(value As String)
                _denominazione1 = value
            End Set
        End Property
        Private _denominazione1 As String

    End Class



End Namespace