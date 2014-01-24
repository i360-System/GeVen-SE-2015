Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Crea una nuova istanza del form figlio.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Imposta il form come figlio di questo form MDI prima di visualizzarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Finestra " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private m_ChildFormNumber As Integer

#Region "menù"

#Region "File"

    ''' <summary>
    ''' Termina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub TerminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminaToolStripMenuItem.Click
        If MsgBox("Vuoi terminare il programma? Tutti i form aperti verranno chiusi.", MsgBoxStyle.YesNo, "Confermare uscita?") = MsgBoxResult.Yes Then
            For Each chdForm As Form In Me.MdiChildren
                chdForm.Dispose()
            Next
            Me.Close()
            Me.Dispose()
        End If
    End Sub

#End Region

#Region "Documenti"

    Private Sub ArchivioDocumentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivioDocumentiToolStripMenuItem.Click
        Dim NewMDIChild As GestioneDocumenti
        NewMDIChild = GestioneDocumenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


    Private Sub GenerazioneFattureDaDcoumentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerazioneFattureDaDcoumentiToolStripMenuItem.Click
        Dim NewMDIChild As GestioneFattureDocumenti
        NewMDIChild = GestioneFattureDocumenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


#End Region

#Region "Anagrafiche"

    ''' <summary>
    ''' Apre Categoria Clienti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CategorieClientiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieClientiToolStripMenuItem.Click

        Dim NewMDIChild As CategorieClienti
        NewMDIChild = CategorieClienti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre ZoneGeografiche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ZoneGeograficheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoneGeograficheToolStripMenuItem.Click
        Dim NewMDIChild As ZoneGeografiche
        NewMDIChild = ZoneGeografiche.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre GestioniAnnuali
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GestioniAnnualiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestioniAnnualiToolStripMenuItem.Click
        Dim NewMDIChild As GestioniAnnuali
        NewMDIChild = GestioniAnnuali.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre AgentiRappresentanti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AgentiRappresentantiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentiRappresentantiToolStripMenuItem.Click

        Dim NewMDIChild As AgentiRappresentanti
        NewMDIChild = AgentiRappresentanti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre DatiAzienda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DatiAziendeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatiAziendeToolStripMenuItem.Click
        Dim NewMDIChild As DatiAziende
        NewMDIChild = DatiAziende.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Cambio Valuta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CambioValutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioValutaToolStripMenuItem.Click
        Dim NewMDIChild As CambioValuta
        NewMDIChild = CambioValuta.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    '''Apre Spedizionieri e Corrieri 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SpedizionieriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpedizionieriToolStripMenuItem.Click
        Dim NewMDIChild As Spedizionieri
        NewMDIChild = Spedizionieri.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre il form Modalita di Pagamento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ModalitàPagamentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalitàPagamentiToolStripMenuItem.Click

        Dim NewMDIChild As ModalitaPagamento
        NewMDIChild = ModalitaPagamento.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre Iva
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub IvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvaToolStripMenuItem.Click
        Dim NewMDIChild As Iva
        NewMDIChild = Iva.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre tipidocumento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TipiDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiDocumentoToolStripMenuItem.Click
        Dim NewMDIChild As TipiDocumento
        NewMDIChild = TipiDocumento.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Anagrafica clienti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AnagraficaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnagraficaToolStripMenuItem.Click
        Dim NewMDIChild As Anagrafica
        NewMDIChild = Anagrafica.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre sconti.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ScontiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScontiToolStripMenuItem.Click
        Dim NewMDIChild As Sconti
        NewMDIChild = Sconti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Destinazione della Merce
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DestinazioneMerceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinazioneMerceToolStripMenuItem.Click
        Dim NewMDIChild As DestinazioneMerce
        NewMDIChild = DestinazioneMerce.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

#End Region

#Region "Magazzino"

#End Region

#Region "Strumenti"

    ''' <summary>
    ''' Apre Opzioni
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OpzioniToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem1.Click
        Dim NewMDIChild As Opzioni
        NewMDIChild = Opzioni.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

#End Region

#Region "Finestre"
    Private Sub TileVerticalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        'Chiude tutti i form figlio del form padre.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
#End Region

#Region "?"

    ''' <summary>
    ''' Apre il form Informazioni sul software
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InformazioniSulSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformazioniSulSoftwareToolStripMenuItem.Click
        Dim NewMDIChild As AboutBox1
        NewMDIChild = AboutBox1.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


#End Region

#End Region

End Class

#Region "codice commentato"
'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
'    Dim OpenFileDialog As New OpenFileDialog
'    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
'    OpenFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"
'    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
'        Dim FileName As String = OpenFileDialog.FileName
'        ' TODO: aggiungere qui il codice per l'apertura del file.
'    End If
'End Sub

'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Dim SaveFileDialog As New SaveFileDialog
'    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
'    SaveFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"

'    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
'        Dim FileName As String = SaveFileDialog.FileName
'        ' TODO: aggiungere qui il codice per il salvataggio del contenuto corrente del form in un file.
'    End If
'End Sub

'Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.Close()
'End Sub
'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Chiude tutti i form figlio del form padre.
'    For Each ChildForm As Form In Me.MdiChildren
'        ChildForm.Close()
'    Next
'End Sub


'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
'End Sub

'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
'End Sub

'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    'Utilizzare My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData per recuperare informazioni dagli Appunti.
'End Sub

'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
'End Sub

'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
'End Sub

'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.Cascade)
'End Sub

'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.TileVertical)
'End Sub

'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.TileHorizontal)
'End Sub

#End Region