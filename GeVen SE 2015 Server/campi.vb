Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

<Serializable()> _
Public Class campi
    Private Sub x(ByVal nomecampodelform As String)

    End Sub

    Private _ComboBoxAzienda = "azienda"
    Public ReadOnly Property ComboBoxAzienda As String
        Get
            Return _ComboBoxAzienda
        End Get
    End Property

    Private _ComboBoxEsercizio = "esercizio"
    Public ReadOnly Property ComboBoxEsercizio As String
        Get
            Return _ComboBoxEsercizio
        End Get
    End Property

    Private _ComboBoxTipiDocumento = "tipodocumento"
    Public ReadOnly Property ComboBoxTipiDocumento As String
        Get
            Return _ComboBoxTipiDocumento
        End Get
    End Property

    Private _TextBoxNumeroDocumento = "numero"
    Public ReadOnly Property TextBoxNumeroDocumento As String
        Get
            Return _TextBoxNumeroDocumento
        End Get
    End Property
    Private _TextBoxSiglaOperatore = "sigla"
    Public ReadOnly Property TextBoxSiglaOperatore As String
        Get
            Return _TextBoxSiglaOperatore
        End Get
    End Property
    Private _ComboBoxCliente = "anagrafica"
    Public ReadOnly Property ComboBoxCliente As String
        Get
            Return _ComboBoxCliente
        End Get
    End Property
    Private _TextBoxDataDocumento = "datadocumento"
    Public ReadOnly Property TextBoxDataDocumento As String
        Get
            Return _TextBoxDataDocumento
        End Get
    End Property
    Private _TextBoxRiferimento = "riferimento"
    Public ReadOnly Property TextBoxRiferimento As String
        Get
            Return _TextBoxRiferimento
        End Get
    End Property
    Private _ComboBoxAgente = "agente"
    Public ReadOnly Property ComboBoxAgente As String
        Get
            Return _ComboBoxAgente
        End Get
    End Property
    Private _ComboBoxIva = "iva"
    Public ReadOnly Property ComboBoxIva As String
        Get
            Return _ComboBoxIva
        End Get
    End Property


    Private _ComboBoxPagamento = "pagamento"
    Public ReadOnly Property ComboBoxPagamento As String
        Get
            Return _ComboBoxPagamento
        End Get

    End Property


    Private _TextBoxSconto = "sconto"
    Public ReadOnly Property TextBoxSconto As String
        Get
            Return _TextBoxSconto
        End Get

    End Property

    Private _ComboBoxDestinazione = "destinazione"
    Public ReadOnly Property ComboBoxDestinazione As String
        Get
            Return _ComboBoxDestinazione
        End Get

    End Property

    Private _TextBoxImponibile As String = "imponibile1"
    Public ReadOnly Property TextBoxImponibile As String
        Get
            Return _TextBoxImponibile
        End Get

    End Property

    Private _TextBoxPeso As String = "peso"
    Public ReadOnly Property TextBoxPeso As String
        Get
            Return _TextBoxPeso
        End Get
    End Property

    Private _ComboBoxCodiceIva As String = "codiceiva1"
    Public ReadOnly Property ComboBoxCodiceIva As String
        Get
            Return _ComboBoxCodiceIva
        End Get

    End Property

    Private _TextBoxTotMerce As String = "totalemerce"
    Public ReadOnly Property TextBoxTotMerce As String
        Get
            Return _TextBoxTotMerce
        End Get

    End Property

    Private _TextBoxOraTrasporto As String = "oratrasporto"
    Public ReadOnly Property TextBoxOraTrasporto As String
        Get
            Return _TextBoxOraTrasporto
        End Get
    End Property

    Private _TextBoxPercSconto As String = "scontocassa"
    Public ReadOnly Property TextBoxPercSconto As String
        Get
            Return _TextBoxPercSconto
        End Get
    End Property

    Private _ComboBoxAspettoBeni As String = "aspettobeni"
    Public ReadOnly Property ComboBoxAspettoBeni As String
        Get
            Return _ComboBoxAspettoBeni
        End Get
    End Property

    Private _TextBoxData As String = "datatrasporto"
    Public ReadOnly Property TextBoxData As String
        Get
            Return _TextBoxData
        End Get
    End Property

    Private _ComboBoxTrasportoMezzo As String = "trasportomezzo"
    Public ReadOnly Property ComboBoxTrasportoMezzo As String
        Get
            Return _ComboBoxTrasportoMezzo
        End Get
    End Property


    Private _ComboBoxCorriere As String = "vettore"
    Public ReadOnly Property ComboBoxCorriere As String
        Get
            Return _ComboBoxCorriere
        End Get
    End Property

    Private _ComboBoxPorto As String = "porto"
    Public ReadOnly Property ComboBoxPorto As String
        Get
            Return _ComboBoxPorto
        End Get
    End Property

    Private _TextBoxColli As String = "colli"
    Public ReadOnly Property TextBoxColli As String
        Get
            Return _TextBoxColli
        End Get
    End Property

    Private _ComboBoxCausaleTrasporto As String = "causaletrasporto"
    Public ReadOnly Property ComboBoxCausaleTrasporto As String
        Get
            Return _ComboBoxCausaleTrasporto
        End Get
    End Property

    Private _TextBoxImballo As String = "imballo"
    Public ReadOnly Property TextBoxImballo As String
        Get
            Return _TextBoxImballo
        End Get
    End Property

    Private _TextBoxTrasporto As String = "trasporto"
    Public ReadOnly Property TextBoxTrasporto As String
        Get
            Return _TextBoxTrasporto
        End Get
    End Property

    Private _TextBoxAgenzia As String = "agenzia"
    Public ReadOnly Property TextBoxAgenzia As String
        Get
            Return _TextBoxAgenzia
        End Get
    End Property

    Private _TextBoxBanca As String = "banca"
    Public ReadOnly Property TextBoxBanca As String
        Get
            Return _TextBoxBanca
        End Get
    End Property

    Private _TextBoxProvincia As String = "provinciadestinatario"
    Public ReadOnly Property TextBoxProvincia As String
        Get
            Return _TextBoxProvincia
        End Get
    End Property

    Private _TextBoxLocalita As String = "localitadestinatario"
    Public ReadOnly Property TextBoxLocalita As String
        Get
            Return _TextBoxLocalita
        End Get
    End Property

    Private _TextBoxCAP As String = "capdestinatario"
    Public ReadOnly Property TextBoxCAP As String
        Get
            Return _TextBoxCAP
        End Get
    End Property

    Private _TextBoxDestinazione3 As String = "indirizzodestinatario"
    Public ReadOnly Property TextBoxDestinazione3 As String
        Get
            Return _TextBoxDestinazione3
        End Get
    End Property


    Private _TextBoxDestinazione2 As String = "nominativodestinatario"
    Public ReadOnly Property TextBoxDestinazione2 As String
        Get
            Return _TextBoxDestinazione2
        End Get
    End Property


    Private _TextBoxPercIva As String = "%iva1"
    Public ReadOnly Property TextBoxPercIva As String
        Get
            Return _TextBoxPercIva
        End Get
    End Property

    Private _TextBoxImportoIva As String = "importoiva1"
    Public ReadOnly Property TextBoxImportoIva As String
        Get
            Return _TextBoxImportoIva
        End Get
    End Property

    Private _ComboBoxCodiceIva2 As String = "codiceiva2"
    Public ReadOnly Property ComboBoxCodiceIva2 As String
        Get
            Return _ComboBoxCodiceIva2
        End Get
    End Property

    Private _TextBoxImponibile2 As String = "imponibile2"
    Public ReadOnly Property TextBoxImponibile2 As String
        Get
            Return _TextBoxImponibile2
        End Get
    End Property

    Private _TextBoxPercIva2 As String = "%iva2"
    Public ReadOnly Property TextBoxPercIva2 As String
        Get
            Return _TextBoxPercIva2
        End Get
    End Property

    Private _TextBoxImportoIva2 As String = "importoiva2"
    Public ReadOnly Property TextBoxImportoIva2 As String
        Get
            Return _TextBoxImportoIva2
        End Get
    End Property

    Private _TextBoxTotProvigioni As String = "totaleprovvigioni"
    Public ReadOnly Property TextBoxTotProvvigioni As String
        Get
            Return _TextBoxTotProvigioni
        End Get
    End Property

    Private _TextBoxS1 As String = "testdocumento"
    Public ReadOnly Property TextBoxS1 As String
        Get
            Return _TextBoxS1
        End Get
    End Property

    Private _TextBoxS2 As String = "testprocedura"
    Public ReadOnly Property TextBoxS2 As String
        Get
            Return _TextBoxS2
        End Get
    End Property

    Private _TextBoxS3 As String = "movimentocontabile"
    Public ReadOnly Property TextBoxS3 As String
        Get
            Return _TextBoxS3
        End Get
    End Property

    Private _TextBoxTotDocumento As String = "totaledocumento"
    Public ReadOnly Property TextBoxTotDocumento As String
        Get
            Return _TextBoxTotDocumento
        End Get
    End Property

    Private _ComboBoxDivisa As String = "divisa"
    Public ReadOnly Property ComboBoxDivisa As String
        Get
            Return _ComboBoxDivisa
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

    Private _iva As String = "iva"
    Public ReadOnly Property iva As String
        Get
            Return _iva
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
