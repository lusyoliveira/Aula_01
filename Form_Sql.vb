
Imports System.Data.SqlClient

Public Class Form_Sql

    Dim sql As String
    Dim ds As New DataSet
    ' Dim con As New Conexao_sql

    Dim cliente As New Cliente
    Dim tipo As New Tipo

    Private con As SqlConnection
    Private strCon As String = "Data Source=TOMAS_EDSON-PC;Initial Catalog=Aula_01;User Id=Souobom;Password=123456"
    Private adpt As SqlDataAdapter
    Private tabela As DataTable

    Dim Banco As New Conexao_sql

    Private Sub Form_Sql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaBox()

    End Sub


    Public Sub CarregaBox()


        Try

            Dim campo As DataTable = New DataTable

            ds = tipo.ConsultarTipo()
            campo = ds.Tables(0)
            txtTipo.ValueMember = "tip_id"
            txtTipo.DisplayMember = "tip_id"

            txtTipo.DataSource = campo



        Catch ex As Exception
            MsgBox("Erro ao preencher Combobox", MsgBoxStyle.Critical, "ERRO")
        End Try



    End Sub


    Private Function PreencherCombobox(consulta As String, nomeTabela As String) As Boolean
        con = New SqlConnection(strCon)
        adpt = New SqlDataAdapter(consulta, con)
        tabela = New DataTable(nomeTabela)

        Try
            con.Open()
            adpt.Fill(tabela)

            If tabela.Rows.Count > 0 Then
                txtTipo.ValueMember = "tip_id"
                txtTipo.DisplayMember = "tip_nome"
                txtTipo.DataSource = tabela.DefaultView

                ' DgvCliente.DataSource = tabela.DefaultView

            End If

        Catch ex As Exception
            MsgBox("Não foi possível se conectar ao banco de dados!" & ex.Message, MsgBoxStyle.Critical, "ERRO AO CONECTAR")
            Return False
        Finally
            con.Dispose()
            adpt.Dispose()
        End Try

        Return True
    End Function

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipo.SelectedIndexChanged

    End Sub


    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        Banco.Conectar()

        'Try
        '    Dim campo As DataTable

        '    ds = cliente.ConsultarCliente()

        '    campo = ds.Tables(0)

        '    If campo.Rows.Count > 0 Then

        '        DgvCliente.DataSource = ds.Tables(0)

        '        '  txtNome.Text = ds.Tables(0).Rows(0).Item(1)
        '    End If
        'Catch ex As Exception
        '    MsgBox("Não foi possível concluir a consulta solicitada!", MsgBoxStyle.Critical, "ERRO")
        'End Try
       



    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Try

            cliente.log_nome = txtNome1.Text
            cliente.log_cargo = txtCargo.Text
            cliente.log_usuario = txtUsuario.Text
            cliente.log_senha = txtSenha.Text
            cliente.log_tipo = txtTipo.Text

            'chama o método para gravar no banco
            cliente.CadastrarCliente()
            MsgBox("Cadastro efetuado com sucesso!", MsgBoxStyle.Information, "Sucesso")


        Catch ex As Exception
            MsgBox("Não foi possível salvar as informações no bacnco de dados!", MsgBoxStyle.Critical, "ERRO")
        End Try

      



    End Sub
End Class