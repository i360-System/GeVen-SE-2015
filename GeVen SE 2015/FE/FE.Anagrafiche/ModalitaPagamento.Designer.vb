<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalitaPagamento
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeroScadenza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoScadenza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentoRata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiorniScadenza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiornoScadenza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeseEscluso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeseDifferimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiornoDifferimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 421)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroScadenza, Me.TipoPagamento, Me.TipoScadenza, Me.percentoRata, Me.GiorniScadenza, Me.GiornoScadenza, Me.MeseEscluso, Me.MeseDifferimento, Me.GiornoDifferimento})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(859, 321)
        Me.DataGridView1.TabIndex = 8
        '
        'NumeroScadenza
        '
        Me.NumeroScadenza.HeaderText = "Numero Scadenza"
        Me.NumeroScadenza.Name = "NumeroScadenza"
        Me.NumeroScadenza.Width = 90
        '
        'TipoPagamento
        '
        Me.TipoPagamento.HeaderText = "Tipo di Pagamento"
        Me.TipoPagamento.Name = "TipoPagamento"
        Me.TipoPagamento.Width = 90
        '
        'TipoScadenza
        '
        Me.TipoScadenza.HeaderText = "Tipo di Scadenza"
        Me.TipoScadenza.Name = "TipoScadenza"
        Me.TipoScadenza.Width = 90
        '
        'percentoRata
        '
        Me.percentoRata.HeaderText = "% Rata"
        Me.percentoRata.Name = "percentoRata"
        Me.percentoRata.Width = 90
        '
        'GiorniScadenza
        '
        Me.GiorniScadenza.HeaderText = "Giorni Scadenza"
        Me.GiorniScadenza.Name = "GiorniScadenza"
        Me.GiorniScadenza.Width = 90
        '
        'GiornoScadenza
        '
        Me.GiornoScadenza.HeaderText = "Giorno Scadenza"
        Me.GiornoScadenza.Name = "GiornoScadenza"
        Me.GiornoScadenza.Width = 90
        '
        'MeseEscluso
        '
        Me.MeseEscluso.HeaderText = "Mese Escluso"
        Me.MeseEscluso.Name = "MeseEscluso"
        Me.MeseEscluso.Width = 90
        '
        'MeseDifferimento
        '
        Me.MeseDifferimento.HeaderText = "Mese di Differimento"
        Me.MeseDifferimento.Name = "MeseDifferimento"
        Me.MeseDifferimento.Width = 90
        '
        'GiornoDifferimento
        '
        Me.GiornoDifferimento.HeaderText = "Giorno di Differimento"
        Me.GiornoDifferimento.Name = "GiornoDifferimento"
        Me.GiornoDifferimento.Width = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Iva su scadenza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "% di sconto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descrizione:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codice pagamento:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(528, 38)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(85, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(422, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(295, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ModalitaPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ModalitaPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modalita di Pagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroScadenza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoScadenza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentoRata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiorniScadenza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiornoScadenza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeseEscluso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeseDifferimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiornoDifferimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
