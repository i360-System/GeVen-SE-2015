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

    Public Function AggiungoSetValue(ByVal campiSET As List(Of List(Of String))) As String

        Dim res As String = ""

        If campiSET.Count > 0 Then

            For Each elem In campiSET

                res &= "┌" & elem(0) & "█" & elem(1) & "┘"

            Next

        End If

        Return res

    End Function


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



    '' '' '' '' ''searchArea.Find.Replacement.ClearFormatting()
    ' '' '' '' '' ''searchArea.Find.Replacement.Text =  'TESTO DA INSERIRE
    '' '' '' '' ''searchArea.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)

    '' '' '' '' ''wd.Visible = True
    'axWord = New Word.Application 'start
    'axWord.Visible = True

    'Dim axDoc As Word.Document 'create
    'axDoc = axWord.Documents.Add

    ''Dim axDoc As Word.Document 'open
    'axDoc = axWord.Documents.Open(My.Settings.percorsotemplate & "/" & "TemplateFatturaBlu.Doc")


    'axDoc.Activate()
    'axDoc.MailMerge.MainDocumentType = Word.WdMailMergeMainDocType.wdFormLetters
    'axDoc.MailMerge.OpenDataSource(F, axWord.WdOpenFormatAuto, False, False, False, False, , , False, , , , , , False, Word.WdMergeSubType.wdMergeSubTypeOAL)
    'axDoc.MailMerge.DataSource.FirstRecord = axWord.wdDefaultFirstRecord
    'axDoc.MailMerge.DataSource.LastRecord = axWord.wdDefaultLastRecord
    'axDoc.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
    'axDoc.MailMerge.Execute(False)

    'axDoc.SaveAs(My.Settings.percorsoOutput & "/" & F.documentitestata.DataDocumentoColumn.ToString) 'save

    'Dim oApp As Object
    'Dim oMainDoc As Object 'Word.Document
    'Dim oSel As Object 'Word.Selection
    'Dim sDBPath As String

    'oApp.Application = CreateObject("Word.Application")
    ''Start a new main document for the mail merge.
    'oMainDoc.Document = oApp.Application.Documents.Add

    'With oMainDoc.Document.MailMerge

    '    .MainDocumentType = wdFormLetters

    '    'Set up the mail merge data source to Northwind.mdb.
    '    'sDBPath = "C:\Program Files\Microsoft Office\" & _
    '    '          "OfficeXP\Samples\Northwind.mdb"
    '    .OpenDataSource(f.documentitestata)
    '    '.OpenDataSource(Name:=sDBPath, _
    '    '   SQLStatement:="SELECT * FROM [Customers]")

    '    'Add the field codes to the document to create the form letter.
    '    With .Fields
    '        oSel = oApp.Application.Selection
    '        .Add(oSel.Range, "@IntestazioneRiga1@")
    '        oSel.TypeParagraph()
    '        .Add(oSel.Range, "@DescrizioneDocumento@")
    '        oSel.TypeParagraph()
    '        .Add(oSel.Range, "@DataDocumento@")
    '        ' oSel.TypeText ", "
    '        .Add(oSel.Range, "@Numero@")
    '        oSel.TypeParagraph()
    '        oSel.TypeParagraph()
    '        'oSel.TypeText "Dear "
    '        .Add(oSel.Range, "@Anno@")
    '        'oSel.TypeText ","
    '        oSel.TypeParagraph()
    '        oSel.TypeParagraph()
    '        'oSel.TypeText " This letter is to inform you..."
    '        'oSel.TypeParagraph()
    '        'oSel.TypeParagraph()
    '        'oSel.TypeText "Sincerely, [Your Name Here]"
    '    End With
    'End With

    ''Perform the mail merge to a new document.
    'With oMainDoc.Document
    '    .MailMerge.Destination = My.Settings.percorsotemplate & "/" & "TemplateFatturaBlu.doc"
    '    .MailMerge.Execute(Pause:=False)
    'End With


    'Dim wrdSelection As Word.Selection
    'Dim wrdMailMerge As Word.MailMerge
    'Dim wrdMergeFields As Word.MailMergeFields

    'Dim StrToAdd As String

    '' Create an instance of Word  and make it visible.
    'wrdApp = CreateObject("Word.Application")
    'wrdApp.Visible = True

    '' Add a new document.

    'wrdDoc = wrdApp.Documents.Add()
    'wrdDoc.Select()

    'wrdSelection = wrdApp.Selection()
    'wrdMailMerge = wrdDoc.MailMerge()

    '' Create MailMerge Data file.
    ''CreateMailMergeDataFile()

    '' Create a string and insert it into the document.
    'StrToAdd = "For additional information regarding the " & _
    '           "Department of Electrical Engineering, " & _
    '           "you can visit our Web site at "
    'wrdSelection.TypeText(StrToAdd)
    '' Insert a hyperlink to the Web page.
    'wrdSelection.Hyperlinks.Add(Anchor:=wrdSelection.Range, _
    '   Address:="http://www.ee.stateu.tld")
    '' Create a string and insert it in the document.
    'StrToAdd = ".  Thank you for your interest in the classes " & _
    '           "offered in the Department of Electrical " & _
    '           "Engineering.  If you have any other questions, " & _
    '           "please feel free to give us a call at " & _
    '           "555-1212." & vbCr & vbCr & _
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


    Public Function ComboDataSource(ByVal valore As System.Collections.Generic.List(Of String)) As System.Collections.Generic.List(Of String)

        Dim res As New System.Collections.Generic.List(Of String)

        valore.Insert(0, "")
        res = valore

        Return res

    End Function

    ''' <summary>
    ''' Distinct select
    ''' </summary>
    ''' <param name="valore"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function distinctSelect(ByVal valore As DataTable) As EnumerableRowCollection(Of String)

        Dim eSeldis As EnumerableRowCollection(Of String) = Nothing


        Select Case valore.TableName.ToLower

            Case "aziende"

                eSeldis = From r In valore.AsEnumerable() _
                                                Select r.Field(Of String)("Azienda") ' + "-" + r.Field(Of String)("Denominazione1")


            Case "anagrafiche"

                eSeldis = From r In valore.AsEnumerable() _
                          Select r.Field(Of Integer)("Anagrafica") & "-" & r.Field(Of String)("Denominazione1")

            Case "articoli"

                eSeldis = From r In valore.AsEnumerable() _
                         Select r.Field(Of String)("Articolo")

        End Select

        Return eSeldis

    End Function

    Public Function distinctSelectList(ByVal valore As DataTable) As List(Of EnumerableRowCollection(Of String))

        Dim eSeldis As EnumerableRowCollection(Of String) = Nothing
        Dim ListeSeldis As New List(Of EnumerableRowCollection(Of String))

        Select Case valore.TableName.ToLower

            Case "aziende"

                eSeldis = From r In valore.AsEnumerable() _
                                                Select r.Field(Of String)("Azienda") ' + "-" + r.Field(Of String)("Denominazione1")
                ListeSeldis.Add(eSeldis)
                eSeldis = Nothing
                eSeldis = From r In valore.AsEnumerable() _
                          Select r.Field(Of String)("Denominazione1")
                ListeSeldis.Add(eSeldis)

            Case "anagrafiche"

                eSeldis = From r In valore.AsEnumerable() _
                          Select (r.Field(Of Integer)("Anagrafica").ToString) '& "-" & r.Field(Of String)("Denominazione1")
                ListeSeldis.Add(eSeldis)
                eSeldis = Nothing
                eSeldis = From r In valore.AsEnumerable() _
                          Select r.Field(Of String)("Denominazione1")

        End Select

        Return ListeSeldis

    End Function

End Class
