Public Class GestioneDocumenti
    Private globalSystemComboBehaviour As Boolean
    Private Shared Ist As GestioneDocumenti = Nothing
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
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)
        globalSystemComboBehaviour = True
    End Sub

    Private Sub GestioneDocumenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.documentidettaglio'. È possibile spostarla o rimuoverla se necessario.
        'Me.DocumentidettaglioTableAdapter.Fill(Me.FatturazionegevenDataSet.documentidettaglio)
        ''TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.documentitestata'. È possibile spostarla o rimuoverla se necessario.
        'Me.DocumentitestataTableAdapter.Fill(Me.FatturazionegevenDataSet.documentitestata)

    End Sub

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        globalSystemComboBehaviour = False
        InitCombo()

    End Sub

    ''' <summary>
    ''' Ricerca nel Dataset e filla i risultati ai controlli sul form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        'ricerca
        Dim FlussodiLavoro As New WorkFlow
        Dim oggettoWhereCondition As New ObjectService : oggettoWhereCondition = FlussodiLavoro.ricerca(Me)
        If oggettoWhereCondition.VeroFalso Then
            DocumentitestataBindingSource.Filter = oggettoWhereCondition.WhereCondition
        End If

        DocumentitestataTableAdapter.Fill(Me.FatturazionegevenDataSet.documentitestata)
        DocumentidettaglioTableAdapter.Fill(Me.FatturazionegevenDataSet.documentidettaglio)
        globalSystemComboBehaviour = True
    End Sub

    ''' <summary>
    ''' Stampa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim flussodiLAvoro As New WorkFlow
        flussodiLAvoro.Print(Me)
        globalSystemComboBehaviour = True
    End Sub

    ''' <summary>
    ''' Inizializa il caricamento delle combobox in determinati stati dell'applicativo,
    ''' inoltre determina il caricamento delle combobox "figlie"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitCombo()
        If Not globalSystemComboBehaviour Then

            Dim servizioApplicazione As New Services
            Dim list1 = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AziendeTableAdapter.GetData()).ToList)
            Dim list2 = servizioApplicazione.ComboDataSource(servizioApplicazione.distinctSelect(AnagraficheTableAdapter1.GetData()).ToList)

            AziendaComboBox.Items.AddRange(list1.ToArray)
            AnagraficaComboBox.Items.AddRange(list2.ToArray)

        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        globalSystemComboBehaviour = True
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        globalSystemComboBehaviour = False
    End Sub

  
   


    Private Sub AziendaComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles AziendaComboBox.SelectionChangeCommitted
        If Not AziendaComboBox.Items(AziendaComboBox.SelectedIndex).ToString = "" Then

            If AziendaComboBox.Items(AziendaComboBox.SelectedIndex).ToString.Length > 4 Then
                AziendaComboBox.Text = Trim(Mid(AziendaComboBox.Items(AziendaComboBox.SelectedIndex).ToString, 1, 4)).ToString
                AziendaComboBox.Refresh()
            End If

        End If
    End Sub
End Class


'************commenti*******
'For Each r In listaSorgente
'    'p.Add()
'Next

'p = AziendeTableAdapter.GetData
'Dim marche = listaSorgente.AsEnumerable().Select(.Field(Of String)("Azienda")).Distinct()
'IEnumarable<string>
