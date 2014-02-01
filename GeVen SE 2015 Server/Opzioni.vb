Public Class Opzioni

#Region "Bottoni"
    ''' <summary>
    ''' Esci
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Salva
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SalvaOpzioni()
    End Sub

    Private Sub SalvaOpzioni()

        My.Settings.serverDB = Trim(TextBoxServerDB.Text.ToString)
        My.Settings.user = Trim(TextBoxUser.Text.ToString)
        My.Settings.password = Trim(TextBoxPassword.Text.ToString)
        My.Settings.nomeDB = Trim(TextBoxNomeDB.Text.ToString)
        My.Settings.porta = Trim(TextBoxPorta.Text.ToString)
        My.Settings.Save()

    End Sub

    ''' <summary>
    ''' Salva & Esci
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SalvaOpzioni()
        Me.Dispose()
    End Sub
#End Region

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().


        caricaOpzioni()


    End Sub

    Private Sub caricaOpzioni()
        TextBoxServerDB.Text = My.Settings.serverDB
        TextBoxUser.Text = My.Settings.user
        TextBoxPassword.Text = My.Settings.password
        CheckBoxCredenziali.Checked = My.Settings.credenziali
        TextBoxNomeDB.Text = My.Settings.nomeDB
        TextBoxPorta.Text = My.Settings.porta
        If CheckBoxCredenziali.Checked = False Then
            TextBoxUser.Enabled = False
            TextBoxPassword.Enabled = Enabled
        End If
    End Sub

    Private Shared Ist As Opzioni = Nothing

    Public Shared Function Istanza() As Opzioni
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New Opzioni
        End If
        Ist.BringToFront()
        Return Ist
    End Function

End Class