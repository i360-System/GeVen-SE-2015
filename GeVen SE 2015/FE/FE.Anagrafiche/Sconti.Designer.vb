<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sconti
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
        Me.anagrafica = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.classemerceologica = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.sconto1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sconto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sconto3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anagrafica, Me.classemerceologica, Me.sconto1, Me.sconto2, Me.sconto3})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(857, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'anagrafica
        '
        Me.anagrafica.HeaderText = "Anagrafica"
        Me.anagrafica.Name = "anagrafica"
        Me.anagrafica.Width = 64
        '
        'classemerceologica
        '
        Me.classemerceologica.HeaderText = "Classe Merceologica"
        Me.classemerceologica.Name = "classemerceologica"
        '
        'sconto1
        '
        Me.sconto1.HeaderText = "Sconto 1"
        Me.sconto1.Name = "sconto1"
        Me.sconto1.Width = 69
        '
        'sconto2
        '
        Me.sconto2.HeaderText = "Sconto 2"
        Me.sconto2.Name = "sconto2"
        Me.sconto2.Width = 69
        '
        'sconto3
        '
        Me.sconto3.HeaderText = "Sconto 3"
        Me.sconto3.Name = "sconto3"
        Me.sconto3.Width = 69
        '
        'Sconti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Sconti"
        Me.Text = "Sconti"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents anagrafica As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents classemerceologica As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents sconto1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sconto2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sconto3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
