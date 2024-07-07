Public Class frmMenu

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data As String

        data = DateAndTime.Now

        lblData.Text = data
    End Sub

    Private Sub BarraDeProgressoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarraDeProgressoToolStripMenuItem.Click
        frmTabuada.MdiParent = Me
        frmTabuada.Show()
    End Sub

    Private Sub NavegaDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavegaDadosToolStripMenuItem.Click
        frmNavegar.MdiParent = Me
        frmNavegar.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        frmProdutos.MdiParent = Me
        frmProdutos.Show()
    End Sub
    Private Sub TestaConexãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestaConexãoToolStripMenuItem.Click
        frmTestaConexao.MdiParent = Me
        frmTestaConexao.Show()
    End Sub

    Private Sub tsProdutos_Click(sender As Object, e As EventArgs) Handles tsProdutos.Click
        frmProdutos.MdiParent = Me
        frmProdutos.Show()
    End Sub

    Private Sub tsConsulta_Click(sender As Object, e As EventArgs) Handles tsConsulta.Click
        frmConsultaParcelas.MdiParent = Me
        frmConsultaParcelas.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class