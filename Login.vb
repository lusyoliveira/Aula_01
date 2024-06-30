Public Class Login

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao

    Private cod_login_ As Integer
    Public Property cod_login() As Integer
        Get
            Return cod_login_
        End Get
        Set(ByVal value As Integer)
            cod_login_ = value
        End Set
    End Property

    Private usuario_ As String
    Public Property usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property

    Private senha_ As String
    Public Property senha() As String
        Get
            Return senha_
        End Get
        Set(ByVal value As String)
            senha_ = value
        End Set
    End Property

    Private nivel_acesso_ As String
    Public Property nivel_acesso() As String
        Get
            Return nivel_acesso_
        End Get
        Set(ByVal value As String)
            nivel_acesso_ = value
        End Set
    End Property


    Public Function ConsularUsuario()
        sql = "Select * from login where usuario='" & usuario & "' and senha='" & senha & "'"
        ds = con.listar(sql)
        Return ds
    End Function


End Class
