Public Class Form_Menu

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim data As String

        data = DateAndTime.Now

        lblData.Text = data



    End Sub

  
    Private Sub Form_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub BarraDeProgressoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarraDeProgressoToolStripMenuItem.Click
        Form_Progresso.MdiParent = Me
        Form_Progresso.Show()
    End Sub

    Private Sub NavegaDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavegaDadosToolStripMenuItem.Click
        Navega_dados.MdiParent = Me
        Navega_dados.Show()

    End Sub
End Class