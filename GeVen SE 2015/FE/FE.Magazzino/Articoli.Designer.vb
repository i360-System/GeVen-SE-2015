<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articoli
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LabelArticolo = New System.Windows.Forms.Label()
        Me.LabelDenominazione = New System.Windows.Forms.Label()
        Me.LabelCodiceIva = New System.Windows.Forms.Label()
        Me.LabelScorporo = New System.Windows.Forms.Label()
        Me.LabelClasseMerceologica = New System.Windows.Forms.Label()
        Me.LabelContropartita = New System.Windows.Forms.Label()
        Me.LabelArticoloAlias = New System.Windows.Forms.Label()
        Me.LabelClasseArticolo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.unitamisura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coefficientequantita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coefficienteprezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scortaminima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scortamassima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lottoriordino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prezzovendita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prezzoacquisto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelClasseArticolo)
        Me.GroupBox1.Controls.Add(Me.LabelArticoloAlias)
        Me.GroupBox1.Controls.Add(Me.LabelContropartita)
        Me.GroupBox1.Controls.Add(Me.LabelClasseMerceologica)
        Me.GroupBox1.Controls.Add(Me.LabelScorporo)
        Me.GroupBox1.Controls.Add(Me.LabelCodiceIva)
        Me.GroupBox1.Controls.Add(Me.LabelDenominazione)
        Me.GroupBox1.Controls.Add(Me.LabelArticolo)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(240, 36)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(333, 59)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(164, 127)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(47, 20)
        Me.TextBox5.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(217, 127)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(397, 129)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(64, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(467, 130)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(228, 20)
        Me.TextBox7.TabIndex = 6
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(701, 129)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox3.TabIndex = 7
        '
        'LabelArticolo
        '
        Me.LabelArticolo.AutoSize = True
        Me.LabelArticolo.Location = New System.Drawing.Point(7, 17)
        Me.LabelArticolo.Name = "LabelArticolo"
        Me.LabelArticolo.Size = New System.Drawing.Size(42, 13)
        Me.LabelArticolo.TabIndex = 10
        Me.LabelArticolo.Text = "Articolo"
        '
        'LabelDenominazione
        '
        Me.LabelDenominazione.AutoSize = True
        Me.LabelDenominazione.Location = New System.Drawing.Point(237, 20)
        Me.LabelDenominazione.Name = "LabelDenominazione"
        Me.LabelDenominazione.Size = New System.Drawing.Size(80, 13)
        Me.LabelDenominazione.TabIndex = 11
        Me.LabelDenominazione.Text = "Denominazione"
        '
        'LabelCodiceIva
        '
        Me.LabelCodiceIva.AutoSize = True
        Me.LabelCodiceIva.Location = New System.Drawing.Point(6, 110)
        Me.LabelCodiceIva.Name = "LabelCodiceIva"
        Me.LabelCodiceIva.Size = New System.Drawing.Size(58, 13)
        Me.LabelCodiceIva.TabIndex = 12
        Me.LabelCodiceIva.Text = "Codice Iva"
        '
        'LabelScorporo
        '
        Me.LabelScorporo.AutoSize = True
        Me.LabelScorporo.Location = New System.Drawing.Point(161, 110)
        Me.LabelScorporo.Name = "LabelScorporo"
        Me.LabelScorporo.Size = New System.Drawing.Size(50, 13)
        Me.LabelScorporo.TabIndex = 13
        Me.LabelScorporo.Text = "Scorporo"
        '
        'LabelClasseMerceologica
        '
        Me.LabelClasseMerceologica.AutoSize = True
        Me.LabelClasseMerceologica.Location = New System.Drawing.Point(214, 111)
        Me.LabelClasseMerceologica.Name = "LabelClasseMerceologica"
        Me.LabelClasseMerceologica.Size = New System.Drawing.Size(105, 13)
        Me.LabelClasseMerceologica.TabIndex = 14
        Me.LabelClasseMerceologica.Text = "Classe Merceologica"
        '
        'LabelContropartita
        '
        Me.LabelContropartita.AutoSize = True
        Me.LabelContropartita.Location = New System.Drawing.Point(394, 112)
        Me.LabelContropartita.Name = "LabelContropartita"
        Me.LabelContropartita.Size = New System.Drawing.Size(67, 13)
        Me.LabelContropartita.TabIndex = 15
        Me.LabelContropartita.Text = "Contropartita"
        '
        'LabelArticoloAlias
        '
        Me.LabelArticoloAlias.AutoSize = True
        Me.LabelArticoloAlias.Location = New System.Drawing.Point(464, 111)
        Me.LabelArticoloAlias.Name = "LabelArticoloAlias"
        Me.LabelArticoloAlias.Size = New System.Drawing.Size(67, 13)
        Me.LabelArticoloAlias.TabIndex = 16
        Me.LabelArticoloAlias.Text = "Articolo Alias"
        '
        'LabelClasseArticolo
        '
        Me.LabelClasseArticolo.AutoSize = True
        Me.LabelClasseArticolo.Location = New System.Drawing.Point(698, 113)
        Me.LabelClasseArticolo.Name = "LabelClasseArticolo"
        Me.LabelClasseArticolo.Size = New System.Drawing.Size(76, 13)
        Me.LabelClasseArticolo.TabIndex = 17
        Me.LabelClasseArticolo.Text = "Classe Articolo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.unitamisura, Me.coefficientequantita, Me.coefficienteprezzo, Me.scortaminima, Me.scortamassima, Me.lottoriordino, Me.prezzovendita, Me.prezzoacquisto})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(886, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'unitamisura
        '
        Me.unitamisura.HeaderText = "Unità di Misura"
        Me.unitamisura.Name = "unitamisura"
        Me.unitamisura.Width = 102
        '
        'coefficientequantita
        '
        Me.coefficientequantita.HeaderText = "Coefficiente di Quantità"
        Me.coefficientequantita.Name = "coefficientequantita"
        Me.coefficientequantita.Width = 94
        '
        'coefficienteprezzo
        '
        Me.coefficienteprezzo.HeaderText = "Coefficiente Prezzo"
        Me.coefficienteprezzo.Name = "coefficienteprezzo"
        Me.coefficienteprezzo.Width = 113
        '
        'scortaminima
        '
        Me.scortaminima.HeaderText = "Scorta Minima"
        Me.scortaminima.Name = "scortaminima"
        Me.scortaminima.Width = 91
        '
        'scortamassima
        '
        Me.scortamassima.HeaderText = "Scorta Massima"
        Me.scortamassima.Name = "scortamassima"
        Me.scortamassima.Width = 98
        '
        'lottoriordino
        '
        Me.lottoriordino.HeaderText = "Lotto Riordino"
        Me.lottoriordino.Name = "lottoriordino"
        Me.lottoriordino.Width = 90
        '
        'prezzovendita
        '
        Me.prezzovendita.HeaderText = "Prezzo di Vendita"
        Me.prezzovendita.Name = "prezzovendita"
        Me.prezzovendita.Width = 105
        '
        'prezzoacquisto
        '
        Me.prezzoacquisto.HeaderText = "Prezzo di Acquisto"
        Me.prezzoacquisto.Name = "prezzoacquisto"
        Me.prezzoacquisto.Width = 109
        '
        'Articoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 398)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Articoli"
        Me.Text = "Articoli"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelClasseArticolo As System.Windows.Forms.Label
    Friend WithEvents LabelArticoloAlias As System.Windows.Forms.Label
    Friend WithEvents LabelContropartita As System.Windows.Forms.Label
    Friend WithEvents LabelClasseMerceologica As System.Windows.Forms.Label
    Friend WithEvents LabelScorporo As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceIva As System.Windows.Forms.Label
    Friend WithEvents LabelDenominazione As System.Windows.Forms.Label
    Friend WithEvents LabelArticolo As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents unitamisura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coefficientequantita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coefficienteprezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents scortaminima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents scortamassima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lottoriordino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzovendita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzoacquisto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
