Public Class FormData
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao

    Dim parcel As New Parcelas

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click

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
                    MsgBox("ERRO ao consultar!", MsgBoxStyle.Critical, "ERRO")
                End Try


    End Sub
End Class