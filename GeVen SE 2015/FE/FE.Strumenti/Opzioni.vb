Public Class Opzioni

    Private Sub New()

        MyBase.New()
        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Shared Ist As Opzioni = Nothing

    Public Shared Function Istanza() As Opzioni
        If Ist Is Nothing OrElse Ist.IsDisposed = True Then
            Ist = New Opzioni
        End If
        Ist.BringToFront()
        Return Ist
    End Function

#Region "Bottoni"

    ''' <summary>
    ''' Esci
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MsgBox("Si desidera uscire?") = vbYes Then
            Me.Dispose()
        End If

    End Sub

    ''' <summary>
    ''' Salva
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        salva()
        
    End Sub

    ''' <summary>
    ''' Salva ed Esci
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        salva()
        Me.Dispose()

    End Sub

    ''' <summary>
    ''' Salva (metodo)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub salva()
        With My.Settings
            .controlloSecondi = Trim(TextBox1.Text)
            .ServerIP = Trim(TextBox2.Text)
            .porta = Trim(TextBox3.Text)
            .Save()
        End With
        MsgBox("Impostazioni salvate con successo")

    End Sub

#End Region

    
End Class