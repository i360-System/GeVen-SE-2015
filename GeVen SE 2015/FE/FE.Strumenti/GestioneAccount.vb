Public Class GestioneAccount
    Private Shared Ist As GestioneAccount = Nothing
    Public Shared Function Istanza() As GestioneAccount
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New GestioneAccount
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

    Private Sub AccountutenteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AccountutenteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AccountutenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FatturazionegevenDataSet)

    End Sub

    Private Sub GestioneAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.accountutente'. È possibile spostarla o rimuoverla se necessario.
        Me.AccountutenteTableAdapter.Fill(Me.FatturazionegevenDataSet.accountutente)

    End Sub
End Class