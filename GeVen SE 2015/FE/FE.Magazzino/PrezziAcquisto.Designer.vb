﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrezziAcquisto
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
        Me.unitamisura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anagraficafornitore = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.prezzoacquisto = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.azienda, Me.esercizio, Me.articolo, Me.unitamisura, Me.anagraficafornitore, Me.prezzoacquisto, Me.ultimadata})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(753, 278)
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
        'unitamisura
        '
        Me.unitamisura.HeaderText = "Unita di Misurà"
        Me.unitamisura.Name = "unitamisura"
        Me.unitamisura.Width = 102
        '
        'anagraficafornitore
        '
        Me.anagraficafornitore.HeaderText = "Anagrafica Fornitore"
        Me.anagraficafornitore.Name = "anagraficafornitore"
        Me.anagraficafornitore.Width = 97
        '
        'prezzoacquisto
        '
        Me.prezzoacquisto.HeaderText = "Prezzo di Acquisto"
        Me.prezzoacquisto.Name = "prezzoacquisto"
        Me.prezzoacquisto.Width = 109
        '
        'ultimadata
        '
        Me.ultimadata.HeaderText = "Ultima Data"
        Me.ultimadata.Name = "ultimadata"
        Me.ultimadata.Width = 80
        '
        'PrezziAcquisto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 348)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PrezziAcquisto"
        Me.Text = "Prezzi di Acquisto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents azienda As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents esercizio As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents articolo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents unitamisura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anagraficafornitore As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents prezzoacquisto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultimadata As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
