﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magazzini
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
        Me.magazzino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.denominazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.azienda, Me.magazzino, Me.denominazione})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(587, 174)
        Me.DataGridView1.TabIndex = 0
        '
        'azienda
        '
        Me.azienda.HeaderText = "Azienda"
        Me.azienda.Name = "azienda"
        Me.azienda.Width = 51
        '
        'magazzino
        '
        Me.magazzino.HeaderText = "Magazzino"
        Me.magazzino.Name = "magazzino"
        Me.magazzino.Width = 83
        '
        'denominazione
        '
        Me.denominazione.HeaderText = "Denominazione"
        Me.denominazione.Name = "denominazione"
        Me.denominazione.Width = 105
        '
        'Magazzini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 251)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Magazzini"
        Me.Text = "Magazzini"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents azienda As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents magazzino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents denominazione As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
