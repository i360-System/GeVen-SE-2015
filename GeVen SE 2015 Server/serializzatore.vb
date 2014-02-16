Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Imports System.IO
Imports System.Linq
Imports System.Data.Linq


Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing

Imports System.Text
Imports System.Reflection

'Imports System.Runtime.Serialization.Formatters.Soap 'implement soap client

Module serializzatore

    Dim ArrayCampi(,) As String = Nothing

    Public Sub serializzaDataset(ByVal obj)
        ' serialize the course information to a binary stream
        Dim fStream As New FileStream("mystream.bin", FileMode.Create)
        Try
            DoBinarySerialization(fStream, obj)
            'DoSoapSerialization(fStream, myCourse)
        Catch e As Exception

        Finally
            fStream.Close()
        End Try

    End Sub

    Private Sub DoBinarySerialization(ByVal strm As Stream, ByVal crs As Object)
        Dim bfmtr As New BinaryFormatter
        bfmtr.Serialize(strm, crs)
    End Sub


    Public Function preparacampoSelect(ByVal nomecampo As String, ByVal nomefrm As String) As String

        Dim res As String = Nothing

        Select Case nomefrm.ToLower

            Case "gestionedocumenti"
                nomecampo = "nometabella." & nomecampo
            Case ""
                nomecampo = "nometabella." & nomecampo
            Case ""
                nomecampo = "nometabella." & nomecampo

        End Select

        Return res

    End Function

    'implement soap client
    'Private Sub DoSoapSerialization(ByVal strm As Stream, ByVal crs As Course)
    '    Dim sfmtr As New SoapFormatter
    '    sfmtr.Serialize(strm, crs)
    'End Sub
    'Dim v As 

    ''' <summary>
    ''' ritorna il nomecampo sul database
    ''' </summary>
    ''' <param name="nomecampoform"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ritornacampo(ByVal nomecampoform As String) As String

        Dim res As String = Nothing


        If InStr(nomecampoform, "ComboBox") = 1 Then
            nomecampoform = "_" & nomecampoform
            Dim c As New campi
            Dim fi() As FieldInfo
            Dim ty As Type = c.GetType
            fi = ty.GetFields(BindingFlags.NonPublic Or _
                              BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.Static)
            'Return 
            For Each f In fi
                If f.Name = nomecampoform Then res = f.GetValue(c)
            Next


        ElseIf InStr(nomecampoform, "TextBox") = 1 Then

            'nomecampoform = Mid(nomecampoform, 8)
            'res = serializzatore.ritornacampo(nomecampoform)


        Else 'campigriglia

            nomecampoform = "_" & nomecampoform
            Dim c As New campi
            Dim fi() As FieldInfo
            Dim ty As Type = c.GetType
            fi = ty.GetFields(BindingFlags.NonPublic Or _
                              BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.Static)
            'Return 
            For Each f In fi
                If f.Name = nomecampoform Then res = f.GetValue(c)
            Next

        End If

        Return res

    End Function


    ''' <summary>
    ''' Preformatted Query
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure Query

