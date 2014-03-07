<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatiAziende
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatiAziende))
        Dim AziendaLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDescrizioneAttivita = New System.Windows.Forms.Label()
        Me.LabelCodiceAttivita = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelSitoWeb = New System.Windows.Forms.Label()
        Me.LabelFax = New System.Windows.Forms.Label()
        Me.LabelTelefoni = New System.Windows.Forms.Label()
        Me.LabelCodiceFiscale = New System.Windows.Forms.Label()
        Me.LabelPartitaIva = New System.Windows.Forms.Label()
        Me.LabelProvincia = New System.Windows.Forms.Label()
        Me.LabelLocalita = New System.Windows.Forms.Label()
        Me.LabelCAP = New System.Windows.Forms.Label()
        Me.LabelIndirizzo = New System.Windows.Forms.Label()
        Me.LabelDenominazione = New System.Windows.Forms.Label()
        Me.LabelCodiceAzienda = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.FatturazionegevenDataSet = New GeVen_SE_2015.fatturazionegevenDataSet()
        Me.AziendeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AziendeTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aziendeTableAdapter()
        Me.TableAdapterManager = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager()
        Me.AziendeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AziendeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AziendaTextBox = New System.Windows.Forms.TextBox()
        AziendaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AziendeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AziendeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AziendeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(AziendaLabel)
        Me.GroupBox1.Controls.Add(Me.AziendaTextBox)
        Me.GroupBox1.Controls.Add(Me.LabelDescrizioneAttivita)
        Me.GroupBox1.Controls.Add(Me.LabelCodiceAttivita)
        Me.GroupBox1.Controls.Add(Me.LabelEmail)
        Me.GroupBox1.Controls.Add(Me.LabelSitoWeb)
        Me.GroupBox1.Controls.Add(Me.LabelFax)
        Me.GroupBox1.Controls.Add(Me.LabelTelefoni)
        Me.GroupBox1.Controls.Add(Me.LabelCodiceFiscale)
        Me.GroupBox1.Controls.Add(Me.LabelPartitaIva)
        Me.GroupBox1.Controls.Add(Me.LabelProvincia)
        Me.GroupBox1.Controls.Add(Me.LabelLocalita)
        Me.GroupBox1.Controls.Add(Me.LabelCAP)
        Me.GroupBox1.Controls.Add(Me.LabelIndirizzo)
        Me.GroupBox1.Controls.Add(Me.LabelDenominazione)
        Me.GroupBox1.Controls.Add(Me.LabelCodiceAzienda)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 301)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelDescrizioneAttivita
        '
        Me.LabelDescrizioneAttivita.AutoSize = True
        Me.LabelDescrizioneAttivita.Location = New System.Drawing.Point(592, 245)
        Me.LabelDescrizioneAttivita.Name = "LabelDescrizioneAttivita"
        Me.LabelDescrizioneAttivita.Size = New System.Drawing.Size(97, 13)
        Me.LabelDescrizioneAttivita.TabIndex = 29
        Me.LabelDescrizioneAttivita.Text = "Descrizione Attività"
        '
        'LabelCodiceAttivita
        '
        Me.LabelCodiceAttivita.AutoSize = True
        Me.LabelCodiceAttivita.Location = New System.Drawing.Point(514, 245)
        Me.LabelCodiceAttivita.Name = "LabelCodiceAttivita"
        Me.LabelCodiceAttivita.Size = New System.Drawing.Size(75, 13)
        Me.LabelCodiceAttivita.TabIndex = 28
        Me.LabelCodiceAttivita.Text = "Codice Attività"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(6, 245)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(32, 13)
        Me.LabelEmail.TabIndex = 27
        Me.LabelEmail.Text = "Email"
        '
        'LabelSitoWeb
        '
        Me.LabelSitoWeb.AutoSize = True
        Me.LabelSitoWeb.Location = New System.Drawing.Point(190, 245)
        Me.LabelSitoWeb.Name = "LabelSitoWeb"
        Me.LabelSitoWeb.Size = New System.Drawing.Size(51, 13)
        Me.LabelSitoWeb.TabIndex = 26
        Me.LabelSitoWeb.Text = "Sito Web"
        '
        'LabelFax
        '
        Me.LabelFax.AutoSize = True
        Me.LabelFax.Location = New System.Drawing.Point(658, 200)
        Me.LabelFax.Name = "LabelFax"
        Me.LabelFax.Size = New System.Drawing.Size(24, 13)
        Me.LabelFax.TabIndex = 25
        Me.LabelFax.Text = "Fax"
        '
        'LabelTelefoni
        '
        Me.LabelTelefoni.AutoSize = True
        Me.LabelTelefoni.Location = New System.Drawing.Point(340, 200)
        Me.LabelTelefoni.Name = "LabelTelefoni"
        Me.LabelTelefoni.Size = New System.Drawing.Size(45, 13)
        Me.LabelTelefoni.TabIndex = 24
        Me.LabelTelefoni.Text = "Telefoni"
        '
        'LabelCodiceFiscale
        '
        Me.LabelCodiceFiscale.AutoSize = True
        Me.LabelCodiceFiscale.Location = New System.Drawing.Point(157, 200)
        Me.LabelCodiceFiscale.Name = "LabelCodiceFiscale"
        Me.LabelCodiceFiscale.Size = New System.Drawing.Size(76, 13)
        Me.LabelCodiceFiscale.TabIndex = 23
        Me.LabelCodiceFiscale.Text = "Codice Fiscale"
        '
        'LabelPartitaIva
        '
        Me.LabelPartitaIva.AutoSize = True
        Me.LabelPartitaIva.Location = New System.Drawing.Point(6, 200)
        Me.LabelPartitaIva.Name = "LabelPartitaIva"
        Me.LabelPartitaIva.Size = New System.Drawing.Size(55, 13)
        Me.LabelPartitaIva.TabIndex = 22
        Me.LabelPartitaIva.Text = "Partita Iva"
        '
        'LabelProvincia
        '
        Me.LabelProvincia.AutoSize = True
        Me.LabelProvincia.Location = New System.Drawing.Point(552, 153)
        Me.LabelProvincia.Name = "LabelProvincia"
        Me.LabelProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LabelProvincia.TabIndex = 21
        Me.LabelProvincia.Text = "Provincia"
        '
        'LabelLocalita
        '
        Me.LabelLocalita.AutoSize = True
        Me.LabelLocalita.Location = New System.Drawing.Point(128, 153)
        Me.LabelLocalita.Name = "LabelLocalita"
        Me.LabelLocalita.Size = New System.Drawing.Size(44, 13)
        Me.LabelLocalita.TabIndex = 20
        Me.LabelLocalita.Text = "Località"
        '
        'LabelCAP
        '
        Me.LabelCAP.AutoSize = True
        Me.LabelCAP.Location = New System.Drawing.Point(6, 153)
        Me.LabelCAP.Name = "LabelCAP"
        Me.LabelCAP.Size = New System.Drawing.Size(28, 13)
        Me.LabelCAP.TabIndex = 19
        Me.LabelCAP.Text = "CAP"
        '
        'LabelIndirizzo
        '
        Me.LabelIndirizzo.AutoSize = True
        Me.LabelIndirizzo.Location = New System.Drawing.Point(128, 111)
        Me.LabelIndirizzo.Name = "LabelIndirizzo"
        Me.LabelIndirizzo.Size = New System.Drawing.Size(45, 13)
        Me.LabelIndirizzo.TabIndex = 18
        Me.LabelIndirizzo.Text = "Indirizzo"
        '
        'LabelDenominazione
        '
        Me.LabelDenominazione.AutoSize = True
        Me.LabelDenominazione.Location = New System.Drawing.Point(128, 22)
        Me.LabelDenominazione.Name = "LabelDenominazione"
        Me.LabelDenominazione.Size = New System.Drawing.Size(80, 13)
        Me.LabelDenominazione.TabIndex = 17
        Me.LabelDenominazione.Text = "Denominazione"
        '
        'LabelCodiceAzienda
        '
        Me.LabelCodiceAzienda.AutoSize = True
        Me.LabelCodiceAzienda.Location = New System.Drawing.Point(6, 22)
        Me.LabelCodiceAzienda.Name = "LabelCodiceAzienda"
        Me.LabelCodiceAzienda.Size = New System.Drawing.Size(81, 13)
        Me.LabelCodiceAzienda.TabIndex = 16
        Me.LabelCodiceAzienda.Text = "Codice Azienda"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(595, 261)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(242, 20)
        Me.TextBox16.TabIndex = 13
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(517, 261)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(72, 20)
        Me.TextBox15.TabIndex = 12
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(193, 261)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(318, 20)
        Me.TextBox14.TabIndex = 11
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(9, 261)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(178, 20)
        Me.TextBox13.TabIndex = 10
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(661, 216)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(176, 20)
        Me.TextBox12.TabIndex = 9
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(343, 216)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(312, 20)
        Me.TextBox11.TabIndex = 8
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(160, 216)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(177, 20)
        Me.TextBox10.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(9, 216)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(145, 20)
        Me.TextBox9.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(555, 169)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(67, 20)
        Me.TextBox8.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(131, 169)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(418, 20)
        Me.TextBox7.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(9, 169)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(131, 127)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(418, 20)
        Me.TextBox5.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 41)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(418, 63)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(843, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Intestazione della Modulistica"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 38)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(831, 83)
        Me.TextBox3.TabIndex = 0
        '
        'FatturazionegevenDataSet
        '
        Me.FatturazionegevenDataSet.DataSetName = "fatturazionegevenDataSet"
        Me.FatturazionegevenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AziendeBindingSource
        '
        Me.AziendeBindingSource.DataMember = "aziende"
        Me.AziendeBindingSource.DataSource = Me.FatturazionegevenDataSet
        '
        'AziendeTableAdapter
        '
        Me.AziendeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
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
        Me.TableAdapterManager.aziendeTableAdapter = Me.AziendeTableAdapter
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
        Me.TableAdapterManager.zoneTableAdapter = Nothing
        '
        'AziendeBindingNavigator
        '
        Me.AziendeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AziendeBindingNavigator.BindingSource = Me.AziendeBindingSource
        Me.AziendeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AziendeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AziendeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AziendeBindingNavigatorSaveItem})
        Me.AziendeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AziendeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AziendeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AziendeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AziendeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AziendeBindingNavigator.Name = "AziendeBindingNavigator"
        Me.AziendeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AziendeBindingNavigator.Size = New System.Drawing.Size(869, 25)
        Me.AziendeBindingNavigator.TabIndex = 2
        Me.AziendeBindingNavigator.Text = "BindingNavigator1"
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
        'AziendeBindingNavigatorSaveItem
        '
        Me.AziendeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AziendeBindingNavigatorSaveItem.Image = CType(resources.GetObject("AziendeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AziendeBindingNavigatorSaveItem.Name = "AziendeBindingNavigatorSaveItem"
        Me.AziendeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AziendeBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'AziendaLabel
        '
        AziendaLabel.AutoSize = True
        AziendaLabel.Location = New System.Drawing.Point(669, 53)
        AziendaLabel.Name = "AziendaLabel"
        AziendaLabel.Size = New System.Drawing.Size(48, 13)
        AziendaLabel.TabIndex = 29
        AziendaLabel.Text = "Azienda:"
        '
        'AziendaTextBox
        '
        Me.AziendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AziendeBindingSource, "Azienda", True))
        Me.AziendaTextBox.Location = New System.Drawing.Point(723, 50)
        Me.AziendaTextBox.Name = "AziendaTextBox"
        Me.AziendaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AziendaTextBox.TabIndex = 30
        '
        'DatiAziende
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 519)
        Me.Controls.Add(Me.AziendeBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DatiAziende"
        Me.Text = "Anagrafica Azienda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AziendeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AziendeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AziendeBindingNavigator.ResumeLayout(False)
        Me.AziendeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDescrizioneAttivita As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceAttivita As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents LabelSitoWeb As System.Windows.Forms.Label
    Friend WithEvents LabelFax As System.Windows.Forms.Label
    Friend WithEvents LabelTelefoni As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceFiscale As System.Windows.Forms.Label
    Friend WithEvents LabelPartitaIva As System.Windows.Forms.Label
    Friend WithEvents LabelProvincia As System.Windows.Forms.Label
    Friend WithEvents LabelLocalita As System.Windows.Forms.Label
    Friend WithEvents LabelCAP As System.Windows.Forms.Label
    Friend WithEvents LabelIndirizzo As System.Windows.Forms.Label
    Friend WithEvents LabelDenominazione As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceAzienda As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents FatturazionegevenDataSet As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents AziendeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AziendeTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aziendeTableAdapter
    Friend WithEvents TableAdapterManager As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AziendeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AziendeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AziendaTextBox As System.Windows.Forms.TextBox
End Class
