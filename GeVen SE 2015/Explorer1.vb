Imports System.Diagnostics
Imports System.Windows.Forms

Public Class Explorer1

    Private Sub Explorer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configura l'interfaccia utente
        SetUpListViewColumns()
        LoadTree()
    End Sub

    Private Sub LoadTree()
        ' TODO: aggiungere il codice per l'aggiunta di elementi al controllo TreeView

        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode

        tvRoot = Me.TreeView.Nodes.Add("Root")
        tvNode = tvRoot.Nodes.Add("TreeItem1")
        tvNode = tvRoot.Nodes.Add("TreeItem2")
        tvNode = tvRoot.Nodes.Add("TreeItem3")
    End Sub

    Private Sub LoadListView()
        ' TODO: aggiungere il codice per l'aggiunta di elementi al controllo ListView in base all'elemento selezionato nel controllo TreeView

        Dim lvItem As ListViewItem
        ListView.Items.Clear()

        lvItem = ListView.Items.Add("ListViewItem1")
        lvItem.ImageKey = "Graph1"
        lvItem.SubItems.AddRange(New String() {"Colonna2", "Colonna3"})

        lvItem = ListView.Items.Add("ListViewItem2")
        lvItem.ImageKey = "Graph2"
        lvItem.SubItems.AddRange(New String() {"Colonna2", "Colonna3"})

        lvItem = ListView.Items.Add("ListViewItem3")
        lvItem.ImageKey = "Graph3"
        lvItem.SubItems.AddRange(New String() {"Colonna2", "Colonna3"})
    End Sub

    Private Sub SetUpListViewColumns()

        ' TODO: aggiungere il codice per l'impostazione delle colonne ListView
        Dim lvColumnHeader As ColumnHeader

        ' Poiché l'impostazione della larghezza delle colonne si applica solo alla visualizzazione corrente, questa riga
        '  imposta in modo esplicito il controllo ListView per l'utilizzo della visualizzazione SmallIcon
        '  prima di impostare la larghezza delle colonne
        SetView(View.SmallIcon)

        lvColumnHeader = ListView.Columns.Add("Colonna1")
        ' Imposta la larghezza delle colonne in visualizzazione SmallIcon in modo che gli elementi
        '  non si sovrappongano
        ' La seconda e la terza colonna non vengono visualizzate in visualizzazione SmallIcon,
        '  pertanto non è necessario impostarle quando è attiva la visualizzazione SmallIcon
        lvColumnHeader.Width = 90

        ' Modifica la visualizzazione in Dettagli e configura la larghezza delle colonne
        '  appropriata perché la visualizzazione Dettagli risulti diversa dalla visualizzazione SmallIcon
        SetView(View.Details)

        ' La prima colonna deve essere leggermente più grande in visualizzazione Dettagli che in
        '  visualizzazione SmallIcon e per Colonna2 e Colonna3 devono essere impostate dimensioni esplicite
        '  per la visualizzazione Dettagli
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Colonna2")
        lvColumnHeader.Width = 70

        lvColumnHeader = ListView.Columns.Add("Colonna3")
        lvColumnHeader.Width = 70

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Chiudi form
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Attiva o disattiva la visualizzazione della striscia comandi e lo stato di selezione della voce di menu associata
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        'Attiva o disattiva la visualizzazione del controllo StatusStrip e lo stato di selezione della voce di menu associata
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    'Attiva o disattiva la visualizzazione del riquadro delle cartelle
    Private Sub ToggleFoldersVisible()
        'Alterna innanzitutto lo stato di selezione della voce di menu associata
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Modifica il pulsante Cartelle della barra degli strumenti in modo che sia sincronizzato
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Comprime il pannello contenente il controllo TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked
    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripMenuItem.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub FoldersToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub SetView(ByVal View As System.Windows.Forms.View)
        'Determina la voce di menu da selezionare
        Dim MenuItemToCheck As ToolStripMenuItem = Nothing
        Select Case View
            Case View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
            Case View.LargeIcon
                MenuItemToCheck = LargeIconsToolStripMenuItem
            Case View.List
                MenuItemToCheck = ListToolStripMenuItem
            Case View.SmallIcon
                MenuItemToCheck = SmallIconsToolStripMenuItem
            Case View.Tile
                MenuItemToCheck = TileToolStripMenuItem
            Case Else
                Debug.Fail("Unexpected View")
                View = View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
        End Select

        'Seleziona la voce di menu appropriata e deseleziona tutte le altre voci del menu Visualizza
        For Each MenuItem As ToolStripMenuItem In ListViewToolStripButton.DropDownItems
            If MenuItem Is MenuItemToCheck Then
                MenuItem.Checked = True
            Else
                MenuItem.Checked = False
            End If
        Next

        'Imposta infine la visualizzazione richiesta
        ListView.View = View
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconsToolStripMenuItem.Click
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconsToolStripMenuItem.Click
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        SetView(View.Tile)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "File di testo (*.txt)|*.txt"
        OpenFileDialog.ShowDialog(Me)

        Dim FileName As String = OpenFileDialog.FileName
        ' TODO: aggiungere il codice per l'apertura del file
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "File di testo (*.txt)|*.txt"
        SaveFileDialog.ShowDialog(Me)

        Dim FileName As String = SaveFileDialog.FileName
        ' TODO: aggiungere qui il codice per il salvataggio del contenuto corrente del form in un file.
    End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        ' TODO: aggiungere il codice per la modifica del contenuto del controllo ListView in base al nodo correntemente selezionato del controllo TreeView
        LoadListView()
    End Sub

End Class
