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





End Module
