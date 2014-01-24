<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategorieClienti
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelCodiceCategoria = New System.Windows.Forms.Label()
        Me.LabelDenominazione = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelDenominazione)
        Me.GroupBox1.Controls.Add(Me.LabelCodiceCategoria)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(318, 20)
        Me.TextBox2.TabIndex = 1
        '
        'LabelCodiceCategoria
        '
        Me.LabelCodiceCategoria.AutoSize = True
        Me.LabelCodiceCategoria.Location = New System.Drawing.Point(7, 20)
        Me.LabelCodiceCategoria.Name = "LabelCodiceCategoria"
        Me.LabelCodiceCategoria.Size = New System.Drawing.Size(88, 13)
        Me.LabelCodiceCategoria.TabIndex = 2
        Me.LabelCodiceCategoria.Text = "Codice Categoria"
        '
        'LabelDenominazione
        '
        Me.LabelDenominazione.AutoSize = True
        Me.LabelDenominazione.Location = New System.Drawing.Point(125, 20)
        Me.LabelDenominazione.Name = "LabelDenominazione"
        Me.LabelDenominazione.Size = New System.Drawing.Size(80, 13)
        Me.LabelDenominazione.TabIndex = 3
        Me.LabelDenominazione.Text = "Denominazione"
        '
        'CategorieClienti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 151)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CategorieClienti"
        Me.Text = "Categorie di Clienti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDenominazione As System.Windows.Forms.Label
    Friend WithEvents LabelCodiceCategoria As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
