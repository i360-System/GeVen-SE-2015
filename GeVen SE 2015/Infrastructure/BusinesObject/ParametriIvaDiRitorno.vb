Public Class ParametriIvaDiRitorno

    Public Property TotDocumento As Double
        Get
            Return _TotDocumento
        End Get
        Set(value As Double)
            _TotDocumento = value
        End Set
    End Property
    Private _TotDocumento As Double

    Public Property TotIva1 As Double
        Get
            Return _TotIva1
        End Get
        Set(value As Double)
            _TotIva1 = value
        End Set
    End Property
    Private _TotIva1 As Double

    Public Property TotIva2 As Double
        Get
            Return _TotIva2
        End Get
        Set(value As Double)
            _TotIva2 = value
        End Set
    End Property
    Private _TotIva2 As Double

    Public Property TotImponibile1 As Double
        Get
            Return _TotImponibile1
        End Get
        Set(value As Double)
            _TotImponibile1 = value
        End Set
    End Property
    Private _TotImponibile1 As Double

    Public Property TotImponibile2 As Double
        Get
            Return _TotImponibile2
        End Get
        Set(value As Double)
            _TotImponibile2 = value
        End Set
    End Property
    Private _TotImponibile2 As Double

    Public Property IvaRif1 As String
        Get
            Return _IvaRif1
        End Get
        Set(value As String)
            _IvaRif1 = value
        End Set
    End Property
    Private _IvaRif1 As String

    Public Property IvaRif2 As String
        Get
            Return _IvaRif2
        End Get
        Set(value As String)
            _IvaRif2 = value
        End Set
    End Property
    Private _IvaRif2 As String

    Public Property ScontoCassa As Double
        Get
            Return _ScontoCassa
        End Get
        Set(value As Double)
            _ScontoCassa = value
        End Set
    End Property
    Private _ScontoCassa As Double

    Public Property TotImporti As Double
        Get
            Return _TotImporti
        End Get
        Set(value As Double)
            _TotImporti = value
        End Set
    End Property
    Private _TotImporti As Double

    Public Property TotQuantitaMagazzino As Double
        Get
            Return _TotQuantitaMagazzino
        End Get
        Set(value As Double)
            _TotQuantitaMagazzino = value
        End Set
    End Property
    Private _TotQuantitaMagazzino As Double


    Public Property aliquotaIva1 As Single
        Get
            Return _aliquotaIva1
        End Get
        Set(value As Single)
            _aliquotaIva1 = value
        End Set
    End Property
    Private _aliquotaIva1 As Single

    Public Property aliquotaIva2 As Single
        Get
            Return _aliquotaIva2
        End Get
        Set(value As Single)
            _aliquotaIva2 = value
        End Set
    End Property
    Private _aliquotaIva2 As Single

    Public Sub clean()
        _IvaRif1 = Nothing
        _IvaRif2 = Nothing
        _ScontoCassa = 0
        _TotDocumento = 0
        _TotImponibile1 = 0
        _TotImponibile2 = 0
        _TotImporti = 0
        _TotIva1 = 0
        _TotIva2 = 0
        _TotQuantitaMagazzino = 0
        _aliquotaIva1 = 0
        _aliquotaIva2 = 0
    End Sub

End Class