#Region "Select"

        Shared selectGestioneDocumenti = "Select * from documentitestata as dt inner join documentidettaglio as dl " & _
                    "on dt.azienda = dl.azienda " & _
                    "and dt.esercizio = dl.esercizio " & _
                    "and dt.tipodocumento = dl.tipodocumento " & _
                    "and dt.numero = dl.numero "
        Shared selectAgentiRappresentanti = "Select * from agenti as ag inner join agentiprovvigioni as ap " & _
            "on ag.anagrafica = ap.anagrafica "
        Shared selectAnagrafica = "Select * from anagrafiche "
        Shared selectCambioValuta = "Select * from divise "
        Shared selectCategorieClienti = "Select * from categorie "
        Shared selectDatiAziende = "Select * from aziende "
        Shared selectDestinazioneMerce = "Select * from anagraficadestinazioni "
        Shared selectGestioneAnnuali = "Select * from esercizicontabili "
        Shared selectIva = "Select * from parametriiva "
        Shared selectModalitaPagamento = "Select * from pagamentitestata as pt inner join pagamentidettaglio as pd " & _
            "on pt.pagamento = pd.pagamento "
        Shared selectSconti = "Select * from anagraficasconti "
        Shared selectSpedizionieri = "Select * from vettori "
        Shared selectTipiDocumento = "Select * from tipidocumento "
        Shared selectZoneGeografiche = "Select * from zone "
        'Shared selectGestioneFattureDocumenti = "Select * from "
        Shared selectArticoli = "Select * from articoli as ar inner join articolimisure as am " & _
            "on as.articolo = am.articolo "
        Shared selectClassiArticolo = "Select * from classiarticolo "
        'Shared selectGenerazioneInventario = ""
        Shared selectListinoArticoli = "Select * from articolilistino "
        Shared selectMagazzini = "Select * from magazzinodenominazione "
        Shared selectMovimentiMagazzino = "Select * from magazzinomovimentitestata as mmt inner join magazzinomovimentidettaglio as mmd " & _
            "on mmt.azienda = mmd.azienda " & _
            "and mmt.esercizio = mmd.esercizio " & _
            "and mmt.movimento = mmd.movimento "
        Shared selectPrezziAcquisto = "Select * from articoliprezziacquisto "

#End Region

#Region "Insert"

        Shared insertGestioneDocumenti1 = "Insert into documentitestata " '
        Shared insertGestioneDocumenti2 = "Insert into documentidettaglio "
        Shared insertAgentiRappresentanti1 = "Insert into agenti " '
        Shared insertAgentiRappresentanti2 = "Insert into agentiproviggioni "
        Shared insertAnagrafica = "Insert into anagrafica "
        Shared insertCambioValuta = "Insert into divise "
        Shared insertCategorieClienti = "Insert into categorie "
        Shared insertDatiAziende = "Insert into aziende "
        Shared insertDestinazioneMerce = "Insert into anagraficadestinazione "
        Shared insertGestioneAnnuali = "Insert into esercizicontabili "
        Shared insertIva = "Insert into parametriiva "
        Shared insertModalitaPagamento1 = "Insert into pagamentitestata "
        Shared insertModalitaPagamento2 = "Insert into pagamentidettaglio "
        Shared insertSconti = "Insert into sconti "
        Shared insertSpedizionieri = "Insert into vettori "
        Shared insertTipiDocumento = "Insert into tipidocumento "
        Shared insertZoneGeografiche = "Insert into zone "
        'Shared insertGestioneFattureDocumenti = "Insert into"
        Shared insertArticoli1 = "Insert into articoli " '
        Shared insertArticoli2 = "Insert into articolimisure "
        Shared insertClassiArticolo = "Insert into classiarticolo "
        'Shared insertGenerazioneInventario = "Insert into"
        Shared insertListinoArticoli = "Insert into articolilistino "
        Shared insertMagazzini = "Insert into magazzinodenominazione "
        Shared insertMovimentiMagazzino1 = "Insert into magazzinomovimentitestata " '
        Shared insertMovimentiMagazzino2 = "Insert into magazzinomovimentidettaglio "
        Shared insertPrezziAcquisto = "Insert into articoliprezziacquisto "

#End Region

