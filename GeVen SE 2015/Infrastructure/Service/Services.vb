Imports System.Text
Imports System.Reflection
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word



Public Class Services


    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    'Dim WithEvents oApp As Object.Application
   
    ''' <summary>
    ''' Raccoglie i nomi dei campi e i relativi valori per preparare la select
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <remarks></remarks>
    Public Overridable Function raccogliValori(ByRef frm As Form) As List(Of List(Of String))

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
    ''' Raccoglie i nomi dei campi e i relativi valori per preparare la select, escludendo per i campi associati al secondo parametro di ingressso
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <param name="listaesclusi"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function raccoglivalori(ByRef frm As Form, ByVal listaesclusi As List(Of List(Of String))) As List(Of List(Of String))
        Dim listaRitorno As New List(Of List(Of String))

        For Each gruppobox As Object In frm.Controls 'groupbox

            If TypeOf gruppobox Is GroupBox Then

                For Each controllo As Object In gruppobox.Controls


                    If (TypeOf controllo Is TextBox) Or (TypeOf controllo Is ComboBox) Then

                        If Not (listaesclusi.Contains(controllo)) Then
                            Dim listaCampoValore As New List(Of String)
                            listaCampoValore.Add(controllo.Name) 'nomecampo
                            listaCampoValore.Add(controllo.Text) 'valore del campo
                            listaRitorno.Add(listaCampoValore)
                        End If

                    ElseIf (TypeOf controllo Is DataGridView) Then

                        Dim numeroColonne As Byte = controllo.columns.count()
                        For i = 0 To numeroColonne - 1
                            If Not (listaesclusi.Contains(controllo)) Then
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
    ''' Restituisce la where condition della select
    ''' </summary>
    ''' <param name="valore"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function WhereConditionSelect(ByVal valore As List(Of List(Of String)))
        Dim res As String = Nothing
        If valore.Count > 0 Then 'gestiamo l'eventuale where condition
            For Each campoevalore In valore

                res &= Me.ritornacampo(campoevalore(0).ToString) & " = " & campoevalore(1).ToString

                If valore.IndexOf(campoevalore) = valore.IndexOf(valore.Last) Then
                    Exit For
                Else
                    res &= " and "
                End If

            Next
        End If
        Return res
    End Function

    Public Function RicalcolaImportoFinale(ByVal righeGriglia As DataGridViewRowCollection, ByVal sconto As Single, ByVal imballo As Double, ByVal trasporto As Double, ByVal data As DataTable) As ParametriIvaDiRitorno
        Dim tabella = data
        Dim quantitamagazzinoTot As Double = 0
        Dim imponibile1 As Double = 0 : Dim imponibile2 As Double = 0
        Dim IvadiRiferimento1 As String = Nothing
        Dim IvadiRiferimento2 As String = Nothing
        Dim TotImporti As Double = 0
        Dim scontoCassaImporto As Double = 0
        Dim spese As Double = 0
        Dim TotDocumento As Double = 0
        Try

            For Each riga As DataGridViewRow In righeGriglia
                If (Not riga.Cells("ArticoloComboBoxColumn").Value = String.Empty) And (Not IsNothing(riga.Cells("ImportoTextBoxColumn").Value)) AndAlso (Not riga.Cells("ImportoTextBoxColumn").Value = 0) Then
                    If IsNothing(IvadiRiferimento1) Then
                        IvadiRiferimento1 = riga.Cells("Iva").Value
                    End If
                    If (riga.Cells("Iva").Value = IvadiRiferimento1) Then
                        imponibile1 += riga.Cells("ImportoTextBoxColumn").Value
                    End If
                    If IsNothing(IvadiRiferimento2) And (Not IvadiRiferimento1 = riga.Cells("Iva").Value) Then
                        IvadiRiferimento2 = riga.Cells("Iva").Value
                    End If
                    If (IvadiRiferimento2 = riga.Cells("Iva").Value) Then
                        imponibile2 += riga.Cells("ImportoTextBoxColumn").Value
                    End If

                    quantitamagazzinoTot += riga.Cells("QuantitaMagazzinoTextBoxColumn").Value
                    TotImporti += riga.Cells("ImportoTextBoxColumn").Value
                End If

            Next

            If (sconto <> 0) And (Not IsNothing(sconto)) Then

                If imponibile1 <> 0 Then
                    imponibile1 = Int(0.5 + (100 * imponibile1) * (100 - sconto) / 100) / 100
                    scontoCassaImporto += Int(0.5 + (100 * imponibile1 * sconto) / 100) / 100
                End If
                If imponibile2 <> 0 Then
                    imponibile2 = Int(0.5 + (100 * imponibile2) * (100 - sconto) / 100) / 100
                    scontoCassaImporto += Int(0.5 + (100 * imponibile2 * sconto) / 100) / 100
                End If
            End If

            If (Not IsNothing(trasporto)) And (IsNumeric(trasporto)) AndAlso (trasporto <> 0) Then
                spese += trasporto
            End If
            If (Not IsNothing(imballo)) And (IsNumeric(imballo)) AndAlso (imballo <> 0) Then
                spese += imballo
            End If

            imponibile1 += spese

            Dim ret1 As EnumerableRowCollection(Of ParametriIva) = Me.distinctSelectParametriIva(data, IvadiRiferimento1)
            Dim ret2 = Nothing
            If (Not IsNothing(IvadiRiferimento2)) Then
                ret2 = Me.distinctSelectParametriIva(data, IvadiRiferimento2)
            End If
            Dim ImportoIva1 As Double = 0
            Dim ImportoIva2 As Double = 0

            If (Not IsNothing(ret1)) AndAlso (ret1.ToList.Count > 0) Then
                ImportoIva1 = Int(0.9 + (100 * imponibile1 * ret1.ElementAt(0).AliquotaIva) / 100) / 100
            End If
            If (Not IsNothing(ret2)) AndAlso (ret2.ToList.Count > 0) Then
                ImportoIva2 = Int(0.9 + (100 * imponibile2 * ret2.ElementAt(0).AliquotaIva) / 100) / 100
            End If

            TotDocumento = imponibile1 + ImportoIva1 + imponibile2 + ImportoIva2

            Dim Result As New ParametriIvaDiRitorno
            With Result
                .clean()
                .IvaRif1 = IvadiRiferimento1
                .IvaRif2 = IvadiRiferimento2
                .ScontoCassa = scontoCassaImporto
                .TotImponibile1 = imponibile1
                .TotImponibile2 = imponibile2
                .TotIva1 = ImportoIva1
                .TotIva2 = ImportoIva2
                .TotQuantitaMagazzino = quantitamagazzinoTot
                .TotDocumento = TotDocumento
                .TotImporti = TotImporti
                If (Not IsNothing(ret1)) Then
                    .aliquotaIva1 = ret1.ElementAt(0).AliquotaIva
                End If
                If (Not IsNothing(ret2)) Then
                    .aliquotaIva2 = ret2.ElementAt(0).AliquotaIva
                End If
            End With

            Return Result

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Function


    'Public Function AggiungoSetValue(ByVal campiSET As List(Of List(Of String))) As String

    'Dim res As String = ""

    '    If campiSET.Count > 0 Then

    '        For Each elem In campiSET

    '            res &= "┌" & elem(0) & "█" & elem(1) & "┘"

    '        Next

    '    End If

    '    Return res

    'End Function

    ''' <summary>
    ''' ritorna il nomecampo sul database
    ''' </summary>
    ''' <param name="nomecampoform"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ritornacampo(ByVal nomecampoform As String) As String

        Dim res As String = Nothing

        If Right(nomecampoform, 8).ToLower = "combobox" Then
            'If InStr(nomecampoform, "ComboBox") = 1 Then
            nomecampoform = "_" & Mid(nomecampoform, 1, nomecampoform.Length - 8)
            Dim c As New campi
            Dim fi() As FieldInfo
            Dim ty As Type = c.GetType
            fi = ty.GetFields(BindingFlags.NonPublic Or _
                              BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.Static)
            'Return 
            For Each f In fi
                If f.Name = nomecampoform Then res = f.GetValue(c)
            Next


        ElseIf Right(nomecampoform, 7).ToLower = "textbox" Then

            nomecampoform = "_" & Mid(nomecampoform, 1, nomecampoform.Length - 7)
            'res = serializzatore.ritornacampo(nomecampoform)
            Dim c As New campi
            Dim fi() As FieldInfo
            Dim ty As Type = c.GetType
            fi = ty.GetFields(BindingFlags.NonPublic Or _
                              BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.Static)
            'Return 
            For Each f In fi
                If f.Name = nomecampoform Then res = f.GetValue(c)
            Next

        Else 'campigriglia

            'nomecampoform = "_" & nomecampoform
            'Dim c As New campi
            'Dim fi() As FieldInfo
            'Dim ty As Type = c.GetType
            'fi = ty.GetFields(BindingFlags.NonPublic Or _
            '                  BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.Static)
            ''Return 
            'For Each f In fi
            '    If f.Name = nomecampoform Then res = f.GetValue(c)
            'Next

        End If

        Return res

    End Function


