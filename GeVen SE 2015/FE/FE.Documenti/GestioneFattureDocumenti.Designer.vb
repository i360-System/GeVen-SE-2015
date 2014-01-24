<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioneFattureDocumenti
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPrimoNumeroDocumento = New System.Windows.Forms.Label()
        Me.LabelSiglaOperatore = New System.Windows.Forms.Label()
        Me.LabelDataFatturazione = New System.Windows.Forms.Label()
        Me.LabelaData = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelUltimoCliente = New System.Windows.Forms.Label()
        Me.LabelPrimoCliente = New System.Windows.Forms.Label()
        Me.LabelEsercizio = New System.Windows.Forms.Label()
        Me.LabelAzienda = New System.Windows.Forms.Label()
        Me.LabelTipoDocumentoEstrarre = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelPrimoNumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.LabelSiglaOperatore)
        Me.GroupBox1.Controls.Add(Me.LabelDataFatturazione)
        Me.GroupBox1.Controls.Add(Me.LabelaData)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelUltimoCliente)
        Me.GroupBox1.Controls.Add(Me.LabelPrimoCliente)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizio)
        Me.GroupBox1.Controls.Add(Me.LabelAzienda)
        Me.GroupBox1.Controls.Add(Me.LabelTipoDocumentoEstrarre)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 210)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(664, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Esegui"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPrimoNumeroDocumento
        '
        Me.LabelPrimoNumeroDocumento.AutoSize = True
        Me.LabelPrimoNumeroDocumento.Location = New System.Drawing.Point(510, 167)
        Me.LabelPrimoNumeroDocumento.Name = "LabelPrimoNumeroDocumento"
        Me.LabelPrimoNumeroDocumento.Size = New System.Drawing.Size(142, 13)
        Me.LabelPrimoNumeroDocumento.TabIndex = 19
        Me.LabelPrimoNumeroDocumento.Text = "Primo Numero di Documento"
        '
        'LabelSiglaOperatore
        '
        Me.LabelSiglaOperatore.AutoSize = True
        Me.LabelSiglaOperatore.Location = New System.Drawing.Point(383, 167)
        Me.LabelSiglaOperatore.Name = "LabelSiglaOperatore"
        Me.LabelSiglaOperatore.Size = New System.Drawing.Size(80, 13)
        Me.LabelSiglaOperatore.TabIndex = 18
        Me.LabelSiglaOperatore.Text = "Sigla Operatore"
        '
        'LabelDataFatturazione
        '
        Me.LabelDataFatturazione.AutoSize = True
        Me.LabelDataFatturazione.Location = New System.Drawing.Point(256, 167)
        Me.LabelDataFatturazione.Name = "LabelDataFatturazione"
        Me.LabelDataFatturazione.Size = New System.Drawing.Size(91, 13)
        Me.LabelDataFatturazione.TabIndex = 17
        Me.LabelDataFatturazione.Text = "Data Fatturazione"
        '
        'LabelaData
        '
        Me.LabelaData.AutoSize = True
        Me.LabelaData.Location = New System.Drawing.Point(129, 167)
        Me.LabelaData.Name = "LabelaData"
        Me.LabelaData.Size = New System.Drawing.Size(39, 13)
        Me.LabelaData.TabIndex = 16
        Me.LabelaData.Text = "a Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "da Data"
        '
        'LabelUltimoCliente
        '
        Me.LabelUltimoCliente.AutoSize = True
        Me.LabelUltimoCliente.Location = New System.Drawing.Point(6, 129)
        Me.LabelUltimoCliente.Name = "LabelUltimoCliente"
        Me.LabelUltimoCliente.Size = New System.Drawing.Size(71, 13)
        Me.LabelUltimoCliente.TabIndex = 14
        Me.LabelUltimoCliente.Text = "Ultimo Cliente"
        '
        'LabelPrimoCliente
        '
        Me.LabelPrimoCliente.AutoSize = True
        Me.LabelPrimoCliente.Location = New System.Drawing.Point(6, 102)
        Me.LabelPrimoCliente.Name = "LabelPrimoCliente"
        Me.LabelPrimoCliente.Size = New System.Drawing.Size(68, 13)
        Me.LabelPrimoCliente.TabIndex = 13
        Me.LabelPrimoCliente.Text = "Primo Cliente"
        '
        'LabelEsercizio
        '
        Me.LabelEsercizio.AutoSize = True
        Me.LabelEsercizio.Location = New System.Drawing.Point(6, 75)
        Me.LabelEsercizio.Name = "LabelEsercizio"
        Me.LabelEsercizio.Size = New System.Drawing.Size(49, 13)
        Me.LabelEsercizio.TabIndex = 12
        Me.LabelEsercizio.Text = "Esercizio"
        '
        'LabelAzienda
        '
        Me.LabelAzienda.AutoSize = True
        Me.LabelAzienda.Location = New System.Drawing.Point(6, 48)
        Me.LabelAzienda.Name = "LabelAzienda"
        Me.LabelAzienda.Size = New System.Drawing.Size(45, 13)
        Me.LabelAzienda.TabIndex = 11
        Me.LabelAzienda.Text = "Azienda"
        '
        'LabelTipoDocumentoEstrarre
        '
        Me.LabelTipoDocumentoEstrarre.AutoSize = True
        Me.LabelTipoDocumentoEstrarre.Location = New System.Drawing.Point(6, 21)
        Me.LabelTipoDocumentoEstrarre.Name = "LabelTipoDocumentoEstrarre"
        Me.LabelTipoDocumentoEstrarre.Size = New System.Drawing.Size(140, 13)
        Me.LabelTipoDocumentoEstrarre.TabIndex = 10
        Me.LabelTipoDocumentoEstrarre.Text = "Tipo Documento da Estrarre"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(513, 183)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(386, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(259, 183)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 183)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(155, 126)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(155, 99)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox3.TabIndex = 3
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(155, 72)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox4.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(155, 45)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(155, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GestioneFattureDocumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 270)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GestioneFattureDocumenti"
        Me.Text = "Generazione Fatture da Documenti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelPrimoNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents LabelSiglaOperatore As System.Windows.Forms.Label
    Friend WithEvents LabelDataFatturazione As System.Windows.Forms.Label
    Friend WithEvents LabelaData As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelUltimoCliente As System.Windows.Forms.Label
    Friend WithEvents LabelPrimoCliente As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizio As System.Windows.Forms.Label
    Friend WithEvents LabelAzienda As System.Windows.Forms.Label
    Friend WithEvents LabelTipoDocumentoEstrarre As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
