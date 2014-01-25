<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerazioneInventario
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
        Me.LabelDataInventario = New System.Windows.Forms.Label()
        Me.LabelCausale2 = New System.Windows.Forms.Label()
        Me.LabelCausale1 = New System.Windows.Forms.Label()
        Me.LabelEsercizioAprire = New System.Windows.Forms.Label()
        Me.LabelEsercizioChiudere = New System.Windows.Forms.Label()
        Me.LabelAzienda = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelDataInventario)
        Me.GroupBox1.Controls.Add(Me.LabelCausale2)
        Me.GroupBox1.Controls.Add(Me.LabelCausale1)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizioAprire)
        Me.GroupBox1.Controls.Add(Me.LabelEsercizioChiudere)
        Me.GroupBox1.Controls.Add(Me.LabelAzienda)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelDataInventario
        '
        Me.LabelDataInventario.AutoSize = True
        Me.LabelDataInventario.Location = New System.Drawing.Point(474, 63)
        Me.LabelDataInventario.Name = "LabelDataInventario"
        Me.LabelDataInventario.Size = New System.Drawing.Size(80, 13)
        Me.LabelDataInventario.TabIndex = 13
        Me.LabelDataInventario.Text = "Data Inventario"
        '
        'LabelCausale2
        '
        Me.LabelCausale2.AutoSize = True
        Me.LabelCausale2.Location = New System.Drawing.Point(251, 61)
        Me.LabelCausale2.Name = "LabelCausale2"
        Me.LabelCausale2.Size = New System.Drawing.Size(54, 13)
        Me.LabelCausale2.TabIndex = 12
        Me.LabelCausale2.Text = "Causale 2"
        '
        'LabelCausale1
        '
        Me.LabelCausale1.AutoSize = True
        Me.LabelCausale1.Location = New System.Drawing.Point(4, 62)
        Me.LabelCausale1.Name = "LabelCausale1"
        Me.LabelCausale1.Size = New System.Drawing.Size(54, 13)
        Me.LabelCausale1.TabIndex = 11
        Me.LabelCausale1.Text = "Causale 1"
        '
        'LabelEsercizioAprire
        '
        Me.LabelEsercizioAprire.AutoSize = True
        Me.LabelEsercizioAprire.Location = New System.Drawing.Point(251, 21)
        Me.LabelEsercizioAprire.Name = "LabelEsercizioAprire"
        Me.LabelEsercizioAprire.Size = New System.Drawing.Size(94, 13)
        Me.LabelEsercizioAprire.TabIndex = 10
        Me.LabelEsercizioAprire.Text = "Esercizio da Aprire"
        '
        'LabelEsercizioChiudere
        '
        Me.LabelEsercizioChiudere.AutoSize = True
        Me.LabelEsercizioChiudere.Location = New System.Drawing.Point(474, 21)
        Me.LabelEsercizioChiudere.Name = "LabelEsercizioChiudere"
        Me.LabelEsercizioChiudere.Size = New System.Drawing.Size(109, 13)
        Me.LabelEsercizioChiudere.TabIndex = 9
        Me.LabelEsercizioChiudere.Text = "Esercizio da Chiudere"
        '
        'LabelAzienda
        '
        Me.LabelAzienda.AutoSize = True
        Me.LabelAzienda.Location = New System.Drawing.Point(6, 21)
        Me.LabelAzienda.Name = "LabelAzienda"
        Me.LabelAzienda.Size = New System.Drawing.Size(45, 13)
        Me.LabelAzienda.TabIndex = 8
        Me.LabelAzienda.Text = "Azienda"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 138)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(692, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(604, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Esegui"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(477, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(254, 77)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(217, 21)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(7, 78)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(241, 21)
        Me.ComboBox4.TabIndex = 3
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(477, 37)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(217, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(254, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(217, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GenerazioneInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GenerazioneInventario"
        Me.Text = "Generazione dell'Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDataInventario As System.Windows.Forms.Label
    Friend WithEvents LabelCausale2 As System.Windows.Forms.Label
    Friend WithEvents LabelCausale1 As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizioAprire As System.Windows.Forms.Label
    Friend WithEvents LabelEsercizioChiudere As System.Windows.Forms.Label
    Friend WithEvents LabelAzienda As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
