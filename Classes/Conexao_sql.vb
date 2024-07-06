Imports System.Data.SqlClient

Public Class Conexao_sql

    Private con As SqlConnection
    Private adpt As SqlDataAdapter
    Private cmd As SqlCommand
    Public ds As New DataSet

    'Variável que armazena caminho do SQLServer
    Public strCon As String = "Data Source=TOMAS_EDSON-PC\SQLEXPRESS;Initial Catalog=Aula_01;User Id=Souobom;Password=123456"



    'Faz a conexão com o banco de dados
    Public Sub Conectar()


        Try

            con = New SqlConnection(strCon)
            con.Open()
            MsgBox("Conexão com SQL SERVER realizada com sucesso!", MsgBoxStyle.Information, "Conexão com Banco SQL Server 2012")
        Catch ex As Exception
            MsgBox(ex.Message & "Erro ao conectar")

        End Try
    End Sub
    'Grava os dados no banco de dados
    Public Sub Operar(ByVal sql)
        'Faz a conexão com o banco de dados SQL
        Try
            con = New SqlConnection(strCon)

        Catch ex As Exception
            MsgBox("Erro ao tentar se conectar ao banco de dados" & ex.Message, MsgBoxStyle.Information, "ERRO DE CONEXÃO COM O BANCO")
            End
        End Try


        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString, MsgBoxStyle.Critical, "Erro no método operar")
        Finally
            con.Close()
        End Try
    End Sub




    'Faz as consultas nas tabelas do banco de dados
     Public Function listar(ByVal sql As String)
        'Faz a conexão com o banco de dados SQL
        Try
            con = New SqlConnection(strCon)

        Catch ex As Exception
            MsgBox("Erro ao tentar se conectar ao banco de dados" & ex.Message, MsgBoxStyle.Information, "ERRO DE CONEXÃO COM O BANCO")
            End
        End Try

        Try
            con.Open()
            'Faz a Consulta de acordo com a String fornecida
            adpt = New SqlDataAdapter(sql, con)
            ds.Clear()

            adpt.Fill(ds)
        Catch ex As Exception
            MsgBox("Erro no método Listar" & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try

        Return ds

    End Function

End Class
