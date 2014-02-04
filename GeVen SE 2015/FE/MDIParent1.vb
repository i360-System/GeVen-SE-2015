Imports System.Windows.Forms
Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class MDIParent1





    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub


#Region "new client"

    Dim t As New TcpClient

    Sub connect(ByVal ip As String, ByVal port As Integer)

        Try
            t.Connect(ip, port) 'tries to connect
            If t.Connected Then 'if connected, start the reading procedure
                t.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf doread, Nothing)
                login() 'send our details to the server
                connectButtonTCPIP.Enabled = False
            End If
        Catch ex As Exception
            If MsgBox(ex.ToString & vbCrLf & "Tentare la riconnessione?", vbYesNo) = vbYes Then
                System.Threading.Thread.Sleep(5000) 'if an error occurs sleep for 8 seconds
                connect(ip, port) 'try to reconnect
            Else

            End If
        End Try
    End Sub




    Sub login()
        senddata("LOGIN|") 'log in to the chatserver
    End Sub
    Sub senddata(ByVal message As String)

        Dim sw As StreamWriter = Nothing 'declare a new streamwriter

        Try
            sw = New StreamWriter(t.GetStream)
            sw.WriteLine(message) 'write the message

        Catch ex As Exception

            MsgBox(ex.ToString)

        Finally

            sw.Flush()

        End Try

    End Sub
    Sub messagerecieved(ByVal message As String)
        Dim msg() As String = message.Split("|") ' if a message is recieved, split it to process it
        Select Case msg(0) 'process it by the first element in the split array

            Case "CHAT"
                'TextBox4.Text &= "Server: " & " " & msg(1) & vbNewLine
        End Select

    End Sub
    Sub doread(ByVal ar As IAsyncResult)
        Try
            Dim sr As New StreamReader(t.GetStream) 'declare a new streamreader to read fromt eh network stream
            Dim msg As String = sr.ReadLine() 'the msg is what is bing read
            messagerecieved(msg) 'start processing the message
            t.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf doread, Nothing) 'continue to read

        Catch ex As Exception
            System.Threading.Thread.Sleep(8000) 'if an error occurs, wait for 8 seconds
            connect(My.Settings.ServerIP, My.Settings.porta) 'try to reconnect
        End Try
    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    senddata("CHAT|" & TextBox3.Text) 'send the data with CHAT| as header
    '    TextBox4.Text &= "You: " & " " & TextBox3.Text.Split("|")(0) & vbNewLine
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' connette al server.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub connectButtonTCPIP_Click(sender As Object, e As EventArgs) Handles connectButtonTCPIP.Click
        If True Then
            Cursor.Current = Cursors.WaitCursor
            connect(My.Settings.ServerIP, My.Settings.porta) 'connect textbox1 as ip and textbox2 as port
            Cursor.Current = Cursors.Default
        End If
    End Sub

#End Region




#Region "menù"

#Region "File"

    ''' <summary>
    ''' Termina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub TerminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminaToolStripMenuItem.Click
        If MsgBox("Vuoi terminare il programma? Tutti i form aperti verranno chiusi.", MsgBoxStyle.YesNo, "Confermare uscita?") = MsgBoxResult.Yes Then
            For Each chdForm As Form In Me.MdiChildren
                chdForm.Dispose()
            Next
            Me.Close()
            Me.Dispose()
        End If
    End Sub

#End Region

#Region "Documenti"

    Private Sub ArchivioDocumentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivioDocumentiToolStripMenuItem.Click
        Dim NewMDIChild As GestioneDocumenti
        NewMDIChild = GestioneDocumenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


    Private Sub GenerazioneFattureDaDcoumentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerazioneFattureDaDcoumentiToolStripMenuItem.Click
        Dim NewMDIChild As GestioneFattureDocumenti
        NewMDIChild = GestioneFattureDocumenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


#End Region

