


Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Threading.Tasks

Imports MySql.Data.MySqlClient

Public Class ServerForm
    Private Delegate Sub Disconnessione(ByVal newValue As ConnectedClient)
    Private Delegate Sub AggiungiClient(ByVal newValue As ConnectedClient)
    Private Delegate Sub ConnessioneSystemConsole(ByVal newValuew As String)
    Private Delegate Sub RemoveListBox(ByVal newValue As String)

#Region "old"

    '    Private _Listener As TcpListener
    '    Private _Connections As New List(Of ConnectionInfo)
    '    Private _ConnectionMontior As Task
    '    ' Private _porta As String = ""

    '    Private Sub StartStopButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles StartStopButton.CheckedChanged

    '        If StartStopButton.Checked Then
    '            StartStopButton.Text = "Stop"
    '            'StartStopButton.Image = My.Resources.Resources.StopServer
    '            _Listener = New TcpListener(IPAddress.Any, CInt(PortTextBox.Text))
    '            _Listener.Start()
    '            Dim monitor As New MonitorInfo(_Listener, _Connections)
    '            ListenForClient(monitor)
    '            _ConnectionMontior = Task.Factory.StartNew(AddressOf DoMonitorConnections, monitor, TaskCreationOptions.LongRunning)
    '        Else
    '            StartStopButton.Text = "Start"
    '            'StartStopButton.Image = My.Resources.Resources.StartServer
    '            CType(_ConnectionMontior.AsyncState, MonitorInfo).Cancel = True
    '            _Listener.Stop()
    '            _Listener = Nothing
    '        End If

    '    End Sub



    '    Private Sub PortTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PortTextBox.Validating

    '        Dim deltaPort As Integer
    '        If Not Integer.TryParse(PortTextBox.Text, deltaPort) OrElse deltaPort < 1 OrElse deltaPort > 65535 Then
    '            MessageBox.Show("Port number must be an integer between 1 and 65535.", "Invalid Port Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            PortTextBox.SelectAll()
    '            e.Cancel = True
    '            StartStopButton.Enabled = False
    '        Else
    '            StartStopButton.Enabled = True
    '        End If

    '    End Sub

    '    Private Sub ListenForClient(monitor As MonitorInfo)
    '        Dim info As New ConnectionInfo(monitor)
    '        _Listener.BeginAcceptTcpClient(AddressOf DoAcceptClient, info)
    '    End Sub

    '    Private Sub DoAcceptClient(result As IAsyncResult) 'qui accetto il client
    '        Dim monitorInfo As MonitorInfo = CType(_ConnectionMontior.AsyncState, MonitorInfo)
    '        If monitorInfo.Listener IsNot Nothing AndAlso Not monitorInfo.Cancel Then
    '            Dim info As ConnectionInfo = CType(result.AsyncState, ConnectionInfo)
    '            monitorInfo.Connections.Add(info) ' qui aggiunge la connessione
    '            info.AcceptClient(result)
    '            ListenForClient(monitorInfo)
    '            info.AwaitData()
    '            Dim doUpdateConnectionCountLabel As New Action(AddressOf UpdateConnectionCountLabel)
    '            Invoke(doUpdateConnectionCountLabel)
    '        End If
    '    End Sub


    '    Private Sub DoMonitorConnections()
    '        'Create delegate for updating output display 
    '        Dim doAppendOutput As New Action(Of String)(AddressOf AppendOutput)
    '        'Create delegate for updating connection count label 
    '        Dim doUpdateConnectionCountLabel As New Action(AddressOf UpdateConnectionCountLabel)

    '        'Get MonitorInfo instance from thread-save Task instance 
    '        Dim monitorInfo As MonitorInfo = CType(_ConnectionMontior.AsyncState, MonitorInfo)

    '        'Report progress 
    '        Me.Invoke(doAppendOutput, "Monitor Started at " & Date.Today) 'Avvio del server e scrittura nella text


    '        'Qui continua a cilcare il server per aspettare le connesioni in ingresso, finche non si stoppa, lui cicla
    '        'Implement client connection processing loop 
    '        Do
    '            'Create temporary list for recording closed connections 
    '            Dim lostCount As Integer = 0
    '            'Examine each connection for processing 
    '            For index As Integer = monitorInfo.Connections.Count - 1 To 0 Step -1
    '                Dim info As ConnectionInfo = monitorInfo.Connections(index) ' Da qui arriva la connesione del client
    '                'If info
    '                If info.Client.Connected Then ' se il client è connesso 
    '                    'Process connected client 

    '                    If info.DataQueue.Count > 0 Then
    '                        'The code in this If-Block should be modified to build 'message' objects 
    '                        'according to the protocol you defined for your data transmissions. 
    '                        'This example simply sends all pending message bytes to the output textbox. 
    '                        'Without a protocol we cannot know what constitutes a complete message, so 
    '                        'with multiple active clients we could see part of client1's first message, 
    '                        'then part of a message from client2, followed by the rest of client1's 
    '                        'first message (assuming client1 sent more than 64 bytes). po
    '                        Dim messageBytes As New List(Of Byte)         'qui ricevo istruzioni dal client
    '                        While info.DataQueue.Count > 0
    '                            Dim value As Byte
    '                            If info.DataQueue.TryDequeue(value) Then
    '                                messageBytes.Add(value)
    '                            End If
    '                        End While
    '                        Me.Invoke(doAppendOutput, System.Text.Encoding.ASCII.GetString(messageBytes.ToArray))
    '                    End If
    '                Else
    '                    'Clean-up any closed client connections 
    '                    monitorInfo.Connections.Remove(info)
    '                    lostCount += 1
    '                End If
    '            Next
    '            If lostCount > 0 Then
    '                Invoke(doUpdateConnectionCountLabel)
    '            End If

    '            'Throttle loop to avoid wasting CPU time 
    '            _ConnectionMontior.Wait(1)
    '        Loop While Not monitorInfo.Cancel

    '        'Close all connections before exiting monitor 
    '        For Each info As ConnectionInfo In monitorInfo.Connections
    '            info.Client.Close()
    '        Next
    '        monitorInfo.Connections.Clear()

    '        'Update the connection count label and report status 
    '        Invoke(doUpdateConnectionCountLabel)
    '        Me.Invoke(doAppendOutput, "Monitor Stopped.")
    '    End Sub

    '    Private Sub AppendOutput(message As String)
    '        If Not InStr(message, "<--try-->") = 0 Then Exit Sub
    '        If message(0) = "«" And (message(message.Length - 1) = "►" Or message(message.Length - 1) = ",") Then
    '            ExecuteQuery(message)
    '        End If
    '        If RichTextBox1.TextLength > 0 Then
    '            RichTextBox1.AppendText(ControlChars.NewLine)
    '        End If
    '        RichTextBox1.AppendText(message)
    '        RichTextBox1.ScrollToCaret()
    '    End Sub

    '    Private Function ExecuteQuery(ByVal queryDaEsedguire As String) As DataSet

    '        Dim DatasetDaRestituire As New DataSet
    '        'Dim conn As MySql.Data.MySqlClient.MySqlConnection
    '        ''mi connetto al DB
    '        'conn = New MySql.Data.MySqlClient.MySqlConnection()
    '        'conn.ConnectionString = "server=localhost; user id=root; password=TUAPSW; database=TUODB"

    '        'Try
    '        '    conn.Open()
    '        'Catch myerror As MySql.Data.MySqlClient.MySqlException
    '        '    MsgBox("Errore nella connessione al database!")
    '        'End Try
    '        ''sql query
    '        'Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

    '        'Dim sqlquery = (queryDaEsedguire)

    '        'Dim myCommand As New MySql.Data.MySqlClient.MySqlCommand()
    '        'myCommand.Connection = conn
    '        'myCommand.CommandText = sqlquery
    '        ''Faccio partire la query
    '        'myAdapter.SelectCommand = myCommand
    '        'Dim myData As MySql.Data.MySqlClient.MySqlDataReader
    '        'myData = myCommand.ExecuteReader()
    '        'If myData.HasRows = 0 Then
    '        '    MsgBox("Query eseguita correttamente")
    '        'Else
    '        '    MsgBox("Query eseguita correttamente")
    '        'End If
    '        Dim ServerDB As String = My.Settings.serverDB
    '        Dim user As String = My.Settings.user
    '        Dim password As String = My.Settings.password
    '        Dim DB As String = My.Settings.nomeDB

    '        Dim connectionstring As String = "Server=" & ServerDB & ";User Id=" & user & ";Password=" & password & ";Database=data"
    '        Dim commandtext As String
    '        Dim adapter As MySqlDataAdapter
    '        Dim table As DataTable
    '        commandtext = queryDaEsedguire '"select * from account where user=admin"
    '        Try
    '            adapter = New MySqlDataAdapter(commandtext, connectionstring)
    '            table = New DataTable
    '            adapter.Fill(table)

    '            'incollo dataset
    '            adapter.Fill(DatasetDaRestituire)

    '            'DataGridView1.DataSource = table '##########(but instead of datagrid put the data in a textbox Put the id in the textbox )#######
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '        Return DatasetDaRestituire

    '    End Function



    '    Private Sub StreamDataSet(ByVal objDataSet As Object, ByRef socket As Object, ByRef var As NetworkStream)


    '    End Sub

    '    Private Sub UpdateConnectionCountLabel()
    '        ConnectionCountLabel.Text = String.Format("{0} Connections", _Connections.Count)
    '    End Sub

    '    Public Sub New()

    '        ' Chiamata richiesta dalla finestra di progettazione.
    '        InitializeComponent()

    '        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
    '        StartStopButton.Enabled = False
    '    End Sub
    'End Class

    ''Provides a simple container object to be used for the state object passed to the connection monitoring thread 
    'Public Class MonitorInfo
    '    Public Property Cancel As Boolean

    '    Private _Connections As List(Of ConnectionInfo)
    '    Public ReadOnly Property Connections As List(Of ConnectionInfo)
    '        Get
    '            Return _Connections
    '        End Get
    '    End Property

    '    Private _Listener As TcpListener
    '    Public ReadOnly Property Listener As TcpListener
    '        Get
    '            Return _Listener
    '        End Get
    '    End Property

    '    Public Sub New(tcpListener As TcpListener, connectionInfoList As List(Of ConnectionInfo))
    '        _Listener = tcpListener
    '        _Connections = connectionInfoList
    '    End Sub
    'End Class

    ''Provides a container object to serve as the state object for async client and stream operations 
    'Public Class ConnectionInfo
    '    'hold a reference to entire monitor instead of just the listener 
    '    Private _Monitor As MonitorInfo
    '    Public ReadOnly Property Monitor As MonitorInfo
    '        Get
    '            Return _Monitor
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

    '    Private _DataQueue As System.Collections.Concurrent.ConcurrentQueue(Of Byte)
    '    Public ReadOnly Property DataQueue As System.Collections.Concurrent.ConcurrentQueue(Of Byte)
    '        Get
    '            Return _DataQueue
    '        End Get
    '    End Property

    '    Private _LastReadLength As Integer
    '    Public ReadOnly Property LastReadLength As Integer
    '        Get
    '            Return _LastReadLength
    '        End Get
    '    End Property


    '    'The buffer size is an arbitrary value which should be selected based on the 
    '    'amount of data you need to transmit, the rate of transmissions, and the 
    '    'anticipalted number of clients. These are the considerations for designing 
    '    'the communicaition protocol for data transmissions, and the size of the read 
    '    'buffer must be based upon the needs of the protocol. 
    '    Private _Buffer(63) As Byte
    '    'implementiamo qui la dimensione del nostro buffer
    '    Public Sub New(monitor As MonitorInfo)
    '        _Monitor = monitor
    '        _DataQueue = New System.Collections.Concurrent.ConcurrentQueue(Of Byte)
    '    End Sub

    '    Public Sub AcceptClient(result As IAsyncResult)
    '        _Client = _Monitor.Listener.EndAcceptTcpClient(result)
    '        If _Client IsNot Nothing AndAlso _Client.Connected Then
    '            _Stream = _Client.GetStream
    '        End If
    '    End Sub

    '    Public Sub AwaitData()
    '        _Stream.BeginRead(_Buffer, 0, _Buffer.Length, AddressOf DoReadData, Me)
    '    End Sub

    '    Private Sub DoReadData(result As IAsyncResult) '1
    '        Dim info As ConnectionInfo = CType(result.AsyncState, ConnectionInfo)
    '        Try
    '            'If the stream is valid for reading, get the current data and then 
    '            'begin another async read 
    '            If info.Stream IsNot Nothing AndAlso info.Stream.CanRead Then
    '                info._LastReadLength = info.Stream.EndRead(result)
    '                For index As Integer = 0 To _LastReadLength - 1
    '                    info._DataQueue.Enqueue(info._Buffer(index))
    '                Next


    '                'The example responds to all data reception with the number of bytes received; 
    '                'you would likely change this behavior when implementing your own protocol. 
    '                'info.SendMessage("Received " & info._LastReadLength & " Bytes")


    '                'qio posso esquire il costruttore query
    '                'Dim serv As New Services

    '                'serv.CostruttoreQuery(System.Text.Encoding.ASCII.GetString(info._Buffer))

    '                ' a seconda del risultato della query mandaeremo o un xml ricostruibile o una istruzione stringa che i client interpretera
    '                'info.SendDataSet()

    '                ' ''''''manda a tutti il messaggio
    '                'For Each otherInfo As ConnectionInfo In info.Monitor.Connections
    '                '    If Not otherInfo Is info Then
    '                '        otherInfo.SendMessage(System.Text.Encoding.ASCII.GetString(info._Buffer))
    '                '    End If
    '                'Next
    '                ' '''''''''''''''''
    '                'info._Buffer = Nothing
    '                info.AwaitData()
    '            Else
    '                'If we cannot read from the stream, the example assumes the connection is 
    '                'invalid and closes the client connection. You might modify this behavior 
    '                'when implementing your own protocol. 
    '                info.Client.Close()
    '            End If
    '        Catch ex As Exception
    '            info._LastReadLength = -1
    '        End Try
    '    End Sub

    '    Private Sub SendDataSet(ByRef objDataset As DataSet)

    '        If _Stream IsNot Nothing Then
    '            'var = New NetworkStream(Socket)
    '            Try
    '                objDataset.WriteXml(_Stream)

    '                'Dim messageData() As Byte = System.Text.Encoding.ASCII.GetBytes(Message)
    '                'Stream.Write(messageData, 0, messageData.Length)
    '                'Try
    '                '    Using var

    '                '        objDataset.WriteXml(var)

    '                '    End Using
    '            Catch ex As Exception

    '            End Try
    '        Else
    '            MsgBox("Impossibile inviare i risultati della query.")
    '        End If

    '    End Sub



    '    Private Sub SendMessage(message As String) ' qui si potrebbe inviare
    '        If _Stream IsNot Nothing Then
    '            Dim messageData() As Byte = System.Text.Encoding.ASCII.GetBytes(message) ' qui gli diamo la query
    '            Stream.Write(messageData, 0, messageData.Length)
    '        End If
    '    End Sub
    'End Class


#End Region
    Dim clients As New Hashtable 'new database (hashtable) to hold the clients
    Sub recieved(ByVal msg As String, ByVal client As ConnectedClient)
        Dim message() As String = msg.Split("|") 'make an array with elements of the message recieved
        Select Case message(0) 'process by the first element in the array
            Case "CHAT" 'if it's CHAT
                TextBox1.Text &= client.name & " says: " & " " & message(1) & vbNewLine 'add the message to the chatbox
                'sendallbutone(message(1), client.name) 'this will update all clients with the new message
                '                                       and it will not send the message to the client it recieved it from :)
            Case "LOGIN" 'A client has connected
                clients.Add(client, client.name) 'add the client to our database (a hashtable)
                ListBox1.Invoke(New AggiungiClient(AddressOf addClient), client)
                'ListBox1.Items.Add(client.name) 'add the client to the listbox to display the new user
                'TextBox1.AppendText("Connected " & client.name & vbCrLf) 'inform system console
                TextBox1.Invoke(New ConnessioneSystemConsole(AddressOf ConSystemConsole), client.name)
        End Select

    End Sub

    Private Sub ConSystemConsole(ByVal name As String)

        TextBox1.AppendText("Connected " & name & vbCrLf) 'inform system console

    End Sub


    Private Sub addClient(ByVal client As ConnectedClient)
        ListBox1.Items.Add(client.name)
    End Sub
    Sub sendallbutone(ByVal message As String, ByVal exemptclientname As String) 'this sends to all clients except the one specified
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                If entry.Value <> exemptclientname Then 'if the entry IS NOT the exempt client name
                    Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                    cli.senddata(message) 'send the message to it
                End If
            Next
        Catch
        End Try
    End Sub
    Sub sendsingle(ByVal message As String, ByVal clientname As String)
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                If entry.Value = clientname Then 'if the entry is belongs to the client specified
                    Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                    cli.senddata(message) 'send the message to it
                End If
            Next
        Catch
        End Try

    End Sub
    Sub senddata(ByVal message As String) 'this sends a message to all connected clients
        Dim entry As DictionaryEntry 'declare a variable of type dictionary entry
        Try
            For Each entry In clients 'for each dictionary entry in the hashtable with all clients (clients)
                Dim cli As ConnectedClient = CType(entry.Key, ConnectedClient) ' cast the hashtable entry to a connection class
                cli.senddata(message) 'send the message to it
            Next  'go to the next client
        Catch
        End Try

    End Sub
    Sub disconnected(ByVal client As ConnectedClient) 'if a client is disconnected, this is raised
        clients.Remove(client) 'remove the client from the hashtable

        ' ListBox1.Items.Remove(client.name) 'remove it from our listbox
        ListBox1.Invoke(New RemoveListBox(AddressOf remo), client.name)
        TextBox1.Invoke(New Disconnessione(AddressOf disc), client)
    End Sub

    Private Sub remo(ByVal name As String)
        ListBox1.Items.Remove(Name)
    End Sub

    Private Sub disc(ByVal client As ConnectedClient)
        TextBox1.AppendText("Disconnected:" & client.name & "at " & Date.Today & vbCrLf) 'inform system console.
    End Sub

    Sub listen(ByVal port As Integer)
        Try
            Dim t As New TcpListener(IPAddress.Any, port) 'declare a new tcplistener
            t.Start() 'start the listener
            Do

                Dim client As New ConnectedClient(t.AcceptTcpClient) 'initialize a new connected client
                AddHandler client.gotmessage, AddressOf recieved 'add the handler which will raise an event when a message is recieved
                AddHandler client.disconnected, AddressOf disconnected 'add the handler which will raise an event when the client disconnects

            Loop Until False
        Catch
        End Try

    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    senddata("CHAT|" & TextBox2.Text) 'send teh data with CHAT as the header so the clietn knows to process the message as a chat message
    '    TextBox3.Text &= "You Say: " & " " & TextBox2.Text & vbNewLine 'add a message to the chat textbox showing we have sent a public message
    'End Sub

    ' Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click
    Private Sub SendDataToSingleClient(ByVal cli As String)
        Try
            'For Each cli As String In ListBox1.SelectedItems 'for each selected client in the selected listbox of our clients
            'sendsingle("CHAT|" & ToolStripTextBox1.Text, cli) 'send a message to the only the selected client by providing it's name as a second parameter
            sendsingle("CHAT|", cli)
            'TextBox3.Text &= "To " & cli & " :" & " " & ToolStripTextBox1.Text.Split("|")(1) & vbNewLine 'add a message on textbox3 which suggests a private message 
            'Next 'go to the next selected client if any
        Catch
        End Try

    End Sub

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click

        If validazionePorta() Then
            Dim listener As New System.Threading.Thread(AddressOf listen) 'initialize a new thread for the listener so our GUI doesn't lag
            listener.IsBackground = True
            listener.Start(My.Settings.porta) 'start the listener, with the port specified as a parameter (textbox1 is our port textbox)
            StartStopButton.Enabled = False 'disable our button so the user cannot try to make any further listeners which will result in errors

            TextBox1.AppendText("Monitor started at " & Date.Today & " " & TimeOfDay & "." & vbCrLf)
        Else
            MsgBox("Inserire una porta corretta.")
        End If
    End Sub


    Private Function validazionePorta() As Boolean

        Dim res As Boolean = False

        Dim deltaPort As Integer
        If Not Integer.TryParse(My.Settings.porta, deltaPort) OrElse deltaPort < 1 OrElse deltaPort > 65535 Then
            MessageBox.Show("Port number must be an integer between 1 and 65535.", "Invalid Port Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'PortTextBox.SelectAll()
            'e.Cancel = True
            res = False
        Else

            res = True

        End If

        Return res

    End Function

    Private Sub OpzioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpzioniToolStripMenuItem.Click
        Dim NewMDIChild As Opzioni
        NewMDIChild = Opzioni.Istanza
        'Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        StartStopButton.Enabled = True
        ' listener.stop()
        TextBox1.AppendText("Monitor stopped at " & Date.Today & " " & TimeOfDay & "." & vbCrLf)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Nothing
    End Sub
End Class