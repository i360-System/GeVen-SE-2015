<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimenti
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LabelAzienda = New System.Windows.Forms.Label()
        Me.LabelEsercizio = New System.Windows.Forms.Label()
        Me.LabelNumeroMovimento = New System.Windows.Forms.Label()
        Me.LabelDocumento = New System.Windows.Forms.Label()
        Me.LabelDataDocumento = New System.Windows.Forms.Label()
        Me.LabelCausale = New System.Windows.Forms.Label()
        Me.LabelDescrizioneMovimento = New System.Windows.Forms.Label()
        Me.LabelAnagrafica = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.riga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datamovimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.magazzino = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tipomovimento = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.articolo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitamisura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelAnagrafica)
        Me.GroupBox1.Controls.Add(Me.LabelDescrizioneMovimento)
        Me.GroupBox1.Controls.Add(Me.LabelCausale)
        Me.GroupBox1.Controls.Add(Me.LabelDataDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelNumeroMovimento)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizio)
        Me.GroupBox1.Controls.Add(Me.LabelAzienda)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(325, 39)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(643, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(219, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(325, 84)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(10, 127)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(309, 20)
        Me.TextBox4.TabIndex = 6
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(325, 126)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox4.TabIndex = 7
        '
        'LabelAzienda
        '
        Me.LabelAzienda.AutoSize = True
        Me.LabelAzienda.Location = New System.Drawing.Point(7, 23)
        Me.LabelAzienda.Name = "LabelAzienda"
        Me.LabelAzienda.Size = New System.Drawing.Size(45, 13)
        Me.LabelAzienda.TabIndex = 8
        Me.LabelAzienda.Text = "Azienda"
        '
        'LabelEsercizio
        '
        Me.LabelEsercizio.AutoSize = True
        Me.LabelEsercizio.Location = New System.Drawing.Point(322, 23)
        Me.LabelEsercizio.Name = "LabelEsercizio"
        Me.LabelEsercizio.Size = New System.Drawing.Size(49, 13)
        Me.LabelEsercizio.TabIndex = 9
        Me.LabelEsercizio.Text = "Esercizio"
        '
        'LabelNumeroMovimento
        '
        Me.LabelNumeroMovimento.AutoSize = True
        Me.LabelNumeroMovimento.Location = New System.Drawing.Point(640, 23)
        Me.LabelNumeroMovimento.Name = "LabelNumeroMovimento"
        Me.LabelNumeroMovimento.Size = New System.Drawing.Size(99, 13)
        Me.LabelNumeroMovimento.TabIndex = 10
        Me.LabelNumeroMovimento.Text = "Numero Movimento"
        '
        'LabelDocumento
        '
        Me.LabelDocumento.AutoSize = True
        Me.LabelDocumento.Location = New System.Drawing.Point(7, 69)
        Me.LabelDocumento.Name = "LabelDocumento"
        Me.LabelDocumento.Size = New System.Drawing.Size(62, 13)
        Me.LabelDocumento.TabIndex = 11
        Me.LabelDocumento.Text = "Documento"
        '
        'LabelDataDocumento
        '
        Me.LabelDataDocumento.AutoSize = True
        Me.LabelDataDocumento.Location = New System.Drawing.Point(216, 69)
        Me.LabelDataDocumento.Name = "LabelDataDocumento"
        Me.LabelDataDocumento.Size = New System.Drawing.Size(88, 13)
        Me.LabelDataDocumento.TabIndex = 12
        Me.LabelDataDocumento.Text = "Data Documento"
        '
        'LabelCausale
        '
        Me.LabelCausale.AutoSize = True
        Me.LabelCausale.Location = New System.Drawing.Point(322, 68)
        Me.LabelCausale.Name = "LabelCausale"
        Me.LabelCausale.Size = New System.Drawing.Size(45, 13)
        Me.LabelCausale.TabIndex = 13
        Me.LabelCausale.Text = "Causale"
        '
        'LabelDescrizioneMovimento
        '
        Me.LabelDescrizioneMovimento.AutoSize = True
        Me.LabelDescrizioneMovimento.Location = New System.Drawing.Point(6, 110)
        Me.LabelDescrizioneMovimento.Name = "LabelDescrizioneMovimento"
        Me.LabelDescrizioneMovimento.Size = New System.Drawing.Size(117, 13)
        Me.LabelDescrizioneMovimento.TabIndex = 14
        Me.LabelDescrizioneMovimento.Text = "Descrizione Movimento"
        '
        'LabelAnagrafica
        '
        Me.LabelAnagrafica.AutoSize = True
        Me.LabelAnagrafica.Location = New System.Drawing.Point(322, 110)
        Me.LabelAnagrafica.Name = "LabelAnagrafica"
        Me.LabelAnagrafica.Size = New System.Drawing.Size(58, 13)
        Me.LabelAnagrafica.TabIndex = 15
        Me.LabelAnagrafica.Text = "Anagrafica"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.riga, Me.datamovimento, Me.magazzino, Me.tipomovimento, Me.articolo, Me.descrizione, Me.unitamisura, Me.quantita, Me.prezzo, Me.valore})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(817, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'riga
        '
        Me.riga.HeaderText = "Riga"
        Me.riga.Name = "riga"
        Me.riga.Width = 54
        '
        'datamovimento
        '
        Me.datamovimento.HeaderText = "Data Movimento"
        Me.datamovimento.Name = "datamovimento"
        Me.datamovimento.Width = 101
        '
        'magazzino
        '
        Me.magazzino.HeaderText = "Magazzino"
        Me.magazzino.Name = "magazzino"
        Me.magazzino.Width = 64
        '
        'tipomovimento
        '
        Me.tipomovimento.HeaderText = "Tipo Movimento"
        Me.tipomovimento.Name = "tipomovimento"
        Me.tipomovimento.Width = 80
        '
        'articolo
        '
        Me.articolo.HeaderText = "Articolo"
        Me.articolo.Name = "articolo"
        Me.articolo.Width = 48
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "Descrizione"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.Width = 87
        '
        'unitamisura
        '
        Me.unitamisura.HeaderText = "Unita di Misurà"
        Me.unitamisura.Name = "unitamisura"
        Me.unitamisura.Width = 94
        '
        'quantita
        '
        Me.quantita.HeaderText = "Quantità"
        Me.quantita.Name = "quantita"
        Me.quantita.Width = 72
        '
        'prezzo
        '
        Me.prezzo.HeaderText = "Prezzo"
        Me.prezzo.Name = "prezzo"
        Me.prezzo.Width = 64
        '
        'valore
        '
        Me.valore.HeaderText = "Valore"
        Me.valore.Name = "valore"
        Me.valore.Width = 62
        '
        'Movimenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 364)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Movimenti"
        Me.Text = "Movimenti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAnagrafica As System.Windows.Forms.Label
    Friend WithEvents LabelDescrizioneMovimento As System.Windows.Forms.Label
    Friend WithEvents LabelCausale As System.Windows.Forms.Label
    Friend WithEvents LabelDataDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelNumeroMovimento As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizio As System.Windows.Forms.Label
    Friend WithEvents LabelAzienda As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents riga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datamovimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents magazzino As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tipomovimento As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents articolo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitamisura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valore As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
