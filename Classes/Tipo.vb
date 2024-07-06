Public Class Tipo

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao_sql



    Public Function ConsultarTipo()

        sql = "Select * from Tbusu_tipo"
        ds = con.listar(sql)
        Return ds

    End Function


End Class
