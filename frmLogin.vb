Imports System.Data.SqlClient
Public Class frmLogin

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoMySql
    Dim campo As DataTable
    Dim linha As DataRow
    Dim acesso As New Login

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtUsuario.Text = "" Then
            MsgBox("Por favor, preencha o campo Usuario", MsgBoxStyle.Information, "INFORMAÇÃO")
            txtUsuario.Focus()
            Exit Sub
        ElseIf txtSenha.Text = "" Then
            MsgBox("Por favor, preencha o campo Senha", MsgBoxStyle.Information, "INFORMAÇÃO")
            txtSenha.Focus()
            Exit Sub
        Else
            Try
                acesso.usuario = txtUsuario.Text
                acesso.senha = txtSenha.Text
                ds = acesso.ConsultarUsuario()

                campo = ds.Tables(0)
                'Verifica se houve resultados na consulta 16565
                If campo.Rows.Count > 0 Then

                    linha = ds.Tables(0).Rows(0)

                    If linha(3) = "admin" Then
                        MessageBox.Show("Dados corretos!", "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmMenu.lblUsuario.Text = linha(1)
                        frmMenu.lblNivel.Text = "ADMINISTRADOR"
                        frmMenu.Show()
                        Me.Hide()

                    Else
                        frmMenu.lblUsuario.Text = linha(1)
                        frmMenu.lblNivel.Text = "USUÁRIO"
                        frmMenu.Show()
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Usuário ou senha estão incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("ERRO ao consultar!" & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class