#Region "update"

        Shared updateGestioneDocumenti1 = "Update documentitestata "
        Shared updateGestioneDocumenti2 = "Update documentidettaglio "
        Shared updateAgentiRappresentanti1 = "Update agenti "
        Shared updateAgentiRappresentanti2 = "Update agentiproviggioni "
        Shared updateAnagrafica = "Update anagrafiche "
        Shared updateCambioValuta = "Update divise"
        Shared updateCategorieClienti = "Update categorie "
        Shared updateDatiAziende = "Update aziende "
        Shared updateDestinazioneMerce = "Update anagraficadestinazioni "
        Shared updateGestioneAnnuali = "Update esercizicontabili "
        Shared updateIva = "Update parametriiva "
        Shared updateModalitaPagamento1 = "Update pagamentitestata "
        Shared updateModalitaPagamento2 = "Update pagamentidettaglio "
        Shared updateSconti = "Update anagraficasconti "
        Shared updateSpedizionieri = "Update vettori "
        Shared updateTipiDocumento = "Update tipidocumento "
        Shared updateZoneGeografiche = "Update zone "
        'Shared updateGestioneFattureDocumenti = ""
        Shared updateArticoli1 = "Update articoli "
        Shared updateArticoli2 = "Update articolimisure "
        Shared updateClassiArticolo = "Update classiarticolo "
        'Shared updateGenerazioneInventario = ""
        Shared updateListinoArticoli = "Update articolilistino "
        Shared updateMagazzini = "Update magazzinodenominazione "
        Shared updateMovimentiMagazzino1 = "Update magazzinomovimentitestata "
        Shared updateMovimentiMagazzino2 = "Update magazzinomovimentidettaglio "
        Shared updatePrezziAcquisto = "Update articoliprezziacquisto "

#End Region

#Region "delete"

        Shared deleteGestioneDocumenti1 = "Delete from documentitestata "
        Shared deleteGestioneDocumenti2 = "Delete from documentidettaglio "
        Shared deleteAgentiRappresentanti1 = "Delete from agenti "
        Shared deleteAgentiRappresentanti2 = "Delete from agentiprovvigioni "
        Shared deleteAnagrafica = "Delete from anagrafiche "
        Shared deleteCambioValuta = "Delete from divise "
        Shared deleteCategorieClienti = "Delete from categorie "
        Shared deleteDatiAziende = "Delete from aziende "
        Shared deleteDestinazioneMerce = "Delete from anagraficadestinazioni "
        Shared deleteGestioneAnnuali = "Delete from esercizicontabili "
        Shared deleteIva = "Delete from parametriiva "
        Shared deleteModalitaPagamento1 = "Delete from pagamentitestata "
        Shared deleteModalitaPagamento2 = "Delete from pagamentidettaglio "
        Shared deleteSconti = "Delete from anagraficasconti "
        Shared deleteSpedizionieri = "Delete from vettori "
        Shared deleteTipiDocumento = "Delete from tipidocumento "
        Shared deleteZoneGeografiche = "Delete from zone "
        'Shared deleteGestioneFattureDocumenti = ""
        Shared deleteArticoli1 = "Delete from articoli "
        Shared deleteArticoli2 = "Delete from articolimisure "
        Shared deleteClassiArticolo = "Delete from classiarticolo "
        'Shared deleteGenerazioneInventario = ""
        Shared deleteListinoArticoli = "Delete from articolilistino "
        Shared deleteMagazzini = "Delete from magazzinodenominazione "
        Shared deleteMovimentiMagazzino1 = "Delete from magazzinomovimentitestata "
        Shared deleteMovimentiMagazzino2 = "Delete from magazzinomovimentidettaglio "
        Shared deletePrezziAcquisto = "Delete from articoliprezziacquisto "

        ' Shared deleteDocumentiTestata1
        'Shared selectAgentiRappresentanti = ""
        'Shared selectAnagrafica = ""
        'Shared selectCambioValuta = ""
        'Shared selectCategorieClienti = ""
        'Shared selectDatiAziende = ""
        'Shared selectDestinazioneMerce = ""
        'Shared selectGestioneAnnuali = ""
        'Shared selectIva = ""
        'Shared selectModalitaPagamento = ""
        'Shared selectSconti = ""
        'Shared selectSpedizionieri = ""
        'Shared selectTipiDocumento = ""
        'Shared selectZoneGeografiche = ""
        'Shared selectGestioneFattureDocumenti = ""
        'Shared selectArticoli = ""
        'Shared selectClassiArticolo = ""
        'Shared selectGenerazioneInventario = ""
        'Shared selectListinoArticoli = ""
        'Shared selectMagazzini = ""
        'Shared selectMovimenti = ""
        'Shared selectPrezziAcquisto = ""

#End Region


    End Structure



End Module
