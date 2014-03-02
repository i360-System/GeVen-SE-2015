Imports System.Windows.Forms
Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class MDIParent1

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub


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

    ''' <summary>
    ''' Apre Movimenti.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MovimentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentiToolStripMenuItem.Click
        Dim NewMDIChild As Movimenti
        NewMDIChild = Movimenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre generazioneinventario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GenerazioneInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerazioneInventarioToolStripMenuItem.Click
        Dim NewMDIChild As GenerazioneInventario
        NewMDIChild = GenerazioneInventario.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Magazzini
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TabelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelleToolStripMenuItem.Click
        Dim NewMDIChild As Magazzini
        NewMDIChild = Magazzini.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre articoli
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ArticoliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticoliToolStripMenuItem.Click
        Dim NewMDIChild As Articoli
        NewMDIChild = Articoli.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre listinoArticoli.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ScontiFornitoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScontiFornitoreToolStripMenuItem.Click
        Dim NewMDIChild As ListinoArticoli
        NewMDIChild = ListinoArticoli.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre PrezziAcquisto.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrezziAcquistoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrezziAcquistoToolStripMenuItem.Click
        Dim NewMDIChild As PrezziAcquisto
        NewMDIChild = PrezziAcquisto.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre ClassiArticolo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClassiArticoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassiArticoloToolStripMenuItem.Click
        Dim NewMDIChild As ClassiArticolo
        NewMDIChild = ClassiArticolo.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

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

    ''' <summary>
    ''' Apre EsportazioneAnagrafiche.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EsportazioneAnagraficheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsportazioneAnagraficheToolStripMenuItem.Click
        Dim NewMDIChild As EsportazioneAnagrafiche
        NewMDIChild = EsportazioneAnagrafiche.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre EsportazioneFatture.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EsportazioneFattureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsportazioneFattureToolStripMenuItem.Click
        Dim NewMDIChild As EsportazioneFatture
        NewMDIChild = EsportazioneFatture.Istanza
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

#Region "Menù di connessione"



#End Region


End Class




