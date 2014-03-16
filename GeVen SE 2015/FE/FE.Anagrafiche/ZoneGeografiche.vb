Public Class ZoneGeografiche
    Dim globalSystemComboBehaviour As Boolean
    Private Shared Ist As ZoneGeografiche = Nothing
    Public Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Public Shared Function Istanza() As ZoneGeografiche
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New ZoneGeografiche
        End If
        Ist.BringToFront()
        Return Ist
    End Function

    Private Sub ZoneBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ZoneBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZoneBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)

    End Sub

    Private Sub ZoneGeografiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.zone'. È possibile spostarla o rimuoverla se necessario.
        'Me.ZoneTableAdapter.Fill(Me.FatturazionegevenDataSet.zone)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'ricerca
        Dim FlussodiLavoro As New WorkFlow
        Dim oggettoWhereCondition As New ObjectService : oggettoWhereCondition = FlussodiLavoro.ricerca(Me)
        If oggettoWhereCondition.VeroFalso Then
            ZoneBindingSource.RemoveFilter()
            ZoneBindingSource.Filter = oggettoWhereCondition.WhereCondition
        End If

        ZoneTableAdapter.Fill(Me.FatturazionegevenDataSet.zone)
        globalSystemComboBehaviour = True
    End Sub
End Class