Public Class frmConsultaParcelas
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoMySql
    Dim parcel As New Parcelas

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim ano, mes, dia As Integer
        Dim dr1, dr2 As Date
        Dim dinicio, dfim As String
        'Dim Parcela As String

        dr1 = txtInicio.Text
        dia = dr1.Day
        mes = dr1.Month
        ano = dr1.Year
        dinicio = ano & "-" & mes & "-" & dia

        dr2 = txtfinal.Text
        dia = dr2.Day
        mes = dr2.Month
        ano = dr2.Year
        dfim = ano & "-" & mes & "-" & dia

        Try
            ds = parcel.ConsularDatas(dinicio, dfim)
            dgvData.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("ERRO ao consultar!" & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class