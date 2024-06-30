Public Class Parcelas

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao


    Private cod_parcela_ As Integer
    Public Property cod_parcela() As Integer
        Get
            Return cod_parcela_
        End Get
        Set(ByVal value As Integer)
            cod_parcela_ = value
        End Set
    End Property

    Private parcela_ As Integer
    Public Property parcela() As Integer
        Get
            Return parcela_
        End Get
        Set(ByVal value As Integer)
            parcela_ = value
        End Set
    End Property


    Private data_parcela_ As String
    Public Property data_parcela() As String
        Get
            Return data_parcela_
        End Get
        Set(ByVal value As String)
            data_parcela_ = value
        End Set
    End Property

    Private valor_parcela_ As String
    Public Property valor_parcela() As String
        Get
            Return valor_parcela_
        End Get
        Set(ByVal value As String)
            valor_parcela_ = value
        End Set
    End Property

    Public Sub CadastrarParcela()

        Sql = "Insert Into parcelas(parcela,data_parcela,valor_parcela)values(" & parcela & ",'" & data_parcela & "','" & valor_parcela & "' )"
        con.Operar(Sql)

    End Sub
    'Consulta as parcelas entre as datas
    Public Function ConsularDatas(ByVal datainicio As String, ByVal datafim As String)
        sql = "Select * from parcelas where data_parcela between '" & datainicio & "' and '" & datafim & "'"
        ds = con.listar(sql)
        Return ds
    End Function

End Class