#Region "Print"
    Public Function controlloInizialeStampa() As Boolean

        Dim res As Boolean = False

        res = Not IsNothing(My.Settings.percorsotemplate) And Not IsNothing(My.Settings.percorsoOutput)

        Return res

    End Function

    Public Sub ElaboraStampe(ByRef fatGevenDataset As fatturazionegevenDataSet, ByVal name As String)

        Dim NomeFile As String

        oWord = New Word.Application
        oWord.Visible = True

        NomeFile = My.Settings.percorsotemplate & "/" & name
        oDoc = oWord.Documents.Open(NomeFile)

        oDoc.MailMerge.MainDocumentType = Word.WdMailMergeMainDocType.wdFormLetters
        'nuovo documento
        oDoc.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
        'stampante
        'oDoc.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToPrinter

        CreateMailMergeDataFile(fatGevenDataset, NomeFile)
        oDoc.MailMerge.Execute(False)

        ' Close the original form document.
        oDoc.Saved = True
        oDoc.Close(False)

        '' Release References.

        oDoc = Nothing
        oWord = Nothing

        ' Clean up temp file.
        'System.IO.File.Delete("C:\DataDoc.doc")


    End Sub
    Private Sub CreateMailMergeDataFile(ByVal fatGevenDataset As fatturazionegevenDataSet, ByVal NomeFile As String)
        Dim wrdDataDoc As New Word.Document
        Dim iCount As Integer

        ' Create a data source at C:\DataDoc.doc containing the field data.
        oDoc.MailMerge.CreateDataSource(Name:=fatGevenDataset, _
            HeaderRecord:="Cognome;Nome;Indirizzo;Città;Provincia;CodicePostale")

        'oDoc.MailMerge.CreateDataSource(Name:="C:\DataDoc.doc")
        'Se non si specificano gli headerRecord vengono inseriti i seguenti campi
        'Titolo	Nome	Cognome	Professione	Società	Indirizzo1	Indirizzo2	Città	Provincia	CodicePostale	Nazione	Telefono	TelefonoUfficio

        ' Open the file to insert data.
        wrdDataDoc = oWord.Documents.Open(NomeFile)

        'For iCount = 1 To 2
        '    wrdDataDoc.Tables.Item(1).Rows.Add()
        'Next iCount
        '"FirstName ; LastName ; Address ; City ; Country ; PostalCode"
        ' Fill in the data.
        'FillRow(wrdDataDoc, 2, "Rossi", "Fabio", _
        '      "Piazza Garibaldi, 18", "Parma", "PR", "43100")
        With wrdDataDoc.Tables.Item(1)

            ' Insert the data in the specific cell
            '.Cell(Row, 1).Range.InsertAfter(Cogn)
            '.Cell(Row, 2).Range.InsertAfter(Nom)
            '.Cell(Row, 3).Range.InsertAfter(Ind)
            '.Cell(Row, 4).Range.InsertAfter(Cit)
            '.Cell(Row, 5).Range.InsertAfter(Prov)
            '.Cell(Row, 6).Range.InsertAfter(CodP)
        End With
        wrdDataDoc.Save()
        wrdDataDoc.Close(False)
    End Sub

    Private Sub FillRow(ByVal Doc As Word.Document, ByVal Row As Integer, _
    ByVal Cogn As String, ByVal Nom As String, _
    ByVal Ind As String, ByVal Cit As String, ByVal Prov As String, ByVal CodP As String)

    End Sub

    '' '' '' '' ''Dim nomecompletotemplate = My.Settings.percorsotemplate & "/" & name 'nome completo del template

    ' '' '' '' '' ''Dim wrdApp As Object
    ' '' '' '' '' ''Dim wrdDoc As Object
    ' '' '' '' '' ''Dim wrdDataDoc As Object
    ' '' '' '' '' ''Dim iCount As Integer
    '' '' '' '' ''Dim F As New fatturazionegevenDataSet

    '' '' '' '' ''Dim wd As New Word.Application
    '' '' '' '' ''Dim doc As Word.Document

    '' '' '' '' ''wd.Visible = False
    '' '' '' '' ''wd.Documents.Add("tuomodello.dot") 'CREO UN NUOVO DOCUMENTO DA MODELLO
    '' '' '' '' ''Dim start As Word.Range = wd.Selection.Range
    '' '' '' '' ''Dim searchArea As Word.Range = wd.ActiveDocument.Range

    '' '' '' '' ''For Each elem In fatGevenDataset.documentitestata
    '' '' '' '' ''    'SIMULO IL TROVA E SOSTITUISCI
    '' '' '' '' ''    searchArea.Find.ClearFormatting()
    '' '' '' '' ''    searchArea.Find.Text = "@NominativoDestinatario@" 'TESTO DA TROVARE
    '' '' '' '' ''Next

    '           "Sincerely," & vbCr & vbCr & _
    '           "Kathryn M. Hinsch" & vbCr & _
    '           "Department of Electrical Engineering" & vbCr
    'wrdSelection.TypeText(StrToAdd)

    '' Perform mail merge.
    'wrdMailMerge.Destination = _
    '           Word.WdMailMergeDestination.wdSendToNewDocument
    'wrdMailMerge.Execute(False)

    '' Create a data source at C:\DataDoc.doc containing the field data.
    'wrdDoc._Document.MailMerge.CreateDataSource(Name:=nomecompletotemplate, _
    '      HeaderRecord:="@indirizzo, @datadocumento")
    '' Open the file to insert data.
    'wrdDataDoc._Document = wrdApp.Application.Documents.Open("C:\DataDoc.doc")
    'For iCount = 1 To 2
    '    wrdDataDoc._Document.Tables.Item(1).Rows.Add()
    'Next iCount
    '' Fill in the data.

    '' Save and close the file.
    'wrdDataDoc.Save()
    'wrdDataDoc.Close(False)

    'axWord.Quit() 'quit

    Private Sub WordDocViewer(ByVal fileName As String)
        Try
            Process.Start(fileName)
        Catch
        End Try
    End Sub

