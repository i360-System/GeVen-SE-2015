<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AccountutenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FatturazionegevenDataSet = New GeVen_SE_2015.fatturazionegevenDataSet()
        Me.AccountutenteTableAdapter = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.accountutenteTableAdapter()
        Me.TableAdapterManager = New GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ServerTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.DatabaseTextBox = New System.Windows.Forms.TextBox()
        Me.ProviderDatiComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountutenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(168, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 13)
        Label1.TabIndex = 8
        Label1.Text = "&Nome Utente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.GeVen_SE_2015.My.Resources.Resources.user_login_icon
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 8)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(168, 47)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 15)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(194, 237)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(297, 237)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Annulla"
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "user", True))
        Me.UserTextBox.Location = New System.Drawing.Point(172, 23)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(219, 20)
        Me.UserTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(171, 65)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(217, 20)
        Me.PasswordTextBox.TabIndex = 10
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'AccountutenteBindingSource
        '
        Me.AccountutenteBindingSource.DataMember = "accountutente"
        Me.AccountutenteBindingSource.DataSource = Me.FatturazionegevenDataSet
        '
        'FatturazionegevenDataSet
        '
        Me.FatturazionegevenDataSet.DataSetName = "fatturazionegevenDataSet"
        Me.FatturazionegevenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountutenteTableAdapter
        '
        Me.AccountutenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountutenteTableAdapter = Me.AccountutenteTableAdapter
        Me.TableAdapterManager.agentiprovvigioniTableAdapter = Nothing
        Me.TableAdapterManager.agentiTableAdapter = Nothing
        Me.TableAdapterManager.anagraficadestinazioniTableAdapter = Nothing
        Me.TableAdapterManager.anagraficafatturazioneTableAdapter = Nothing
        Me.TableAdapterManager.anagraficascontiTableAdapter = Nothing
        Me.TableAdapterManager.anagraficheTableAdapter = Nothing
        Me.TableAdapterManager.articolilistinoTableAdapter = Nothing
        Me.TableAdapterManager.articolimisureTableAdapter = Nothing
        Me.TableAdapterManager.articoliprezziacquistoTableAdapter = Nothing
        Me.TableAdapterManager.articoliTableAdapter = Nothing
        Me.TableAdapterManager.aspettobeniTableAdapter = Nothing
        Me.TableAdapterManager.aziendacostantiTableAdapter = Nothing
        Me.TableAdapterManager.aziendaintestazionemodulisticaTableAdapter = Nothing
        Me.TableAdapterManager.aziendeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriemerceologicheTableAdapter = Nothing
        Me.TableAdapterManager.categorieTableAdapter = Nothing
        Me.TableAdapterManager.causalitrasportoTableAdapter = Nothing
        Me.TableAdapterManager.classiarticoloTableAdapter = Nothing
        Me.TableAdapterManager.contiTableAdapter = Nothing
        Me.TableAdapterManager.diviseTableAdapter = Nothing
        Me.TableAdapterManager.documentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.documentiscadenzeTableAdapter = Nothing
        Me.TableAdapterManager.documentitestataTableAdapter = Nothing
        Me.TableAdapterManager.esercizicontabiliTableAdapter = Nothing
        Me.TableAdapterManager.magazzinodenominazioneTableAdapter = Nothing
        Me.TableAdapterManager.magazzinomovimentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.magazzinomovimentitestataTableAdapter = Nothing
        Me.TableAdapterManager.magazzinotipimovimentodettaglioTableAdapter = Nothing
        Me.TableAdapterManager.magazzinotipimovimentoTableAdapter = Nothing
        Me.TableAdapterManager.moditrasportoTableAdapter = Nothing
        Me.TableAdapterManager.operazionidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.operazioniTableAdapter = Nothing
        Me.TableAdapterManager.pagamentidettaglioTableAdapter = Nothing
        Me.TableAdapterManager.pagamentitestataTableAdapter = Nothing
        Me.TableAdapterManager.parametriivaTableAdapter = Nothing
        Me.TableAdapterManager.portafoglioeffettiTableAdapter = Nothing
        Me.TableAdapterManager.scontifornitoreTableAdapter = Nothing
        Me.TableAdapterManager.tipidocumentoTableAdapter = Nothing
        Me.TableAdapterManager.tipitrasportoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vettoriTableAdapter = Nothing
        Me.TableAdapterManager.zoneTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.ProviderDatiComboBox)
        Me.Panel1.Controls.Add(Me.DatabaseTextBox)
        Me.Panel1.Controls.Add(Me.PassTextBox)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ServerTextBox)
        Me.Panel1.Location = New System.Drawing.Point(172, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 140)
        Me.Panel1.TabIndex = 11
        '
        'ServerTextBox
        '
        Me.ServerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "user", True))
        Me.ServerTextBox.Location = New System.Drawing.Point(89, 3)
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ServerTextBox.TabIndex = 12
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "user", True))
        Me.IdTextBox.Location = New System.Drawing.Point(89, 29)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(124, 20)
        Me.IdTextBox.TabIndex = 13
        '
        'PassTextBox
        '
        Me.PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "user", True))
        Me.PassTextBox.Location = New System.Drawing.Point(89, 55)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(124, 20)
        Me.PassTextBox.TabIndex = 14
        '
        'DatabaseTextBox
        '
        Me.DatabaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountutenteBindingSource, "user", True))
        Me.DatabaseTextBox.Location = New System.Drawing.Point(89, 81)
        Me.DatabaseTextBox.Name = "DatabaseTextBox"
        Me.DatabaseTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DatabaseTextBox.TabIndex = 15
        '
        'ProviderDatiComboBox
        '
        Me.ProviderDatiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProviderDatiComboBox.FormattingEnabled = True
        Me.ProviderDatiComboBox.Location = New System.Drawing.Point(89, 107)
        Me.ProviderDatiComboBox.Name = "ProviderDatiComboBox"
        Me.ProviderDatiComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProviderDatiComboBox.TabIndex = 16
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 10)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 12
        Label2.Text = "Server" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(13, 36)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(16, 13)
        Label3.TabIndex = 17
        Label3.Text = "Id"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(13, 62)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 18
        Label4.Text = "Password"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(13, 88)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(53, 13)
        Label5.TabIndex = 19
        Label5.Text = "Database"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(13, 115)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(68, 13)
        Label6.TabIndex = 20
        Label6.Text = "Provider Dati"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 13)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(402, 263)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountutenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatturazionegevenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FatturazionegevenDataSet As GeVen_SE_2015.fatturazionegevenDataSet
    Friend WithEvents AccountutenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountutenteTableAdapter As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.accountutenteTableAdapter
    Friend WithEvents TableAdapterManager As GeVen_SE_2015.fatturazionegevenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProviderDatiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatabaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
