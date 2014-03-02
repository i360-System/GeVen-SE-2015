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
        Dim AziendaLabel As System.Windows.Forms.Label
        Dim EsercizioLabel As System.Windows.Forms.Label
        Dim TipoDocumentoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim SiglaLabel As System.Windows.Forms.Label
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim DestinazioneLabel As System.Windows.Forms.Label
        Dim DataDocumentoLabel As System.Windows.Forms.Label
        Dim RiferimentoLabel As System.Windows.Forms.Label
        Dim AgenteLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim PagamentoLabel As System.Windows.Forms.Label
        Dim ScontoLabel As System.Windows.Forms.Label
        Dim BancaLabel As System.Windows.Forms.Label
        Dim AgenziaLabel As System.Windows.Forms.Label
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
        Dim TotaleMerceLabel As System.Windows.Forms.Label
        Dim ScontoCassaLabel As System.Windows.Forms.Label
        Dim DivisaLabel As System.Windows.Forms.Label
        Dim TotaleDocumentoLabel As System.Windows.Forms.Label
        Dim CodiceIva1Label As System.Windows.Forms.Label
        Dim Imponibile1Label As System.Windows.Forms.Label
        Dim _Iva1Label As System.Windows.Forms.Label
        Dim ImportoIva1Label As System.Windows.Forms.Label
        Dim TotaleProvvigioniLabel As System.Windows.Forms.Label
        Dim ImportoIva2Label As System.Windows.Forms.Label
        Dim _Iva2Label As System.Windows.Forms.Label
        Dim Imponibile2Label As System.Windows.Forms.Label
        Dim CodiceIva2Label As System.Windows.Forms.Label
        Dim NominativoDestinatarioLabel As System.Windows.Forms.Label
        Dim IndirizzoDestinatarioLabel As System.Windows.Forms.Label
        Dim CapDestinatarioLabel As System.Windows.Forms.Label
        Dim ProvinciaDestinatarioLabel As System.Windows.Forms.Label
        Dim MovimentoContabileLabel As System.Windows.Forms.Label
        Dim TestDocumentoLabel As System.Windows.Forms.Label
        Dim TestProceduraLabel As System.Windows.Forms.Label
        Dim LocalitaDestinatarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioneDocumenti))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SiglaTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentitestataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatturazionegevenDataSet1 = New GeVen_SE_2015.fatturazionegevenDataSet()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.EsercizioComboBox = New System.Windows.Forms.ComboBox()
        Me.AziendaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ScontoTextBox = New System.Windows.Forms.TextBox()
        Me.PagamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.IvaComboBox = New System.Windows.Forms.ComboBox()
        Me.AgenteComboBox = New System.Windows.Forms.ComboBox()
        Me.RiferimentoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDocumentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AnagraficaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LocalitaDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.CapDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.NominativoDestinatarioTextBox = New System.Windows.Forms.TextBox()
        Me.DestinazioneComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AgenziaTextBox = New System.Windows.Forms.TextBox()
        Me.BancaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.VettoreComboBox = New System.Windows.Forms.ComboBox()
        Me.TrasportoMezzoComboBox = New System.Windows.Forms.ComboBox()
        Me.AspettoBeniComboBox = New System.Windows.Forms.ComboBox()
        Me.OraTrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.DataTrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.ColliTextBox = New System.Windows.Forms.TextBox()
        Me.PortoTextBox = New System.Windows.Forms.TextBox()
        Me.CausaleTrasportoComboBox = New System.Windows.Forms.ComboBox()
        Me.ImballoTextBox = New System.Windows.Forms.TextBox()
        Me.TrasportoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TestProceduraTextBox = New System.Windows.Forms.TextBox()
        Me.TestDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.MovimentoContabileTextBox = New System.Windows.Forms.TextBox()
        Me.CodiceIva2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Imponibile2TextBox = New System.Windows.Forms.TextBox()
        Me._Iva2TextBox = New System.Windows.Forms.TextBox()
        Me.ImportoIva2TextBox = New System.Windows.Forms.TextBox()
        Me.TotaleProvvigioniTextBox = New System.Windows.Forms.TextBox()
        Me.ImportoIva1TextBox = New System.Windows.Forms.TextBox()
        Me._Iva1TextBox = New System.Windows.Forms.TextBox()
        Me.Imponibile1TextBox = New System.Windows.Forms.TextBox()
        Me.CodiceIva1ComboBox = New System.Windows.Forms.ComboBox()
        Me.TotaleDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.DivisaComboBox = New System.Windows.Forms.ComboBox()
        Me.ScontoCassaTextBox = New System.Windows.Forms.TextBox()
        Me.TotaleMerceTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentitestataTableAdapter1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentitestataTableAdapter()
        Me.TableAdapterManager1 = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager()
        Me.DocumentidettaglioTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentidettaglioTableAdapter()
        Me.DocumentitestataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentitestataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DocumentidettaglioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentidettaglioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoProvvigioniTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticoloAliasTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimentoMagazzinoTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RigaTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticoloTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PercentoProvvigioniTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AziendaLabel = New System.Windows.Forms.Label()
        EsercizioLabel = New System.Windows.Forms.Label()
        TipoDocumentoLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        SiglaLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        DestinazioneLabel = New System.Windows.Forms.Label()
        DataDocumentoLabel = New System.Windows.Forms.Label()
        RiferimentoLabel = New System.Windows.Forms.Label()
        AgenteLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        PagamentoLabel = New System.Windows.Forms.Label()
        ScontoLabel = New System.Windows.Forms.Label()
        BancaLabel = New System.Windows.Forms.Label()
        AgenziaLabel = New System.Windows.Forms.Label()
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
        TotaleMerceLabel = New System.Windows.Forms.Label()
        ScontoCassaLabel = New System.Windows.Forms.Label()
        DivisaLabel = New System.Windows.Forms.Label()
        TotaleDocumentoLabel = New System.Windows.Forms.Label()
        CodiceIva1Label = New System.Windows.Forms.Label()
        Imponibile1Label = New System.Windows.Forms.Label()
        _Iva1Label = New System.Windows.Forms.Label()
        ImportoIva1Label = New System.Windows.Forms.Label()
        TotaleProvvigioniLabel = New System.Windows.Forms.Label()
        ImportoIva2Label = New System.Windows.Forms.Label()
        _Iva2Label = New System.Windows.Forms.Label()
        Imponibile2Label = New System.Windows.Forms.Label()
        CodiceIva2Label = New System.Windows.Forms.Label()
        NominativoDestinatarioLabel = New System.Windows.Forms.Label()
        IndirizzoDestinatarioLabel = New System.Windows.Forms.Label()
        CapDestinatarioLabel = New System.Windows.Forms.Label()
        ProvinciaDestinatarioLabel = New System.Windows.Forms.Label()
        MovimentoContabileLabel = New System.Windows.Forms.Label()
        TestDocumentoLabel = New System.Windows.Forms.Label()
        TestProceduraLabel = New System.Windows.Forms.Label()
        LocalitaDestinatarioLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DocumentitestataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturazionegevenDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DocumentitestataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentitestataBindingNavigator.SuspendLayout()
        CType(Me.DocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentidettaglioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AziendaLabel
        '
        AziendaLabel.AutoSize = True
        AziendaLabel.Location = New System.Drawing.Point(8, 22)
        AziendaLabel.Name = "AziendaLabel"
        AziendaLabel.Size = New System.Drawing.Size(48, 13)
        AziendaLabel.TabIndex = 0
        AziendaLabel.Text = "Azienda:"
        '
        'EsercizioLabel
        '
        EsercizioLabel.AutoSize = True
        EsercizioLabel.Location = New System.Drawing.Point(201, 22)
        EsercizioLabel.Name = "EsercizioLabel"
        EsercizioLabel.Size = New System.Drawing.Size(52, 13)
        EsercizioLabel.TabIndex = 0
        EsercizioLabel.Text = "Esercizio:"
        '
        'TipoDocumentoLabel
        '
        TipoDocumentoLabel.AutoSize = True
        TipoDocumentoLabel.Location = New System.Drawing.Point(402, 22)
        TipoDocumentoLabel.Name = "TipoDocumentoLabel"
        TipoDocumentoLabel.Size = New System.Drawing.Size(89, 13)
        TipoDocumentoLabel.TabIndex = 4
        TipoDocumentoLabel.Text = "Tipo Documento:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(639, 22)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 6
        NumeroLabel.Text = "Numero:"
        '
        'SiglaLabel
        '
        SiglaLabel.AutoSize = True
        SiglaLabel.Location = New System.Drawing.Point(793, 22)
        SiglaLabel.Name = "SiglaLabel"
        SiglaLabel.Size = New System.Drawing.Size(33, 13)
        SiglaLabel.TabIndex = 8
        SiglaLabel.Text = "Sigla:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(7, 22)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(61, 13)
        AnagraficaLabel.TabIndex = 0
        AnagraficaLabel.Text = "Anagrafica:"
        '
        'DestinazioneLabel
        '
        DestinazioneLabel.AutoSize = True
        DestinazioneLabel.Location = New System.Drawing.Point(9, 22)
        DestinazioneLabel.Name = "DestinazioneLabel"
        DestinazioneLabel.Size = New System.Drawing.Size(71, 13)
        DestinazioneLabel.TabIndex = 0
        DestinazioneLabel.Text = "Destinazione:"
        '
        'DataDocumentoLabel
        '
        DataDocumentoLabel.AutoSize = True
        DataDocumentoLabel.Location = New System.Drawing.Point(8, 56)
        DataDocumentoLabel.Name = "DataDocumentoLabel"
        DataDocumentoLabel.Size = New System.Drawing.Size(91, 13)
        DataDocumentoLabel.TabIndex = 2
        DataDocumentoLabel.Text = "Data Documento:"
        '
        'RiferimentoLabel
        '
        RiferimentoLabel.AutoSize = True
        RiferimentoLabel.Location = New System.Drawing.Point(8, 81)
        RiferimentoLabel.Name = "RiferimentoLabel"
        RiferimentoLabel.Size = New System.Drawing.Size(63, 13)
        RiferimentoLabel.TabIndex = 4
        RiferimentoLabel.Text = "Riferimento:"
        '
        'AgenteLabel
        '
        AgenteLabel.AutoSize = True
        AgenteLabel.Location = New System.Drawing.Point(8, 110)
        AgenteLabel.Name = "AgenteLabel"
        AgenteLabel.Size = New System.Drawing.Size(44, 13)
        AgenteLabel.TabIndex = 6
        AgenteLabel.Text = "Agente:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(8, 143)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(25, 13)
        IvaLabel.TabIndex = 8
        IvaLabel.Text = "Iva:"
        '
        'PagamentoLabel
        '
        PagamentoLabel.AutoSize = True
        PagamentoLabel.Location = New System.Drawing.Point(116, 143)
        PagamentoLabel.Name = "PagamentoLabel"
        PagamentoLabel.Size = New System.Drawing.Size(64, 13)
        PagamentoLabel.TabIndex = 10
        PagamentoLabel.Text = "Pagamento:"
        '
        'ScontoLabel
        '
        ScontoLabel.AutoSize = True
        ScontoLabel.Location = New System.Drawing.Point(320, 143)
        ScontoLabel.Name = "ScontoLabel"
        ScontoLabel.Size = New System.Drawing.Size(44, 13)
        ScontoLabel.TabIndex = 12
        ScontoLabel.Text = "Sconto:"
        '
        'BancaLabel
        '
        BancaLabel.AutoSize = True
        BancaLabel.Location = New System.Drawing.Point(8, 28)
        BancaLabel.Name = "BancaLabel"
        BancaLabel.Size = New System.Drawing.Size(41, 13)
        BancaLabel.TabIndex = 0
        BancaLabel.Text = "Banca:"
        '
        'AgenziaLabel
        '
        AgenziaLabel.AutoSize = True
        AgenziaLabel.Location = New System.Drawing.Point(443, 28)
        AgenziaLabel.Name = "AgenziaLabel"
        AgenziaLabel.Size = New System.Drawing.Size(48, 13)
        AgenziaLabel.TabIndex = 2
        AgenziaLabel.Text = "Agenzia:"
        '
        'TrasportoLabel
        '
        TrasportoLabel.AutoSize = True
        TrasportoLabel.Location = New System.Drawing.Point(13, 22)
        TrasportoLabel.Name = "TrasportoLabel"
        TrasportoLabel.Size = New System.Drawing.Size(55, 13)
        TrasportoLabel.TabIndex = 72
        TrasportoLabel.Text = "Trasporto:"
        '
        'ImballoLabel
        '
        ImballoLabel.AutoSize = True
        ImballoLabel.Location = New System.Drawing.Point(180, 22)
        ImballoLabel.Name = "ImballoLabel"
        ImballoLabel.Size = New System.Drawing.Size(43, 13)
        ImballoLabel.TabIndex = 73
        ImballoLabel.Text = "Imballo:"
        '
        'CausaleTrasportoLabel
        '
        CausaleTrasportoLabel.AutoSize = True
        CausaleTrasportoLabel.Location = New System.Drawing.Point(335, 22)
        CausaleTrasportoLabel.Name = "CausaleTrasportoLabel"
        CausaleTrasportoLabel.Size = New System.Drawing.Size(96, 13)
        CausaleTrasportoLabel.TabIndex = 74
        CausaleTrasportoLabel.Text = "Causale Trasporto:"
        '
        'PortoLabel
        '
        PortoLabel.AutoSize = True
        PortoLabel.Location = New System.Drawing.Point(564, 22)
        PortoLabel.Name = "PortoLabel"
        PortoLabel.Size = New System.Drawing.Size(35, 13)
        PortoLabel.TabIndex = 75
        PortoLabel.Text = "Porto:"
        '
        'ColliLabel
        '
        ColliLabel.AutoSize = True
        ColliLabel.Location = New System.Drawing.Point(719, 23)
        ColliLabel.Name = "ColliLabel"
        ColliLabel.Size = New System.Drawing.Size(29, 13)
        ColliLabel.TabIndex = 76
        ColliLabel.Text = "Colli:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(34, 54)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 77
        PesoLabel.Text = "Peso:"
        '
        'DataTrasportoLabel
        '
        DataTrasportoLabel.AutoSize = True
        DataTrasportoLabel.Location = New System.Drawing.Point(180, 54)
        DataTrasportoLabel.Name = "DataTrasportoLabel"
        DataTrasportoLabel.Size = New System.Drawing.Size(81, 13)
        DataTrasportoLabel.TabIndex = 78
        DataTrasportoLabel.Text = "Data Trasporto:"
        '
        'OraTrasportoLabel
        '
        OraTrasportoLabel.AutoSize = True
        OraTrasportoLabel.Location = New System.Drawing.Point(373, 54)
        OraTrasportoLabel.Name = "OraTrasportoLabel"
        OraTrasportoLabel.Size = New System.Drawing.Size(75, 13)
        OraTrasportoLabel.TabIndex = 79
        OraTrasportoLabel.Text = "Ora Trasporto:"
        '
        'AspettoBeniLabel
        '
        AspettoBeniLabel.AutoSize = True
        AspettoBeniLabel.Location = New System.Drawing.Point(7, 93)
        AspettoBeniLabel.Name = "AspettoBeniLabel"
        AspettoBeniLabel.Size = New System.Drawing.Size(70, 13)
        AspettoBeniLabel.TabIndex = 80
        AspettoBeniLabel.Text = "Aspetto Beni:"
        '
        'TrasportoMezzoLabel
        '
        TrasportoMezzoLabel.AutoSize = True
        TrasportoMezzoLabel.Location = New System.Drawing.Point(295, 93)
        TrasportoMezzoLabel.Name = "TrasportoMezzoLabel"
        TrasportoMezzoLabel.Size = New System.Drawing.Size(89, 13)
        TrasportoMezzoLabel.TabIndex = 81
        TrasportoMezzoLabel.Text = "Trasporto Mezzo:"
        '
        'VettoreLabel
        '
        VettoreLabel.AutoSize = True
        VettoreLabel.Location = New System.Drawing.Point(639, 93)
        VettoreLabel.Name = "VettoreLabel"
        VettoreLabel.Size = New System.Drawing.Size(44, 13)
        VettoreLabel.TabIndex = 82
        VettoreLabel.Text = "Vettore:"
        '
        'TotaleMerceLabel
        '
        TotaleMerceLabel.AutoSize = True
        TotaleMerceLabel.Location = New System.Drawing.Point(689, 13)
        TotaleMerceLabel.Name = "TotaleMerceLabel"
        TotaleMerceLabel.Size = New System.Drawing.Size(73, 13)
        TotaleMerceLabel.TabIndex = 88
        TotaleMerceLabel.Text = "Totale Merce:"
        '
        'ScontoCassaLabel
        '
        ScontoCassaLabel.AutoSize = True
        ScontoCassaLabel.Location = New System.Drawing.Point(791, 13)
        ScontoCassaLabel.Name = "ScontoCassaLabel"
        ScontoCassaLabel.Size = New System.Drawing.Size(76, 13)
        ScontoCassaLabel.TabIndex = 89
        ScontoCassaLabel.Text = "Sconto Cassa:"
        '
        'DivisaLabel
        '
        DivisaLabel.AutoSize = True
        DivisaLabel.Location = New System.Drawing.Point(791, 55)
        DivisaLabel.Name = "DivisaLabel"
        DivisaLabel.Size = New System.Drawing.Size(39, 13)
        DivisaLabel.TabIndex = 90
        DivisaLabel.Text = "Divisa:"
        '
        'TotaleDocumentoLabel
        '
        TotaleDocumentoLabel.AutoSize = True
        TotaleDocumentoLabel.Location = New System.Drawing.Point(686, 55)
        TotaleDocumentoLabel.Name = "TotaleDocumentoLabel"
        TotaleDocumentoLabel.Size = New System.Drawing.Size(98, 13)
        TotaleDocumentoLabel.TabIndex = 91
        TotaleDocumentoLabel.Text = "Totale Documento:"
        '
        'CodiceIva1Label
        '
        CodiceIva1Label.AutoSize = True
        CodiceIva1Label.Location = New System.Drawing.Point(8, 13)
        CodiceIva1Label.Name = "CodiceIva1Label"
        CodiceIva1Label.Size = New System.Drawing.Size(67, 13)
        CodiceIva1Label.TabIndex = 92
        CodiceIva1Label.Text = "Codice Iva1:"
        '
        'Imponibile1Label
        '
        Imponibile1Label.AutoSize = True
        Imponibile1Label.Location = New System.Drawing.Point(133, 14)
        Imponibile1Label.Name = "Imponibile1Label"
        Imponibile1Label.Size = New System.Drawing.Size(63, 13)
        Imponibile1Label.TabIndex = 93
        Imponibile1Label.Text = "Imponibile1:"
        '
        '_Iva1Label
        '
        _Iva1Label.AutoSize = True
        _Iva1Label.Location = New System.Drawing.Point(239, 15)
        _Iva1Label.Name = "_Iva1Label"
        _Iva1Label.Size = New System.Drawing.Size(39, 13)
        _Iva1Label.TabIndex = 94
        _Iva1Label.Text = "%Iva1:"
        '
        'ImportoIva1Label
        '
        ImportoIva1Label.AutoSize = True
        ImportoIva1Label.Location = New System.Drawing.Point(345, 15)
        ImportoIva1Label.Name = "ImportoIva1Label"
        ImportoIva1Label.Size = New System.Drawing.Size(69, 13)
        ImportoIva1Label.TabIndex = 95
        ImportoIva1Label.Text = "Importo Iva1:"
        '
        'TotaleProvvigioniLabel
        '
        TotaleProvvigioniLabel.AutoSize = True
        TotaleProvvigioniLabel.Location = New System.Drawing.Point(451, 55)
        TotaleProvvigioniLabel.Name = "TotaleProvvigioniLabel"
        TotaleProvvigioniLabel.Size = New System.Drawing.Size(95, 13)
        TotaleProvvigioniLabel.TabIndex = 96
        TotaleProvvigioniLabel.Text = "Totale Provvigioni:"
        '
        'ImportoIva2Label
        '
        ImportoIva2Label.AutoSize = True
        ImportoIva2Label.Location = New System.Drawing.Point(345, 56)
        ImportoIva2Label.Name = "ImportoIva2Label"
        ImportoIva2Label.Size = New System.Drawing.Size(69, 13)
        ImportoIva2Label.TabIndex = 97
        ImportoIva2Label.Text = "Importo Iva2:"
        '
        '_Iva2Label
        '
        _Iva2Label.AutoSize = True
        _Iva2Label.Location = New System.Drawing.Point(239, 58)
        _Iva2Label.Name = "_Iva2Label"
        _Iva2Label.Size = New System.Drawing.Size(39, 13)
        _Iva2Label.TabIndex = 98
        _Iva2Label.Text = "%Iva2:"
        '
        'Imponibile2Label
        '
        Imponibile2Label.AutoSize = True
        Imponibile2Label.Location = New System.Drawing.Point(133, 56)
        Imponibile2Label.Name = "Imponibile2Label"
        Imponibile2Label.Size = New System.Drawing.Size(63, 13)
        Imponibile2Label.TabIndex = 99
        Imponibile2Label.Text = "Imponibile2:"
        '
        'CodiceIva2Label
        '
        CodiceIva2Label.AutoSize = True
        CodiceIva2Label.Location = New System.Drawing.Point(6, 54)
        CodiceIva2Label.Name = "CodiceIva2Label"
        CodiceIva2Label.Size = New System.Drawing.Size(67, 13)
        CodiceIva2Label.TabIndex = 100
        CodiceIva2Label.Text = "Codice Iva2:"
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
        IndirizzoDestinatarioLabel.Location = New System.Drawing.Point(18, 84)
        IndirizzoDestinatarioLabel.Name = "IndirizzoDestinatarioLabel"
        IndirizzoDestinatarioLabel.Size = New System.Drawing.Size(107, 13)
        IndirizzoDestinatarioLabel.TabIndex = 4
        IndirizzoDestinatarioLabel.Text = "Indirizzo Destinatario:"
        '
        'CapDestinatarioLabel
        '
        CapDestinatarioLabel.AutoSize = True
        CapDestinatarioLabel.Location = New System.Drawing.Point(22, 109)
        CapDestinatarioLabel.Name = "CapDestinatarioLabel"
        CapDestinatarioLabel.Size = New System.Drawing.Size(88, 13)
        CapDestinatarioLabel.TabIndex = 6
        CapDestinatarioLabel.Text = "Cap Destinatario:"
        '
        'ProvinciaDestinatarioLabel
        '
        ProvinciaDestinatarioLabel.AutoSize = True
        ProvinciaDestinatarioLabel.Location = New System.Drawing.Point(359, 110)
        ProvinciaDestinatarioLabel.Name = "ProvinciaDestinatarioLabel"
        ProvinciaDestinatarioLabel.Size = New System.Drawing.Size(113, 13)
        ProvinciaDestinatarioLabel.TabIndex = 8
        ProvinciaDestinatarioLabel.Text = "Provincia Destinatario:"
        '
        'MovimentoContabileLabel
        '
        MovimentoContabileLabel.AutoSize = True
        MovimentoContabileLabel.Location = New System.Drawing.Point(572, 15)
        MovimentoContabileLabel.Name = "MovimentoContabileLabel"
        MovimentoContabileLabel.Size = New System.Drawing.Size(109, 13)
        MovimentoContabileLabel.TabIndex = 101
        MovimentoContabileLabel.Text = "Movimento Contabile:"
        '
        'TestDocumentoLabel
        '
        TestDocumentoLabel.AutoSize = True
        TestDocumentoLabel.Location = New System.Drawing.Point(484, 14)
        TestDocumentoLabel.Name = "TestDocumentoLabel"
        TestDocumentoLabel.Size = New System.Drawing.Size(89, 13)
        TestDocumentoLabel.TabIndex = 102
        TestDocumentoLabel.Text = "Test Documento:"
        '
        'TestProceduraLabel
        '
        TestProceduraLabel.AutoSize = True
        TestProceduraLabel.Location = New System.Drawing.Point(582, 55)
        TestProceduraLabel.Name = "TestProceduraLabel"
        TestProceduraLabel.Size = New System.Drawing.Size(83, 13)
        TestProceduraLabel.TabIndex = 103
        TestProceduraLabel.Text = "Test Procedura:"
        '
        'LocalitaDestinatarioLabel
        '
        LocalitaDestinatarioLabel.AutoSize = True
        LocalitaDestinatarioLabel.Location = New System.Drawing.Point(128, 109)
        LocalitaDestinatarioLabel.Name = "LocalitaDestinatarioLabel"
        LocalitaDestinatarioLabel.Size = New System.Drawing.Size(106, 13)
        LocalitaDestinatarioLabel.TabIndex = 10
        LocalitaDestinatarioLabel.Text = "Localita Destinatario:"
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
        Me.GroupBox1.Controls.Add(AziendaLabel)
        Me.GroupBox1.Controls.Add(Me.EsercizioComboBox)
        Me.GroupBox1.Controls.Add(Me.AziendaComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(931, 58)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'SiglaTextBox
        '
        Me.SiglaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Sigla", True))
        Me.SiglaTextBox.Location = New System.Drawing.Point(832, 19)
        Me.SiglaTextBox.Name = "SiglaTextBox"
        Me.SiglaTextBox.Size = New System.Drawing.Size(82, 20)
        Me.SiglaTextBox.TabIndex = 9
        '
        'DocumentitestataBindingSource
        '
        Me.DocumentitestataBindingSource.DataMember = "documentitestata"
        Me.DocumentitestataBindingSource.DataSource = Me.FatturazionegevenDataSet1
        '
        'FatturazionegevenDataSet1
        '
        Me.FatturazionegevenDataSet1.DataSetName = "fatturazionegevenDataSet"
        Me.FatturazionegevenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(692, 19)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(84, 20)
        Me.NumeroTextBox.TabIndex = 7
        '
        'TipoDocumentoComboBox
        '
        Me.TipoDocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TipoDocumento", True))
        Me.TipoDocumentoComboBox.FormattingEnabled = True
        Me.TipoDocumentoComboBox.Location = New System.Drawing.Point(497, 19)
        Me.TipoDocumentoComboBox.Name = "TipoDocumentoComboBox"
        Me.TipoDocumentoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoDocumentoComboBox.TabIndex = 5
        '
        'EsercizioComboBox
        '
        Me.EsercizioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Esercizio", True))
        Me.EsercizioComboBox.FormattingEnabled = True
        Me.EsercizioComboBox.Location = New System.Drawing.Point(259, 19)
        Me.EsercizioComboBox.Name = "EsercizioComboBox"
        Me.EsercizioComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EsercizioComboBox.TabIndex = 1
        '
        'AziendaComboBox
        '
        Me.AziendaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Azienda", True))
        Me.AziendaComboBox.FormattingEnabled = True
        Me.AziendaComboBox.Location = New System.Drawing.Point(62, 19)
        Me.AziendaComboBox.Name = "AziendaComboBox"
        Me.AziendaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AziendaComboBox.TabIndex = 1
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 168)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'ScontoTextBox
        '
        Me.ScontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Sconto", True))
        Me.ScontoTextBox.Location = New System.Drawing.Point(370, 140)
        Me.ScontoTextBox.Name = "ScontoTextBox"
        Me.ScontoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.ScontoTextBox.TabIndex = 13
        '
        'PagamentoComboBox
        '
        Me.PagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Pagamento", True))
        Me.PagamentoComboBox.FormattingEnabled = True
        Me.PagamentoComboBox.Location = New System.Drawing.Point(186, 140)
        Me.PagamentoComboBox.Name = "PagamentoComboBox"
        Me.PagamentoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PagamentoComboBox.TabIndex = 11
        '
        'IvaComboBox
        '
        Me.IvaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Iva", True))
        Me.IvaComboBox.FormattingEnabled = True
        Me.IvaComboBox.Location = New System.Drawing.Point(39, 140)
        Me.IvaComboBox.Name = "IvaComboBox"
        Me.IvaComboBox.Size = New System.Drawing.Size(60, 21)
        Me.IvaComboBox.TabIndex = 9
        '
        'AgenteComboBox
        '
        Me.AgenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Agente", True))
        Me.AgenteComboBox.FormattingEnabled = True
        Me.AgenteComboBox.Location = New System.Drawing.Point(58, 107)
        Me.AgenteComboBox.Name = "AgenteComboBox"
        Me.AgenteComboBox.Size = New System.Drawing.Size(364, 21)
        Me.AgenteComboBox.TabIndex = 7
        '
        'RiferimentoTextBox
        '
        Me.RiferimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Riferimento", True))
        Me.RiferimentoTextBox.Location = New System.Drawing.Point(77, 78)
        Me.RiferimentoTextBox.Name = "RiferimentoTextBox"
        Me.RiferimentoTextBox.Size = New System.Drawing.Size(345, 20)
        Me.RiferimentoTextBox.TabIndex = 5
        '
        'DataDocumentoDateTimePicker
        '
        Me.DataDocumentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DocumentitestataBindingSource, "DataDocumento", True))
        Me.DataDocumentoDateTimePicker.Location = New System.Drawing.Point(105, 52)
        Me.DataDocumentoDateTimePicker.Name = "DataDocumentoDateTimePicker"
        Me.DataDocumentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDocumentoDateTimePicker.TabIndex = 3
        '
        'AnagraficaComboBox
        '
        Me.AnagraficaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Anagrafica", True))
        Me.AnagraficaComboBox.FormattingEnabled = True
        Me.AnagraficaComboBox.Location = New System.Drawing.Point(74, 19)
        Me.AnagraficaComboBox.Name = "AnagraficaComboBox"
        Me.AnagraficaComboBox.Size = New System.Drawing.Size(348, 21)
        Me.AnagraficaComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(LocalitaDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.LocalitaDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(ProvinciaDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.ProvinciaDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(CapDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.CapDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(IndirizzoDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.IndirizzoDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(NominativoDestinatarioLabel)
        Me.GroupBox3.Controls.Add(Me.NominativoDestinatarioTextBox)
        Me.GroupBox3.Controls.Add(DestinazioneLabel)
        Me.GroupBox3.Controls.Add(Me.DestinazioneComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 176)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'LocalitaDestinatarioTextBox
        '
        Me.LocalitaDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "LocalitaDestinatario", True))
        Me.LocalitaDestinatarioTextBox.Location = New System.Drawing.Point(131, 125)
        Me.LocalitaDestinatarioTextBox.Name = "LocalitaDestinatarioTextBox"
        Me.LocalitaDestinatarioTextBox.Size = New System.Drawing.Size(222, 20)
        Me.LocalitaDestinatarioTextBox.TabIndex = 11
        '
        'ProvinciaDestinatarioTextBox
        '
        Me.ProvinciaDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ProvinciaDestinatario", True))
        Me.ProvinciaDestinatarioTextBox.Location = New System.Drawing.Point(362, 125)
        Me.ProvinciaDestinatarioTextBox.Name = "ProvinciaDestinatarioTextBox"
        Me.ProvinciaDestinatarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProvinciaDestinatarioTextBox.TabIndex = 9
        '
        'CapDestinatarioTextBox
        '
        Me.CapDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CapDestinatario", True))
        Me.CapDestinatarioTextBox.Location = New System.Drawing.Point(25, 125)
        Me.CapDestinatarioTextBox.Name = "CapDestinatarioTextBox"
        Me.CapDestinatarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CapDestinatarioTextBox.TabIndex = 7
        '
        'IndirizzoDestinatarioTextBox
        '
        Me.IndirizzoDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "IndirizzoDestinatario", True))
        Me.IndirizzoDestinatarioTextBox.Location = New System.Drawing.Point(131, 81)
        Me.IndirizzoDestinatarioTextBox.Name = "IndirizzoDestinatarioTextBox"
        Me.IndirizzoDestinatarioTextBox.Size = New System.Drawing.Size(327, 20)
        Me.IndirizzoDestinatarioTextBox.TabIndex = 5
        '
        'NominativoDestinatarioTextBox
        '
        Me.NominativoDestinatarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "NominativoDestinatario", True))
        Me.NominativoDestinatarioTextBox.Location = New System.Drawing.Point(131, 49)
        Me.NominativoDestinatarioTextBox.Name = "NominativoDestinatarioTextBox"
        Me.NominativoDestinatarioTextBox.Size = New System.Drawing.Size(327, 20)
        Me.NominativoDestinatarioTextBox.TabIndex = 3
        '
        'DestinazioneComboBox
        '
        Me.DestinazioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Destinazione", True))
        Me.DestinazioneComboBox.FormattingEnabled = True
        Me.DestinazioneComboBox.Location = New System.Drawing.Point(86, 19)
        Me.DestinazioneComboBox.Name = "DestinazioneComboBox"
        Me.DestinazioneComboBox.Size = New System.Drawing.Size(372, 21)
        Me.DestinazioneComboBox.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(AgenziaLabel)
        Me.GroupBox4.Controls.Add(Me.AgenziaTextBox)
        Me.GroupBox4.Controls.Add(BancaLabel)
        Me.GroupBox4.Controls.Add(Me.BancaTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 267)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(916, 61)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'AgenziaTextBox
        '
        Me.AgenziaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Agenzia", True))
        Me.AgenziaTextBox.Location = New System.Drawing.Point(497, 25)
        Me.AgenziaTextBox.Name = "AgenziaTextBox"
        Me.AgenziaTextBox.Size = New System.Drawing.Size(397, 20)
        Me.AgenziaTextBox.TabIndex = 3
        '
        'BancaTextBox
        '
        Me.BancaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Banca", True))
        Me.BancaTextBox.Location = New System.Drawing.Point(55, 25)
        Me.BancaTextBox.Name = "BancaTextBox"
        Me.BancaTextBox.Size = New System.Drawing.Size(375, 20)
        Me.BancaTextBox.TabIndex = 1
        '
        'GroupBox5
        '
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
        Me.GroupBox5.Controls.Add(Me.PortoTextBox)
        Me.GroupBox5.Controls.Add(CausaleTrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.CausaleTrasportoComboBox)
        Me.GroupBox5.Controls.Add(ImballoLabel)
        Me.GroupBox5.Controls.Add(Me.ImballoTextBox)
        Me.GroupBox5.Controls.Add(TrasportoLabel)
        Me.GroupBox5.Controls.Add(Me.TrasportoTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 490)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(914, 126)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        '
        'VettoreComboBox
        '
        Me.VettoreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Vettore", True))
        Me.VettoreComboBox.FormattingEnabled = True
        Me.VettoreComboBox.Location = New System.Drawing.Point(689, 90)
        Me.VettoreComboBox.Name = "VettoreComboBox"
        Me.VettoreComboBox.Size = New System.Drawing.Size(212, 21)
        Me.VettoreComboBox.TabIndex = 83
        '
        'TrasportoMezzoComboBox
        '
        Me.TrasportoMezzoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TrasportoMezzo", True))
        Me.TrasportoMezzoComboBox.FormattingEnabled = True
        Me.TrasportoMezzoComboBox.Location = New System.Drawing.Point(390, 90)
        Me.TrasportoMezzoComboBox.Name = "TrasportoMezzoComboBox"
        Me.TrasportoMezzoComboBox.Size = New System.Drawing.Size(229, 21)
        Me.TrasportoMezzoComboBox.TabIndex = 82
        '
        'AspettoBeniComboBox
        '
        Me.AspettoBeniComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "AspettoBeni", True))
        Me.AspettoBeniComboBox.FormattingEnabled = True
        Me.AspettoBeniComboBox.Location = New System.Drawing.Point(83, 90)
        Me.AspettoBeniComboBox.Name = "AspettoBeniComboBox"
        Me.AspettoBeniComboBox.Size = New System.Drawing.Size(206, 21)
        Me.AspettoBeniComboBox.TabIndex = 81
        '
        'OraTrasportoTextBox
        '
        Me.OraTrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "OraTrasporto", True))
        Me.OraTrasportoTextBox.Location = New System.Drawing.Point(454, 51)
        Me.OraTrasportoTextBox.Name = "OraTrasportoTextBox"
        Me.OraTrasportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OraTrasportoTextBox.TabIndex = 80
        '
        'DataTrasportoTextBox
        '
        Me.DataTrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "DataTrasporto", True))
        Me.DataTrasportoTextBox.Location = New System.Drawing.Point(267, 51)
        Me.DataTrasportoTextBox.Name = "DataTrasportoTextBox"
        Me.DataTrasportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataTrasportoTextBox.TabIndex = 79
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(74, 51)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoTextBox.TabIndex = 78
        '
        'ColliTextBox
        '
        Me.ColliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Colli", True))
        Me.ColliTextBox.Location = New System.Drawing.Point(754, 20)
        Me.ColliTextBox.Name = "ColliTextBox"
        Me.ColliTextBox.Size = New System.Drawing.Size(52, 20)
        Me.ColliTextBox.TabIndex = 77
        '
        'PortoTextBox
        '
        Me.PortoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Porto", True))
        Me.PortoTextBox.Location = New System.Drawing.Point(605, 19)
        Me.PortoTextBox.Name = "PortoTextBox"
        Me.PortoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PortoTextBox.TabIndex = 76
        '
        'CausaleTrasportoComboBox
        '
        Me.CausaleTrasportoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CausaleTrasporto", True))
        Me.CausaleTrasportoComboBox.FormattingEnabled = True
        Me.CausaleTrasportoComboBox.Location = New System.Drawing.Point(437, 19)
        Me.CausaleTrasportoComboBox.Name = "CausaleTrasportoComboBox"
        Me.CausaleTrasportoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CausaleTrasportoComboBox.TabIndex = 75
        '
        'ImballoTextBox
        '
        Me.ImballoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imballo", True))
        Me.ImballoTextBox.Location = New System.Drawing.Point(229, 19)
        Me.ImballoTextBox.Name = "ImballoTextBox"
        Me.ImballoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImballoTextBox.TabIndex = 74
        '
        'TrasportoTextBox
        '
        Me.TrasportoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Trasporto", True))
        Me.TrasportoTextBox.Location = New System.Drawing.Point(74, 19)
        Me.TrasportoTextBox.Name = "TrasportoTextBox"
        Me.TrasportoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrasportoTextBox.TabIndex = 73
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(TestProceduraLabel)
        Me.GroupBox6.Controls.Add(Me.TestProceduraTextBox)
        Me.GroupBox6.Controls.Add(TestDocumentoLabel)
        Me.GroupBox6.Controls.Add(Me.TestDocumentoTextBox)
        Me.GroupBox6.Controls.Add(MovimentoContabileLabel)
        Me.GroupBox6.Controls.Add(Me.MovimentoContabileTextBox)
        Me.GroupBox6.Controls.Add(CodiceIva2Label)
        Me.GroupBox6.Controls.Add(Me.CodiceIva2ComboBox)
        Me.GroupBox6.Controls.Add(Imponibile2Label)
        Me.GroupBox6.Controls.Add(Me.Imponibile2TextBox)
        Me.GroupBox6.Controls.Add(_Iva2Label)
        Me.GroupBox6.Controls.Add(Me._Iva2TextBox)
        Me.GroupBox6.Controls.Add(ImportoIva2Label)
        Me.GroupBox6.Controls.Add(Me.ImportoIva2TextBox)
        Me.GroupBox6.Controls.Add(TotaleProvvigioniLabel)
        Me.GroupBox6.Controls.Add(Me.TotaleProvvigioniTextBox)
        Me.GroupBox6.Controls.Add(ImportoIva1Label)
        Me.GroupBox6.Controls.Add(Me.ImportoIva1TextBox)
        Me.GroupBox6.Controls.Add(_Iva1Label)
        Me.GroupBox6.Controls.Add(Me._Iva1TextBox)
        Me.GroupBox6.Controls.Add(Imponibile1Label)
        Me.GroupBox6.Controls.Add(Me.Imponibile1TextBox)
        Me.GroupBox6.Controls.Add(CodiceIva1Label)
        Me.GroupBox6.Controls.Add(Me.CodiceIva1ComboBox)
        Me.GroupBox6.Controls.Add(TotaleDocumentoLabel)
        Me.GroupBox6.Controls.Add(Me.TotaleDocumentoTextBox)
        Me.GroupBox6.Controls.Add(DivisaLabel)
        Me.GroupBox6.Controls.Add(Me.DivisaComboBox)
        Me.GroupBox6.Controls.Add(ScontoCassaLabel)
        Me.GroupBox6.Controls.Add(Me.ScontoCassaTextBox)
        Me.GroupBox6.Controls.Add(TotaleMerceLabel)
        Me.GroupBox6.Controls.Add(Me.TotaleMerceTextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 622)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(916, 126)
        Me.GroupBox6.TabIndex = 63
        Me.GroupBox6.TabStop = False
        '
        'TestProceduraTextBox
        '
        Me.TestProceduraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TestProcedura", True))
        Me.TestProceduraTextBox.Location = New System.Drawing.Point(585, 72)
        Me.TestProceduraTextBox.Name = "TestProceduraTextBox"
        Me.TestProceduraTextBox.Size = New System.Drawing.Size(44, 20)
        Me.TestProceduraTextBox.TabIndex = 104
        '
        'TestDocumentoTextBox
        '
        Me.TestDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TestDocumento", True))
        Me.TestDocumentoTextBox.Location = New System.Drawing.Point(522, 30)
        Me.TestDocumentoTextBox.Name = "TestDocumentoTextBox"
        Me.TestDocumentoTextBox.Size = New System.Drawing.Size(44, 20)
        Me.TestDocumentoTextBox.TabIndex = 103
        '
        'MovimentoContabileTextBox
        '
        Me.MovimentoContabileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "MovimentoContabile", True))
        Me.MovimentoContabileTextBox.Location = New System.Drawing.Point(626, 31)
        Me.MovimentoContabileTextBox.Name = "MovimentoContabileTextBox"
        Me.MovimentoContabileTextBox.Size = New System.Drawing.Size(44, 20)
        Me.MovimentoContabileTextBox.TabIndex = 102
        '
        'CodiceIva2ComboBox
        '
        Me.CodiceIva2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CodiceIva2", True))
        Me.CodiceIva2ComboBox.FormattingEnabled = True
        Me.CodiceIva2ComboBox.Location = New System.Drawing.Point(9, 70)
        Me.CodiceIva2ComboBox.Name = "CodiceIva2ComboBox"
        Me.CodiceIva2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CodiceIva2ComboBox.TabIndex = 101
        '
        'Imponibile2TextBox
        '
        Me.Imponibile2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imponibile2", True))
        Me.Imponibile2TextBox.Location = New System.Drawing.Point(136, 72)
        Me.Imponibile2TextBox.Name = "Imponibile2TextBox"
        Me.Imponibile2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Imponibile2TextBox.TabIndex = 100
        '
        '_Iva2TextBox
        '
        Me._Iva2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "%Iva2", True))
        Me._Iva2TextBox.Location = New System.Drawing.Point(242, 72)
        Me._Iva2TextBox.Name = "_Iva2TextBox"
        Me._Iva2TextBox.Size = New System.Drawing.Size(100, 20)
        Me._Iva2TextBox.TabIndex = 99
        '
        'ImportoIva2TextBox
        '
        Me.ImportoIva2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ImportoIva2", True))
        Me.ImportoIva2TextBox.Location = New System.Drawing.Point(348, 72)
        Me.ImportoIva2TextBox.Name = "ImportoIva2TextBox"
        Me.ImportoIva2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoIva2TextBox.TabIndex = 98
        '
        'TotaleProvvigioniTextBox
        '
        Me.TotaleProvvigioniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TotaleProvvigioni", True))
        Me.TotaleProvvigioniTextBox.Location = New System.Drawing.Point(454, 72)
        Me.TotaleProvvigioniTextBox.Name = "TotaleProvvigioniTextBox"
        Me.TotaleProvvigioniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotaleProvvigioniTextBox.TabIndex = 97
        '
        'ImportoIva1TextBox
        '
        Me.ImportoIva1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ImportoIva1", True))
        Me.ImportoIva1TextBox.Location = New System.Drawing.Point(348, 31)
        Me.ImportoIva1TextBox.Name = "ImportoIva1TextBox"
        Me.ImportoIva1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImportoIva1TextBox.TabIndex = 96
        '
        '_Iva1TextBox
        '
        Me._Iva1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "%Iva1", True))
        Me._Iva1TextBox.Location = New System.Drawing.Point(242, 31)
        Me._Iva1TextBox.Name = "_Iva1TextBox"
        Me._Iva1TextBox.Size = New System.Drawing.Size(100, 20)
        Me._Iva1TextBox.TabIndex = 95
        '
        'Imponibile1TextBox
        '
        Me.Imponibile1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Imponibile1", True))
        Me.Imponibile1TextBox.Location = New System.Drawing.Point(136, 30)
        Me.Imponibile1TextBox.Name = "Imponibile1TextBox"
        Me.Imponibile1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Imponibile1TextBox.TabIndex = 94
        '
        'CodiceIva1ComboBox
        '
        Me.CodiceIva1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "CodiceIva1", True))
        Me.CodiceIva1ComboBox.FormattingEnabled = True
        Me.CodiceIva1ComboBox.Location = New System.Drawing.Point(9, 29)
        Me.CodiceIva1ComboBox.Name = "CodiceIva1ComboBox"
        Me.CodiceIva1ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CodiceIva1ComboBox.TabIndex = 93
        '
        'TotaleDocumentoTextBox
        '
        Me.TotaleDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TotaleDocumento", True))
        Me.TotaleDocumentoTextBox.Location = New System.Drawing.Point(689, 71)
        Me.TotaleDocumentoTextBox.Name = "TotaleDocumentoTextBox"
        Me.TotaleDocumentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotaleDocumentoTextBox.TabIndex = 92
        '
        'DivisaComboBox
        '
        Me.DivisaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "Divisa", True))
        Me.DivisaComboBox.FormattingEnabled = True
        Me.DivisaComboBox.Location = New System.Drawing.Point(794, 70)
        Me.DivisaComboBox.Name = "DivisaComboBox"
        Me.DivisaComboBox.Size = New System.Drawing.Size(100, 21)
        Me.DivisaComboBox.TabIndex = 91
        '
        'ScontoCassaTextBox
        '
        Me.ScontoCassaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "ScontoCassa", True))
        Me.ScontoCassaTextBox.Location = New System.Drawing.Point(794, 29)
        Me.ScontoCassaTextBox.Name = "ScontoCassaTextBox"
        Me.ScontoCassaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ScontoCassaTextBox.TabIndex = 90
        '
        'TotaleMerceTextBox
        '
        Me.TotaleMerceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentitestataBindingSource, "TotaleMerce", True))
        Me.TotaleMerceTextBox.Location = New System.Drawing.Point(689, 29)
        Me.TotaleMerceTextBox.Name = "TotaleMerceTextBox"
        Me.TotaleMerceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotaleMerceTextBox.TabIndex = 89
        '
        'DocumentitestataTableAdapter1
        '
        Me.DocumentitestataTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.agentiprovvigioniTableAdapter = Nothing
        Me.TableAdapterManager1.agentiTableAdapter = Nothing
        Me.TableAdapterManager1.anagraficadestinazioniTableAdapter = Nothing
        Me.TableAdapterManager1.anagraficafatturazioneTableAdapter = Nothing
        Me.TableAdapterManager1.anagraficascontiTableAdapter = Nothing
        Me.TableAdapterManager1.anagraficheTableAdapter = Nothing
        Me.TableAdapterManager1.articolilistinoTableAdapter = Nothing
        Me.TableAdapterManager1.articolimisureTableAdapter = Nothing
        Me.TableAdapterManager1.articoliprezziacquistoTableAdapter = Nothing
        Me.TableAdapterManager1.articoliTableAdapter = Nothing
        Me.TableAdapterManager1.aspettobeniTableAdapter = Nothing
        Me.TableAdapterManager1.aziendacostantiTableAdapter = Nothing
        Me.TableAdapterManager1.aziendaintestazionemodulisticaTableAdapter = Nothing
        Me.TableAdapterManager1.aziendeTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.categoriemerceologicheTableAdapter = Nothing
        Me.TableAdapterManager1.categorieTableAdapter = Nothing
        Me.TableAdapterManager1.causalitrasportoTableAdapter = Nothing
        Me.TableAdapterManager1.classiarticoloTableAdapter = Nothing
        Me.TableAdapterManager1.contiTableAdapter = Nothing
        Me.TableAdapterManager1.diviseTableAdapter = Nothing
        Me.TableAdapterManager1.documentidettaglioTableAdapter = Me.DocumentidettaglioTableAdapter
        Me.TableAdapterManager1.documentiscadenzeTableAdapter = Nothing
        Me.TableAdapterManager1.documentitestataTableAdapter = Me.DocumentitestataTableAdapter1
        Me.TableAdapterManager1.esercizicontabiliTableAdapter = Nothing
        Me.TableAdapterManager1.magazzinodenominazioneTableAdapter = Nothing
        Me.TableAdapterManager1.magazzinomovimentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.magazzinomovimentitestataTableAdapter = Nothing
        Me.TableAdapterManager1.magazzinotipimovimentodettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.magazzinotipimovimentoTableAdapter = Nothing
        Me.TableAdapterManager1.moditrasportoTableAdapter = Nothing
        Me.TableAdapterManager1.operazionidettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.operazioniTableAdapter = Nothing
        Me.TableAdapterManager1.pagamentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager1.pagamentitestataTableAdapter = Nothing
        Me.TableAdapterManager1.parametriivaTableAdapter = Nothing
        Me.TableAdapterManager1.portafoglioeffettiTableAdapter = Nothing
        Me.TableAdapterManager1.scontifornitoreTableAdapter = Nothing
        Me.TableAdapterManager1.tipidocumentoTableAdapter = Nothing
        Me.TableAdapterManager1.tipitrasportoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.vettoriTableAdapter = Nothing
        Me.TableAdapterManager1.zoneTableAdapter = Nothing
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
        Me.DocumentitestataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DocumentitestataBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.DocumentitestataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DocumentitestataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocumentitestataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocumentitestataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocumentitestataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocumentitestataBindingNavigator.Name = "DocumentitestataBindingNavigator"
        Me.DocumentitestataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocumentitestataBindingNavigator.Size = New System.Drawing.Size(951, 38)
        Me.DocumentitestataBindingNavigator.TabIndex = 64
        Me.DocumentitestataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DocumentitestataBindingNavigatorSaveItem
        '
        Me.DocumentitestataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocumentitestataBindingNavigatorSaveItem.Image = CType(resources.GetObject("DocumentitestataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DocumentitestataBindingNavigatorSaveItem.Name = "DocumentitestataBindingNavigatorSaveItem"
        Me.DocumentitestataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DocumentitestataBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 35)
        Me.ToolStripButton1.Text = "&Ricerca"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'DocumentidettaglioBindingSource
        '
        Me.DocumentidettaglioBindingSource.DataMember = "documentitestata_documentidettaglio"
        Me.DocumentidettaglioBindingSource.DataSource = Me.DocumentitestataBindingSource
        '
        'DocumentidettaglioDataGridView
        '
        Me.DocumentidettaglioDataGridView.AutoGenerateColumns = False
        Me.DocumentidettaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentidettaglioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ImportoProvvigioniTextBoxColumn, Me.ArticoloAliasTextBoxColumn, Me.MovimentoMagazzinoTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn17, Me.RigaTextBoxColumn, Me.ArticoloTextBoxColumn, Me.DescrizioneTextBoxColumn, Me.UnitaMisuraMagazzinoTextBoxColumn, Me.QuantitaMagazzinoTextBoxColumn, Me.UnitaMisuraTextBoxColumn, Me.QuantitaTextBoxColumn, Me.PrezzoUnitarioTextBoxColumn, Me.Sconto1TextBoxColumn, Me.Sconto2TextBoxColumn, Me.Sconto3TextBoxColumn, Me.ImportoTextBoxColumn, Me.ScorporoTextBoxColumn, Me.ClasseMerceologicaTextBoxColumn, Me.ClasseContropartitaTextBoxColumn, Me.PercentoProvvigioniTextBoxColumn})
        Me.DocumentidettaglioDataGridView.DataSource = Me.DocumentidettaglioBindingSource
        Me.DocumentidettaglioDataGridView.Location = New System.Drawing.Point(12, 334)
        Me.DocumentidettaglioDataGridView.Name = "DocumentidettaglioDataGridView"
        Me.DocumentidettaglioDataGridView.Size = New System.Drawing.Size(916, 150)
        Me.DocumentidettaglioDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Azienda"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Azienda"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ImportoProvvigioniTextBoxColumn
        '
        Me.ImportoProvvigioniTextBoxColumn.DataPropertyName = "ImportoProvvigioni"
        Me.ImportoProvvigioniTextBoxColumn.HeaderText = "ImportoProvvigioni"
        Me.ImportoProvvigioniTextBoxColumn.Name = "ImportoProvvigioniTextBoxColumn"
        '
        'ArticoloAliasTextBoxColumn
        '
        Me.ArticoloAliasTextBoxColumn.DataPropertyName = "ArticoloAlias"
        Me.ArticoloAliasTextBoxColumn.HeaderText = "ArticoloAlias"
        Me.ArticoloAliasTextBoxColumn.Name = "ArticoloAliasTextBoxColumn"
        '
        'MovimentoMagazzinoTextBoxColumn
        '
        Me.MovimentoMagazzinoTextBoxColumn.DataPropertyName = "MovimentoMagazzino"
        Me.MovimentoMagazzinoTextBoxColumn.HeaderText = "MovimentoMagazzino"
        Me.MovimentoMagazzinoTextBoxColumn.Name = "MovimentoMagazzinoTextBoxColumn"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Esercizio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Esercizio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TipoDocumento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TipoDocumento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Iva"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Iva"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'RigaTextBoxColumn
        '
        Me.RigaTextBoxColumn.DataPropertyName = "Riga"
        Me.RigaTextBoxColumn.HeaderText = "Riga"
        Me.RigaTextBoxColumn.Name = "RigaTextBoxColumn"
        '
        'ArticoloTextBoxColumn
        '
        Me.ArticoloTextBoxColumn.DataPropertyName = "Articolo"
        Me.ArticoloTextBoxColumn.HeaderText = "Articolo"
        Me.ArticoloTextBoxColumn.Name = "ArticoloTextBoxColumn"
        '
        'DescrizioneTextBoxColumn
        '
        Me.DescrizioneTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneTextBoxColumn.Name = "DescrizioneTextBoxColumn"
        '
        'UnitaMisuraMagazzinoTextBoxColumn
        '
        Me.UnitaMisuraMagazzinoTextBoxColumn.DataPropertyName = "UnitaMisuraMagazzino"
        Me.UnitaMisuraMagazzinoTextBoxColumn.HeaderText = "UnitaMisuraMagazzino"
        Me.UnitaMisuraMagazzinoTextBoxColumn.Name = "UnitaMisuraMagazzinoTextBoxColumn"
        '
        'QuantitaMagazzinoTextBoxColumn
        '
        Me.QuantitaMagazzinoTextBoxColumn.DataPropertyName = "QuantitaMagazzino"
        Me.QuantitaMagazzinoTextBoxColumn.HeaderText = "QuantitaMagazzino"
        Me.QuantitaMagazzinoTextBoxColumn.Name = "QuantitaMagazzinoTextBoxColumn"
        '
        'UnitaMisuraTextBoxColumn
        '
        Me.UnitaMisuraTextBoxColumn.DataPropertyName = "UnitaMisura"
        Me.UnitaMisuraTextBoxColumn.HeaderText = "UnitaMisura"
        Me.UnitaMisuraTextBoxColumn.Name = "UnitaMisuraTextBoxColumn"
        '
        'QuantitaTextBoxColumn
        '
        Me.QuantitaTextBoxColumn.DataPropertyName = "Quantita"
        Me.QuantitaTextBoxColumn.HeaderText = "Quantita"
        Me.QuantitaTextBoxColumn.Name = "QuantitaTextBoxColumn"
        '
        'PrezzoUnitarioTextBoxColumn
        '
        Me.PrezzoUnitarioTextBoxColumn.DataPropertyName = "PrezzoUnitario"
        Me.PrezzoUnitarioTextBoxColumn.HeaderText = "PrezzoUnitario"
        Me.PrezzoUnitarioTextBoxColumn.Name = "PrezzoUnitarioTextBoxColumn"
        '
        'Sconto1TextBoxColumn
        '
        Me.Sconto1TextBoxColumn.DataPropertyName = "Sconto1"
        Me.Sconto1TextBoxColumn.HeaderText = "Sconto1"
        Me.Sconto1TextBoxColumn.Name = "Sconto1TextBoxColumn"
        '
        'Sconto2TextBoxColumn
        '
        Me.Sconto2TextBoxColumn.DataPropertyName = "Sconto2"
        Me.Sconto2TextBoxColumn.HeaderText = "Sconto2"
        Me.Sconto2TextBoxColumn.Name = "Sconto2TextBoxColumn"
        '
        'Sconto3TextBoxColumn
        '
        Me.Sconto3TextBoxColumn.DataPropertyName = "Sconto3"
        Me.Sconto3TextBoxColumn.HeaderText = "Sconto3"
        Me.Sconto3TextBoxColumn.Name = "Sconto3TextBoxColumn"
        '
        'ImportoTextBoxColumn
        '
        Me.ImportoTextBoxColumn.DataPropertyName = "Importo"
        Me.ImportoTextBoxColumn.HeaderText = "Importo"
        Me.ImportoTextBoxColumn.Name = "ImportoTextBoxColumn"
        '
        'ScorporoTextBoxColumn
        '
        Me.ScorporoTextBoxColumn.DataPropertyName = "Scorporo"
        Me.ScorporoTextBoxColumn.HeaderText = "Scorporo"
        Me.ScorporoTextBoxColumn.Name = "ScorporoTextBoxColumn"
        '
        'ClasseMerceologicaTextBoxColumn
        '
        Me.ClasseMerceologicaTextBoxColumn.DataPropertyName = "ClasseMerceologica"
        Me.ClasseMerceologicaTextBoxColumn.HeaderText = "ClasseMerceologica"
        Me.ClasseMerceologicaTextBoxColumn.Name = "ClasseMerceologicaTextBoxColumn"
        '
        'ClasseContropartitaTextBoxColumn
        '
        Me.ClasseContropartitaTextBoxColumn.DataPropertyName = "ClasseContropartita"
        Me.ClasseContropartitaTextBoxColumn.HeaderText = "ClasseContropartita"
        Me.ClasseContropartitaTextBoxColumn.Name = "ClasseContropartitaTextBoxColumn"
        '
        'PercentoProvvigioniTextBoxColumn
        '
        Me.PercentoProvvigioniTextBoxColumn.DataPropertyName = "PercentoProvvigioni"
        Me.PercentoProvvigioniTextBoxColumn.HeaderText = "PercentoProvvigioni"
        Me.PercentoProvvigioniTextBoxColumn.Name = "PercentoProvvigioniTextBoxColumn"
        '
        'GestioneDocumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 764)
        Me.Controls.Add(Me.DocumentidettaglioDataGridView)
        Me.Controls.Add(Me.DocumentitestataBindingNavigator)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GestioneDocumenti"
        Me.Text = "Gestione dei Documenti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DocumentitestataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturazionegevenDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DocumentitestataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentitestataBindingNavigator.ResumeLayout(False)
        Me.DocumentitestataBindingNavigator.PerformLayout()
        CType(Me.DocumentidettaglioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentidettaglioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents FatturazionegevenDataSet As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents DocumentitestataTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentitestataTableAdapter
    Friend WithEvents TableAdapterManager As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FatturazionegevenDataSet1 As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents DocumentitestataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentitestataTableAdapter1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentitestataTableAdapter
    Friend WithEvents TableAdapterManager1 As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents AziendaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentidettaglioTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.documentidettaglioTableAdapter
    Friend WithEvents DocumentidettaglioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiglaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoDocumentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EsercizioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IvaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgenteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RiferimentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDocumentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AnagraficaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DestinazioneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentidettaglioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AgenziaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VettoreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrasportoMezzoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AspettoBeniComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OraTrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CausaleTrasportoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImballoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasportoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotaleDocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DivisaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ScontoCassaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotaleMerceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndirizzoDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NominativoDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceIva2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Imponibile2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _Iva2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoIva2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotaleProvvigioniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImportoIva1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _Iva1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Imponibile1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodiceIva1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TestProceduraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TestDocumentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MovimentoContabileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalitaDestinatarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportoProvvigioniTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticoloAliasTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimentoMagazzinoTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RigaTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArticoloTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PercentoProvvigioniTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
