﻿Public Class frmProdutos
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoMySql
    Dim produto As New Produto
    Dim parc As New Parcelas

    Public Sub Contalinhas()
        Dim numlinhas As Integer = dgvValor.RowCount - 1
        Dim contador As Integer = 0

        For i = 0 To numlinhas
            contador = contador + 1

            numlinhas = numlinhas + 1
        Next
        lblLinhas.Text = contador
    End Sub

    Public Sub SomarValor()
        Dim valor As Double = 0

        For Each linha As DataGridViewRow In dgvValor.Rows
            valor = valor + linha.Cells(2).Value
        Next
        txtresultado.Text = FormatCurrency(valor)
    End Sub
    Public Sub Carrega_Valor()
        Try
            ds = produto.ConsularValor()
            dgvValor.DataSource = ds.Tables(0)
            Contalinhas()
            SomarValor()
        Catch ex As Exception
            MsgBox("Erro ao consultar", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Public Sub CarregaBox()
        Try
            Dim campo As DataTable = New DataTable

            ds = produto.ConsularValor()
            campo = ds.Tables(0)
            cmbproduto.ValueMember = "cod_produto"
            cmbproduto.DisplayMember = "produto"
            cmbproduto.DataSource = campo
        Catch ex As Exception
            MsgBox("Erro ao consulta tabela Produto", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Carrega_Valor()
        CarregaBox()
    End Sub

    Private Sub btnGravar_Click(sender As System.Object, e As System.EventArgs) Handles btnGravar.Click
        Try
            produto.produto = txtProduto.Text
            produto.valor = txtValor.Text.Replace(",", ".")
            produto.CadastrarValor()
            MessageBox.Show("Produto gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Carrega_Valor()
        Catch ex As Exception
            MsgBox("Não foi possível Gravar as informações no banco de dados", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtValor.TextChanged
        Utils.TextBoxMoeda(txtValor)
    End Sub

    Private Sub txtParcela_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtParcela.TextChanged
        Utils.TextBoxMoeda(txtParcela)
    End Sub
    Private Sub cmbproduto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbproduto.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        frmConsultaParcelas.Show()
    End Sub

    Private Sub btnGravaParc_Click(sender As Object, e As EventArgs) Handles btnGravaParc.Click
        Dim ano, mes, dia As Integer
        Dim dr As Date
        Dim d As String
        'Dim Parcela As String
        Try

            Dim numlinhas As Integer = dgvParcelas.RowCount - 1
            Dim cont As Integer = 0

            'Insere no banco de dados as parcelas geradas no DataGrid
            While (cont <= numlinhas)
                dr = Me.dgvParcelas.Item(1, cont).Value
                dia = dr.Day
                mes = dr.Month
                ano = dr.Year
                d = ano & "-" & mes & "-" & dia
                parc.parcela = (Me.dgvParcelas.Item(0, cont).Value)
                parc.data_parcela = d
                parc.valor_parcela = (Me.dgvParcelas.Item(2, cont).Value).Replace("R$", "").Replace(".", "").Replace(",", ".")
                parc.CadastrarParcela()
                cont = cont + 1
            End While
            MessageBox.Show("Produto gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Erro ao gravar as Parcelas no banco!", MsgBoxStyle.Information, "Sucesso")
        End Try

    End Sub

    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerar.Click
        Dim venc As DateTime = mskData.Text
        Dim ValorTotal, valorParcela As Double

        'Calcular valor de cada Parcela
        ValorTotal = txtParcela.Text
        valorParcela = FormatCurrency(ValorTotal / txtNumeroPacelas.Text)

        Try
            For i = 0 To Val(txtNumeroPacelas.Text) - 1
                Dim novaParcela As DateTime
                novaParcela = venc.AddDays(i * 30)
                If novaParcela.DayOfWeek = DayOfWeek.Sunday Then
                    novaParcela = novaParcela.AddDays(1)
                ElseIf novaParcela.DayOfWeek = DayOfWeek.Saturday Then
                    novaParcela = novaParcela.AddDays(2)
                End If
                dgvParcelas.Rows.Add(i + 1, Mid(novaParcela.ToString, 1, 10), FormatCurrency(valorParcela))
            Next
        Catch ex As Exception
            MsgBox("Erro ao calcular pagamento", MsgBoxStyle.Critical, "Atenção")
        End Try
    End Sub
End Class
