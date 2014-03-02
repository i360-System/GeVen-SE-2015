Public Class GestioneDocumenti
    Private Shared Ist As GestioneDocumenti = Nothing
    'Dim modi As Byte = 100 'identifica l'ambito in cui siamo, ricerca,modifica etc etc

    Public Shared Function Istanza() As GestioneDocumenti
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioneDocumenti
        End If
        Ist.BringToFront()
        Return Ist
    End Function

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    '    Public Function clickMenu(ByVal valoreClick As Integer) As Boolean

    '        Dim res As Boolean = False


    '        Select Case valoreClick

    '            Case 0 'inserisci

    '                serializzatore.azzeraTuttiCampi(Me)
    '                modi = 0

    '            Case 1 'ricerca

    '                modi = 1
    '                'raccolgo i valori che ho scritto nei campi 
    '                Dim listaCampiValoriSelect As New List(Of List(Of String))
    '                Dim c As New Services
    '                listaCampiValoriSelect = c.raccogliValori(Me)

    '                'chiamo il server e gli passo i valori della query
    '                Dim preselect As String = serializzatore.costruttoreDiPreSelect(listaCampiValoriSelect, "«" & Me.Name.ToString & "»")
    '                Dim obj As Object = Me.ParentForm

    '                Try
    '                    obj.senddata(preselect)
    '                    'If Not IsNothing(obj._Connection) AndAlso obj._Connection.Client.Connected AndAlso obj._Connection.Stream IsNot Nothing Then
    '                    '    serializzatore.comunica = True
    '                    '    obj.IstruzioneDBServer(preselect)
    '                    serializzatore.comunica = False
    '                    'End Try

    '                    If serializzatore.comunica Then
    '                        'if ok then popolo tutti i controlli o un datareader e restituisco true, poi vediamo
    '                    End If

    '                Catch ex As Exception
    '                    MsgBox(ex.ToString)
    '                    res = False
    '                End Try
    '                Return res

    '            Case 2 'modifica

    '                modi = 2
    '                CampiUpdate.init()
    '                'sblocco caselle?
    '                'se ne ho procedo, altrimenti avverto il client


    '            Case 10 'conferma

    '                Select Case modi

    '                    Case 2 'modifica

    '                        If CampiUpdate.nomecampo.Count > 0 Then
    '                            Try
    '                                Dim listaCampiValoriSelect, listaesclusi, listaCampiValoriupdate As New List(Of List(Of String))
    '                                Dim c As New Services

    '                                listaesclusi = CampiUpdate.nomecampo
    '                                listaCampiValoriSelect = c.raccogliValori(Me, listaesclusi)
    '                                Dim preupd As String = serializzatore.costruttoreDiPreUpdate(listaCampiValoriSelect, listaesclusi, "«" & Me.Name.ToString & "»")
    '                                Dim obj As Object = Me.ParentForm
    '                                'spara al wcf
    '                                'iif ok return true
    '                                'res = true
    '                            Catch ex As Exception
    '                                MsgBox(ex.ToString)
    '                            Finally
    '                                CampiUpdate.init()
    '                            End Try
    '                        Else
    '                            MsgBox("Non è stato modificato nessun valore.")
    '                            res = False
    '                        End If

    '                    Case 0 'inserisci


    '                End Select

    '        End Select

    '        'res = serializzatore.comunica
    '        Return res

    '    End Function


    '    ''' <summary>
    '    ''' autocompletamento su combo/text
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Private Sub autoCompletamento()
    '        Dim arrSource As New AutoCompleteStringCollection

    '        '-2 perchè l'ultima riga è quella vuota
    '        For i As Integer = 0 To DataGridView1.RowCount - 2
    '            arrSource.Add(DataGridView1(0, i).Value.ToString)
    '            ComboBoxAzienda.Items.Add(DataGridView1(0, i).Value.ToString)
    '        Next

    '        'aggiungo agli items e ricevo anche il suggerimento
    '        'se non devo ordinare gli items posso impostare il DataSource
    '        'ComboBox1.DataSource=arrSource
    '        ComboBoxAzienda.Sorted = True
    '        ComboBoxAzienda.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '        ComboBoxAzienda.AutoCompleteSource = AutoCompleteSource.ListItems
    '        ComboBoxAzienda.SelectedIndex = -1

    '        'ho solo il suggerimento
    '        ComboBoxEsercizio.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '        ComboBoxEsercizio.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        ComboBoxEsercizio.AutoCompleteCustomSource = arrSource

    '        'textbox
    '        TextBoxNumeroDocumento.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '        TextBoxNumeroDocumento.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        TextBoxNumeroDocumento.AutoCompleteCustomSource = arrSource
    '    End Sub



    '#Region "captureSetValue"



    '    Private Function Condizioni() As Boolean

    '        Dim res As Boolean = False

    '        If Navigatore1.modifica.Enabled = True And Navigatore1.ricerca.Enabled = False And Navigatore1.inserisci.Enabled = False And modi = 2 Then
    '            res = True
    '        End If

    '        Return res

    '    Private Sub ComboBoxAgente_Validated(sender As Object, e As EventArgs) Handles ComboBoxAgente.Validated
    '        If Not Condizioni() Then Exit Sub
    '        Dim p As New List(Of String) : p.AddRange({ComboBoxAgente.Name, ComboBoxAgente.Text.ToString})
    '        CampiUpdate.nomecampo.Add(p)
    '    End Sub

    '#End Region

    Private Sub DocumentitestataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DocumentitestataBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DocumentitestataBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.FatturazionegevenDataSet1)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub

    Private Sub GestioneDocumenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

   
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim servizioApplicazione As New Services
        Dim where As String = servizioApplicazione.WhereConditionSelect(servizioApplicazione.raccogliValori(Me))

        If Not IsNothing(where) Then
            Me.DocumentitestataBindingSource.Filter = where
        End If
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet1.documentitestata'. È possibile spostarla o rimuoverla se necessario.
        Me.DocumentitestataTableAdapter1.Fill(Me.FatturazionegevenDataSet1.documentitestata)
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet1.documentidettaglio'. È possibile spostarla o rimuoverla se necessario.
        Me.DocumentidettaglioTableAdapter.Fill(Me.FatturazionegevenDataSet1.documentidettaglio)


    End Sub

End Class

'Public Module CampiUpdate

'    Public Property nomecampo As List(Of List(Of String))
'        Get
'            Return _nomecampo
'        End Get
'        Set(value As List(Of List(Of String)))
'            _nomecampo = value
'        End Set
'    End Property
'    Private _nomecampo As New List(Of List(Of String))

'    Public Sub init()
'        _nomecampo = New List(Of List(Of String))
'    End Sub


'End Module