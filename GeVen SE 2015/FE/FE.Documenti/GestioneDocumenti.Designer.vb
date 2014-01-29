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
        Me.ComboBoxAzienda = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEsercizio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipiDocumento = New System.Windows.Forms.ComboBox()
        Me.TextBoxNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.TextBoxSiglaOperatore = New System.Windows.Forms.TextBox()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDestinazione = New System.Windows.Forms.ComboBox()
        Me.TextBoxRiferimento = New System.Windows.Forms.TextBox()
        Me.TextBoxDataDocumento = New System.Windows.Forms.TextBox()
        Me.ComboBoxAgente = New System.Windows.Forms.ComboBox()
        Me.TextBoxDestinazione2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxIva = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPagamento = New System.Windows.Forms.ComboBox()
        Me.TextBoxBanca = New System.Windows.Forms.TextBox()
        Me.TextBoxSconto = New System.Windows.Forms.TextBox()
        Me.TextBoxCAP = New System.Windows.Forms.TextBox()
        Me.TextBoxDestinazione3 = New System.Windows.Forms.TextBox()
        Me.TextBoxLocalita = New System.Windows.Forms.TextBox()
        Me.TextBoxProvincia = New System.Windows.Forms.TextBox()
        Me.TextBoxAgenzia = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.riga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitamisuramagazzino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantitamagazzino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitamisurafatturazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantitafatturazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentuale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentuale2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentuale3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scorporo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.classemerceologica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contropartita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentualeprovigioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aliax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.magazzino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxImballo = New System.Windows.Forms.TextBox()
        Me.TextBoxTrasporto = New System.Windows.Forms.TextBox()
        Me.ComboBoxPorto = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCausaleTrasporto = New System.Windows.Forms.ComboBox()
        Me.TextBoxData = New System.Windows.Forms.TextBox()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.TextBoxColli = New System.Windows.Forms.TextBox()
        Me.TextBoxOraTrasporto = New System.Windows.Forms.TextBox()
        Me.TextBoxPercSconto = New System.Windows.Forms.TextBox()
        Me.TextBoxTotMerce = New System.Windows.Forms.TextBox()
        Me.ComboBoxCorriere = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTrasportoMezzo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAspettoBeni = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCodiceIva = New System.Windows.Forms.ComboBox()
        Me.TextBoxTotDocumento = New System.Windows.Forms.TextBox()
        Me.TextBoxImportoIva = New System.Windows.Forms.TextBox()
        Me.TextBoxPercIva = New System.Windows.Forms.TextBox()
        Me.TextBoxImponibile = New System.Windows.Forms.TextBox()
        Me.ComboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.TextBoxTotProvvigioni = New System.Windows.Forms.TextBox()
        Me.TextBoxImportoIva2 = New System.Windows.Forms.TextBox()
        Me.TextBoxPercIva2 = New System.Windows.Forms.TextBox()
        Me.TextBoxImponibile2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxCodiceIva2 = New System.Windows.Forms.ComboBox()
        Me.TextBoxS3 = New System.Windows.Forms.TextBox()
        Me.TextBoxS2 = New System.Windows.Forms.TextBox()
        Me.TextBoxS1 = New System.Windows.Forms.TextBox()
        Me.LabelAzienda = New System.Windows.Forms.Label()
        Me.LabelEsercizio = New System.Windows.Forms.Label()
        Me.LabelTipoDocumento = New System.Windows.Forms.Label()
        Me.LabelNumeroDocumento = New System.Windows.Forms.Label()
        Me.LabelSiglaOperatore = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPagamento = New System.Windows.Forms.Label()
        Me.LabelIva = New System.Windows.Forms.Label()
        Me.LabelSconto = New System.Windows.Forms.Label()
        Me.LabelRiferimento = New System.Windows.Forms.Label()
        Me.LabelDataDocumento = New System.Windows.Forms.Label()
        Me.LabelAgente = New System.Windows.Forms.Label()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelBanca = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelDestinazione = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelAgenzia = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelCorriere = New System.Windows.Forms.Label()
        Me.LabelTrasportoMezzo = New System.Windows.Forms.Label()
        Me.LabelAspettoBeni = New System.Windows.Forms.Label()
        Me.LabelOraTrasporto = New System.Windows.Forms.Label()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.LabelPeso = New System.Windows.Forms.Label()
        Me.LabelColli = New System.Windows.Forms.Label()
        Me.LabelPorto = New System.Windows.Forms.Label()
        Me.LabelCausaleTrasporto = New System.Windows.Forms.Label()
        Me.LabelImballo = New System.Windows.Forms.Label()
        Me.LabelTrasporto = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabelS3 = New System.Windows.Forms.Label()
        Me.LabelS2 = New System.Windows.Forms.Label()
        Me.LabelS1 = New System.Windows.Forms.Label()
        Me.LabelTotaleProvvigioni = New System.Windows.Forms.Label()
        Me.LabelDivisa = New System.Windows.Forms.Label()
        Me.LabelTotaleDocumento = New System.Windows.Forms.Label()
        Me.LabelImportoIva2 = New System.Windows.Forms.Label()
        Me.LabelpercentualeIva2 = New System.Windows.Forms.Label()
        Me.LabelImponibile2 = New System.Windows.Forms.Label()
        Me.LabelCodiceIva2 = New System.Windows.Forms.Label()
        Me.LabelImportoIva = New System.Windows.Forms.Label()
        Me.LabelpercentualeIva = New System.Windows.Forms.Label()
        Me.LabelImponibile = New System.Windows.Forms.Label()
        Me.LabelCodiceIva = New System.Windows.Forms.Label()
        Me.Labelpercentualesconto = New System.Windows.Forms.Label()
        Me.LabelTotaleMerce = New System.Windows.Forms.Label()
        Me.Navigatore1 = New GeVen_SE_2015.Navigatore()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxAzienda
        '
        Me.ComboBoxAzienda.FormattingEnabled = True
        Me.ComboBoxAzienda.Location = New System.Drawing.Point(6, 36)
        Me.ComboBoxAzienda.Name = "ComboBoxAzienda"
        Me.ComboBoxAzienda.Size = New System.Drawing.Size(213, 21)
        Me.ComboBoxAzienda.TabIndex = 0
        '
        'ComboBoxEsercizio
        '
        Me.ComboBoxEsercizio.FormattingEnabled = True
        Me.ComboBoxEsercizio.Location = New System.Drawing.Point(235, 36)
        Me.ComboBoxEsercizio.Name = "ComboBoxEsercizio"
        Me.ComboBoxEsercizio.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxEsercizio.TabIndex = 1
        '
        'ComboBoxTipiDocumento
        '
        Me.ComboBoxTipiDocumento.FormattingEnabled = True
        Me.ComboBoxTipiDocumento.Location = New System.Drawing.Point(428, 35)
        Me.ComboBoxTipiDocumento.Name = "ComboBoxTipiDocumento"
        Me.ComboBoxTipiDocumento.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxTipiDocumento.TabIndex = 2
        '
        'TextBoxNumeroDocumento
        '
        Me.TextBoxNumeroDocumento.Location = New System.Drawing.Point(670, 36)
        Me.TextBoxNumeroDocumento.Name = "TextBoxNumeroDocumento"
        Me.TextBoxNumeroDocumento.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxNumeroDocumento.TabIndex = 3
        '
        'TextBoxSiglaOperatore
        '
        Me.TextBoxSiglaOperatore.Location = New System.Drawing.Point(796, 38)
        Me.TextBoxSiglaOperatore.Name = "TextBoxSiglaOperatore"
        Me.TextBoxSiglaOperatore.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSiglaOperatore.TabIndex = 4
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(6, 34)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(409, 21)
        Me.ComboBoxCliente.TabIndex = 5
        '
        'ComboBoxDestinazione
        '
        Me.ComboBoxDestinazione.FormattingEnabled = True
        Me.ComboBoxDestinazione.Location = New System.Drawing.Point(7, 34)
        Me.ComboBoxDestinazione.Name = "ComboBoxDestinazione"
        Me.ComboBoxDestinazione.Size = New System.Drawing.Size(453, 21)
        Me.ComboBoxDestinazione.TabIndex = 12
        '
        'TextBoxRiferimento
        '
        Me.TextBoxRiferimento.Location = New System.Drawing.Point(106, 78)
        Me.TextBoxRiferimento.Name = "TextBoxRiferimento"
        Me.TextBoxRiferimento.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxRiferimento.TabIndex = 7
        '
        'TextBoxDataDocumento
        '
        Me.TextBoxDataDocumento.Location = New System.Drawing.Point(6, 78)
        Me.TextBoxDataDocumento.Name = "TextBoxDataDocumento"
        Me.TextBoxDataDocumento.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxDataDocumento.TabIndex = 6
        '
        'ComboBoxAgente
        '
        Me.ComboBoxAgente.FormattingEnabled = True
        Me.ComboBoxAgente.Location = New System.Drawing.Point(235, 77)
        Me.ComboBoxAgente.Name = "ComboBoxAgente"
        Me.ComboBoxAgente.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxAgente.TabIndex = 8
        '
        'TextBoxDestinazione2
        '
        Me.TextBoxDestinazione2.Location = New System.Drawing.Point(7, 78)
        Me.TextBoxDestinazione2.Name = "TextBoxDestinazione2"
        Me.TextBoxDestinazione2.Size = New System.Drawing.Size(453, 20)
        Me.TextBoxDestinazione2.TabIndex = 13
        '
        'ComboBoxIva
        '
        Me.ComboBoxIva.FormattingEnabled = True
        Me.ComboBoxIva.Location = New System.Drawing.Point(6, 125)
        Me.ComboBoxIva.Name = "ComboBoxIva"
        Me.ComboBoxIva.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxIva.TabIndex = 9
        '
        'ComboBoxPagamento
        '
        Me.ComboBoxPagamento.FormattingEnabled = True
        Me.ComboBoxPagamento.Location = New System.Drawing.Point(144, 125)
        Me.ComboBoxPagamento.Name = "ComboBoxPagamento"
        Me.ComboBoxPagamento.Size = New System.Drawing.Size(193, 21)
        Me.ComboBoxPagamento.TabIndex = 10
        '
        'TextBoxBanca
        '
        Me.TextBoxBanca.Location = New System.Drawing.Point(6, 34)
        Me.TextBoxBanca.Name = "TextBoxBanca"
        Me.TextBoxBanca.Size = New System.Drawing.Size(409, 20)
        Me.TextBoxBanca.TabIndex = 18
        '
        'TextBoxSconto
        '
        Me.TextBoxSconto.Location = New System.Drawing.Point(356, 126)
        Me.TextBoxSconto.Name = "TextBoxSconto"
        Me.TextBoxSconto.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxSconto.TabIndex = 11
        '
        'TextBoxCAP
        '
        Me.TextBoxCAP.Location = New System.Drawing.Point(7, 128)
        Me.TextBoxCAP.Name = "TextBoxCAP"
        Me.TextBoxCAP.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxCAP.TabIndex = 15
        '
        'TextBoxDestinazione3
        '
        Me.TextBoxDestinazione3.Location = New System.Drawing.Point(7, 102)
        Me.TextBoxDestinazione3.Name = "TextBoxDestinazione3"
        Me.TextBoxDestinazione3.Size = New System.Drawing.Size(453, 20)
        Me.TextBoxDestinazione3.TabIndex = 14
        '
        'TextBoxLocalita
        '
        Me.TextBoxLocalita.Location = New System.Drawing.Point(107, 128)
        Me.TextBoxLocalita.Name = "TextBoxLocalita"
        Me.TextBoxLocalita.Size = New System.Drawing.Size(291, 20)
        Me.TextBoxLocalita.TabIndex = 16
        '
        'TextBoxProvincia
        '
        Me.TextBoxProvincia.Location = New System.Drawing.Point(404, 128)
        Me.TextBoxProvincia.Name = "TextBoxProvincia"
        Me.TextBoxProvincia.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxProvincia.TabIndex = 17
        '
        'TextBoxAgenzia
        '
        Me.TextBoxAgenzia.Location = New System.Drawing.Point(445, 34)
        Me.TextBoxAgenzia.Name = "TextBoxAgenzia"
        Me.TextBoxAgenzia.Size = New System.Drawing.Size(451, 20)
        Me.TextBoxAgenzia.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.riga, Me.articolo, Me.descrizione, Me.unitamisuramagazzino, Me.quantitamagazzino, Me.unitamisurafatturazione, Me.quantitafatturazione, Me.prezzo, Me.percentuale, Me.percentuale2, Me.percentuale3, Me.importo, Me.iva, Me.scorporo, Me.classemerceologica, Me.contropartita, Me.percentualeprovigioni, Me.aliax, Me.magazzino})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(901, 150)
        Me.DataGridView1.TabIndex = 20
        '
        'riga
        '
        Me.riga.HeaderText = "Riga"
        Me.riga.Name = "riga"
        '
        'articolo
        '
        Me.articolo.HeaderText = "Articolo"
        Me.articolo.Name = "articolo"
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "Descrizione"
        Me.descrizione.Name = "descrizione"
        '
        'unitamisuramagazzino
        '
        Me.unitamisuramagazzino.HeaderText = "U.M. Magazzino"
        Me.unitamisuramagazzino.Name = "unitamisuramagazzino"
        '
        'quantitamagazzino
        '
        Me.quantitamagazzino.HeaderText = "Q.tà Magazzino"
        Me.quantitamagazzino.Name = "quantitamagazzino"
        '
        'unitamisurafatturazione
        '
        Me.unitamisurafatturazione.HeaderText = "U.M. Fatturazione"
        Me.unitamisurafatturazione.Name = "unitamisurafatturazione"
        '
        'quantitafatturazione
        '
        Me.quantitafatturazione.HeaderText = "Q.tà Fatturazione"
        Me.quantitafatturazione.Name = "quantitafatturazione"
        '
        'prezzo
        '
        Me.prezzo.HeaderText = "Prezzo"
        Me.prezzo.Name = "prezzo"
        '
        'percentuale
        '
        Me.percentuale.HeaderText = "%"
        Me.percentuale.Name = "percentuale"
        '
        'percentuale2
        '
        Me.percentuale2.HeaderText = "%"
        Me.percentuale2.Name = "percentuale2"
        '
        'percentuale3
        '
        Me.percentuale3.HeaderText = "%"
        Me.percentuale3.Name = "percentuale3"
        '
        'importo
        '
        Me.importo.HeaderText = "Importo"
        Me.importo.Name = "importo"
        '
        'iva
        '
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        '
        'scorporo
        '
        Me.scorporo.HeaderText = "Scorporo"
        Me.scorporo.Name = "scorporo"
        '
        'classemerceologica
        '
        Me.classemerceologica.HeaderText = "Classe Merceologica"
        Me.classemerceologica.Name = "classemerceologica"
        '
        'contropartita
        '
        Me.contropartita.HeaderText = "Contro Partita"
        Me.contropartita.Name = "contropartita"
        '
        'percentualeprovigioni
        '
        Me.percentualeprovigioni.HeaderText = "% Provigioni"
        Me.percentualeprovigioni.Name = "percentualeprovigioni"
        '
        'aliax
        '
        Me.aliax.HeaderText = "Alias"
        Me.aliax.Name = "aliax"
        '
        'magazzino
        '
        Me.magazzino.HeaderText = "Magazzino"
        Me.magazzino.Name = "magazzino"
        '
        'TextBoxImballo
        '
        Me.TextBoxImballo.Location = New System.Drawing.Point(119, 35)
        Me.TextBoxImballo.Name = "TextBoxImballo"
        Me.TextBoxImballo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImballo.TabIndex = 22
        '
        'TextBoxTrasporto
        '
        Me.TextBoxTrasporto.Location = New System.Drawing.Point(6, 36)
        Me.TextBoxTrasporto.Name = "TextBoxTrasporto"
        Me.TextBoxTrasporto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTrasporto.TabIndex = 21
        '
        'ComboBoxPorto
        '
        Me.ComboBoxPorto.FormattingEnabled = True
        Me.ComboBoxPorto.Location = New System.Drawing.Point(370, 34)
        Me.ComboBoxPorto.Name = "ComboBoxPorto"
        Me.ComboBoxPorto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPorto.TabIndex = 24
        '
        'ComboBoxCausaleTrasporto
        '
        Me.ComboBoxCausaleTrasporto.FormattingEnabled = True
        Me.ComboBoxCausaleTrasporto.Location = New System.Drawing.Point(235, 34)
        Me.ComboBoxCausaleTrasporto.Name = "ComboBoxCausaleTrasporto"
        Me.ComboBoxCausaleTrasporto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCausaleTrasporto.TabIndex = 23
        '
        'TextBoxData
        '
        Me.TextBoxData.Location = New System.Drawing.Point(703, 36)
        Me.TextBoxData.Name = "TextBoxData"
        Me.TextBoxData.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxData.TabIndex = 27
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Location = New System.Drawing.Point(597, 36)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxPeso.TabIndex = 26
        '
        'TextBoxColli
        '
        Me.TextBoxColli.Location = New System.Drawing.Point(513, 36)
        Me.TextBoxColli.Name = "TextBoxColli"
        Me.TextBoxColli.Size = New System.Drawing.Size(68, 20)
        Me.TextBoxColli.TabIndex = 25
        '
        'TextBoxOraTrasporto
        '
        Me.TextBoxOraTrasporto.Location = New System.Drawing.Point(808, 36)
        Me.TextBoxOraTrasporto.Name = "TextBoxOraTrasporto"
        Me.TextBoxOraTrasporto.Size = New System.Drawing.Size(65, 20)
        Me.TextBoxOraTrasporto.TabIndex = 28
        '
        'TextBoxPercSconto
        '
        Me.TextBoxPercSconto.Location = New System.Drawing.Point(794, 29)
        Me.TextBoxPercSconto.Name = "TextBoxPercSconto"
        Me.TextBoxPercSconto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPercSconto.TabIndex = 41
        '
        'TextBoxTotMerce
        '
        Me.TextBoxTotMerce.Location = New System.Drawing.Point(676, 29)
        Me.TextBoxTotMerce.Name = "TextBoxTotMerce"
        Me.TextBoxTotMerce.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotMerce.TabIndex = 40
        '
        'ComboBoxCorriere
        '
        Me.ComboBoxCorriere.FormattingEnabled = True
        Me.ComboBoxCorriere.Location = New System.Drawing.Point(453, 79)
        Me.ComboBoxCorriere.Name = "ComboBoxCorriere"
        Me.ComboBoxCorriere.Size = New System.Drawing.Size(285, 21)
        Me.ComboBoxCorriere.TabIndex = 31
        '
        'ComboBoxTrasportoMezzo
        '
        Me.ComboBoxTrasportoMezzo.FormattingEnabled = True
        Me.ComboBoxTrasportoMezzo.Location = New System.Drawing.Point(235, 79)
        Me.ComboBoxTrasportoMezzo.Name = "ComboBoxTrasportoMezzo"
        Me.ComboBoxTrasportoMezzo.Size = New System.Drawing.Size(204, 21)
        Me.ComboBoxTrasportoMezzo.TabIndex = 30
        '
        'ComboBoxAspettoBeni
        '
        Me.ComboBoxAspettoBeni.FormattingEnabled = True
        Me.ComboBoxAspettoBeni.Location = New System.Drawing.Point(6, 79)
        Me.ComboBoxAspettoBeni.Name = "ComboBoxAspettoBeni"
        Me.ComboBoxAspettoBeni.Size = New System.Drawing.Size(213, 21)
        Me.ComboBoxAspettoBeni.TabIndex = 29
        '
        'ComboBoxCodiceIva
        '
        Me.ComboBoxCodiceIva.FormattingEnabled = True
        Me.ComboBoxCodiceIva.Location = New System.Drawing.Point(9, 28)
        Me.ComboBoxCodiceIva.Name = "ComboBoxCodiceIva"
        Me.ComboBoxCodiceIva.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCodiceIva.TabIndex = 32
        '
        'TextBoxTotDocumento
        '
        Me.TextBoxTotDocumento.Location = New System.Drawing.Point(676, 71)
        Me.TextBoxTotDocumento.Name = "TextBoxTotDocumento"
        Me.TextBoxTotDocumento.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotDocumento.TabIndex = 42
        '
        'TextBoxImportoIva
        '
        Me.TextBoxImportoIva.Location = New System.Drawing.Point(365, 28)
        Me.TextBoxImportoIva.Name = "TextBoxImportoIva"
        Me.TextBoxImportoIva.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImportoIva.TabIndex = 35
        '
        'TextBoxPercIva
        '
        Me.TextBoxPercIva.Location = New System.Drawing.Point(259, 28)
        Me.TextBoxPercIva.Name = "TextBoxPercIva"
        Me.TextBoxPercIva.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPercIva.TabIndex = 34
        '
        'TextBoxImponibile
        '
        Me.TextBoxImponibile.Location = New System.Drawing.Point(153, 28)
        Me.TextBoxImponibile.Name = "TextBoxImponibile"
        Me.TextBoxImponibile.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImponibile.TabIndex = 33
        '
        'ComboBoxDivisa
        '
        Me.ComboBoxDivisa.FormattingEnabled = True
        Me.ComboBoxDivisa.Location = New System.Drawing.Point(796, 71)
        Me.ComboBoxDivisa.Name = "ComboBoxDivisa"
        Me.ComboBoxDivisa.Size = New System.Drawing.Size(98, 21)
        Me.ComboBoxDivisa.TabIndex = 43
        '
        'TextBoxTotProvvigioni
        '
        Me.TextBoxTotProvvigioni.Location = New System.Drawing.Point(471, 71)
        Me.TextBoxTotProvvigioni.Name = "TextBoxTotProvvigioni"
        Me.TextBoxTotProvvigioni.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotProvvigioni.TabIndex = 44
        '
        'TextBoxImportoIva2
        '
        Me.TextBoxImportoIva2.Location = New System.Drawing.Point(365, 72)
        Me.TextBoxImportoIva2.Name = "TextBoxImportoIva2"
        Me.TextBoxImportoIva2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImportoIva2.TabIndex = 39
        '
        'TextBoxPercIva2
        '
        Me.TextBoxPercIva2.Location = New System.Drawing.Point(259, 72)
        Me.TextBoxPercIva2.Name = "TextBoxPercIva2"
        Me.TextBoxPercIva2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPercIva2.TabIndex = 38
        '
        'TextBoxImponibile2
        '
        Me.TextBoxImponibile2.Location = New System.Drawing.Point(153, 72)
        Me.TextBoxImponibile2.Name = "TextBoxImponibile2"
        Me.TextBoxImponibile2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImponibile2.TabIndex = 37
        '
        'ComboBoxCodiceIva2
        '
        Me.ComboBoxCodiceIva2.FormattingEnabled = True
        Me.ComboBoxCodiceIva2.Location = New System.Drawing.Point(9, 71)
        Me.ComboBoxCodiceIva2.Name = "ComboBoxCodiceIva2"
        Me.ComboBoxCodiceIva2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCodiceIva2.TabIndex = 36
        '
        'TextBoxS3
        '
        Me.TextBoxS3.Location = New System.Drawing.Point(624, 71)
        Me.TextBoxS3.Name = "TextBoxS3"
        Me.TextBoxS3.Size = New System.Drawing.Size(19, 20)
        Me.TextBoxS3.TabIndex = 47
        '
        'TextBoxS2
        '
        Me.TextBoxS2.Location = New System.Drawing.Point(600, 71)
        Me.TextBoxS2.Name = "TextBoxS2"
        Me.TextBoxS2.Size = New System.Drawing.Size(17, 20)
        Me.TextBoxS2.TabIndex = 46
        '
        'TextBoxS1
        '
        Me.TextBoxS1.Location = New System.Drawing.Point(577, 71)
        Me.TextBoxS1.Name = "TextBoxS1"
        Me.TextBoxS1.Size = New System.Drawing.Size(17, 20)
        Me.TextBoxS1.TabIndex = 45
        '
        'LabelAzienda
        '
        Me.LabelAzienda.AutoSize = True
        Me.LabelAzienda.Location = New System.Drawing.Point(6, 20)
        Me.LabelAzienda.Name = "LabelAzienda"
        Me.LabelAzienda.Size = New System.Drawing.Size(45, 13)
        Me.LabelAzienda.TabIndex = 48
        Me.LabelAzienda.Text = "Azienda"
        '
        'LabelEsercizio
        '
        Me.LabelEsercizio.AutoSize = True
        Me.LabelEsercizio.Location = New System.Drawing.Point(232, 19)
        Me.LabelEsercizio.Name = "LabelEsercizio"
        Me.LabelEsercizio.Size = New System.Drawing.Size(49, 13)
        Me.LabelEsercizio.TabIndex = 49
        Me.LabelEsercizio.Text = "Esercizio"
        '
        'LabelTipoDocumento
        '
        Me.LabelTipoDocumento.AutoSize = True
        Me.LabelTipoDocumento.Location = New System.Drawing.Point(425, 18)
        Me.LabelTipoDocumento.Name = "LabelTipoDocumento"
        Me.LabelTipoDocumento.Size = New System.Drawing.Size(97, 13)
        Me.LabelTipoDocumento.TabIndex = 50
        Me.LabelTipoDocumento.Text = "Tipo di Documento"
        '
        'LabelNumeroDocumento
        '
        Me.LabelNumeroDocumento.AutoSize = True
        Me.LabelNumeroDocumento.Location = New System.Drawing.Point(667, 19)
        Me.LabelNumeroDocumento.Name = "LabelNumeroDocumento"
        Me.LabelNumeroDocumento.Size = New System.Drawing.Size(113, 13)
        Me.LabelNumeroDocumento.TabIndex = 51
        Me.LabelNumeroDocumento.Text = "Numero di Documento"
        '
        'LabelSiglaOperatore
        '
        Me.LabelSiglaOperatore.AutoSize = True
        Me.LabelSiglaOperatore.Location = New System.Drawing.Point(793, 21)
        Me.LabelSiglaOperatore.Name = "LabelSiglaOperatore"
        Me.LabelSiglaOperatore.Size = New System.Drawing.Size(80, 13)
        Me.LabelSiglaOperatore.TabIndex = 52
        Me.LabelSiglaOperatore.Text = "Sigla Operatore"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxAzienda)
        Me.GroupBox1.Controls.Add(Me.LabelSiglaOperatore)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEsercizio)
        Me.GroupBox1.Controls.Add(Me.LabelNumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipiDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizio)
        Me.GroupBox1.Controls.Add(Me.TextBoxSiglaOperatore)
        Me.GroupBox1.Controls.Add(Me.LabelAzienda)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 69)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPagamento)
        Me.GroupBox2.Controls.Add(Me.LabelIva)
        Me.GroupBox2.Controls.Add(Me.LabelSconto)
        Me.GroupBox2.Controls.Add(Me.LabelRiferimento)
        Me.GroupBox2.Controls.Add(Me.LabelDataDocumento)
        Me.GroupBox2.Controls.Add(Me.LabelAgente)
        Me.GroupBox2.Controls.Add(Me.LabelCliente)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCliente)
        Me.GroupBox2.Controls.Add(Me.TextBoxDataDocumento)
        Me.GroupBox2.Controls.Add(Me.TextBoxRiferimento)
        Me.GroupBox2.Controls.Add(Me.ComboBoxAgente)
        Me.GroupBox2.Controls.Add(Me.ComboBoxIva)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPagamento)
        Me.GroupBox2.Controls.Add(Me.TextBoxSconto)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 158)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'LabelPagamento
        '
        Me.LabelPagamento.AutoSize = True
        Me.LabelPagamento.Location = New System.Drawing.Point(141, 109)
        Me.LabelPagamento.Name = "LabelPagamento"
        Me.LabelPagamento.Size = New System.Drawing.Size(61, 13)
        Me.LabelPagamento.TabIndex = 59
        Me.LabelPagamento.Text = "Pagamento"
        '
        'LabelIva
        '
        Me.LabelIva.AutoSize = True
        Me.LabelIva.Location = New System.Drawing.Point(6, 109)
        Me.LabelIva.Name = "LabelIva"
        Me.LabelIva.Size = New System.Drawing.Size(22, 13)
        Me.LabelIva.TabIndex = 58
        Me.LabelIva.Text = "Iva"
        '
        'LabelSconto
        '
        Me.LabelSconto.AutoSize = True
        Me.LabelSconto.Location = New System.Drawing.Point(353, 109)
        Me.LabelSconto.Name = "LabelSconto"
        Me.LabelSconto.Size = New System.Drawing.Size(41, 13)
        Me.LabelSconto.TabIndex = 57
        Me.LabelSconto.Text = "Sconto"
        '
        'LabelRiferimento
        '
        Me.LabelRiferimento.AutoSize = True
        Me.LabelRiferimento.Location = New System.Drawing.Point(103, 62)
        Me.LabelRiferimento.Name = "LabelRiferimento"
        Me.LabelRiferimento.Size = New System.Drawing.Size(60, 13)
        Me.LabelRiferimento.TabIndex = 56
        Me.LabelRiferimento.Text = "Riferimento"
        '
        'LabelDataDocumento
        '
        Me.LabelDataDocumento.AutoSize = True
        Me.LabelDataDocumento.Location = New System.Drawing.Point(3, 62)
        Me.LabelDataDocumento.Name = "LabelDataDocumento"
        Me.LabelDataDocumento.Size = New System.Drawing.Size(88, 13)
        Me.LabelDataDocumento.TabIndex = 55
        Me.LabelDataDocumento.Text = "Data Documento"
        '
        'LabelAgente
        '
        Me.LabelAgente.AutoSize = True
        Me.LabelAgente.Location = New System.Drawing.Point(232, 61)
        Me.LabelAgente.Name = "LabelAgente"
        Me.LabelAgente.Size = New System.Drawing.Size(41, 13)
        Me.LabelAgente.TabIndex = 54
        Me.LabelAgente.Text = "Agente"
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Location = New System.Drawing.Point(6, 18)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(39, 13)
        Me.LabelCliente.TabIndex = 53
        Me.LabelCliente.Text = "Cliente"
        '
        'LabelBanca
        '
        Me.LabelBanca.AutoSize = True
        Me.LabelBanca.Location = New System.Drawing.Point(5, 18)
        Me.LabelBanca.Name = "LabelBanca"
        Me.LabelBanca.Size = New System.Drawing.Size(38, 13)
        Me.LabelBanca.TabIndex = 60
        Me.LabelBanca.Text = "Banca"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelDestinazione)
        Me.GroupBox3.Controls.Add(Me.ComboBoxDestinazione)
        Me.GroupBox3.Controls.Add(Me.TextBoxDestinazione2)
        Me.GroupBox3.Controls.Add(Me.TextBoxDestinazione3)
        Me.GroupBox3.Controls.Add(Me.TextBoxCAP)
        Me.GroupBox3.Controls.Add(Me.TextBoxLocalita)
        Me.GroupBox3.Controls.Add(Me.TextBoxProvincia)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 158)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'LabelDestinazione
        '
        Me.LabelDestinazione.AutoSize = True
        Me.LabelDestinazione.Location = New System.Drawing.Point(6, 18)
        Me.LabelDestinazione.Name = "LabelDestinazione"
        Me.LabelDestinazione.Size = New System.Drawing.Size(68, 13)
        Me.LabelDestinazione.TabIndex = 54
        Me.LabelDestinazione.Text = "Destinazione"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelAgenzia)
        Me.GroupBox4.Controls.Add(Me.TextBoxBanca)
        Me.GroupBox4.Controls.Add(Me.LabelBanca)
        Me.GroupBox4.Controls.Add(Me.TextBoxAgenzia)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(901, 64)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'LabelAgenzia
        '
        Me.LabelAgenzia.AutoSize = True
        Me.LabelAgenzia.Location = New System.Drawing.Point(442, 18)
        Me.LabelAgenzia.Name = "LabelAgenzia"
        Me.LabelAgenzia.Size = New System.Drawing.Size(45, 13)
        Me.LabelAgenzia.TabIndex = 61
        Me.LabelAgenzia.Text = "Agenzia"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelCorriere)
        Me.GroupBox5.Controls.Add(Me.LabelTrasportoMezzo)
        Me.GroupBox5.Controls.Add(Me.LabelAspettoBeni)
        Me.GroupBox5.Controls.Add(Me.LabelOraTrasporto)
        Me.GroupBox5.Controls.Add(Me.LabelData)
        Me.GroupBox5.Controls.Add(Me.LabelPeso)
        Me.GroupBox5.Controls.Add(Me.LabelColli)
        Me.GroupBox5.Controls.Add(Me.LabelPorto)
        Me.GroupBox5.Controls.Add(Me.LabelCausaleTrasporto)
        Me.GroupBox5.Controls.Add(Me.LabelImballo)
        Me.GroupBox5.Controls.Add(Me.LabelTrasporto)
        Me.GroupBox5.Controls.Add(Me.TextBoxTrasporto)
        Me.GroupBox5.Controls.Add(Me.TextBoxImballo)
        Me.GroupBox5.Controls.Add(Me.ComboBoxCausaleTrasporto)
        Me.GroupBox5.Controls.Add(Me.ComboBoxPorto)
        Me.GroupBox5.Controls.Add(Me.TextBoxColli)
        Me.GroupBox5.Controls.Add(Me.TextBoxPeso)
        Me.GroupBox5.Controls.Add(Me.TextBoxData)
        Me.GroupBox5.Controls.Add(Me.TextBoxOraTrasporto)
        Me.GroupBox5.Controls.Add(Me.ComboBoxAspettoBeni)
        Me.GroupBox5.Controls.Add(Me.ComboBoxTrasportoMezzo)
        Me.GroupBox5.Controls.Add(Me.ComboBoxCorriere)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 490)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(901, 111)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        '
        'LabelCorriere
        '
        Me.LabelCorriere.AutoSize = True
        Me.LabelCorriere.Location = New System.Drawing.Point(450, 63)
        Me.LabelCorriere.Name = "LabelCorriere"
        Me.LabelCorriere.Size = New System.Drawing.Size(43, 13)
        Me.LabelCorriere.TabIndex = 72
        Me.LabelCorriere.Text = "Corriere"
        '
        'LabelTrasportoMezzo
        '
        Me.LabelTrasportoMezzo.AutoSize = True
        Me.LabelTrasportoMezzo.Location = New System.Drawing.Point(232, 63)
        Me.LabelTrasportoMezzo.Name = "LabelTrasportoMezzo"
        Me.LabelTrasportoMezzo.Size = New System.Drawing.Size(97, 13)
        Me.LabelTrasportoMezzo.TabIndex = 71
        Me.LabelTrasportoMezzo.Text = "Trasporto al Mezzo"
        '
        'LabelAspettoBeni
        '
        Me.LabelAspettoBeni.AutoSize = True
        Me.LabelAspettoBeni.Location = New System.Drawing.Point(6, 63)
        Me.LabelAspettoBeni.Name = "LabelAspettoBeni"
        Me.LabelAspettoBeni.Size = New System.Drawing.Size(84, 13)
        Me.LabelAspettoBeni.TabIndex = 70
        Me.LabelAspettoBeni.Text = "Aspetto dei Beni"
        '
        'LabelOraTrasporto
        '
        Me.LabelOraTrasporto.AutoSize = True
        Me.LabelOraTrasporto.Location = New System.Drawing.Point(805, 20)
        Me.LabelOraTrasporto.Name = "LabelOraTrasporto"
        Me.LabelOraTrasporto.Size = New System.Drawing.Size(89, 13)
        Me.LabelOraTrasporto.TabIndex = 69
        Me.LabelOraTrasporto.Text = "Ora del Trasporto"
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(700, 20)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 68
        Me.LabelData.Text = "Data"
        '
        'LabelPeso
        '
        Me.LabelPeso.AutoSize = True
        Me.LabelPeso.Location = New System.Drawing.Point(594, 20)
        Me.LabelPeso.Name = "LabelPeso"
        Me.LabelPeso.Size = New System.Drawing.Size(31, 13)
        Me.LabelPeso.TabIndex = 67
        Me.LabelPeso.Text = "Peso"
        '
        'LabelColli
        '
        Me.LabelColli.AutoSize = True
        Me.LabelColli.Location = New System.Drawing.Point(510, 20)
        Me.LabelColli.Name = "LabelColli"
        Me.LabelColli.Size = New System.Drawing.Size(26, 13)
        Me.LabelColli.TabIndex = 66
        Me.LabelColli.Text = "Colli"
        '
        'LabelPorto
        '
        Me.LabelPorto.AutoSize = True
        Me.LabelPorto.Location = New System.Drawing.Point(367, 19)
        Me.LabelPorto.Name = "LabelPorto"
        Me.LabelPorto.Size = New System.Drawing.Size(32, 13)
        Me.LabelPorto.TabIndex = 65
        Me.LabelPorto.Text = "Porto"
        '
        'LabelCausaleTrasporto
        '
        Me.LabelCausaleTrasporto.AutoSize = True
        Me.LabelCausaleTrasporto.Location = New System.Drawing.Point(232, 19)
        Me.LabelCausaleTrasporto.Name = "LabelCausaleTrasporto"
        Me.LabelCausaleTrasporto.Size = New System.Drawing.Size(93, 13)
        Me.LabelCausaleTrasporto.TabIndex = 64
        Me.LabelCausaleTrasporto.Text = "Causale Trasporto"
        '
        'LabelImballo
        '
        Me.LabelImballo.AutoSize = True
        Me.LabelImballo.Location = New System.Drawing.Point(120, 19)
        Me.LabelImballo.Name = "LabelImballo"
        Me.LabelImballo.Size = New System.Drawing.Size(40, 13)
        Me.LabelImballo.TabIndex = 63
        Me.LabelImballo.Text = "Imballo"
        '
        'LabelTrasporto
        '
        Me.LabelTrasporto.AutoSize = True
        Me.LabelTrasporto.Location = New System.Drawing.Point(3, 20)
        Me.LabelTrasporto.Name = "LabelTrasporto"
        Me.LabelTrasporto.Size = New System.Drawing.Size(52, 13)
        Me.LabelTrasporto.TabIndex = 62
        Me.LabelTrasporto.Text = "Trasporto"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LabelS3)
        Me.GroupBox6.Controls.Add(Me.LabelS2)
        Me.GroupBox6.Controls.Add(Me.LabelS1)
        Me.GroupBox6.Controls.Add(Me.LabelTotaleProvvigioni)
        Me.GroupBox6.Controls.Add(Me.LabelDivisa)
        Me.GroupBox6.Controls.Add(Me.LabelTotaleDocumento)
        Me.GroupBox6.Controls.Add(Me.LabelImportoIva2)
        Me.GroupBox6.Controls.Add(Me.LabelpercentualeIva2)
        Me.GroupBox6.Controls.Add(Me.LabelImponibile2)
        Me.GroupBox6.Controls.Add(Me.LabelCodiceIva2)
        Me.GroupBox6.Controls.Add(Me.LabelImportoIva)
        Me.GroupBox6.Controls.Add(Me.LabelpercentualeIva)
        Me.GroupBox6.Controls.Add(Me.LabelImponibile)
        Me.GroupBox6.Controls.Add(Me.LabelCodiceIva)
        Me.GroupBox6.Controls.Add(Me.Labelpercentualesconto)
        Me.GroupBox6.Controls.Add(Me.LabelTotaleMerce)
        Me.GroupBox6.Controls.Add(Me.TextBoxS3)
        Me.GroupBox6.Controls.Add(Me.TextBoxTotMerce)
        Me.GroupBox6.Controls.Add(Me.TextBoxS2)
        Me.GroupBox6.Controls.Add(Me.TextBoxPercSconto)
        Me.GroupBox6.Controls.Add(Me.TextBoxS1)
        Me.GroupBox6.Controls.Add(Me.ComboBoxCodiceIva)
        Me.GroupBox6.Controls.Add(Me.TextBoxTotProvvigioni)
        Me.GroupBox6.Controls.Add(Me.TextBoxImponibile)
        Me.GroupBox6.Controls.Add(Me.ComboBoxDivisa)
        Me.GroupBox6.Controls.Add(Me.TextBoxImportoIva2)
        Me.GroupBox6.Controls.Add(Me.TextBoxTotDocumento)
        Me.GroupBox6.Controls.Add(Me.TextBoxPercIva)
        Me.GroupBox6.Controls.Add(Me.TextBoxPercIva2)
        Me.GroupBox6.Controls.Add(Me.TextBoxImportoIva)
        Me.GroupBox6.Controls.Add(Me.TextBoxImponibile2)
        Me.GroupBox6.Controls.Add(Me.ComboBoxCodiceIva2)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 607)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(901, 108)
        Me.GroupBox6.TabIndex = 63
        Me.GroupBox6.TabStop = False
        '
        'LabelS3
        '
        Me.LabelS3.AutoSize = True
        Me.LabelS3.Location = New System.Drawing.Point(623, 54)
        Me.LabelS3.Name = "LabelS3"
        Me.LabelS3.Size = New System.Drawing.Size(20, 13)
        Me.LabelS3.TabIndex = 88
        Me.LabelS3.Text = "S3"
        '
        'LabelS2
        '
        Me.LabelS2.AutoSize = True
        Me.LabelS2.Location = New System.Drawing.Point(599, 54)
        Me.LabelS2.Name = "LabelS2"
        Me.LabelS2.Size = New System.Drawing.Size(20, 13)
        Me.LabelS2.TabIndex = 87
        Me.LabelS2.Text = "S2"
        '
        'LabelS1
        '
        Me.LabelS1.AutoSize = True
        Me.LabelS1.Location = New System.Drawing.Point(574, 55)
        Me.LabelS1.Name = "LabelS1"
        Me.LabelS1.Size = New System.Drawing.Size(20, 13)
        Me.LabelS1.TabIndex = 86
        Me.LabelS1.Text = "S1"
        '
        'LabelTotaleProvvigioni
        '
        Me.LabelTotaleProvvigioni.AutoSize = True
        Me.LabelTotaleProvvigioni.Location = New System.Drawing.Point(468, 55)
        Me.LabelTotaleProvvigioni.Name = "LabelTotaleProvvigioni"
        Me.LabelTotaleProvvigioni.Size = New System.Drawing.Size(92, 13)
        Me.LabelTotaleProvvigioni.TabIndex = 85
        Me.LabelTotaleProvvigioni.Text = "Totale Provvigioni"
        '
        'LabelDivisa
        '
        Me.LabelDivisa.AutoSize = True
        Me.LabelDivisa.Location = New System.Drawing.Point(793, 55)
        Me.LabelDivisa.Name = "LabelDivisa"
        Me.LabelDivisa.Size = New System.Drawing.Size(36, 13)
        Me.LabelDivisa.TabIndex = 84
        Me.LabelDivisa.Text = "Divisa"
        '
        'LabelTotaleDocumento
        '
        Me.LabelTotaleDocumento.AutoSize = True
        Me.LabelTotaleDocumento.Location = New System.Drawing.Point(673, 55)
        Me.LabelTotaleDocumento.Name = "LabelTotaleDocumento"
        Me.LabelTotaleDocumento.Size = New System.Drawing.Size(95, 13)
        Me.LabelTotaleDocumento.TabIndex = 83
        Me.LabelTotaleDocumento.Text = "Totale Documento"
        '
        'LabelImportoIva2
        '
        Me.LabelImportoIva2.AutoSize = True
        Me.LabelImportoIva2.Location = New System.Drawing.Point(362, 54)
        Me.LabelImportoIva2.Name = "LabelImportoIva2"
        Me.LabelImportoIva2.Size = New System.Drawing.Size(60, 13)
        Me.LabelImportoIva2.TabIndex = 82
        Me.LabelImportoIva2.Text = "Importo Iva"
        '
        'LabelpercentualeIva2
        '
        Me.LabelpercentualeIva2.AutoSize = True
        Me.LabelpercentualeIva2.Location = New System.Drawing.Point(256, 55)
        Me.LabelpercentualeIva2.Name = "LabelpercentualeIva2"
        Me.LabelpercentualeIva2.Size = New System.Drawing.Size(33, 13)
        Me.LabelpercentualeIva2.TabIndex = 81
        Me.LabelpercentualeIva2.Text = "% Iva"
        '
        'LabelImponibile2
        '
        Me.LabelImponibile2.AutoSize = True
        Me.LabelImponibile2.Location = New System.Drawing.Point(150, 55)
        Me.LabelImponibile2.Name = "LabelImponibile2"
        Me.LabelImponibile2.Size = New System.Drawing.Size(54, 13)
        Me.LabelImponibile2.TabIndex = 80
        Me.LabelImponibile2.Text = "Imponibile"
        '
        'LabelCodiceIva2
        '
        Me.LabelCodiceIva2.AutoSize = True
        Me.LabelCodiceIva2.Location = New System.Drawing.Point(6, 55)
        Me.LabelCodiceIva2.Name = "LabelCodiceIva2"
        Me.LabelCodiceIva2.Size = New System.Drawing.Size(58, 13)
        Me.LabelCodiceIva2.TabIndex = 79
        Me.LabelCodiceIva2.Text = "Codice Iva"
        '
        'LabelImportoIva
        '
        Me.LabelImportoIva.AutoSize = True
        Me.LabelImportoIva.Location = New System.Drawing.Point(362, 12)
        Me.LabelImportoIva.Name = "LabelImportoIva"
        Me.LabelImportoIva.Size = New System.Drawing.Size(60, 13)
        Me.LabelImportoIva.TabIndex = 78
        Me.LabelImportoIva.Text = "Importo Iva"
        '
        'LabelpercentualeIva
        '
        Me.LabelpercentualeIva.AutoSize = True
        Me.LabelpercentualeIva.Location = New System.Drawing.Point(256, 13)
        Me.LabelpercentualeIva.Name = "LabelpercentualeIva"
        Me.LabelpercentualeIva.Size = New System.Drawing.Size(33, 13)
        Me.LabelpercentualeIva.TabIndex = 77
        Me.LabelpercentualeIva.Text = "% Iva"
        '
        'LabelImponibile
        '
        Me.LabelImponibile.AutoSize = True
        Me.LabelImponibile.Location = New System.Drawing.Point(150, 13)
        Me.LabelImponibile.Name = "LabelImponibile"
        Me.LabelImponibile.Size = New System.Drawing.Size(54, 13)
        Me.LabelImponibile.TabIndex = 76
        Me.LabelImponibile.Text = "Imponibile"
        '
        'LabelCodiceIva
        '
        Me.LabelCodiceIva.AutoSize = True
        Me.LabelCodiceIva.Location = New System.Drawing.Point(6, 13)
        Me.LabelCodiceIva.Name = "LabelCodiceIva"
        Me.LabelCodiceIva.Size = New System.Drawing.Size(58, 13)
        Me.LabelCodiceIva.TabIndex = 75
        Me.LabelCodiceIva.Text = "Codice Iva"
        '
        'Labelpercentualesconto
        '
        Me.Labelpercentualesconto.AutoSize = True
        Me.Labelpercentualesconto.Location = New System.Drawing.Point(791, 13)
        Me.Labelpercentualesconto.Name = "Labelpercentualesconto"
        Me.Labelpercentualesconto.Size = New System.Drawing.Size(52, 13)
        Me.Labelpercentualesconto.TabIndex = 74
        Me.Labelpercentualesconto.Text = "% Sconto"
        '
        'LabelTotaleMerce
        '
        Me.LabelTotaleMerce.AutoSize = True
        Me.LabelTotaleMerce.Location = New System.Drawing.Point(673, 13)
        Me.LabelTotaleMerce.Name = "LabelTotaleMerce"
        Me.LabelTotaleMerce.Size = New System.Drawing.Size(70, 13)
        Me.LabelTotaleMerce.TabIndex = 73
        Me.LabelTotaleMerce.Text = "Totale Merce"
        '
        'Navigatore1
        '
        Me.Navigatore1.BackColor = System.Drawing.Color.Transparent
        Me.Navigatore1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Navigatore1.Location = New System.Drawing.Point(0, 0)
        Me.Navigatore1.Name = "Navigatore1"
        Me.Navigatore1.Size = New System.Drawing.Size(925, 36)
        Me.Navigatore1.TabIndex = 64
        '
        'GestioneDocumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 764)
        Me.Controls.Add(Me.Navigatore1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GestioneDocumenti"
        Me.Text = "Gestione dei Documenti"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxAzienda As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEsercizio As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTipiDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxNumeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSiglaOperatore As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCliente As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDestinazione As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxRiferimento As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDataDocumento As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAgente As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxDestinazione2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxIva As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxBanca As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSconto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCAP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDestinazione3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLocalita As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProvincia As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAgenzia As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxImballo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTrasporto As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxPorto As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCausaleTrasporto As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxData As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPeso As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxColli As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOraTrasporto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPercSconto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotMerce As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCorriere As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTrasportoMezzo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAspettoBeni As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCodiceIva As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxTotDocumento As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxImportoIva As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPercIva As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxImponibile As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDivisa As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxTotProvvigioni As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxImportoIva2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPercIva2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxImponibile2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCodiceIva2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxS3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxS2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxS1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelAzienda As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizio As System.Windows.Forms.Label
    Friend WithEvents LabelTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelSiglaOperatore As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelRiferimento As System.Windows.Forms.Label
    Friend WithEvents LabelDataDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelAgente As System.Windows.Forms.Label
    Friend WithEvents LabelCliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDestinazione As System.Windows.Forms.Label
    Friend WithEvents LabelPagamento As System.Windows.Forms.Label
    Friend WithEvents LabelIva As System.Windows.Forms.Label
    Friend WithEvents LabelSconto As System.Windows.Forms.Label
    Friend WithEvents LabelBanca As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents riga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents articolo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitamisuramagazzino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantitamagazzino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitamisurafatturazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantitafatturazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentuale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentuale2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentuale3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents scorporo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents classemerceologica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contropartita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentualeprovigioni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aliax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents magazzino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelAgenzia As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCorriere As System.Windows.Forms.Label
    Friend WithEvents LabelTrasportoMezzo As System.Windows.Forms.Label
    Friend WithEvents LabelAspettoBeni As System.Windows.Forms.Label
    Friend WithEvents LabelOraTrasporto As System.Windows.Forms.Label
    Friend WithEvents LabelData As System.Windows.Forms.Label
    Friend WithEvents LabelPeso As System.Windows.Forms.Label
    Friend WithEvents LabelColli As System.Windows.Forms.Label
    Friend WithEvents LabelPorto As System.Windows.Forms.Label
    Friend WithEvents LabelCausaleTrasporto As System.Windows.Forms.Label
    Friend WithEvents LabelImballo As System.Windows.Forms.Label
    Friend WithEvents LabelTrasporto As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelS3 As System.Windows.Forms.Label
    Friend WithEvents LabelS2 As System.Windows.Forms.Label
    Friend WithEvents LabelS1 As System.Windows.Forms.Label
    Friend WithEvents LabelTotaleProvvigioni As System.Windows.Forms.Label
    Friend WithEvents LabelDivisa As System.Windows.Forms.Label
    Friend WithEvents LabelTotaleDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelImportoIva2 As System.Windows.Forms.Label
    Friend WithEvents LabelpercentualeIva2 As System.Windows.Forms.Label
    Friend WithEvents LabelImponibile2 As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceIva2 As System.Windows.Forms.Label
    Friend WithEvents LabelImportoIva As System.Windows.Forms.Label
    Friend WithEvents LabelpercentualeIva As System.Windows.Forms.Label
    Friend WithEvents LabelImponibile As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceIva As System.Windows.Forms.Label
    Friend WithEvents Labelpercentualesconto As System.Windows.Forms.Label
    Friend WithEvents LabelTotaleMerce As System.Windows.Forms.Label
    Friend WithEvents Navigatore1 As GeVen_SE_2015.Navigatore
End Class
