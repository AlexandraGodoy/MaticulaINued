Imports System.Data.OleDb
Public Class Form1
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\Programación3\SegundoParcial\SistemaMtricula\basededatos\matriculaINUED(2002-2003).mdb")
        Try

            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class
