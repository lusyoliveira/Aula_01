Public Class Clientes

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao_sql

    Private log_id_ As Integer
    Public Property log_id() As Integer
        Get
            Return log_id_
        End Get
        Set(ByVal value As Integer)
            log_id_ = value
        End Set
    End Property

    Private log_nome_ As String
    Public Property log_nome() As String
        Get
            Return log_nome_
        End Get
        Set(ByVal value As String)
            log_nome_ = value
        End Set
    End Property

    Private log_usuario_ As String
    Public Property log_usuario() As String
        Get
            Return log_usuario_
        End Get
        Set(ByVal value As String)
            log_usuario_ = value
        End Set
    End Property


    Private log_senha_ As String
    Public Property log_senha() As String
        Get
            Return log_senha_
        End Get
        Set(ByVal value As String)
            log_senha_ = value
        End Set
    End Property


    Private log_cargo_ As String
    Public Property log_cargo() As String
        Get
            Return log_cargo_
        End Get
        Set(ByVal value As String)
            log_cargo_ = value
        End Set
    End Property


    Private log_tipo_ As Integer
    Public Property log_tipo() As String
        Get
            Return log_tipo_
        End Get
        Set(ByVal value As String)
            log_tipo_ = value
        End Set
    End Property


    Public Sub CadastrarCliente()

        sql = "Insert Into tbCliente(log_nome,log_usuario,log_senha, log_cargo, log_tipo)values('" & log_nome & "','" & log_usuario & "','" & log_senha & "','" & log_cargo & "'," & log_tipo & " )"
        con.Operar(sql)

    End Sub

    Public Sub ExcluirCliente()

        sql = "Delete from tbCliente Where log_id= " & log_id & ""
        con.Operar(sql)

    End Sub
    Public Function ConsultarCliente()

        sql = "Select * from tbCliente"
        ds = con.listar(sql)
        Return ds

    End Function
End Class
