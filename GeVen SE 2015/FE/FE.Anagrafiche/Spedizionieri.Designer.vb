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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelAnagrafica = New System.Windows.Forms.Label()
        Me.LabelCorriere = New System.Windows.Forms.Label()
        Me.LabelLocalita = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelLocalita)
        Me.GroupBox1.Controls.Add(Me.LabelCorriere)
        Me.GroupBox1.Controls.Add(Me.LabelAnagrafica)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(270, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'LabelAnagrafica
        '
        Me.LabelAnagrafica.AutoSize = True
        Me.LabelAnagrafica.Location = New System.Drawing.Point(7, 26)
        Me.LabelAnagrafica.Name = "LabelAnagrafica"
        Me.LabelAnagrafica.Size = New System.Drawing.Size(58, 13)
        Me.LabelAnagrafica.TabIndex = 3
        Me.LabelAnagrafica.Text = "Anagrafica"
        '
        'LabelCorriere
        '
        Me.LabelCorriere.AutoSize = True
        Me.LabelCorriere.Location = New System.Drawing.Point(147, 26)
        Me.LabelCorriere.Name = "LabelCorriere"
        Me.LabelCorriere.Size = New System.Drawing.Size(43, 13)
        Me.LabelCorriere.TabIndex = 4
        Me.LabelCorriere.Text = "Corriere"
        '
        'LabelLocalita
        '
        Me.LabelLocalita.AutoSize = True
        Me.LabelLocalita.Location = New System.Drawing.Point(267, 29)
        Me.LabelLocalita.Name = "LabelLocalita"
        Me.LabelLocalita.Size = New System.Drawing.Size(44, 13)
        Me.LabelLocalita.TabIndex = 5
        Me.LabelLocalita.Text = "Località"
        '
        'Spedizionieri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 162)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Spedizionieri"
        Me.Text = "Spedizionieri & Corrieri"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelLocalita As System.Windows.Forms.Label
    Friend WithEvents LabelCorriere As System.Windows.Forms.Label
    Friend WithEvents LabelAnagrafica As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
