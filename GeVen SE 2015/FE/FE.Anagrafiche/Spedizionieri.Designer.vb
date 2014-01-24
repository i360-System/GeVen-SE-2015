<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spedizionieri
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
        Me.corriere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anagrafica, Me.corriere, Me.localita})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 99)
        Me.DataGridView1.TabIndex = 0
        '
        'anagrafica
        '
        Me.anagrafica.HeaderText = "Anagrafica"
        Me.anagrafica.Name = "anagrafica"
        '
        'corriere
        '
        Me.corriere.HeaderText = "Corriere"
        Me.corriere.Name = "corriere"
        '
        'localita
        '
        Me.localita.HeaderText = "Località"
        Me.localita.Name = "localita"
        '
        'Spedizionieri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 162)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Spedizionieri"
        Me.Text = "Spedizionieri & Corrieri"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents anagrafica As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents corriere As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localita As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
