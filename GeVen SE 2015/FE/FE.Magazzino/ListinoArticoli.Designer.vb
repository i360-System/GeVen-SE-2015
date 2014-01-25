<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListinoArticoli
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.azienda = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.esercizio = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.articolo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.settore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitamisura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimadata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.azienda, Me.esercizio, Me.articolo, Me.settore, Me.unitamisura, Me.prezzo, Me.ultimadata})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(874, 329)
        Me.DataGridView1.TabIndex = 0
        '
        'azienda
        '
        Me.azienda.HeaderText = "Azienda"
        Me.azienda.Name = "azienda"
        Me.azienda.Width = 51
        '
        'esercizio
        '
        Me.esercizio.HeaderText = "Esercizio"
        Me.esercizio.Name = "esercizio"
        Me.esercizio.Width = 55
        '
        'articolo
        '
        Me.articolo.HeaderText = "Articolo"
        Me.articolo.Name = "articolo"
        Me.articolo.Width = 48
        '
        'settore
        '
        Me.settore.HeaderText = "Settore"
        Me.settore.Name = "settore"
        Me.settore.Width = 66
        '
        'unitamisura
        '
        Me.unitamisura.HeaderText = "Unità di Misura"
        Me.unitamisura.Name = "unitamisura"
        Me.unitamisura.Width = 102
        '
        'prezzo
        '
        Me.prezzo.HeaderText = "Prezzo"
        Me.prezzo.Name = "prezzo"
        Me.prezzo.Width = 64
        '
        'ultimadata
        '
        Me.ultimadata.HeaderText = "Ultima Data"
        Me.ultimadata.Name = "ultimadata"
        Me.ultimadata.Width = 87
        '
        'ListinoArticoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 402)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ListinoArticoli"
        Me.Text = "Listino degli Articoli"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents azienda As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents esercizio As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents articolo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents settore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitamisura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultimadata As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
