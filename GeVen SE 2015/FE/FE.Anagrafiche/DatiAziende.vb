Public Class DatiAziende

    Private Shared Ist As DatiAziende = Nothing
    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Public Shared Function Istanza() As DatiAziende
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New DatiAziende
        End If
        Ist.BringToFront()
        Return Ist
    End Function

    Private Sub AziendeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AziendeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AziendeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)

    End Sub

    Private Sub DatiAziende_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.aziende'. È possibile spostarla o rimuoverla se necessario.
        Me.AziendeTableAdapter.Fill(Me.FatturazionegevenDataSet.aziende)

    End Sub
End Class