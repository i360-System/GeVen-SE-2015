Public Class GestioneDocumenti
    Private Shared Ist As GestioneDocumenti = Nothing

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

    Public Function clickMenu(ByVal valoreClick As Integer) As Boolean

        Dim res As Boolean = False

        Select Case valoreClick

            Case 0 'inserisci

                serializzatore.azzeraTuttiCampi(Me)

            Case 1 'ricerca

                'raccolgo i valori che ho scritto nei campi 
                Dim listaCampiValoriSelect As New List(Of List(Of String))
                listaCampiValoriSelect = serializzatore.raccogliValori(Me)

                'chiamo il server e gli passo i valori della query
                Dim preselect As String = serializzatore.costruttoreDiPreSelect(listaCampiValoriSelect, "«" & Me.Name.ToString & "»")
                Dim obj As Object = Me.ParentForm

                Try
                    obj.senddata(preselect)
                    'If Not IsNothing(obj._Connection) AndAlso obj._Connection.Client.Connected AndAlso obj._Connection.Stream IsNot Nothing Then
                    '    serializzatore.comunica = True
                    '    obj.IstruzioneDBServer(preselect)
                    serializzatore.comunica = False
                    'End Try

                    If serializzatore.comunica Then
                        'if ok then popolo tutti i controlli o un datareader e restituisco true, poi vediamo

                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                    res = False
                End Try

            Case 2 To 12
                Return True
        End Select

        res = serializzatore.comunica
        Return res

    End Function


    ''' <summary>
    ''' autocompletamento su combo/text
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub autoCompletamento()
        Dim arrSource As New AutoCompleteStringCollection

        '-2 perchè l'ultima riga è quella vuota
        For i As Integer = 0 To DataGridView1.RowCount - 2
            arrSource.Add(DataGridView1(0, i).Value.ToString)
            ComboBoxAzienda.Items.Add(DataGridView1(0, i).Value.ToString)
        Next

        'aggiungo agli items e ricevo anche il suggerimento
        'se non devo ordinare gli items posso impostare il DataSource
        'ComboBox1.DataSource=arrSource
        ComboBoxAzienda.Sorted = True
        ComboBoxAzienda.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxAzienda.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxAzienda.SelectedIndex = -1

        'ho solo il suggerimento
        ComboBoxEsercizio.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxEsercizio.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxEsercizio.AutoCompleteCustomSource = arrSource

        'textbox
        TextBoxNumeroDocumento.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBoxNumeroDocumento.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBoxNumeroDocumento.AutoCompleteCustomSource = arrSource
    End Sub

    Private Sub Navigatore1_Load(sender As Object, e As EventArgs)

    End Sub
End Class

Public Class prov



End Class