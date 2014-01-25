<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EsportazioneFatture
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelOrigine = New System.Windows.Forms.Label()
        Me.LabelDestinazione = New System.Windows.Forms.Label()
        Me.LabelEsercizio = New System.Windows.Forms.Label()
        Me.LabeldaFattura = New System.Windows.Forms.Label()
        Me.LabelaFattura = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelaFattura)
        Me.GroupBox1.Controls.Add(Me.LabeldaFattura)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizio)
        Me.GroupBox1.Controls.Add(Me.LabelDestinazione)
        Me.GroupBox1.Controls.Add(Me.LabelOrigine)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 36)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(220, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(453, 34)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(347, 34)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'LabelOrigine
        '
        Me.LabelOrigine.AutoSize = True
        Me.LabelOrigine.Location = New System.Drawing.Point(6, 20)
        Me.LabelOrigine.Name = "LabelOrigine"
        Me.LabelOrigine.Size = New System.Drawing.Size(40, 13)
        Me.LabelOrigine.TabIndex = 5
        Me.LabelOrigine.Text = "Origine"
        '
        'LabelDestinazione
        '
        Me.LabelDestinazione.AutoSize = True
        Me.LabelDestinazione.Location = New System.Drawing.Point(110, 20)
        Me.LabelDestinazione.Name = "LabelDestinazione"
        Me.LabelDestinazione.Size = New System.Drawing.Size(68, 13)
        Me.LabelDestinazione.TabIndex = 6
        Me.LabelDestinazione.Text = "Destinazione"
        '
        'LabelEsercizio
        '
        Me.LabelEsercizio.AutoSize = True
        Me.LabelEsercizio.Location = New System.Drawing.Point(217, 20)
        Me.LabelEsercizio.Name = "LabelEsercizio"
        Me.LabelEsercizio.Size = New System.Drawing.Size(49, 13)
        Me.LabelEsercizio.TabIndex = 7
        Me.LabelEsercizio.Text = "Esercizio"
        '
        'LabeldaFattura
        '
        Me.LabeldaFattura.AutoSize = True
        Me.LabeldaFattura.Location = New System.Drawing.Point(344, 20)
        Me.LabeldaFattura.Name = "LabeldaFattura"
        Me.LabeldaFattura.Size = New System.Drawing.Size(55, 13)
        Me.LabeldaFattura.TabIndex = 8
        Me.LabeldaFattura.Text = "da Fattura"
        '
        'LabelaFattura
        '
        Me.LabelaFattura.AutoSize = True
        Me.LabelaFattura.Location = New System.Drawing.Point(450, 20)
        Me.LabelaFattura.Name = "LabelaFattura"
        Me.LabelaFattura.Size = New System.Drawing.Size(49, 13)
        Me.LabelaFattura.TabIndex = 9
        Me.LabelaFattura.Text = "a Fattura"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(559, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Esegui"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(711, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'EsportazioneFatture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 134)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EsportazioneFatture"
        Me.Text = "EsportazioneFatture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelaFattura As System.Windows.Forms.Label
    Friend WithEvents LabeldaFattura As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizio As System.Windows.Forms.Label
    Friend WithEvents LabelDestinazione As System.Windows.Forms.Label
    Friend WithEvents LabelOrigine As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
