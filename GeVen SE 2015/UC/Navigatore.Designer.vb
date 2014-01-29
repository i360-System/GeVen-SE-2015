<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigatore
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Navigatore))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.inserisci = New System.Windows.Forms.ToolStripButton()
        Me.ricerca = New System.Windows.Forms.ToolStripButton()
        Me.cancella = New System.Windows.Forms.ToolStripButton()
        Me.cancellatutto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.indietro = New System.Windows.Forms.ToolStripButton()
        Me.avanti = New System.Windows.Forms.ToolStripButton()
        Me.primo = New System.Windows.Forms.ToolStripButton()
        Me.ultimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.annulla = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.conferma = New System.Windows.Forms.ToolStripButton()
        Me.esci = New System.Windows.Forms.ToolStripButton()
        Me.stampa = New System.Windows.Forms.ToolStripButton()
        Me.modifica = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inserisci, Me.ricerca, Me.modifica, Me.cancella, Me.cancellatutto, Me.ToolStripSeparator1, Me.indietro, Me.avanti, Me.primo, Me.ultimo, Me.ToolStripSeparator2, Me.annulla, Me.ToolStripSeparator3, Me.conferma, Me.esci, Me.stampa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(752, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'inserisci
        '
        Me.inserisci.Image = CType(resources.GetObject("inserisci.Image"), System.Drawing.Image)
        Me.inserisci.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.inserisci.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.inserisci.Name = "inserisci"
        Me.inserisci.Size = New System.Drawing.Size(53, 22)
        Me.inserisci.Text = "&Inserisci"
        Me.inserisci.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.inserisci.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ricerca
        '
        Me.ricerca.Image = CType(resources.GetObject("ricerca.Image"), System.Drawing.Image)
        Me.ricerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ricerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ricerca.Name = "ricerca"
        Me.ricerca.Size = New System.Drawing.Size(49, 22)
        Me.ricerca.Text = "&Ricerca"
        Me.ricerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ricerca.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'cancella
        '
        Me.cancella.Enabled = False
        Me.cancella.Image = CType(resources.GetObject("cancella.Image"), System.Drawing.Image)
        Me.cancella.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancella.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancella.Name = "cancella"
        Me.cancella.Size = New System.Drawing.Size(56, 22)
        Me.cancella.Text = "&Cancella"
        Me.cancella.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancella.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'cancellatutto
        '
        Me.cancellatutto.Enabled = False
        Me.cancellatutto.Image = CType(resources.GetObject("cancellatutto.Image"), System.Drawing.Image)
        Me.cancellatutto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancellatutto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancellatutto.Name = "cancellatutto"
        Me.cancellatutto.Size = New System.Drawing.Size(88, 22)
        Me.cancellatutto.Text = "Cancella &tutto "
        Me.cancellatutto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancellatutto.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'indietro
        '
        Me.indietro.Enabled = False
        Me.indietro.Image = CType(resources.GetObject("indietro.Image"), System.Drawing.Image)
        Me.indietro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.indietro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.indietro.Name = "indietro"
        Me.indietro.Size = New System.Drawing.Size(52, 22)
        Me.indietro.Text = "In&dietro"
        Me.indietro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.indietro.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'avanti
        '
        Me.avanti.Enabled = False
        Me.avanti.Image = CType(resources.GetObject("avanti.Image"), System.Drawing.Image)
        Me.avanti.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.avanti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.avanti.Name = "avanti"
        Me.avanti.Size = New System.Drawing.Size(45, 22)
        Me.avanti.Text = "&Avanti"
        Me.avanti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.avanti.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'primo
        '
        Me.primo.Enabled = False
        Me.primo.Image = CType(resources.GetObject("primo.Image"), System.Drawing.Image)
        Me.primo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.primo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.primo.Name = "primo"
        Me.primo.Size = New System.Drawing.Size(43, 22)
        Me.primo.Text = "&Primo"
        Me.primo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.primo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ultimo
        '
        Me.ultimo.Enabled = False
        Me.ultimo.Image = CType(resources.GetObject("ultimo.Image"), System.Drawing.Image)
        Me.ultimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ultimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ultimo.Name = "ultimo"
        Me.ultimo.Size = New System.Drawing.Size(47, 22)
        Me.ultimo.Text = "&Ultimo"
        Me.ultimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ultimo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'annulla
        '
        Me.annulla.Enabled = False
        Me.annulla.Image = CType(resources.GetObject("annulla.Image"), System.Drawing.Image)
        Me.annulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.annulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.annulla.Name = "annulla"
        Me.annulla.Size = New System.Drawing.Size(52, 22)
        Me.annulla.Text = "A&nnulla"
        Me.annulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.annulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'conferma
        '
        Me.conferma.Enabled = False
        Me.conferma.Image = CType(resources.GetObject("conferma.Image"), System.Drawing.Image)
        Me.conferma.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.conferma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.conferma.Name = "conferma"
        Me.conferma.Size = New System.Drawing.Size(64, 22)
        Me.conferma.Text = "C&onferma"
        Me.conferma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.conferma.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'esci
        '
        Me.esci.Image = CType(resources.GetObject("esci.Image"), System.Drawing.Image)
        Me.esci.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.esci.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.esci.Name = "esci"
        Me.esci.Size = New System.Drawing.Size(31, 22)
        Me.esci.Text = "&Esci"
        Me.esci.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.esci.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'stampa
        '
        Me.stampa.Enabled = False
        Me.stampa.Image = CType(resources.GetObject("stampa.Image"), System.Drawing.Image)
        Me.stampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.stampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stampa.Name = "stampa"
        Me.stampa.Size = New System.Drawing.Size(51, 22)
        Me.stampa.Text = "&Stampa"
        Me.stampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.stampa.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'modifica
        '
        Me.modifica.Enabled = False
        Me.modifica.Image = CType(resources.GetObject("modifica.Image"), System.Drawing.Image)
        Me.modifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.modifica.Name = "modifica"
        Me.modifica.Size = New System.Drawing.Size(74, 22)
        Me.modifica.Text = "&Modifica"
        '
        'Navigatore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Navigatore"
        Me.Size = New System.Drawing.Size(752, 46)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents inserisci As System.Windows.Forms.ToolStripButton
    Friend WithEvents ricerca As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancella As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancellatutto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents indietro As System.Windows.Forms.ToolStripButton
    Friend WithEvents avanti As System.Windows.Forms.ToolStripButton
    Friend WithEvents primo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ultimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents annulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents conferma As System.Windows.Forms.ToolStripButton
    Friend WithEvents esci As System.Windows.Forms.ToolStripButton
    Friend WithEvents stampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents modifica As System.Windows.Forms.ToolStripButton

End Class