#End Region

#Region "Combo add null value"

    ''' <summary>
    ''' Aggiunge in cima all'elenco un valore vuoto
    ''' </summary>
    ''' <param name="valore">valore as list of string</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ComboDataSource(ByVal valore As List(Of String)) As System.Collections.Generic.List(Of String)

        Dim res As New System.Collections.Generic.List(Of String)

        valore.Insert(0, "")
        res = valore

        Return res

    End Function

    ''' <summary>
    ''' Aggiunge un valore vuoto in cime all'elenco
    ''' </summary>
    ''' <param name="valore"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function comboDataSource(ByVal valore As List(Of Integer)) As System.Collections.Generic.List(Of String)

        Dim res As New System.Collections.Generic.List(Of String)

        valore.Insert(0, vbNull)
        For Each Valo In valore
            res.Add(Valo.ToString)
        Next
        'res = valore

        Return res

    End Function

    Public Overloads Function ComboDataSource(ByVal valore As List(Of List(Of String))) As List(Of List(Of String))

        Dim res As New List(Of List(Of String))

        For Each valo In valore

            valo.Insert(0, "")
            res.Add(valo)

        Next
        'valore.Insert(0, "")
        'res = valore

        Return res

    End Function

#End Region

#Region "Query LinQ"

    ''' <summary>
    ''' Funzione per estrarre una rowcollection di stringhe, in relazione al datatable di ingresso
    ''' </summary>
    ''' <param name="valore">Valore as Datatable</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function distinctSelect(ByVal valore As DataTable) As EnumerableRowCollection(Of String)

        Dim eSeldis As EnumerableRowCollection(Of String) = Nothing

        Try

            Select Case valore.TableName.ToLower

                Case "aziende"

                    eSeldis = From r In valore.AsEnumerable() _
                                                    Select r.Field(Of String)("Azienda") + "-" + r.Field(Of String)("Denominazione1")

                Case "anagrafiche"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of Integer)("Anagrafica") & "-" & r.Field(Of String)("Denominazione1")

                Case "articoli"

                    eSeldis = From r In valore.AsEnumerable() _
                             Select r.Field(Of String)("Articolo") & "-" & r.Field(Of String)("Denominazione")

                Case "tipidocumento"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of Integer)("TipoDocumento") & "-" & r.Field(Of String)("Descrizione") & " ■ " & r.Field(Of Integer)("TestDocumento")

                    'Case "agenti"

                    '    eSeldis = From r In valore.AsEnumerable() _
                    '              Select r.Field(Of Integer)("Anagrafica") & "-" & r.Field(Of String)("Denominazione1")

                Case "parametriiva"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of String)("SiglaIva") & "-" & r.Field(Of String)("Descrizione")

                Case "pagamentitestata"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of Integer)("Pagamento") & "-" & r.Field(Of String)("Descrizione")


                Case "causalitrasporto"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of Integer)("Causale") & "-" & r.Field(Of String)("Denominazione")

                Case "tipitrasporto"

                    eSeldis = From r In valore.AsEnumerable() _
                              Select r.Field(Of Integer)("Tipo") & "-" & r.Field(Of String)("Denominazione")

                Case "aspettobeni"

                    eSeldis = From r In valore.AsEnumerable _
                              Select r.Field(Of Integer)("Tipo") & "-" & r.Field(Of String)("Denominazione")


                Case "moditrasporto"

                    eSeldis = From r In valore.AsEnumerable() _
                             Select r.Field(Of Integer)("Modo") & "-" & r.Field(Of String)("Denominazione")

                Case "vettori"

                    eSeldis = From r In valore.AsEnumerable() _
                             Select r.Field(Of Integer)("Anagrafica") & "-" & r.Field(Of String)("Note1")

                Case "divise"

                    eSeldis = From r In valore.AsEnumerable() _
                             Select r.Field(Of String)("SiglaDivisa") & "-" & r.Field(Of Double)("CambioEuro")

                Case "anagraficadestinazioni"

                    eSeldis = From r In valore.AsEnumerable() _
                             Select r.Field(Of Integer)("Destinazione") & "-" & r.Field(Of String)("Nominativo")

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eSeldis

    End Function

    'Public Overloads Function NumericDistinctSelect(ByVal valore As DataTable) As EnumerableRowCollection(Of Integer)


    '    Dim eSeldis As EnumerableRowCollection(Of Integer) = Nothing

    '    Select Case valore.TableName.ToLower



    '    End Select

    '    Return eSeldis

    'End Function

    ''' <summary>
    ''' Funzione per estrarre una row colection, in relazione al datatable di ingresso e alla where condition
    ''' </summary>
    ''' <param name="valore">Valore as Datatable</param>
    ''' <param name="valore2">Valore2 as String, where condition</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function distinctSelect(ByVal valore As DataTable, ByVal valore2 As String) As EnumerableRowCollection(Of String)

        Dim eseldis As EnumerableRowCollection(Of String) = Nothing

        Try

            Select Case valore.TableName.ToLower

                Case "anagraficadestinazioni" 'anagraficadestinazioni

                    eseldis = From r In valore.AsEnumerable _
                            Where r.Field(Of Integer)("Anagrafica") = valore2 _
                            Select r.Field(Of Integer)("Destinazione") & "-" & r.Field(Of String)("Nominativo")

                Case "esercizicontabili"

                    eseldis = From r In valore.AsEnumerable _
                           Where r.Field(Of String)("Azienda") = valore2 _
                           Order By r.Field(Of String)("Esercizio") Descending _
                            Select r.Field(Of String)("Esercizio") & "-" & r.Field(Of String)("Descrizione")

                Case "pagamentitestata"

                    eseldis = From r In valore.AsEnumerable() _
                              Where r.Field(Of Integer)("Pagamento") = valore2 _
                              Select r.Field(Of Single)("ScontoCassa") & ""

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    ''' <summary>
    ''' Ottiene la password relativa all'account
    ''' </summary>
    ''' <param name="resLogin"></param>
    ''' <param name="us"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function SelectAccount(ByVal resLogin As DataTable, ByVal us As String) As EnumerableRowCollection(Of String)

        Dim eseldis As EnumerableRowCollection(Of String) = Nothing

        Try

            eseldis = From r In resLogin.AsEnumerable() _
               Where r.Field(Of String)("user") = us _
               Select r.Field(Of String)("password")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    ''' <summary>
    ''' Ottiene il numero massimo incrementato di uno, dalla tabella DocumentiTestata
    ''' </summary>
    ''' <param name="tabella"></param>
    ''' <param name="az"></param>
    ''' <param name="eser"></param>
    ''' <param name="tipDoc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNumeroDocumento(ByVal tabella As DataTable, ByVal az As String, ByVal eser As String, ByVal tipDoc As Integer) As Integer

        Dim eseldis As Integer = 0

        Try

            eseldis = (From r In tabella.AsEnumerable() _
                          Where r.Field(Of String)("Azienda") = az _
                          And r.Field(Of String)("Esercizio") = eser _
                          And r.Field(Of Integer)("TestDocumento") = tipDoc _
                          Select r.Field(Of Integer)("Numero")).Max

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    ''' <summary>
    ''' Ottiene il livello utente dalla tabella account
    ''' </summary>
    ''' <param name="resLogin"></param>
    ''' <param name="us"></param>
    ''' <param name="ps"></param>
    ''' <returns>as integer</returns>
    ''' <remarks></remarks>
    Public Overloads Function SelectAccount(ByVal resLogin As DataTable, ByVal us As String, ByVal ps As String) As EnumerableRowCollection(Of Integer)

        Dim eseldis As EnumerableRowCollection(Of Integer) = Nothing

        Try

            eseldis = From r In resLogin.AsEnumerable() _
               Where r.Field(Of String)("user") = us _
               And r.Field(Of String)("password") = ps _
               Select r.Field(Of Integer)("userlevel")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    Public Function AnagraficaClienteLike(ByVal datatbl As DataTable, ByVal valoreLike As String) As EnumerableRowCollection(Of String)

        Dim eseldis As EnumerableRowCollection(Of String) = Nothing

        Try

            eseldis = From r In datatbl.AsEnumerable() _
                      Where r.Field(Of String)("denominazione1").ToLower.Contains(valoreLike.ToLower) _
                      Select r.Field(Of Integer)("anagrafica") & "-" & r.Field(Of String)("denominazione1")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    ''' <summary>
    ''' Estrae i campi da anagraficadestinazione
    ''' </summary>
    ''' <param name="datatbl"></param>
    ''' <param name="anagrafica"></param>
    ''' <param name="destinazione"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function distinctSelectDestinazione(ByVal datatbl As DataTable, ByVal anagrafica As Integer, ByVal destinazione As Integer) ' As EnumerableRowCollection(Of CampiDestinazione)

        'Dim eseldis As EnumerableRowCollection(Of String) = Nothing
        'Dim eseldis As EnumerableRowCollection(Of DataRow) = Nothing

        Dim eseldis = Nothing
        Try

            eseldis = From r In datatbl.AsEnumerable _
                  Where r.Field(Of Integer)("Anagrafica") = anagrafica And r.Field(Of Integer)("Destinazione") = destinazione
            Select New CampiDestinazione With {.Nominativo = r.Field(Of String)("Nominativo"), .Indirizzo = r.Field(Of String)("Indirizzo"), .Cap = r.Field(Of String)("Cap") _
                                              , .Localita = r.Field(Of String)("Localita"), .Provincia = r.Field(Of String)("Provincia")}

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Return eseldis

    End Function

    Public Function distinctSelectAnagraficaFatturazione(ByVal datatbl As DataTable, ByVal anagrafica As Integer)

        Dim eseldis = Nothing
        Try

            eseldis = From r In datatbl.AsEnumerable _
                  Where r.Field(Of Integer)("Anagrafica") = anagrafica
            Select New PopolaCampiDaAnagrafica With {.Pagamento = r.Field(Of Integer)("Pagamento"), .Agente = r.Field(Of Integer)("Agente"), .Iva = r.Field(Of String)("Iva") _
                                              , .Banca = r.Field(Of String)("Banca"), .Agenzia = r.Field(Of String)("Agenzia")}

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Return eseldis

    End Function

    Public Function distinctSelectArticoliEmisure(ByVal dttbl As DataTable, ByVal whereCondition As String)

        Dim eseldis = Nothing

        Try

            Select Case dttbl.TableName.ToLower

                Case "articolimisure"
                    'query su articolimisure
                    eseldis = From r In dttbl.AsEnumerable() _
                    Where r.Field(Of String)("Articolo") = whereCondition
                              Select New ArticoliMisure With {.UnitaMisura = r.Field(Of String)("UnitaMisura"), .PrezzoVendita = _
                                  r.Field(Of Double)("PrezzoVendita")}


                Case "articoli"

                    eseldis = From r In dttbl.AsEnumerable() _
                              Where r.Field(Of String)("Articolo") = whereCondition
                              Select New ArticoliStrongType With {.ArticoloAlias = r.Field(Of String)("ArticoloAlias"), _
                                                                  .ClasseContropartita = r.Field(Of String)("ClasseContropartita"), _
                                                                  .ClasseMerceologica = r.Field(Of String)("ClasseMerceologica"), _
                                                                  .Denominazione = r.Field(Of String)("Denominazione"), _
                                                                  .Iva = r.Field(Of String)("Iva"), .Scorporo = r.Field(Of String)("Scorporo")}

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseldis

    End Function

    Public Function distinctSelectParametriIva(ByVal dtb As DataTable, ByVal ivaRif As String)

        Dim eseledis = Nothing

        Try

            eseledis = From r In dtb.AsEnumerable() _
                       Where r.Field(Of String)("SiglaIva") = ivaRif
                       Select New ParametriIva With {.AliquotaIva = r.Field(Of Single)("AliquotaIva"), _
                                                     .Descrizione = r.Field(Of String)("Descrizione")}

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return eseledis

    End Function

#End Region

End Class
'select anagrafica, denominazione1 from anagrafiche where denominazione1 like textboxlike.text