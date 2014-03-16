Public Class LoginForm1

    ' TODO: inserire il codice per l'esecuzione dell'autenticazione personalizzata tramite il nome utente e la password forniti 
    ' (Vedere http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'entità personalizzata può essere quindi collegata all'entità del thread corrente nel modo seguente: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' dove CustomPrincipal è l'implementazione di IPrincipal utilizzata per eseguire l'autenticazione. 
    ' My.User restituirà quindi informazioni sull'identità incapsulate nell'oggetto CustomPrincipal,
    ' quali il nome utente, il nome visualizzato e così via.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Not (UserTextBox.Text = "") And Not (PasswordTextBox.Text = "") Then

            Dim resLogin = AccountutenteTableAdapter.GetData()
            Dim servApp As New Services
            Dim usrpass = servApp.SelectAccount(resLogin, Trim(UserTextBox.Text))

            If usrpass.ToList.Count = 1 Then 'se ce l'utente

                If Trim(PasswordTextBox.Text) = usrpass.ToList.Item(0).ToString Then 'se la pass ricava è identica alla digitata

                    Dim usrlvl = servApp.SelectAccount(resLogin, Trim(UserTextBox.Text), usrpass.ToList.Item(0).ToString)
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

    End Sub

    
End Class
