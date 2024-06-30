Public Class Teste_conexao

    Dim ds As New DataSet
    Dim abobora As New Conexao_sql_server

    Dim cliente As New Clientes

    Dim tipo As New Tipo

    Public Sub Contalinhas()

        Dim numlinhas As Integer = dgvClientes.RowCount - 1
        Dim contador As Integer = 0

        For i = 0 To numlinhas
            contador = contador + 1

            numlinhas = numlinhas + 1
        Next

        txtlinhas.Text = contador

    End Sub


    Public Sub preenchegrid()

        ' abobora.Conectar()
        Dim tabela As DataTable

        ds = cliente.CosultarClientes()
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then

            dgvClientes.DataSource = ds.Tables(0)
            Formatagrid()
            Contalinhas()

        End If


    End Sub

    Public Sub CarregaBox()


        Try

            Dim campo As DataTable = New DataTable

            ds = tipo.ConsultarTipo()
            campo = ds.Tables(0)

            If campo.Rows.Count > 0 Then

                txtTipo.ValueMember = "tip_id"
                txtTipo.DisplayMember = "tip_nome"

                txtTipo.DataSource = campo

            End If


        Catch ex As Exception
            MsgBox("Erro ao preencher Combobox", MsgBoxStyle.Critical, "ERRO")
        End Try

    End Sub

    Public Sub Formatagrid()
        With dgvClientes
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Usuário"
            .Columns(3).HeaderText = "Senha"
            .Columns(4).HeaderText = "Cargo"
            .Columns(5).HeaderText = "Tipo"
        End With
    End Sub

    Private Sub Teste_conexao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaBox()
        preenchegrid()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If txtNome.TextLength = 0 Then
            MsgBox("Por favor preencha o campo nome!")
            txtNome.Focus()
            Exit Sub
        End If

        Try
            cliente.log_nome = txtNome.Text
            cliente.log_usuario = txtUsuario.Text
            cliente.log_senha = txtSenha.Text
            cliente.log_cargo = txtCargo.Text

            If txtTipo.Text = "administrador" Then
                cliente.log_tipo = 1
            Else
                cliente.log_tipo = 1
            End If

            cliente.CadastrarCliente()
            MsgBox("As informações foram gravadas com sucesso", MsgBoxStyle.Information, "Sucesso")

            preenchegrid()


        Catch ex As Exception
            MsgBox("Não foi possível gravar as informações no banco", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub

    Private Sub dgvClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentDoubleClick
        txtCodigo.Text = dgvClientes.CurrentRow.Cells(0).Value
        txtNome.Text = dgvClientes.CurrentRow.Cells(1).Value
        txtUsuario.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtSenha.Text = dgvClientes.CurrentRow.Cells(3).Value
        txtCargo.Text = dgvClientes.CurrentRow.Cells(4).Value
        txtTipo.Text = dgvClientes.CurrentRow.Cells(5).Value
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Confrmação") = MsgBoxResult.Yes Then


                cliente.log_id = dgvClientes.CurrentRow.Cells(0).Value
                cliente.ExcluirCliente()
                MsgBox("Cliente excluído com sucesso", MsgBoxStyle.Information, "Sucesso")
                preenchegrid()


            End If


        Catch ex As Exception
            MsgBox("Erro ao Excluir!", MsgBoxStyle.Critical, "ERRO")
        End Try

    End Sub
End Class