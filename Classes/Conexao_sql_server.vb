Imports System.Data.SqlClient


Public Class Conexao_sql_server

    Public con As SqlConnection
    Public cmd As SqlCommand
    Public adpt As SqlDataAdapter
    Public ds As New DataSet
    Public strCon As String = "Data Source=TOMAS_EDSON-PC;Initial Catalog=Aula_01;User Id=joao;Password=123456"

    Public Sub Conectar()

        Try
            con = New SqlConnection(strCon)
            con.Open()
            MsgBox("Conexão Realizada com sucesso!")

        Catch ex As Exception
            MsgBox("Erro no método conectar!", MsgBoxStyle.Critical, "ERRO")
        End Try

    
    End Sub

    Public Sub Operar(ByVal sql As String)
        'Faz a conexão com o banco de dados
        con = New SqlConnection(strCon)

       


        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro no método Operar", MsgBoxStyle.Critical, "Erro")
        Finally
            con.Close()
        End Try




    End Sub



    Public Function Listar(ByVal sql As String)
        con = New SqlConnection(strCon)

        Try
            con.Open()
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
