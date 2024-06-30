Imports System.Data.SqlClient
Public Class Form_Login

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim campo As DataTable
    Dim linha As DataRow
    Dim acesso As New Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtUsuario.Text = "" Then
            MsgBox("Por favor, preencha o campo Usuario", MsgBoxStyle.Information, "INFORMAÇÃO")
            txtUsuario.Focus()
            Exit Sub
        End If

        If txtSenha.Text = "" Then
            MsgBox("Por favor, preencha o campo Senha", MsgBoxStyle.Information, "INFORMAÇÃO")
            txtSenha.Focus()
            Exit Sub
        End If


    End Sub
    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        'Try
        '    Using cn = New SqlConnection(strCon)
        '        cn.Open()
        '        Dim sql = "SELECT CodCli, ISNULL(NomeCliente, ''), ISNULL(Endereco, '') ,ISNULL(Referencia, ''), ISNULL(Bairro, ''), ISNULL(CEP, ''), ISNULL(Cidade, ''), ISNULL(UF, ''), ISNULL(Site, ''), ISNULL(CNPJ, 0), ISNULL(INSC, ''), ISNULL(CPF_RG, ''), ISNULL(RG, ''), ISNULL(RazaoSocial, '') from Tbl_CadCli"
        '        Using da = New SqlDataAdapter(sql, cn)
        '            Using dt = New DataTable()
        '                da.Fill(dt)
        '                acesso.usuario = txtUsuario.Text
        '                acesso.senha = txtSenha.Text
        '                ds = acesso.ConsularUsuario()
        '            End Using
        '        End Using
        '    End Using
        'Catch ex As Exception
        '    MsgBox("Não foi possível realizar a consulta!" & vbCrLf & ex.Message)
        '    Exit Sub
        'End Try
        'Try


        '    acesso.usuario = txtUsuario.Text
        '    acesso.senha = txtSenha.Text
        '    ds = acesso.ConsularUsuario()

        '    campo = ds.Tables(0)
        '    'Verifica se houve resultados na consulta
        '    If campo.Rows.Count > 0 Then

        '        linha = ds.Tables(0).Rows(0)

        '        If linha(3) = "administrador" Then
        '            ' MsgBox("Usuário e senha estão corretos!")
        '            Form_Menu.lblUsuario.Text = linha(1)
        '            Form_Menu.lblNivel.Text = "ADMINISTRADOR"
        '            Form_Menu.Show()
        '            Me.Hide()

        '        Else
        '            Form_Menu.lblUsuario.Text = linha(1)
        '            Form_Menu.lblNivel.Text = "USUÁRIO"
        '            Form_Menu.menu.Enabled = False
        '            Form_Menu.Show()
        '            Me.Hide()


        '        End If



        '    Else
        '        MsgBox("Usuário ou senha estão incorretos!")

        '    End If





        'Catch ex As Exception
        '    MsgBox("ERRO ao verificar os dados no banco!", MsgBoxStyle.Critical, "ERRO")

        'End Try


    End Sub
End Class