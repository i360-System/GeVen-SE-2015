Public Class LoginForm1

    ' TODO: inserire il codice per l'esecuzione dell'autenticazione personalizzata tramite il nome utente e la password forniti 
    ' (Vedere http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'entità personalizzata può essere quindi collegata all'entità del thread corrente nel modo seguente: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' dove CustomPrincipal è l'implementazione di IPrincipal utilizzata per eseguire l'autenticazione. 
    ' My.User restituirà quindi informazioni sull'identità incapsulate nell'oggetto CustomPrincipal,
    ' quali il nome utente, il nome visualizzato e così via.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Panel1.Visible Then

            If (Trim(ServerTextBox.Text) = String.Empty) And (Trim(DatabaseTextBox.Text) = String.Empty) _
                And (Trim(IdTextBox.Text) = String.Empty) _
                And (Trim(PassTextBox.Text) = String.Empty) _
                And (ProviderDatiComboBox.SelectedItem.ToString = String.Empty) Then
                MsgBox("Se il pannello di connessione viene lasciato aperto, compilare tutti i campi.")
                Exit Sub
            End If

            My.Settings.server = Trim(ServerTextBox.Text)
            My.Settings.user = Trim(IdTextBox.Text)
            My.Settings.pass = Trim(PassTextBox.Text)
            My.Settings.Database = Trim(DatabaseTextBox.Text)
            My.Settings.tipodb = ProviderDatiComboBox.SelectedItem.ToString
            My.Settings.Save()
            Try
                serializzatore.MakeConnectionString(True)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            End Try
        Else
            Try
                serializzatore.MakeConnectionString(True)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            End Try
        End If
        'My.MySettings.Default.Item("fatturazioneGevenConnectionString") = connectionstring
        'My.MySettings.Default.Save()
        If Not (UserTextBox.Text = "") And Not (PasswordTextBox.Text = "") Then
            Dim reslogin
            Try
                reslogin = AccountutenteTableAdapter.GetData()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            End Try
            Dim servApp As New Services
            'MsgBox(My.Settings.fatturazionegevenConnectionString.ToString)
            Dim usrpass = servApp.SelectAccount(reslogin, Trim(UserTextBox.Text))

            If usrpass.ToList.Count = 1 Then 'se ce l'utente

                If Trim(PasswordTextBox.Text) = usrpass.ToList.Item(0).ToString Then 'se la pass ricava è identica alla digitata

                    Dim usrlvl = servApp.SelectAccount(reslogin, Trim(UserTextBox.Text), usrpass.ToList.Item(0).ToString)
                    'creo l'oggetto accounInfo atrtaverso il metodo getAccounData e lo valorizzo
                    serializzatore.GetAccountData(Trim(UserTextBox.Text), usrpass.ToList.Item(0).ToString, usrlvl.ToList.Item(0))

                Else 'altrimenti pass errata

                    MsgBox(serializzatore.Messaggi.passErrata)
                    Exit Sub

                End If

            Else 'altrimenti user errato

                MsgBox(serializzatore.Messaggi.userErrato)
                Exit Sub

            End If

            If Not IsNothing(serializzatore.GlobalObjAccountInfo) Then

                Me.Hide()
                MDIParent1.ShowDialog()
                Me.Close()
                Me.Dispose()

            End If

        Else

            MsgBox("I campi User e Password non possono essere vuoti.")

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FatturazionegevenDataSet.accountutente'. È possibile spostarla o rimuoverla se necessario.
        'Me.AccountutenteTableAdapter.Fill(Me.FatturazionegevenDataSet.accountutente)
        With ProviderDatiComboBox
            .Items.Add("MySQL")
        End With
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub
End Class
