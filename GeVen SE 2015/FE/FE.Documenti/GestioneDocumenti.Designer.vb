<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioneDocumenti
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
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim DestinazioneLabel As System.Windows.Forms.Label
        Dim DataDocumentoLabel As System.Windows.Forms.Label
        Dim RiferimentoLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim PagamentoLabel As System.Windows.Forms.Label
        Dim ScontoLabel As System.Windows.Forms.Label
        Dim NominativoDestinatarioLabel As System.Windows.Forms.Label
        Dim IndirizzoDestinatarioLabel As System.Windows.Forms.Label
        Dim CapDestinatarioLabel As System.Windows.Forms.Label
        Dim LocalitaDestinatarioLabel As System.Windows.Forms.Label
        Dim ProvinciaDestinatarioLabel As System.Windows.Forms.Label
        Dim BancaLabel As System.Windows.Forms.Label
        Dim AgenziaLabel As System.Windows.Forms.Label
        Dim TotaleMerceLabel As System.Windows.Forms.Label
        Dim ScontoCassaLabel As System.Windows.Forms.Label
        Dim TrasportoLabel As System.Windows.Forms.Label
        Dim ImballoLabel As System.Windows.Forms.Label
        Dim CausaleTrasportoLabel As System.Windows.Forms.Label
        Dim PortoLabel As System.Windows.Forms.Label
        Dim ColliLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim DataTrasportoLabel As System.Windows.Forms.Label
        Dim OraTrasportoLabel As System.Windows.Forms.Label
        Dim AspettoBeniLabel As System.Windows.Forms.Label
        Dim TrasportoMezzoLabel As System.Windows.Forms.Label
        Dim VettoreLabel As System.Windows.Forms.Label
        Dim CodiceIva1Label As System.Windows.Forms.Label
        Dim Imponibile1Label As System.Windows.Forms.Label
        Dim _Iva1Label As System.Windows.Forms.Label
        Dim ImportoIva1Label As System.Windows.Forms.Label
        Dim CodiceIva2Label As System.Windows.Forms.Label
        Dim Imponibile2Label As System.Windows.Forms.Label
        Dim _Iva2Label As System.Windows.Forms.Label
        Dim ImportoIva2Label As System.Windows.Forms.Label
        Dim TotaleDocumentoLabel As System.Windows.Forms.Label
        Dim DivisaLabel As System.Windows.Forms.Label
        Dim TestDocumentoLabel As System.Windows.Forms.Label
        Dim TestProceduraLabel As System.Windows.Forms.Label
        Dim MovimentoContabileLabel As System.Windows.Forms.Label
        Dim AziendaLabel As System.Windows.Forms.Label
        Dim EsercizioLabel As System.Windows.Forms.Label
        Dim TipoDocumentoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioneDocumenti))
        Me.DocumentitestataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatturazionegevenDataSet = New GeVen_SE_2015.fatturazionegevenDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxLike = New System.Windows.Forms.TextBox()
        Me.ScontoTextBox = New System.Windows.Forms.TextBox()
        Me.PagamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.IvaComboBox = New System.Windows.Forms.ComboBox()
        Me.AgenteComboBox = New System.Windows.Forms.ComboBox()
        Me.RiferimentoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AnagraficaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ProvinciaDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.CapDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.NominativoDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.DestinazioneComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentitestataTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentitestataTableAdapter()
        Me.TableAdapterManager = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager()
        Me.AziendeTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aziendeTableAdapter()
        Me.DocumentidettaglioTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentidettaglioTableAdapter()
        Me.DocumentitestataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentidettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.RigaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticoloComboBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitaMisuraMagazzinoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitaMagazzinoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitaMisuraTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoUnitarioTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sconto1TextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sconto2TextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sconto3TextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScorporoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasseMerceologicaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasseContropartitaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticoloAliasTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimentoMagazzinoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AgenziaTextBox = New System.Windows.Forms.TextBox()
        Me.BancaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MovimentoContabileTextBox = New System.Windows.Forms.TextBox()
        Me.TestProceduraTextBox = New System.Windows.Forms.TextBox()
        Me.TestDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.DivisaComboBox = New System.Windows.Forms.ComboBox()
        Me.TotaleDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoIva2TextBox = New System.Windows.Forms.TextBox()
        Me._Iva2TextBox = New System.Windows.Forms.TextBox()
        Me.Imponibile2TextBox = New System.Windows.Forms.TextBox()
        Me.CodiceIva2TextBox = New System.Windows.Forms.TextBox()
        Me.ImportoIva1TextBox = New System.Windows.Forms.TextBox()
        Me._Iva1TextBox = New System.Windows.Forms.TextBox()
        Me.Imponibile1TextBox = New System.Windows.Forms.TextBox()
        Me.CodiceIva1TextBox = New System.Windows.Forms.TextBox()
        Me.VettoreComboBox = New System.Windows.Forms.ComboBox()
        Me.TrasportoMezzoComboBox = New System.Windows.Forms.ComboBox()
        Me.AspettoBeniComboBox = New System.Windows.Forms.ComboBox()
        Me.OraTrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.DataTrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.ColliTextBox = New System.Windows.Forms.TextBox()
        Me.PortoComboBox = New System.Windows.Forms.ComboBox()
        Me.CausaleTrasportoComboBox = New System.Windows.Forms.ComboBox()
        Me.ImballoTextBox = New System.Windows.Forms.TextBox()
        Me.TrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.ScontoCassaTextBox = New System.Windows.Forms.TextBox()
        Me.TotaleMerceTextBox = New System.Windows.Forms.TextBox()
        Me.AnagraficheTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficheTableAdapter()
        Me.ArticoliTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.articoliTableAdapter()
        Me.TipidocumentoTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.tipidocumentoTableAdapter()
        Me.ParametriivaTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.parametriivaTableAdapter()
        Me.AgentiTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.agentiTableAdapter()
        Me.PagamentitestataTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.pagamentitestataTableAdapter()
        Me.TipitrasportoTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.tipitrasportoTableAdapter()
        Me.AspettobeniTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aspettobeniTableAdapter()
        Me.CausalitrasportoTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.causalitrasportoTableAdapter()
        Me.ModitrasportoTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.moditrasportoTableAdapter()
        Me.VettoriTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.vettoriTableAdapter()
        Me.DiviseTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.diviseTableAdapter()
        Me.AnagraficadestinazioniTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficadestinazioniTableAdapter()
        Me.EsercizicontabiliTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.esercizicontabiliTableAdapter()
        Me.AnagraficafatturazioneTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficafatturazioneTableAdapter()
        Me.AziendaComboBox = New System.Windows.Forms.ComboBox()
        Me.EsercizioComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoDocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ArticolimisureTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.articolimisureTableAdapter()
        Me.Azienda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esercizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentidettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentitestataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DocumentitestatadocumentidettaglioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentitestatadocumentidettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        AnagraficaLabel = New System.Windows.Forms.Label()
        DestinazioneLabel = New System.Windows.Forms.Label()
        DataDocumentoLabel = New System.Windows.Forms.Label()
        RiferimentoLabel = New System.Windows.Forms.Label()
        AgenteLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        PagamentoLabel = New System.Windows.Forms.Label()
        ScontoLabel = New System.Windows.Forms.Label()
        NominativoDestinatarioLabel = New System.Windows.Forms.Label()
        IndirizzoDestinatarioLabel = New System.Windows.Forms.Label()
        CapDestinatarioLabel = New System.Windows.Forms.Label()
        LocalitaDestinatarioLabel = New System.Windows.Forms.Label()
        ProvinciaDestinatarioLabel = New System.Windows.Forms.Label()
        BancaLabel = New System.Windows.Forms.Label()
        AgenziaLabel = New System.Windows.Forms.Label()
        TotaleMerceLabel = New System.Windows.Forms.Label()
        ScontoCassaLabel = New System.Windows.Forms.Label()
        TrasportoLabel = New System.Windows.Forms.Label()
        ImballoLabel = New System.Windows.Forms.Label()
        CausaleTrasportoLabel = New System.Windows.Forms.Label()
        PortoLabel = New System.Windows.Forms.Label()
        ColliLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        DataTrasportoLabel = New System.Windows.Forms.Label()
        OraTrasportoLabel = New System.Windows.Forms.Label()
        AspettoBeniLabel = New System.Windows.Forms.Label()
        TrasportoMezzoLabel = New System.Windows.Forms.Label()
        VettoreLabel = New System.Windows.Forms.Label()
        CodiceIva1Label = New System.Windows.Forms.Label()
        Imponibile1Label = New System.Windows.Forms.Label()
        _Iva1Label = New System.Windows.Forms.Label()
        ImportoIva1Label = New System.Windows.Forms.Label()
        CodiceIva2Label = New System.Windows.Forms.Label()
        Imponibile2Label = New System.Windows.Forms.Label()
        _Iva2Label = New System.Windows.Forms.Label()
        ImportoIva2Label = New System.Windows.Forms.Label()
        TotaleDocumentoLabel = New System.Windows.Forms.Label()
        DivisaLabel = New System.Windows.Forms.Label()
        TestDocumentoLabel = New System.Windows.Forms.Label()
        TestProceduraLabel = New System.Windows.Forms.Label()
        MovimentoContabileLabel = New System.Windows.Forms.Label()
        AziendaLabel = New System.Windows.Forms.Label()
        EsercizioLabel = New System.Windows.Forms.Label()
        TipoDocumentoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        CType(Me.DocumentitestataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DocumentitestataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentitestataBindingNavigator.SuspendLayout()
        CType(Me.DocumentidettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentitestatadocumentidettaglioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentitestatadocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(3, 12)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 0
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'DestinazioneLabel
        '
        DestinazioneLabel.AutoSize = True
        DestinazioneLabel.Location = New System.Drawing.Point(3, 13)
        DestinazioneLabel.Name = "DestinazioneLabel"
        DestinazioneLabel.Size = New System.Drawing.Size(71, 13)
        DestinazioneLabel.TabIndex = 0
        DestinazioneLabel.Text = "Destinazione:"
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(3, 51)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 2
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'RiferimentoLabel
        '
        RiferimentoLabel.AutoSize = True
        RiferimentoLabel.Location = New System.Drawing.Point(169, 51)
        RiferimentoLabel.Name = "RiferimentoLabel"
        RiferimentoLabel.Size = New System.Drawing.Size(63, 13)
        RiferimentoLabel.TabIndex = 4
        RiferimentoLabel.Text = "Riferimento:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Location = New System.Drawing.Point(6, 90)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(44, 13)
        AgenteLabel.TabIndex = 6
        AgenteLabel.Text = "Agente:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(270, 90)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 8
        IvaLabel.Text = "Iva:"
        '
        'PagamentoLabel
        '
        PagamentoLabel.AutoSize = True
        PagamentoLabel.Location = New System.Drawing.Point(3, 130)
        PagamentoLabel.Name = "PagamentoLabel"
        PagamentoLabel.Size = New System.Drawing.Size(64, 13)
        PagamentoLabel.TabIndex = 10
        PagamentoLabel.Text = "Pagamento:"
        '
        'ScontoLabel
        '
        ScontoLabel.AutoSize = True
        ScontoLabel.Location = New System.Drawing.Point(297, 130)
        ScontoLabel.Name = "ScontoLabel"
        ScontoLabel.Size = New System.Drawing.Size(44, 13)
        ScontoLabel.TabIndex = 12
        ScontoLabel.Text = "Sconto:"
        '
        'NominativoDestinatarioLabel
        '
        NominativoDestinatarioLabel.AutoSize = True
        NominativoDestinatarioLabel.Location = New System.Drawing.Point(3, 52)
        NominativoDestinatarioLabel.Name = "NominativoDestinatarioLabel"
        NominativoDestinatarioLabel.Size = New System.Drawing.Size(122, 13)
        NominativoDestinatarioLabel.TabIndex = 2
        NominativoDestinatarioLabel.Text = "Nominativo Destinatario:"
        '
        'IndirizzoDestinatarioLabel
        '
        IndirizzoDestinatarioLabel.AutoSize = True
        IndirizzoDestinatarioLabel.Location = New System.Drawing.Point(3, 91)
        IndirizzoDestinatarioLabel.Name = "IndirizzoDestinatarioLabel"
        IndirizzoDestinatarioLabel.Size = New System.Drawing.Size(107, 13)
        IndirizzoDestinatarioLabel.TabIndex = 4
        IndirizzoDestinatarioLabel.Text = "Indirizzo Destinatario:"
        '
        'CapDestinatarioLabel
        '
        CapDestinatarioLabel.AutoSize = True
        CapDestinatarioLabel.Location = New System.Drawing.Point(3, 131)
        CapDestinatarioLabel.Name = "CapDestinatarioLabel"
        CapDestinatarioLabel.Size = New System.Drawing.Size(88, 13)
        CapDestinatarioLabel.TabIndex = 6
        CapDestinatarioLabel.Text = "Cap Destinatario:"
        '
        'LocalitaDestinatarioLabel
        '
        LocalitaDestinatarioLabel.AutoSize = True
        LocalitaDestinatarioLabel.Location = New System.Drawing.Point(109, 131)
        LocalitaDestinatarioLabel.Name = "LocalitaDestinatarioLabel"
        LocalitaDestinatarioLabel.Size = New System.Drawing.Size(106, 13)
        LocalitaDestinatarioLabel.TabIndex = 8
        LocalitaDestinatarioLabel.Text = "Localita Destinatario:"
        '
        'ProvinciaDestinatarioLabel
        '
        ProvinciaDestinatarioLabel.AutoSize = True
        ProvinciaDestinatarioLabel.Location = New System.Drawing.Point(387, 132)
        ProvinciaDestinatarioLabel.Name = "ProvinciaDestinatarioLabel"
        ProvinciaDestinatarioLabel.Size = New System.Drawing.Size(113, 13)
        ProvinciaDestinatarioLabel.TabIndex = 10
        ProvinciaDestinatarioLabel.Text = "Provincia Destinatario:"
        '
        'BancaLabel
        '
        BancaLabel.AutoSize = True
        BancaLabel.Location = New System.Drawing.Point(6, 19)
        BancaLabel.Name = "BancaLabel"
        BancaLabel.Size = New System.Drawing.Size(41, 13)
        BancaLabel.TabIndex = 0
        BancaLabel.Text = "Banca:"
        '
        'AgenziaLabel
        '
        AgenziaLabel.AutoSize = True
        AgenziaLabel.Location = New System.Drawing.Point(408, 19)
        AgenziaLabel.Name = "AgenziaLabel"
        AgenziaLabel.Size = New System.Drawing.Size(48, 13)
        AgenziaLabel.TabIndex = 2
        AgenziaLabel.Text = "Agenzia:"
        '
        'TotaleMerceLabel
        '
        TotaleMerceLabel.AutoSize = True
        TotaleMerceLabel.Location = New System.Drawing.Point(3, 18)
        TotaleMerceLabel.Name = "TotaleMerceLabel"
        TotaleMerceLabel.Size = New System.Drawing.Size(73, 13)
        TotaleMerceLabel.TabIndex = 0
        TotaleMerceLabel.Text = "Totale Merce:"
        '
        'ScontoCassaLabel
        '
        ScontoCassaLabel.AutoSize = True
        ScontoCassaLabel.Location = New System.Drawing.Point(109, 17)
        ScontoCassaLabel.Name = "ScontoCassaLabel"
        ScontoCassaLabel.Size = New System.Drawing.Size(76, 13)
        ScontoCassaLabel.TabIndex = 2
        ScontoCassaLabel.Text = "Sconto Cassa:"
        '
        'TrasportoLabel
        '
        TrasportoLabel.AutoSize = True
        TrasportoLabel.Location = New System.Drawing.Point(188, 18)
        TrasportoLabel.Name = "TrasportoLabel"
        TrasportoLabel.Size = New System.Drawing.Size(55, 13)
        TrasportoLabel.TabIndex = 4
        TrasportoLabel.Text = "Trasporto:"
        '
        'ImballoLabel
        '
        ImballoLabel.AutoSize = True
        ImballoLabel.Location = New System.Drawing.Point(284, 18)
        ImballoLabel.Name = "ImballoLabel"
        ImballoLabel.Size = New System.Drawing.Size(43, 13)
        ImballoLabel.TabIndex = 6
        ImballoLabel.Text = "Imballo:"
        '
        'CausaleTrasportoLabel
        '
        CausaleTrasportoLabel.AutoSize = True
        CausaleTrasportoLabel.Location = New System.Drawing.Point(380, 17)
        CausaleTrasportoLabel.Name = "CausaleTrasportoLabel"
        CausaleTrasportoLabel.Size = New System.Drawing.Size(96, 13)
        CausaleTrasportoLabel.TabIndex = 8
        CausaleTrasportoLabel.Text = "Causale Trasporto:"
        '
        'PortoLabel
        '
        PortoLabel.AutoSize = True
        PortoLabel.Location = New System.Drawing.Point(507, 17)
        PortoLabel.Name = "PortoLabel"
        PortoLabel.Size = New System.Drawing.Size(35, 13)
        PortoLabel.TabIndex = 10
        PortoLabel.Text = "Porto:"
        '
        'ColliLabel
        '
        ColliLabel.AutoSize = True
        ColliLabel.Location = New System.Drawing.Point(634, 18)
        ColliLabel.Name = "ColliLabel"
        ColliLabel.Size = New System.Drawing.Size(29, 13)
        ColliLabel.TabIndex = 12
        ColliLabel.Text = "Colli:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(694, 17)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 14
        PesoLabel.Text = "Peso:"
        '
        'DataTrasportoLabel
        '
        DataTrasportoLabel.AutoSize = True
        DataTrasportoLabel.Location = New System.Drawing.Point(770, 17)
        DataTrasportoLabel.Name = "DataTrasportoLabel"
        DataTrasportoLabel.Size = New System.Drawing.Size(81, 13)
        DataTrasportoLabel.TabIndex = 16
        DataTrasportoLabel.Text = "Data Trasporto:"
        '
        'OraTrasportoLabel
        '
        OraTrasportoLabel.AutoSize = True
        OraTrasportoLabel.Location = New System.Drawing.Point(770, 61)
        OraTrasportoLabel.Name = "OraTrasportoLabel"
        OraTrasportoLabel.Size = New System.Drawing.Size(75, 13)
        OraTrasportoLabel.TabIndex = 18
        OraTrasportoLabel.Text = "Ora Trasporto:"
        '
        'AspettoBeniLabel
        '
        AspettoBeniLabel.AutoSize = True
        AspettoBeniLabel.Location = New System.Drawing.Point(3, 61)
        AspettoBeniLabel.Name = "AspettoBeniLabel"
        AspettoBeniLabel.Size = New System.Drawing.Size(70, 13)
        AspettoBeniLabel.TabIndex = 20
        AspettoBeniLabel.Text = "Aspetto Beni:"
        '
        'TrasportoMezzoLabel
        '
        TrasportoMezzoLabel.AutoSize = True
        TrasportoMezzoLabel.Location = New System.Drawing.Point(130, 61)
        TrasportoMezzoLabel.Name = "TrasportoMezzoLabel"
        TrasportoMezzoLabel.Size = New System.Drawing.Size(89, 13)
        TrasportoMezzoLabel.TabIndex = 22
        TrasportoMezzoLabel.Text = "Trasporto Mezzo:"
        '
        'VettoreLabel
        '
        VettoreLabel.AutoSize = True
        VettoreLabel.Location = New System.Drawing.Point(257, 61)
        VettoreLabel.Name = "VettoreLabel"
        VettoreLabel.Size = New System.Drawing.Size(44, 13)
        VettoreLabel.TabIndex = 24
        VettoreLabel.Text = "Vettore:"
        '
        'CodiceIva1Label
        '
        CodiceIva1Label.AutoSize = True
        CodiceIva1Label.Location = New System.Drawing.Point(3, 103)
        CodiceIva1Label.Name = "CodiceIva1Label"
        CodiceIva1Label.Size = New System.Drawing.Size(67, 13)
        CodiceIva1Label.TabIndex = 26
        CodiceIva1Label.Text = "Codice Iva1:"
        '
        'Imponibile1Label
        '
        Imponibile1Label.AutoSize = True
        Imponibile1Label.Location = New System.Drawing.Point(73, 103)
        Imponibile1Label.Name = "Imponibile1Label"
        Imponibile1Label.Size = New System.Drawing.Size(63, 13)
        Imponibile1Label.TabIndex = 28
        Imponibile1Label.Text = "Imponibile1:"
        '
        '_Iva1Label
        '
        _Iva1Label.AutoSize = True
        _Iva1Label.Location = New System.Drawing.Point(179, 103)
        _Iva1Label.Name = "_Iva1Label"
        _Iva1Label.Size = New System.Drawing.Size(39, 13)
        _Iva1Label.TabIndex = 30
        _Iva1Label.Text = "%Iva1:"
        '
        'ImportoIva1Label
        '
        ImportoIva1Label.AutoSize = True
        ImportoIva1Label.Location = New System.Drawing.Point(257, 103)
        ImportoIva1Label.Name = "ImportoIva1Label"
        ImportoIva1Label.Size = New System.Drawing.Size(69, 13)
        ImportoIva1Label.TabIndex = 32
        ImportoIva1Label.Text = "Importo Iva1:"
        '
        'CodiceIva2Label
        '
        CodiceIva2Label.AutoSize = True
        CodiceIva2Label.Location = New System.Drawing.Point(3, 143)
        CodiceIva2Label.Name = "CodiceIva2Label"
        CodiceIva2Label.Size = New System.Drawing.Size(67, 13)
        CodiceIva2Label.TabIndex = 34
        CodiceIva2Label.Text = "Codice Iva2:"
        '
        'Imponibile2Label
        '
        Imponibile2Label.AutoSize = True
        Imponibile2Label.Location = New System.Drawing.Point(73, 143)
        Imponibile2Label.Name = "Imponibile2Label"
        Imponibile2Label.Size = New System.Drawing.Size(63, 13)
        Imponibile2Label.TabIndex = 36
        Imponibile2Label.Text = "Imponibile2:"
        '
        '_Iva2Label
        '
        _Iva2Label.AutoSize = True
        _Iva2Label.Location = New System.Drawing.Point(179, 143)
        _Iva2Label.Name = "_Iva2Label"
        _Iva2Label.Size = New System.Drawing.Size(39, 13)
        _Iva2Label.TabIndex = 38
        _Iva2Label.Text = "%Iva2:"
        '
        'ImportoIva2Label
        '
        ImportoIva2Label.AutoSize = True
        ImportoIva2Label.Location = New System.Drawing.Point(257, 143)
        ImportoIva2Label.Name = "ImportoIva2Label"
        ImportoIva2Label.Size = New System.Drawing.Size(69, 13)
        ImportoIva2Label.TabIndex = 40
        ImportoIva2Label.Text = "Importo Iva2:"
        '
        'TotaleDocumentoLabel
        '
        TotaleDocumentoLabel.AutoSize = True
        TotaleDocumentoLabel.Location = New System.Drawing.Point(770, 142)
        TotaleDocumentoLabel.Name = "TotaleDocumentoLabel"
        TotaleDocumentoLabel.Size = New System.Drawing.Size(98, 13)
        TotaleDocumentoLabel.TabIndex = 42
        TotaleDocumentoLabel.Text = "Totale Documento:"
        '
        'DivisaLabel
        '
        DivisaLabel.AutoSize = True
        DivisaLabel.Location = New System.Drawing.Point(694, 143)
        DivisaLabel.Name = "DivisaLabel"
        DivisaLabel.Size = New System.Drawing.Size(39, 13)
        DivisaLabel.TabIndex = 44
        DivisaLabel.Text = "Divisa:"
        '
        'TestDocumentoLabel
        '
        TestDocumentoLabel.AutoSize = True
        TestDocumentoLabel.Location = New System.Drawing.Point(544, 62)
        TestDocumentoLabel.Name = "TestDocumentoLabel"
        TestDocumentoLabel.Size = New System.Drawing.Size(89, 13)
        TestDocumentoLabel.TabIndex = 46
        TestDocumentoLabel.Text = "Test Documento:"
        '
        'TestProceduraLabel
        '
        TestProceduraLabel.AutoSize = True
        TestProceduraLabel.Location = New System.Drawing.Point(544, 101)
        TestProceduraLabel.Name = "TestProceduraLabel"
        TestProceduraLabel.Size = New System.Drawing.Size(83, 13)
        TestProceduraLabel.TabIndex = 48
        TestProceduraLabel.Text = "Test Procedura:"
        '
        'MovimentoContabileLabel
        '
        MovimentoContabileLabel.AutoSize = True
        MovimentoContabileLabel.Location = New System.Drawing.Point(544, 140)
        MovimentoContabileLabel.Name = "MovimentoContabileLabel"
        MovimentoContabileLabel.Size = New System.Drawing.Size(109, 13)
        MovimentoContabileLabel.TabIndex = 50
        MovimentoContabileLabel.Text = "Movimento Contabile:"
        '
        'AziendaLabel
        '
        AziendaLabel.AutoSize = True
        AziendaLabel.Location = New System.Drawing.Point(3, 14)
        AziendaLabel.Name = "AziendaLabel"
        AziendaLabel.Size = New System.Drawing.Size(48, 13)
        AziendaLabel.TabIndex = 0
        AziendaLabel.Text = "Azienda:"
        '
        'EsercizioLabel
        '
        EsercizioLabel.AutoSize = True
        EsercizioLabel.Location = New System.Drawing.Point(188, 14)
        EsercizioLabel.Name = "EsercizioLabel"
        EsercizioLabel.Size = New System.Drawing.Size(52, 13)
        EsercizioLabel.TabIndex = 2
        EsercizioLabel.Text = "Esercizio:"
        '
        'TipoDocumentoLabel
        '
        TipoDocumentoLabel.AutoSize = True
        TipoDocumentoLabel.Location = New System.Drawing.Point(373, 16)
        TipoDocumentoLabel.Name = "TipoDocumentoLabel"
        TipoDocumentoLabel.Size = New System.Drawing.Size(89, 13)
        TipoDocumentoLabel.TabIndex = 4
        TipoDocumentoLabel.Text = "Tipo Documento:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(558, 15)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 6
        NumeroLabel.Text = "Numero:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(664, 16)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 8
        SiglaLabel.Text = "Sigla:"
        '
        'DocumentitestataBindingSource
        '
        Me.DocumentitestataBindingSource.DataMember = "documentitestata"
        Me.DocumentitestataBindingSource.DataSource = Me.FatturazionegevenDataSet
        '
        'FatturazionegevenDataSet
        '
        Me.FatturazionegevenDataSet.DataSetName = "fatturazionegevenDataSet"
        Me.FatturazionegevenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxLike)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(ScontoLabel)
        Me.GroupBox2.Controls.Add(Me.ScontoTextBox)
        Me.GroupBox2.Controls.Add(PagamentoLabel)
        Me.GroupBox2.Controls.Add(Me.PagamentoComboBox)
        Me.GroupBox2.Controls.Add(IvaLabel)
        Me.GroupBox2.Controls.Add(Me.IvaComboBox)
        Me.GroupBox2.Controls.Add(AgenteLabel)
        Me.GroupBox2.Controls.Add(Me.AgenteComboBox)
        Me.GroupBox2.Controls.Add(RiferimentoLabel)
        Me.GroupBox2.Controls.Add(Me.RiferimentoTextBox)
        Me.GroupBox2.Controls.Add(DataDocumentoLabel)
        Me.GroupBox2.Controls.Add(Me.DataDocumentoDateTimePicker)
        Me.GroupBox2.Controls.Add(AnagraficaLabel)
        Me.GroupBox2.Controls.Add(Me.AnagraficaComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TextBoxLike
        '
        Me.TextBoxLike.Location = New System.Drawing.Point(273, 28)
        Me.TextBoxLike.Name = "TextBoxLike"
        Me.TextBoxLike.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxLike.TabIndex = 15
        '
        'ScontoTextBox
        '
        Me.ScontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Sconto", True))
        Me.ScontoTextBox.Location = New System.Drawing.Point(300, 146)
        Me.ScontoTextBox.Name = "ScontoTextBox"
        Me.ScontoTextBox.Size = New System.Drawing.Size(94, 20)
        Me.ScontoTextBox.TabIndex = 13
        '
        'PagamentoComboBox
        '
        Me.PagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Pagamento", True))
        Me.PagamentoComboBox.FormattingEnabled = True
        Me.PagamentoComboBox.Location = New System.Drawing.Point(6, 146)
        Me.PagamentoComboBox.Name = "PagamentoComboBox"
        Me.PagamentoComboBox.Size = New System.Drawing.Size(287, 21)
        Me.PagamentoComboBox.TabIndex = 11
        '
        'IvaComboBox
        '
        Me.IvaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Iva", True))
        Me.IvaComboBox.FormattingEnabled = True
        Me.IvaComboBox.Location = New System.Drawing.Point(273, 106)
        Me.IvaComboBox.Name = "IvaComboBox"
        Me.IvaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IvaComboBox.TabIndex = 9
        '
        'AgenteComboBox
        '
        Me.AgenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Agente", True))
        Me.AgenteComboBox.FormattingEnabled = True
        Me.AgenteComboBox.Location = New System.Drawing.Point(9, 106)
        Me.AgenteComboBox.Name = "AgenteComboBox"
        Me.AgenteComboBox.Size = New System.Drawing.Size(258, 21)
        Me.AgenteComboBox.TabIndex = 7
        '
        'RiferimentoTextBox
        '
        Me.RiferimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Riferimento", True))
        Me.RiferimentoTextBox.Location = New System.Drawing.Point(172, 67)
        Me.RiferimentoTextBox.Name = "RiferimentoTextBox"
        Me.RiferimentoTextBox.Size = New System.Drawing.Size(222, 20)
        Me.RiferimentoTextBox.TabIndex = 5
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DocumentitestataBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(6, 67)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(160, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 3
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(6, 28)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(261, 21)
        Me.AnagraficaComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ProvinciaDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.ProvinciaDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(LocalitaDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.LocalitaDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(CapDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.CapDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(IndirizzoDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.IndirizzoDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(NominativoDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.NominativoDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(DestinazioneLabel)
        Me.GroupBox3.Controls.Add(Me.DestinazioneComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(418, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 180)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'ProvinciaDestinatarioTextBox
        '
        Me.ProvinciaDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ProvinciaDestinatario", True))
        Me.ProvinciaDestinatarioTextBox.Location = New System.Drawing.Point(390, 148)
        Me.ProvinciaDestinatarioTextBox.Name = "ProvinciaDestinatarioTextBox"
        Me.ProvinciaDestinatarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProvinciaDestinatarioTextBox.TabIndex = 11
        '
        'LocalitaDestinatarioTextBox
        '
        Me.LocalitaDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "LocalitaDestinatario", True))
        Me.LocalitaDestinatarioTextBox.Location = New System.Drawing.Point(112, 147)
        Me.LocalitaDestinatarioTextBox.Name = "LocalitaDestinatarioTextBox"
        Me.LocalitaDestinatarioTextBox.Size = New System.Drawing.Size(272, 20)
        Me.LocalitaDestinatarioTextBox.TabIndex = 9
        '
        'CapDestinatarioTextBox
        '
        Me.CapDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CapDestinatario", True))
        Me.CapDestinatarioTextBox.Location = New System.Drawing.Point(6, 147)
        Me.CapDestinatarioTextBox.Name = "CapDestinatarioTextBox"
        Me.CapDestinatarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CapDestinatarioTextBox.TabIndex = 7
        '
        'IndirizzoDestinatarioTextBox
        '
        Me.IndirizzoDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "IndirizzoDestinatario", True))
        Me.IndirizzoDestinatarioTextBox.Location = New System.Drawing.Point(6, 107)
        Me.IndirizzoDestinatarioTextBox.Name = "IndirizzoDestinatarioTextBox"
        Me.IndirizzoDestinatarioTextBox.Size = New System.Drawing.Size(484, 20)
        Me.IndirizzoDestinatarioTextBox.TabIndex = 5
        '
        'NominativoDestinatarioTextBox
        '
        Me.NominativoDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "NominativoDestinatario", True))
        Me.NominativoDestinatarioTextBox.Location = New System.Drawing.Point(6, 68)
        Me.NominativoDestinatarioTextBox.Name = "NominativoDestinatarioTextBox"
        Me.NominativoDestinatarioTextBox.Size = New System.Drawing.Size(484, 20)
        Me.NominativoDestinatarioTextBox.TabIndex = 3
        '
        'DestinazioneComboBox
        '
        Me.DestinazioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Destinazione", True))
        Me.DestinazioneComboBox.FormattingEnabled = True
        Me.DestinazioneComboBox.Location = New System.Drawing.Point(6, 29)
        Me.DestinazioneComboBox.Name = "DestinazioneComboBox"
        Me.DestinazioneComboBox.Size = New System.Drawing.Size(484, 21)
        Me.DestinazioneComboBox.TabIndex = 1
        '
        'DocumentitestataTableAdapter
        '
        Me.DocumentitestataTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.aziendeTableAdapter = Me.AziendeTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriemerceologicheTableAdapter = Nothing
        Me.TableAdapterManager.categorieTableAdapter = Nothing
        Me.TableAdapterManager.causalitrasportoTableAdapter = Nothing
        Me.TableAdapterManager.classiarticoloTableAdapter = Nothing
        Me.TableAdapterManager.contiTableAdapter = Nothing
        Me.TableAdapterManager.diviseTableAdapter = Nothing
        Me.TableAdapterManager.documentidettaglioTableAdapter = Me.DocumentidettaglioTableAdapter
        Me.TableAdapterManager.documentiscadenzeTableAdapter = Nothing
        Me.TableAdapterManager.documentitestataTableAdapter = Me.DocumentitestataTableAdapter
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
        'AziendeTableAdapter
        '
        Me.AziendeTableAdapter.ClearBeforeFill = True
        '
        'DocumentidettaglioTableAdapter
        '
        Me.DocumentidettaglioTableAdapter.ClearBeforeFill = True
        '
        'DocumentitestataBindingNavigator
        '
        Me.DocumentitestataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DocumentitestataBindingNavigator.BindingSource = Me.DocumentitestataBindingSource
        Me.DocumentitestataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DocumentitestataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DocumentitestataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DocumentitestataBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.DocumentitestataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DocumentitestataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocumentitestataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocumentitestataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocumentitestataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocumentitestataBindingNavigator.Name = "DocumentitestataBindingNavigator"
        Me.DocumentitestataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocumentitestataBindingNavigator.Size = New System.Drawing.Size(933, 38)
        Me.DocumentitestataBindingNavigator.TabIndex = 2
        Me.DocumentitestataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 35)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'DocumentidettaglioDataGridView
        '
        Me.DocumentidettaglioDataGridView.AutoGenerateColumns = False
        Me.DocumentidettaglioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DocumentidettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentidettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RigaTextBoxColumn, Me.ArticoloComboBoxColumn, Me.DescrizioneTextBoxColumn, Me.UnitaMisuraMagazzinoTextBoxColumn, Me.QuantitaMagazzinoTextBoxColumn, Me.UnitaMisuraTextBoxColumn, Me.QuantitaTextBoxColumn, Me.PrezzoUnitarioTextBoxColumn, Me.Sconto1TextBoxColumn, Me.Sconto2TextBoxColumn, Me.Sconto3TextBoxColumn, Me.ImportoTextBoxColumn, Me.ScorporoTextBoxColumn, Me.ClasseMerceologicaTextBoxColumn, Me.ClasseContropartitaTextBoxColumn, Me.ArticoloAliasTextBoxColumn, Me.MovimentoMagazzinoTextBoxColumn, Me.Iva, Me.Azienda, Me.Esercizio, Me.TipoDocumento, Me.Numero})
        Me.DocumentidettaglioDataGridView.DataSource = Me.DocumentidettaglioBindingSource
        Me.DocumentidettaglioDataGridView.Location = New System.Drawing.Point(12, 342)
        Me.DocumentidettaglioDataGridView.Name = "DocumentidettaglioDataGridView"
        Me.DocumentidettaglioDataGridView.Size = New System.Drawing.Size(912, 146)
        Me.DocumentidettaglioDataGridView.TabIndex = 4
        '
        'RigaTextBoxColumn
        '
        Me.RigaTextBoxColumn.DataPropertyName = "Riga"
        Me.RigaTextBoxColumn.HeaderText = "Riga"
        Me.RigaTextBoxColumn.Name = "RigaTextBoxColumn"
        Me.RigaTextBoxColumn.Width = 54
        '
        'ArticoloComboBoxColumn
        '
        Me.ArticoloComboBoxColumn.DataPropertyName = "Articolo"
        Me.ArticoloComboBoxColumn.HeaderText = "Articolo"
        Me.ArticoloComboBoxColumn.Name = "ArticoloComboBoxColumn"
        Me.ArticoloComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArticoloComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ArticoloComboBoxColumn.Width = 48
        '
        'DescrizioneTextBoxColumn
        '
        Me.DescrizioneTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneTextBoxColumn.Name = "DescrizioneTextBoxColumn"
        Me.DescrizioneTextBoxColumn.Width = 87
        '
        'UnitaMisuraMagazzinoTextBoxColumn
        '
        Me.UnitaMisuraMagazzinoTextBoxColumn.DataPropertyName = "UnitaMisuraMagazzino"
        Me.UnitaMisuraMagazzinoTextBoxColumn.HeaderText = "U.M.M."
        Me.UnitaMisuraMagazzinoTextBoxColumn.Name = "UnitaMisuraMagazzinoTextBoxColumn"
        Me.UnitaMisuraMagazzinoTextBoxColumn.Width = 67
        '
        'QuantitaMagazzinoTextBoxColumn
        '
        Me.QuantitaMagazzinoTextBoxColumn.DataPropertyName = "QuantitaMagazzino"
        Me.QuantitaMagazzinoTextBoxColumn.HeaderText = "Q.ta Mag."
        Me.QuantitaMagazzinoTextBoxColumn.Name = "QuantitaMagazzinoTextBoxColumn"
        Me.QuantitaMagazzinoTextBoxColumn.Width = 79
        '
        'UnitaMisuraTextBoxColumn
        '
        Me.UnitaMisuraTextBoxColumn.DataPropertyName = "UnitaMisura"
        Me.UnitaMisuraTextBoxColumn.HeaderText = "U.M.F."
        Me.UnitaMisuraTextBoxColumn.Name = "UnitaMisuraTextBoxColumn"
        Me.UnitaMisuraTextBoxColumn.Width = 64
        '
        'QuantitaTextBoxColumn
        '
        Me.QuantitaTextBoxColumn.DataPropertyName = "Quantita"
        Me.QuantitaTextBoxColumn.HeaderText = "Quantita"
        Me.QuantitaTextBoxColumn.Name = "QuantitaTextBoxColumn"
        Me.QuantitaTextBoxColumn.Width = 72
        '
        'PrezzoUnitarioTextBoxColumn
        '
        Me.PrezzoUnitarioTextBoxColumn.DataPropertyName = "PrezzoUnitario"
        Me.PrezzoUnitarioTextBoxColumn.HeaderText = "Prezzo"
        Me.PrezzoUnitarioTextBoxColumn.Name = "PrezzoUnitarioTextBoxColumn"
        Me.PrezzoUnitarioTextBoxColumn.Width = 64
        '
        'Sconto1TextBoxColumn
        '
        Me.Sconto1TextBoxColumn.DataPropertyName = "Sconto1"
        Me.Sconto1TextBoxColumn.HeaderText = "%1"
        Me.Sconto1TextBoxColumn.Name = "Sconto1TextBoxColumn"
        Me.Sconto1TextBoxColumn.Width = 46
        '
        'Sconto2TextBoxColumn
        '
        Me.Sconto2TextBoxColumn.DataPropertyName = "Sconto2"
        Me.Sconto2TextBoxColumn.HeaderText = "%2"
        Me.Sconto2TextBoxColumn.Name = "Sconto2TextBoxColumn"
        Me.Sconto2TextBoxColumn.Width = 46
        '
        'Sconto3TextBoxColumn
        '
        Me.Sconto3TextBoxColumn.DataPropertyName = "Sconto3"
        Me.Sconto3TextBoxColumn.HeaderText = "%3"
        Me.Sconto3TextBoxColumn.Name = "Sconto3TextBoxColumn"
        Me.Sconto3TextBoxColumn.Width = 46
        '
        'ImportoTextBoxColumn
        '
        Me.ImportoTextBoxColumn.DataPropertyName = "Importo"
        Me.ImportoTextBoxColumn.HeaderText = "Importo"
        Me.ImportoTextBoxColumn.Name = "ImportoTextBoxColumn"
        Me.ImportoTextBoxColumn.Width = 67
        '
        'ScorporoTextBoxColumn
        '
        Me.ScorporoTextBoxColumn.DataPropertyName = "Scorporo"
        Me.ScorporoTextBoxColumn.HeaderText = "*"
        Me.ScorporoTextBoxColumn.Name = "ScorporoTextBoxColumn"
        Me.ScorporoTextBoxColumn.Width = 36
        '
        'ClasseMerceologicaTextBoxColumn
        '
        Me.ClasseMerceologicaTextBoxColumn.DataPropertyName = "ClasseMerceologica"
        Me.ClasseMerceologicaTextBoxColumn.HeaderText = "C.M."
        Me.ClasseMerceologicaTextBoxColumn.Name = "ClasseMerceologicaTextBoxColumn"
        Me.ClasseMerceologicaTextBoxColumn.Width = 54
        '
        'ClasseContropartitaTextBoxColumn
        '
        Me.ClasseContropartitaTextBoxColumn.DataPropertyName = "ClasseContropartita"
        Me.ClasseContropartitaTextBoxColumn.HeaderText = "C.C."
        Me.ClasseContropartitaTextBoxColumn.Name = "ClasseContropartitaTextBoxColumn"
        Me.ClasseContropartitaTextBoxColumn.Width = 52
        '
        'ArticoloAliasTextBoxColumn
        '
        Me.ArticoloAliasTextBoxColumn.DataPropertyName = "ArticoloAlias"
        Me.ArticoloAliasTextBoxColumn.HeaderText = "ArticoloAlias"
        Me.ArticoloAliasTextBoxColumn.Name = "ArticoloAliasTextBoxColumn"
        Me.ArticoloAliasTextBoxColumn.Width = 89
        '
        'MovimentoMagazzinoTextBoxColumn
        '
        Me.MovimentoMagazzinoTextBoxColumn.DataPropertyName = "MovimentoMagazzino"
        Me.MovimentoMagazzinoTextBoxColumn.HeaderText = "N° Magazzino"
        Me.MovimentoMagazzinoTextBoxColumn.Name = "MovimentoMagazzinoTextBoxColumn"
        Me.MovimentoMagazzinoTextBoxColumn.Width = 98
        '
        'Iva
        '
        Me.Iva.DataPropertyName = "Iva"
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.Width = 47
        '
        'IvaTextBoxColumn
        '
        Me.IvaTextBoxColumn.DataPropertyName = "Iva"
        Me.IvaTextBoxColumn.HeaderText = "Iva"
        Me.IvaTextBoxColumn.Name = "IvaTextBoxColumn"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(AgenziaLabel)
        Me.GroupBox4.Controls.Add(Me.AgenziaTextBox)
        Me.GroupBox4.Controls.Add(BancaLabel)
        Me.GroupBox4.Controls.Add(Me.BancaTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(911, 43)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'AgenziaTextBox
        '
        Me.AgenziaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Agenzia", True))
        Me.AgenziaTextBox.Location = New System.Drawing.Point(462, 16)
        Me.AgenziaTextBox.Name = "AgenziaTextBox"
        Me.AgenziaTextBox.Size = New System.Drawing.Size(433, 20)
        Me.AgenziaTextBox.TabIndex = 3
        '
        'BancaTextBox
        '
        Me.BancaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Banca", True))
        Me.BancaTextBox.Location = New System.Drawing.Point(53, 16)
        Me.BancaTextBox.Name = "BancaTextBox"
        Me.BancaTextBox.Size = New System.Drawing.Size(349, 20)
        Me.BancaTextBox.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(MovimentoContabileLabel)
        Me.GroupBox5.Controls.Add(Me.MovimentoContabileTextBox)
        Me.GroupBox5.Controls.Add(TestProceduraLabel)
        Me.GroupBox5.Controls.Add(Me.TestProceduraTextBox)
        Me.GroupBox5.Controls.Add(TestDocumentoLabel)
        Me.GroupBox5.Controls.Add(Me.TestDocumentoTextBox)
        Me.GroupBox5.Controls.Add(DivisaLabel)
        Me.GroupBox5.Controls.Add(Me.DivisaComboBox)
        Me.GroupBox5.Controls.Add(TotaleDocumentoLabel)
        Me.GroupBox5.Controls.Add(Me.TotaleDocumentoTextBox)
        Me.GroupBox5.Controls.Add(ImportoIva2Label)
        Me.GroupBox5.Controls.Add(Me.ImportoIva2TextBox)
        Me.GroupBox5.Controls.Add(_Iva2Label)
        Me.GroupBox5.Controls.Add(Me._Iva2TextBox)
        Me.GroupBox5.Controls.Add(Imponibile2Label)
        Me.GroupBox5.Controls.Add(Me.Imponibile2TextBox)
        Me.GroupBox5.Controls.Add(CodiceIva2Label)
        Me.GroupBox5.Controls.Add(Me.CodiceIva2TextBox)
        Me.GroupBox5.Controls.Add(ImportoIva1Label)
        Me.GroupBox5.Controls.Add(Me.ImportoIva1TextBox)
        Me.GroupBox5.Controls.Add(_Iva1Label)
        Me.GroupBox5.Controls.Add(Me._Iva1TextBox)
        Me.GroupBox5.Controls.Add(Imponibile1Label)
        Me.GroupBox5.Controls.Add(Me.Imponibile1TextBox)
        Me.GroupBox5.Controls.Add(CodiceIva1Label)
        Me.GroupBox5.Controls.Add(Me.CodiceIva1TextBox)
        Me.GroupBox5.Controls.Add(VettoreLabel)
        Me.GroupBox5.Controls.Add(Me.VettoreComboBox)
        Me.GroupBox5.Controls.Add(TrasportoMezzoLabel)
        Me.GroupBox5.Controls.Add(Me.TrasportoMezzoComboBox)
        Me.GroupBox5.Controls.Add(AspettoBeniLabel)
        Me.GroupBox5.Controls.Add(Me.AspettoBeniComboBox)
        Me.GroupBox5.Controls.Add(OraTrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.OraTrasportoTextBox)
        Me.GroupBox5.Controls.Add(DataTrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.DataTrasportoTextBox)
        Me.GroupBox5.Controls.Add(PesoLabel)
        Me.GroupBox5.Controls.Add(Me.PesoTextBox)
        Me.GroupBox5.Controls.Add(ColliLabel)
        Me.GroupBox5.Controls.Add(Me.ColliTextBox)
        Me.GroupBox5.Controls.Add(PortoLabel)
        Me.GroupBox5.Controls.Add(Me.PortoComboBox)
        Me.GroupBox5.Controls.Add(CausaleTrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.CausaleTrasportoComboBox)
        Me.GroupBox5.Controls.Add(ImballoLabel)
        Me.GroupBox5.Controls.Add(Me.ImballoTextBox)
        Me.GroupBox5.Controls.Add(TrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.TrasportoTextBox)
        Me.GroupBox5.Controls.Add(ScontoCassaLabel)
        Me.GroupBox5.Controls.Add(Me.ScontoCassaTextBox)
        Me.GroupBox5.Controls.Add(TotaleMerceLabel)
        Me.GroupBox5.Controls.Add(Me.TotaleMerceTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 484)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(912, 183)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'MovimentoContabileTextBox
        '
        Me.MovimentoContabileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "MovimentoContabile", True))
        Me.MovimentoContabileTextBox.Location = New System.Drawing.Point(547, 156)
        Me.MovimentoContabileTextBox.Name = "MovimentoContabileTextBox"
        Me.MovimentoContabileTextBox.Size = New System.Drawing.Size(56, 20)
        Me.MovimentoContabileTextBox.TabIndex = 51
        '
        'TestProceduraTextBox
        '
        Me.TestProceduraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TestProcedura", True))
        Me.TestProceduraTextBox.Location = New System.Drawing.Point(547, 117)
        Me.TestProceduraTextBox.Name = "TestProceduraTextBox"
        Me.TestProceduraTextBox.Size = New System.Drawing.Size(56, 20)
        Me.TestProceduraTextBox.TabIndex = 49
        '
        'TestDocumentoTextBox
        '
        Me.TestDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TestDocumento", True))
        Me.TestDocumentoTextBox.Location = New System.Drawing.Point(547, 78)
        Me.TestDocumentoTextBox.Name = "TestDocumentoTextBox"
        Me.TestDocumentoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TestDocumentoTextBox.TabIndex = 47
        '
        'DivisaComboBox
        '
        Me.DivisaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Divisa", True))
        Me.DivisaComboBox.FormattingEnabled = True
        Me.DivisaComboBox.Location = New System.Drawing.Point(697, 159)
        Me.DivisaComboBox.Name = "DivisaComboBox"
        Me.DivisaComboBox.Size = New System.Drawing.Size(70, 21)
        Me.DivisaComboBox.TabIndex = 45
        '
        'TotaleDocumentoTextBox
        '
        Me.TotaleDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TotaleDocumento", True))
        Me.TotaleDocumentoTextBox.Location = New System.Drawing.Point(773, 159)
        Me.TotaleDocumentoTextBox.Name = "TotaleDocumentoTextBox"
        Me.TotaleDocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotaleDocumentoTextBox.TabIndex = 43
        '
        'ImportoIva2TextBox
        '
        Me.ImportoIva2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ImportoIva2", True))
        Me.ImportoIva2TextBox.Location = New System.Drawing.Point(260, 159)
        Me.ImportoIva2TextBox.Name = "ImportoIva2TextBox"
        Me.ImportoIva2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoIva2TextBox.TabIndex = 41
        '
        '_Iva2TextBox
        '
        Me._Iva2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "%Iva2", True))
        Me._Iva2TextBox.Location = New System.Drawing.Point(182, 159)
        Me._Iva2TextBox.Name = "_Iva2TextBox"
        Me._Iva2TextBox.Size = New System.Drawing.Size(72, 20)
        Me._Iva2TextBox.TabIndex = 39
        '
        'Imponibile2TextBox
        '
        Me.Imponibile2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imponibile2", True))
        Me.Imponibile2TextBox.Location = New System.Drawing.Point(76, 159)
        Me.Imponibile2TextBox.Name = "Imponibile2TextBox"
        Me.Imponibile2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Imponibile2TextBox.TabIndex = 37
        '
        'CodiceIva2TextBox
        '
        Me.CodiceIva2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CodiceIva2", True))
        Me.CodiceIva2TextBox.Location = New System.Drawing.Point(6, 159)
        Me.CodiceIva2TextBox.Name = "CodiceIva2TextBox"
        Me.CodiceIva2TextBox.Size = New System.Drawing.Size(64, 20)
        Me.CodiceIva2TextBox.TabIndex = 35
        '
        'ImportoIva1TextBox
        '
        Me.ImportoIva1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ImportoIva1", True))
        Me.ImportoIva1TextBox.Location = New System.Drawing.Point(260, 119)
        Me.ImportoIva1TextBox.Name = "ImportoIva1TextBox"
        Me.ImportoIva1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoIva1TextBox.TabIndex = 33
        '
        '_Iva1TextBox
        '
        Me._Iva1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "%Iva1", True))
        Me._Iva1TextBox.Location = New System.Drawing.Point(182, 119)
        Me._Iva1TextBox.Name = "_Iva1TextBox"
        Me._Iva1TextBox.Size = New System.Drawing.Size(72, 20)
        Me._Iva1TextBox.TabIndex = 31
        '
        'Imponibile1TextBox
        '
        Me.Imponibile1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imponibile1", True))
        Me.Imponibile1TextBox.Location = New System.Drawing.Point(76, 119)
        Me.Imponibile1TextBox.Name = "Imponibile1TextBox"
        Me.Imponibile1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Imponibile1TextBox.TabIndex = 29
        '
        'CodiceIva1TextBox
        '
        Me.CodiceIva1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CodiceIva1", True))
        Me.CodiceIva1TextBox.Location = New System.Drawing.Point(6, 119)
        Me.CodiceIva1TextBox.Name = "CodiceIva1TextBox"
        Me.CodiceIva1TextBox.Size = New System.Drawing.Size(64, 20)
        Me.CodiceIva1TextBox.TabIndex = 27
        '
        'VettoreComboBox
        '
        Me.VettoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Vettore", True))
        Me.VettoreComboBox.FormattingEnabled = True
        Me.VettoreComboBox.Location = New System.Drawing.Point(260, 77)
        Me.VettoreComboBox.Name = "VettoreComboBox"
        Me.VettoreComboBox.Size = New System.Drawing.Size(244, 21)
        Me.VettoreComboBox.TabIndex = 25
        '
        'TrasportoMezzoComboBox
        '
        Me.TrasportoMezzoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TrasportoMezzo", True))
        Me.TrasportoMezzoComboBox.FormattingEnabled = True
        Me.TrasportoMezzoComboBox.Location = New System.Drawing.Point(133, 77)
        Me.TrasportoMezzoComboBox.Name = "TrasportoMezzoComboBox"
        Me.TrasportoMezzoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TrasportoMezzoComboBox.TabIndex = 23
        '
        'AspettoBeniComboBox
        '
        Me.AspettoBeniComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "AspettoBeni", True))
        Me.AspettoBeniComboBox.FormattingEnabled = True
        Me.AspettoBeniComboBox.Location = New System.Drawing.Point(6, 77)
        Me.AspettoBeniComboBox.Name = "AspettoBeniComboBox"
        Me.AspettoBeniComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AspettoBeniComboBox.TabIndex = 21
        '
        'OraTrasportoTextBox
        '
        Me.OraTrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "OraTrasporto", True))
        Me.OraTrasportoTextBox.Location = New System.Drawing.Point(773, 77)
        Me.OraTrasportoTextBox.Name = "OraTrasportoTextBox"
        Me.OraTrasportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OraTrasportoTextBox.TabIndex = 19
        '
        'DataTrasportoTextBox
        '
        Me.DataTrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "DataTrasporto", True))
        Me.DataTrasportoTextBox.Location = New System.Drawing.Point(773, 33)
        Me.DataTrasportoTextBox.Name = "DataTrasportoTextBox"
        Me.DataTrasportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataTrasportoTextBox.TabIndex = 17
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(697, 33)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(70, 20)
        Me.PesoTextBox.TabIndex = 15
        '
        'ColliTextBox
        '
        Me.ColliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Colli", True))
        Me.ColliTextBox.Location = New System.Drawing.Point(637, 34)
        Me.ColliTextBox.Name = "ColliTextBox"
        Me.ColliTextBox.Size = New System.Drawing.Size(54, 20)
        Me.ColliTextBox.TabIndex = 13
        '
        'PortoComboBox
        '
        Me.PortoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Porto", True))
        Me.PortoComboBox.FormattingEnabled = True
        Me.PortoComboBox.Location = New System.Drawing.Point(510, 33)
        Me.PortoComboBox.Name = "PortoComboBox"
        Me.PortoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PortoComboBox.TabIndex = 11
        '
        'CausaleTrasportoComboBox
        '
        Me.CausaleTrasportoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CausaleTrasporto", True))
        Me.CausaleTrasportoComboBox.FormattingEnabled = True
        Me.CausaleTrasportoComboBox.Location = New System.Drawing.Point(383, 33)
        Me.CausaleTrasportoComboBox.Name = "CausaleTrasportoComboBox"
        Me.CausaleTrasportoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CausaleTrasportoComboBox.TabIndex = 9
        '
        'ImballoTextBox
        '
        Me.ImballoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imballo", True))
        Me.ImballoTextBox.Location = New System.Drawing.Point(287, 34)
        Me.ImballoTextBox.Name = "ImballoTextBox"
        Me.ImballoTextBox.Size = New System.Drawing.Size(90, 20)
        Me.ImballoTextBox.TabIndex = 7
        '
        'TrasportoTextBox
        '
        Me.TrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Trasporto", True))
        Me.TrasportoTextBox.Location = New System.Drawing.Point(191, 34)
        Me.TrasportoTextBox.Name = "TrasportoTextBox"
        Me.TrasportoTextBox.Size = New System.Drawing.Size(90, 20)
        Me.TrasportoTextBox.TabIndex = 5
        '
        'ScontoCassaTextBox
        '
        Me.ScontoCassaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ScontoCassa", True))
        Me.ScontoCassaTextBox.Location = New System.Drawing.Point(112, 34)
        Me.ScontoCassaTextBox.Name = "ScontoCassaTextBox"
        Me.ScontoCassaTextBox.Size = New System.Drawing.Size(73, 20)
        Me.ScontoCassaTextBox.TabIndex = 3
        '
        'TotaleMerceTextBox
        '
        Me.TotaleMerceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TotaleMerce", True))
        Me.TotaleMerceTextBox.Location = New System.Drawing.Point(6, 34)
        Me.TotaleMerceTextBox.Name = "TotaleMerceTextBox"
        Me.TotaleMerceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotaleMerceTextBox.TabIndex = 1
        '
        'AnagraficheTableAdapter1
        '
        Me.AnagraficheTableAdapter1.ClearBeforeFill = True
        '
        'ArticoliTableAdapter1
        '
        Me.ArticoliTableAdapter1.ClearBeforeFill = True
        '
        'TipidocumentoTableAdapter1
        '
        Me.TipidocumentoTableAdapter1.ClearBeforeFill = True
        '
        'ParametriivaTableAdapter1
        '
        Me.ParametriivaTableAdapter1.ClearBeforeFill = True
        '
        'AgentiTableAdapter1
        '
        Me.AgentiTableAdapter1.ClearBeforeFill = True
        '
        'PagamentitestataTableAdapter1
        '
        Me.PagamentitestataTableAdapter1.ClearBeforeFill = True
        '
        'TipitrasportoTableAdapter1
        '
        Me.TipitrasportoTableAdapter1.ClearBeforeFill = True
        '
        'AspettobeniTableAdapter1
        '
        Me.AspettobeniTableAdapter1.ClearBeforeFill = True
        '
        'CausalitrasportoTableAdapter1
        '
        Me.CausalitrasportoTableAdapter1.ClearBeforeFill = True
        '
        'ModitrasportoTableAdapter1
        '
        Me.ModitrasportoTableAdapter1.ClearBeforeFill = True
        '
        'VettoriTableAdapter1
        '
        Me.VettoriTableAdapter1.ClearBeforeFill = True
        '
        'DiviseTableAdapter1
        '
        Me.DiviseTableAdapter1.ClearBeforeFill = True
        '
        'AnagraficadestinazioniTableAdapter1
        '
        Me.AnagraficadestinazioniTableAdapter1.ClearBeforeFill = True
        '
        'EsercizicontabiliTableAdapter1
        '
        Me.EsercizicontabiliTableAdapter1.ClearBeforeFill = True
        '
        'AnagraficafatturazioneTableAdapter1
        '
        Me.AnagraficafatturazioneTableAdapter1.ClearBeforeFill = True
        '
        'AziendaComboBox
        '
        Me.AziendaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Azienda", True))
        Me.AziendaComboBox.FormattingEnabled = True
        Me.AziendaComboBox.Location = New System.Drawing.Point(6, 30)
        Me.AziendaComboBox.Name = "AziendaComboBox"
        Me.AziendaComboBox.Size = New System.Drawing.Size(179, 21)
        Me.AziendaComboBox.TabIndex = 1
        '
        'EsercizioComboBox
        '
        Me.EsercizioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Esercizio", True))
        Me.EsercizioComboBox.FormattingEnabled = True
        Me.EsercizioComboBox.Location = New System.Drawing.Point(191, 30)
        Me.EsercizioComboBox.Name = "EsercizioComboBox"
        Me.EsercizioComboBox.Size = New System.Drawing.Size(179, 21)
        Me.EsercizioComboBox.TabIndex = 3
        '
        'TipoDocumentoComboBox
        '
        Me.TipoDocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TipoDocumento", True))
        Me.TipoDocumentoComboBox.FormattingEnabled = True
        Me.TipoDocumentoComboBox.Location = New System.Drawing.Point(376, 30)
        Me.TipoDocumentoComboBox.Name = "TipoDocumentoComboBox"
        Me.TipoDocumentoComboBox.Size = New System.Drawing.Size(179, 21)
        Me.TipoDocumentoComboBox.TabIndex = 5
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(561, 30)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroTextBox.TabIndex = 7
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Sigla", True))
        Me.SiglaTextBox.Location = New System.Drawing.Point(667, 30)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(44, 20)
        Me.SiglaTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SiglaLabel)
        Me.GroupBox1.Controls.Add(Me.SiglaTextBox)
        Me.GroupBox1.Controls.Add(NumeroLabel)
        Me.GroupBox1.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox1.Controls.Add(TipoDocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.TipoDocumentoComboBox)
        Me.GroupBox1.Controls.Add(EsercizioLabel)
        Me.GroupBox1.Controls.Add(Me.EsercizioComboBox)
        Me.GroupBox1.Controls.Add(AziendaLabel)
        Me.GroupBox1.Controls.Add(Me.AziendaComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(906, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ArticolimisureTableAdapter1
        '
        Me.ArticolimisureTableAdapter1.ClearBeforeFill = True
        '
        'Azienda
        '
        Me.Azienda.DataPropertyName = "Azienda"
        Me.Azienda.HeaderText = "Azienda"
        Me.Azienda.Name = "Azienda"
        Me.Azienda.Width = 70
        '
        'Esercizio
        '
        Me.Esercizio.DataPropertyName = "Esercizio"
        Me.Esercizio.HeaderText = "Esercizio"
        Me.Esercizio.Name = "Esercizio"
        Me.Esercizio.Width = 74
        '
        'TipoDocumento
        '
        Me.TipoDocumento.DataPropertyName = "TipoDocumento"
        Me.TipoDocumento.HeaderText = "TipoDocumento"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.Width = 108
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "Numero"
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 69
        '
        'DocumentidettaglioBindingSource
        '
        Me.DocumentidettaglioBindingSource.DataMember = "documentitestata_documentidettaglio"
        Me.DocumentidettaglioBindingSource.DataSource = Me.DocumentitestataBindingSource
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = Global.GeVen_SE_2015.My.Resources.Resources.inserimento
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(47, 35)
        Me.BindingNavigatorAddNewItem.Text = "&Nuovo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = Global.GeVen_SE_2015.My.Resources.Resources.Trash
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(50, 35)
        Me.BindingNavigatorDeleteItem.Text = "&Elimina"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'DocumentitestataBindingNavigatorSaveItem
        '
        Me.DocumentitestataBindingNavigatorSaveItem.Image = Global.GeVen_SE_2015.My.Resources.Resources.salva
        Me.DocumentitestataBindingNavigatorSaveItem.Name = "DocumentitestataBindingNavigatorSaveItem"
        Me.DocumentitestataBindingNavigatorSaveItem.Size = New System.Drawing.Size(38, 35)
        Me.DocumentitestataBindingNavigatorSaveItem.Text = "&Salva"
        Me.DocumentitestataBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = Global.GeVen_SE_2015.My.Resources.Resources.ricerca
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton1.Text = "&Ricerca"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.GeVen_SE_2015.My.Resources.Resources.stampa
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 35)
        Me.ToolStripButton2.Text = "&Stampa"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.GeVen_SE_2015.My.Resources.Resources.text_effects
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(372, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 20)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DocumentitestatadocumentidettaglioBindingSource1
        '
        Me.DocumentitestatadocumentidettaglioBindingSource1.DataMember = "documentitestata_documentidettaglio"
        Me.DocumentitestatadocumentidettaglioBindingSource1.DataSource = Me.DocumentitestataBindingSource
        '
        'DocumentitestatadocumentidettaglioBindingSource
        '
        Me.DocumentitestatadocumentidettaglioBindingSource.DataMember = "documentitestata_documentidettaglio"
        Me.DocumentitestatadocumentidettaglioBindingSource.DataSource = Me.DocumentitestataBindingSource
        '
        'GestioneDocumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 673)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DocumentidettaglioDataGridView)
        Me.Controls.Add(Me.DocumentitestataBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GestioneDocumenti"
        Me.Text = "GestioneDocumenti"
        CType(Me.DocumentitestataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DocumentitestataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentitestataBindingNavigator.ResumeLayout(False)
        Me.DocumentitestataBindingNavigator.PerformLayout()
        CType(Me.DocumentidettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentitestatadocumentidettaglioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentitestatadocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FatturazionegevenDataSet As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents DocumentitestataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentitestataTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentitestataTableAdapter
    Friend WithEvents TableAdapterManager As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocumentitestataBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DocumentitestataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DocumentidettaglioTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentidettaglioTableAdapter
    Friend WithEvents DocumentidettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentidettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AziendeTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aziendeTableAdapter
    Friend WithEvents AnagraficaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DestinazioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgenteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RiferimentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IvaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProvinciaDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalitaDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NominativoDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents AgenziaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PortoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CausaleTrasportoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImballoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScontoCassaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotaleMerceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VettoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrasportoMezzoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AspettoBeniComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OraTrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceIva1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _Iva1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Imponibile1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoIva2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _Iva2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Imponibile2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceIva2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoIva1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DivisaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TotaleDocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TestDocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MovimentoContabileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TestProceduraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficheTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficheTableAdapter
    Friend WithEvents ArticoliTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.articoliTableAdapter
    Friend WithEvents IvaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentitestatadocumentidettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipidocumentoTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.tipidocumentoTableAdapter
    Friend WithEvents ParametriivaTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.parametriivaTableAdapter
    Friend WithEvents AgentiTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.agentiTableAdapter
    Friend WithEvents PagamentitestataTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.pagamentitestataTableAdapter
    Friend WithEvents TipitrasportoTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.tipitrasportoTableAdapter
    Friend WithEvents AspettobeniTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.aspettobeniTableAdapter
    Friend WithEvents CausalitrasportoTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.causalitrasportoTableAdapter
    Friend WithEvents ModitrasportoTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.moditrasportoTableAdapter
    Friend WithEvents VettoriTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.vettoriTableAdapter
    Friend WithEvents DiviseTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.diviseTableAdapter
    Friend WithEvents AnagraficadestinazioniTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficadestinazioniTableAdapter
    Friend WithEvents EsercizicontabiliTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.esercizicontabiliTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxLike As System.Windows.Forms.TextBox
    Friend WithEvents AnagraficafatturazioneTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.anagraficafatturazioneTableAdapter
    Friend WithEvents AziendaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EsercizioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoDocumentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiglaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DocumentitestatadocumentidettaglioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RigaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticoloComboBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitaMisuraMagazzinoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantitaMagazzinoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitaMisuraTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantitaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoUnitarioTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sconto1TextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sconto2TextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sconto3TextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScorporoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasseMerceologicaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClasseContropartitaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticoloAliasTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimentoMagazzinoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Azienda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Esercizio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticolimisureTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.articolimisureTableAdapter
End Class
