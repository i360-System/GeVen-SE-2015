<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioniAnnuali
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
        Me.esercizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datainizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datatermine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.azienda, Me.esercizio, Me.datainizio, Me.datatermine, Me.descrizione})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(871, 74)
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
        Me.esercizio.Width = 74
        '
        'datainizio
        '
        Me.datainizio.HeaderText = "Data Inizio"
        Me.datainizio.Name = "datainizio"
        Me.datainizio.Width = 82
        '
        'datatermine
        '
        Me.datatermine.HeaderText = "Data Termine"
        Me.datatermine.Name = "datatermine"
        Me.datatermine.Width = 96
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "Descrizione"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.Width = 87
        '
        'GestioniAnnuali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 148)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GestioniAnnuali"
        Me.Text = "Gestioni  Annuali - Esercizi Contabili"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents azienda As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents esercizio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datainizio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datatermine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
