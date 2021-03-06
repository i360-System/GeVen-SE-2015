﻿Public Class WorkFlow
    Inherits Services

    ''' <summary>
    ''' Esegue le procedure preliminari di ricerca
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ricerca(ByRef frm As Object) As ObjectService

        Dim WhereCondition As String = Nothing : Dim obj As New ObjectService

        Try

            WhereCondition = Me.WhereConditionSelect(Me.raccogliValori(frm)) 'yeah! 'raccolgo eventuale where condition

            If (Not IsNothing(WhereCondition)) Or (Not WhereCondition = String.Empty) Then

                obj.VeroFalso = True
                obj.WhereCondition = WhereCondition

            Else

                obj.VeroFalso = False
                obj.WhereCondition = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not obj.VeroFalso = True Then
                obj.VeroFalso = False
            End If
        End Try

        Return obj

    End Function

    ''' <summary>
    ''' Elabora le stampe
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Print(ByRef listaTabelle As List(Of DataTable))

        Dim i As New Services
        'i.ElaboraStampe()


    End Sub


End Class
