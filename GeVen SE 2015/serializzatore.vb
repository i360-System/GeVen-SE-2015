Module serializzatore

    Public comunica As Boolean = False

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
    ''' Raccoglie i nomi dei campi e i relativi valori per preparare la select
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Function raccogliValori(ByRef frm As Form) As List(Of List(Of String))

        Dim listaRitorno As New List(Of List(Of String))

        For Each gruppobox As Object In frm.Controls 'groupbox

            If TypeOf gruppobox Is GroupBox Then

                For Each controllo As Object In gruppobox.Controls

                    If (TypeOf controllo Is TextBox) Or (TypeOf controllo Is ComboBox) Then

                        If Not Trim(controllo.Text) = "" Then
                            Dim listaCampoValore As New List(Of String)
                            listaCampoValore.Add(controllo.Name) 'nomecampo
                            listaCampoValore.Add(controllo.Text) 'valore del campo
                            listaRitorno.Add(listaCampoValore)
                        End If

                    ElseIf (TypeOf controllo Is DataGridView) Then

                        Dim numeroColonne As Byte = controllo.columns.count()
                        For i = 0 To numeroColonne - 1
                            If Not Trim(controllo.item(i, 0).value.ToString) = "" Then
                                Dim listaCampoValore As New List(Of String)
                                listaCampoValore.Add(controllo.Columns(i).name())
                                listaCampoValore.Add(Trim(controllo.item(i, 0).value.ToString))
                                listaRitorno.Add(listaCampoValore)
                            End If
                        Next

                    End If

                Next

            End If

        Next

        Return listaRitorno

    End Function

    ''' <summary>
    ''' Costruttore di preSelect query, imposta la stringa da dare al server, il quale provvederà
    ''' a comporre su istruzione del client, la query select
    ''' </summary>
    ''' <param name="CampiValori"></param>
    ''' <param name="nomeTabella"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function costruttoreDiPreSelect(ByVal CampiValori As List(Of List(Of String)), ByVal nomeTabella As String) As String

        Dim queryPreSelect As String = "QUERY|"

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

#End Region

End Module
