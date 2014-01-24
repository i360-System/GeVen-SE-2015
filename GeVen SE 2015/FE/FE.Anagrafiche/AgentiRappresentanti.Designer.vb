<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgentiRappresentanti
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelAnagrafica = New System.Windows.Forms.Label()
        Me.LabelpercentualeProvvigioni = New System.Windows.Forms.Label()
        Me.categoriamerceologica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentualeprovvigioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelpercentualeProvvigioni)
        Me.GroupBox1.Controls.Add(Me.LabelAnagrafica)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(244, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.categoriamerceologica, Me.percentualeprovvigioni})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(337, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'LabelAnagrafica
        '
        Me.LabelAnagrafica.AutoSize = True
        Me.LabelAnagrafica.Location = New System.Drawing.Point(7, 20)
        Me.LabelAnagrafica.Name = "LabelAnagrafica"
        Me.LabelAnagrafica.Size = New System.Drawing.Size(58, 13)
        Me.LabelAnagrafica.TabIndex = 3
        Me.LabelAnagrafica.Text = "Anagrafica"
        '
        'LabelpercentualeProvvigioni
        '
        Me.LabelpercentualeProvvigioni.AutoSize = True
        Me.LabelpercentualeProvvigioni.Location = New System.Drawing.Point(241, 25)
        Me.LabelpercentualeProvvigioni.Name = "LabelpercentualeProvvigioni"
        Me.LabelpercentualeProvvigioni.Size = New System.Drawing.Size(70, 13)
        Me.LabelpercentualeProvvigioni.TabIndex = 4
        Me.LabelpercentualeProvvigioni.Text = "% Provvigioni"
        '
        'categoriamerceologica
        '
        Me.categoriamerceologica.HeaderText = "Categoria Merceologica"
        Me.categoriamerceologica.Name = "categoriamerceologica"
        '
        'percentualeprovvigioni
        '
        Me.percentualeprovvigioni.HeaderText = "% Provvigioni"
        Me.percentualeprovvigioni.Name = "percentualeprovvigioni"
        '
        'AgentiRappresentanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 298)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgentiRappresentanti"
        Me.Text = "Agenti & Rappresentanti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelpercentualeProvvigioni As System.Windows.Forms.Label
    Friend WithEvents LabelAnagrafica As System.Windows.Forms.Label
    Friend WithEvents categoriamerceologica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percentualeprovvigioni As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
