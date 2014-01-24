<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioValuta
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
        Me.sigladivisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cambioeuro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sigladivisa, Me.data, Me.cambio, Me.cambioeuro})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(488, 88)
        Me.DataGridView1.TabIndex = 0
        '
        'sigladivisa
        '
        Me.sigladivisa.HeaderText = "Sigla Divisa"
        Me.sigladivisa.Name = "sigladivisa"
        Me.sigladivisa.Width = 87
        '
        'data
        '
        Me.data.HeaderText = "Data"
        Me.data.Name = "data"
        Me.data.Width = 55
        '
        'cambio
        '
        Me.cambio.HeaderText = "Cambio"
        Me.cambio.Name = "cambio"
        Me.cambio.Width = 67
        '
        'cambioeuro
        '
        Me.cambioeuro.HeaderText = "Cambio Euro"
        Me.cambioeuro.Name = "cambioeuro"
        Me.cambioeuro.Width = 92
        '
        'CambioValuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 158)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CambioValuta"
        Me.Text = "Cambio Valuta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents sigladivisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cambioeuro As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
