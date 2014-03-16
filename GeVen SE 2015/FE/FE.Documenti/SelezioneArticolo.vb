Public Class SelezioneArticolo
    Dim Cities As New AutoCompleteStringCollection()
    

    Private Sub SelezioneArticolo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListBox1.DataSource = serializzatore.globalListaArticoliDaCaricare.listaDaCaricare
        Cities.AddRange(serializzatore.globalListaArticoliDaCaricare.listaDaCaricare.ToArray)
        With TextBox1
            .AutoCompleteCustomSource = Cities
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'If Not Trim(TextBox1.Text) = String.Empty Then
        '    Dim str As String = Trim(TextBox1.Text)


        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).ToLower = TextBox1.Text.Trim.ToLower Then

                ListBox1.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If Not ListBox1.SelectedItem.ToString = String.Empty Then
            'catturo l'articolo
            serializzatore.CaptureArticolo(ListBox1.SelectedItem.ToString)
            Me.Dispose()
        End If
    End Sub

    Private Sub ListBox1_Enter(sender As Object, e As EventArgs) Handles ListBox1.Enter
       
    End Sub

    

    Private Sub ListBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            'catturo l'articolo
            serializzatore.CaptureArticolo(ListBox1.SelectedItem.ToString)
            Me.Dispose()
        End If
    End Sub
End Class