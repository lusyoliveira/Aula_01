Public Class Navega_dados

    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao

    Dim i As Integer = 0

    Dim produto As New Produto

   

    Private Sub Navega_dados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        'Botão Primeiro
        ds = produto.consultaAlfabetica()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0

            txtCodigo.Text = ds.Tables(0).Rows(i)("cod_produto").ToString
            txtProduto.Text = ds.Tables(0).Rows(i)("produto").ToString
            TxtValor.Text = ds.Tables(0).Rows(i)("valor").ToString


        End If
   


    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        'Botão Ultimo
        ds = produto.consultaAlfabetica()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1

            txtCodigo.Text = ds.Tables(0).Rows(i)("cod_produto").ToString
            txtProduto.Text = ds.Tables(0).Rows(i)("produto").ToString
            TxtValor.Text = ds.Tables(0).Rows(i)("valor").ToString


        End If


    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click

        'Botão Próxmo
        ds = produto.consultaAlfabetica()

        If i < ds.Tables(0).Rows.Count - 1 Then
            i = i + 1

            txtCodigo.Text = ds.Tables(0).Rows(i)("cod_produto").ToString
            txtProduto.Text = ds.Tables(0).Rows(i)("produto").ToString
            TxtValor.Text = ds.Tables(0).Rows(i)("valor").ToString

        Else

            MsgBox("Fim do Arquivo!")

        End If


    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        

        'Botão Anterior
        ds = produto.consultaAlfabetica()

        If i = ds.Tables(0).Rows.Count - 1 OrElse i <> 0 Then
            i = i - 1

            txtCodigo.Text = ds.Tables(0).Rows(i)("cod_produto").ToString
            txtProduto.Text = ds.Tables(0).Rows(i)("produto").ToString
            TxtValor.Text = ds.Tables(0).Rows(i)("valor").ToString

        Else

            MsgBox("Início do Arquivo!")

        End If


    End Sub
End Class