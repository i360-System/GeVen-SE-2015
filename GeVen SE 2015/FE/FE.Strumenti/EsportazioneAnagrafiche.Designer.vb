<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EsportazioneAnagrafiche
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelOrigine = New System.Windows.Forms.Label()
        Me.LabelDestinazione = New System.Windows.Forms.Label()
        Me.LabeldaAnagrafica = New System.Windows.Forms.Label()
        Me.LabeladAnagrafica = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.LabeladAnagrafica)
        Me.GroupBox1.Controls.Add(Me.LabeldaAnagrafica)
        Me.GroupBox1.Controls.Add(Me.LabelDestinazione)
        Me.GroupBox1.Controls.Add(Me.LabelOrigine)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(219, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(426, 38)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'LabelOrigine
        '
        Me.LabelOrigine.AutoSize = True
        Me.LabelOrigine.Location = New System.Drawing.Point(7, 20)
        Me.LabelOrigine.Name = "LabelOrigine"
        Me.LabelOrigine.Size = New System.Drawing.Size(40, 13)
        Me.LabelOrigine.TabIndex = 4
        Me.LabelOrigine.Text = "Origine"
        '
        'LabelDestinazione
        '
        Me.LabelDestinazione.AutoSize = True
        Me.LabelDestinazione.Location = New System.Drawing.Point(110, 20)
        Me.LabelDestinazione.Name = "LabelDestinazione"
        Me.LabelDestinazione.Size = New System.Drawing.Size(68, 13)
        Me.LabelDestinazione.TabIndex = 5
        Me.LabelDestinazione.Text = "Destinazione"
        '
        'LabeldaAnagrafica
        '
        Me.LabeldaAnagrafica.AutoSize = True
        Me.LabeldaAnagrafica.Location = New System.Drawing.Point(216, 20)
        Me.LabeldaAnagrafica.Name = "LabeldaAnagrafica"
        Me.LabeldaAnagrafica.Size = New System.Drawing.Size(73, 13)
        Me.LabeldaAnagrafica.TabIndex = 6
        Me.LabeldaAnagrafica.Text = "da Anagrafica"
        '
        'LabeladAnagrafica
        '
        Me.LabeladAnagrafica.AutoSize = True
        Me.LabeladAnagrafica.Location = New System.Drawing.Point(423, 20)
        Me.LabeladAnagrafica.Name = "LabeladAnagrafica"
        Me.LabeladAnagrafica.Size = New System.Drawing.Size(73, 13)
        Me.LabeladAnagrafica.TabIndex = 7
        Me.LabeladAnagrafica.Text = "ad Anagrafica"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(685, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Esegui"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 81)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(753, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'EsportazioneAnagrafiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 130)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EsportazioneAnagrafiche"
        Me.Text = "Esportazione delle Anagrafiche"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabeladAnagrafica As System.Windows.Forms.Label
    Friend WithEvents LabeldaAnagrafica As System.Windows.Forms.Label
    Friend WithEvents LabelDestinazione As System.Windows.Forms.Label
    Friend WithEvents LabelOrigine As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
