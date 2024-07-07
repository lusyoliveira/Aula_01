Imports MySql.Data.MySqlClient

Imports System.Data
Imports System.IO
Public Class ConexaoMySql
    'Public con As New MySqlConnection
    'Public cmd As MySqlCommand = con.CreateCommand
    'Public ds As New DataSet
    'Public da As MySqlDataAdapter = New MySqlDataAdapter(cmd)

    'Dim daImagem As MySqlDataAdapter
    'Dim dsImagem As DataSet


    'Public Sub Conectar()


    '    Try

    '        con.ConnectionString = "server=localhost;user id=root;password=;database=aula_01"
    '        con.Open()
    '    Catch ex As Exception
    '        MsgBox(ex.Message & "Erro ao conectar")

    '    End Try
    'End Sub

    'Public Sub Operar(ByVal sql)
    '    Conectar()
    '    Try
    '        cmd.CommandText = sql
    '        cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message & ex.ToString, MsgBoxStyle.Critical, "Erro no método operar")
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

    'Public Function listar(ByVal sql As String)
    '    Conectar()
    '    Try
    '        ds.Clear()
    '        cmd.CommandText = sql
    '        da.Fill(ds)
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " erro no método listar")
    '    Finally
    '        con.Close()
    '    End Try
    '    Return ds
    'End Function




End Class
