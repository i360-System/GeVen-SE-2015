Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

<Serializable()> _
Public Class campi
    Private Sub x(ByVal nomecampodelform As String)

    End Sub
    Private _Azienda = "azienda"
    Public ReadOnly Property Azienda As String
        Get
            Return _Azienda
        End Get
    End Property

    Private _Esercizio = "esercizio"
    Public ReadOnly Property Esercizio As String
        Get
            Return _Esercizio
        End Get
    End Property

    Private _TipiDocumento = "tipodocumento"
    Public ReadOnly Property TipiDocumento As String
        Get
            Return _TipiDocumento
        End Get
    End Property

    Private _NumeroDocumento = "numero"
    Public ReadOnly Property NumeroDocumento As String
        Get
            Return _NumeroDocumento
        End Get
    End Property
    Private _SiglaOperatore = "sigla"
    Public ReadOnly Property SiglaOperatore As String
        Get
            Return _SiglaOperatore
        End Get
    End Property
    Private _Cliente = "anagrafica"
    Public ReadOnly Property Cliente As String
        Get
            Return _Cliente
        End Get
    End Property
    Private _DataDocumento = "datadocumento"
    Public ReadOnly Property DataDocumento As String
        Get
            Return _DataDocumento
        End Get
    End Property
    Private _Riferimento = "riferimento"
    Public ReadOnly Property Riferimento As String
        Get
            Return _Riferimento
        End Get
    End Property
    Private _Agente = "agente"
    Public ReadOnly Property Agente As String
        Get
            Return _Agente
        End Get
    End Property
    Private _Iva = "iva"
    Public ReadOnly Property Iva As String
        Get
            Return _Iva
        End Get
    End Property


    Private _Pagamento = "pagamento"
    Public ReadOnly Property Pagamento As String
        Get
            Return _Pagamento
        End Get

    End Property


    Private _Sconto = "sconto"
    Public ReadOnly Property Sconto As String
        Get
            Return _Sconto
        End Get

    End Property

    Private _Destinazione = "destinazione"
    Public ReadOnly Property Destinazione As String
        Get
            Return _Destinazione
        End Get

    End Property

    Private _Imponibile As String = "imponibile1"
    Public ReadOnly Property Imponibile As String
        Get
            Return _Imponibile
        End Get

    End Property

    Private _Peso As String = "peso"
    Public ReadOnly Property Peso As String
        Get
            Return _Peso
        End Get
    End Property

    Private _CodiceIva As String = "codiceiva1"
    Public ReadOnly Property CodiceIva As String
        Get
            Return _CodiceIva
        End Get

    End Property

    Private _TotMerce As String = "totalemerce"
    Public ReadOnly Property TotMerce As String
        Get
            Return _TotMerce
        End Get

    End Property

    Private _OraTrasporto As String = "oratrasporto"
    Public ReadOnly Property OraTrasporto As String
        Get
            Return _OraTrasporto
        End Get
    End Property

    Private _PercSconto As String = "scontocassa"
    Public ReadOnly Property PercSconto As String
        Get
            Return _PercSconto
        End Get
    End Property

    Private _AspettoBeni As String = "aspettobeni"
    Public ReadOnly Property AspettoBeni As String
        Get
            Return _AspettoBeni
        End Get
    End Property

    Private _Data As String = "datatrasporto"
    Public ReadOnly Property Data As String
        Get
            Return _Data
        End Get
    End Property

    Private _TrasportoMezzo As String = "trasportomezzo"
    Public ReadOnly Property TrasportoMezzo As String
        Get
            Return _TrasportoMezzo
        End Get
    End Property


    Private _Corriere As String = "vettore"
    Public ReadOnly Property Corriere As String
        Get
            Return _Corriere
        End Get
    End Property

    Private _Porto As String = "porto"
    Public ReadOnly Property Porto As String
        Get
            Return _Porto
        End Get
    End Property

    Private _Colli As String = "colli"
    Public ReadOnly Property Colli As String
        Get
            Return _Colli
        End Get
    End Property

    Private _CausaleTrasporto As String = "causaletrasporto"
    Public ReadOnly Property CausaleTrasporto As String
        Get
            Return _CausaleTrasporto
        End Get
    End Property

    Private _Imballo As String = "imballo"
    Public ReadOnly Property Imballo As String
        Get
            Return _Imballo
        End Get
    End Property

    Private _Trasporto As String = "trasporto"
    Public ReadOnly Property Trasporto As String
        Get
            Return _Trasporto
        End Get
    End Property

    Private _Agenzia As String = "agenzia"
    Public ReadOnly Property Agenzia As String
        Get
            Return _Agenzia
        End Get
    End Property

    Private _Banca As String = "banca"
    Public ReadOnly Property Banca As String
        Get
            Return _Banca
        End Get
    End Property

    Private _Provincia As String = "provinciadestinatario"
    Public ReadOnly Property Provincia As String
        Get
            Return _Provincia
        End Get
    End Property

    Private _Localita As String = "localitadestinatario"
    Public ReadOnly Property Localita As String
        Get
            Return _Localita
        End Get
    End Property

    Private _CAP As String = "capdestinatario"
    Public ReadOnly Property CAP As String
        Get
            Return _CAP
        End Get
    End Property

    Private _Destinazione3 As String = "indirizzodestinatario"
    Public ReadOnly Property Destinazione3 As String
        Get
            Return _Destinazione3
        End Get
    End Property


    Private _Destinazione2 As String = "nominativodestinatario"
    Public ReadOnly Property Destinazione2 As String
        Get
            Return _Destinazione2
        End Get
    End Property


    Private _PercIva As String = "%iva1"
    Public ReadOnly Property PercIva As String
        Get
            Return _PercIva
        End Get
    End Property

    Private _ImportoIva As String = "importoiva1"
    Public ReadOnly Property ImportoIva As String
        Get
            Return _ImportoIva
        End Get
    End Property

    Private _CodiceIva2 As String = "codiceiva2"
    Public ReadOnly Property CodiceIva2 As String
        Get
            Return _CodiceIva2
        End Get
    End Property

    Private _Imponibile2 As String = "imponibile2"
    Public ReadOnly Property Imponibile2 As String
        Get
            Return _Imponibile2
        End Get
    End Property

    Private _PercIva2 As String = "%iva2"
    Public ReadOnly Property PercIva2 As String
        Get
            Return _PercIva2
        End Get
    End Property

    Private _ImportoIva2 As String = "importoiva2"
    Public ReadOnly Property ImportoIva2 As String
        Get
            Return _ImportoIva2
        End Get
    End Property

    Private _TotProvigioni As String = "totaleprovvigioni"
    Public ReadOnly Property TotProvvigioni As String
        Get
            Return _TotProvigioni
        End Get
    End Property

    Private _S1 As String = "testdocumento"
    Public ReadOnly Property S1 As String
        Get
            Return _S1
        End Get
    End Property

    Private _S2 As String = "testprocedura"
    Public ReadOnly Property S2 As String
        Get
            Return _S2
        End Get
    End Property

    Private _S3 As String = "movimentocontabile"
    Public ReadOnly Property S3 As String
        Get
            Return _S3
        End Get
    End Property

    Private _TotDocumento As String = "totaledocumento"
    Public ReadOnly Property TotDocumento As String
        Get
            Return _TotDocumento
        End Get
    End Property

    Private _Divisa As String = "divisa"
    Public ReadOnly Property Divisa As String
        Get
            Return _Divisa
        End Get
    End Property

    Private _riga As String = "riga"
    Public ReadOnly Property riga As String
        Get
            Return _riga
        End Get
    End Property

    Private _articolo As String = "articolo"
    Public ReadOnly Property articolo As String
        Get
            Return _articolo
        End Get
    End Property

    Private _descrizione As String = "descrizione"
    Public ReadOnly Property descrizione As String
        Get
            Return _descrizione
        End Get
    End Property

    Private _unitamisuramnagazzino As String = "unitamisuramnagazzino"
    Public ReadOnly Property unitamisuramnagazzino As String
        Get
            Return _unitamisuramnagazzino
        End Get
    End Property

    Private _quantitamagazzino As String = "quantitamagazzino"
    Public ReadOnly Property quantitamagazzino As String
        Get
            Return _quantitamagazzino
        End Get
    End Property

    Private _unitamisurafatturazione As String = "unitamisura"
    Public ReadOnly Property unitamisurafatturazione As String
        Get
            Return _unitamisurafatturazione
        End Get
    End Property

    Private _quantitafatturazione As String = "quantita"
    Public ReadOnly Property quantitafatturazione As String
        Get
            Return _quantitafatturazione
        End Get
    End Property

    Private _prezzo As String = "prezzounitario"
    Public ReadOnly Property prezzo As String
        Get
            Return _prezzo
        End Get
    End Property

    Private _percentuale As String = "sconto1"
    Public ReadOnly Property percentuale As String
        Get
            Return _percentuale
        End Get
    End Property

    Private _percentuale2 As String = "sconto2"
    Public ReadOnly Property percentuale2 As String
        Get
            Return _percentuale2
        End Get
    End Property

    Private _percentuale3 As String = "sconto3"
    Public ReadOnly Property percentuale3 As String
        Get
            Return _percentuale3
        End Get
    End Property

    Private _importo As String = "importo"
    Public ReadOnly Property importo As String
        Get
            Return _importo
        End Get
    End Property

    Private _iva1 As String = "iva1"
    Public ReadOnly Property iva1 As String
        Get
            Return _iva1
        End Get
    End Property

    Private _scorporo As String = "scorporo"
    Public ReadOnly Property scorporo As String
        Get
            Return _scorporo
        End Get
    End Property


    Private _classemerceologica As String = "classemerceologica"
    Public ReadOnly Property classemerceologica As String
        Get
            Return _classemerceologica
        End Get
    End Property


    Private _contropartita As String = "classecontropartita"
    Public ReadOnly Property contropartita As String
        Get
            Return _contropartita
        End Get
    End Property

    Private _percentualeprovigioni As String = "percentoprovvigioni"
    Public ReadOnly Property percentualeprovigioni As String
        Get
            Return _percentualeprovigioni
        End Get
    End Property

    Private _aliax As String = "articoloalias"

    Public ReadOnly Property aliax As String
        Get
            Return _aliax
        End Get
    End Property

    Private _magazzino As String = "movimentomagazzino"
    Public ReadOnly Property magazzino As String
        Get
            Return _magazzino
        End Get
    End Property


End Class
