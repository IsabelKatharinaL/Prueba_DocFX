Imports System.Data
Imports BibOdoo
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

''' <summary>
''' Módulo de funciones públicas y privadas con funcionaliades de Odoo
''' </summary>
Public Module DatosOdoo

    ''' <summary>
    ''' Función pública que pide una tabla de datos a Odoo
    ''' </summary>
    ''' <param name="modelo">Modelo del que pedimos los datos</param>
    ''' <param name="listaDomain">Filtros de búsqueda</param>
    ''' <param name="listaCampos">Campos que queremos mostrar</param>
    ''' <returns>Tabla</returns>
    Public Function pideTablaOdoo(ByVal modelo As String, ByVal listaDomain As List(Of String), ByVal listaCampos As List(Of String)) As DataTable
        Return _pideTablaOdoo(modelo, listaDomain, listaCampos)
    End Function

    ''' <summary>
    ''' Función públlica que trae todos los modelos disponibles en el ERP
    ''' </summary>
    ''' <returns>Tabla</returns>
    Public Function pideModelosOdoo() As DataTable
        Return _pideModelosOdoo()
    End Function

    ''' <summary>
    ''' Función pública que pide todos los campos de un modelo de Odoo
    ''' </summary>
    ''' <param name="modelo">Modelo de Odoo</param>
    ''' <returns>Tabla</returns>
    Public Function pideCamposOdoo(ByVal modelo As String) As DataTable
        Return _pideCamposOdoo(modelo)
    End Function


    Public Function sobrescribirTabla(ByVal modelo As String, ByVal tabla As DataTable) As Boolean
        Return _sobrescribirTabla(modelo, tabla)
    End Function


    Public Function cambioMasivo(ByVal modelo As String, ByVal listaDomains As List(Of String), ByVal campo As String, ByVal valor As String) As Boolean
        Return _cambioMasivo(modelo, listaDomains, campo, valor)
    End Function


    Private Function _pasaDTaLista(ByVal dt As DataTable) As List(Of String)
        Dim lista As New List(Of String)
        For Each row As DataRow In dt.Rows
            lista.Add(row(0))
        Next
        Return lista
    End Function

    Private Function _pideTablaOdoo(modelo As String, listaDomain As List(Of String), listaCampos As List(Of String)) As DataTable
        Throw New NotImplementedException()
    End Function

    Private Function _pideModelosOdoo() As DataTable
        Throw New NotImplementedException()
    End Function

    Private Function _pideCamposOdoo(modelo As String) As DataTable
        Throw New NotImplementedException()
    End Function

    Private Function _sobrescribirTabla(modelo As String, tabla As DataTable) As Boolean
        Throw New NotImplementedException()
    End Function
    Private Function _cambioMasivo(modelo As String, listaDomains As List(Of String), campo As String, valor As String) As Boolean
        Throw New NotImplementedException()
    End Function

End Module
