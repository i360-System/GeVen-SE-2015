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

#End Region

#Region "Anagrafiche"


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



#End Region

#Region "Magazzino"

#End Region

#Region "Strumenti"

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