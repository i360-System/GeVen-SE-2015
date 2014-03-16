<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZoneGeografiche
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZoneGeografiche))
        Me.FatturazionegevenDataSet = New GeVen_SE_2015.fatturazionegevenDataSet()
        Me.ZoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZoneTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.zoneTableAdapter()
        Me.TableAdapterManager = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager()
        Me.ZoneBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ZoneBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ZoneDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoneBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZoneBindingNavigator.SuspendLayout()
        CType(Me.ZoneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FatturazionegevenDataSet
        '
        Me.FatturazionegevenDataSet.DataSetName = "fatturazionegevenDataSet"
        Me.FatturazionegevenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZoneBindingSource
        '
        Me.ZoneBindingSource.DataMember = "zone"
        Me.ZoneBindingSource.DataSource = Me.FatturazionegevenDataSet
        '
        'ZoneTableAdapter
        '
        Me.ZoneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountutenteTableAdapter = Nothing
        Me.TableAdapterManager.agentiprovvigioniTableAdapter = Nothing
        Me.TableAdapterManager.agentiTableAdapter = Nothing
        Me.TableAdapterManager.anagraficadestinazioniTableAdapter = Nothing
        Me.TableAdapterManager.anagraficafatturazioneTableAdapter = Nothing
        Me.TableAdapterManager.anagraficascontiTableAdapter = Nothing
        Me.TableAdapterManager.anagraficheTableAdapter = Nothing
        Me.TableAdapterManager.articolilistinoTableAdapter = Nothing
        Me.TableAdapterManager.articolimisureTableAdapter = Nothing
        Me.TableAdapterManager.articoliprezziacquistoTableAdapter = Nothing
        Me.TableAdapterManager.articoliTableAdapter = Nothing
        Me.TableAdapterManager.aspettobeniTableAdapter = Nothing
        Me.TableAdapterManager.aziendacostantiTableAdapter = Nothing
        Me.TableAdapterManager.aziendaintestazionemodulisticaTableAdapter = Nothing
        Me.TableAdapterManager.aziendeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriemerceologicheTableAdapter = Nothing
        Me.TableAdapterManager.categorieTableAdapter = Nothing
        Me.TableAdapterManager.causalitrasportoTableAdapter = Nothing
        Me.TableAdapterManager.classiarticoloTableAdapter = Nothing
        Me.TableAdapterManager.contiTableAdapter = Nothing
        Me.TableAdapterManager.diviseTableAdapter = Nothing
        Me.TableAdapterManager.documentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.documentiscadenzeTableAdapter = Nothing
        Me.TableAdapterManager.documentitestataTableAdapter = Nothing
        Me.TableAdapterManager.esercizicontabiliTableAdapter = Nothing
        Me.TableAdapterManager.magazzinodenominazioneTableAdapter = Nothing
        Me.TableAdapterManager.magazzinomovimentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.magazzinomovimentitestataTableAdapter = Nothing
        Me.TableAdapterManager.magazzinotipimovimentodettaglioTableAdapter = Nothing
        Me.TableAdapterManager.magazzinotipimovimentoTableAdapter = Nothing
        Me.TableAdapterManager.moditrasportoTableAdapter = Nothing
        Me.TableAdapterManager.operazionidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.operazioniTableAdapter = Nothing
        Me.TableAdapterManager.pagamentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.pagamentitestataTableAdapter = Nothing
        Me.TableAdapterManager.parametriivaTableAdapter = Nothing
        Me.TableAdapterManager.portafoglioeffettiTableAdapter = Nothing
        Me.TableAdapterManager.scontifornitoreTableAdapter = Nothing
        Me.TableAdapterManager.tipidocumentoTableAdapter = Nothing
        Me.TableAdapterManager.tipitrasportoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vettoriTableAdapter = Nothing
        Me.TableAdapterManager.zoneTableAdapter = Me.ZoneTableAdapter
        '
        'ZoneBindingNavigator
        '
        Me.ZoneBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ZoneBindingNavigator.BindingSource = Me.ZoneBindingSource
        Me.ZoneBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ZoneBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ZoneBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ZoneBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ZoneBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ZoneBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ZoneBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ZoneBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ZoneBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ZoneBindingNavigator.Name = "ZoneBindingNavigator"
        Me.ZoneBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ZoneBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.ZoneBindingNavigator.TabIndex = 0
        Me.ZoneBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 15)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'ZoneBindingNavigatorSaveItem
        '
        Me.ZoneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoneBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZoneBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZoneBindingNavigatorSaveItem.Name = "ZoneBindingNavigatorSaveItem"
        Me.ZoneBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ZoneBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ZoneDataGridView
        '
        Me.ZoneDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoneDataGridView.AutoGenerateColumns = False
        Me.ZoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ZoneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ZoneDataGridView.DataSource = Me.ZoneBindingSource
        Me.ZoneDataGridView.Location = New System.Drawing.Point(12, 51)
        Me.ZoneDataGridView.Name = "ZoneDataGridView"
        Me.ZoneDataGridView.Size = New System.Drawing.Size(696, 220)
        Me.ZoneDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Zona"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Denominazione"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Denominazione"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ZoneGeografiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 365)
        Me.Controls.Add(Me.ZoneDataGridView)
        Me.Controls.Add(Me.ZoneBindingNavigator)
        Me.Name = "ZoneGeografiche"
        Me.Text = "ZoneGeografiche"
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoneBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZoneBindingNavigator.ResumeLayout(False)
        Me.ZoneBindingNavigator.PerformLayout()
        CType(Me.ZoneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FatturazionegevenDataSet As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents ZoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZoneTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.zoneTableAdapter
    Friend WithEvents TableAdapterManager As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ZoneBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoneBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZoneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
