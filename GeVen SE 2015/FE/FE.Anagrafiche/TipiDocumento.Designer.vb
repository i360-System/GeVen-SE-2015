<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipiDocumento
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
        Me.tipodocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.testdocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.causalemagazzino = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipodocumento, Me.descrizione, Me.testdocumento, Me.causalemagazzino})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(792, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'tipodocumento
        '
        Me.tipodocumento.HeaderText = "Tipo Documento"
        Me.tipodocumento.Name = "tipodocumento"
        Me.tipodocumento.Width = 102
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "Descrizione"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.Width = 87
        '
        'testdocumento
        '
        Me.testdocumento.HeaderText = "Test Documento"
        Me.testdocumento.Name = "testdocumento"
        Me.testdocumento.Width = 102
        '
        'causalemagazzino
        '
        Me.causalemagazzino.HeaderText = "Causale Magazzino"
        Me.causalemagazzino.Name = "causalemagazzino"
        Me.causalemagazzino.Width = 95
        '
        'TipiDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TipiDocumento"
        Me.Text = "Tipi di Documento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tipodocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents testdocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents causalemagazzino As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
