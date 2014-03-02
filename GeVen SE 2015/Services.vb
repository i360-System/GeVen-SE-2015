Imports System.Text
Imports System.Reflection
Public Class Services

    Public Sub RaccogliInformazioniDaiClient()

    End Sub

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
    ''' raccogli i valorei da mettere in preselect escludendo i campi presenti nella lista che gli  viene fornita come secondo parametro
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


End Class
