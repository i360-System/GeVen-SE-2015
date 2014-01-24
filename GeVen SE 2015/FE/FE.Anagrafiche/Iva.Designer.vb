<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iva
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
        Me.siglaiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aliquotaiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detraibilitaiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.siglaiva, Me.descrizione, Me.aliquotaiva, Me.tipoiva, Me.detraibilitaiva})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(855, 375)
        Me.DataGridView1.TabIndex = 0
        '
        'siglaiva
        '
        Me.siglaiva.HeaderText = "Sigla Iva"
        Me.siglaiva.Name = "siglaiva"
        Me.siglaiva.Width = 73
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "Descrizione"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.Width = 87
        '
        'aliquotaiva
        '
        Me.aliquotaiva.HeaderText = "Aliquota Iva"
        Me.aliquotaiva.Name = "aliquotaiva"
        Me.aliquotaiva.Width = 88
        '
        'tipoiva
        '
        Me.tipoiva.HeaderText = "Tipo Iva"
        Me.tipoiva.Name = "tipoiva"
        Me.tipoiva.Width = 71
        '
        'detraibilitaiva
        '
        Me.detraibilitaiva.HeaderText = "Detraibilità Iva"
        Me.detraibilitaiva.Name = "detraibilitaiva"
        Me.detraibilitaiva.Width = 99
        '
        'Iva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 460)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Iva"
        Me.Text = "Parametri Iva"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents siglaiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aliquotaiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detraibilitaiva As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
