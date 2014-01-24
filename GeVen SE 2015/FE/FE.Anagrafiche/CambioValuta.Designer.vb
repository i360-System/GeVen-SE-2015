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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelSiglaDivisa = New System.Windows.Forms.Label()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.LabelCambio = New System.Windows.Forms.Label()
        Me.LabelRapportoEuro = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelRapportoEuro)
        Me.GroupBox1.Controls.Add(Me.LabelCambio)
        Me.GroupBox1.Controls.Add(Me.LabelData)
        Me.GroupBox1.Controls.Add(Me.LabelSiglaDivisa)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(325, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(219, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 2
        '
        'LabelSiglaDivisa
        '
        Me.LabelSiglaDivisa.AutoSize = True
        Me.LabelSiglaDivisa.Location = New System.Drawing.Point(7, 22)
        Me.LabelSiglaDivisa.Name = "LabelSiglaDivisa"
        Me.LabelSiglaDivisa.Size = New System.Drawing.Size(62, 13)
        Me.LabelSiglaDivisa.TabIndex = 4
        Me.LabelSiglaDivisa.Text = "Sigla Divisa"
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(110, 22)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 5
        Me.LabelData.Text = "Data"
        '
        'LabelCambio
        '
        Me.LabelCambio.AutoSize = True
        Me.LabelCambio.Location = New System.Drawing.Point(216, 22)
        Me.LabelCambio.Name = "LabelCambio"
        Me.LabelCambio.Size = New System.Drawing.Size(42, 13)
        Me.LabelCambio.TabIndex = 6
        Me.LabelCambio.Text = "Cambio"
        '
        'LabelRapportoEuro
        '
        Me.LabelRapportoEuro.AutoSize = True
        Me.LabelRapportoEuro.Location = New System.Drawing.Point(322, 22)
        Me.LabelRapportoEuro.Name = "LabelRapportoEuro"
        Me.LabelRapportoEuro.Size = New System.Drawing.Size(76, 13)
        Me.LabelRapportoEuro.TabIndex = 7
        Me.LabelRapportoEuro.Text = "Rapporto Euro"
        '
        'CambioValuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 139)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CambioValuta"
        Me.Text = "Cambio Valuta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelRapportoEuro As System.Windows.Forms.Label
    Friend WithEvents LabelCambio As System.Windows.Forms.Label
    Friend WithEvents LabelData As System.Windows.Forms.Label
    Friend WithEvents LabelSiglaDivisa As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