#Region "Anagrafiche"

    ''' <summary>
    ''' Apre Categoria Clienti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CategorieClientiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieClientiToolStripMenuItem.Click

        Dim NewMDIChild As CategorieClienti
        NewMDIChild = CategorieClienti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre ZoneGeografiche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ZoneGeograficheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoneGeograficheToolStripMenuItem.Click
        Dim NewMDIChild As ZoneGeografiche
        NewMDIChild = ZoneGeografiche.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre GestioniAnnuali
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GestioniAnnualiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestioniAnnualiToolStripMenuItem.Click
        Dim NewMDIChild As GestioniAnnuali
        NewMDIChild = GestioniAnnuali.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre AgentiRappresentanti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AgentiRappresentantiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentiRappresentantiToolStripMenuItem.Click

        Dim NewMDIChild As AgentiRappresentanti
        NewMDIChild = AgentiRappresentanti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre DatiAzienda
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DatiAziendeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatiAziendeToolStripMenuItem.Click
        Dim NewMDIChild As DatiAziende
        NewMDIChild = DatiAziende.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Cambio Valuta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CambioValutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioValutaToolStripMenuItem.Click
        Dim NewMDIChild As CambioValuta
        NewMDIChild = CambioValuta.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    '''Apre Spedizionieri e Corrieri 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SpedizionieriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpedizionieriToolStripMenuItem.Click
        Dim NewMDIChild As Spedizionieri
        NewMDIChild = Spedizionieri.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre il form Modalita di Pagamento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ModalitàPagamentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalitàPagamentiToolStripMenuItem.Click

        Dim NewMDIChild As ModalitaPagamento
        NewMDIChild = ModalitaPagamento.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    ''' <summary>
    ''' Apre Iva
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub IvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvaToolStripMenuItem.Click
        Dim NewMDIChild As Iva
        NewMDIChild = Iva.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre tipidocumento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TipiDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiDocumentoToolStripMenuItem.Click
        Dim NewMDIChild As TipiDocumento
        NewMDIChild = TipiDocumento.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Anagrafica clienti
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AnagraficaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnagraficaToolStripMenuItem.Click
        Dim NewMDIChild As Anagrafica
        NewMDIChild = Anagrafica.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre sconti.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ScontiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScontiToolStripMenuItem.Click
        Dim NewMDIChild As Sconti
        NewMDIChild = Sconti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Destinazione della Merce
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DestinazioneMerceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinazioneMerceToolStripMenuItem.Click
        Dim NewMDIChild As DestinazioneMerce
        NewMDIChild = DestinazioneMerce.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

#End Region

#Region "Magazzino"

    ''' <summary>
    ''' Apre Movimenti.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MovimentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentiToolStripMenuItem.Click
        Dim NewMDIChild As Movimenti
        NewMDIChild = Movimenti.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre generazioneinventario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GenerazioneInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerazioneInventarioToolStripMenuItem.Click
        Dim NewMDIChild As GenerazioneInventario
        NewMDIChild = GenerazioneInventario.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre Magazzini
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TabelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelleToolStripMenuItem.Click
        Dim NewMDIChild As Magazzini
        NewMDIChild = Magazzini.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre articoli
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ArticoliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticoliToolStripMenuItem.Click
        Dim NewMDIChild As Articoli
        NewMDIChild = Articoli.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre listinoArticoli.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ScontiFornitoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScontiFornitoreToolStripMenuItem.Click
        Dim NewMDIChild As ListinoArticoli
        NewMDIChild = ListinoArticoli.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre PrezziAcquisto.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrezziAcquistoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrezziAcquistoToolStripMenuItem.Click
        Dim NewMDIChild As PrezziAcquisto
        NewMDIChild = PrezziAcquisto.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre ClassiArticolo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClassiArticoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassiArticoloToolStripMenuItem.Click
        Dim NewMDIChild As ClassiArticolo
        NewMDIChild = ClassiArticolo.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

#End Region

#Region "Strumenti"

    ''' <summary>
    ''' Apre Opzioni
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OpzioniToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem1.Click
        Dim NewMDIChild As Opzioni
        NewMDIChild = Opzioni.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre EsportazioneAnagrafiche.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EsportazioneAnagraficheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsportazioneAnagraficheToolStripMenuItem.Click
        Dim NewMDIChild As EsportazioneAnagrafiche
        NewMDIChild = EsportazioneAnagrafiche.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    ''' <summary>
    ''' Apre EsportazioneFatture.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EsportazioneFattureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsportazioneFattureToolStripMenuItem.Click
        Dim NewMDIChild As EsportazioneFatture
        NewMDIChild = EsportazioneFatture.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

#End Region

#Region "Finestre"
    Private Sub TileVerticalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        'Chiude tutti i form figlio del form padre.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
#End Region

#Region "?"

    ''' <summary>
    ''' Apre il form Informazioni sul software
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InformazioniSulSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformazioniSulSoftwareToolStripMenuItem.Click
        Dim NewMDIChild As AboutBox1
        NewMDIChild = AboutBox1.Istanza
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub


#End Region

#End Region

#Region "Menù di connessione"

    'Private Sub PortTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PortTextBox.Validating
    '    Dim deltaPort As Integer
    '    If Not Integer.TryParse(porta, deltaPort) OrElse deltaPort < 1 OrElse deltaPort > 65535 Then
    '        MessageBox.Show("Port number must be an integer between 1 and 65535.", "Invalid Port Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        'porta.SelectAll()
    '        e.Cancel = True
    '    End If
    'End Sub



    Private Sub ValidazioneIP()

        Dim _ServerAddress = Nothing
        If My.Settings.ServerIP = "" Then Exit Sub
        Dim remoteHost As IPHostEntry = Dns.GetHostEntry(My.Settings.ServerIP)
        If remoteHost IsNot Nothing AndAlso remoteHost.AddressList.Length > 0 Then
            For Each deltaAddress As IPAddress In remoteHost.AddressList
                If deltaAddress.AddressFamily = AddressFamily.InterNetwork Then
                    _ServerAddress = deltaAddress
                    'My.Settings.ServerIP = Trim(ServerTextBox.Text)
                    'My.Settings.Save()
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub ServerTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ServerTextBox.Validating
        '    ' If Not My.Settings.ServerIP = "" Then
        '    _ServerAddress = Nothing
        '    Dim remoteHost As IPHostEntry = Dns.GetHostEntry(ServerTextBox.Text)
        '    If remoteHost IsNot Nothing AndAlso remoteHost.AddressList.Length > 0 Then
        '        For Each deltaAddress As IPAddress In remoteHost.AddressList
        '            If deltaAddress.AddressFamily = AddressFamily.InterNetwork Then
        '                '                 _ServerAddress = deltaAddress
        '                My.Settings.ServerIP = Trim(ServerTextBox.Text)
        '                My.Settings.Save()
        '                Exit For
        '            End If
        '        Next
        '    End If

        '    If _ServerAddress Is Nothing Then

        '        MessageBox.Show("Cannot resolve server address.", "Invalid Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        'ServerTextBox.SelectAll()
        '        e.Cancel = True
        '    End If

    End Sub



    ''Private Sub SendButton_Click(sender As System.Object, e As System.EventArgs) Handles SendButton.Click
    'Public Sub IstruzioneDBServer(ByVal istruzione As String)
    '    If _Connection IsNot Nothing AndAlso _Connection.Client.Connected AndAlso _Connection.Stream IsNot Nothing Then
    '        Dim buffer() As Byte = System.Text.Encoding.ASCII.GetBytes(istruzione)
    '        _Connection.Stream.Write(buffer, 0, buffer.Length)
    '    Else
    '        serializzatore.comunica = False
    '        MsgBox("Non è stato possibile comunicare con il server. Provare a riconnettersi.")
    '    End If
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If _Connection Is Nothing Or _Connection.Client.Connected = False Or _Connection.Stream Is Nothing Or _Connection.Stream.CanWrite = False Then

    '        'image
    '        Timer1.Enabled = False
    '        connectButtonTCPIP.Checked = False
    '        connectButtonTCPIP.Text = "Connect"
    '        MsgBox("Connessione persa con il server, riconnettersi.")
    '    Else
    '        IstruzioneDBServer("<--tryconnect-->")
    '        'Dim buffer() As Byte = System.Text.Encoding.ASCII.GetBytes("<--tryconnect-->")
    '        '_Connection.Stream.Write(buffer, 0, buffer.Length)
    '    End If
    'End Sub
#End Region


End Class




#Region "codice commentato"


'Private _Connection As ConnectionInfo
'Private _ServerAddress As IPAddress

''Encapuslates the client connection and provides a state object for async read operations 
'Public Class ConnectionInfo
'    Private _AppendMethod As Action(Of String)
'    Public ReadOnly Property AppendMethod As Action(Of String)
'        Get
'            Return _AppendMethod
'        End Get
'    End Property

'    Private _Client As TcpClient
'    Public ReadOnly Property Client As TcpClient
'        Get
'            Return _Client
'        End Get
'    End Property

'    Private _Stream As NetworkStream
'    Public ReadOnly Property Stream As NetworkStream
'        Get
'            Return _Stream
'        End Get
'    End Property

'    Private _LastReadLength As Integer
'    Public ReadOnly Property LastReadLength As Integer
'        Get
'            Return _LastReadLength
'        End Get
'    End Property

'    Private _Buffer(63) As Byte

'    Public Sub New(address As IPAddress, port As Integer, append As Action(Of String))
'        _AppendMethod = append
'        _Client = New TcpClient
'        _Client.Connect(address, port)
'        _Stream = _Client.GetStream
'    End Sub

'    Public Sub AwaitData()
'        _Stream.BeginRead(_Buffer, 0, _Buffer.Length, AddressOf DoReadData, Me)
'    End Sub


'    Public Sub Close()
'        If _Client IsNot Nothing Then _Client.Close()
'        _Client = Nothing
'        _Stream = Nothing
'    End Sub

'    Private Sub DoReadData(result As IAsyncResult)
'        Dim info As ConnectionInfo = CType(result.AsyncState, ConnectionInfo)
'        Try
'            If info._Stream IsNot Nothing AndAlso info._Stream.CanRead Then
'                info._LastReadLength = info._Stream.EndRead(result)
'                If info._LastReadLength > 0 Then
'                    'otteniamo il dataset
'                    'Dim p As New DataSet
'                    'p= 
'                    Dim message As String = System.Text.Encoding.ASCII.GetString(info._Buffer)
'                    info._AppendMethod(message)

'                End If
'                info.AwaitData()
'            End If
'        Catch ex As Exception
'            info._LastReadLength = -1
'            info._AppendMethod(ex.Message)
'        End Try
'    End Sub
'End Class

'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
'    ' Crea una nuova istanza del form figlio.
'    Dim ChildForm As New System.Windows.Forms.Form
'    ' Imposta il form come figlio di questo form MDI prima di visualizzarlo.
'    ChildForm.MdiParent = Me

'    m_ChildFormNumber += 1
'    ChildForm.Text = "Finestra " & m_ChildFormNumber

'    ChildForm.Show()
'End Sub
'Private m_ChildFormNumber As Integer

'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
'    Dim OpenFileDialog As New OpenFileDialog
'    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
'    OpenFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"
'    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
'        Dim FileName As String = OpenFileDialog.FileName
'        ' TODO: aggiungere qui il codice per l'apertura del file.
'    End If
'End Sub

'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Dim SaveFileDialog As New SaveFileDialog
'    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
'    SaveFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"

'    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
'        Dim FileName As String = SaveFileDialog.FileName
'        ' TODO: aggiungere qui il codice per il salvataggio del contenuto corrente del form in un file.
'    End If
'End Sub

'Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.Close()
'End Sub
'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Chiude tutti i form figlio del form padre.
'    For Each ChildForm As Form In Me.MdiChildren
'        ChildForm.Close()
'    Next
'End Sub


'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
'End Sub

'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
'End Sub

'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    'Utilizzare My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData per recuperare informazioni dagli Appunti.
'End Sub

'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
'End Sub

'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
'End Sub

'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.Cascade)
'End Sub

'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.TileVertical)
'End Sub

'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.LayoutMdi(MdiLayout.TileHorizontal)
'End Sub

#End Region