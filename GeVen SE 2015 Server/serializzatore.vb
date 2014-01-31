Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
'Imports System.Runtime.Serialization.Formatters.Soap 'implement soap client
Imports System.IO
Module serializzatore

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

    'implement soap client
    'Private Sub DoSoapSerialization(ByVal strm As Stream, ByVal crs As Course)
    '    Dim sfmtr As New SoapFormatter
    '    sfmtr.Serialize(strm, crs)
    'End Sub
    'Dim v As 


    ''' <summary>
    ''' Preformatted Query
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure Query

#Region "Select"

        Shared selectGestioneDocumenti = "Select * from documentitestata as dt inner join documentidettaglio as dl " & _
                    "on dt.documentidettaglioazienda = dl.documentidettaglioazienda " & _
                     "on dt.documentitestataazienda = dl.documentitestataazienda " & _
                     "on dt.esercizio = dl.esercizio " & _
                    "on dt.tipodocumento = dl.tipodocumento " & _
                    "on dt.numerodocumento = dl.numerodocumento "
        Shared selectAgentiRappresentanti = ""
        Shared selectAnagrafica = ""
        Shared selectCambioValuta = ""
        Shared selectCategorieClienti = ""
        Shared selectDatiAziende = ""
        Shared selectDestinazioneMerce = ""
        Shared selectGestioneAnnuali = ""
        Shared selectIva = ""
        Shared selectModalitaPagamento = ""
        Shared selectSconti = ""
        Shared selectSpedizionieri = ""
        Shared selectTipiDocumento = ""
        Shared selectZoneGeografiche = ""
        Shared selectGestioneFattureDocumenti = ""
        Shared selectArticoli = ""
        Shared selectClassiArticolo = ""
        Shared selectGenerazioneInventario = ""
        Shared selectListinoArticoli = ""
        Shared selectMagazzini = ""
        Shared selectMovimenti = ""
        Shared selectPrezziAcquisto = ""

#End Region

#Region "Insert"

        Shared insertGestioneDocumenti
        Shared insertAgentiRappresentanti = ""
        Shared insertAnagrafica = ""
        Shared insertCambioValuta = ""
        Shared insertCategorieClienti = ""
        Shared insertDatiAziende = ""
        Shared insertDestinazioneMerce = ""
        Shared insertGestioneAnnuali = ""
        Shared insertIva = ""
        Shared insertModalitaPagamento = ""
        Shared insertSconti = ""
        Shared insertSpedizionieri = ""
        Shared insertTipiDocumento = ""
        Shared insertZoneGeografiche = ""
        Shared insertGestioneFattureDocumenti = ""
        Shared insertArticoli = ""
        Shared insertClassiArticolo = ""
        Shared insertGenerazioneInventario = ""
        Shared insertListinoArticoli = ""
        Shared insertMagazzini = ""
        Shared insertMovimenti = ""
        Shared insertPrezziAcquisto = ""

#End Region

#Region "update"

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

#Region "delete"

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
