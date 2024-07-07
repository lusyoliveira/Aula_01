Public Class frmTabuada

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lbtResultado.Text = ""
        Barra.Value = 0

        Barra.Maximum = txtQuantidade.Text


        Dim tabuada As Integer = txtTabuada.Text
        Dim resultado As Integer = 0
        Dim quantidade As Integer = txtQuantidade.Text
        Dim mensagem As String = ""

        For i = 0 To quantidade - 1 Step 1

            resultado = tabuada * (i + 1)

            mensagem = tabuada & "X" & i + 1 & "=" & resultado

            lbtResultado.Items.Add(mensagem)

            Barra.Value = Barra.Value + 1
        Next

        MsgBox("Cálculo concluído com sucesso!", MsgBoxStyle.Information, "INFORMAÇÃO")

    End Sub

    Private Sub Form_Progresso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class