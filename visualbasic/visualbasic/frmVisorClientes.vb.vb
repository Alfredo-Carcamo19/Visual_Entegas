' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmVisorClientes
    Dim conn As New MySqlConnection

    Private Sub frmVisorClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection

        ' 1. Conectar y cargar datos
        conn = conectar()
        ' *** ¡CAMBIO AQUÍ! ***
        Dim sql As String = "SELECT id_cliente AS idcliente, nombre, direccion, telefono, email FROM clientes ORDER BY nombre"
        Dim dtClientesReales As DataTable = cargar_grid(sql, conn)

        ' 2. Crear el origen de datos
        ' *** ¡CAMBIO AQUÍ! (Debe coincidir con el nombre del DataSet en el .rdlc) ***
        Dim rds As New ReportDataSource("dsClientes", dtClientesReales)
        ' (Este nombre está en SINGULAR, igual que el error)

        ' 3. Limpiar y añadir datos al visor
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        ' 4. Mostrar
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class