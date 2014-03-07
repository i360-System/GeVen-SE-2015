Module serializzatore

    'Public comunica As Boolean = False

    ''' <summary>
    ''' Struttura con relative Query
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure comandiInvioClient

#Region "tipoDiQuery"
        Shared sel As String = "«select»"
        Shared inser As String = "«insert»"
        Shared del As String = "«delete»"
        Shared upd As String = "«update»"
        Shared sep As String = ","
#End Region

    End Structure

#Region "Metodi"

    ''' <summary>
    ''' Metodo che pulisce il testo di ogni textbox, combobox, o datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub azzeraTuttiCampi(ByRef frm As Form)

        For Each gruppobox As Object In frm.Controls 'groupbox

            If TypeOf gruppobox Is GroupBox Then
                For Each controllo As Control In gruppobox.Controls
                    If (TypeOf controllo Is TextBox) Or (TypeOf controllo Is ComboBox) Then
                        controllo.Text = Nothing
                    ElseIf (TypeOf controllo Is DataGridView) Then
                        controllo = Nothing
                    End If
                Next
            End If

        Next
    End Sub


    

    ''' <summary>
    ''' Costruttore di preSelect query, imposta la stringa da dare al server, il quale provvederà
    ''' a comporre su istruzione del client, la query select
    ''' </summary>
    ''' <param name="CampiValori"></param>
    ''' <param name="nomeTabella"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function costruttoreDiPreSelect(ByVal CampiValori As List(Of List(Of String)), ByVal nomeTabella As String) As String

        Dim queryPreSelect As String = ""

        queryPreSelect &= comandiInvioClient.sel & comandiInvioClient.sep

        queryPreSelect &= nomeTabella & comandiInvioClient.sep



        For Each lista As List(Of String) In CampiValori
            queryPreSelect &= "◄"
            For Each valore As String In lista
                queryPreSelect &= valore & "↨"
            Next
            queryPreSelect = Left(queryPreSelect, queryPreSelect.Length - 1)
            queryPreSelect &= "►"
        Next

        Return queryPreSelect

    End Function


    Public Function costruttoreDiPreUpdate(ByVal CampiValori As List(Of List(Of String)), ByVal campivaloriSET As List(Of List(Of String)), ByVal nomeTabella As String) As String

        Dim queryPreSelect As String = ""

        queryPreSelect &= comandiInvioClient.upd & comandiInvioClient.sep

        queryPreSelect &= nomeTabella & comandiInvioClient.sep



        For Each lista As List(Of String) In CampiValori
            queryPreSelect &= "◄"
            For Each valore As String In lista
                queryPreSelect &= valore & "↨"
            Next
            queryPreSelect = Left(queryPreSelect, queryPreSelect.Length - 1)
            queryPreSelect &= "►"
        Next

        For Each Lis As List(Of String) In campivaloriSET

            queryPreSelect &= "┌"
            For Each Val As String In Lis
                queryPreSelect &= Val & "█"
            Next
            queryPreSelect = Left(queryPreSelect, queryPreSelect.Length - 1)
            queryPreSelect &= "┘"
        Next


        Return queryPreSelect

    End Function

#End Region
    Public Structure stampe
        Shared pèippo = ""
    End Structure
    Public Structure Messaggi

        Shared TemplatepercorsononTrovato = "Percorso dei template non impostato."
        Shared templatenonTrovato = "Template non trovato"
    End Structure
    

   


End Module
